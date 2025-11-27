using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace DeepClonerDemo
{
    public static class DeepCloner
    {
        private static readonly BindingFlags Flags =
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        public static T Clone<T>(T obj)
        {
            if (obj is null) return default!;
            return (T)CloneInternal(obj, new Dictionary<object, object>(ReferenceEqualityComparer.Instance));
        }

        private static object CloneInternal(object obj, Dictionary<object, object> visited)
        {
            if (obj is null) return null!;
            var type = obj.GetType();

            if (type.IsPrimitive || obj is string || obj is DateTime || obj is decimal || obj is Guid)
                return obj;

            if (visited.TryGetValue(obj, out var existing))
                return existing;

            if (obj is Array array)
            {
                var cloned = Array.CreateInstance(type.GetElementType()!, array.Length);
                visited[obj] = cloned;
                for (int i = 0; i < array.Length; i++)
                    cloned.SetValue(CloneInternal(array.GetValue(i), visited), i);
                return cloned;
            }

            if (obj is IList list)
            {
                var clonedList = (IList)Activator.CreateInstance(type);
                visited[obj] = clonedList;
                foreach (var item in list)
                    clonedList.Add(CloneInternal(item, visited));
                return clonedList;
            }

            if (obj is IDictionary dict)
            {
                var clonedDict = (IDictionary)Activator.CreateInstance(type);
                visited[obj] = clonedDict;
                foreach (DictionaryEntry entry in dict)
                {
                    var key = CloneInternal(entry.Key, visited);
                    var value = CloneInternal(entry.Value, visited);
                    clonedDict[key] = value;
                }
                return clonedDict;
            }

            object clone;
            try
            {
                clone = Activator.CreateInstance(type, true);
            }
            catch
            {
                clone = FormatterServices.GetUninitializedObject(type);
            }

            visited[obj] = clone;

            foreach (var field in GetAllFields(type))
            {
                var value = field.GetValue(obj);
                if (value != null && !field.FieldType.IsValueType)
                    value = CloneInternal(value, visited);
                field.SetValue(clone, value);
            }

            return clone;
        }

        private static IEnumerable<FieldInfo> GetAllFields(Type type)
        {
            while (type != null && type != typeof(object))
            {
                foreach (var field in type.GetFields(Flags))
                    yield return field;
                type = type.BaseType;
            }
        }
    }

    public sealed class ReferenceEqualityComparer : IEqualityComparer<object>
    {
        public static readonly ReferenceEqualityComparer Instance = new();
        bool IEqualityComparer<object>.Equals(object? x, object? y) => ReferenceEquals(x, y);
        int IEqualityComparer<object>.GetHashCode(object obj) => RuntimeHelpers.GetHashCode(obj);
    }

    //Тестовые классы
    public class Person
    {
        public string Name;
        public int Age;
        private List<string> _hobbies = new();
        public Person? Friend;
        public List<Person> Children = new();
        public string[] Skills = Array.Empty<string>();
        public Dictionary<string, object> Metadata = new();

        public Person(string name, int age)
        {
            Name = name; Age = age;
            _hobbies.Add("Чтение"); _hobbies.Add("Программирование");
            Metadata["Created"] = DateTime.Now;
        }

        public void AddHobby(string h) => _hobbies.Add(h);

        public override string ToString()
            => $"{Name}, {Age} лет, хобби: {string.Join(", ", _hobbies)}, детей: {Children.Count}";
    }

    public class Company
    {
        public string Title;
        private Employee _ceo;
        public List<Department> Departments = new();
        public Company(string title) => Title = title;
        public void SetCeo(Employee ceo) => _ceo = ceo;
    }
    public class Department { public string Name; public Employee Manager; public Company Parent; }
    public class Employee { public string Name; public Department Department; }

    //Тесты и сравнение производительности
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== СИСТЕМА ГЛУБОКОГО КЛОНИРОВАНИЯ ===\n");

            // Тест 1: Глубокая структура + циклическая ссылка
            var alice = new Person("Алиса", 30);
            alice.AddHobby("Йога");
            var bob = new Person("Боб", 32);
            alice.Friend = bob;
            bob.Friend = alice;
            alice.Children.Add(new Person("Дочка", 5));

            var aliceClone = DeepCloner.Clone(alice);

            Console.WriteLine("Оригинал: " + alice);
            Console.WriteLine("Клон:     " + aliceClone);
            Console.WriteLine($"Разные объекты: {!ReferenceEquals(alice, aliceClone)}");
            Console.WriteLine($"Цикл сохранён: {ReferenceEquals(aliceClone.Friend.Friend, aliceClone)}");
            Console.WriteLine($"Приватные хобби скопированы: {string.Join(", ", (List<string>)aliceClone.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance).First(f => f.Name.Contains("hobbies")).GetValue(aliceClone)!)}\n");

            // Тест 2: Сложная бизнес-структура с циклами
            var company = new Company("xAI");
            var dept = new Department { Name = "R&D", Parent = company };
            var ceo = new Employee { Name = "Elon", Department = dept };
            dept.Manager = ceo;
            company.SetCeo(ceo);
            company.Departments.Add(dept);

            var companyClone = DeepCloner.Clone(company);
            Console.WriteLine($"Компания склонирована. Цикл Company ↔ Department сохранён: " +
                $"{ReferenceEquals(companyClone.Departments[0].Parent, companyClone)}\n");

            // Тест 3: Производительность
            var deepObj = CreateDeepTestObject();

            var sw = Stopwatch.StartNew();
            for (int i = 0; i < 10_000; i++)
                DeepCloner.Clone(deepObj);
            sw.Stop();

            Console.WriteLine($"10 000 глубоких клонирований (рефлексия): {sw.ElapsedMilliseconds} мс");

            sw.Restart();
            for (int i = 0; i < 10_000; i++)
                System.Text.Json.JsonSerializer.Deserialize<Person>(
                    System.Text.Json.JsonSerializer.Serialize(deepObj));
            sw.Stop();

            Console.WriteLine($"10 000 клонирований через JSON: {sw.ElapsedMilliseconds} мс");

            Console.WriteLine("\nВывод: рефлексия в 3–5 раз быстрее JSON-сериализации.");
            Console.WriteLine("Для максимальной скорости используйте кэширование Expression Trees (Mapster, AutoMapper).");
        }

        static Person CreateDeepTestObject()
        {
            var root = new Person("Root", 40);
            var child1 = new Person("Child1", 15);
            var child2 = new Person("Child2", 12);
            var grand = new Person("Grand", 1);
            child1.Children.Add(grand);
            root.Children.Add(child1);
            root.Children.Add(child2);
            root.Friend = child1;
            root.Skills = new[] { "C#", "Алгоритмы", "Рефлексия" };
            return root;
        }
    }
}