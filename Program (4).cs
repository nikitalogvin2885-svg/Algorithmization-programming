using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.ComponentModel;
using CovarianceDemo;

//1
//using System;

//namespace BoxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            int value = 42;
//            object boxed = value;

//            Console.WriteLine($"Исходное значение: {value}");
//            Console.WriteLine($"Упакованное значение: {boxed}");
//            Console.WriteLine($"Тип упакованного значения: {boxed.GetType()}");

//            const int iterations = 10000000;
//            Stopwatch sw = new Stopwatch();

//            sw.Start();
//            int sum1 = 0;
//            for (int i = 0; i < iterations; i++)
//            {
//                sum1 += i;
//            }
//            sw.Stop();
//            Console.WriteLine($"Без упаковки: {sw.ElapsedMilliseconds} мс");

//            sw.Restart();
//            object sum2 = 0;
//            for (int i = 0; i < iterations; i++)
//            {
//                sum2 = (int)sum2 + i;
//            }
//            sw.Stop();
//            Console.WriteLine($"С упаковкой: {sw.ElapsedMilliseconds} мс");
//        }
//    }
//}

//2
//using System;

//namespace UnboxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            int originalValue = 100;
//            object boxed = originalValue;

//            Console.WriteLine($"Упакованное значение: {boxed}");
//            Console.WriteLine($"Тип упакованного объекта: {boxed.GetType()}");

//            if (boxed is int)
//            {
//                int unboxed = (int)boxed;
//                Console.WriteLine($"Распаковано: {unboxed}");
//                Console.WriteLine($"Тип проверен успешно: {boxed.GetType()}");
//            }
//            else
//            {
//                Console.WriteLine("Ошибка: тип не соответствует int");
//            }
//        }
//    }
//}

//3
//using System;

//namespace SafeUnboxingDemo
//{
//    class Program
//    {
//        static void SafeUnbox(object obj)
//        {
//            Console.WriteLine($"\nОбрабатываем объект типа: {obj?.GetType()?.Name ?? "null"}");

//            switch (obj)
//            {
//                case int i:
//                    Console.WriteLine($"[INT] Распакован: {i}, Квадрат: {i * i}");
//                    break;
//                case double d:
//                    Console.WriteLine($"[DOUBLE] Распакован: {d}, Округлено: {Math.Round(d)}");
//                    break;
//                case bool b:
//                    Console.WriteLine($"[BOOL] Распакован: {b}, Инверсия: {!b}");
//                    break;
//                case string s:
//                    Console.WriteLine($"[STRING] Строка: '{s}', Длина: {s.Length}");
//                    break;
//                case null:
//                    Console.WriteLine("[NULL] Передан null");
//                    break;
//                default:
//                    Console.WriteLine($"[OTHER] Неизвестный тип: {obj.GetType().Name}");
//                    break;
//            }
//        }

//        static void Main()
//        {

//            SafeUnbox(10);
//            SafeUnbox(3.14);
//            SafeUnbox(true);
//            SafeUnbox("text");
//            SafeUnbox(null);
//        }
//    }
//}

//4
//using System;
//using System.Diagnostics;
//using System.Collections;

//namespace PerformanceComparisonDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 4: Разница в производительности между упакованными и неупакованными значениями ===\n");

//            const int count = 1000000;
//            Stopwatch sw = new Stopwatch();

//            Console.WriteLine("Тест 1: Работа с массивами");
//            sw.Start();
//            int[] intArray = new int[count];
//            for (int i = 0; i < count; i++)
//            {
//                intArray[i] = i;
//            }
//            sw.Stop();
//            Console.WriteLine($"int[] (без упаковки): {sw.ElapsedMilliseconds} мс");

//            sw.Restart();
//            object[] objArray = new object[count];
//            for (int i = 0; i < count; i++)
//            {
//                objArray[i] = i;
//            }
//            sw.Stop();
//            Console.WriteLine($"object[] (с упаковкой): {sw.ElapsedMilliseconds} мс");

//            Console.WriteLine("\nТест 2: Работа с коллекциями");
//            sw.Restart();
//            ArrayList withBoxing = new ArrayList();
//            for (int i = 0; i < count; i++)
//            {
//                withBoxing.Add(i);
//            }
//            sw.Stop();
//            Console.WriteLine($"ArrayList (с упаковкой): {sw.ElapsedMilliseconds} мс");

//            sw.Restart();
//            System.Collections.Generic.List<int> withoutBoxing = new System.Collections.Generic.List<int>();
//            for (int i = 0; i < count; i++)
//            {
//                withoutBoxing.Add(i);
//            }
//            sw.Stop();
//            Console.WriteLine($"List<int> (без упаковки): {sw.ElapsedMilliseconds} мс");
//        }
//    }
//}

//using System;
//using System.Collections;
//using System.Diagnostics;

//namespace BoxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 5: ArrayList и упаковка ===\n");

//            ArrayList - нетипизированная коллекция
//           ArrayList arrayList = new ArrayList();

//            Добавление различных типов значений(происходит boxing)
//            arrayList.Add(42);              // int -> boxing
//            arrayList.Add(3.14);            // double -> boxing
//            arrayList.Add(true);            // bool -> boxing
//            arrayList.Add('A');             // char -> boxing
//            arrayList.Add(DateTime.Now);    // DateTime (struct) -> boxing
//            arrayList.Add("Hello");         // string - ссылочный тип, boxing НЕ происходит

//            Console.WriteLine("Содержимое ArrayList:");
//            foreach (object item in arrayList)
//            {
//                Console.WriteLine($"Значение: {item,-30} Тип: {item.GetType().Name}");
//            }

//            Распаковка(unboxing)
//            Console.WriteLine("\n=== Распаковка значений ===");
//            int unboxedInt = (int)arrayList[0];
//            double unboxedDouble = (double)arrayList[1];
//            bool unboxedBool = (bool)arrayList[2];

//            Console.WriteLine($"int: {unboxedInt}");
//            Console.WriteLine($"double: {unboxedDouble}");
//            Console.WriteLine($"bool: {unboxedBool}");

//            Демонстрация производительности
//            Console.WriteLine("\n=== Тест производительности ===");
//            Stopwatch sw = new Stopwatch();

//            ArrayList с boxing
//            sw.Start();
//            ArrayList list1 = new ArrayList();
//            for (int i = 0; i < 100000; i++)
//            {
//                list1.Add(i); // boxing на каждой итерации
//            }
//            sw.Stop();
//            Console.WriteLine($"ArrayList (с boxing): {sw.ElapsedMilliseconds} мс");

//            List<int> без boxing
//            sw.Restart();
//            List<int> list2 = new List<int>();
//            for (int i = 0; i < 100000; i++)
//            {
//                list2.Add(i); // boxing не происходит
//            }
//            sw.Stop();
//            Console.WriteLine($"List<int> (без boxing): {sw.ElapsedMilliseconds} мс");
//        }
//    }
//}

//6
//using System;
//using System.Collections;
//using System.Reflection;

//namespace BoxingCounterDemo
//{
//    class Program
//    {
//        static int CountBoxingOperations(ArrayList list)
//        {
//            int count = 0;
//            foreach (object item in list)
//            {
//                if (item != null && item.GetType().IsValueType)
//                {
//                    count++;
//                    Console.WriteLine($"Обнаружена упаковка: {item.GetType().Name} -> {item}");
//                }
//            }
//            return count;
//        }

//        static void Main()
//        {

//            ArrayList list = new ArrayList();

//            list.Add(1);
//            list.Add("text");
//            list.Add(3.14);
//            list.Add(true);
//            list.Add('A');
//            list.Add(DateTime.Now);

//            Console.WriteLine("Содержимое ArrayList:");
//            for (int i = 0; i < list.Count; i++)
//            {
//                Console.WriteLine($"[{i}] {list[i],-20} Тип: {list[i]?.GetType().Name ?? "null"}");
//            }

//            int boxingCount = CountBoxingOperations(list);
//            Console.WriteLine($"\nВсего операций упаковки: {boxingCount}");
//        }
//    }
//}

//7
//using System;
//using System.Diagnostics;
//using System.Collections;
//using System.Collections.Generic;

//namespace ListVsArrayListDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            const int elementsCount = 10000;
//            Stopwatch sw = new Stopwatch();

//            sw.Start();
//            ArrayList arrayList = new ArrayList();
//            for (int i = 0; i < elementsCount; i++)
//            {
//                arrayList.Add(i);
//            }
//            sw.Stop();
//            long arrayListTime = sw.ElapsedMilliseconds;
//            Console.WriteLine($"ArrayList: {arrayListTime} мс");

//            sw.Restart();
//            List<int> genericList = new List<int>();
//            for (int i = 0; i < elementsCount; i++)
//            {
//                genericList.Add(i);
//            }
//            sw.Stop();
//            long genericListTime = sw.ElapsedMilliseconds;
//            Console.WriteLine($"List<int>: {genericListTime} мс");

//            double difference = (double)arrayListTime / genericListTime;
//            Console.WriteLine($"\nList<int> быстрее в {difference:F2} раз");
//        }
//    }
//}

//8
//using System;

//namespace InvalidCastExceptionDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            try
//            {
//                int value = 100;
//                object boxed = value;
//                Console.WriteLine($"Упаковано значение: {boxed} типа {boxed.GetType()}");

//                Console.WriteLine("Пытаемся распаковать int как double...");
//                double wrongUnbox = (double)boxed;
//                Console.WriteLine($"Распаковано: {wrongUnbox}");
//            }
//            catch (InvalidCastException ex)
//            {
//                Console.WriteLine($"Ошибка распаковки: {ex.Message}");
//                Console.WriteLine($"Тип исключения: {ex.GetType().Name}");
//            }

//            Console.WriteLine("\nПравильный способ с проверкой типа:");
//            object boxedValue = 200;

//            if (boxedValue is double)
//            {
//                double correctUnbox = (double)boxedValue;
//                Console.WriteLine($"Распаковано как double: {correctUnbox}");
//            }
//            else
//            {
//                Console.WriteLine($"Нельзя распаковать {boxedValue.GetType().Name} как double");
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//namespace ParamsObjectDemo
//{
//    class Program
//    {
//        Метод принимает произвольное количество параметров любого типа
//        static void ProcessValues(params object[] values)
//        {
//            Console.WriteLine($"=== Обработка {values.Length} значений ===\n");

//            foreach (object value in values)
//            {
//                Используем pattern matching для определения типа
//                switch (value)
//                {
//                    case int i:
//                        Console.WriteLine($"[INT]    Значение: {i}, Квадрат: {i * i}");
//                        break;

//                    case double d:
//                        Console.WriteLine($"[DOUBLE] Значение: {d:F2}, Округленное: {Math.Round(d)}");
//                        break;

//                    case bool b:
//                        Console.WriteLine($"[BOOL]   Значение: {b}, Инверсия: {!b}");
//                        break;

//                    case string s:
//                        Console.WriteLine($"[STRING] Значение: '{s}', Длина: {s.Length}");
//                        break;

//                    case DateTime dt:
//                        Console.WriteLine($"[DATE]   Значение: {dt:yyyy-MM-dd HH:mm:ss}");
//                        break;

//                    case null:
//                        Console.WriteLine($"[NULL]   Значение: null");
//                        break;

//                    default:
//                        Console.WriteLine($"[OTHER]  Тип: {value.GetType().Name}, Значение: {value}");
//                        break;
//                }
//            }
//        }

//        Метод для подсчета количества значений каждого типа
//        static Dictionary<Type, int> CountTypes(params object[] values)
//        {
//            var typeCounts = new Dictionary<Type, int>();

//            foreach (object value in values)
//            {
//                Type type = value?.GetType() ?? typeof(object);

//                if (typeCounts.ContainsKey(type))
//                    typeCounts[type]++;
//                else
//                    typeCounts[type] = 1;
//            }

//            return typeCounts;
//        }

//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 9: params object[] ===\n");

//            Вызов метода с различными типами(boxing происходит для типов значений)
//            ProcessValues(
//                42,                      // int -> boxing
//                3.14159,                 // double -> boxing
//                true,                    // bool -> boxing
//                "Hello World",           // string - нет boxing
//                DateTime.Now,            // DateTime (struct) -> boxing
//                'X',                     // char -> boxing
//                null                     // null
//            );

//            Console.WriteLine("\n=== Подсчет типов ===\n");
//            var counts = CountTypes(10, 20, 30, "test", "hello", 5.5, 7.7, 8.8, true, false);

//            foreach (var kvp in counts)
//            {
//                Console.WriteLine($"{kvp.Key.Name}: {kvp.Value} шт.");
//            }
//        }
//    }
//}

//10
//using System;

//namespace InterfaceBoxingDemo
//{
//    interface IDisplayable
//    {
//        void Display();
//    }

//    struct Point : IDisplayable
//    {
//        public int X;
//        public int Y;

//        public void Display()
//        {
//            Console.WriteLine($"Точка: X={X}, Y={Y}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Point point = new Point { X = 10, Y = 20 };
//            Console.WriteLine("Исходная структура:");
//            point.Display();

//            IDisplayable boxed = point;
//            Console.WriteLine("\nУпаковано в интерфейс:");
//            boxed.Display();

//            Console.WriteLine($"\nТип исходной структуры: {point.GetType()}");
//            Console.WriteLine($"Тип упакованного объекта: {boxed.GetType()}");
//            Console.WriteLine($"Произошла упаковка: {boxed.GetType() != point.GetType()}");
//        }
//    }
//}

//11
//using System;

//namespace IsBoxedValueDemo
//{
//    class Program
//    {
//        static bool IsBoxedValueType(object obj)
//        {
//            return obj != null && obj.GetType().IsValueType;
//        }

//        static void CheckAndDisplay(object obj)
//        {
//            bool isBoxed = IsBoxedValueType(obj);
//            Console.WriteLine($"Значение: {obj,-15} Тип: {obj?.GetType().Name,-10} Упакован: {isBoxed}");
//        }

//        static void Main()
//        {

//            CheckAndDisplay(10);
//            CheckAndDisplay(3.14);
//            CheckAndDisplay(true);
//            CheckAndDisplay("text");
//            CheckAndDisplay('A');
//            CheckAndDisplay(DateTime.Now);
//            CheckAndDisplay(null);
//        }
//    }
//}

//12
//using System;

//namespace NullableBoxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            int? nullableInt = 42;
//            double? nullableDouble = 3.14;
//            int? nullInt = null;

//            Console.WriteLine("Nullable значения:");
//            Console.WriteLine($"int?: {nullableInt}");
//            Console.WriteLine($"double?: {nullableDouble}");
//            Console.WriteLine($"null int?: {nullInt}");

//            object boxedNullableInt = nullableInt;
//            object boxedNullableDouble = nullableDouble;
//            object boxedNull = nullInt;

//            Console.WriteLine("\nУпакованные значения:");
//            Console.WriteLine($"boxed int?: {boxedNullableInt} (тип: {boxedNullableInt.GetType()})");
//            Console.WriteLine($"boxed double?: {boxedNullableDouble} (тип: {boxedNullableDouble.GetType()})");
//            Console.WriteLine($"boxed null: {boxedNull} (тип: {boxedNull?.GetType()?.Name ?? "null"})");

//            Console.WriteLine("\nПоведение при упаковке null:");
//            Console.WriteLine($"nullableInt.HasValue: {nullableInt.HasValue}");
//            Console.WriteLine($"nullInt.HasValue: {nullInt.HasValue}");
//            Console.WriteLine($"boxedNullableInt == null: {boxedNullableInt == null}");
//            Console.WriteLine($"boxedNull == null: {boxedNull == null}");
//        }
//    }
//}
//13
//using System;
//using System.Collections.Generic;
//using System.Reflection.Emit;
//using System.Reflection;

//namespace BoxingProfilerDemo
//{
//    public class BoxingProfiler
//    {
//        private static Dictionary<string, int> boxingOperations = new Dictionary<string, int>();

//        public static void TrackBoxing(string operationName)
//        {
//            if (boxingOperations.ContainsKey(operationName))
//                boxingOperations[operationName]++;
//            else
//                boxingOperations[operationName] = 1;
//        }

//        public static void PrintReport()
//        {
//            Console.WriteLine("\n=== ОТЧЕТ ОБ ОПЕРАЦИЯХ УПАКОВКИ ===");
//            Console.WriteLine($"Всего различных операций: {boxingOperations.Count}");

//            int totalBoxing = 0;
//            foreach (var operation in boxingOperations)
//            {
//                Console.WriteLine($"  {operation.Key}: {operation.Value} раз");
//                totalBoxing += operation.Value;
//            }

//            Console.WriteLine($"Всего операций упаковки: {totalBoxing}");
//        }

//        public static void Reset()
//        {
//            boxingOperations.Clear();
//        }
//    }

//    class Program
//    {
//        static void ProcessWithTracking(int value)
//        {
//            object boxed = value;
//            BoxingProfiler.TrackBoxing("int в object");

//            int unboxed = (int)boxed;
//            BoxingProfiler.TrackBoxing("object в int");
//        }

//        static void AddToArrayList()
//        {
//            ArrayList list = new ArrayList();
//            for (int i = 0; i < 100; i++)
//            {
//                list.Add(i);
//                BoxingProfiler.TrackBoxing("ArrayList.Add(int)");
//            }
//        }

//        static void StringFormatExample()
//        {
//            int age = 25;
//            double salary = 50000.50;
//            string result = String.Format("Возраст: {0}, Зарплата: {1}", age, salary);
//            BoxingProfiler.TrackBoxing("String.Format с int");
//            BoxingProfiler.TrackBoxing("String.Format с double");
//        }

//        static void Main()
//        {

//            Console.WriteLine("Запуск операций с упаковкой...");

//            ProcessWithTracking(42);

//            for (int i = 0; i < 50; i++)
//            {
//                ProcessWithTracking(i);
//            }

//            AddToArrayList();
//            StringFormatExample();

//            object[] objects = new object[10];
//            for (int i = 0; i < objects.Length; i++)
//            {
//                objects[i] = i;
//                BoxingProfiler.TrackBoxing("object[] присваивание");
//            }

//            BoxingProfiler.PrintReport();
//        }
//    }
//}

//14
//using System;
//using System.Collections.Generic;

//namespace GenericNoBoxingDemo
//{
//    class Program
//    {
//        static void ProcessWithGenerics<T>(T value)
//        {
//            Console.WriteLine($"Обработано: {value}, Тип: {typeof(T).Name}, Упаковка: {typeof(T).IsValueType && typeof(T) != typeof(string)}");
//        }

//        static void ProcessWithoutGenerics(object value)
//        {
//            Console.WriteLine($"Обработано: {value}, Тип: {value.GetType().Name}, Упаковка: {value.GetType().IsValueType}");
//        }

//        static void Main()
//        {

//            Console.WriteLine("С использованием generics (без упаковки):");
//            ProcessWithGenerics(10);
//            ProcessWithGenerics(3.14);
//            ProcessWithGenerics(true);

//            Console.WriteLine("\nБез generics (с упаковкой):");
//            ProcessWithoutGenerics(10);
//            ProcessWithoutGenerics(3.14);
//            ProcessWithoutGenerics(true);
//        }
//    }
//}

//15
//using System;
//using System.Collections;

//namespace BoxedValuesComparisonDemo
//{
//    class Program
//    {
//        static void CompareBoxedValues(object obj1, object obj2)
//        {
//            Console.WriteLine($"\nСравнение: {obj1} ({obj1?.GetType().Name}) vs {obj2} ({obj2?.GetType().Name})");

//            bool equalsResult = object.Equals(obj1, obj2);
//            Console.WriteLine($"object.Equals: {equalsResult}");

//            bool operatorResult = obj1 == obj2;
//            Console.WriteLine($"operator ==: {operatorResult}");

//            bool sameType = obj1?.GetType() == obj2?.GetType();
//            Console.WriteLine($"Типы одинаковы: {sameType}");

//            if (obj1 != null && obj2 != null)
//            {
//                bool sameHashCode = obj1.GetHashCode() == obj2.GetHashCode();
//                Console.WriteLine($"Хэш-коды одинаковы: {sameHashCode}");
//                Console.WriteLine($"HashCode obj1: {obj1.GetHashCode()}, obj2: {obj2.GetHashCode()}");
//            }

//            if (obj1 is IComparable comparable1 && obj2 is IComparable comparable2 &&
//                obj1.GetType() == obj2.GetType())
//            {
//                try
//                {
//                    int compareResult = comparable1.CompareTo(comparable2);
//                    Console.WriteLine($"IComparable.CompareTo: {compareResult} (0=равны, <0=obj1<obj2, >0=obj1>obj2)");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"IComparable.CompareTo ошибка: {ex.Message}");
//                }
//            }
//        }

//        static void Main()
//        {

//            Console.WriteLine("Случай 1: Одинаковые int значения");
//            object int1 = 42;
//            object int2 = 42;
//            CompareBoxedValues(int1, int2);

//            Console.WriteLine("\nСлучай 2: Разные int значения");
//            object int3 = 42;
//            object int4 = 100;
//            CompareBoxedValues(int3, int4);

//            Console.WriteLine("\nСлучай 3: Одинаковые значения, разные типы");
//            object int5 = 42;
//            object double1 = 42.0;
//            CompareBoxedValues(int5, double1);

//            Console.WriteLine("\nСлучай 4: Разные типы значений");
//            object bool1 = true;
//            object int6 = 1;
//            CompareBoxedValues(bool1, int6);


//        }
//    }
//}

//16
//using System;

//namespace EnumBoxingDemo
//{
//    enum Status
//    {
//        Active,
//        Inactive,
//        Pending
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 16: Упаковка enum в object и обратная распаковка ===\n");

//            Status status = Status.Active;
//            Console.WriteLine($"Исходный enum: {status} (значение: {(int)status})");

//            object boxed = status;
//            Console.WriteLine($"Упакованный: {boxed} (тип: {boxed.GetType()})");

//            Status unboxed = (Status)boxed;
//            Console.WriteLine($"Распакованный: {unboxed} (значение: {(int)unboxed})");

//            Console.WriteLine($"\nСравнение:");
//            Console.WriteLine($"status == unboxed: {status == unboxed}");
//            Console.WriteLine($"boxed.Equals(status): {boxed.Equals(status)}");

//            Console.WriteLine("\nМассив enum с упаковкой:");
//            Status[] statuses = { Status.Active, Status.Inactive, Status.Pending };
//            object[] boxedStatuses = new object[statuses.Length];

//            for (int i = 0; i < statuses.Length; i++)
//            {
//                boxedStatuses[i] = statuses[i];
//                Console.WriteLine($"{statuses[i]} -> {boxedStatuses[i]} (тип: {boxedStatuses[i].GetType()})");
//            }
//        }
//    }
//}

//17
//using System;

//namespace CloneViaBoxingDemo
//{
//    struct Point
//    {
//        public int X;
//        public int Y;

//        public object Clone()
//        {
//            return this;
//        }

//        public override string ToString()
//        {
//            return $"X={X}, Y={Y}";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Point original = new Point { X = 10, Y = 20 };
//            Console.WriteLine($"Оригинал: {original}");

//            object cloned = original.Clone();
//            Console.WriteLine($"Упакованная копия: {cloned}");

//            Point unboxedClone = (Point)cloned;
//            Console.WriteLine($"Распакованная копия: {unboxedClone}");

//            Console.WriteLine($"\nСравнение:");
//            Console.WriteLine($"original.Equals(unboxedClone): {original.Equals(unboxedClone)}");
//            Console.WriteLine($"original == unboxedClone: {original.ToString() == unboxedClone.ToString()}");

//            Console.WriteLine("\nИзменяем оригинал:");
//            original.X = 100;
//            Console.WriteLine($"Оригинал после изменения: {original}");
//            Console.WriteLine($"Копия после изменения оригинала: {unboxedClone}");
//        }
//    }
//}

//18
//using System;
//using System.Diagnostics;
//using System.Collections;

//namespace BoxingBenchmarkDemo
//{
//    class Program
//    {
//        const int Iterations = 10000000;

//        static long MeasureDirectIntOperations()
//        {
//            Stopwatch sw = Stopwatch.StartNew();
//            int sum = 0;
//            for (int i = 0; i < Iterations; i++)
//            {
//                sum += i;
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureBoxingUnboxingOperations()
//        {
//            Stopwatch sw = Stopwatch.StartNew();
//            object sum = 0;
//            for (int i = 0; i < Iterations; i++)
//            {
//                sum = (int)sum + i;
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureArrayListPerformance()
//        {
//            Stopwatch sw = Stopwatch.StartNew();
//            ArrayList list = new ArrayList();
//            for (int i = 0; i < Iterations / 100; i++)
//            {
//                list.Add(i);
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureGenericListPerformance()
//        {
//            Stopwatch sw = Stopwatch.StartNew();
//            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
//            for (int i = 0; i < Iterations / 100; i++)
//            {
//                list.Add(i);
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureObjectArrayPerformance()
//        {
//            Stopwatch sw = Stopwatch.StartNew();
//            object[] array = new object[Iterations / 1000];
//            for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = i;
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureIntArrayPerformance()
//        {
//            Stopwatch sw = Stopwatch.StartNew();
//            int[] array = new int[Iterations / 1000];
//            for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = i;
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static void RunBenchmark(string name, Func<long> benchmark, Func<long> baseline = null)
//        {
//            Console.WriteLine($"\n--- {name} ---");

//            benchmark();

//            long time = benchmark();

//            Console.WriteLine($"Время: {time} мс");

//            if (baseline != null)
//            {
//                long baselineTime = baseline();
//                double slowdown = (double)time / baselineTime;
//                Console.WriteLine($"Замедление: {slowdown:F2}x");
//            }
//        }

//        static void Main()
//        {
//            Console.WriteLine($"Количество итераций: {Iterations:N0}");

//            RunBenchmark("Прямые операции с int", MeasureDirectIntOperations);
//            RunBenchmark("Операции с упаковкой/распаковкой",
//                MeasureBoxingUnboxingOperations,
//                MeasureDirectIntOperations);

//            RunBenchmark("ArrayList (с упаковкой)", MeasureArrayListPerformance);
//            RunBenchmark("List<int> (без упаковки)",
//                MeasureGenericListPerformance,
//                MeasureArrayListPerformance);

//            RunBenchmark("object[] (с упаковкой)", MeasureObjectArrayPerformance);
//            RunBenchmark("int[] (без упаковки)",
//                MeasureIntArrayPerformance,
//                MeasureObjectArrayPerformance);

//            Console.WriteLine("\n=== Дополнительные тесты производительности ===");

//            Stopwatch sw = Stopwatch.StartNew();
//            for (int i = 0; i < Iterations; i++)
//            {
//                ProcessValue(i);
//            }
//            sw.Stop();
//            Console.WriteLine($"Вызов метода с int: {sw.ElapsedMilliseconds} мс");

//            sw.Restart();
//            for (int i = 0; i < Iterations; i++)
//            {
//                ProcessObject(i);
//            }
//            sw.Stop();
//            Console.WriteLine($"Вызов метода с object: {sw.ElapsedMilliseconds} мс");

//            Console.WriteLine("\n=== ВЫВОДЫ ===");
//            Console.WriteLine("1. Упаковка/распаковка добавляет значительные накладные расходы");
//            Console.WriteLine("2. Использование generics коллекций вместо нетипизированных ускоряет работу");
//            Console.WriteLine("3. Типизированные массивы эффективнее object[] массивов");
//            Console.WriteLine("4. Следует избегать упаковки в performance-critical коде");
//        }

//        static void ProcessValue(int value)
//        {
//            var result = value * 2;
//        }

//        static void ProcessObject(object value)
//        {
//            var result = (int)value * 2;
//        }
//    }
//}

//19
//using System;
//using System.Collections.Generic;

//namespace BoxingCacheDemo
//{
//    class Program
//    {
//        static Dictionary<Type, object> valueCache = new Dictionary<Type, object>();

//        static T GetCachedValue<T>() where T : struct
//        {
//            Type type = typeof(T);
//            if (!valueCache.ContainsKey(type))
//            {
//                valueCache[type] = default(T);
//                Console.WriteLine($"Создан кеш для типа {type.Name}");
//            }
//            return (T)valueCache[type];
//        }

//        static void SetCachedValue<T>(T value) where T : struct
//        {
//            Type type = typeof(T);
//            valueCache[type] = value;
//            Console.WriteLine($"Установлено значение в кеш для {type.Name}: {value}");
//        }

//        static void Main()
//        {

//            SetCachedValue(42);
//            SetCachedValue(3.14);
//            SetCachedValue(true);

//            Console.WriteLine("\nПолучение из кеша:");
//            int cachedInt = GetCachedValue<int>();
//            double cachedDouble = GetCachedValue<double>();
//            bool cachedBool = GetCachedValue<bool>();

//            Console.WriteLine($"int: {cachedInt}");
//            Console.WriteLine($"double: {cachedDouble}");
//            Console.WriteLine($"bool: {cachedBool}");

//            Console.WriteLine($"\nКеш содержит {valueCache.Count} элементов:");
//            foreach (var item in valueCache)
//            {
//                Console.WriteLine($"{item.Key.Name}: {item.Value}");
//            }
//        }
//    }
//}

//20
//using System;

//namespace ModifyBoxedValueDemo
//{
//    interface IModifiable
//    {
//        int Value { get; set; }
//    }

//    struct MyStruct : IModifiable
//    {
//        public int Value { get; set; }

//        public override string ToString()
//        {
//            return $"Value = {Value}";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            MyStruct original = new MyStruct { Value = 10 };
//            Console.WriteLine($"Оригинальная структура: {original}");

//            IModifiable boxed = original;
//            Console.WriteLine($"Упаковано в интерфейс: {boxed.Value}");

//            Console.WriteLine("\nИзменяем значение через интерфейс:");
//            boxed.Value = 20;
//            Console.WriteLine($"Через интерфейс: {boxed.Value}");
//            Console.WriteLine($"Оригинальная структура: {original}");

//            Console.WriteLine("\nРазница в поведении:");
//            Console.WriteLine("При упаковке создается копия, поэтому изменения через интерфейс");
//            Console.WriteLine("не влияют на оригинальную структуру");
//        }
//    }
//}

//21
//using System;

//namespace ExplicitBoxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            int value = 42;

//            object boxed1 = (object)value;
//            Console.WriteLine($"Явная упаковка: {boxed1} (тип: {boxed1.GetType()})");

//            ValueType valueType = value;
//            Console.WriteLine($"Упаковка в ValueType: {valueType} (тип: {valueType.GetType()})");

//            Console.WriteLine("\nСравнение явной и неявной упаковки:");

//            object implicitBoxed = value;
//            Console.WriteLine($"Неявная упаковка: {implicitBoxed}");

//            object explicitBoxed = (object)value;
//            Console.WriteLine($"Явная упаковка: {explicitBoxed}");

//            Console.WriteLine($"\nРавенство: {implicitBoxed.Equals(explicitBoxed)}");
//            Console.WriteLine($"Ссылочное равенство: {object.ReferenceEquals(implicitBoxed, explicitBoxed)}");
//        }
//    }
//}

//22
//using System;

//namespace ImplicitBoxingDemo
//{
//    class Program
//    {
//        static void ProcessObject(object obj)
//        {
//            Console.WriteLine($"Получен объект: {obj} типа {obj.GetType()}");
//        }

//        static void ProcessValueType(ValueType value)
//        {
//            Console.WriteLine($"Получен ValueType: {value} типа {value.GetType()}");
//        }

//        static void ProcessIComparable(IComparable comparable)
//        {
//            Console.WriteLine($"Получен IComparable: {comparable} типа {comparable.GetType()}");
//        }

//        static void Main()
//        {

//            int intValue = 100;
//            double doubleValue = 3.14;
//            bool boolValue = true;
//            char charValue = 'A';

//            Console.WriteLine("Передача int в object параметр:");
//            ProcessObject(intValue);

//            Console.WriteLine("\nПередача double в ValueType параметр:");
//            ProcessValueType(doubleValue);

//            Console.WriteLine("\nПередача bool в IComparable параметр:");
//            ProcessIComparable(boolValue);

//            Console.WriteLine("\nПередача char в object параметр:");
//            ProcessObject(charValue);

//            Console.WriteLine("\nМассив с неявной упаковкой:");
//            object[] objects = { intValue, doubleValue, boolValue, charValue };
//            foreach (var obj in objects)
//            {
//                Console.WriteLine($"Элемент: {obj} типа {obj.GetType()}");
//            }
//        }
//    }
//}

//23
//using System;

//namespace VirtualMethodsBoxingDemo
//{
//    struct Point
//    {
//        public int X, Y;

//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Point point = new Point(10, 20);

//            Console.WriteLine("Вызов ToString() на структуре:");
//            string str1 = point.ToString();
//            Console.WriteLine($"Результат: {str1}");
//            Console.WriteLine($"Упаковка не происходит при вызове на структуре\n");

//            Console.WriteLine("Вызов ToString() на упакованной структуре:");
//            object boxedPoint = point;
//            string str2 = boxedPoint.ToString();
//            Console.WriteLine($"Результат: {str2}");
//            Console.WriteLine($"Упаковка уже произошла ранее\n");

//            Console.WriteLine("Вызов GetHashCode():");
//            int hash1 = point.GetHashCode();
//            int hash2 = boxedPoint.GetHashCode();
//            Console.WriteLine($"HashCode структуры: {hash1}");
//            Console.WriteLine($"HashCode упакованной: {hash2}");
//            Console.WriteLine($"Равны: {hash1 == hash2}\n");

//            Console.WriteLine("Вызов Equals():");
//            Point point2 = new Point(10, 20);
//            bool equals1 = point.Equals(point2);
//            bool equals2 = boxedPoint.Equals(point2);
//            Console.WriteLine($"point.Equals(point2): {equals1}");
//            Console.WriteLine($"boxedPoint.Equals(point2): {equals2}");

//            Console.WriteLine("\nВызов GetType():");
//            Type type1 = point.GetType();
//            Type type2 = boxedPoint.GetType();
//            Console.WriteLine($"Тип структуры: {type1}");
//            Console.WriteLine($"Тип упакованной: {type2}");
//        }
//    }
//}

//24
//using System;

//namespace IComparableBoxingDemo
//{
//    struct Product : IComparable
//    {
//        public string Name;
//        public decimal Price;

//        public Product(string name, decimal price)
//        {
//            Name = name;
//            Price = price;
//        }

//        public int CompareTo(object obj)
//        {
//            if (obj is Product other)
//            {
//                return Price.CompareTo(other.Price);
//            }
//            throw new ArgumentException("Object is not a Product");
//        }

//        public override string ToString()
//        {
//            return $"{Name} - {Price:C}";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Product product1 = new Product("Apple", 1.50m);
//            Product product2 = new Product("Banana", 2.00m);

//            Console.WriteLine($"Продукт 1: {product1}");
//            Console.WriteLine($"Продукт 2: {product2}\n");

//            Console.WriteLine("Прямой вызов CompareTo (упаковка):");
//            IComparable comparable1 = product1;
//            int result1 = comparable1.CompareTo(product2);
//            Console.WriteLine($"Результат сравнения: {result1}");
//            Console.WriteLine($"Тип comparable1: {comparable1.GetType()}\n");

//            Console.WriteLine("Использование в сортировке (упаковка):");
//            Product[] products = {
//                new Product("Orange", 3.00m),
//                new Product("Apple", 1.50m),
//                new Product("Banana", 2.00m)
//            };

//            Array.Sort(products);
//            Console.WriteLine("Отсортированные продукты:");
//            foreach (var product in products)
//            {
//                Console.WriteLine($"  {product}");
//            }

//            Console.WriteLine("\nСравнение через интерфейс (упаковка):");
//            object boxedProduct1 = product1;
//            object boxedProduct2 = product2;

//            if (boxedProduct1 is IComparable comp1 && boxedProduct2 is IComparable comp2)
//            {
//                int result2 = comp1.CompareTo(comp2);
//                Console.WriteLine($"Сравнение упакованных: {result2}");
//            }
//        }
//    }
//}

//25
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LINQBoxingDemo
//{
//    struct Number
//    {
//        public int Value;

//        public Number(int value)
//        {
//            Value = value;
//        }

//        public override string ToString()
//        {
//            return $"Number: {Value}";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Number[] numbers = {
//                new Number(1),
//                new Number(2),
//                new Number(3),
//                new Number(4),
//                new Number(5)
//            };

//            Console.WriteLine("Исходный массив:");
//            foreach (var number in numbers)
//            {
//                Console.WriteLine($"  {number}");
//            }

//            Console.WriteLine("\nLINQ Where (упаковка в итераторе):");
//            var evenNumbers = numbers.Where(n => n.Value % 2 == 0);
//            foreach (var number in evenNumbers)
//            {
//                Console.WriteLine($"  {number} (тип: {number.GetType()})");
//            }

//            Console.WriteLine("\nLINQ Select (упаковка при преобразовании):");
//            var doubled = numbers.Select(n => n.Value * 2);
//            foreach (var item in doubled)
//            {
//                Console.WriteLine($"  {item} (тип: {item.GetType()})");
//            }

//            Console.WriteLine("\nLINQ OrderBy (упаковка при сортировке):");
//            var ordered = numbers.OrderBy(n => n.Value);
//            foreach (var number in ordered)
//            {
//                Console.WriteLine($"  {number} (тип: {number.GetType()})");
//            }

//            Console.WriteLine("\nLINQ OfType (упаковка при фильтрации):");
//            object[] mixedArray = { 1, "text", new Number(10), 3.14, new Number(20) };
//            var numberObjects = mixedArray.OfType<Number>();
//            foreach (var obj in numberObjects)
//            {
//                Console.WriteLine($"  {obj} (тип: {obj.GetType()})");
//            }

//            Console.WriteLine("\nLINQ Cast (упаковка/распаковка):");
//            try
//            {
//                var casted = mixedArray.Cast<Number>();
//                foreach (var item in casted)
//                {
//                    Console.WriteLine($"  {item}");
//                }
//            }
//            catch (InvalidCastException ex)
//            {
//                Console.WriteLine($"Ошибка при Cast: {ex.Message}");
//            }
//        }
//    }
//}

//26
//using System;
//using System.Collections;

//namespace CollectionBoxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            ArrayList arrayList = new ArrayList();
//            Hashtable hashtable = new Hashtable();
//            Stack stack = new Stack();
//            Queue queue = new Queue();

//            int intValue = 42;
//            double doubleValue = 3.14;
//            bool boolValue = true;
//            DateTime dateValue = DateTime.Now;

//            Console.WriteLine("Добавление в ArrayList:");
//            arrayList.Add(intValue);
//            arrayList.Add(doubleValue);
//            arrayList.Add(boolValue);
//            arrayList.Add(dateValue);
//            Console.WriteLine($"ArrayList содержит {arrayList.Count} элементов\n");

//            Console.WriteLine("Добавление в Hashtable:");
//            hashtable.Add("number", intValue);
//            hashtable.Add("price", doubleValue);
//            hashtable.Add("active", boolValue);
//            hashtable.Add("created", dateValue);
//            Console.WriteLine($"Hashtable содержит {hashtable.Count} элементов\n");

//            Console.WriteLine("Добавление в Stack:");
//            stack.Push(intValue);
//            stack.Push(doubleValue);
//            stack.Push(boolValue);
//            Console.WriteLine($"Stack содержит {stack.Count} элементов\n");

//            Console.WriteLine("Добавление в Queue:");
//            queue.Enqueue(intValue);
//            queue.Enqueue(doubleValue);
//            queue.Enqueue(boolValue);
//            Console.WriteLine($"Queue содержит {queue.Count} элементов\n");

//            Console.WriteLine("Типы элементов в ArrayList:");
//            foreach (object item in arrayList)
//            {
//                Console.WriteLine($"  Значение: {item,-15} Тип: {item.GetType().Name,-10} Упакован: {item.GetType().IsValueType}");
//            }

//            Console.WriteLine("\nРаспаковка из ArrayList:");
//            int unboxedInt = (int)arrayList[0];
//            double unboxedDouble = (double)arrayList[1];
//            bool unboxedBool = (bool)arrayList[2];
//            Console.WriteLine($"int: {unboxedInt}, double: {unboxedDouble}, bool: {unboxedBool}");
//        }
//    }
//}

//27
//using System;
//using System.Reflection;

//namespace ReflectionBoxingDemo
//{
//    struct Point
//    {
//        public int X;
//        public int Y;

//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }

//        public override string ToString()
//        {
//            return $"({X}, {Y})";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Point point = new Point(10, 20);
//            Type pointType = typeof(Point);

//            Console.WriteLine("Получение свойств через reflection:");
//            PropertyInfo[] properties = pointType.GetProperties();
//            foreach (var prop in properties)
//            {
//                object value = prop.GetValue(point);
//                Console.WriteLine($"  {prop.Name}: {value} (тип: {value.GetType()})");
//            }

//            Console.WriteLine("\nВызов методов через reflection:");
//            MethodInfo toStringMethod = pointType.GetMethod("ToString");
//            object result = toStringMethod.Invoke(point, null);
//            Console.WriteLine($"ToString результат: {result} (тип: {result.GetType()})");

//            Console.WriteLine("\nСоздание экземпляра через reflection:");
//            object boxedPoint = Activator.CreateInstance(pointType);
//            Console.WriteLine($"Созданный объект: {boxedPoint} (тип: {boxedPoint.GetType()})");

//            Console.WriteLine("\nУстановка значений полей через reflection:");
//            FieldInfo xField = pointType.GetField("X");
//            FieldInfo yField = pointType.GetField("Y");
//            xField.SetValue(boxedPoint, 100);
//            yField.SetValue(boxedPoint, 200);
//            Console.WriteLine($"После установки: {boxedPoint}");

//            Console.WriteLine("\nРабота с массивами через reflection:");
//            Array pointsArray = Array.CreateInstance(pointType, 3);
//            for (int i = 0; i < pointsArray.Length; i++)
//            {
//                pointsArray.SetValue(new Point(i * 10, i * 20), i);
//            }
//            Console.WriteLine("Массив точек:");
//            foreach (object item in pointsArray)
//            {
//                Console.WriteLine($"  {item} (тип: {item.GetType()})");
//            }
//        }
//    }
//}

//28
//using System;

//namespace DelegateBoxingDemo
//{
//    class Program
//    {
//        delegate void ObjectDelegate(object obj);
//        delegate object ObjectReturnDelegate();

//        static void ProcessObject(object obj)
//        {
//            Console.WriteLine($"Обработан: {obj} типа {obj.GetType()}");
//        }

//        static object GetIntObject()
//        {
//            return 42;
//        }

//        static object GetDoubleObject()
//        {
//            return 3.14;
//        }

//        static void ProcessValueType(ValueType value)
//        {
//            Console.WriteLine($"ValueType: {value} типа {value.GetType()}");
//        }

//        static void Main()
//        {

//            ObjectDelegate objectDelegate = ProcessObject;
//            ObjectReturnDelegate returnDelegate = GetIntObject;

//            Console.WriteLine("Вызов делегата с int (упаковка):");
//            objectDelegate(100);

//            Console.WriteLine("\nВызов делегата с double (упаковка):");
//            objectDelegate(2.71);

//            Console.WriteLine("\nВызов делегата с bool (упаковка):");
//            objectDelegate(true);

//            Console.WriteLine("\nДелегат возвращающий object:");
//            object result1 = returnDelegate();
//            Console.WriteLine($"Результат: {result1} типа {result1.GetType()}");

//            returnDelegate = GetDoubleObject;
//            object result2 = returnDelegate();
//            Console.WriteLine($"Результат: {result2} типа {result2.GetType()}");

//            Console.WriteLine("\nЦепочка делегатов:");
//            ObjectDelegate chain = ProcessObject;
//            chain += obj => Console.WriteLine($"Лямбда: {obj}");
//            chain(123);

//            Console.WriteLine("\nДелегат с ValueType параметром:");
//            Action<ValueType> valueTypeDelegate = ProcessValueType;
//            valueTypeDelegate(999);
//            valueTypeDelegate(45.67m);
//        }
//    }
//}

//29
//using System;

//namespace EventBoxingDemo
//{
//    class NumberProcessor
//    {
//        public event EventHandler<object> NumberProcessed;

//        public void ProcessNumber(int number)
//        {
//            Console.WriteLine($"Обрабатываем число: {number}");
//            OnNumberProcessed(number);
//        }

//        public void ProcessDouble(double value)
//        {
//            Console.WriteLine($"Обрабатываем double: {value}");
//            OnNumberProcessed(value);
//        }

//        protected virtual void OnNumberProcessed(object data)
//        {
//            NumberProcessed?.Invoke(this, data);
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            NumberProcessor processor = new NumberProcessor();

//            processor.NumberProcessed += (sender, e) =>
//            {
//                Console.WriteLine($"Событие: получен {e} типа {e.GetType()}");
//            };

//            Console.WriteLine("Обработка int (упаковка в EventArgs):");
//            processor.ProcessNumber(42);

//            Console.WriteLine("\nОбработка double (упаковка в EventArgs):");
//            processor.ProcessDouble(3.14159);

//            Console.WriteLine("\nКастомные EventArgs с упаковкой:");
//            EventHandler<object> customHandler = (sender, arg) =>
//            {
//                if (arg is int i)
//                    Console.WriteLine($"Обработан int: {i * 2}");
//                else if (arg is double d)
//                    Console.WriteLine($"Обработан double: {d:F2}");
//            };

//            customHandler(null, 100);
//            customHandler(null, 45.678);
//        }
//    }
//}

//30
//using System;

//namespace IsAsBoxingDemo
//{
//    struct Point
//    {
//        public int X, Y;

//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            int intValue = 42;
//            double doubleValue = 3.14;
//            Point point = new Point(10, 20);

//            Console.WriteLine("Оператор is с типами значений:");

//            object obj1 = intValue;
//            if (obj1 is int)
//            {
//                Console.WriteLine($"obj1 is int: true");
//            }

//            object obj2 = doubleValue;
//            if (obj2 is double d)
//            {
//                Console.WriteLine($"obj2 is double: {d}");
//            }

//            object obj3 = point;
//            if (obj3 is Point p)
//            {
//                Console.WriteLine($"obj3 is Point: ({p.X}, {p.Y})");
//            }

//            Console.WriteLine("\nОператор as с типами значений:");

//            object obj4 = 100;
//            int? asInt = obj4 as int?;
//            Console.WriteLine($"as int?: {asInt}");

//            object obj5 = 2.71;
//            double? asDouble = obj5 as double?;
//            Console.WriteLine($"as double?: {asDouble}");

//            object obj6 = point;
//            Point? asPoint = obj6 as Point?;
//            Console.WriteLine($"as Point?: {asPoint}");

//            Console.WriteLine("\nПроверка с null:");
//            object nullObj = null;
//            Console.WriteLine($"null is int: {nullObj is int}");
//            Console.WriteLine($"null as int?: {nullObj as int?}");

//            Console.WriteLine("\nСравнение is и as:");
//            object testObj = 123;

//            bool isInt = testObj is int;
//            int? asIntResult = testObj as int?;

//            Console.WriteLine($"is int: {isInt}");
//            Console.WriteLine($"as int?: {asIntResult}");
//            Console.WriteLine($"Эквивалентны: {isInt == asIntResult.HasValue}");
//        }
//    }
//}

//31
//using System;
//using System.Collections.Generic;

//namespace DynamicBoxingDemo
//{
//    struct Measurement
//    {
//        public double Value;
//        public string Unit;

//        public Measurement(double value, string unit)
//        {
//            Value = value;
//            Unit = unit;
//        }

//        public override string ToString()
//        {
//            return $"{Value} {Unit}";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            int intValue = 100;
//            double doubleValue = 3.14;
//            Measurement measurement = new Measurement(25.5, "cm");

//            Console.WriteLine("Присваивание dynamic (упаковка):");
//            dynamic dynInt = intValue;
//            dynamic dynDouble = doubleValue;
//            dynamic dynMeasurement = measurement;

//            Console.WriteLine($"dynInt: {dynInt} типа {dynInt.GetType()}");
//            Console.WriteLine($"dynDouble: {dynDouble} типа {dynDouble.GetType()}");
//            Console.WriteLine($"dynMeasurement: {dynMeasurement} типа {dynMeasurement.GetType()}");

//            Console.WriteLine("\nОперации с dynamic:");
//            dynamic result1 = dynInt + 50;
//            dynamic result2 = dynDouble * 2;
//            Console.WriteLine($"dynInt + 50 = {result1} типа {result1.GetType()}");
//            Console.WriteLine($"dynDouble * 2 = {result2} типа {result2.GetType()}");

//            Console.WriteLine("\nВызов методов через dynamic:");
//            dynamic strResult = dynMeasurement.ToString();
//            Console.WriteLine($"ToString(): {strResult} типа {strResult.GetType()}");

//            Console.WriteLine("\nDynamic в коллекциях:");
//            List<dynamic> dynamicList = new List<dynamic>();
//            dynamicList.Add(42);
//            dynamicList.Add(3.14);
//            dynamicList.Add(true);
//            dynamicList.Add(new Measurement(10, "m"));

//            Console.WriteLine("Содержимое List<dynamic>:");
//            foreach (dynamic item in dynamicList)
//            {
//                Console.WriteLine($"  {item} (тип: {item.GetType()})");
//            }

//            Console.WriteLine("\nИзменение типа dynamic:");
//            dynamic changing = 100;
//            Console.WriteLine($"Изначально: {changing} ({changing.GetType()})");
//            changing = "Теперь строка";
//            Console.WriteLine($"После изменения: {changing} ({changing.GetType()})");
//        }
//    }
//}

//32
//using System;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text.Json;

//namespace SerializationBoxingDemo
//{
//    [Serializable]
//    struct Person
//    {
//        public string Name;
//        public int Age;
//        public decimal Salary;

//        public Person(string name, int age, decimal salary)
//        {
//            Name = name;
//            Age = age;
//            Salary = salary;
//        }

//        public override string ToString()
//        {
//            return $"{Name}, {Age} лет, ЗП: {Salary:C}";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Person person = new Person("Иван", 30, 50000.50m);

//            Console.WriteLine("Бинарная сериализация:");
//            BinaryFormatter formatter = new BinaryFormatter();
//            using (MemoryStream stream = new MemoryStream())
//            {
//                formatter.Serialize(stream, person);
//                Console.WriteLine($"Размер сериализованных данных: {stream.Length} байт");

//                stream.Position = 0;
//                object deserialized = formatter.Deserialize(stream);
//                Console.WriteLine($"Десериализовано: {deserialized} типа {deserialized.GetType()}");
//            }

//            Console.WriteLine("\nJSON сериализация (System.Text.Json):");
//            string json = JsonSerializer.Serialize(person);
//            Console.WriteLine($"JSON: {json}");

//            Person deserializedPerson = JsonSerializer.Deserialize<Person>(json);
//            Console.WriteLine($"Десериализовано: {deserializedPerson}");

//            Console.WriteLine("\nСериализация массива структур:");
//            Person[] people = {
//                new Person("Анна", 25, 40000),
//                new Person("Петр", 35, 60000),
//                new Person("Мария", 28, 45000)
//            };

//            string jsonArray = JsonSerializer.Serialize(people);
//            Console.WriteLine($"JSON массив: {jsonArray}");

//            Console.WriteLine("\nСравнение с сериализацией класса:");
//            object boxedPerson = person;
//            string jsonBoxed = JsonSerializer.Serialize(boxedPerson);
//            Console.WriteLine($"Упакованная структура: {jsonBoxed}");
//        }
//    }
//}

//33
//using System;
//using System.Text;

//namespace StringFormatBoxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            int age = 25;
//            double salary = 50000.50;
//            bool isActive = true;
//            char grade = 'A';
//            DateTime birthDate = new DateTime(1990, 5, 15);

//            Console.WriteLine("String.Format с различными типами значений:");
//            string formatted = String.Format(
//                "Возраст: {0}, Зарплата: {1:C}, Активен: {2}, Оценка: {3}, Дата: {4:yyyy-MM-dd}",
//                age, salary, isActive, grade, birthDate
//            );
//            Console.WriteLine(formatted);

//            Console.WriteLine("\nComposite formatting:");
//            Console.WriteLine("Имя: {0}, Возраст: {1}, Рост: {2:F2}м", "Иван", 30, 1.85);
//            Console.WriteLine("Цена: {0:C}, Количество: {1}, Итого: {2:C}", 99.99, 5, 99.99 * 5);

//            Console.WriteLine("\nString.Format с пользовательскими форматами:");
//            string customFormatted = String.Format(
//                "Число: {0:D5}, Процент: {1:P1}, Научный: {2:E2}",
//                42, 0.456, 12345.6789
//            );
//            Console.WriteLine(customFormatted);

//            Console.WriteLine("\nСравнение производительности:");
//            var sw = System.Diagnostics.Stopwatch.StartNew();
//            for (int i = 0; i < 10000; i++)
//            {
//                string result = String.Format("Number: {0}, Double: {1}", i, i * 1.5);
//            }
//            sw.Stop();
//            Console.WriteLine($"String.Format: {sw.ElapsedMilliseconds} мс");

//            sw.Restart();
//            for (int i = 0; i < 10000; i++)
//            {
//                string result = $"Number: {i}, Double: {i * 1.5}";
//            }
//            sw.Stop();
//            Console.WriteLine($"Интерполяция строк: {sw.ElapsedMilliseconds} мс");
//        }
//    }
//}

//34
//using System;

//namespace NullableBoxingDemo
//{
//    class Program
//    {
//        static void Main()
//        {

//            int? nullableInt = 42;
//            double? nullableDouble = 3.14;
//            bool? nullableBool = true;
//            int? nullInt = null;
//            DateTime? nullableDate = DateTime.Now;

//            Console.WriteLine("Nullable значения:");
//            Console.WriteLine($"int?: {nullableInt}");
//            Console.WriteLine($"double?: {nullableDouble}");
//            Console.WriteLine($"bool?: {nullableBool}");
//            Console.WriteLine($"null int?: {nullInt}");
//            Console.WriteLine($"DateTime?: {nullableDate}");

//            Console.WriteLine("\nУпаковка Nullable<T> в object:");
//            object boxedNullableInt = nullableInt;
//            object boxedNullableDouble = nullableDouble;
//            object boxedNullableBool = nullableBool;
//            object boxedNull = nullInt;
//            object boxedNullableDate = nullableDate;

//            Console.WriteLine($"boxed int?: {boxedNullableInt} (тип: {boxedNullableInt.GetType()})");
//            Console.WriteLine($"boxed double?: {boxedNullableDouble} (тип: {boxedNullableDouble.GetType()})");
//            Console.WriteLine($"boxed bool?: {boxedNullableBool} (тип: {boxedNullableBool.GetType()})");
//            Console.WriteLine($"boxed null: {boxedNull} (тип: {boxedNull?.GetType()?.Name ?? "null"})");
//            Console.WriteLine($"boxed DateTime?: {boxedNullableDate} (тип: {boxedNullableDate.GetType()})");

//            Console.WriteLine("\nПоведение при упаковке null:");
//            Console.WriteLine($"nullableInt.HasValue: {nullableInt.HasValue}");
//            Console.WriteLine($"nullInt.HasValue: {nullInt.HasValue}");
//            Console.WriteLine($"boxedNullableInt == null: {boxedNullableInt == null}");
//            Console.WriteLine($"boxedNull == null: {boxedNull == null}");

//            Console.WriteLine("\nРаспаковка Nullable:");
//            if (boxedNullableInt is int unboxedInt)
//            {
//                Console.WriteLine($"Распакован int: {unboxedInt}");
//            }

//            if (boxedNullableDouble is double unboxedDouble)
//            {
//                Console.WriteLine($"Распакован double: {unboxedDouble}");
//            }

//            Console.WriteLine("\nИспользование GetValueOrDefault:");
//            int defaultValue1 = nullableInt.GetValueOrDefault();
//            int defaultValue2 = nullInt.GetValueOrDefault(999);
//            Console.WriteLine($"GetValueOrDefault(42): {defaultValue1}");
//            Console.WriteLine($"GetValueOrDefault(null, 999): {defaultValue2}");

//            Console.WriteLine("\nNullable в коллекциях:");
//            object[] objects = { nullableInt, nullableDouble, nullableBool, nullInt, nullableDate };
//            foreach (object obj in objects)
//            {
//                Console.WriteLine($"Значение: {obj,-10} Тип: {obj?.GetType()?.Name ?? "null",-15} IsNull: {obj == null}");
//            }
//        }
//    }
//}

//35
//using System;

//namespace EqualsBoxingDemo
//{
//    struct Point
//    {
//        public int X, Y;

//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }

//        public override bool Equals(object obj)
//        {
//            if (obj is Point other)
//            {
//                return X == other.X && Y == other.Y;
//            }
//            return false;
//        }

//        public override int GetHashCode()
//        {
//            return HashCode.Combine(X, Y);
//        }

//        public override string ToString()
//        {
//            return $"({X}, {Y})";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Point point1 = new Point(10, 20);
//            Point point2 = new Point(10, 20);
//            Point point3 = new Point(30, 40);

//            Console.WriteLine("Сравнение структур через Equals:");
//            bool equals1 = point1.Equals(point2);
//            Console.WriteLine($"point1.Equals(point2): {equals1} (упаковка не происходит)");

//            bool equals2 = point1.Equals(point3);
//            Console.WriteLine($"point1.Equals(point3): {equals2} (упаковка не происходит)");

//            Console.WriteLine("\nСравнение с упакованными структурами:");
//            object boxedPoint1 = point1;
//            object boxedPoint2 = point2;
//            object boxedPoint3 = point3;

//            bool equals3 = boxedPoint1.Equals(boxedPoint2);
//            Console.WriteLine($"boxedPoint1.Equals(boxedPoint2): {equals3}");

//            bool equals4 = boxedPoint1.Equals(boxedPoint3);
//            Console.WriteLine($"boxedPoint1.Equals(boxedPoint3): {equals4}");

//            Console.WriteLine("\nСравнение разных типов:");
//            object stringObj = "(10, 20)";
//            bool equals5 = boxedPoint1.Equals(stringObj);
//            Console.WriteLine($"boxedPoint1.Equals(string): {equals5}");

//            Console.WriteLine("\nИспользование static object.Equals:");
//            bool staticEquals1 = object.Equals(point1, point2);
//            Console.WriteLine($"object.Equals(point1, point2): {staticEquals1}");

//            bool staticEquals2 = object.Equals(boxedPoint1, boxedPoint2);
//            Console.WriteLine($"object.Equals(boxedPoint1, boxedPoint2): {staticEquals2}");

//            Console.WriteLine("\nСравнение с null:");
//            bool equalsNull1 = point1.Equals(null);
//            Console.WriteLine($"point1.Equals(null): {equalsNull1}");

//            bool equalsNull2 = boxedPoint1.Equals(null);
//            Console.WriteLine($"boxedPoint1.Equals(null): {equalsNull2}");
//        }
//    }
//}

//36
//using System;

//namespace AttributesBoxingDemo
//{
//    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
//    class CustomAttribute : Attribute
//    {
//        public object Value { get; }
//        public int Number { get; }
//        public string Text { get; }

//        public CustomAttribute(object value, int number, string text)
//        {
//            Value = value;
//            Number = number;
//            Text = text;
//        }
//    }

//    [Custom(42, 100, "Integer value")]
//    [Custom(3.14, 200, "Double value")]
//    [Custom(true, 300, "Boolean value")]
//    struct DataContainer
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }

//        [Custom('A', 400, "Char value")]
//        public void Process()
//        {
//            Console.WriteLine("Processing data...");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Type containerType = typeof(DataContainer);

//            Console.WriteLine("Атрибуты типа:");
//            object[] typeAttributes = containerType.GetCustomAttributes(typeof(CustomAttribute), false);
//            foreach (CustomAttribute attr in typeAttributes)
//            {
//                Console.WriteLine($"Value: {attr.Value} (тип: {attr.Value.GetType()}), Number: {attr.Number}, Text: {attr.Text}");
//            }

//            Console.WriteLine("\nАтрибуты метода:");
//            var method = containerType.GetMethod("Process");
//            object[] methodAttributes = method.GetCustomAttributes(typeof(CustomAttribute), false);
//            foreach (CustomAttribute attr in methodAttributes)
//            {
//                Console.WriteLine($"Value: {attr.Value} (тип: {attr.Value.GetType()}), Number: {attr.Number}, Text: {attr.Text}");
//            }

//            Console.WriteLine("\nСоздание атрибутов с упаковкой:");
//            var attribute1 = new CustomAttribute(123, 1, "int value");
//            var attribute2 = new CustomAttribute(45.67, 2, "double value");
//            var attribute3 = new CustomAttribute(false, 3, "bool value");

//            Console.WriteLine($"Атрибут 1: {attribute1.Value} типа {attribute1.Value.GetType()}");
//            Console.WriteLine($"Атрибут 2: {attribute2.Value} типа {attribute2.Value.GetType()}");
//            Console.WriteLine($"Атрибут 3: {attribute3.Value} типа {attribute3.Value.GetType()}");

//            Console.WriteLine("\nАтрибуты с nullable типами:");
//            var attribute4 = new CustomAttribute((int?)42, 4, "nullable int");
//            Console.WriteLine($"Nullable атрибут: {attribute4.Value} типа {attribute4.Value.GetType()}");
//        }
//    }
//}

//37
//using System;
//using System.Reflection;

//namespace MethodInfoInvokeBoxingDemo
//{
//    struct Calculator
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }

//        public double Multiply(double a, double b)
//        {
//            return a * b;
//        }

//        public string Format(int number, string prefix)
//        {
//            return $"{prefix}: {number}";
//        }

//        public void DisplayValue(object value)
//        {
//            Console.WriteLine($"Значение: {value} типа {value.GetType()}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Calculator calculator = new Calculator();
//            Type calculatorType = typeof(Calculator);

//            Console.WriteLine("Вызов метода Add через reflection:");
//            MethodInfo addMethod = calculatorType.GetMethod("Add");
//            object[] addParams = { 10, 20 };
//            object addResult = addMethod.Invoke(calculator, addParams);
//            Console.WriteLine($"Результат: {addResult} типа {addResult.GetType()}");

//            Console.WriteLine("\nВызов метода Multiply через reflection:");
//            MethodInfo multiplyMethod = calculatorType.GetMethod("Multiply");
//            object[] multiplyParams = { 2.5, 4.0 };
//            object multiplyResult = multiplyMethod.Invoke(calculator, multiplyParams);
//            Console.WriteLine($"Результат: {multiplyResult} типа {multiplyResult.GetType()}");

//            Console.WriteLine("\nВызов метода Format через reflection:");
//            MethodInfo formatMethod = calculatorType.GetMethod("Format");
//            object[] formatParams = { 42, "Number" };
//            object formatResult = formatMethod.Invoke(calculator, formatParams);
//            Console.WriteLine($"Результат: {formatResult} типа {formatResult.GetType()}");

//            Console.WriteLine("\nВызов метода DisplayValue с упаковкой:");
//            MethodInfo displayMethod = calculatorType.GetMethod("DisplayValue");
//            object[] displayParams = { 100 };
//            displayMethod.Invoke(calculator, displayParams);

//            object[] displayParams2 = { 3.14 };
//            displayMethod.Invoke(calculator, displayParams2);

//            Console.WriteLine("\nВызов статических методов через reflection:");
//            MethodInfo writeLineMethod = typeof(Console).GetMethod("WriteLine", new Type[] { typeof(object) });
//            object[] consoleParams = { "Hello from reflection!" };
//            writeLineMethod.Invoke(null, consoleParams);

//            Console.WriteLine("\nВызов методов с возвращаемым типом void:");
//            MethodInfo voidMethod = calculatorType.GetMethod("DisplayValue");
//            object[] voidParams = { true };
//            object voidResult = voidMethod.Invoke(calculator, voidParams);
//            Console.WriteLine($"Результат void метода: {voidResult}");
//        }
//    }
//}

//38
//using System;

//namespace WeakReferenceBoxingDemo
//{
//    struct LargeStruct
//    {
//        public long Data1;
//        public long Data2;
//        public long Data3;
//        public long Data4;

//        public LargeStruct(long value)
//        {
//            Data1 = value;
//            Data2 = value * 2;
//            Data3 = value * 3;
//            Data4 = value * 4;
//        }

//        public override string ToString()
//        {
//            return $"LargeStruct({Data1}, {Data2}, {Data3}, {Data4})";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Console.WriteLine("WeakReference с упакованной структурой:");
//            LargeStruct largeStruct = new LargeStruct(100);
//            object boxedStruct = largeStruct;
//            WeakReference weakRef = new WeakReference(boxedStruct);

//            Console.WriteLine($"Исходная структура: {largeStruct}");
//            Console.WriteLine($"WeakReference IsAlive: {weakRef.IsAlive}");

//            if (weakRef.IsAlive)
//            {
//                object target = weakRef.Target;
//                Console.WriteLine($"Получен из WeakReference: {target} типа {target.GetType()}");
//            }

//            Console.WriteLine("\nПринудительная сборка мусора:");
//            boxedStruct = null;
//            GC.Collect();
//            GC.WaitForPendingFinalizers();

//            Console.WriteLine($"WeakReference IsAlive после GC: {weakRef.IsAlive}");

//            Console.WriteLine("\nWeakReference с разными типами значений:");
//            WeakReference weakInt = new WeakReference(42);
//            WeakReference weakDouble = new WeakReference(3.14);
//            WeakReference weakBool = new WeakReference(true);

//            Console.WriteLine($"weakInt IsAlive: {weakInt.IsAlive}, Target: {weakInt.Target}");
//            Console.WriteLine($"weakDouble IsAlive: {weakDouble.IsAlive}, Target: {weakDouble.Target}");
//            Console.WriteLine($"weakBool IsAlive: {weakBool.IsAlive}, Target: {weakBool.Target}");

//            Console.WriteLine("\nДолгоживущие WeakReference:");
//            WeakReference longWeakRef = new WeakReference(999, true);
//            Console.WriteLine($"Long WeakReference IsAlive: {longWeakRef.IsAlive}");

//            if (longWeakRef.Target != null)
//            {
//                Console.WriteLine($"Long WeakReference Target: {longWeakRef.Target}");
//            }

//            Console.WriteLine("\nМассив WeakReference:");
//            WeakReference[] weakRefs = new WeakReference[5];
//            for (int i = 0; i < weakRefs.Length; i++)
//            {
//                weakRefs[i] = new WeakReference(i * 10);
//            }

//            Console.WriteLine("Содержимое массива WeakReference:");
//            for (int i = 0; i < weakRefs.Length; i++)
//            {
//                if (weakRefs[i].IsAlive)
//                {
//                    Console.WriteLine($"[{i}]: {weakRefs[i].Target}");
//                }
//                else
//                {
//                    Console.WriteLine($"[{i}]: collected");
//                }
//            }
//        }
//    }
//}

//39
//using System;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;

//namespace ConditionalWeakTableDemo
//{
//    struct DataPoint
//    {
//        public double X, Y;

//        public DataPoint(double x, double y)
//        {
//            X = x;
//            Y = y;
//        }

//        public override string ToString()
//        {
//            return $"({X}, {Y})";
//        }
//    }

//    class Metadata
//    {
//        public string Description { get; set; }
//        public DateTime Created { get; set; }

//        public Metadata(string description)
//        {
//            Description = description;
//            Created = DateTime.Now;
//        }

//        public override string ToString()
//        {
//            return $"{Description} (создано: {Created:HH:mm:ss})";
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            var metadataTable = new ConditionalWeakTable<object, Metadata>();

//            Console.WriteLine("Добавление метаданных к упакованным значениям:");

//            int intValue = 42;
//            object boxedInt = intValue;
//            metadataTable.Add(boxedInt, new Metadata("Важное число"));

//            double doubleValue = 3.14;
//            object boxedDouble = doubleValue;
//            metadataTable.Add(boxedDouble, new Metadata("Значение PI"));

//            DataPoint point = new DataPoint(10.5, 20.3);
//            object boxedPoint = point;
//            metadataTable.Add(boxedPoint, new Metadata("Точка данных"));

//            Console.WriteLine("Получение метаданных:");
//            if (metadataTable.TryGetValue(boxedInt, out Metadata intMetadata))
//            {
//                Console.WriteLine($"int {boxedInt}: {intMetadata}");
//            }

//            if (metadataTable.TryGetValue(boxedDouble, out Metadata doubleMetadata))
//            {
//                Console.WriteLine($"double {boxedDouble}: {doubleMetadata}");
//            }

//            if (metadataTable.TryGetValue(boxedPoint, out Metadata pointMetadata))
//            {
//                Console.WriteLine($"point {boxedPoint}: {pointMetadata}");
//            }

//            Console.WriteLine("\nОбновление метаданных:");
//            metadataTable.AddOrUpdate(boxedInt, new Metadata("Обновленное число"));
//            if (metadataTable.TryGetValue(boxedInt, out Metadata updatedMetadata))
//            {
//                Console.WriteLine($"Обновленные метаданны: {updatedMetadata}");
//            }

//            Console.WriteLine("\nПроверка после сборки мусора:");
//            boxedDouble = null;
//            GC.Collect();
//            GC.WaitForPendingFinalizers();

//            Console.WriteLine("Попытка получить метаданные для удаленного объекта...");
//            if (metadataTable.TryGetValue(boxedDouble, out Metadata collectedMetadata))
//            {
//                Console.WriteLine($"Найдены: {collectedMetadata}");
//            }
//            else
//            {
//                Console.WriteLine("Метаданные удалены вместе с объектом");
//            }

//            Console.WriteLine("\nРабота с существующими объектами:");
//            if (metadataTable.TryGetValue(boxedInt, out Metadata existingMetadata))
//            {
//                Console.WriteLine($"Метаданные существуют: {existingMetadata}");
//            }
//        }
//    }
//}

//40
//using System;
//using System.Diagnostics;
//using System.Collections;

//namespace BoxingPerformanceComparisonDemo
//{
//    struct TestStruct
//    {
//        public int Value;

//        public TestStruct(int value)
//        {
//            Value = value;
//        }
//    }

//    class Program
//    {
//        const int Iterations = 10000000;

//        static long MeasureDirectOperations()
//        {
//            var sw = Stopwatch.StartNew();
//            int sum = 0;
//            for (int i = 0; i < Iterations; i++)
//            {
//                sum += i;
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureBoxingUnboxing()
//        {
//            var sw = Stopwatch.StartNew();
//            object sum = 0;
//            for (int i = 0; i < Iterations; i++)
//            {
//                sum = (int)sum + i;
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureArrayList()
//        {
//            var sw = Stopwatch.StartNew();
//            ArrayList list = new ArrayList();
//            for (int i = 0; i < Iterations / 10; i++)
//            {
//                list.Add(i);
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureGenericList()
//        {
//            var sw = Stopwatch.StartNew();
//            var list = new System.Collections.Generic.List<int>();
//            for (int i = 0; i < Iterations / 10; i++)
//            {
//                list.Add(i);
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureObjectArray()
//        {
//            var sw = Stopwatch.StartNew();
//            object[] array = new object[Iterations / 100];
//            for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = i;
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureIntArray()
//        {
//            var sw = Stopwatch.StartNew();
//            int[] array = new int[Iterations / 100];
//            for (int i = 0; i < array.Length; i++)
//            {
//                array[i] = i;
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureMethodCalls()
//        {
//            var sw = Stopwatch.StartNew();
//            for (int i = 0; i < Iterations; i++)
//            {
//                ProcessValue(i);
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static long MeasureBoxedMethodCalls()
//        {
//            var sw = Stopwatch.StartNew();
//            for (int i = 0; i < Iterations; i++)
//            {
//                ProcessObject(i);
//            }
//            sw.Stop();
//            return sw.ElapsedMilliseconds;
//        }

//        static void ProcessValue(int value) { }
//        static void ProcessObject(object value) { }

//        static void RunComparison(string name, Func<long> test, Func<long> baseline = null)
//        {
//            Console.WriteLine($"\n--- {name} ---");

//            GC.Collect();
//            GC.WaitForPendingFinalizers();

//            long time = test();
//            Console.WriteLine($"Время: {time} мс");

//            if (baseline != null)
//            {
//                long baselineTime = baseline();
//                double slowdown = (double)time / baselineTime;
//                Console.WriteLine($"Замедление: {slowdown:F2}x");
//            }
//        }

//        static void Main()
//        {
//            Console.WriteLine($"Количество итераций: {Iterations:N0}\n");

//            RunComparison("Прямые операции с int", MeasureDirectOperations);
//            RunComparison("Упаковка/распаковка", MeasureBoxingUnboxing, MeasureDirectOperations);

//            RunComparison("ArrayList (с упаковкой)", MeasureArrayList);
//            RunComparison("List<int> (без упаковки)", MeasureGenericList, MeasureArrayList);

//            RunComparison("object[] (с упаковкой)", MeasureObjectArray);
//            RunComparison("int[] (без упаковки)", MeasureIntArray, MeasureObjectArray);

//            RunComparison("Вызов метода с int", MeasureMethodCalls);
//            RunComparison("Вызов метода с object", MeasureBoxedMethodCalls, MeasureMethodCalls);

//            Console.WriteLine("\n=== ВЫВОДЫ ===");
//            Console.WriteLine("1. Упаковка/распаковка добавляет 2-10x замедление");
//            Console.WriteLine("2. Generic коллекции значительно быстрее нетипизированных");
//            Console.WriteLine("3. Типизированные массивы быстрее object[] массивов");
//            Console.WriteLine("4. Методы с object параметрами медленнее из-за упаковки");
//            Console.WriteLine("5. Следует минимизировать упаковку в performance-critical коде");
//        }
//    }
//}

//41
//using System;

//namespace AgeCalculatorDemo
//{
//    class Program
//    {
//        static int CalculateAge(DateTime birthDate)
//        {
//            DateTime today = DateTime.Today;
//            int age = today.Year - birthDate.Year;

//            if (birthDate.Date > today.AddYears(-age))
//                age--;

//            return age;
//        }

//        static void Main()
//        {

//            DateTime birthDate1 = new DateTime(1990, 5, 15);
//            DateTime birthDate2 = new DateTime(1985, 12, 25);
//            DateTime birthDate3 = new DateTime(2000, 2, 29);
//            DateTime birthDate4 = DateTime.Today.AddYears(-25);

//            Console.WriteLine($"Дата рождения: {birthDate1:dd.MM.yyyy} -> Возраст: {CalculateAge(birthDate1)}");
//            Console.WriteLine($"Дата рождения: {birthDate2:dd.MM.yyyy} -> Возраст: {CalculateAge(birthDate2)}");
//            Console.WriteLine($"Дата рождения: {birthDate3:dd.MM.yyyy} -> Возраст: {CalculateAge(birthDate3)}");
//            Console.WriteLine($"Дата рождения: {birthDate4:dd.MM.yyyy} -> Возраст: {CalculateAge(birthDate4)}");

//            Console.WriteLine($"\nТекущая дата: {DateTime.Today:dd.MM.yyyy}");
//        }
//    }
//}

//42
//using System;

//namespace WorkingDaysCalculatorDemo
//{
//    class Program
//    {
//        static int CalculateWorkingDays(DateTime startDate, DateTime endDate)
//        {
//            if (startDate > endDate)
//            {
//                DateTime temp = startDate;
//                startDate = endDate;
//                endDate = temp;
//            }

//            int workingDays = 0;
//            DateTime current = startDate;

//            while (current <= endDate)
//            {
//                if (current.DayOfWeek != DayOfWeek.Saturday && current.DayOfWeek != DayOfWeek.Sunday)
//                {
//                    workingDays++;
//                }
//                current = current.AddDays(1);
//            }

//            return workingDays;
//        }

//        static void Main()
//        {

//            DateTime start1 = new DateTime(2024, 1, 1);
//            DateTime end1 = new DateTime(2024, 1, 31);

//            DateTime start2 = new DateTime(2024, 3, 1);
//            DateTime end2 = new DateTime(2024, 3, 15);

//            DateTime start3 = DateTime.Today;
//            DateTime end3 = DateTime.Today.AddDays(14);

//            Console.WriteLine($"Период: {start1:dd.MM.yyyy} - {end1:dd.MM.yyyy}");
//            Console.WriteLine($"Рабочих дней: {CalculateWorkingDays(start1, end1)}");

//            Console.WriteLine($"\nПериод: {start2:dd.MM.yyyy} - {end2:dd.MM.yyyy}");
//            Console.WriteLine($"Рабочих дней: {CalculateWorkingDays(start2, end2)}");

//            Console.WriteLine($"\nПериод: {start3:dd.MM.yyyy} - {end3:dd.MM.yyyy}");
//            Console.WriteLine($"Рабочих дней: {CalculateWorkingDays(start3, end3)}");
//        }
//    }
//}

//43
//using System;

//namespace DaysUntilEndOfYearDemo
//{
//    class Program
//    {
//        static int DaysUntilEndOfYear(DateTime date)
//        {
//            DateTime endOfYear = new DateTime(date.Year, 12, 31);
//            return (endOfYear - date).Days;
//        }

//        static void Main()
//        {

//            DateTime date1 = new DateTime(2024, 1, 1);
//            DateTime date2 = new DateTime(2024, 6, 30);
//            DateTime date3 = new DateTime(2024, 12, 25);
//            DateTime today = DateTime.Today;

//            Console.WriteLine($"Дата: {date1:dd.MM.yyyy} -> Дней до конца года: {DaysUntilEndOfYear(date1)}");
//            Console.WriteLine($"Дата: {date2:dd.MM.yyyy} -> Дней до конца года: {DaysUntilEndOfYear(date2)}");
//            Console.WriteLine($"Дата: {date3:dd.MM.yyyy} -> Дней до конца года: {DaysUntilEndOfYear(date3)}");
//            Console.WriteLine($"Сегодня: {today:dd.MM.yyyy} -> Дней до конца года: {DaysUntilEndOfYear(today)}");
//        }
//    }
//}

//44
//using System;
//using System.Globalization;

//namespace DateTimeFormattingDemo
//{
//    class Program
//    {
//        static void DisplayFormattedDateTime(DateTime dateTime, CultureInfo culture)
//        {
//            Console.WriteLine($"\nКультура: {culture.DisplayName} ({culture.Name})");
//            Console.WriteLine($"  Полная дата: {dateTime.ToString("F", culture)}");
//            Console.WriteLine($"  Короткая дата: {dateTime.ToString("d", culture)}");
//            Console.WriteLine($"  Длинная дата: {dateTime.ToString("D", culture)}");
//            Console.WriteLine($"  Время: {dateTime.ToString("T", culture)}");
//            Console.WriteLine($"  Общий формат: {dateTime.ToString("G", culture)}");
//        }

//        static void Main()
//        {

//            DateTime dateTime = new DateTime(2024, 3, 15, 14, 30, 45);

//            CultureInfo[] cultures = {
//                new CultureInfo("ru-RU"),
//                new CultureInfo("en-US"),
//                new CultureInfo("de-DE"),
//                new CultureInfo("fr-FR"),
//                new CultureInfo("ja-JP")
//            };

//            foreach (var culture in cultures)
//            {
//                DisplayFormattedDateTime(dateTime, culture);
//            }
//        }
//    }
//}

//45
//using System;

//namespace DateDifferenceDemo
//{
//    class Program
//    {
//        static void GetDateDifference(DateTime date1, DateTime date2)
//        {
//            if (date1 > date2)
//            {
//                DateTime temp = date1;
//                date1 = date2;
//                date2 = temp;
//            }

//            int years = date2.Year - date1.Year;
//            int months = date2.Month - date1.Month;
//            int days = date2.Day - date1.Day;

//            if (days < 0)
//            {
//                months--;
//                DateTime previousMonth = date2.AddMonths(-1);
//                days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
//            }

//            if (months < 0)
//            {
//                years--;
//                months += 12;
//            }

//            Console.WriteLine($"Разница: {years} лет, {months} месяцев, {days} дней");
//        }

//        static void Main()
//        {

//            DateTime date1 = new DateTime(2020, 1, 15);
//            DateTime date2 = new DateTime(2024, 3, 10);

//            DateTime date3 = new DateTime(2023, 12, 25);
//            DateTime date4 = new DateTime(2024, 2, 15);

//            DateTime date5 = new DateTime(2022, 5, 20);
//            DateTime date6 = new DateTime(2022, 5, 25);

//            Console.WriteLine($"Дата 1: {date1:dd.MM.yyyy}, Дата 2: {date2:dd.MM.yyyy}");
//            GetDateDifference(date1, date2);

//            Console.WriteLine($"\nДата 1: {date3:dd.MM.yyyy}, Дата 2: {date4:dd.MM.yyyy}");
//            GetDateDifference(date3, date4);

//            Console.WriteLine($"\nДата 1: {date5:dd.MM.yyyy}, Дата 2: {date6:dd.MM.yyyy}");
//            GetDateDifference(date5, date6);
//        }
//    }
//}

//46
//using System;

//namespace DateTimeParsingDemo
//{
//    class Program
//    {
//        static void ParseDateTime(string dateString)
//        {
//            Console.WriteLine($"\nПарсинг строки: '{dateString}'");

//            string[] formats = {
//                "dd.MM.yyyy",
//                "dd/MM/yyyy",
//                "yyyy-MM-dd",
//                "MM/dd/yyyy",
//                "dd MMMM yyyy",
//                "yyyyMMdd"
//            };

//            foreach (string format in formats)
//            {
//                try
//                {
//                    DateTime result = DateTime.ParseExact(dateString, format, null);
//                    Console.WriteLine($"  Формат '{format}': {result:dd.MM.yyyy}");
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine($"  Формат '{format}': не подходит");
//                }
//            }

//            try
//            {
//                DateTime autoParse = DateTime.Parse(dateString);
//                Console.WriteLine($"  Автопарсинг: {autoParse:dd.MM.yyyy}");
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine($"  Автопарсинг: не удался");
//            }
//        }

//        static void Main()
//        {

//            ParseDateTime("15.03.2024");
//            ParseDateTime("2024-03-15");
//            ParseDateTime("03/15/2024");
//            ParseDateTime("15 марта 2024");
//            ParseDateTime("20240315");
//        }
//    }
//}

//47
//using System;

//namespace AddWorkingDaysDemo
//{
//    class Program
//    {
//        static DateTime AddWorkingDays(DateTime startDate, int workingDays)
//        {
//            DateTime result = startDate;
//            int daysAdded = 0;

//            while (daysAdded < workingDays)
//            {
//                result = result.AddDays(1);
//                if (result.DayOfWeek != DayOfWeek.Saturday && result.DayOfWeek != DayOfWeek.Sunday)
//                {
//                    daysAdded++;
//                }
//            }

//            return result;
//        }

//        static void Main()
//        {

//            DateTime startDate1 = new DateTime(2024, 3, 15);
//            DateTime startDate2 = new DateTime(2024, 3, 22);

//            Console.WriteLine($"Начальная дата: {startDate1:dd.MM.yyyy} ({startDate1:dddd})");
//            Console.WriteLine($"+5 рабочих дней: {AddWorkingDays(startDate1, 5):dd.MM.yyyy} ({AddWorkingDays(startDate1, 5):dddd})");
//            Console.WriteLine($"+10 рабочих дней: {AddWorkingDays(startDate1, 10):dd.MM.yyyy} ({AddWorkingDays(startDate1, 10):dddd})");

//            Console.WriteLine($"\nНачальная дата: {startDate2:dd.MM.yyyy} ({startDate2:dddd})");
//            Console.WriteLine($"+3 рабочих дня: {AddWorkingDays(startDate2, 3):dd.MM.yyyy} ({AddWorkingDays(startDate2, 3):dddd})");
//            Console.WriteLine($"+7 рабочих дней: {AddWorkingDays(startDate2, 7):dd.MM.yyyy} ({AddWorkingDays(startDate2, 7):dddd})");
//        }
//    }
//}

//48
//using System;

//namespace LeapYearDemo
//{
//    class Program
//    {
//        static bool IsLeapYear(int year)
//        {
//            return DateTime.IsLeapYear(year);
//        }

//        static void Main()
//        {

//            int[] years = { 2020, 2021, 2022, 2023, 2024, 1900, 2000, 2100 };

//            foreach (int year in years)
//            {
//                bool isLeap = IsLeapYear(year);
//                Console.WriteLine($"{year} год: {(isLeap ? "високосный" : "не високосный")}");
//            }

//            Console.WriteLine($"\nТекущий год {DateTime.Now.Year}: {(IsLeapYear(DateTime.Now.Year) ? "високосный" : "не високосный")}");
//        }
//    }
//}

//49
//using System;

//namespace MonthBoundariesDemo
//{
//    class Program
//    {
//        static void GetMonthBoundaries(DateTime date)
//        {
//            DateTime firstDay = new DateTime(date.Year, date.Month, 1);
//            DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

//            Console.WriteLine($"Месяц: {date:MMMM yyyy}");
//            Console.WriteLine($"  Первый день: {firstDay:dd.MM.yyyy} ({firstDay:dddd})");
//            Console.WriteLine($"  Последний день: {lastDay:dd.MM.yyyy} ({lastDay:dddd})");
//            Console.WriteLine($"  Количество дней: {DateTime.DaysInMonth(date.Year, date.Month)}");
//        }

//        static void Main()
//        {

//            DateTime date1 = new DateTime(2024, 1, 15);
//            DateTime date2 = new DateTime(2024, 2, 15);
//            DateTime date3 = new DateTime(2024, 3, 15);
//            DateTime date4 = new DateTime(2024, 4, 15);

//            GetMonthBoundaries(date1);
//            GetMonthBoundaries(date2);
//            GetMonthBoundaries(date3);
//            GetMonthBoundaries(date4);

//            Console.WriteLine($"\nТекущий месяц:");
//            GetMonthBoundaries(DateTime.Today);
//        }
//    }
//}

//50
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CountdownTimerDemo
//{
//    class Program
//    {
//        static async Task CountdownTimer(TimeSpan duration)
//        {
//            Console.WriteLine($"Таймер обратного отсчета: {duration}");

//            TimeSpan remaining = duration;

//            while (remaining > TimeSpan.Zero)
//            {
//                Console.WriteLine($"  Осталось: {remaining:hh\\:mm\\:ss}");
//                await Task.Delay(1000);
//                remaining = remaining.Subtract(TimeSpan.FromSeconds(1));
//            }

//            Console.WriteLine("Время вышло! ⏰");
//        }

//        static void Main()
//        {

//            TimeSpan timer1 = TimeSpan.FromMinutes(1);
//            TimeSpan timer2 = TimeSpan.FromSeconds(10);
//            TimeSpan timer3 = new TimeSpan(0, 0, 5, 0);

//            Console.WriteLine("Запуск 1-минутного таймера:");
//            CountdownTimer(timer1).Wait();

//            Console.WriteLine("\nЗапуск 10-секундного таймера:");
//            CountdownTimer(timer2).Wait();

//            Console.WriteLine("\nЗапуск 5-минутного таймера:");
//            CountdownTimer(timer3).Wait();
//        }
//    }
//}

//51
//using System;

//namespace TimeZoneConverter
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 51: Конвертация UTC и локального времени ===\n");

//            DateTime utcNow = DateTime.UtcNow;
//            Console.WriteLine($"Текущее UTC время: {utcNow:yyyy-MM-dd HH:mm:ss}");

//            // Конвертация UTC в локальное время
//            DateTime localTime = ConvertUtcToLocal(utcNow);
//            Console.WriteLine($"Локальное время: {localTime:yyyy-MM-dd HH:mm:ss}");

//            // Обратная конвертация
//            DateTime backToUtc = ConvertLocalToUtc(localTime);
//            Console.WriteLine($"Обратно в UTC: {backToUtc:yyyy-MM-dd HH:mm:ss}");

//            // Проверка
//            Console.WriteLine($"\nКонвертация корректна: {utcNow == backToUtc}");

//            // Пример с конкретным временем
//            DateTime specificUtc = new DateTime(2024, 1, 15, 12, 0, 0, DateTimeKind.Utc);
//            DateTime specificLocal = ConvertUtcToLocal(specificUtc);
//            Console.WriteLine($"\nКонкретное UTC: {specificUtc:yyyy-MM-dd HH:mm:ss}");
//            Console.WriteLine($"В локальном времени: {specificLocal:yyyy-MM-dd HH:mm:ss}");
//        }

//        static DateTime ConvertUtcToLocal(DateTime utcTime)
//        {
//            return TimeZoneInfo.ConvertTimeFromUtc(utcTime, TimeZoneInfo.Local);
//        }

//        static DateTime ConvertLocalToUtc(DateTime localTime)
//        {
//            return TimeZoneInfo.ConvertTimeToUtc(localTime, TimeZoneInfo.Local);
//        }
//    }
//}



//52
//using System;

//namespace QuarterCalculator
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 52: Определение квартала года ===\n");

//            DateTime[] testDates = {
//                new DateTime(2024, 1, 15),   // 1 квартал
//                new DateTime(2024, 3, 31),   // 1 квартал
//                new DateTime(2024, 4, 20),   // 2 квартал
//                new DateTime(2024, 6, 15),   // 2 квартал
//                new DateTime(2024, 8, 10),   // 3 квартал
//                new DateTime(2024, 9, 30),   // 3 квартал
//                new DateTime(2024, 11, 30),  // 4 квартал
//                new DateTime(2024, 12, 25)   // 4 квартал
//            };

//            foreach (var date in testDates)
//            {
//                int quarter = GetQuarter(date);
//                string season = GetSeason(quarter);
//                Console.WriteLine($"{date:yyyy-MM-dd} -> {quarter} квартал ({season})");
//            }

//            // Текущая дата
//            DateTime today = DateTime.Today;
//            Console.WriteLine($"\nСегодня ({today:yyyy-MM-dd}) -> {GetQuarter(today)} квартал");
//        }

//        static int GetQuarter(DateTime date)
//        {
//            return (date.Month - 1) / 3 + 1;
//        }

//        static string GetSeason(int quarter)
//        {
//            return quarter switch
//            {
//                1 => "Зима-Весна",
//                2 => "Весна-Лето",
//                3 => "Лето-Осень",
//                4 => "Осень-Зима",
//                _ => "Неизвестно"
//            };
//        }
//    }
//}



//53
//using System;

//namespace DateComparer
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 53: Сравнение с прошлым днем ===\n");

//            DateTime today = DateTime.Today;
//            DateTime yesterday = today.AddDays(-1);
//            DateTime tomorrow = today.AddDays(1);
//            DateTime twoDaysAgo = today.AddDays(-2);

//            // Тестирование различных дат
//            TestDateComparison(today, "Сегодня");
//            TestDateComparison(yesterday, "Вчера");
//            TestDateComparison(tomorrow, "Завтра");
//            TestDateComparison(twoDaysAgo, "Позавчера");

//            // Тест с временем (должно игнорироваться)
//            DateTime yesterdayWithTime = yesterday.AddHours(15).AddMinutes(30);
//            Console.WriteLine($"\nВчера с временем {yesterdayWithTime:yyyy-MM-dd HH:mm:ss}:");
//            Console.WriteLine($"Равно прошлому дню: {IsEqualToYesterday(yesterdayWithTime)}");
//        }

//        static void TestDateComparison(DateTime date, string description)
//        {
//            bool result = IsEqualToYesterday(date);
//            Console.WriteLine($"{description} ({date:yyyy-MM-dd}) равно прошлому дню: {result}");
//        }

//        static bool IsEqualToYesterday(DateTime date)
//        {
//            DateTime yesterday = DateTime.Today.AddDays(-1);
//            return date.Date == yesterday;
//        }
//    }
//}



//54
//using System;
//using System.Diagnostics;
//using System.Threading;
//using System.Threading.Tasks;

//namespace AdvancedStopwatch
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 54: Секундомер ===\n");

//            // Простой секундомер
//            SimpleStopwatch();

//            Console.WriteLine("\n" + new string('=', 40) + "\n");

//            // Продвинутый секундомер с паузами
//            AdvancedStopwatch();
//        }

//        static void SimpleStopwatch()
//        {
//            Console.WriteLine("=== Простой секундомер ===");

//            Stopwatch stopwatch = new Stopwatch();

//            Console.WriteLine("Запуск на 2.5 секунды...");
//            stopwatch.Start();
//            Thread.Sleep(2500);
//            stopwatch.Stop();

//            DisplayStopwatchResults(stopwatch);
//        }

//        static void AdvancedStopwatch()
//        {
//            Console.WriteLine("=== Продвинутый секундомер с паузами ===");

//            Stopwatch stopwatch = new Stopwatch();

//            // Первый отрезок
//            Console.WriteLine("Сегмент 1 (1 секунда)...");
//            stopwatch.Start();
//            Thread.Sleep(1000);
//            stopwatch.Stop();
//            Console.WriteLine($"Время после сегмента 1: {stopwatch.Elapsed}");

//            // Пауза
//            Console.WriteLine("Пауза 1 секунда...");
//            Thread.Sleep(1000);

//            // Второй отрезок
//            Console.WriteLine("Сегмент 2 (1.5 секунды)...");
//            stopwatch.Start();
//            Thread.Sleep(1500);
//            stopwatch.Stop();

//            DisplayStopwatchResults(stopwatch);

//            // Сброс и новый замер
//            Console.WriteLine("\n--- Сброс и новый замер ---");
//            stopwatch.Reset();
//            stopwatch.Start();
//            Thread.Sleep(800);
//            stopwatch.Stop();

//            DisplayStopwatchResults(stopwatch);
//        }

//        static void DisplayStopwatchResults(Stopwatch stopwatch)
//        {
//            Console.WriteLine("\nРезультаты измерения:");
//            Console.WriteLine($"Общее время: {stopwatch.Elapsed}");
//            Console.WriteLine($"Миллисекунды: {stopwatch.ElapsedMilliseconds} мс");
//            Console.WriteLine($"Секунды: {stopwatch.Elapsed.TotalSeconds:F3} с");
//            Console.WriteLine($"Тики: {stopwatch.ElapsedTicks} тиков");
//            Console.WriteLine($"Запущен: {stopwatch.IsRunning}");
//        }
//    }
//}



//55
//using System;

//namespace TimeSpanDurability
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 55: Расчет долговечности между TimeSpan ===\n");

//            // Тестовые данные
//            TimeSpan[] timeSpans1 = {
//                new TimeSpan(10, 30, 15),    // 10 часов, 30 минут, 15 секунд
//                new TimeSpan(5, 0, 0),       // 5 часов
//                new TimeSpan(1, 45, 30),     // 1 час 45 минут 30 секунд
//                new TimeSpan(0, 30, 0)       // 30 минут
//            };

//            TimeSpan[] timeSpans2 = {
//                new TimeSpan(5, 45, 30),     // 5 часов 45 минут 30 секунд
//                new TimeSpan(3, 30, 0),      // 3 часа 30 минут
//                new TimeSpan(2, 15, 45),     // 2 часа 15 минут 45 секунд
//                new TimeSpan(1, 15, 0)       // 1 час 15 минут
//            };

//            for (int i = 0; i < timeSpans1.Length; i++)
//            {
//                var durability = CalculateDurability(timeSpans1[i], timeSpans2[i]);
//                Console.WriteLine($"TimeSpan1: {timeSpans1[i]}");
//                Console.WriteLine($"TimeSpan2: {timeSpans2[i]}");
//                Console.WriteLine($"Долговечность: {durability}");
//                Console.WriteLine($"В днях: {durability.TotalDays:F4} дней");
//                Console.WriteLine($"В часах: {durability.TotalHours:F2} часов");
//                Console.WriteLine($"В минутах: {durability.TotalMinutes} минут");
//                Console.WriteLine();
//            }

//            // Специальные случаи
//            Console.WriteLine("=== Специальные случаи ===");

//            // Одинаковые TimeSpan
//            TimeSpan same1 = new TimeSpan(5, 0, 0);
//            TimeSpan same2 = new TimeSpan(5, 0, 0);
//            Console.WriteLine($"Одинаковые: {CalculateDurability(same1, same2)}");

//            // Нулевые TimeSpan
//            Console.WriteLine($"Нулевые: {CalculateDurability(TimeSpan.Zero, TimeSpan.Zero)}");
//        }

//        static TimeSpan CalculateDurability(TimeSpan ts1, TimeSpan ts2)
//        {
//            // Долговечность как абсолютная разница между двумя временными промежутками
//            return ts1 > ts2 ? ts1 - ts2 : ts2 - ts1;
//        }
//    }
//}


//56
//using System;

//namespace DateTimeRounder
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 56: Округление DateTime ===\n");

//            DateTime[] testDates = {
//                new DateTime(2024, 3, 15, 14, 25, 30),
//                new DateTime(2024, 6, 20, 9, 15, 45),
//                new DateTime(2024, 9, 10, 18, 45, 10),
//                new DateTime(2024, 12, 25, 23, 30, 55),
//                DateTime.Now
//            };

//            foreach (var date in testDates)
//            {
//                Console.WriteLine($"Исходное:      {date:yyyy-MM-dd HH:mm:ss}");
//                Console.WriteLine($"До часа:       {RoundToNearestHour(date):yyyy-MM-dd HH:mm:ss}");
//                Console.WriteLine($"До дня:         {RoundToNearestDay(date):yyyy-MM-dd}");
//                Console.WriteLine($"До недели:      {RoundToNearestWeek(date):yyyy-MM-dd}");
//                Console.WriteLine();
//            }
//        }

//        static DateTime RoundToNearestHour(DateTime date)
//        {
//            return date.Minute >= 30 ? date.AddHours(1).AddMinutes(-date.Minute).AddSeconds(-date.Second)
//                                     : date.AddMinutes(-date.Minute).AddSeconds(-date.Second);
//        }

//        static DateTime RoundToNearestDay(DateTime date)
//        {
//            return date.Hour >= 12 ? date.AddDays(1).Date : date.Date;
//        }

//        static DateTime RoundToNearestWeek(DateTime date)
//        {
//            // Округляем до понедельника текущей недели
//            int daysToSubtract = (int)date.DayOfWeek - (int)DayOfWeek.Monday;
//            if (daysToSubtract < 0) daysToSubtract += 7;

//            DateTime monday = date.AddDays(-daysToSubtract).Date;

//            // Если текущий день четверг или позже, округляем до следующего понедельника
//            return date.DayOfWeek >= DayOfWeek.Thursday ? monday.AddDays(7) : monday;
//        }
//    }
//}


//57
//using System;

//namespace IsoWeekCalculator
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 57: Недели года по ISO 8601 ===\n");

//            // Критические даты для тестирования (границы недель)
//            DateTime[] testDates = {
//                new DateTime(2024, 1, 1),   // Понедельник, неделя 1
//                new DateTime(2024, 1, 7),   // Воскресенье, неделя 1
//                new DateTime(2024, 12, 25), // Среда, неделя 52
//                new DateTime(2024, 12, 30), // Понедельник, неделя 1 2025 года
//                new DateTime(2024, 12, 31), // Вторник, неделя 1 2025 года
//                new DateTime(2023, 12, 31), // Воскресенье, неделя 52 2023 года
//                DateTime.Now
//            };

//            foreach (var date in testDates)
//            {
//                int week = GetIso8601WeekOfYear(date);
//                Console.WriteLine($"{date:yyyy-MM-dd} ({date:dddd}) -> Неделя {week} года {GetIso8601Year(date)}");
//            }

//            // Получить все недели года
//            Console.WriteLine("\n=== Недели 2024 года ===");
//            DisplayWeeksOfYear(2024);
//        }

//        static int GetIso8601WeekOfYear(DateTime date)
//        {
//            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
//            return cal.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
//        }

//        static int GetIso8601Year(DateTime date)
//        {
//            // Для дат в конце декабря, которые относятся к следующему году по ISO
//            if (date.Month == 12 && date.Day >= 29)
//            {
//                int week = GetIso8601WeekOfYear(date);
//                if (week == 1) return date.Year + 1;
//            }
//            // Для дат в начале января, которые относятся к предыдущему году по ISO
//            else if (date.Month == 1 && date.Day <= 3)
//            {
//                int week = GetIso8601WeekOfYear(date);
//                if (week >= 52) return date.Year - 1;
//            }

//            return date.Year;
//        }

//        static void DisplayWeeksOfYear(int year)
//        {
//            DateTime date = new DateTime(year, 1, 1);

//            // Найти первый понедельник года по ISO
//            while (date.DayOfWeek != DayOfWeek.Monday)
//            {
//                date = date.AddDays(1);
//            }

//            for (int i = 0; i < 10; i++) // Показать первые 10 недель
//            {
//                DateTime weekStart = date.AddDays(i * 7);
//                DateTime weekEnd = weekStart.AddDays(6);
//                int weekNumber = GetIso8601WeekOfYear(weekStart);

//                Console.WriteLine($"Неделя {weekNumber}: {weekStart:yyyy-MM-dd} - {weekEnd:yyyy-MM-dd}");
//            }
//        }
//    }
//}


//58
//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;

//namespace TaskSchedulerDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 58: Планировщик задач ===\n");

//            SimpleScheduler scheduler = new SimpleScheduler();

//            // Планируем несколько задач
//            scheduler.ScheduleTask("Задача 1", TimeSpan.FromSeconds(2));
//            scheduler.ScheduleTask("Задача 2", TimeSpan.FromSeconds(5));
//            scheduler.ScheduleTask("Задача 3", TimeSpan.FromSeconds(8));
//            scheduler.ScheduleRecurringTask("Повторяющаяся задача", TimeSpan.FromSeconds(3), 4);

//            Console.WriteLine("Все задачи запланированы. Ожидание выполнения...");
//            Console.ReadLine(); // Ждем завершения всех задач
//        }
//    }

//    class SimpleScheduler
//    {
//        private List<Task> _tasks = new List<Task>();

//        public void ScheduleTask(string taskName, TimeSpan delay)
//        {
//            var task = Task.Run(async () =>
//            {
//                await Task.Delay(delay);
//                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Выполнено: {taskName} (задержка: {delay.TotalSeconds}с)");
//            });

//            _tasks.Add(task);
//        }

//        public void ScheduleRecurringTask(string taskName, TimeSpan interval, int repetitions)
//        {
//            var task = Task.Run(async () =>
//            {
//                for (int i = 1; i <= repetitions; i++)
//                {
//                    await Task.Delay(interval);
//                    Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Повтор {i}/{repetitions}: {taskName}");
//                }
//            });

//            _tasks.Add(task);
//        }

//        public void ScheduleTaskAtTime(string taskName, DateTime scheduledTime)
//        {
//            TimeSpan delay = scheduledTime - DateTime.Now;

//            if (delay > TimeSpan.Zero)
//            {
//                ScheduleTask(taskName, delay);
//            }
//            else
//            {
//                Console.WriteLine($"Время для задачи '{taskName}' уже прошло!");
//            }
//        }
//    }
//}


//59
//using System;
//using System.Collections.Generic;

//namespace TimeZoneDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 59: Работа с временными зонами ===\n");

//            // 1. Информация о локальной временной зоне
//            DisplayLocalTimeZoneInfo();

//            Console.WriteLine("\n" + new string('=', 50) + "\n");

//            // 2. Конвертация между различными временными зонами
//            TestTimeZoneConversions();

//            Console.WriteLine("\n" + new string('=', 50) + "\n");

//            // 3. Список всех доступных временных зон
//            DisplayAllTimeZones();
//        }

//        static void DisplayLocalTimeZoneInfo()
//        {
//            TimeZoneInfo localZone = TimeZoneInfo.Local;
//            DateTime now = DateTime.Now;

//            Console.WriteLine("=== Локальная временная зона ===");
//            Console.WriteLine($"ID: {localZone.Id}");
//            Console.WriteLine($"Отображаемое имя: {localZone.DisplayName}");
//            Console.WriteLine($"Стандартное имя: {localZone.StandardName}");
//            Console.WriteLine($"Летнее имя: {localZone.DaylightName}");
//            Console.WriteLine($"Смещение от UTC: {localZone.BaseUtcOffset}");
//            Console.WriteLine($"Поддерживает летнее время: {localZone.SupportsDaylightSavingTime}");
//            Console.WriteLine($"Сейчас летнее время: {localZone.IsDaylightSavingTime(now)}");
//        }

//        static void TestTimeZoneConversions()
//        {
//            Console.WriteLine("=== Конвертация между временными зонами ===");

//            DateTime localTime = DateTime.Now;
//            string[] targetZones = {
//                "UTC",
//                "Eastern Standard Time", // Нью-Йорк
//                "Central European Standard Time", // Берлин
//                "Tokyo Standard Time" // Токио
//            };

//            Console.WriteLine($"Локальное время: {localTime:yyyy-MM-dd HH:mm:ss}");

//            foreach (string zoneId in targetZones)
//            {
//                try
//                {
//                    TimeZoneInfo targetZone = TimeZoneInfo.FindSystemTimeZoneById(zoneId);
//                    DateTime targetTime = TimeZoneInfo.ConvertTime(localTime, TimeZoneInfo.Local, targetZone);
//                    Console.WriteLine($"{targetZone.DisplayName,-35}: {targetTime:yyyy-MM-dd HH:mm:ss}");
//                }
//                catch (TimeZoneNotFoundException)
//                {
//                    Console.WriteLine($"Временная зона '{zoneId}' не найдена");
//                }
//            }
//        }

//        static void DisplayAllTimeZones()
//        {
//            Console.WriteLine("=== Все доступные временные зоны ===");

//            ReadOnlySpan<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();

//            Console.WriteLine($"Всего временных зон: {zones.Count}");
//            Console.WriteLine("\nПервые 10 зон:");

//            for (int i = 0; i < Math.Min(10, zones.Count); i++)
//            {
//                var zone = zones[i];
//                Console.WriteLine($"{zone.Id,-40} {zone.DisplayName}");
//            }
//        }
//    }
//}


//60
//using System;
//using System.Collections.Generic;

//namespace DateRangeDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 60: Класс для работы с диапазонами дат ===\n");

//            // Создание диапазонов дат
//            DateRange range1 = new DateRange(
//                new DateTime(2024, 1, 1),
//                new DateTime(2024, 1, 31));

//            DateRange range2 = new DateRange(
//                new DateTime(2024, 1, 15),
//                new DateTime(2024, 2, 15));

//            DateRange range3 = new DateRange(
//                new DateTime(2024, 3, 1),
//                new DateTime(2024, 3, 31));

//            // Тестирование функциональности
//            Console.WriteLine("Диапазон 1: " + range1);
//            Console.WriteLine("Диапазон 2: " + range2);
//            Console.WriteLine("Диапазон 3: " + range3);
//            Console.WriteLine();

//            Console.WriteLine($"Длина диапазона 1: {range1.Length.TotalDays} дней");
//            Console.WriteLine($"Диапазон 1 содержит 2024-01-15: {range1.Contains(new DateTime(2024, 1, 15))}");
//            Console.WriteLine($"Диапазон 1 пересекается с диапазоном 2: {range1.Overlaps(range2)}");
//            Console.WriteLine($"Диапазон 1 пересекается с диапазоном 3: {range1.Overlaps(range3)}");
//            Console.WriteLine();

//            // Объединение пересекающихся диапазонов
//            if (range1.Overlaps(range2))
//            {
//                DateRange merged = range1.Merge(range2);
//                Console.WriteLine($"Объединение диапазонов 1 и 2: {merged}");
//            }

//            // Получение пересечения
//            DateRange? intersection = range1.GetIntersection(range2);
//            if (intersection != null)
//            {
//                Console.WriteLine($"Пересечение диапазонов 1 и 2: {intersection}");
//            }

//            // Разбиение на поддиапазоны
//            Console.WriteLine("\nРазбиение диапазона 1 на недели:");
//            var weeks = range1.SplitIntoWeeks();
//            foreach (var week in weeks)
//            {
//                Console.WriteLine($"  {week}");
//            }
//        }
//    }

//    public class DateRange
//    {
//        public DateTime Start { get; }
//        public DateTime End { get; }

//        public TimeSpan Length => End - Start;

//        public DateRange(DateTime start, DateTime end)
//        {
//            if (start > end)
//                throw new ArgumentException("Начальная дата не может быть позже конечной");

//            Start = start.Date;
//            End = end.Date;
//        }

//        public bool Contains(DateTime date)
//        {
//            return date.Date >= Start && date.Date <= End;
//        }

//        public bool Overlaps(DateRange other)
//        {
//            return Start <= other.End && End >= other.Start;
//        }

//        public DateRange Merge(DateRange other)
//        {
//            if (!Overlaps(other))
//                throw new InvalidOperationException("Диапазоны не пересекаются");

//            DateTime newStart = Start < other.Start ? Start : other.Start;
//            DateTime newEnd = End > other.End ? End : other.End;

//            return new DateRange(newStart, newEnd);
//        }

//        public DateRange? GetIntersection(DateRange other)
//        {
//            if (!Overlaps(other))
//                return null;

//            DateTime intersectionStart = Start > other.Start ? Start : other.Start;
//            DateTime intersectionEnd = End < other.End ? End : other.End;

//            return new DateRange(intersectionStart, intersectionEnd);
//        }

//        public List<DateRange> SplitIntoWeeks()
//        {
//            var weeks = new List<DateRange>();
//            DateTime currentWeekStart = Start;

//            while (currentWeekStart <= End)
//            {
//                DateTime currentWeekEnd = currentWeekStart.AddDays(6); // Неделя с понедельника по воскресенье
//                if (currentWeekEnd > End)
//                    currentWeekEnd = End;

//                weeks.Add(new DateRange(currentWeekStart, currentWeekEnd));
//                currentWeekStart = currentWeekEnd.AddDays(1);
//            }

//            return weeks;
//        }

//        public override string ToString()
//        {
//            return $"{Start:yyyy-MM-dd} - {End:yyyy-MM-dd} ({Length.TotalDays} дней)";
//        }
//    }
//}


//61
//using System;
//using System.Collections.Generic;

//namespace CovarianceDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 61: Ковариантный интерфейс IProducer ===\n");

//            // Создаем провайдеров для разных типов
//            IProducer<Animal> animalProducer = new AnimalProducer();
//            IProducer<Dog> dogProducer = new DogProducer();
//            IProducer<Puppy> puppyProducer = new PuppyProducer();

//            // Ковариантность: IProducer<Dog> может быть присвоен IProducer<Animal>
//            IProducer<Animal> covariantProducer = dogProducer;

//            Console.WriteLine("Результаты работы провайдеров:");
//            Console.WriteLine($"Animal: {animalProducer.Produce().Name}");
//            Console.WriteLine($"Dog: {dogProducer.Produce().Name}");
//            Console.WriteLine($"Puppy: {puppyProducer.Produce().Name}");
//            Console.WriteLine($"Covariant (Dog as Animal): {covariantProducer.Produce().Name}");

//            // Демонстрация в коллекции
//            Console.WriteLine("\nКовариантность в коллекции:");
//            List<IProducer<Animal>> producers = new List<IProducer<Animal>>
//            {
//                animalProducer,
//                dogProducer,    // Ковариантность!
//                puppyProducer   // Ковариантность!
//            };

//            foreach (var producer in producers)
//            {
//                Console.WriteLine($"Producer: {producer.Produce().Name}");
//            }
//        }
//    }

//    // Базовые классы для демонстрации
//    public class Animal
//    {
//        public string Name { get; set; } = "Животное";
//        public virtual void Speak() => Console.WriteLine("Звук животного");
//    }

//    public class Dog : Animal
//    {
//        public Dog() { Name = "Собака"; }
//        public override void Speak() => Console.WriteLine("Гав!");
//    }

//    public class Puppy : Dog
//    {
//        public Puppy() { Name = "Щенок"; }
//        public override void Speak() => Console.WriteLine("Тяв!");
//    }

//    // Ковариантный интерфейс с out параметром
//    public interface IProducer<out T>
//    {
//        T Produce();
//        // T GetItem(); // Разрешено - возвращаемый тип
//        // void SetItem(T item); // Запрещено - входной параметр
//    }

//    // Реализации интерфейса
//    public class AnimalProducer : IProducer<Animal>
//    {
//        public Animal Produce() => new Animal();
//    }

//    public class DogProducer : IProducer<Dog>
//    {
//        public Dog Produce() => new Dog();
//    }

//    public class PuppyProducer : IProducer<Puppy>
//    {
//        public Puppy Produce() => new Puppy();
//    }
//}

//62
//using System;

//namespace ContravarianceDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 62: Контрвариантный интерфейс IConsumer ===\n");

//            // Создаем потребителей для разных типов
//            IConsumer<Animal> animalConsumer = new AnimalConsumer();
//            IConsumer<Dog> dogConsumer = new DogConsumer();
//            IConsumer<Puppy> puppyConsumer = new PuppyConsumer();

//            // Контрвариантность: IConsumer<Animal> может быть присвоен IConsumer<Puppy>
//            IConsumer<Puppy> contravariantConsumer = animalConsumer;

//            Console.WriteLine("Проверка потребителей:");
//            var animal = new Animal();
//            var dog = new Dog();
//            var puppy = new Puppy();

//            animalConsumer.Consume(animal);
//            dogConsumer.Consume(dog);
//            puppyConsumer.Consume(puppy);

//            Console.WriteLine("\nКонтрвариантность - AnimalConsumer как PuppyConsumer:");
//            contravariantConsumer.Consume(puppy); // AnimalConsumer может обработать Puppy

//            // Демонстрация с коллекцией
//            Console.WriteLine("\nКонтрвариантность в обработке:");
//            ProcessAnimals(new Animal[] { animal, dog, puppy }, animalConsumer);
//            ProcessAnimals(new Dog[] { dog, new Dog() }, dogConsumer);
//            ProcessAnimals(new Puppy[] { puppy }, puppyConsumer);
//        }

//        static void ProcessAnimals<T>(T[] animals, IConsumer<T> consumer)
//        {
//            foreach (var animal in animals)
//            {
//                consumer.Consume(animal);
//            }
//        }
//    }

//    // Контрвариантный интерфейс с in параметром
//    public interface IConsumer<in T>
//    {
//        void Consume(T item);
//        // T GetItem(); // Запрещено - возвращаемый тип
//        // void Process(T input); // Разрешено - входной параметр
//    }

//    // Реализации интерфейса
//    public class AnimalConsumer : IConsumer<Animal>
//    {
//        public void Consume(Animal animal)
//        {
//            Console.WriteLine($"AnimalConsumer обрабатывает: {animal.Name}");
//            animal.Speak();
//        }
//    }

//    public class DogConsumer : IConsumer<Dog>
//    {
//        public void Consume(Dog dog)
//        {
//            Console.WriteLine($"DogConsumer обрабатывает: {dog.Name}");
//            dog.Speak();
//        }
//    }

//    public class PuppyConsumer : IConsumer<Puppy>
//    {
//        public void Consume(Puppy puppy)
//        {
//            Console.WriteLine($"PuppyConsumer обрабатывает: {puppy.Name}");
//            puppy.Speak();
//        }
//    }
//}


//63
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace IEnumerableCovarianceDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 63: Ковариантность с IEnumerable ===\n");

//            // Создаем коллекции конкретных типов
//            List<Dog> dogs = new List<Dog> { new Dog(), new Dog() };
//            List<Puppy> puppies = new List<Puppy> { new Puppy(), new Puppy() };

//            // Ковариантность: IEnumerable<Dog> может быть присвоен IEnumerable<Animal>
//            IEnumerable<Animal> animalsFromDogs = dogs;
//            IEnumerable<Animal> animalsFromPuppies = puppies;

//            Console.WriteLine("Обработка собак как животных:");
//            ProcessAnimals(animalsFromDogs);

//            Console.WriteLine("\nОбработка щенков как животных:");
//            ProcessAnimals(animalsFromPuppies);

//            // Ковариантность в LINQ
//            Console.WriteLine("\nКовариантность в LINQ:");
//            var mixedAnimals = dogs.Cast<Animal>().Concat(puppies.Cast<Animal>());
//            foreach (var animal in mixedAnimals)
//            {
//                Console.WriteLine($"LINQ Animal: {animal.Name}");
//            }

//            // Демонстрация с массивами
//            Console.WriteLine("\nКовариантность массивов (устаревшая):");
//            Dog[] dogArray = { new Dog(), new Dog() };
//            Animal[] animalArray = dogArray; // Ковариантность массивов (небезопасно)

//            foreach (var animal in animalArray)
//            {
//                Console.WriteLine($"Array Animal: {animal.Name}");
//            }
//        }

//        static void ProcessAnimals(IEnumerable<Animal> animals)
//        {
//            foreach (var animal in animals)
//            {
//                Console.WriteLine($"Обрабатываем: {animal.Name}");
//                animal.Speak();
//            }
//        }
//    }
//}


//64
//using System;

//namespace CovariantDelegateDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 64: Делегат с ковариантным возвращаемым типом ===\n");

//            // Создаем делегаты с разными возвращаемыми типами
//            Func<Animal> animalFactory = CreateAnimal;
//            Func<Dog> dogFactory = CreateDog;
//            Func<Puppy> puppyFactory = CreatePuppy;

//            // Ковариантность: Func<Dog> может быть присвоен Func<Animal>
//            Func<Animal> covariantFactory = dogFactory;

//            Console.WriteLine("Результаты работы фабрик:");
//            Console.WriteLine($"Animal: {animalFactory().Name}");
//            Console.WriteLine($"Dog: {dogFactory().Name}");
//            Console.WriteLine($"Puppy: {puppyFactory().Name}");
//            Console.WriteLine($"Covariant: {covariantFactory().Name}");

//            // Использование в коллекции
//            Console.WriteLine("\nКовариантность в коллекции делегатов:");
//            Func<Animal>[] factories = { animalFactory, dogFactory, puppyFactory };

//            foreach (var factory in factories)
//            {
//                var result = factory();
//                Console.WriteLine($"Factory produced: {result.Name}");
//            }

//            // Практический пример с кэшем
//            Console.WriteLine("\nПрактический пример - кэш фабрик:");
//            var factoryCache = new FactoryCache();
//            factoryCache.TestFactories();
//        }

//        static Animal CreateAnimal() => new Animal();
//        static Dog CreateDog() => new Dog();
//        static Puppy CreatePuppy() => new Puppy();
//    }

//    public class FactoryCache
//    {
//        private Func<Animal>[] _factories;

//        public FactoryCache()
//        {
//            _factories = new Func<Animal>[]
//            {
//                () => new Animal(),
//                () => new Dog(),    // Ковариантность!
//                () => new Puppy()   // Ковариантность!
//            };
//        }

//        public void TestFactories()
//        {
//            for (int i = 0; i < _factories.Length; i++)
//            {
//                var animal = _factories[i]();
//                Console.WriteLine($"Factory {i}: {animal.Name}");
//            }
//        }
//    }
//}


//65
//using System;

//namespace ContravariantDelegateDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 65: Делегат с контрвариантными параметрами ===\n");

//            // Создаем делегаты с разными параметрами
//            Action<Animal> animalProcessor = ProcessAnimal;
//            Action<Dog> dogProcessor = ProcessDog;
//            Action<Puppy> puppyProcessor = ProcessPuppy;

//            // Контрвариантность: Action<Animal> может быть присвоен Action<Puppy>
//            Action<Puppy> contravariantProcessor = animalProcessor;

//            Console.WriteLine("Проверка обработчиков:");
//            var animal = new Animal();
//            var dog = new Dog();
//            var puppy = new Puppy();

//            animalProcessor(animal);
//            dogProcessor(dog);
//            puppyProcessor(puppy);

//            Console.WriteLine("\nКонтрвариантность - Animal processor как Puppy processor:");
//            contravariantProcessor(puppy);

//            // Использование в коллекции
//            Console.WriteLine("\nКонтрвариантность в подписке на события:");
//            var eventManager = new EventManager<Dog>();
//            eventManager.AddHandler(animalProcessor); // Контрвариантность!
//            eventManager.AddHandler(dogProcessor);

//            eventManager.TriggerEvent(dog);
//        }

//        static void ProcessAnimal(Animal animal)
//        {
//            Console.WriteLine($"ProcessAnimal: {animal.Name}");
//        }

//        static void ProcessDog(Dog dog)
//        {
//            Console.WriteLine($"ProcessDog: {dog.Name}");
//        }

//        static void ProcessPuppy(Puppy puppy)
//        {
//            Console.WriteLine($"ProcessPuppy: {puppy.Name}");
//        }
//    }

//    public class EventManager<T>
//    {
//        private List<Action<T>> _handlers = new List<Action<T>>();

//        public void AddHandler(Action<T> handler)
//        {
//            _handlers.Add(handler);
//        }

//        public void TriggerEvent(T item)
//        {
//            foreach (var handler in _handlers)
//            {
//                handler(item);
//            }
//        }
//    }
//}


//66
//using System;
//using System.Collections.Generic;

//namespace VarianceHierarchyDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Иерархия классов для вариантности ===\n");

//            Демонстрация ковариантности
//            Console.WriteLine("=== КОВАРИАНТНОСТЬ ===");
//            IZoo<Dog> dogZoo = new Zoo<Dog>();
//            IZoo<Animal> animalZoo = dogZoo; // Ковариантность!

//            dogZoo.Add(new Dog { Name = "Рекс" });
//            animalZoo.Add(new Dog { Name = "Бобик" });

//            Console.WriteLine("Животные в зоопарке:");
//            foreach (var animal in animalZoo.GetAll())
//            {
//                Console.WriteLine($"- {animal.Name}");
//                animal.Speak();
//            }

//            Демонстрация контрвариантности
//            Console.WriteLine("\n=== КОНТРВАРИАНТНОСТЬ ===");
//            IVeterinarian<Animal> animalVet = new Veterinarian<Animal>();
//            IVeterinarian<Dog> dogVet = animalVet; // Контрвариантность!

//            var sickDog = new Dog { Name = "Больной пёс" };
//            dogVet.Treat(sickDog);

//            Дополнительные примеры
//            Console.WriteLine("\n=== ДОПОЛНИТЕЛЬНЫЕ ПРИМЕРЫ ===");

//            Ковариантность с коллекциями
//            List<Dog> dogs = new List<Dog> { new Dog(), new Puppy() };
//            IEnumerable<Animal> animals = dogs; // Ковариантность!

//            foreach (var animal in animals)
//            {
//                Console.WriteLine($"Коллекция: {animal.Name}");
//            }

//            Контрвариантность с делегатами
//            Action<Animal> animalAction = a => Console.WriteLine($"Обработано: {a.Name}");
//            Action<Dog> dogAction = animalAction; // Контрвариантность!
//            dogAction(new Dog { Name = "Шарик" });
//        }
//    }

//     Иерархия классов животных
//    public class Animal
//    {
//        public string Name { get; set; } = "Животное";
//        public virtual void Speak() => Console.WriteLine("  Издает звук животного");
//    }

//    public class Dog : Animal
//    {
//        public Dog() { Name = "Собака"; }
//        public override void Speak() => Console.WriteLine("  Гав!");
//    }

//    public class Puppy : Dog
//    {
//        public Puppy() { Name = "Щенок"; }
//        public override void Speak() => Console.WriteLine("  Тяв!");
//    }

//     Ковариантный интерфейс(out)
//    public interface IZoo<out T> where T : Animal
//    {
//        T GetAnimal(int index);
//        IEnumerable<T> GetAll();
//    }

//    public class Zoo<T> : IZoo<T> where T : Animal, new()
//    {
//        private List<T> animals = new List<T>();

//        public T GetAnimal(int index) => animals[index];

//        public IEnumerable<T> GetAll() => animals;

//        Внутренний метод - не нарушает ковариантность
//        public void Add(T animal)
//        {
//            animals.Add(animal);
//            Console.WriteLine($"Добавлено: {animal.Name}");
//        }
//    }

//     Контрвариантный интерфейс(in)
//    public interface IVeterinarian<in T> where T : Animal
//    {
//        void Treat(T animal);
//    }

//    public class Veterinarian<T> : IVeterinarian<T> where T : Animal
//    {
//        public void Treat(T animal)
//        {
//            Console.WriteLine($"Лечим: {animal.Name}");
//            animal.Speak();
//        }
//    }
//}


//67
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace CovariantExtensionsDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 67: Ковариантное расширение метода ===\n");

//            List<Dog> dogs = new List<Dog>
//            {
//                new Dog { Name = "Бобик", Age = 3 },
//                new Dog { Name = "Шарик", Age = 5 },
//                new Dog { Name = "Рекс", Age = 2 }
//            };

//            List<Puppy> puppies = new List<Puppy>
//            {
//                new Puppy { Name = "Малыш", Age = 1 },
//                new Puppy { Name = "Пушистик", Age = 1 }
//            };

//            // Использование ковариантных расширений
//            Console.WriteLine("Все собаки как животные:");
//            var allAnimals = dogs.AsAnimals();
//            foreach (var animal in allAnimals)
//            {
//                Console.WriteLine($"- {animal.Name}");
//            }

//            Console.WriteLine("\nОбъединение собак и щенков как животных:");
//            var mixedAnimals = dogs.AsAnimals().Concat(puppies.AsAnimals());
//            foreach (var animal in mixedAnimals)
//            {
//                Console.WriteLine($"- {animal.Name} ({animal.GetType().Name})");
//            }

//            Console.WriteLine("\nФильтрация через ковариантное расширение:");
//            var youngAnimals = dogs.WhereAnimals(a => a.Age < 4);
//            foreach (var animal in youngAnimals)
//            {
//                Console.WriteLine($"- {animal.Name}, возраст: {animal.Age}");
//            }

//            Console.WriteLine("\nПроекция через ковариантное расширение:");
//            var names = dogs.SelectAnimals(a => a.Name);
//            foreach (var name in names)
//            {
//                Console.WriteLine($"- Имя: {name}");
//            }
//        }
//    }

//    // Ковариантные расширения для IEnumerable
//    public static class CovariantExtensions
//    {
//        // Преобразование IEnumerable<T> в IEnumerable<Animal> где T : Animal
//        public static IEnumerable<Animal> AsAnimals<T>(this IEnumerable<T> animals) where T : Animal
//        {
//            return animals; // Ковариантность!
//        }

//        // Фильтрация с ковариантным возвращаемым типом
//        public static IEnumerable<Animal> WhereAnimals<T>(
//            this IEnumerable<T> animals,
//            Func<Animal, bool> predicate) where T : Animal
//        {
//            return animals.Where(predicate);
//        }

//        // Проекция с сохранением ковариантности
//        public static IEnumerable<TResult> SelectAnimals<T, TResult>(
//            this IEnumerable<T> animals,
//            Func<Animal, TResult> selector) where T : Animal
//        {
//            return animals.Select(selector);
//        }

//        // Ковариантное преобразование типов
//        public static IEnumerable<TBase> CovariantCast<TBase, TDerived>(
//            this IEnumerable<TDerived> collection) where TDerived : TBase
//        {
//            return collection; // Ковариантность!
//        }
//    }

//    // Расширенные классы животных с возрастом
//    public class Animal
//    {
//        public string Name { get; set; } = "Животное";
//        public int Age { get; set; }
//        public virtual void Speak() => Console.WriteLine("Звук животного");
//    }

//    public class Dog : Animal
//    {
//        public Dog() { Name = "Собака"; }
//        public override void Speak() => Console.WriteLine("Гав!");
//    }

//    public class Puppy : Dog
//    {
//        public Puppy() { Name = "Щенок"; }
//        public override void Speak() => Console.WriteLine("Тяв!");
//    }
//}


//68
//using System;
//using System.Collections.Generic;

//namespace ContravariantComparerDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 68: Контрвариантный компаратор IComparer ===\n");

//            // Создаем компараторы для разных типов
//            IComparer<Animal> animalComparer = new AnimalComparer();
//            IComparer<Dog> dogComparer = new DogComparer();
//            IComparer<Puppy> puppyComparer = new PuppyComparer();

//            // Контрвариантность: IComparer<Animal> может быть использован для сравнения Puppy
//            IComparer<Puppy> contravariantComparer = animalComparer;

//            // Тестовые данные
//            var animals = new List<Animal>
//            {
//                new Animal { Name = "Медведь", Age = 10 },
//                new Animal { Name = "Волк", Age = 5 },
//                new Animal { Name = "Лиса", Age = 3 }
//            };

//            var dogs = new List<Dog>
//            {
//                new Dog { Name = "Рекс", Age = 5 },
//                new Dog { Name = "Бобик", Age = 3 },
//                new Dog { Name = "Шарик", Age = 7 }
//            };

//            var puppies = new List<Puppy>
//            {
//                new Puppy { Name = "Малыш", Age = 1 },
//                new Puppy { Name = "Пушистик", Age = 2 },
//                new Puppy { Name = "Непоседа", Age = 1 }
//            };

//            // Сортировка с использованием контрвариантности
//            Console.WriteLine("Сортировка животных:");
//            animals.Sort(animalComparer);
//            PrintCollection(animals);

//            Console.WriteLine("\nСортировка собак компаратором животных (контрвариантность):");
//            dogs.Sort(animalComparer); // IComparer<Animal> для List<Dog>
//            PrintCollection(dogs);

//            Console.WriteLine("\nСортировка щенков компаратором животных (контрвариантность):");
//            puppies.Sort(animalComparer); // IComparer<Animal> для List<Puppy>
//            PrintCollection(puppies);

//            // Использование универсального компаратора
//            Console.WriteLine("\nУниверсальная сортировка:");
//            var universalComparer = new UniversalAnimalComparer();
//            SortAndPrint(animals, universalComparer, "животных");
//            SortAndPrint(dogs, universalComparer, "собак");
//            SortAndPrint(puppies, universalComparer, "щенков");
//        }

//        static void PrintCollection<T>(IEnumerable<T> collection) where T : Animal
//        {
//            foreach (var item in collection)
//            {
//                Console.WriteLine($"- {item.Name} (возраст: {item.Age})");
//            }
//        }

//        static void SortAndPrint<T>(List<T> list, IComparer<Animal> comparer, string description) where T : Animal
//        {
//            list.Sort(comparer); // Контрвариантность!
//            Console.WriteLine($"\nСортировка {description}:");
//            PrintCollection(list);
//        }
//    }

//    // Контрвариантный интерфейс IComparer
//    public class AnimalComparer : IComparer<Animal>
//    {
//        public int Compare(Animal x, Animal y)
//        {
//            return x.Age.CompareTo(y.Age);
//        }
//    }

//    public class DogComparer : IComparer<Dog>
//    {
//        public int Compare(Dog x, Dog y)
//        {
//            return x.Name.CompareTo(y.Name);
//        }
//    }

//    public class PuppyComparer : IComparer<Puppy>
//    {
//        public int Compare(Puppy x, Puppy y)
//        {
//            return x.Age.CompareTo(y.Age);
//        }
//    }

//    // Универсальный компаратор, демонстрирующий контрвариантность
//    public class UniversalAnimalComparer : IComparer<Animal>
//    {
//        public int Compare(Animal x, Animal y)
//        {
//            int nameComparison = x.Name.CompareTo(y.Name);
//            if (nameComparison != 0) return nameComparison;
//            return x.Age.CompareTo(y.Age);
//        }
//    }
//}


//69
//using System;
//using System.Collections.Generic;

//namespace VarianceErrorsDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 69: Ошибки при нарушении правил вариантности ===\n");

//            // Демонстрация безопасного использования
//            SafeVarianceDemo();

//            Console.WriteLine("\n" + new string('=', 50) + "\n");

//            // Демонстрация потенциально опасных ситуаций
//            UnsafeVarianceDemo();
//        }

//        static void SafeVarianceDemo()
//        {
//            Console.WriteLine("=== БЕЗОПАСНОЕ ИСПОЛЬЗОВАНИЕ ===");

//            // Ковариантность - безопасно
//            List<Dog> dogs = new List<Dog> { new Dog(), new Dog() };
//            IEnumerable<Animal> animals = dogs; // Безопасно - только чтение

//            foreach (Animal animal in animals)
//            {
//                Console.WriteLine($"Безопасное чтение: {animal.Name}");
//            }

//            // Контрвариантность - безопасно
//            Action<Animal> animalAction = a => Console.WriteLine($"Обработка: {a.Name}");
//            Action<Dog> dogAction = animalAction; // Безопасно - можно передать Dog как Animal

//            dogAction(new Dog());
//        }

//        static void UnsafeVarianceDemo()
//        {
//            Console.WriteLine("=== ПОТЕНЦИАЛЬНО ОПАСНЫЕ СИТУАЦИИ ===");

//            // 1. Попытка нарушения ковариантности
//            try
//            {
//                Console.WriteLine("1. Нарушение ковариантности:");
//                List<Dog> dogs = new List<Dog> { new Dog(), new Dog() };
//                // IList<Animal> animals = dogs; // ОШИБКА КОМПИЛЯЦИИ!
//                // animals.Add(new Cat()); // Это сломало бы типобезопасность

//                Console.WriteLine("   Компилятор предотвратил ошибку!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"   Ошибка: {ex.Message}");
//            }

//            // 2. Опасность ковариантности массивов (устаревшая функция)
//            try
//            {
//                Console.WriteLine("\n2. Опасность ковариантности массивов:");
//                Dog[] dogs = new Dog[] { new Dog(), new Dog() };
//                Animal[] animals = dogs; // Разрешено для массивов (опасно!)

//                Console.WriteLine("   Массив собак присвоен массиву животных");

//                // Попытка добавить неправильный тип - исключение в runtime!
//                // animals[0] = new Cat(); // ArrayTypeMismatchException!

//                Console.WriteLine("   Попытка добавления кошки в массив собак вызовет исключение");
//            }
//            catch (ArrayTypeMismatchException)
//            {
//                Console.WriteLine("   Поймано ArrayTypeMismatchException!");
//            }

//            // 3. Нарушение контрвариантности
//            try
//            {
//                Console.WriteLine("\n3. Попытка нарушения контрвариантности:");
//                Action<Puppy> puppyAction = p => Console.WriteLine($"Щенок: {p.Name}");
//                // Action<Animal> animalAction = puppyAction; // ОШИБКА КОМПИЛЯЦИИ!

//                Console.WriteLine("   Компилятор предотвратил ошибку!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"   Ошибка: {ex.Message}");
//            }

//            // 4. Проблемы с обобщенными интерфейсами
//            try
//            {
//                Console.WriteLine("\n4. Проблемы с двухсторонними интерфейсами:");
//                // Интерфейс с in и out параметрами не может быть вариантым
//                // interface IVariant<T> { T Get(); void Set(T item); } // ОШИБКА!

//                Console.WriteLine("   Интерфейсы с входными и выходными параметрами не могут быть вариантыми");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"   Ошибка: {ex.Message}");
//            }
//        }
//    }

//    public class Animal
//    {
//        public string Name { get; set; } = "Животное";
//    }

//    public class Dog : Animal
//    {
//        public Dog() { Name = "Собака"; }
//    }

//    public class Cat : Animal
//    {
//        public Cat() { Name = "Кошка"; }
//    }

//    public class Puppy : Dog
//    {
//        public Puppy() { Name = "Щенок"; }
//    }
//}


//70
//using System;
//using System.Collections.Generic;

//namespace CovariantGenericClassDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 70: Общий класс с ковариантным параметром типа ===\n");

//            // Создание контейнеров разных типов
//            var animalContainer = new CovariantContainer<Animal>(new Animal());
//            var dogContainer = new CovariantContainer<Dog>(new Dog());
//            var puppyContainer = new CovariantContainer<Puppy>(new Puppy());

//            // Ковариантность: CovariantContainer<Dog> может быть присвоен ICovariantContainer<Animal>
//            ICovariantContainer<Animal> covariantContainer = dogContainer;

//            Console.WriteLine("Содержимое контейнеров:");
//            Console.WriteLine($"Animal: {animalContainer.GetItem().Name}");
//            Console.WriteLine($"Dog: {dogContainer.GetItem().Name}");
//            Console.WriteLine($"Puppy: {puppyContainer.GetItem().Name}");
//            Console.WriteLine($"Covariant: {covariantContainer.GetItem().Name}");

//            // Использование в коллекции
//            Console.WriteLine("\nКовариантность в коллекции контейнеров:");
//            List<ICovariantContainer<Animal>> containers = new List<ICovariantContainer<Animal>>
//            {
//                animalContainer,
//                dogContainer,    // Ковариантность!
//                puppyContainer   // Ковариантность!
//            };

//            foreach (var container in containers)
//            {
//                var item = container.GetItem();
//                Console.WriteLine($"Container holds: {item.Name} ({item.GetType().Name})");
//            }

//            // Фабрика контейнеров
//            Console.WriteLine("\nФабрика контейнеров:");
//            var containerFactory = new ContainerFactory();
//            containerFactory.DemoCovariance();
//        }
//    }

//    // Ковариантный интерфейс с out параметром
//    public interface ICovariantContainer<out T>
//    {
//        T GetItem();
//        string ContainerType { get; }

//        // Нельзя иметь методы с T как входным параметром:
//        // void SetItem(T item); // ОШИБКА КОМПИЛЯЦИИ!
//    }

//    // Общий класс, реализующий ковариантный интерфейс
//    public class CovariantContainer<T> : ICovariantContainer<T> where T : Animal, new()
//    {
//        private T item;

//        public CovariantContainer(T item)
//        {
//            this.item = item;
//        }

//        public T GetItem() => item;

//        public string ContainerType => typeof(T).Name;

//        // Внутренний метод, который не нарушает ковариантность
//        public void ReplaceItem(T newItem)
//        {
//            item = newItem;
//            Console.WriteLine($"Заменен элемент в контейнере {ContainerType}");
//        }

//        // Фабричный метод
//        public static CovariantContainer<T> CreateDefault()
//        {
//            return new CovariantContainer<T>(new T());
//        }
//    }

//    // Специализированные классы-наследники
//    public class AnimalContainer : CovariantContainer<Animal>
//    {
//        public AnimalContainer(Animal animal) : base(animal) { }
//    }

//    public class DogContainer : CovariantContainer<Dog>
//    {
//        public DogContainer(Dog dog) : base(dog) { }
//    }

//    // Фабрика для демонстрации ковариантности
//    public class ContainerFactory
//    {
//        public void DemoCovariance()
//        {
//            // Создание различных контейнеров
//            var containers = new ICovariantContainer<Animal>[]
//            {
//                new CovariantContainer<Animal>(new Animal()),
//                new CovariantContainer<Dog>(new Dog()),
//                new CovariantContainer<Puppy>(new Puppy()),
//                new AnimalContainer(new Animal()),
//                new DogContainer(new Dog())
//            };

//            Console.WriteLine("Фабрика создала контейнеры:");
//            foreach (var container in containers)
//            {
//                var item = container.GetItem();
//                Console.WriteLine($"  {container.ContainerType}: {item.Name}");
//            }

//            // Демонстрация ковариантности в методах
//            Console.WriteLine("\nПередача специализированных контейнеров:");
//            ProcessContainer(new CovariantContainer<Dog>(new Dog()));
//            ProcessContainer(new CovariantContainer<Puppy>(new Puppy()));
//        }

//        public void ProcessContainer(ICovariantContainer<Animal> container)
//        {
//            Console.WriteLine($"Обработка контейнера: {container.ContainerType}");
//            var animal = container.GetItem();
//            animal.Speak();
//        }
//    }
//}


//71
//using System;
//using System.Collections.Generic;

//namespace ContravariantActionDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 71: Действие делегата с контрвариантностью ===\n");

//            // Создаем действия для разных типов
//            Action<Animal> processAnimal = ProcessAnimal;
//            Action<Dog> processDog = ProcessDog;
//            Action<Puppy> processPuppy = ProcessPuppy;

//            // Контрвариантность: Action<Animal> может быть присвоен Action<Puppy>
//            Action<Puppy> contravariantAction = processAnimal;

//            Console.WriteLine("Прямой вызов действий:");
//            processAnimal(new Animal());
//            processDog(new Dog());
//            processPuppy(new Puppy());

//            Console.WriteLine("\nКонтрвариантность - вызов через базовый тип:");
//            contravariantAction(new Puppy());

//            // Практический пример - система уведомлений
//            Console.WriteLine("\n=== Система уведомлений с контрвариантностью ===");
//            var notificationSystem = new NotificationSystem();
//            notificationSystem.DemoContravariance();

//            // Пример с коллекцией действий
//            Console.WriteLine("\n=== Коллекция действий ===");
//            var animalProcessor = new AnimalProcessor();
//            animalProcessor.DemoActionCollection();
//        }

//        static void ProcessAnimal(Animal animal)
//        {
//            Console.WriteLine($"Обработка животного: {animal.Name}");
//        }

//        static void ProcessDog(Dog dog)
//        {
//            Console.WriteLine($"Обработка собаки: {dog.Name}");
//        }

//        static void ProcessPuppy(Puppy puppy)
//        {
//            Console.WriteLine($"Обработка щенка: {puppy.Name}");
//        }
//    }

//    public class NotificationSystem
//    {
//        private List<Action<Animal>> _animalHandlers = new List<Action<Animal>>();

//        public void AddHandler<T>(Action<T> handler) where T : Animal
//        {
//            // Контрвариантность: Action<T> может быть преобразован в Action<Animal>
//            Action<Animal> contravariantHandler = handler;
//            _animalHandlers.Add(contravariantHandler);
//        }

//        public void Notify<T>(T animal) where T : Animal
//        {
//            foreach (var handler in _animalHandlers)
//            {
//                handler(animal);
//            }
//        }

//        public void DemoContravariance()
//        {
//            // Добавляем обработчики разных типов
//            AddHandler<Animal>(a => Console.WriteLine($"Уведомление для животного: {a.Name}"));
//            AddHandler<Dog>(d => Console.WriteLine($"Уведомление для собаки: {d.Name} - Гав!"));
//            AddHandler<Puppy>(p => Console.WriteLine($"Уведомление для щенка: {p.Name} - Тяв!"));

//            // Отправляем уведомления разных типов
//            Console.WriteLine("Отправка уведомлений:");
//            Notify(new Animal { Name = "Медведь" });
//            Notify(new Dog { Name = "Рекс" });
//            Notify(new Puppy { Name = "Малыш" });
//        }
//    }

//    public class AnimalProcessor
//    {
//        private Dictionary<Type, Action<Animal>> _processors = new Dictionary<Type, Action<Animal>>();

//        public AnimalProcessor()
//        {
//            // Регистрируем процессоры с контрвариантностью
//            _processors[typeof(Animal)] = ProcessAnimal;
//            _processors[typeof(Dog)] = ProcessDog;
//            _processors[typeof(Puppy)] = ProcessPuppy;
//        }

//        public void Process<T>(T animal) where T : Animal
//        {
//            if (_processors.TryGetValue(typeof(T), out var processor))
//            {
//                processor(animal); // Контрвариантность!
//            }
//            else
//            {
//                Console.WriteLine($"Неизвестный тип: {typeof(T).Name}");
//            }
//        }

//        public void DemoActionCollection()
//        {
//            Console.WriteLine("Обработка коллекции животных:");
//            var animals = new Animal[]
//            {
//                new Animal(),
//                new Dog(),
//                new Puppy()
//            };

//            foreach (var animal in animals)
//            {
//                Process(animal);
//            }
//        }

//        private void ProcessAnimal(Animal animal)
//        {
//            Console.WriteLine($"Универсальная обработка: {animal.Name}");
//        }

//        private void ProcessDog(Animal dog)
//        {
//            Console.WriteLine($"Специальная обработка собаки: {dog.Name}");
//        }

//        private void ProcessPuppy(Animal puppy)
//        {
//            Console.WriteLine($"Особая обработка щенка: {puppy.Name}");
//        }
//    }
//}


//72
//using System;
//using System.Collections.Generic;

//namespace CovariantFuncDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 72: Func делегат с ковариантностью ===\n");

//            // Создаем фабрики для разных типов
//            Func<Animal> createAnimal = () => new Animal();
//            Func<Dog> createDog = () => new Dog();
//            Func<Puppy> createPuppy = () => new Puppy();

//            // Ковариантность: Func<Dog> может быть присвоен Func<Animal>
//            Func<Animal> covariantFunc = createDog;

//            Console.WriteLine("Создание объектов через фабрики:");
//            Console.WriteLine($"Animal: {createAnimal().Name}");
//            Console.WriteLine($"Dog: {createDog().Name}");
//            Console.WriteLine($"Puppy: {createPuppy().Name}");
//            Console.WriteLine($"Covariant: {covariantFunc().Name}");

//            // Func с параметрами и ковариантным возвращаемым типом
//            Console.WriteLine("\n=== Func с параметрами ===");
//            Func<string, Animal> createAnimalWithName = name => new Animal { Name = name };
//            Func<string, Dog> createDogWithName = name => new Dog { Name = name };
//            Func<string, Puppy> createPuppyWithName = name => new Puppy { Name = name };

//            // Ковариантность в возвращаемом типе
//            Func<string, Animal> covariantNamedFunc = createDogWithName;

//            Console.WriteLine($"Создан: {createAnimalWithName("Медведь").Name}");
//            Console.WriteLine($"Создан: {createDogWithName("Рекс").Name}");
//            Console.WriteLine($"Создан: {covariantNamedFunc("Бобик").Name}");

//            // Практический пример - система фабрик
//            Console.WriteLine("\n=== Система фабрик с ковариантностью ===");
//            var factorySystem = new FactorySystem();
//            factorySystem.DemoCovariantFactories();

//            // Пример с преобразователями
//            Console.WriteLine("\n=== Система преобразователей ===");
//            var converterSystem = new ConverterSystem();
//            converterSystem.DemoConverters();
//        }
//    }

//    public class FactorySystem
//    {
//        private List<Func<Animal>> _factories = new List<Func<Animal>>();

//        public void RegisterFactory<T>(Func<T> factory) where T : Animal
//        {
//            // Ковариантность: Func<T> может быть преобразован в Func<Animal>
//            Func<Animal> covariantFactory = factory;
//            _factories.Add(covariantFactory);
//        }

//        public List<Animal> CreateAll()
//        {
//            var result = new List<Animal>();
//            foreach (var factory in _factories)
//            {
//                result.Add(factory());
//            }
//            return result;
//        }

//        public void DemoCovariantFactories()
//        {
//            // Регистрируем фабрики разных типов
//            RegisterFactory(() => new Animal());
//            RegisterFactory(() => new Dog());
//            RegisterFactory(() => new Puppy());
//            RegisterFactory(() => new Cat());

//            // Создаем все объекты
//            Console.WriteLine("Созданные объекты:");
//            var animals = CreateAll();
//            foreach (var animal in animals)
//            {
//                Console.WriteLine($"- {animal.Name} ({animal.GetType().Name})");
//            }
//        }
//    }

//    public class ConverterSystem
//    {
//        public void DemoConverters()
//        {
//            // Func с ковариантными возвращаемыми типами
//            Func<Dog, Animal> dogToAnimal = dog => dog;
//            Func<Puppy, Animal> puppyToAnimal = puppy => puppy;
//            Func<Puppy, Dog> puppyToDog = puppy => puppy;

//            // Ковариантность в цепочке преобразований
//            Func<Puppy, Animal> combinedConverter = puppyToDog + dogToAnimal;

//            var puppy = new Puppy { Name = "Малыш" };
//            var result = combinedConverter(puppy);

//            Console.WriteLine($"Преобразовано: {puppy.Name} -> {result.Name} ({result.GetType().Name})");

//            // Массив конвертеров с ковариантностью
//            Func<Animal, string>[] converters =
//            {
//                a => $"Животное: {a.Name}",
//                a => a is Dog dog ? $"Собака: {dog.Name}" : "Не собака",
//                a => a is Puppy puppy ? $"Щенок: {puppy.Name}" : "Не щенок"
//            };

//            Console.WriteLine("\nПреобразования животных:");
//            var testAnimals = new Animal[] { new Animal(), new Dog(), new Puppy() };
//            foreach (var animal in testAnimals)
//            {
//                foreach (var converter in converters)
//                {
//                    Console.WriteLine($"  {converter(animal)}");
//                }
//                Console.WriteLine();
//            }
//        }
//    }

//    public class Cat : Animal
//    {
//        public Cat() { Name = "Кошка"; }
//        public override void Speak() => Console.WriteLine("Мяу!");
//    }
//}


//73
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace RepositoryVarianceDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 73: Интерфейс репозитория с альтернативными параметрами ===\n");

//            // Создаем репозитории разных типов
//            IRepository<Animal> animalRepo = new AnimalRepository();
//            IRepository<Dog> dogRepo = new DogRepository();
//            IRepository<Puppy> puppyRepo = new PuppyRepository();

//            // Демонстрация ковариантности и контрвариантности
//            Console.WriteLine("=== Демонстрация вариантности в репозиториях ===\n");

//            // Ковариантность: получение данных
//            Console.WriteLine("Ковариантность - чтение:");
//            IEnumerable<Animal> animalsFromDogs = dogRepo.GetAll();
//            foreach (var animal in animalsFromDogs)
//            {
//                Console.WriteLine($"- {animal.Name}");
//            }

//            // Контрвариантность: сохранение данных
//            Console.WriteLine("\nКонтрвариантность - запись:");
//            var newPuppy = new Puppy { Name = "Новый щенок" };
//            animalRepo.Add(newPuppy); // AnimalRepository может принимать Puppy

//            // Универсальный сервис с вариантностью
//            Console.WriteLine("\n=== Универсальный сервис ===");
//            var animalService = new AnimalService(animalRepo);
//            animalService.DemoVariance();

//            // Поиск с контрвариантностью
//            Console.WriteLine("\n=== Поиск с вариантностью ===");
//            DemoSearchVariance(animalRepo, dogRepo, puppyRepo);
//        }

//        static void DemoSearchVariance(params IRepository<Animal>[] repositories)
//        {
//            foreach (var repo in repositories)
//            {
//                var found = repo.Find(a => a.Name.Contains("и"));
//                Console.WriteLine($"Найдено в {repo.GetType().Name}: {found.Count()} объектов");
//            }
//        }
//    }

//    // Интерфейс репозитория с ковариантными и контрвариантными возможностями
//    public interface IRepository<in T> where T : Animal
//    {
//        // Контрвариантность - входные параметры
//        void Add(T entity);
//        void Update(T entity);
//        void Delete(T entity);

//        // Ковариантность - возвращаемые значения
//        IEnumerable<Animal> GetAll();
//        Animal GetById(int id);
//        IEnumerable<Animal> Find(Func<Animal, bool> predicate);

//        // Методы с mixed variance
//        Animal FindAndUpdate(Func<Animal, bool> predicate, Action<Animal> update);
//    }

//    // Базовый репозиторий
//    public class AnimalRepository : IRepository<Animal>
//    {
//        protected List<Animal> _animals = new List<Animal>();

//        public AnimalRepository()
//        {
//            // Инициализация тестовыми данными
//            _animals.AddRange(new Animal[]
//            {
//                new Animal { Name = "Лев" },
//                new Dog { Name = "Барбос" },
//                new Puppy { Name = "Малыш" },
//                new Cat { Name = "Мурка" }
//            });
//        }

//        public void Add(Animal entity)
//        {
//            _animals.Add(entity);
//            Console.WriteLine($"Добавлено: {entity.Name}");
//        }

//        public void Update(Animal entity)
//        {
//            var existing = _animals.FirstOrDefault(a => a.Name == entity.Name);
//            if (existing != null)
//            {
//                Console.WriteLine($"Обновлено: {entity.Name}");
//            }
//        }

//        public void Delete(Animal entity)
//        {
//            _animals.Remove(entity);
//            Console.WriteLine($"Удалено: {entity.Name}");
//        }

//        public IEnumerable<Animal> GetAll() => _animals;

//        public Animal GetById(int id) => _animals.Count > id ? _animals[id] : null;

//        public IEnumerable<Animal> Find(Func<Animal, bool> predicate) => _animals.Where(predicate);

//        public Animal FindAndUpdate(Func<Animal, bool> predicate, Action<Animal> update)
//        {
//            var animal = _animals.FirstOrDefault(predicate);
//            if (animal != null)
//            {
//                update(animal);
//                Console.WriteLine($"Найден и обновлен: {animal.Name}");
//            }
//            return animal;
//        }
//    }

//    // Специализированные репозитории
//    public class DogRepository : IRepository<Dog>
//    {
//        private List<Dog> _dogs = new List<Dog>
//        {
//            new Dog { Name = "Рекс" },
//            new Dog { Name = "Шарик" },
//            new Puppy { Name = "Тузик" }
//        };

//        public void Add(Dog entity)
//        {
//            _dogs.Add(entity);
//            Console.WriteLine($"Добавлена собака: {entity.Name}");
//        }

//        public void Update(Dog entity)
//        {
//            Console.WriteLine($"Обновлена собака: {entity.Name}");
//        }

//        public void Delete(Dog entity)
//        {
//            _dogs.Remove(entity);
//            Console.WriteLine($"Удалена собака: {entity.Name}");
//        }

//        public IEnumerable<Animal> GetAll() => _dogs;

//        public Animal GetById(int id) => _dogs.Count > id ? _dogs[id] : null;

//        public IEnumerable<Animal> Find(Func<Animal, bool> predicate) => _dogs.Where(predicate);

//        public Animal FindAndUpdate(Func<Animal, bool> predicate, Action<Animal> update)
//        {
//            var dog = _dogs.FirstOrDefault(predicate);
//            if (dog != null)
//            {
//                update(dog);
//                Console.WriteLine($"Найдена и обновлена собака: {dog.Name}");
//            }
//            return dog;
//        }
//    }

//    public class PuppyRepository : IRepository<Puppy>
//    {
//        private List<Puppy> _puppies = new List<Puppy>
//        {
//            new Puppy { Name = "Пушистик" },
//            new Puppy { Name = "Комочек" }
//        };

//        public void Add(Puppy entity)
//        {
//            _puppies.Add(entity);
//            Console.WriteLine($"Добавлен щенок: {entity.Name}");
//        }

//        public void Update(Puppy entity)
//        {
//            Console.WriteLine($"Обновлен щенок: {entity.Name}");
//        }

//        public void Delete(Puppy entity)
//        {
//            _puppies.Remove(entity);
//            Console.WriteLine($"Удален щенок: {entity.Name}");
//        }

//        public IEnumerable<Animal> GetAll() => _puppies;

//        public Animal GetById(int id) => _puppies.Count > id ? _puppies[id] : null;

//        public IEnumerable<Animal> Find(Func<Animal, bool> predicate) => _puppies.Where(predicate);

//        public Animal FindAndUpdate(Func<Animal, bool> predicate, Action<Animal> update)
//        {
//            var puppy = _puppies.FirstOrDefault(predicate);
//            if (puppy != null)
//            {
//                update(puppy);
//                Console.WriteLine($"Найден и обновлен щенок: {puppy.Name}");
//            }
//            return puppy;
//        }
//    }

//    public class AnimalService
//    {
//        private readonly IRepository<Animal> _repository;

//        public AnimalService(IRepository<Animal> repository)
//        {
//            _repository = repository;
//        }

//        public void DemoVariance()
//        {
//            // Контрвариантность - можем добавлять производные типы
//            _repository.Add(new Dog { Name = "Новая собака" });
//            _repository.Add(new Puppy { Name = "Новый щенок" });
//            _repository.Add(new Cat { Name = "Новая кошка" });

//            // Ковариантность - получаем как базовый тип
//            Console.WriteLine("\nВсе животные в сервисе:");
//            foreach (var animal in _repository.GetAll())
//            {
//                Console.WriteLine($"- {animal.Name} ({animal.GetType().Name})");
//            }

//            // Поиск с предикатом
//            var dogs = _repository.Find(a => a is Dog);
//            Console.WriteLine($"\nНайдено собак: {dogs.Count()}");
//        }
//    }
//}


//74
//using System;
//using System.Collections.Generic;

//namespace CovariantFactoryDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 74: Фабрика шаблонов с ковариантностью ===\n");

//            // Создаем фабрики разных типов
//            IAnimalFactory<Animal> animalFactory = new AnimalFactory();
//            IAnimalFactory<Dog> dogFactory = new DogFactory();
//            IAnimalFactory<Puppy> puppyFactory = new PuppyFactory();

//            // Ковариантность: IAnimalFactory<Dog> может быть присвоен IAnimalFactory<Animal>
//            IAnimalFactory<Animal> covariantFactory = dogFactory;

//            Console.WriteLine("Создание объектов через фабрики:");
//            Console.WriteLine($"Animal: {animalFactory.Create().Name}");
//            Console.WriteLine($"Dog: {dogFactory.Create().Name}");
//            Console.WriteLine($"Puppy: {puppyFactory.Create().Name}");
//            Console.WriteLine($"Covariant: {covariantFactory.Create().Name}");

//            // Фабрика фабрик с ковариантностью
//            Console.WriteLine("\n=== Фабрика фабрик ===");
//            var factoryManager = new FactoryManager();
//            factoryManager.DemoCovariantFactories();

//            // Генератор объектов с ковариантностью
//            Console.WriteLine("\n=== Генератор объектов ===");
//            var objectGenerator = new ObjectGenerator();
//            objectGenerator.DemoGeneration();
//        }
//    }

//    // Ковариантный интерфейс фабрики
//    public interface IAnimalFactory<out T> where T : Animal
//    {
//        T Create();
//        string FactoryName { get; }

//        // Можно иметь методы с ковариантными возвращаемыми типами
//        IEnumerable<T> CreateMultiple(int count);
//    }

//    // Реализации фабрик
//    public class AnimalFactory : IAnimalFactory<Animal>
//    {
//        public Animal Create() => new Animal();

//        public string FactoryName => "Фабрика животных";

//        public IEnumerable<Animal> CreateMultiple(int count)
//        {
//            for (int i = 0; i < count; i++)
//            {
//                yield return new Animal { Name = $"Животное {i + 1}" };
//            }
//        }
//    }

//    public class DogFactory : IAnimalFactory<Dog>
//    {
//        public Dog Create() => new Dog();

//        public string FactoryName => "Фабрика собак";

//        public IEnumerable<Dog> CreateMultiple(int count)
//        {
//            for (int i = 0; i < count; i++)
//            {
//                yield return new Dog { Name = $"Собака {i + 1}" };
//            }
//        }
//    }

//    public class PuppyFactory : IAnimalFactory<Puppy>
//    {
//        public Puppy Create() => new Puppy();

//        public string FactoryName => "Фабрика щенков";

//        public IEnumerable<Puppy> CreateMultiple(int count)
//        {
//            for (int i = 0; i < count; i++)
//            {
//                yield return new Puppy { Name = $"Щенок {i + 1}" };
//            }
//        }
//    }

//    public class CatFactory : IAnimalFactory<Cat>
//    {
//        public Cat Create() => new Cat();

//        public string FactoryName => "Фабрика кошек";

//        public IEnumerable<Cat> CreateMultiple(int count)
//        {
//            for (int i = 0; i < count; i++)
//            {
//                yield return new Cat { Name = $"Кошка {i + 1}" };
//            }
//        }
//    }

//    // Менеджер фабрик с ковариантностью
//    public class FactoryManager
//    {
//        private List<IAnimalFactory<Animal>> _factories = new List<IAnimalFactory<Animal>>();

//        public void RegisterFactory<T>(IAnimalFactory<T> factory) where T : Animal
//        {
//            // Ковариантность: IAnimalFactory<T> может быть преобразован в IAnimalFactory<Animal>
//            IAnimalFactory<Animal> covariantFactory = factory;
//            _factories.Add(covariantFactory);
//        }

//        public void DemoCovariantFactories()
//        {
//            // Регистрируем фабрики разных типов
//            RegisterFactory(new AnimalFactory());
//            RegisterFactory(new DogFactory());
//            RegisterFactory(new PuppyFactory());
//            RegisterFactory(new CatFactory());

//            Console.WriteLine("Зарегистрированные фабрики:");
//            foreach (var factory in _factories)
//            {
//                Console.WriteLine($"- {factory.FactoryName}");

//                // Создаем по одному объекту каждой фабрикой
//                var animal = factory.Create();
//                Console.WriteLine($"  Создан: {animal.Name}");
//            }

//            // Массовое создание объектов
//            Console.WriteLine("\nМассовое создание объектов:");
//            foreach (var factory in _factories)
//            {
//                Console.WriteLine($"\n{factory.FactoryName}:");
//                var animals = factory.CreateMultiple(2);
//                foreach (var animal in animals)
//                {
//                    Console.WriteLine($"  - {animal.Name}");
//                }
//            }
//        }
//    }

//    // Генератор объектов с ковариантностью
//    public class ObjectGenerator
//    {
//        public void DemoGeneration()
//        {
//            // Словарь фабрик с ковариантностью
//            var factoryDictionary = new Dictionary<string, IAnimalFactory<Animal>>
//            {
//                ["animal"] = new AnimalFactory(),
//                ["dog"] = new DogFactory(),
//                ["puppy"] = new PuppyFactory(),
//                ["cat"] = new CatFactory()
//            };

//            Console.WriteLine("Генерация объектов по ключам:");
//            foreach (var kvp in factoryDictionary)
//            {
//                var animal = kvp.Value.Create();
//                Console.WriteLine($"Ключ '{kvp.Key}': {animal.Name} ({animal.GetType().Name})");
//            }

//            // Динамический выбор фабрики
//            Console.WriteLine("\nДинамическая генерация:");
//            string[] keys = { "animal", "dog", "puppy", "cat" };
//            foreach (string key in keys)
//            {
//                if (factoryDictionary.TryGetValue(key, out var factory))
//                {
//                    var animals = factory.CreateMultiple(3);
//                    Console.WriteLine($"\n{key}:");
//                    foreach (var animal in animals)
//                    {
//                        Console.WriteLine($"  - {animal.Name}");
//                    }
//                }
//            }
//        }
//    }
//}


//75
//using System;
//using System.Collections.Generic;

//namespace EventHandlerVarianceDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 75: Варианты в событиях (EventHandler) ===\n");

//            // Создаем издателей событий
//            var animalPublisher = new AnimalPublisher();
//            var dogPublisher = new DogPublisher();
//            var puppyPublisher = new PuppyPublisher();

//            // Создаем подписчиков
//            var animalSubscriber = new AnimalSubscriber();
//            var dogSubscriber = new DogSubscriber();
//            var puppySubscriber = new PuppySubscriber();

//            // Демонстрация ковариантности в событиях
//            Console.WriteLine("=== Ковариантность в событиях ===\n");

//            // Подписываемся с ковариантностью
//            animalPublisher.AnimalEvent += animalSubscriber.OnAnimalEvent;
//            animalPublisher.AnimalEvent += dogSubscriber.OnAnimalEvent;    // Ковариантность!
//            animalPublisher.AnimalEvent += puppySubscriber.OnAnimalEvent;  // Ковариантность!

//            Console.WriteLine("Публикация события AnimalEvent:");
//            animalPublisher.PublishEvent(new AnimalEventArgs { Animal = new Animal() });

//            // Демонстрация контрвариантности в событиях
//            Console.WriteLine("\n=== Контрвариантность в событиях ===\n");

//            // Подписываемся с контрвариантностью
//            puppyPublisher.PuppyEvent += animalSubscriber.OnPuppyEvent;  // Контрвариантность!
//            puppyPublisher.PuppyEvent += dogSubscriber.OnPuppyEvent;     // Контрвариантность!
//            puppyPublisher.PuppyEvent += puppySubscriber.OnPuppyEvent;

//            Console.WriteLine("Публикация события PuppyEvent:");
//            puppyPublisher.PublishEvent(new PuppyEventArgs { Puppy = new Puppy() });

//            // Универсальная система событий
//            Console.WriteLine("\n=== Универсальная система событий ===\n");
//            var eventSystem = new EventSystem();
//            eventSystem.DemoEventVariance();
//        }
//    }

//    // Базовые классы аргументов событий
//    public class AnimalEventArgs : EventArgs
//    {
//        public Animal Animal { get; set; }
//    }

//    public class DogEventArgs : AnimalEventArgs
//    {
//        public new Dog Animal
//        {
//            get => (Dog)base.Animal;
//            set => base.Animal = value;
//        }
//    }

//    public class PuppyEventArgs : DogEventArgs
//    {
//        public new Puppy Animal
//        {
//            get => (Puppy)base.Animal;
//            set => base.Animal = value;
//        }

//        public Puppy Puppy
//        {
//            get => (Puppy)base.Animal;
//            set => base.Animal = value;
//        }
//    }

//    // Издатели событий
//    public class AnimalPublisher
//    {
//        public event EventHandler<AnimalEventArgs> AnimalEvent;

//        public void PublishEvent(AnimalEventArgs e)
//        {
//            AnimalEvent?.Invoke(this, e);
//        }
//    }

//    public class DogPublisher
//    {
//        public event EventHandler<DogEventArgs> DogEvent;

//        public void PublishEvent(DogEventArgs e)
//        {
//            DogEvent?.Invoke(this, e);
//        }
//    }

//    public class PuppyPublisher
//    {
//        public event EventHandler<PuppyEventArgs> PuppyEvent;

//        public void PublishEvent(PuppyEventArgs e)
//        {
//            PuppyEvent?.Invoke(this, e);
//        }
//    }

//    // Подписчики событий
//    public class AnimalSubscriber
//    {
//        public void OnAnimalEvent(object sender, AnimalEventArgs e)
//        {
//            Console.WriteLine($"AnimalSubscriber: Получено животное - {e.Animal.Name}");
//        }

//        public void OnDogEvent(object sender, DogEventArgs e)
//        {
//            Console.WriteLine($"AnimalSubscriber: Получена собака - {e.Animal.Name}");
//        }

//        public void OnPuppyEvent(object sender, PuppyEventArgs e)
//        {
//            Console.WriteLine($"AnimalSubscriber: Получен щенок - {e.Puppy.Name}");
//        }
//    }

//    public class DogSubscriber
//    {
//        public void OnAnimalEvent(object sender, AnimalEventArgs e)
//        {
//            Console.WriteLine($"DogSubscriber: Получено животное как собака - {e.Animal.Name}");
//        }

//        public void OnDogEvent(object sender, DogEventArgs e)
//        {
//            Console.WriteLine($"DogSubscriber: Получена собака - {e.Animal.Name}");
//        }

//        public void OnPuppyEvent(object sender, PuppyEventArgs e)
//        {
//            Console.WriteLine($"DogSubscriber: Получен щенок - {e.Puppy.Name}");
//        }
//    }

//    public class PuppySubscriber
//    {
//        public void OnAnimalEvent(object sender, AnimalEventArgs e)
//        {
//            Console.WriteLine($"PuppySubscriber: Получено животное как щенок - {e.Animal.Name}");
//        }

//        public void OnDogEvent(object sender, DogEventArgs e)
//        {
//            Console.WriteLine($"PuppySubscriber: Получена собака как щенок - {e.Animal.Name}");
//        }

//        public void OnPuppyEvent(object sender, PuppyEventArgs e)
//        {
//            Console.WriteLine($"PuppySubscriber: Получен щенок - {e.Puppy.Name}");
//        }
//    }

//    // Универсальная система событий
//    public class EventSystem
//    {
//        private event EventHandler<AnimalEventArgs> _genericAnimalEvent;

//        public void AddHandler<T>(EventHandler<T> handler) where T : AnimalEventArgs
//        {
//            // Контрвариантность в параметрах событий
//            _genericAnimalEvent += (sender, e) => handler(sender, (T)e);
//        }

//        public void PublishEvent<T>(T eventArgs) where T : AnimalEventArgs
//        {
//            _genericAnimalEvent?.Invoke(this, eventArgs);
//        }

//        public void DemoEventVariance()
//        {
//            // Добавляем обработчики разных типов
//            AddHandler<AnimalEventArgs>((s, e) =>
//                Console.WriteLine($"Универсальный обработчик Animal: {e.Animal.Name}"));

//            AddHandler<DogEventArgs>((s, e) =>
//                Console.WriteLine($"Универсальный обработчик Dog: {e.Animal.Name}"));

//            AddHandler<PuppyEventArgs>((s, e) =>
//                Console.WriteLine($"Универсальный обработчик Puppy: {e.Puppy.Name}"));

//            // Публикуем события разных типов
//            Console.WriteLine("Публикация через универсальную систему:");
//            PublishEvent(new AnimalEventArgs { Animal = new Animal() });
//            PublishEvent(new DogEventArgs { Animal = new Dog() });
//            PublishEvent(new PuppyEventArgs { Puppy = new Puppy() });
//        }
//    }
//}


//76
//using System;
//using System.Collections.Generic;

//namespace ContravariantVisitorDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 76: Контрвариантный шаблон посетителей ===\n");

//            // Создаем посетителей
//            IAnimalVisitor<Animal> animalVisitor = new AnimalVisitor();
//            IAnimalVisitor<Dog> dogVisitor = new DogVisitor();

//            // Контрвариантность: IAnimalVisitor<Animal> может быть использован для Puppy
//            IAnimalVisitor<Puppy> puppyVisitor = animalVisitor;

//            // Тестовые объекты
//            var animals = new Animal[] { new Animal(), new Dog(), new Puppy() };

//            Console.WriteLine("Прямое использование посетителей:");
//            foreach (var animal in animals)
//            {
//                animal.Accept(animalVisitor);
//            }

//            Console.WriteLine("\nИспользование с контрвариантностью:");
//            var puppy = new Puppy();
//            puppy.Accept(puppyVisitor);  // AnimalVisitor для Puppy
//            puppy.Accept(dogVisitor);    // DogVisitor для Puppy

//            // Универсальный обработчик
//            Console.WriteLine("\nУниверсальный обработчик:");
//            var processor = new AnimalProcessor();
//            processor.ProcessAnimals(animals);
//        }
//    }

//    // Интерфейс посетителя с контрвариантным параметром
//    public interface IAnimalVisitor<in T> where T : Animal
//    {
//        void Visit(T animal);
//    }

//    // Конкретные посетители
//    public class AnimalVisitor : IAnimalVisitor<Animal>
//    {
//        public void Visit(Animal animal)
//        {
//            Console.WriteLine($"AnimalVisitor: {animal.Name}");
//            animal.Speak();
//        }
//    }

//    public class DogVisitor : IAnimalVisitor<Dog>
//    {
//        public void Visit(Dog dog)
//        {
//            Console.WriteLine($"DogVisitor: Собака {dog.Name}");
//            dog.Speak();
//        }
//    }

//    public class UniversalVisitor : IAnimalVisitor<Animal>
//    {
//        public void Visit(Animal animal)
//        {
//            Console.WriteLine($"UniversalVisitor: {animal.Name} ({animal.GetType().Name})");
//        }
//    }

//    // Иерархия классов животных
//    public class Animal
//    {
//        public string Name { get; set; } = "Животное";
//        public virtual void Speak() => Console.WriteLine("  Звук животного");

//        public virtual void Accept<T>(T visitor) where T : IAnimalVisitor<Animal>
//        {
//            visitor.Visit(this);
//        }
//    }

//    public class Dog : Animal
//    {
//        public Dog() { Name = "Собака"; }
//        public override void Speak() => Console.WriteLine("  Гав!");

//        public void Accept<T>(T visitor) where T : IAnimalVisitor<Dog>
//        {
//            visitor.Visit(this);
//        }
//    }

//    public class Puppy : Dog
//    {
//        public Puppy() { Name = "Щенок"; }
//        public override void Speak() => Console.WriteLine("  Тяв!");

//        public void Accept<T>(T visitor) where T : IAnimalVisitor<Puppy>
//        {
//            visitor.Visit(this);
//        }
//    }

//    // Обработчик с контрвариантностью
//    public class AnimalProcessor
//    {
//        private List<IAnimalVisitor<Animal>> _visitors = new List<IAnimalVisitor<Animal>>();

//        public AnimalProcessor()
//        {
//            _visitors.Add(new AnimalVisitor());
//            _visitors.Add(new UniversalVisitor());
//            _visitors.Add(new DogVisitor()); // Контрвариантность: DogVisitor → AnimalVisitor
//        }

//        public void ProcessAnimals(IEnumerable<Animal> animals)
//        {
//            foreach (var animal in animals)
//            {
//                Console.WriteLine($"\nОбработка: {animal.Name}");
//                foreach (var visitor in _visitors)
//                {
//                    visitor.Visit(animal);
//                }
//            }
//        }
//    }
//}

//77
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace CovariantReadOnlyCollectionDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 77: Ковариантный интерфейс для коллекций только для чтения ===\n");

//            // Создаем коллекции разных типов
//            IReadOnlyCollection<Dog> dogs = new List<Dog>
//            {
//                new Dog { Name = "Рекс" },
//                new Dog { Name = "Шарик" }
//            };

//            IReadOnlyCollection<Puppy> puppies = new List<Puppy>
//            {
//                new Puppy { Name = "Малыш" },
//                new Puppy { Name = "Пушистик" }
//            };

//            // Ковариантность: IReadOnlyCollection<Dog> может быть присвоен IReadOnlyCollection<Animal>
//            IReadOnlyCollection<Animal> animalsFromDogs = dogs;
//            IReadOnlyCollection<Animal> animalsFromPuppies = puppies;

//            Console.WriteLine("Собаки как животные:");
//            foreach (var animal in animalsFromDogs)
//            {
//                Console.WriteLine($"- {animal.Name}");
//            }

//            Console.WriteLine("\nЩенки как животные:");
//            foreach (var animal in animalsFromPuppies)
//            {
//                Console.WriteLine($"- {animal.Name}");
//            }

//            // Собственная ковариантная коллекция
//            Console.WriteLine("\n=== Собственная ковариантная коллекция ===\n");
//            var animalCollection = new ReadOnlyAnimalCollection<Animal>(new[]
//            {
//                new Animal(),
//                new Dog(),
//                new Puppy(),
//                new Cat()
//            });

//            var dogCollection = new ReadOnlyAnimalCollection<Dog>(new[]
//            {
//                new Dog(),
//                new Dog(),
//                new Puppy() // Puppy является Dog
//            });

//            // Ковариантность в работе
//            Console.WriteLine("Универсальная обработка коллекций:");
//            ProcessReadOnlyCollection(animalCollection);
//            ProcessReadOnlyCollection(dogCollection);    // Ковариантность!

//            // Расширения для ковариантных коллекций
//            Console.WriteLine("\n=== Расширения для ковариантных коллекций ===\n");
//            var filteredDogs = dogCollection.Filter(a => a.Name.Contains("и"));
//            Console.WriteLine("Отфильтрованные собаки:");
//            foreach (var dog in filteredDogs)
//            {
//                Console.WriteLine($"- {dog.Name}");
//            }
//        }

//        static void ProcessReadOnlyCollection(IReadOnlyCollection<Animal> collection)
//        {
//            Console.WriteLine($"\nОбработка коллекции ({collection.Count} элементов):");
//            foreach (var animal in collection)
//            {
//                Console.WriteLine($"- {animal.Name} ({animal.GetType().Name})");
//            }
//        }
//    }

//    // Ковариантный интерфейс для коллекции только для чтения
//    public interface IReadOnlyAnimalCollection<out T> where T : Animal
//    {
//        int Count { get; }
//        T this[int index] { get; }
//        IEnumerator<T> GetEnumerator();

//        // Только методы для чтения разрешены
//        bool Contains(Animal item);
//        int IndexOf(Animal item);
//    }

//    // Реализация ковариантной коллекции только для чтения
//    public class ReadOnlyAnimalCollection<T> : IReadOnlyAnimalCollection<T> where T : Animal
//    {
//        private readonly IList<T> _items;

//        public ReadOnlyAnimalCollection(IEnumerable<T> items)
//        {
//            _items = items?.ToList() ?? new List<T>();
//        }

//        public int Count => _items.Count;

//        public T this[int index] => _items[index];

//        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();

//        public bool Contains(Animal item)
//        {
//            return _items.Contains((T)item);
//        }

//        public int IndexOf(Animal item)
//        {
//            return _items.IndexOf((T)item);
//        }

//        // Дополнительные методы только для чтения
//        public IEnumerable<T> Where(Func<T, bool> predicate)
//        {
//            return _items.Where(predicate);
//        }

//        public T FirstOrDefault(Func<T, bool> predicate)
//        {
//            return _items.FirstOrDefault(predicate);
//        }
//    }

//    // Расширения для ковариантных коллекций
//    public static class ReadOnlyCollectionExtensions
//    {
//        // Ковариантное расширение для фильтрации
//        public static IReadOnlyAnimalCollection<Animal> Filter<T>(
//            this IReadOnlyAnimalCollection<T> collection,
//            Func<Animal, bool> predicate) where T : Animal
//        {
//            var filtered = collection.Where(predicate).ToList();
//            return new ReadOnlyAnimalCollection<Animal>(filtered);
//        }

//        // Ковариантное преобразование
//        public static IReadOnlyAnimalCollection<TResult> Select<T, TResult>(
//            this IReadOnlyAnimalCollection<T> collection,
//            Func<T, TResult> selector) where T : Animal where TResult : Animal
//        {
//            var selected = collection.Select(selector).ToList();
//            return new ReadOnlyAnimalCollection<TResult>(selected);
//        }

//        // Объединение коллекций с ковариантностью
//        public static IReadOnlyAnimalCollection<Animal> Concat<T1, T2>(
//            this IReadOnlyAnimalCollection<T1> first,
//            IReadOnlyAnimalCollection<T2> second) where T1 : Animal where T2 : Animal
//        {
//            var concatenated = first.Cast<Animal>().Concat(second.Cast<Animal>()).ToList();
//            return new ReadOnlyAnimalCollection<Animal>(concatenated);
//        }
//    }

//    // Специализированные коллекции
//    public class DogCollection : ReadOnlyAnimalCollection<Dog>
//    {
//        public DogCollection(IEnumerable<Dog> dogs) : base(dogs) { }
//    }

//    public class PuppyCollection : ReadOnlyAnimalCollection<Puppy>
//    {
//        public PuppyCollection(IEnumerable<Puppy> puppies) : base(puppies) { }
//    }
//}


//78
//using System;
//using System.Collections.Generic;

//namespace SafeVariancePrinciplesDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 78: Безопасные принципы применения типов с использованием вариантов ===\n");

//            // 1. Ковариантность только для выходных позиций
//            Console.WriteLine("1. Ковариантность (out) - только возвращаемые значения:\n");

//            IAnimalReader<Dog> dogReader = new DogReader();
//            IAnimalReader<Animal> animalReader = dogReader; // Безопасно!

//            Console.WriteLine($"Прочитано: {animalReader.Read().Name}");

//            // 2. Контрвариантность только для входных позиций  
//            Console.WriteLine("\n2. Контрвариантность (in) - только входные параметры:\n");

//            IAnimalWriter<Animal> animalWriter = new AnimalWriter();
//            IAnimalWriter<Puppy> puppyWriter = animalWriter; // Безопасно!

//            puppyWriter.Write(new Puppy());

//            // 3. Безопасные преобразования
//            Console.WriteLine("\n3. Безопасные преобразования типов:\n");

//            var safeConverter = new SafeTypeConverter();
//            safeConverter.DemoSafeConversions();

//            // 4. Generic-ограничения для типобезопасности
//            Console.WriteLine("\n4. Generic-ограничения для вариантности:\n");

//            var processor = new SafeGenericProcessor();
//            processor.DemoSafeGenericUsage();
//        }
//    }

//    // Иерархия классов
//    public class Animal
//    {
//        public string Name { get; set; } = "Животное";
//        public virtual void Speak() => Console.WriteLine("  Звук животного");
//    }

//    public class Dog : Animal
//    {
//        public Dog() { Name = "Собака"; }
//        public override void Speak() => Console.WriteLine("  Гав!");
//    }

//    public class Puppy : Dog
//    {
//        public Puppy() { Name = "Щенок"; }
//        public override void Speak() => Console.WriteLine("  Тяв!");
//    }

//    // 1. Безопасные ковариантные интерфейсы (только выходные позиции)
//    public interface IAnimalReader<out T> where T : Animal
//    {
//        T Read();
//        IEnumerable<T> ReadAll();
//        // void Write(T item); // НЕБЕЗОПАСНО - запрещено компилятором
//    }

//    public class AnimalReader : IAnimalReader<Animal>
//    {
//        public Animal Read() => new Animal();
//        public IEnumerable<Animal> ReadAll() => new[] { new Animal(), new Dog() };
//    }

//    public class DogReader : IAnimalReader<Dog>
//    {
//        public Dog Read() => new Dog();
//        public IEnumerable<Dog> ReadAll() => new[] { new Dog(), new Puppy() };
//    }

//    // 2. Безопасные контрвариантные интерфейсы (только входные позиции)
//    public interface IAnimalWriter<in T> where T : Animal
//    {
//        void Write(T item);
//        // T Read(); // НЕБЕЗОПАСНО - запрещено компилятором
//    }

//    public class AnimalWriter : IAnimalWriter<Animal>
//    {
//        public void Write(Animal item)
//        {
//            Console.WriteLine($"Запись животного: {item.Name}");
//            item.Speak();
//        }
//    }

//    public class DogWriter : IAnimalWriter<Dog>
//    {
//        public void Write(Dog item)
//        {
//            Console.WriteLine($"Запись собаки: {item.Name}");
//            item.Speak();
//        }
//    }

//    // 3. Безопасный конвертер типов
//    public class SafeTypeConverter
//    {
//        public void DemoSafeConversions()
//        {
//            // Безопасное приведение с проверкой
//            Animal animal = new Dog();
//            if (animal is Dog dog)
//            {
//                Console.WriteLine($"Безопасное приведение: {dog.Name}");
//            }

//            // Безопасное использование as
//            Animal anotherAnimal = new Puppy();
//            var anotherDog = anotherAnimal as Dog;
//            if (anotherDog != null)
//            {
//                Console.WriteLine($"Безопасное преобразование as: {anotherDog.Name}");
//            }

//            // Ковариантность коллекций - безопасно
//            List<Dog> dogs = new List<Dog> { new Dog(), new Puppy() };
//            IEnumerable<Animal> animals = dogs;

//            Console.WriteLine("Ковариантная коллекция:");
//            foreach (var a in animals)
//            {
//                Console.WriteLine($"- {a.Name} ({a.GetType().Name})");
//            }
//        }
//    }

//    // 4. Безопасный generic-процессор
//    public class SafeGenericProcessor
//    {
//        // Безопасный метод с ковариантными ограничениями
//        public void ProcessAnimals<T>(IEnumerable<T> animals) where T : Animal
//        {
//            Console.WriteLine($"Обработка {typeof(T).Name}:");
//            foreach (var animal in animals)
//            {
//                Console.WriteLine($"- {animal.Name}");
//                animal.Speak();
//            }
//        }

//        // Безопасный метод с контрвариантными ограничениями
//        public void ApplyAction<T>(Action<T> action, T animal) where T : Animal
//        {
//            action(animal);
//        }

//        public void DemoSafeGenericUsage()
//        {
//            // Безопасная ковариантность
//            var dogs = new List<Dog> { new Dog(), new Puppy() };
//            ProcessAnimals(dogs); // Dog → Animal

//            // Безопасная контрвариантность
//            Action<Animal> animalAction = a => Console.WriteLine($"Обработано: {a.Name}");
//            ApplyAction(animalAction, new Dog()); // Action<Animal> → Action<Dog>

//            Console.WriteLine("\nКомпилятор предотвращает небезопасные операции:");
//            // ProcessAnimals(new List<string>()); // ОШИБКА КОМПИЛЯЦИИ!
//            // ApplyAction<string>(s => Console.WriteLine(s), "test"); // ОШИБКА!
//        }
//    }

//    // Безопасный вариантный контейнер
//    public class SafeVariantContainer<T> where T : Animal
//    {
//        private T _item;

//        // Безопасные методы только для чтения (ковариантность)
//        public T GetItem() => _item;

//        public TResult GetItemAs<TResult>() where TResult : T
//        {
//            return (TResult)_item; // Безопасно - проверка на этапе компиляции
//        }

//        // Безопасные методы только для записи (контрвариантность)
//        public void SetItem(T item)
//        {
//            _item = item;
//            Console.WriteLine($"Установлен: {item.Name}");
//        }

//        public void SetItemFrom<TSource>(TSource item) where TSource : T
//        {
//            _item = item;
//            Console.WriteLine($"Установлен из {typeof(TSource).Name}: {item.Name}");
//        }
//    }
//}


//79
//using System;
//using System.Collections.Generic;

//namespace CombinedVarianceDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ 79: Сочетание ковариантности и контрвариантности ===\n");

//            // 1. Func делегат - комбинированная вариантность
//            Console.WriteLine("1. Func<in T, out TResult> - комбинированная вариантность:\n");

//            // Контрвариантность в параметре + ковариантность в возвращаемом значении
//            Func<Animal, string> animalProcessor = a => $"Обработано: {a.Name}";
//            Func<Dog, string> dogProcessor = animalProcessor; // Контрвариантность!

//            Func<Dog, Animal> dogToAnimal = d => d;
//            Func<Puppy, Animal> puppyToAnimal = dogToAnimal; // Контрвариантность + ковариантность!

//            var dog = new Dog { Name = "Рекс" };
//            var puppy = new Puppy { Name = "Малыш" };

//            Console.WriteLine($"dogProcessor: {dogProcessor(dog)}");
//            Console.WriteLine($"puppyToAnimal: {puppyToAnimal(puppy).Name}");

//            // 2. Интерфейс с mixed variance
//            Console.WriteLine("\n2. Интерфейс IProcessor<in TInput, out TOutput>:\n");

//            IProcessor<Animal, string> animalStringProcessor = new AnimalStringProcessor();
//            IProcessor<Dog, string> dogStringProcessor = animalStringProcessor; // Контрвариантность!

//            IProcessor<Dog, Animal> dogAnimalProcessor = new DogAnimalProcessor();
//            IProcessor<Puppy, string> puppyStringProcessor = dogAnimalProcessor; // Оба варианта!

//            Console.WriteLine($"dogStringProcessor: {dogStringProcessor.Process(dog)}");
//            Console.WriteLine($"puppyStringProcessor: {puppyStringProcessor.Process(puppy)}");

//            // 3. Цепочка преобразований
//            Console.WriteLine("\n3. Цепочка преобразований с вариантностью:\n");

//            var converter = new ConverterSystem();
//            string result = converter.TransformChain(
//                new Puppy { Name = "Цепной щенок" },
//                p => (Dog)p,                    // Puppy → Dog (контрвариантность)
//                d => new Animal { Name = d.Name }, // Dog → Animal (ковариантность)
//                a => a.ToString()               // Animal → string (ковариантность)
//            );

//            Console.WriteLine($"Результат цепочки: {result}");
//        }
//    }

//    // Иерархия классов
//    public class Animal
//    {
//        public string Name { get; set; } = "Животное";
//        public override string ToString() => $"Animal: {Name}";
//    }

//    public class Dog : Animal
//    {
//        public Dog() { Name = "Собака"; }
//    }

//    public class Puppy : Dog
//    {
//        public Puppy() { Name = "Щенок"; }
//    }

//    // Интерфейс с комбинированной вариантностью
//    // in TInput - контрвариантность, out TOutput - ковариантность
//    public interface IProcessor<in TInput, out TOutput>
//    {
//        TOutput Process(TInput input);
//    }

//    // Реализации интерфейса
//    public class AnimalStringProcessor : IProcessor<Animal, string>
//    {
//        public string Process(Animal input) => $"Animal: {input.Name}";
//    }

//    public class DogAnimalProcessor : IProcessor<Dog, Animal>
//    {
//        public Animal Process(Dog input) => new Animal { Name = $"Из собаки: {input.Name}" };
//    }

//    // Система преобразований с вариантностью
//    public class ConverterSystem
//    {
//        // Метод для цепочки преобразований с комбинированной вариантностью
//        public TResult TransformChain<T1, T2, T3, TResult>(
//            T1 input,
//            Func<T1, T2> step1,  // Контрвариантность возможна в T1
//            Func<T2, T3> step2,  // Ковариантность возможна в T3  
//            Func<T3, TResult> step3) // Ковариантность в TResult
//            where T1 : Animal
//            where T2 : Animal
//            where T3 : Animal
//        {
//            var result1 = step1(input);    // T1 → T2
//            var result2 = step2(result1);  // T2 → T3  
//            return step3(result2);         // T3 → TResult
//        }
//    }

//    // Практический пример - обработчик событий с вариантностью
//    public class EventProcessor
//    {
//        private List<Action<Animal>> _handlers = new List<Action<Animal>>();

//        // Контрвариантность - можно добавить Action<Dog> как Action<Animal>
//        public void AddHandler<T>(Action<T> handler) where T : Animal
//        {
//            _handlers.Add((Action<Animal>)handler);
//        }

//        // Ковариантность - можно обработать Dog как Animal
//        public void ProcessEvent<T>(T animal) where T : Animal
//        {
//            foreach (var handler in _handlers)
//            {
//                handler(animal);
//            }
//        }
//    }
//}


//80
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace GenericMethodVarianceDemo
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== ЗАДАНИЕ: 80: Общий метод с ограничениями для поддержки вариантов ===\n");

//            var processor = new VarianceProcessor();

//            // 1. Ковариантность - работа с производными типами как с базовыми
//            Console.WriteLine("=== КОВАРИАНТНОСТЬ ===\n");

//            List<Dog> dogs = new List<Dog> { new Dog(), new Dog { Name = "Рекс" } };
//            List<Puppy> puppies = new List<Puppy> { new Puppy(), new Puppy { Name = "Малыш" } };

//            Console.WriteLine("Обработка собак как животных:");
//            processor.ProcessAnimals(dogs); // Dog → Animal

//            Console.WriteLine("\nОбработка щенков как животных:");
//            processor.ProcessAnimals(puppies); // Puppy → Animal

//            // 2. Контрвариантность - работа с базовыми типами как с производными
//            Console.WriteLine("\n=== КОНТРВАРИАНТНОСТЬ ===\n");

//            Action<Animal> animalAction = a => Console.WriteLine($"  Обработано: {a.Name}");
//            Action<Dog> dogAction = animalAction; // Animal → Dog

//            Console.WriteLine("Animal action для собаки:");
//            processor.ApplyAction(dogAction, new Dog { Name = "Бобик" });

//            // 3. Комбинированная вариантность
//            Console.WriteLine("\n=== КОМБИНИРОВАННАЯ ВАРИАНТНОСТЬ ===\n");

//            Func<Animal, string> animalConverter = a => $"Результат: {a.Name}";

//            Console.WriteLine("Преобразование с вариантностью:");
//            string result1 = processor.Transform(new Animal(), animalConverter);
//            string result2 = processor.Transform(new Dog(), animalConverter); // Контрвариантность + ковариантность

//            Console.WriteLine($"  Animal: {result1}");
//            Console.WriteLine($"  Dog: {result2}");

//            // 4. Практические примеры
//            Console.WriteLine("\n=== ПРАКТИЧЕСКИЕ ПРИМЕРЫ ===\n");

//            var factory = new AnimalFactory();
//            Animal animal = factory.Create<Animal>();
//            Animal dog = factory.Create<Dog>();     // Ковариантность
//            Animal puppy = factory.Create<Puppy>(); // Ковариантность

//            Console.WriteLine($"Создано: {animal.Name}, {dog.Name}, {puppy.Name}");
//        }
//    }

//    // Иерархия классов
//    public class Animal
//    {
//        public string Name { get; set; } = "Животное";
//        public virtual void Speak() => Console.WriteLine("  Звук животного");
//    }

//    public class Dog : Animal
//    {
//        public Dog() { Name = "Собака"; }
//        public override void Speak() => Console.WriteLine("  Гав!");
//    }

//    public class Puppy : Dog
//    {
//        public Puppy() { Name = "Щенок"; }
//        public override void Speak() => Console.WriteLine("  Тяв!");
//    }

//    // Класс с generic-методами для вариантности
//    public class VarianceProcessor
//    {
//        // Generic-метод с ковариантным ограничением
//        // Может принимать IEnumerable<Dog> как IEnumerable<Animal>
//        public void ProcessAnimals<T>(IEnumerable<T> animals) where T : Animal
//        {
//            Console.WriteLine($"Обработка {typeof(T).Name}:");
//            foreach (var animal in animals)
//            {
//                Console.WriteLine($"- {animal.Name}");
//                animal.Speak();
//            }
//        }

//        // Generic-метод с контрвариантным ограничением
//        // Может принимать Action<Animal> как Action<Dog>
//        public void ApplyAction<T>(Action<T> action, T item) where T : Animal
//        {
//            action(item);
//        }

//        // Generic-метод с комбинированной вариантностью
//        // Контрвариантность в T + ковариантность в TResult
//        public TResult Transform<T, TResult>(T input, Func<T, TResult> transformer)
//            where T : Animal
//            where TResult : class
//        {
//            return transformer(input);
//        }

//        // Generic-метод для создания объектов с ковариантностью
//        public T CreateAnimal<T>() where T : Animal, new()
//        {
//            return new T();
//        }

//        // Generic-метод с фильтрацией и вариантностью
//        public IEnumerable<T> FilterAnimals<T>(IEnumerable<T> animals, Func<T, bool> predicate)
//            where T : Animal
//        {
//            return animals.Where(predicate);
//        }
//    }

//    // Практическая реализация с вариантностью
//    public class AnimalFactory
//    {
//        // Generic-метод с ковариантным ограничением
//        public T Create<T>() where T : Animal, new()
//        {
//            var animal = new T();
//            Console.WriteLine($"Создано: {animal.Name}");
//            return animal;
//        }
//    }

//    public class AnimalValidator
//    {
//        // Generic-метод с контрвариантным параметром
//        public bool Validate<T>(T animal, Func<T, bool> validator) where T : Animal
//        {
//            return validator(animal);
//        }
//    }
//}


//81
//using System;

//namespace EnumTask81
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 81: DaysOfWeek и определение выходного дня ===\n");

//            // Тестирование всех дней недели
//            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
//            {
//                string dayType = IsWeekend(day) ? "Выходной" : "Рабочий день";
//                Console.WriteLine($"{day}: {dayType}");
//            }

//            // Тестирование конкретного дня
//            DaysOfWeek today = DaysOfWeek.Saturday;
//            Console.WriteLine($"\nСегодня {today}: {(IsWeekend(today) ? "Ура, выходной!" : "Время работать!")}");
//        }

//        static bool IsWeekend(DaysOfWeek day)
//        {
//            return day == DaysOfWeek.Saturday || day == DaysOfWeek.Sunday;
//        }
//    }

//    public enum DaysOfWeek
//    {
//        Monday = 1,    // Понедельник
//        Tuesday,       // Вторник
//        Wednesday,     // Среда
//        Thursday,      // Четверг
//        Friday,        // Пятница
//        Saturday,      // Суббота
//        Sunday         // Воскресенье
//    }
//}


//82
//using System;

//namespace EnumTask82
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 82: Enum с явными значениями ===\n");

//            // Демонстрация значений
//            Console.WriteLine("Все значения Status:");
//            foreach (Status status in Enum.GetValues(typeof(Status)))
//            {
//                Console.WriteLine($"{status} = {(int)status}");
//            }

//            // Работа с конкретными значениями
//            Status current = Status.Active;
//            Console.WriteLine($"\nТекущий статус: {current} (значение: {(int)current})");

//            // Создание из числового значения
//            Status fromValue = (Status)3;
//            Console.WriteLine($"Статус из значения 3: {fromValue}");

//            // Проверка валидности значения
//            int testValue = 5;
//            if (Enum.IsDefined(typeof(Status), testValue))
//            {
//                Console.WriteLine($"Значение {testValue} валидно: {(Status)testValue}");
//            }
//            else
//            {
//                Console.WriteLine($"Значение {testValue} невалидно для Status");
//            }
//        }
//    }

//    public enum Status
//    {
//        None = 0,      // Не установлен
//        Pending = 1,   // Ожидание
//        Active = 2,    // Активный
//        Completed = 3, // Завершен
//        Cancelled = 4  // Отменен
//    }
//}


//83
//using System;

//namespace EnumTask83
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 83: Флаговое перечисление FilePermissions ===\n");

//            // Создание комбинированных прав
//            FilePermissions userPermissions = FilePermissions.Read | FilePermissions.Write;
//            Console.WriteLine($"Права пользователя: {userPermissions} (значение: {(int)userPermissions})");

//            // Добавление права
//            userPermissions |= FilePermissions.Execute;
//            Console.WriteLine($"После добавления Execute: {userPermissions}");

//            // Проверка прав
//            Console.WriteLine($"\nПроверка прав для {userPermissions}:");
//            Console.WriteLine($"- Может читать: {userPermissions.HasFlag(FilePermissions.Read)}");
//            Console.WriteLine($"- Может писать: {userPermissions.HasFlag(FilePermissions.Write)}");
//            Console.WriteLine($"- Может выполнять: {userPermissions.HasFlag(FilePermissions.Execute)}");
//            Console.WriteLine($"- Может удалять: {userPermissions.HasFlag(FilePermissions.Delete)}");

//            // Удаление права
//            userPermissions &= ~FilePermissions.Write;
//            Console.WriteLine($"\nПосле удаления Write: {userPermissions}");

//            // Предопределенные комбинации
//            FilePermissions admin = FilePermissions.FullControl;
//            Console.WriteLine($"\nПрава администратора: {admin} (значение: {(int)admin})");

//            // Проверка с помощью битовых операций
//            bool canReadWrite = (userPermissions & FilePermissions.ReadWrite) == FilePermissions.ReadWrite;
//            Console.WriteLine($"Имеет права ReadWrite: {canReadWrite}");
//        }
//    }

//    [Flags]
//    public enum FilePermissions
//    {
//        None = 0,
//        Read = 1 << 0,    // 1
//        Write = 1 << 1,   // 2
//        Execute = 1 << 2, // 4
//        Delete = 1 << 3,  // 8

//        // Комбинированные права
//        ReadWrite = Read | Write,
//        ReadExecute = Read | Execute,
//        FullControl = Read | Write | Execute | Delete
//    }
//}


//84
//using System;

//namespace EnumTask84
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 84: Конвертация enum в текст и обратно ===\n");

//            // Enum → string
//            DaysOfWeek day = DaysOfWeek.Wednesday;
//            string dayString = day.ToString();
//            Console.WriteLine($"Enum в строку: {day} -> '{dayString}'");

//            // String → enum (успешный парсинг)
//            string input = "Friday";
//            if (Enum.TryParse<DaysOfWeek>(input, out DaysOfWeek parsedDay))
//            {
//                Console.WriteLine($"Строка в enum: '{input}' -> {parsedDay}");
//            }

//            // String → enum (неудачный парсинг)
//            string invalidInput = "Funday";
//            if (!Enum.TryParse<DaysOfWeek>(invalidInput, out DaysOfWeek invalidDay))
//            {
//                Console.WriteLine($"Не удалось распарсить '{invalidInput}'");
//            }

//            // Enum → number → enum
//            int dayNumber = 7;
//            DaysOfWeek fromNumber = (DaysOfWeek)dayNumber;
//            Console.WriteLine($"Число в enum: {dayNumber} -> {fromNumber}");

//            // Number → enum с проверкой
//            int invalidNumber = 10;
//            if (Enum.IsDefined(typeof(DaysOfWeek), invalidNumber))
//            {
//                Console.WriteLine($"Число {invalidNumber} -> {(DaysOfWeek)invalidNumber}");
//            }
//            else
//            {
//                Console.WriteLine($"Число {invalidNumber} не является валидным DaysOfWeek");
//            }

//            // Получение всех значений
//            Console.WriteLine("\nВсе значения DaysOfWeek:");
//            foreach (DaysOfWeek d in Enum.GetValues(typeof(DaysOfWeek)))
//            {
//                Console.WriteLine($"- {d} = {(int)d}");
//            }
//        }
//    }

//    public enum DaysOfWeek
//    {
//        Monday = 1,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }
//}


//85
//using System;
//using System.ComponentModel;
//using System.Reflection;

//namespace EnumTask85
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 85: Enum с атрибутом Description ===\n");

//            // Тестирование всех цветов
//            Console.WriteLine("Все цвета с описаниями:");
//            foreach (Color color in Enum.GetValues(typeof(Color)))
//            {
//                string description = GetEnumDescription(color);
//                Console.WriteLine($"- {color}: {description}");
//            }

//            // Поиск по описанию
//            Console.WriteLine("\nПоиск по описанию:");
//            string searchDescription = "Зеленый цвет";
//            Color? foundColor = GetEnumFromDescription<Color>(searchDescription);
//            if (foundColor.HasValue)
//            {
//                Console.WriteLine($"Найден цвет: {foundColor.Value}");
//            }

//            // Работа с конкретным значением
//            Color favorite = Color.Blue;
//            Console.WriteLine($"\nМой любимый цвет: {favorite} - {GetEnumDescription(favorite)}");
//        }

//        static string GetEnumDescription(Enum value)
//        {
//            var field = value.GetType().GetField(value.ToString());
//            var attribute = field.GetCustomAttribute<DescriptionAttribute>();
//            return attribute?.Description ?? value.ToString();
//        }

//        static T? GetEnumFromDescription<T>(string description) where T : struct, Enum
//        {
//            foreach (T value in Enum.GetValues(typeof(T)))
//            {
//                if (GetEnumDescription(value) == description)
//                    return value;
//            }
//            return null;
//        }
//    }

//    public enum Color
//    {
//        [Description("Красный цвет - цвет страсти и энергии")]
//        Red,

//        [Description("Зеленый цвет - цвет природы и гармонии")]
//        Green,

//        [Description("Синий цвет - цвет спокойствия и уверенности")]
//        Blue,

//        [Description("Желтый цвет - цвет радости и оптимизма")]
//        Yellow,

//        [Description("Фиолетовый цвет - цвет творчества и мудрости")]
//        Purple
//    }
//}


//86
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace EnumTask86
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 86: Метод расширения для enum ===\n");

//            // Использование методов расширения
//            Console.WriteLine("Все значения DaysOfWeek:");
//            foreach (var day in EnumHelper.GetAllValues<DaysOfWeek>())
//            {
//                Console.WriteLine($"- {day} ({(int)day})");
//            }

//            Console.WriteLine("\nВсе имена Status:");
//            foreach (var name in EnumHelper.GetAllNames<Status>())
//            {
//                Console.WriteLine($"- {name}");
//            }

//            Console.WriteLine("\nПары имя-значение FilePermissions:");
//            foreach (var pair in EnumHelper.GetNameValuePairs<FilePermissions>())
//            {
//                Console.WriteLine($"- {pair.Name} = {pair.Value} (0x{pair.Value:X})");
//            }

//            // Получение случайного значения
//            var randomDay = EnumHelper.GetRandomValue<DaysOfWeek>();
//            Console.WriteLine($"\nСлучайный день: {randomDay}");

//            // Проверка на флаговый enum
//            Console.WriteLine($"\nDaysOfWeek является флаговым: {EnumHelper.IsFlagsEnum<DaysOfWeek>()}");
//            Console.WriteLine($"FilePermissions является флаговым: {EnumHelper.IsFlagsEnum<FilePermissions>()}");
//        }
//    }

//    public enum DaysOfWeek
//    {
//        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
//    }

//    public enum Status
//    {
//        None, Pending, Active, Completed, Cancelled
//    }

//    [Flags]
//    public enum FilePermissions
//    {
//        None = 0, Read = 1, Write = 2, Execute = 4, Delete = 8
//    }

//    public static class EnumHelper
//    {
//        public static T[] GetAllValues<T>() where T : Enum
//        {
//            return Enum.GetValues(typeof(T)).Cast<T>().ToArray();
//        }

//        public static string[] GetAllNames<T>() where T : Enum
//        {
//            return Enum.GetNames(typeof(T));
//        }

//        public static List<(string Name, int Value)> GetNameValuePairs<T>() where T : Enum
//        {
//            return Enum.GetValues(typeof(T))
//                      .Cast<T>()
//                      .Select(e => (e.ToString(), Convert.ToInt32(e)))
//                      .ToList();
//        }

//        public static T GetRandomValue<T>() where T : Enum
//        {
//            var values = GetAllValues<T>();
//            var random = new Random();
//            return values[random.Next(values.Length)];
//        }

//        public static bool IsFlagsEnum<T>() where T : Enum
//        {
//            return typeof(T).GetCustomAttributes(typeof(FlagsAttribute), false).Length > 0;
//        }
//    }
//}


//87
//using System;

//namespace EnumTask87
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 87: Проверка валидности значения enum ===\n");

//            // Тестирование валидных значений
//            TestValue(DaysOfWeek.Monday);
//            TestValue((DaysOfWeek)3);
//            TestValue((DaysOfWeek)7);

//            // Тестирование невалидных значений
//            TestValue((DaysOfWeek)0);
//            TestValue((DaysOfWeek)8);
//            TestValue((DaysOfWeek)100);
//            TestValue((DaysOfWeek)(-1));

//            // Тестирование строковых значений
//            Console.WriteLine("\nПроверка строковых значений:");
//            TestStringValue("Monday");
//            TestStringValue("Funday");
//            TestStringValue("3");
//            TestStringValue("100");
//        }

//        static void TestValue<T>(T value) where T : Enum
//        {
//            bool isValid = Enum.IsDefined(typeof(T), value);
//            Console.WriteLine($"Значение {value} ({(int)(object)value}) валидно для {typeof(T).Name}: {isValid}");
//        }

//        static void TestStringValue(string value)
//        {
//            if (Enum.TryParse<DaysOfWeek>(value, out DaysOfWeek result) &&
//                Enum.IsDefined(typeof(DaysOfWeek), result))
//            {
//                Console.WriteLine($"Строка '{value}' валидна: {result}");
//            }
//            else
//            {
//                Console.WriteLine($"Строка '{value}' невалидна для DaysOfWeek");
//            }
//        }
//    }

//    public enum DaysOfWeek
//    {
//        Monday = 1,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }

//    public static class EnumValidationExtensions
//    {
//        public static bool IsValid<T>(this T value) where T : Enum
//        {
//            return Enum.IsDefined(typeof(T), value);
//        }

//        public static bool IsValid<T>(this int value) where T : Enum
//        {
//            return Enum.IsDefined(typeof(T), value);
//        }

//        public static bool IsValid<T>(this string value) where T : Enum
//        {
//            return Enum.TryParse<T>(value, out T result) && Enum.IsDefined(typeof(T), result);
//        }
//    }
//}


//88
//using System;
//using System.Collections.Generic;

//namespace EnumTask88
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 88: OrderStatus с переходами между статусами ===\n");

//            // Создание заказа
//            Order order = new Order();
//            Console.WriteLine($"Создан заказ. Статус: {order.CurrentStatus}");

//            // Последовательные переходы
//            Console.WriteLine("\nВыполнение последовательных переходов:");
//            while (order.MoveToNextStatus())
//            {
//                Console.WriteLine($"Переход выполнен. Новый статус: {order.CurrentStatus}");
//            }

//            // Создание нового заказа для тестирования произвольных переходов
//            Console.WriteLine("\nТестирование произвольных переходов:");
//            Order order2 = new Order();

//            // Валидные переходы
//            order2.MoveToStatus(OrderStatus.Confirmed);
//            order2.MoveToStatus(OrderStatus.Shipped);

//            // Невалидный переход
//            order2.MoveToStatus(OrderStatus.Pending); // Нельзя вернуться назад

//            // Валидный переход
//            order2.MoveToStatus(OrderStatus.Delivered);

//            // Попытка изменить завершенный заказ
//            order2.MoveToStatus(OrderStatus.Cancelled);

//            // Показать историю переходов
//            Console.WriteLine("\nИстория переходов заказа:");
//            foreach (var transition in order2.GetStatusHistory())
//            {
//                Console.WriteLine($"- {transition.Time:HH:mm:ss}: {transition.FromStatus} → {transition.ToStatus}");
//            }
//        }
//    }

//    public enum OrderStatus
//    {
//        Pending,    // Ожидает подтверждения
//        Confirmed,  // Подтвержден
//        Shipped,    // Отправлен
//        Delivered,  // Доставлен
//        Cancelled   // Отменен
//    }

//    public class Order
//    {
//        public OrderStatus CurrentStatus { get; private set; } = OrderStatus.Pending;

//        private List<StatusTransition> _statusHistory = new List<StatusTransition>();

//        public Order()
//        {
//            _statusHistory.Add(new StatusTransition
//            {
//                Time = DateTime.Now,
//                FromStatus = OrderStatus.Pending,
//                ToStatus = OrderStatus.Pending
//            });
//        }

//        public bool MoveToNextStatus()
//        {
//            OrderStatus nextStatus = CurrentStatus switch
//            {
//                OrderStatus.Pending => OrderStatus.Confirmed,
//                OrderStatus.Confirmed => OrderStatus.Shipped,
//                OrderStatus.Shipped => OrderStatus.Delivered,
//                _ => CurrentStatus // Конечные статусы
//            };

//            return MoveToStatus(nextStatus);
//        }

//        public bool MoveToStatus(OrderStatus newStatus)
//        {
//            if (!IsValidTransition(CurrentStatus, newStatus))
//            {
//                Console.WriteLine($"Недопустимый переход: {CurrentStatus} → {newStatus}");
//                return false;
//            }

//            var oldStatus = CurrentStatus;
//            CurrentStatus = newStatus;

//            _statusHistory.Add(new StatusTransition
//            {
//                Time = DateTime.Now,
//                FromStatus = oldStatus,
//                ToStatus = newStatus
//            });

//            Console.WriteLine($"Успешный переход: {oldStatus} → {newStatus}");
//            return true;
//        }

//        private bool IsValidTransition(OrderStatus from, OrderStatus to)
//        {
//            var validTransitions = new Dictionary<OrderStatus, OrderStatus[]>
//            {
//                [OrderStatus.Pending] = new[] { OrderStatus.Confirmed, OrderStatus.Cancelled },
//                [OrderStatus.Confirmed] = new[] { OrderStatus.Shipped, OrderStatus.Cancelled },
//                [OrderStatus.Shipped] = new[] { OrderStatus.Delivered, OrderStatus.Cancelled },
//                [OrderStatus.Delivered] = new OrderStatus[0], // Конечный статус
//                [OrderStatus.Cancelled] = new OrderStatus[0]  // Конечный статус
//            };

//            return Array.Exists(validTransitions[from], status => status == to);
//        }

//        public IEnumerable<StatusTransition> GetStatusHistory()
//        {
//            return _statusHistory;
//        }
//    }

//    public struct StatusTransition
//    {
//        public DateTime Time { get; set; }
//        public OrderStatus FromStatus { get; set; }
//        public OrderStatus ToStatus { get; set; }
//    }
//}


//89
//using System;

//namespace EnumTask89
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 89: Универсальный метод для парсинга строк ===\n");

//            string[] testStrings = {
//                "Monday", "monday", "MONDAY", "1", "5",
//                "Active", "Completed", "Read", "ReadWrite", "Invalid"
//            };

//            Console.WriteLine("Парсинг строк в DaysOfWeek:");
//            foreach (string testString in testStrings)
//            {
//                var result = EnumParser.Parse<DaysOfWeek>(testString);
//                Console.WriteLine($"  '{testString}' -> {result}");
//            }

//            Console.WriteLine("\nПарсинг строк в Status:");
//            foreach (string testString in testStrings)
//            {
//                var result = EnumParser.Parse<Status>(testString);
//                Console.WriteLine($"  '{testString}' -> {result}");
//            }

//            Console.WriteLine("\nПарсинг строк в FilePermissions:");
//            foreach (string testString in testStrings)
//            {
//                var result = EnumParser.Parse<FilePermissions>(testString);
//                Console.WriteLine($"  '{testString}' -> {result}");
//            }

//            // Тестирование расширенных возможностей
//            Console.WriteLine("\nРасширенные возможности:");
//            Console.WriteLine($"Чувствительность к регистру 'Monday': {EnumParser.Parse<DaysOfWeek>("Monday", false)}");
//            Console.WriteLine($"Чувствительность к регистру 'monday': {EnumParser.Parse<DaysOfWeek>("monday", false)}");
//            Console.WriteLine($"Игнорирование регистра 'monday': {EnumParser.Parse<DaysOfWeek>("monday", true)}");

//            // Парсинг с значением по умолчанию
//            Console.WriteLine($"Невалидная строка с default: {EnumParser.Parse<DaysOfWeek>("Invalid", defaultValue: DaysOfWeek.Sunday)}");
//        }
//    }

//    public enum DaysOfWeek
//    {
//        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
//    }

//    public enum Status
//    {
//        None, Pending, Active, Completed, Cancelled
//    }

//    [Flags]
//    public enum FilePermissions
//    {
//        None = 0, Read = 1, Write = 2, Execute = 4, ReadWrite = Read | Write
//    }

//    public static class EnumParser
//    {
//        public static T? Parse<T>(string value, bool ignoreCase = true, T? defaultValue = null)
//            where T : struct, Enum
//        {
//            if (Enum.TryParse<T>(value, ignoreCase, out T result) && Enum.IsDefined(typeof(T), result))
//            {
//                return result;
//            }

//            // Попробовать распарсить как число
//            if (int.TryParse(value, out int numericValue) && Enum.IsDefined(typeof(T), numericValue))
//            {
//                return (T)Enum.ToObject(typeof(T), numericValue);
//            }

//            return defaultValue;
//        }

//        public static T ParseRequired<T>(string value, bool ignoreCase = true) where T : struct, Enum
//        {
//            var result = Parse<T>(value, ignoreCase);
//            if (result == null)
//            {
//                throw new ArgumentException($"Не удалось распарсить '{value}' как {typeof(T).Name}");
//            }
//            return result.Value;
//        }

//        public static bool TryParse<T>(string value, out T result, bool ignoreCase = true) where T : struct, Enum
//        {
//            result = default;
//            var parsed = Parse<T>(value, ignoreCase);
//            if (parsed.HasValue)
//            {
//                result = parsed.Value;
//                return true;
//            }
//            return false;
//        }
//    }
//}


//90
//using System;

//namespace EnumTask90
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 90: Enum с базовым типом byte ===\n");

//            // Демонстрация размеров
//            Console.WriteLine("Размеры типов в байтах:");
//            Console.WriteLine($"- SmallEnum (byte): {sizeof(SmallEnum)} байт");
//            Console.WriteLine($"- NormalEnum (int): {sizeof(NormalEnum)} байт");
//            Console.WriteLine($"- LargeEnum (long): {sizeof(LargeEnum)} байт");

//            // Работа с SmallEnum
//            Console.WriteLine("\nРабота с SmallEnum:");
//            SmallEnum small = SmallEnum.High;
//            Console.WriteLine($"Значение: {small}, числовое: {(byte)small}, размер: {sizeof(SmallEnum)} байт");

//            // Массив SmallEnum - экономия памяти
//            SmallEnum[] smallArray = new SmallEnum[1000];
//            Console.WriteLine($"\nМассив из 1000 SmallEnum: ~{1000 * sizeof(SmallEnum)} байт");

//            // Сравнение с обычным enum
//            NormalEnum[] normalArray = new NormalEnum[1000];
//            Console.WriteLine($"Массив из 1000 NormalEnum: ~{1000 * sizeof(NormalEnum)} байт");

//            // Экономия памяти
//            long savings = 1000 * (sizeof(NormalEnum) - sizeof(SmallEnum));
//            Console.WriteLine($"Экономия памяти: {savings} байт");

//            // Использование в структурах
//            var packet = new NetworkPacket();
//            Console.WriteLine($"\nРазмер структуры NetworkPacket: {System.Runtime.InteropServices.Marshal.SizeOf(packet)} байт");

//            // Проверка граничных значений
//            Console.WriteLine($"\nГраничные значения SmallEnum:");
//            Console.WriteLine($"Минимальное: {SmallEnum.Low} = {(byte)SmallEnum.Low}");
//            Console.WriteLine($"Максимальное: {SmallEnum.High} = {(byte)SmallEnum.High}");

//            // Преобразование между типами
//            byte value = 200;
//            if (Enum.IsDefined(typeof(SmallEnum), value))
//            {
//                SmallEnum fromByte = (SmallEnum)value;
//                Console.WriteLine($"Преобразование byte → SmallEnum: {value} → {fromByte}");
//            }
//        }
//    }

//    // Enum с базовым типом byte для экономии памяти
//    public enum SmallEnum : byte
//    {
//        None = 0,
//        Low = 10,
//        Medium = 50,
//        High = 100,
//        Maximum = 255  // Максимальное значение для byte
//    }

//    // Обычный enum (базовый тип int)
//    public enum NormalEnum
//    {
//        First,
//        Second,
//        Third
//    }

//    // Enum с большим базовым типом
//    public enum LargeEnum : long
//    {
//        Small = 1,
//        Large = 1000000,
//        VeryLarge = 1000000000
//    }

//    // Пример использования в структуре для экономии памяти
//    public struct NetworkPacket
//    {
//        public SmallEnum PacketType;     // 1 байт
//        public byte SequenceNumber;      // 1 байт  
//        public ushort DataLength;        // 2 байта
//        public uint Checksum;            // 4 байта

//        // Итого: 8 байт вместо 12, если бы использовали int для PacketType
//    }

//    public static class ByteEnumExtensions
//    {
//        public static byte ToByte<T>(this T value) where T : Enum
//        {
//            return Convert.ToByte(value);
//        }

//        public static bool IsValidByteValue<T>(this byte value) where T : Enum
//        {
//            return Enum.IsDefined(typeof(T), value);
//        }
//    }
//}


//91
//using System;

//namespace EnumTask91
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 91: Циклическое перечисление ===\n");

//            Season current = Season.Winter;
//            Console.WriteLine("Циклический переход по сезонам:");

//            for (int i = 0; i < 8; i++)
//            {
//                Console.WriteLine($"Шаг {i}: {current} -> {current.Next()}");
//                current = current.Next();
//            }

//            Console.WriteLine($"\nОбратный переход: {Season.Summer} -> {Season.Summer.Previous()}");
//        }
//    }

//    public enum Season
//    {
//        Spring,
//        Summer,
//        Autumn,
//        Winter
//    }

//    public static class SeasonExtensions
//    {
//        public static Season Next(this Season current)
//        {
//            return (Season)(((int)current + 1) % Enum.GetValues(typeof(Season)).Length);
//        }

//        public static Season Previous(this Season current)
//        {
//            int length = Enum.GetValues(typeof(Season)).Length;
//            return (Season)(((int)current - 1 + length) % length);
//        }
//    }
//}


//92
//using System;

//namespace EnumTask92
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 92: Color enum с RGB значениями ===\n");

//            Console.WriteLine("Цвета и их RGB значения:");
//            foreach (Color color in Enum.GetValues(typeof(Color)))
//            {
//                var rgb = color.GetRGB();
//                Console.WriteLine($"{color,-12}: RGB({rgb.R,3}, {rgb.G,3}, {rgb.B,3}) | {color.ToHex()}");
//            }

//            Console.WriteLine($"\nПример: {Color.Blue} в HEX: {Color.Blue.ToHex()}");
//        }
//    }

//    public enum Color
//    {
//        Red,
//        Green,
//        Blue,
//        Yellow,
//        Cyan,
//        Magenta,
//        Black,
//        White
//    }

//    public static class ColorExtensions
//    {
//        public static (byte R, byte G, byte B) GetRGB(this Color color)
//        {
//            return color switch
//            {
//                Color.Red => (255, 0, 0),
//                Color.Green => (0, 255, 0),
//                Color.Blue => (0, 0, 255),
//                Color.Yellow => (255, 255, 0),
//                Color.Cyan => (0, 255, 255),
//                Color.Magenta => (255, 0, 255),
//                Color.Black => (0, 0, 0),
//                Color.White => (255, 255, 255),
//                _ => (0, 0, 0)
//            };
//        }

//        public static string ToHex(this Color color)
//        {
//            var rgb = color.GetRGB();
//            return $"#{rgb.R:X2}{rgb.G:X2}{rgb.B:X2}";
//        }
//    }
//}


//93
//using System;
//using System.Collections.Generic;

//namespace EnumTask93
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 93: Флаговое перечисление UserRoles ===\n");

//            UserRoles user = UserRoles.User | UserRoles.Moderator;
//            UserRoles admin = UserRoles.Administrator | UserRoles.Moderator | UserRoles.User;

//            Console.WriteLine($"Роли пользователя: {user} = {user.ToRoleString()}");
//            Console.WriteLine($"Роли администратора: {admin} = {admin.ToRoleString()}");

//            Console.WriteLine($"\nПроверка прав:");
//            Console.WriteLine($"Пользователь имеет роль Moderator: {user.HasRole(UserRoles.Moderator)}");
//            Console.WriteLine($"Пользователь имеет роль Administrator: {user.HasRole(UserRoles.Administrator)}");

//            user = user.AddRole(UserRoles.Guest);
//            Console.WriteLine($"После добавления Guest: {user.ToRoleString()}");
//        }
//    }

//    [Flags]
//    public enum UserRoles
//    {
//        None = 0,
//        Guest = 1,
//        User = 2,
//        Moderator = 4,
//        Administrator = 8
//    }

//    public static class UserRolesExtensions
//    {
//        public static bool HasRole(this UserRoles roles, UserRoles role)
//        {
//            return (roles & role) == role;
//        }

//        public static UserRoles AddRole(this UserRoles roles, UserRoles role)
//        {
//            return roles | role;
//        }

//        public static UserRoles RemoveRole(this UserRoles roles, UserRoles role)
//        {
//            return roles & ~role;
//        }

//        public static string ToRoleString(this UserRoles roles)
//        {
//            if (roles == UserRoles.None)
//                return "None";

//            var roleNames = new List<string>();
//            foreach (UserRoles role in Enum.GetValues(typeof(UserRoles)))
//            {
//                if (role != UserRoles.None && roles.HasRole(role))
//                {
//                    roleNames.Add(role.ToString());
//                }
//            }
//            return string.Join(" | ", roleNames);
//        }
//    }
//}


//94
//using System;

//namespace EnumTask94
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 94: Подсчет флагов в перечислении ===\n");

//            UserRoles roles1 = UserRoles.User;
//            UserRoles roles2 = UserRoles.Administrator | UserRoles.Moderator;
//            UserRoles roles3 = UserRoles.Administrator | UserRoles.Moderator | UserRoles.User | UserRoles.Guest;

//            Console.WriteLine($"Роли: {roles1.ToRoleString()}");
//            Console.WriteLine($"Количество флагов: {EnumFlagsCounter.CountFlags(roles1)}");

//            Console.WriteLine($"\nРоли: {roles2.ToRoleString()}");
//            Console.WriteLine($"Количество флагов: {EnumFlagsCounter.CountFlags(roles2)}");

//            Console.WriteLine($"\nРоли: {roles3.ToRoleString()}");
//            Console.WriteLine($"Количество флагов: {EnumFlagsCounter.CountFlags(roles3)}");
//            Console.WriteLine($"Оптимизированный подсчет: {EnumFlagsCounter.CountFlagsOptimized(roles3)}");
//        }
//    }

//    [Flags]
//    public enum UserRoles
//    {
//        None = 0,
//        Guest = 1,
//        User = 2,
//        Moderator = 4,
//        Administrator = 8
//    }

//    public static class UserRolesExtensions
//    {
//        public static string ToRoleString(this UserRoles roles)
//        {
//            if (roles == UserRoles.None)
//                return "None";

//            var roleNames = new System.Collections.Generic.List<string>();
//            foreach (UserRoles role in Enum.GetValues(typeof(UserRoles)))
//            {
//                if (role != UserRoles.None && roles.HasFlag(role))
//                {
//                    roleNames.Add(role.ToString());
//                }
//            }
//            return string.Join(" | ", roleNames);
//        }
//    }

//    public static class EnumFlagsCounter
//    {
//        public static int CountFlags<T>(T flags) where T : Enum
//        {
//            int value = Convert.ToInt32(flags);
//            int count = 0;

//            while (value != 0)
//            {
//                count += value & 1;
//                value >>= 1;
//            }

//            return count;
//        }

//        public static int CountFlagsOptimized<T>(T flags) where T : Enum
//        {
//            int value = Convert.ToInt32(flags);
//            int count = 0;
//            while (value != 0)
//            {
//                count++;
//                value &= value - 1;
//            }
//            return count;
//        }
//    }
//}


//95
//using System;

//namespace EnumTask95
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 95: Priority enum с сравнением приоритетов ===\n");

//            Priority low = Priority.Low;
//            Priority high = Priority.High;
//            Priority critical = Priority.Critical;

//            Console.WriteLine($"Сравнение приоритетов:");
//            Console.WriteLine($"{low} > {high}: {low.IsHigherThan(high)}");
//            Console.WriteLine($"{high} > {low}: {high.IsHigherThan(low)}");
//            Console.WriteLine($"{critical} >= {high}: {critical.IsAtLeast(high)}");

//            Console.WriteLine($"\nМаксимальный из {low} и {critical}: {PriorityExtensions.Max(low, critical)}");
//            Console.WriteLine($"Минимальный из {high} и {critical}: {PriorityExtensions.Min(high, critical)}");

//            Priority medium = Priority.Medium;
//            Console.WriteLine($"\nПовышение приоритета: {medium} -> {medium.Increase()}");
//            Console.WriteLine($"Понижение приоритета: {high} -> {high.Decrease()}");
//        }
//    }

//    public enum Priority
//    {
//        Lowest = 1,
//        Low = 2,
//        Medium = 3,
//        High = 4,
//        Highest = 5,
//        Critical = 6
//    }

//    public static class PriorityExtensions
//    {
//        public static bool IsHigherThan(this Priority current, Priority other)
//        {
//            return current > other;
//        }

//        public static bool IsLowerThan(this Priority current, Priority other)
//        {
//            return current < other;
//        }

//        public static bool IsAtLeast(this Priority current, Priority minimum)
//        {
//            return current >= minimum;
//        }

//        public static Priority Max(Priority a, Priority b)
//        {
//            return a > b ? a : b;
//        }

//        public static Priority Min(Priority a, Priority b)
//        {
//            return a < b ? a : b;
//        }

//        public static Priority Increase(this Priority current)
//        {
//            if (current == Priority.Critical)
//                return current;
//            return (Priority)((int)current + 1);
//        }

//        public static Priority Decrease(this Priority current)
//        {
//            if (current == Priority.Lowest)
//                return current;
//            return (Priority)((int)current - 1);
//        }
//    }
//}


//96
//using System;
//using System.Collections.Generic;

//namespace EnumTask96
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 96: Локализация результатов enum ===\n");

//            Status status = Status.Approved;

//            Console.WriteLine("Локализация статусов:");
//            Console.WriteLine($"Английский: {status.GetLocalizedString("en")}");
//            Console.WriteLine($"Русский: {status.GetLocalizedString("ru")}");
//            Console.WriteLine($"Испанский: {status.GetLocalizedString("es")}");
//            Console.WriteLine($"Французский: {status.GetLocalizedString("fr")} (по умолчанию)");

//            Console.WriteLine($"\nВсе статусы на русском:");
//            foreach (Status s in Enum.GetValues(typeof(Status)))
//            {
//                Console.WriteLine($"{s} -> {s.GetLocalizedString("ru")}");
//            }
//        }
//    }

//    public enum Status
//    {
//        Pending,
//        Approved,
//        Rejected,
//        Completed
//    }

//    public static class StatusLocalizer
//    {
//        private static readonly Dictionary<Status, Dictionary<string, string>> translations = new()
//        {
//            [Status.Pending] = new()
//            {
//                ["en"] = "Pending",
//                ["ru"] = "В ожидании",
//                ["es"] = "Pendiente"
//            },
//            [Status.Approved] = new()
//            {
//                ["en"] = "Approved",
//                ["ru"] = "Одобрено",
//                ["es"] = "Aprobado"
//            },
//            [Status.Rejected] = new()
//            {
//                ["en"] = "Rejected",
//                ["ru"] = "Отклонено",
//                ["es"] = "Rechazado"
//            },
//            [Status.Completed] = new()
//            {
//                ["en"] = "Completed",
//                ["ru"] = "Завершено",
//                ["es"] = "Completado"
//            }
//        };

//        public static string GetLocalizedString(this Status status, string languageCode = "en")
//        {
//            if (translations.TryGetValue(status, out var languageDict) &&
//                languageDict.TryGetValue(languageCode, out var translation))
//            {
//                return translation;
//            }
//            return status.ToString();
//        }
//    }
//}


//97
//using System;

//namespace EnumTask97
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 97: Enum с методом для получения связанной иконки или цвета ===\n");

//            Console.WriteLine("Типы уведомлений и их визуальное представление:");
//            foreach (NotificationType type in Enum.GetValues(typeof(NotificationType)))
//            {
//                Console.WriteLine($"{type,-8}: {type.GetIcon()} | Цвет: {type.GetColor()} | CSS: {type.GetCSSColor()}");
//            }

//            Console.WriteLine($"\nПример использования:");
//            NotificationType error = NotificationType.Error;
//            Console.WriteLine($"Уведомление {error}: {error.GetIcon()} цвет {error.GetColor()}");
//        }
//    }

//    public enum NotificationType
//    {
//        Info,
//        Success,
//        Warning,
//        Error
//    }

//    public static class NotificationTypeExtensions
//    {
//        public static string GetIcon(this NotificationType type)
//        {
//            return type switch
//            {
//                NotificationType.Info => "ℹ️",
//                NotificationType.Success => "✅",
//                NotificationType.Warning => "⚠️",
//                NotificationType.Error => "❌",
//                _ => "📄"
//            };
//        }

//        public static ConsoleColor GetColor(this NotificationType type)
//        {
//            return type switch
//            {
//                NotificationType.Info => ConsoleColor.Blue,
//                NotificationType.Success => ConsoleColor.Green,
//                NotificationType.Warning => ConsoleColor.Yellow,
//                NotificationType.Error => ConsoleColor.Red,
//                _ => ConsoleColor.White
//            };
//        }

//        public static string GetCSSColor(this NotificationType type)
//        {
//            return type switch
//            {
//                NotificationType.Info => "#007bff",
//                NotificationType.Success => "#28a745",
//                NotificationType.Warning => "#ffc107",
//                NotificationType.Error => "#dc3545",
//                _ => "#6c757d"
//            };
//        }
//    }
//}


//98
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace EnumTask98
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 98: State Machine на основе enum ===\n");

//            OrderState currentState = OrderState.Created;
//            Console.WriteLine($"Начальное состояние: {currentState}");

//            Console.WriteLine($"\nДоступные переходы:");
//            foreach (var transition in currentState.GetPossibleTransitions())
//            {
//                Console.WriteLine($"  {currentState} -> {transition}");
//            }

//            currentState = currentState.TransitionTo(OrderState.PaymentPending);
//            Console.WriteLine($"\nПосле перехода: {currentState}");

//            Console.WriteLine($"\nПопытка недопустимого перехода:");
//            try
//            {
//                currentState.TransitionTo(OrderState.Delivered);
//            }
//            catch (InvalidOperationException ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//            }
//        }
//    }

//    public enum OrderState
//    {
//        Created,
//        PaymentPending,
//        Paid,
//        Shipped,
//        Delivered,
//        Cancelled,
//        Refunded
//    }

//    public static class OrderStateMachine
//    {
//        private static readonly Dictionary<OrderState, OrderState[]> allowedTransitions = new()
//        {
//            [OrderState.Created] = new[] { OrderState.PaymentPending, OrderState.Cancelled },
//            [OrderState.PaymentPending] = new[] { OrderState.Paid, OrderState.Cancelled },
//            [OrderState.Paid] = new[] { OrderState.Shipped, OrderState.Refunded },
//            [OrderState.Shipped] = new[] { OrderState.Delivered },
//            [OrderState.Delivered] = new[] { OrderState.Refunded },
//            [OrderState.Cancelled] = Array.Empty<OrderState>(),
//            [OrderState.Refunded] = Array.Empty<OrderState>()
//        };

//        public static bool CanTransitionTo(this OrderState current, OrderState next)
//        {
//            return allowedTransitions[current].Contains(next);
//        }

//        public static OrderState TransitionTo(this OrderState current, OrderState next)
//        {
//            if (!current.CanTransitionTo(next))
//            {
//                throw new InvalidOperationException(
//                    $"Cannot transition from {current} to {next}");
//            }
//            return next;
//        }

//        public static OrderState[] GetPossibleTransitions(this OrderState current)
//        {
//            return allowedTransitions[current];
//        }
//    }
//}


//99
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace EnumTask99
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 99: Все комбинации флагового перечисления ===\n");

//            var combinations = FlagEnumCombinations.GetAllFlagCombinations<UserRoles>();

//            Console.WriteLine("Все возможные комбинации ролей:");
//            int count = 0;
//            foreach (var combination in combinations)
//            {
//                if (combination != UserRoles.None)
//                {
//                    count++;
//                    Console.WriteLine($"  {count,2}. {combination.ToRoleString()}");
//                }
//            }

//            Console.WriteLine($"\nВсего комбинаций (без None): {count}");
//            Console.WriteLine($"Теоретическое количество: {Math.Pow(2, 4) - 1}");
//        }
//    }

//    [Flags]
//    public enum UserRoles
//    {
//        None = 0,
//        Guest = 1,
//        User = 2,
//        Moderator = 4,
//        Administrator = 8
//    }

//    public static class UserRolesExtensions
//    {
//        public static string ToRoleString(this UserRoles roles)
//        {
//            if (roles == UserRoles.None)
//                return "None";

//            var roleNames = new List<string>();
//            foreach (UserRoles role in Enum.GetValues(typeof(UserRoles)))
//            {
//                if (role != UserRoles.None && roles.HasFlag(role))
//                {
//                    roleNames.Add(role.ToString());
//                }
//            }
//            return string.Join(" | ", roleNames);
//        }
//    }

//    public static class FlagEnumCombinations
//    {
//        public static IEnumerable<T> GetAllFlagCombinations<T>() where T : Enum
//        {
//            Type enumType = typeof(T);
//            Array values = Enum.GetValues(enumType);
//            int count = values.Length;
//            int totalCombinations = 1 << count;

//            for (int i = 0; i < totalCombinations; i++)
//            {
//                int combination = 0;
//                for (int j = 0; j < count; j++)
//                {
//                    if ((i & (1 << j)) != 0)
//                    {
//                        combination |= (int)values.GetValue(j)!;
//                    }
//                }
//                yield return (T)Enum.ToObject(enumType, combination);
//            }
//        }
//    }
//}


//100
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace EnumTask100
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 100: Enum с валидацией и бизнес-логикой ===\n");

//            DocumentStatus currentStatus = DocumentStatus.Draft;
//            var documentData = new Dictionary<string, object>
//            {
//                ["Title"] = "Важный документ",
//                ["Content"] = "Содержание документа",
//                ["Author"] = "Иван Иванов"
//            };

//            Console.WriteLine($"Текущий статус: {currentStatus}");
//            Console.WriteLine($"Можно редактировать: {currentStatus.CanBeEdited()}");
//            Console.WriteLine($"Можно удалить: {currentStatus.CanBeDeleted()}");
//            Console.WriteLine($"Ожидаемое время обработки: {currentStatus.GetExpectedProcessingTime()}");

//            Console.WriteLine($"\nПроверка перехода в UnderReview:");
//            var validation = DocumentStatusValidator.ValidateTransition(
//                currentStatus, DocumentStatus.UnderReview, documentData);

//            if (validation.IsValid)
//            {
//                Console.WriteLine("✓ Переход допустим");
//            }
//            else
//            {
//                Console.WriteLine("✗ Ошибки валидации:");
//                foreach (var error in validation.Errors)
//                {
//                    Console.WriteLine($"  - {error}");
//                }
//            }

//            Console.WriteLine($"\nПроверка перехода в Published (должен быть ошибка):");
//            documentData["Reviewer"] = "Петр Петров";
//            validation = DocumentStatusValidator.ValidateTransition(
//                DocumentStatus.Approved, DocumentStatus.Published, documentData);

//            if (!validation.IsValid)
//            {
//                Console.WriteLine("Ожидаемые ошибки:");
//                foreach (var error in validation.Errors)
//                {
//                    Console.WriteLine($"  - {error}");
//                }
//            }
//        }
//    }

//    public enum DocumentStatus
//    {
//        Draft,
//        UnderReview,
//        Approved,
//        Published,
//        Archived
//    }

//    public static class DocumentStatusExtensions
//    {
//        public static bool CanBeDeleted(this DocumentStatus status)
//        {
//            return status == DocumentStatus.Draft || status == DocumentStatus.Archived;
//        }

//        public static bool CanBeEdited(this DocumentStatus status)
//        {
//            return status != DocumentStatus.Published && status != DocumentStatus.Archived;
//        }

//        public static TimeSpan GetExpectedProcessingTime(this DocumentStatus status)
//        {
//            return status switch
//            {
//                DocumentStatus.Draft => TimeSpan.Zero,
//                DocumentStatus.UnderReview => TimeSpan.FromDays(2),
//                DocumentStatus.Approved => TimeSpan.FromHours(4),
//                DocumentStatus.Published => TimeSpan.FromMinutes(30),
//                DocumentStatus.Archived => TimeSpan.FromDays(1),
//                _ => TimeSpan.Zero
//            };
//        }
//    }

//    public static class DocumentStatusValidator
//    {
//        private static readonly Dictionary<DocumentStatus, string[]> requiredFields = new()
//        {
//            [DocumentStatus.Draft] = new[] { "Title", "Content" },
//            [DocumentStatus.UnderReview] = new[] { "Title", "Content", "Author" },
//            [DocumentStatus.Approved] = new[] { "Title", "Content", "Author", "Reviewer" },
//            [DocumentStatus.Published] = new[] { "Title", "Content", "Author", "Reviewer", "PublishDate" },
//            [DocumentStatus.Archived] = new[] { "Title", "Content", "Author", "ArchiveDate" }
//        };

//        public static ValidationResult ValidateTransition(DocumentStatus from, DocumentStatus to, Dictionary<string, object> documentData)
//        {
//            var result = new ValidationResult();

//            if (!IsTransitionAllowed(from, to))
//            {
//                result.AddError($"Transition from {from} to {to} is not allowed");
//                return result;
//            }

//            var required = requiredFields[to];
//            var missingFields = required.Where(field => !documentData.ContainsKey(field) || documentData[field] == null).ToList();

//            if (missingFields.Any())
//            {
//                result.AddError($"Missing required fields for {to}: {string.Join(", ", missingFields)}");
//            }

//            if (to == DocumentStatus.Published)
//            {
//                if (documentData.TryGetValue("Content", out var content) && content is string contentStr && contentStr.Length < 100)
//                {
//                    result.AddError("Content must be at least 100 characters for publishing");
//                }
//            }

//            return result;
//        }

//        private static bool IsTransitionAllowed(DocumentStatus from, DocumentStatus to)
//        {
//            return (from, to) switch
//            {
//                (DocumentStatus.Draft, DocumentStatus.UnderReview) => true,
//                (DocumentStatus.Draft, DocumentStatus.Archived) => true,
//                (DocumentStatus.UnderReview, DocumentStatus.Approved) => true,
//                (DocumentStatus.UnderReview, DocumentStatus.Draft) => true,
//                (DocumentStatus.Approved, DocumentStatus.Published) => true,
//                (DocumentStatus.Approved, DocumentStatus.UnderReview) => true,
//                (DocumentStatus.Published, DocumentStatus.Archived) => true,
//                (DocumentStatus.Archived, DocumentStatus.Draft) => true,
//                _ => false
//            };
//        }
//    }

//    public class ValidationResult
//    {
//        public bool IsValid => !Errors.Any();
//        public List<string> Errors { get; } = new List<string>();

//        public void AddError(string error) => Errors.Add(error);
//    }
//}