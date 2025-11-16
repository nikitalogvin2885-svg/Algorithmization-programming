1
using System;
using System.Collections.Generic;

namespace StackDemo
{
    public class Stack<T>
    {
        private readonly List<T> _items = new();

        public void Push(T item)
        {
            _items.Add(item);
            Console.WriteLine($"Push: {item}");
        }

        public T Pop()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Стек пуст");
            var item = _items[^1];
            _items.RemoveAt(_items.Count - 1);
            Console.WriteLine($"Pop: {item}");
            return item;
        }

        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Стек пуст");
            return _items[^1];
        }

        public int Count => _items.Count;
    }

    class Program
    {
        static void Main()
        {
            var stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine($"\nPeek: {stack.Peek()}");
            Console.WriteLine($"Count: {stack.Count}");

            stack.Pop();
            stack.Pop();

            Console.WriteLine($"\nPeek после Pop: {stack.Peek()}");
            Console.WriteLine($"Count: {stack.Count}");
        }
    }
}


2
using System;
using System.Collections.Generic;

namespace QueueDemo
{
    public class Queue<T>
    {
        private readonly List<T> _items = new();

        public void Enqueue(T item)
        {
            _items.Add(item);
            Console.WriteLine($"Enqueue: {item}");
        }

        public T Dequeue()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Очередь пуста");
            var item = _items[0];
            _items.RemoveAt(0);
            Console.WriteLine($"Dequeue: {item}");
            return item;
        }

        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Очередь пуста");
            return _items[0];
        }

        public int Count => _items.Count;
    }

    class Program
    {
        static void Main()
        {
            var queue = new Queue<string>();

            queue.Enqueue("Первый");
            queue.Enqueue("Второй");
            queue.Enqueue("Третий");

            Console.WriteLine($"\nPeek: {queue.Peek()}");
            Console.WriteLine($"Count: {queue.Count}");

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine($"\nPeek после Dequeue: {queue.Peek()}");
            Console.WriteLine($"Count: {queue.Count}");
        }
    }
}


3
using System;

namespace FindIndexDemo
{
    class Program
    {
        public static int FindIndex<T>(T[] array, T value) where T : IEquatable<T>
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i].Equals(value))
                    return i;
            return -1;
        }

        static void Main()
        {

            int[] numbers = { 10, 20, 30, 40, 50 };
            string[] words = { "apple", "banana", "cherry" };

            Console.WriteLine($"Поиск 30 в numbers: {FindIndex(numbers, 30)}");
            Console.WriteLine($"Поиск 25 в numbers: {FindIndex(numbers, 25)}");
            Console.WriteLine($"Поиск \"banana\" в words: {FindIndex(words, "banana")}");
            Console.WriteLine($"Поиск \"orange\" в words: {FindIndex(words, "orange")}");
        }
    }
}


4
using System;

namespace PairDemo
{
    public class Pair<T>
    {
        public T First { get; set; }
        public T Second { get; set; }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public override string ToString() => $"({First}, {Second})";
    }

    class Program
    {
        static void Main()
        {

            var intPair = new Pair<int>(100, 200);
            var stringPair = new Pair<string>("left", "right");
            var doublePair = new Pair<double>(3.14, 2.71);

            Console.WriteLine($"intPair: {intPair}");
            Console.WriteLine($"stringPair: {stringPair}");
            Console.WriteLine($"doublePair: {doublePair}");

            intPair.First = 999;
            Console.WriteLine($"После изменения: {intPair}");
        }
    }
}


5
using System;

namespace GenericSwapDemo
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static (T, T) SwapReturn<T>(T a, T b) => (b, a);

        class SwapHelper<T>
        {
            private T _value1;
            private T _value2;

            public SwapHelper(T value1, T value2)
            {
                _value1 = value1;
                _value2 = value2;
            }

            public void Display()
            {
                Console.WriteLine($"Value1: {_value1}, Value2: {_value2}");
            }

            public void DoSwap()
            {
                Console.WriteLine($"Before: {_value1}, {_value2}");
                (_value1, _value2) = (_value2, _value1);
                Console.WriteLine($"After: {_value1}, {_value2}");
            }
        }

        static void Main()
        {

            Console.WriteLine("--- Обмен целых чисел ---");
            int a = 10, b = 20;
            Console.WriteLine($"До обмена: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"После обмена: a = {a}, b = {b}");

            Console.WriteLine("\n--- Обмен строк ---");
            string s1 = "Hello", s2 = "World";
            Console.WriteLine($"До обмена: s1 = '{s1}', s2 = '{s2}'");
            Swap(ref s1, ref s2);
            Console.WriteLine($"После обмена: s1 = '{s1}', s2 = '{s2}'");

            Console.WriteLine("\n--- Обмен вещественных чисел ---");
            double x = 3.14, y = 2.71;
            Console.WriteLine($"До обмена: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"После обмена: x = {x}, y = {y}");

            Console.WriteLine("\n--- SwapReturn (с возвращением tuple) ---");
            int n1 = 100, n2 = 200;
            (n1, n2) = SwapReturn(n1, n2);
            Console.WriteLine($"После SwapReturn: n1 = {n1}, n2 = {n2}");

            Console.WriteLine("\n--- SwapHelper класс ---");
            var helper = new SwapHelper<char>('A', 'B');
            helper.Display();
            helper.DoSwap();

            Console.WriteLine("\n--- Обмен пользовательских объектов ---");
            var person1 = new Person { Name = "Alice", Age = 25 };
            var person2 = new Person { Name = "Bob", Age = 30 };

            Console.WriteLine($"До обмена: {person1}, {person2}");
            Swap(ref person1, ref person2);
            Console.WriteLine($"После обмена: {person1}, {person2}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }
}


6
using System;
using System.Collections.Generic;

namespace CacheDemo
{
    public class Cache<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _store = new();

        public void Add(TKey key, TValue value)
        {
            _store[key] = value;
            Console.WriteLine($"Добавлено: [{key}] = {value}");
        }

        public TValue Get(TKey key)
        {
            return _store.TryGetValue(key, out var value) ? value : default;
        }

        public bool Contains(TKey key) => _store.ContainsKey(key);

        public void Remove(TKey key)
        {
            if (_store.Remove(key))
                Console.WriteLine($"Удалено: [{key}]");
        }

        public int Count => _store.Count;
    }

    class Program
    {
        static void Main()
        {

            var cache = new Cache<string, int>();

            cache.Add("apple", 5);
            cache.Add("banana", 3);
            cache.Add("orange", 8);

            Console.WriteLine($"\nGet(\"banana\"): {cache.Get("banana")}");
            Console.WriteLine($"Contains(\"grape\"): {cache.Contains("grape")}");

            cache.Remove("apple");

            Console.WriteLine($"\nCount: {cache.Count}");
        }
    }
}


7
using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T Value;
            public Node Next;
            public Node(T value) => Value = value;
        }

        private Node _head;
        private Node _tail;
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            var node = new Node(value) { Next = _head };
            _head = node;
            if (_tail == null) _tail = node;
            Count++;
            Console.WriteLine($"AddFirst: {value}");
        }

        public void AddLast(T value)
        {
            var node = new Node(value);
            if (_tail == null)
                _head = _tail = node;
            else
                _tail.Next = node;
            _tail = node;
            Count++;
            Console.WriteLine($"AddLast: {value}");
        }

        public T RemoveFirst()
        {
            if (_head == null) throw new InvalidOperationException("Список пуст");
            var value = _head.Value;
            _head = _head.Next;
            if (_head == null) _tail = null;
            Count--;
            Console.WriteLine($"RemoveFirst: {value}");
            return value;
        }

        public IEnumerable<T> GetAll()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main()
        {

            var list = new LinkedList<string>();

            list.AddFirst("First");
            list.AddLast("Last");
            list.AddFirst("NewFirst");

            Console.WriteLine("\nВсе элементы:");
            foreach (var item in list.GetAll())
                Console.WriteLine($"  {item}");

            list.RemoveFirst();

            Console.WriteLine($"\nCount: {list.Count}");
        }
    }
}


8
using System;

namespace SortDemo
{
    class Program
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            Array.Sort(array);
            Console.WriteLine("Массив отсортирован");
        }

        static void Main()
        {

            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            string[] words = { "zebra", "apple", "banana", "cherry" };

            Console.WriteLine("До сортировки (numbers):");
            Console.WriteLine(string.Join(", ", numbers));

            Sort(numbers);

            Console.WriteLine("После сортировки:");
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("\nДо сортировки (words):");
            Console.WriteLine(string.Join(", ", words));

            Sort(words);

            Console.WriteLine("После сортировки:");
            Console.WriteLine(string.Join(", ", words));
        }
    }
}


9
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepositoryDemo
{
    interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
        bool Exists(int id);
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public override string ToString() => $"#{Id} {Name} ({Email})";
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public override string ToString() => $"#{Id} {Name} - ${Price:F2}";
    }

    class Repository<T> : IRepository<T> where T : class
    {
        private List<T> _data = new List<T>();
        private int _nextId = 1;

        public virtual void Add(T item)
        {
            _data.Add(item);
            dynamic d = item;
            d.Id = _nextId++;
            Console.WriteLine($"Добавлен: {item}");
        }

        public virtual void Remove(T item)
        {
            _data.Remove(item);
            Console.WriteLine($"Удален: {item}");
        }

        public virtual T GetById(int id)
        {
            return _data.FirstOrDefault(x => ((dynamic)x).Id == id);
        }

        public virtual IEnumerable<T> GetAll() => _data;

        public virtual void Update(T item)
        {
            var index = _data.FindIndex(x => ((dynamic)x).Id == ((dynamic)item).Id);
            if (index >= 0)
            {
                _data[index] = item;
                Console.WriteLine($"Обновлен: {item}");
            }
        }

        public virtual bool Exists(int id)
        {
            return _data.Any(x => ((dynamic)x).Id == id);
        }
    }

    class UserRepository : Repository<User>
    {
        public List<User> FindByName(string name)
        {
            return GetAll().Where(u => u.Name.Contains(name)).ToList();
        }
    }

    class Program
    {
        static void Main()
        {

            var userRepo = new UserRepository();

            var user1 = new User { Name = "Alice", Email = "alice@example.com" };
            var user2 = new User { Name = "Bob", Email = "bob@example.com" };

            userRepo.Add(user1);
            userRepo.Add(user2);

            Console.WriteLine("\nВсе пользователи:");
            foreach (var user in userRepo.GetAll())
                Console.WriteLine($"  {user}");

            Console.WriteLine("\nПоиск по имени 'Alice':");
            foreach (var user in userRepo.FindByName("Alice"))
                Console.WriteLine($"  {user}");
        }
    }
}


10
using System;

namespace MatrixDemo
{
    public class Matrix<T>
    {
        private readonly T[,] _data;
        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            _data = new T[rows, columns];
        }

        public T this[int row, int col]
        {
            get => _data[row, col];
            set => _data[row, col] = value;
        }

        public void Fill(T value)
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    _data[i, j] = value;
        }

        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    Console.Write($"{_data[i, j],8}");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {

            var intMatrix = new Matrix<int>(3, 4);
            intMatrix.Fill(0);
            intMatrix[0, 0] = 1;
            intMatrix[1, 2] = 5;

            Console.WriteLine("Матрица int:");
            intMatrix.Print();

            var stringMatrix = new Matrix<string>(2, 2);
            stringMatrix[0, 0] = "A"; stringMatrix[0, 1] = "B";
            stringMatrix[1, 0] = "C"; stringMatrix[1, 1] = "D";

            Console.WriteLine("\nМатрица string:");
            stringMatrix.Print();
        }
    }
}


11
using System;

namespace MatrixDemo
{
    public class Matrix<T>
    {
        private readonly T[,] _data;
        public int Rows { get; }
        public int Columns { get; }

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0) throw new ArgumentException("Размеры должны быть положительными");
            Rows = rows;
            Columns = columns;
            _data = new T[rows, columns];
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Columns)
                    throw new IndexOutOfRangeException();
                return _data[row, col];
            }
            set
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Columns)
                    throw new IndexOutOfRangeException();
                _data[row, col] = value;
            }
        }

        public void Fill(T value)
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    _data[i, j] = value;
        }

        public Matrix<T> Clone()
        {
            var clone = new Matrix<T>(Rows, Columns);
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    clone[i, j] = _data[i, j];
            return clone;
        }

        public void Print()
        {
            Console.WriteLine($"Матрица {Rows}x{Columns}:");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    Console.Write($"{_data[i, j],8}");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {

            var matrix = new Matrix<int>(3, 4);
            matrix.Fill(0);
            matrix[0, 0] = 1; matrix[0, 1] = 2;
            matrix[1, 2] = 5; matrix[2, 3] = 9;

            Console.WriteLine("Оригинальная матрица:");
            matrix.Print();

            var clone = matrix.Clone();
            clone[0, 0] = 99;

            Console.WriteLine("\nКлон после изменения:");
            clone.Print();

            Console.WriteLine("\nОригинал (не изменился):");
            matrix.Print();
        }
    }
}


12
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConvertAllDemo
{
    class Program
    {
        public static IEnumerable<TResult> ConvertAll<TSource, TResult>(
            IEnumerable<TSource> source,
            Func<TSource, TResult> converter)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (converter == null) throw new ArgumentNullException(nameof(converter));

            foreach (var item in source)
                yield return converter(item);
        }

        static void Main()
        {

            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var strings = new List<string> { "apple", "banana", "cherry" };

            var squared = ConvertAll(numbers, x => x * x);
            var lengths = ConvertAll(strings, s => s.Length);
            var upper = ConvertAll(strings, s => s.ToUpper());

            Console.WriteLine("Числа -> квадраты:");
            Console.WriteLine(string.Join(", ", squared));

            Console.WriteLine("\nСтроки -> длины:");
            Console.WriteLine(string.Join(", ", lengths));

            Console.WriteLine("\nСтроки -> в верхний регистр:");
            Console.WriteLine(string.Join(", ", upper));

            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 }
            };

            var names = ConvertAll(people, p => p.Name);
            Console.WriteLine("\nОбъекты -> имена:");
            Console.WriteLine(string.Join(", ", names));
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}


13
using System;
using System.Collections.Generic;

namespace HistoryDemo
{
    public class History<T>
    {
        private readonly List<T> _operations = new();
        private readonly int _capacity;

        public History(int capacity = 100)
        {
            _capacity = capacity > 0 ? capacity : throw new ArgumentException("Ёмкость должна быть положительной");
        }

        public void Add(T operation)
        {
            if (operation == null) throw new ArgumentNullException(nameof(operation));
            _operations.Add(operation);
            Console.WriteLine($"Добавлена операция: {operation}");

            if (_operations.Count > _capacity)
            {
                _operations.RemoveAt(0);
                Console.WriteLine("Удалена самая старая операция (превышена ёмкость)");
            }
        }

        public IReadOnlyList<T> GetAll() => _operations.AsReadOnly();

        public void Clear()
        {
            _operations.Clear();
            Console.WriteLine("История очищена");
        }

        public int Count => _operations.Count;
        public int Capacity => _capacity;
    }

    class Program
    {
        static void Main()
        {

            var history = new History<string>(3);

            history.Add("Создан файл");
            history.Add("Изменён текст");
            history.Add("Сохранён документ");
            history.Add("Удалена строка");

            Console.WriteLine($"\nВсего операций: {history.Count}");
            Console.WriteLine("История:");
            foreach (var op in history.GetAll())
                Console.WriteLine($"  - {op}");

            history.Clear();
            Console.WriteLine($"\nПосле очистки: {history.Count} операций");
        }
    }
}


14
using System;
using System.Linq;

namespace FilterDemo
{
    class Program
    {
        public static T[] Filter<T>(T[] source, Func<T, bool> predicate)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            return source.Where(predicate).ToArray();
        }

        static void Main()
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] words = { "cat", "dog", "elephant", "ant", "giraffe" };

            var evens = Filter(numbers, x => x % 2 == 0);
            var odds = Filter(numbers, x => x % 2 != 0);
            var longWords = Filter(words, w => w.Length > 3);

            Console.WriteLine("Чётные числа:");
            Console.WriteLine(string.Join(", ", evens));

            Console.WriteLine("\nНечётные числа:");
            Console.WriteLine(string.Join(", ", odds));

            Console.WriteLine("\nСлова длиннее 3 символов:");
            Console.WriteLine(string.Join(", ", longWords));

            var people = new[]
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 17 },
                new Person { Name = "Charlie", Age = 30 }
            };

            var adults = Filter(people, p => p.Age >= 18);
            Console.WriteLine("\nВзрослые:");
            foreach (var p in adults)
                Console.WriteLine($"  {p.Name} ({p.Age})");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}


15
using System;
using System.Collections.Generic;

namespace GraphDemo
{
    public class Graph<T>
    {
        private readonly Dictionary<T, List<T>> _adjacency = new();
        private readonly bool _isDirected;

        public Graph(bool isDirected = false)
        {
            _isDirected = isDirected;
        }

        public void AddVertex(T vertex)
        {
            if (!_adjacency.ContainsKey(vertex))
            {
                _adjacency[vertex] = new List<T>();
                Console.WriteLine($"Добавлена вершина: {vertex}");
            }
        }

        public void AddEdge(T from, T to)
        {
            AddVertex(from);
            AddVertex(to);

            _adjacency[from].Add(to);
            if (!_isDirected)
                _adjacency[to].Add(from);

            Console.WriteLine($"Добавлено ребро: {from} -> {to}" + (_isDirected ? "" : " (двунаправленное)"));
        }

        public IReadOnlyList<T> GetNeighbors(T vertex)
        {
            return _adjacency.TryGetValue(vertex, out var neighbors) ? neighbors : new List<T>();
        }

        public IReadOnlyDictionary<T, List<T>> AdjacencyList => _adjacency;

        public IEnumerable<T> DFS(T start)
        {
            var visited = new HashSet<T>();
            var stack = new Stack<T>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var vertex = stack.Pop();
                if (visited.Contains(vertex)) continue;

                visited.Add(vertex);
                yield return vertex;

                foreach (var neighbor in GetNeighbors(vertex))
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
            }
        }
    }

    class Program
    {
        static void Main()
        {

            var graph = new Graph<string>();

            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "D");
            graph.AddEdge("C", "D");
            graph.AddEdge("D", "E");

            Console.WriteLine("\nСоседи вершины B:");
            foreach (var neighbor in graph.GetNeighbors("B"))
                Console.WriteLine($"  B -> {neighbor}");

            Console.WriteLine("\nОбход DFS от A:");
            foreach (var vertex in graph.DFS("A"))
                Console.WriteLine($"  {vertex}");
        }
    }
}


16
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxDemo
{
    class Program
    {
        public static (T Min, T Max) MinMax<T>(IEnumerable<T> source) where T : IComparable<T>
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            using var enumerator = source.GetEnumerator();
            if (!enumerator.MoveNext()) throw new InvalidOperationException("Последовательность пуста");

            T min = enumerator.Current;
            T max = enumerator.Current;

            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                if (current.CompareTo(min) < 0) min = current;
                if (current.CompareTo(max) > 0) max = current;
            }

            return (min, max);
        }

        static void Main()
        {

            var numbers = new[] { 5, 2, 8, 1, 9, 3 };
            var words = new[] { "zebra", "apple", "banana", "cherry" };
            var dates = new[]
            {
                new DateTime(2023, 1, 1),
                new DateTime(2023, 6, 15),
                new DateTime(2023, 12, 25)
            };

            var (minNum, maxNum) = MinMax(numbers);
            Console.WriteLine($"Числа: Min = {minNum}, Max = {maxNum}");

            var (minWord, maxWord) = MinMax(words);
            Console.WriteLine($"Слова: Min = {minWord}, Max = {maxWord}");

            var (minDate, maxDate) = MinMax(dates);
            Console.WriteLine($"Даты: Min = {minDate:d}, Max = {maxDate:d}");

            var people = new[]
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 20 }
            };

            var (youngest, oldest) = MinMax(people.Select(p => p.Age));
            Console.WriteLine($"Возраст: Min = {youngest}, Max = {oldest}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}


17
using System;

namespace ContainerDemo
{
    public class Container<T> where T : class, new()
    {
        public T Value { get; private set; } = new T();

        public void Set(T value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
            Console.WriteLine($"Установлено значение: {value}");
        }

        public void Reset()
        {
            Value = new T();
            Console.WriteLine("Значение сброшено на новое по умолчанию");
        }

        public T Get() => Value;
    }

    class Config
    {
        public string ConnectionString { get; set; } = "Server=localhost";
        public int Timeout { get; set; } = 30;
        public override string ToString() => $"Conn: {ConnectionString}, Timeout: {Timeout}";
    }

    class Program
    {
        static void Main()
        {

            var container = new Container<Config>();
            Console.WriteLine($"По умолчанию: {container.Get()}");

            var custom = new Config { ConnectionString = "Server=prod", Timeout = 60 };
            container.Set(custom);
            Console.WriteLine($"После установки: {container.Get()}");

            container.Reset();
            Console.WriteLine($"После сброса: {container.Get()}");
        }
    }
}


18
using System;
using System.Collections.Generic;

namespace TreeTraversalDemo
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; } = new();

        public TreeNode(T value) => Value = value;

        public void AddChild(TreeNode<T> child) => Children.Add(child);
    }

    class Program
    {
        public static IEnumerable<T> Traverse<T>(TreeNode<T> root, Func<TreeNode<T>, IEnumerable<TreeNode<T>>> childrenSelector)
        {
            if (root == null) throw new ArgumentNullException(nameof(root));
            if (childrenSelector == null) throw new ArgumentNullException(nameof(childrenSelector));

            yield return root.Value;

            foreach (var child in childrenSelector(root))
                foreach (var descendant in Traverse(child, childrenSelector))
                    yield return descendant;
        }

        static void Main()
        {

            var root = new TreeNode<string>("Root");
            var child1 = new TreeNode<string>("Child1");
            var child2 = new TreeNode<string>("Child2");
            var grand1 = new TreeNode<string>("Grandchild1");
            var grand2 = new TreeNode<string>("Grandchild2");

            root.AddChild(child1);
            root.AddChild(child2);
            child1.AddChild(grand1);
            child2.AddChild(grand2);

            Console.WriteLine("Обход дерева (DFS):");
            foreach (var value in Traverse(root, node => node.Children))
                Console.WriteLine($"  {value}");

            Console.WriteLine("\nОбход в ширину (BFS):");
            var queue = new Queue<TreeNode<string>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.WriteLine($"  {node.Value}");
                foreach (var child in node.Children)
                    queue.Enqueue(child);
            }
        }
    }
}


19
using System;

namespace ComparerDemo
{
    public interface IComparer<T>
    {
        int Compare(T x, T y);
    }

    public class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.Length.CompareTo(y.Length);
        }
    }

    public class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.Age.CompareTo(y.Age);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }

    class Program
    {
        static void Main()
        {

            var words = new[] { "cat", "apple", "banana", "hi" };
            Array.Sort(words, new StringLengthComparer());

            Console.WriteLine("Слова по длине:");
            foreach (var word in words)
                Console.WriteLine($"  {word} ({word.Length})");

            var people = new[]
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 20 }
            };

            Array.Sort(people, new PersonAgeComparer());

            Console.WriteLine("\nЛюди по возрасту:");
            foreach (var person in people)
                Console.WriteLine($"  {person}");
        }
    }
}


20
using System;
using System.Collections.Generic;

namespace EventDispatcherDemo
{
    public class EventDispatcher<T>
    {
        private readonly List<Action<T>> _handlers = new();

        public void Subscribe(Action<T> handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            _handlers.Add(handler);
            Console.WriteLine($"Подписчик добавлен (всего: {_handlers.Count})");
        }

        public void Unsubscribe(Action<T> handler)
        {
            if (handler != null && _handlers.Remove(handler))
                Console.WriteLine($"Подписчик удалён (осталось: {_handlers.Count})");
        }

        public void Dispatch(T eventData)
        {
            Console.WriteLine($"Событие: {eventData}");
            foreach (var handler in _handlers)
                handler(eventData);
        }

        public int SubscriberCount => _handlers.Count;
    }

    class Program
    {
        static void LogMessage(string message) => Console.WriteLine($"[LOG] {message}");
        static void SaveToFile(string message) => Console.WriteLine($"[FILE] Сохранено: {message}");
        static void SendEmail(string message) => Console.WriteLine($"[EMAIL] Отправлено: {message}");

        static void Main()
        {

            var dispatcher = new EventDispatcher<string>();

            dispatcher.Subscribe(LogMessage);
            dispatcher.Subscribe(SaveToFile);

            dispatcher.Dispatch("Пользователь вошёл в систему");

            var emailHandler = SendEmail;
            dispatcher.Subscribe(emailHandler);

            dispatcher.Dispatch("Критическая ошибка!");

            dispatcher.Unsubscribe(emailHandler);
            dispatcher.Dispatch("Система восстановлена");
        }
    }
}


21
using System;

namespace CloneDemo
{
    class Program
    {
        public static TResult Clone<TSource, TResult>(TSource source, Func<TSource, TResult> cloner)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (cloner == null) throw new ArgumentNullException(nameof(cloner));
            return cloner(source);
        }

        public static T DeepClone<T>(T source) where T : class, new()
        {
            return Clone(source, src => new T());
        }

        static void Main()
        {

            var person = new Person { Name = "Alice", Age = 25 };
            var cloned = Clone(person, p => new Person { Name = p.Name, Age = p.Age });

            Console.WriteLine($"Оригинал: {person}");
            Console.WriteLine($"Клон: {cloned}");

            cloned.Name = "Bob";
            Console.WriteLine($"После изменения клона: {cloned}");
            Console.WriteLine($"Оригинал не изменился: {person}");

            var config = new Config { Timeout = 30 };
            var defaultConfig = DeepClone(config);
            Console.WriteLine($"\nГлубокое клонирование: {defaultConfig.Timeout}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} ({Age})";
    }

    class Config
    {
        public int Timeout { get; set; }
    }
}


22
using System;

namespace ConverterDemo
{
    public class Converter<TIn, TOut>
    {
        private readonly Func<TIn, TOut> _conversion;

        public Converter(Func<TIn, TOut> conversion)
        {
            _conversion = conversion ?? throw new ArgumentNullException(nameof(conversion));
        }

        public TOut Convert(TIn input)
        {
            Console.WriteLine($"Конвертация: {input} -> {_conversion(input)}");
            return _conversion(input);
        }

        public IEnumerable<TOut> ConvertMany(IEnumerable<TIn> inputs)
        {
            if (inputs == null) yield break;
            foreach (var input in inputs)
                yield return Convert(input);
        }
    }

    class Program
    {
        static void Main()
        {

            var intToString = new Converter<int, string>(x => x.ToString("D3"));
            Console.WriteLine(intToString.Convert(42));

            var stringToInt = new Converter<string, int>(int.Parse);
            Console.WriteLine(stringToInt.Convert("123"));

            var celsiusToFahrenheit = new Converter<double, double>(c => c * 9 / 5 + 32);
            var temps = new[] { 0.0, 20.0, 100.0 };
            foreach (var f in celsiusToFahrenheit.ConvertMany(temps))
                Console.WriteLine($"{f:F1}°F");

            var personToName = new Converter<Person, string>(p => $"{p.Name} ({p.Age})");
            var people = new[]
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 }
            };
            foreach (var name in personToName.ConvertMany(people))
                Console.WriteLine(name);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}


23
using System;

namespace ValidationDemo
{
    class Program
    {
        public static bool Validate<T>(T value, Func<T, bool> validator, string errorMessage = null)
        {
            if (validator == null) throw new ArgumentNullException(nameof(validator));
            bool isValid = validator(value);
            Console.WriteLine($"{(isValid ? "Успешно" : "Ошибка")}: {value} — {(isValid ? "валидно" : errorMessage ?? "невалидно")}");
            return isValid;
        }

        static void Main()
        {

            Validate(42, x => x > 0, "Число должно быть положительным");
            Validate(-5, x => x > 0, "Число должно быть положительным");

            Validate("hello", s => !string.IsNullOrWhiteSpace(s), "Строка не должна быть пустой");
            Validate("", s => !string.IsNullOrWhiteSpace(s), "Строка не должна быть пустой");

            Validate("user@example.com", email => email.Contains("@") && email.Contains("."), "Неверный email");
            Validate("invalid", email => email.Contains("@") && email.Contains("."), "Неверный email");

            var person = new Person { Age = 150 };
            Validate(person.Age, age => age >= 0 && age <= 130, "Возраст должен быть в диапазоне 0-130");
        }
    }

    class Person
    {
        public int Age { get; set; }
    }
}


24
using System;

namespace HandlerDemo
{
    public class Handler<TRequest, TResponse>
    {
        private readonly Func<TRequest, TResponse> _handler;

        public Handler(Func<TRequest, TResponse> handler)
        {
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        public TResponse Handle(TRequest request)
        {
            Console.WriteLine($"Обработка запроса: {request}");
            var response = _handler(request);
            Console.WriteLine($"Ответ: {response}");
            return response;
        }
    }

    class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public override string ToString() => $"Login: {Username}";
    }

    class LoginResponse
    {
        public bool Success { get; set; }
        public string Token { get; set; }
        public override string ToString() => Success ? $"Успех: {Token}" : "Ошибка";
    }

    class Program
    {
        static void Main()
        {

            var loginHandler = new Handler<LoginRequest, LoginResponse>(req =>
            {
                bool success = req.Username == "admin" && req.Password == "123";
                return new LoginResponse
                {
                    Success = success,
                    Token = success ? "abc123" : null
                };
            });

            loginHandler.Handle(new LoginRequest { Username = "admin", Password = "123" });
            loginHandler.Handle(new LoginRequest { Username = "user", Password = "wrong" });

            var calculator = new Handler<double, double>(x => x * x);
            Console.WriteLine($"\nКалькулятор: 5^2 = {calculator.Handle(5)}");
        }
    }
}


25
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupByTypeDemo
{
    class Program
    {
        public static Dictionary<Type, List<object>> GroupByType(IEnumerable<object> items)
        {
            if (items == null) return new Dictionary<Type, List<object>>();

            return items
                .GroupBy(item => item?.GetType() ?? typeof(object))
                .ToDictionary(
                    g => g.Key,
                    g => g.ToList());
        }

        static void Main()
        {

            var mixed = new object[]
            {
                42, "hello", 3.14, "world", 100, new Person { Name = "Alice" },
                true, 5.5, new Person { Name = "Bob" }, false
            };

            var grouped = GroupByType(mixed);

            foreach (var kvp in grouped)
            {
                Console.WriteLine($"Тип: {kvp.Key.Name} ({kvp.Value.Count} шт.)");
                foreach (var item in kvp.Value.Take(3))
                    Console.WriteLine($"  - {item}");
                if (kvp.Value.Count > 3)
                    Console.WriteLine($"  ... и ещё {kvp.Value.Count - 3}");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public override string ToString() => $"Person: {Name}";
    }
}


26
using System;
using System.Collections.Generic;

namespace PipelineDemo
{
    public class Pipeline<T>
    {
        private readonly List<Func<T, T>> _steps = new();

        public Pipeline<T> AddStep(Func<T, T> step)
        {
            if (step == null) throw new ArgumentNullException(nameof(step));
            _steps.Add(step);
            Console.WriteLine($"Добавлен шаг: {step.Method.Name}");
            return this;
        }

        public T Execute(T input)
        {
            Console.WriteLine($"Начальное значение: {input}");
            var result = input;
            foreach (var step in _steps)
            {
                result = step(result);
                Console.WriteLine($"После шага: {result}");
            }
            return result;
        }
    }

    class Program
    {
        static string TrimAndUpper(string s) => s.Trim().ToUpper();
        static string AddPrefix(string s) => "RESULT: " + s;
        static string ReplaceSpaces(string s) => s.Replace(" ", "_");

        static void Main()
        {

            var pipeline = new Pipeline<string>()
                .AddStep(TrimAndUpper)
                .AddStep(ReplaceSpaces)
                .AddStep(AddPrefix);

            var result = pipeline.Execute("  hello world  ");
            Console.WriteLine($"\nФинальный результат: {result}");

            var math = new Pipeline<int>()
                .AddStep(x => x * 2)
                .AddStep(x => x + 10)
                .AddStep(x => x * x);

            Console.WriteLine($"\nМатематический пайплайн: 5 -> {math.Execute(5)}");
        }
    }
}


26
using System;

namespace CovariantProducerDemo
{
    interface IProducer<out T>
    {
        T Produce();
    }

    class AnimalProducer : IProducer<Animal>
    {
        public Animal Produce() => new Animal { Name = "Generic Animal" };
    }

    class DogProducer : IProducer<Dog>
    {
        public Dog Produce() => new Dog { Name = "Rex" };
    }

    class PuppyProducer : IProducer<Puppy>
    {
        public Puppy Produce() => new Puppy { Name = "Buddy" };
    }

    class Animal { public string Name { get; set; } public virtual void Speak() => Console.WriteLine("..."); }
    class Dog : Animal { public override void Speak() => Console.WriteLine("Woof!"); }
    class Puppy : Dog { public override void Speak() => Console.WriteLine("Yip!"); }

    class Program
    {
        static void Main()
        {

            IProducer<Dog> dogProducer = new DogProducer();
            IProducer<Puppy> puppyProducer = new PuppyProducer();

            IProducer<Animal> animalFromDog = dogProducer;
            IProducer<Animal> animalFromPuppy = puppyProducer;

            Console.WriteLine("Производство животных:");
            var animal1 = animalFromDog.Produce();
            var animal2 = animalFromPuppy.Produce();

            animal1.Speak();
            animal2.Speak();
        }
    }
}


27
using System;

namespace ContravariantConsumerDemo
{
    interface IConsumer<in T>
    {
        void Consume(T item);
    }

    class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal animal)
        {
            Console.WriteLine($"[Animal] Потреблено: {animal.Name}");
        }
    }

    class DogConsumer : IConsumer<Dog>
    {
        public void Consume(Dog dog)
        {
            Console.WriteLine($"[Dog] Потреблено: {dog.Name}");
        }
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Puppy : Dog { }

    class Program
    {
        static void Main()
        {

            IConsumer<Animal> animalConsumer = new AnimalConsumer();

            IConsumer<Dog> dogConsumer = animalConsumer;
            IConsumer<Puppy> puppyConsumer = animalConsumer;

            Console.WriteLine("Потребление через контрвариантность:");
            dogConsumer.Consume(new Dog { Name = "Rex" });
            puppyConsumer.Consume(new Puppy { Name = "Buddy" });
        }
    }
}


28
using System;
using System.Collections.Generic;

namespace IEnumerableCovarianceDemo
{
    class Animal { public string Name { get; set; } public virtual void Speak() => Console.WriteLine("..."); }
    class Dog : Animal { public override void Speak() => Console.WriteLine("Woof!"); }
    class Cat : Animal { public override void Speak() => Console.WriteLine("Meow!"); }

    class Program
    {
        static void Main()
        {

            var dogs = new List<Dog>
            {
                new Dog { Name = "Rex" },
                new Dog { Name = "Max" }
            };

            var cats = new List<Cat>
            {
                new Cat { Name = "Whiskers" }
            };

            IEnumerable<Animal> animalsFromDogs = dogs;
            IEnumerable<Animal> animalsFromCats = cats;

            Console.WriteLine("Животные из собак:");
            foreach (var animal in animalsFromDogs)
                animal.Speak();

            Console.WriteLine("\nЖивотные из кошек:");
            foreach (var animal in animalsFromCats)
                animal.Speak();
        }
    }
}


29
using System;

namespace ActionContravarianceDemo
{
    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Puppy : Dog { }

    class Program
    {
        static void HandleAnimal(Animal animal)
        {
            Console.WriteLine($"Обрабатываю животное: {animal.Name}");
        }

        static void Main()
        {

            Action<Animal> animalAction = HandleAnimal;

            Action<Dog> dogAction = animalAction;
            Action<Puppy> puppyAction = animalAction;

            dogAction(new Dog { Name = "Rex" });
            puppyAction(new Puppy { Name = "Buddy" });
        }
    }
}


30
using System;

namespace FuncCovarianceDemo
{
    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Puppy : Dog { }

    class Program
    {
        static Dog CreateDog() => new Dog { Name = "Buddy" };
        static Puppy CreatePuppy() => new Puppy { Name = "Tiny" };

        static void Main()
        {

            Func<Dog> dogFunc = CreateDog;
            Func<Puppy> puppyFunc = CreatePuppy;

            Func<Animal> animalFromDog = dogFunc;
            Func<Animal> animalFromPuppy = puppyFunc;

            Console.WriteLine("Создание через ковариантность:");
            Console.WriteLine(animalFromDog().Name);
            Console.WriteLine(animalFromPuppy().Name);
        }
    }
}


31
using System;
using System.Collections.Generic;

namespace VarianceHierarchyDemo
{
    class Animal
    {
        public string Name { get; set; }
        public virtual void MakeSound() => Console.WriteLine("Звук животного");
        public override string ToString() => $"{GetType().Name}: {Name}";
    }

    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Гав! Гав!");
    }

    class Puppy : Dog
    {
        public override void MakeSound() => Console.WriteLine("Пищик! Пищик!");
    }

    interface IProducer<out T>
    {
        T Produce();
    }

    interface IConsumer<in T>
    {
        void Consume(T item);
    }

    class AnimalProducer : IProducer<Animal>
    {
        public Animal Produce() => new Animal { Name = "Generic Animal" };
    }

    class DogProducer : IProducer<Dog>
    {
        public Dog Produce() => new Dog { Name = "Buddy" };
    }

    class PuppyProducer : IProducer<Puppy>
    {
        public Puppy Produce() => new Puppy { Name = "Max" };
    }

    class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal animal)
        {
            Console.WriteLine($"Consuming: {animal}");
            animal.MakeSound();
        }
    }

    class Program
    {
        static void Main()
        {

            Console.WriteLine("--- Иерархия ---");
            Animal a = new Animal { Name = "A" };
            Dog d = new Dog { Name = "Rex" };
            Puppy p = new Puppy { Name = "Buddy" };
            a.MakeSound(); d.MakeSound(); p.MakeSound();

            Console.WriteLine("\n--- Ковариантность IProducer ---");
            IProducer<Animal> prod1 = new DogProducer();
            IProducer<Animal> prod2 = new PuppyProducer();
            prod1.Produce().MakeSound();
            prod2.Produce().MakeSound();

            Console.WriteLine("\n--- Контрвариантность IConsumer ---");
            IConsumer<Dog> cons1 = new AnimalConsumer();
            IConsumer<Puppy> cons2 = new AnimalConsumer();
            cons1.Consume(new Dog { Name = "BigDog" });
            cons2.Consume(new Puppy { Name = "SmallPuppy" });
        }
    }
}


32
using System;

namespace VarianceErrorDemo
{
    interface IBad<out T>
    {
        void Set(T value);
    }

    interface IBad2<in T>
    {
        T Get();
    }

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Эти интерфейсы НЕ скомпилируются:");
            Console.WriteLine("• out T в методе с входным параметром");
            Console.WriteLine("• in T в методе с возвращаемым значением");
            Console.WriteLine("• Использование вариантных типов в полях/свойствах с set");
        }
    }
}


33
using System;
using System.Collections.Generic;

namespace CovariantRepositoryDemo
{
    interface IReadOnlyRepository<out T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }

    class Shape { public string Name { get; set; } public virtual double Area => 0; }
    class Circle : Shape { public double Radius { get; set; } public override double Area => Math.PI * Radius * Radius; }
    class Square : Shape { public double Side { get; set; } public override double Area => Side * Side; }

    class ShapeRepository : IReadOnlyRepository<Shape>
    {
        private readonly List<Shape> _data = new()
        {
            new Circle { Name = "Circle1", Radius = 5 },
            new Square { Name = "Square1", Side = 4 }
        };

        public Shape GetById(int id) => id < _data.Count ? _data[id] : null;
        public IEnumerable<Shape> GetAll() => _data;
    }

    class CircleRepository : IReadOnlyRepository<Circle>
    {
        private readonly List<Circle> _data = new()
        {
            new Circle { Name = "C1", Radius = 3 },
            new Circle { Name = "C2", Radius = 7 }
        };

        public Circle GetById(int id) => id < _data.Count ? _data[id] : null;
        public IEnumerable<Circle> GetAll() => _data;
    }

    class Program
    {
        static void Display<T>(IReadOnlyRepository<T> repo) where T : class
        {
            Console.WriteLine($"Репозиторий {typeof(T).Name}:");
            foreach (var item in repo.GetAll())
                Console.WriteLine($"  {item.Name} (Area: {item.Area:F2})");
        }

        static void Main()
        {

            IReadOnlyRepository<Circle> circleRepo = new CircleRepository();
            IReadOnlyRepository<Shape> shapeRepo = new ShapeRepository();

            IReadOnlyRepository<Shape> asShape = circleRepo;

            Display(shapeRepo);
            Console.WriteLine();
            Display(asShape);
        }
    }
}


34
using System;

namespace ContravariantComparerDemo
{
    interface IComparer<in T>
    {
        int Compare(T x, T y);
    }

    class AnimalComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Puppy : Dog { }

    class Program
    {
        static void Main()
        {

            IComparer<Animal> animalComparer = new AnimalComparer();

            IComparer<Dog> dogComparer = animalComparer;
            IComparer<Puppy> puppyComparer = animalComparer;

            var dog1 = new Dog { Name = "Rex" };
            var dog2 = new Dog { Name = "Max" };

            Console.WriteLine($"dog1 vs dog2: {dogComparer.Compare(dog1, dog2)}");
            Console.WriteLine($"puppy vs dog: {puppyComparer.Compare(new Puppy { Name = "A" }, dog1)}");
        }
    }
}


35
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionCovarianceDemo
{
    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Cat : Animal { }

    class Program
    {
        static void Main()
        {

            Dog[] dogs = { new Dog { Name = "Rex" }, new Dog { Name = "Max" } };
            Cat[] cats = { new Cat { Name = "Whiskers" } };

            Animal[] animalsFromDogs = dogs;
            Animal[] animalsFromCats = cats;

            Console.WriteLine("Животные из массива собак:");
            foreach (var a in animalsFromDogs)
                Console.WriteLine($"  {a.Name}");

            IEnumerable<Animal> safeFromDogs = dogs;
            IEnumerable<Animal> safeFromCats = cats;

            Console.WriteLine("\nБезопасно через IEnumerable:");
            safeFromDogs.Concat(safeFromCats).ToList().ForEach(a => Console.WriteLine($"  {a.Name}"));
        }
    }
}


36
using System;

namespace VariantGenericClassDemo
{
    class ProducerConsumer<out TOut, in TIn>
    {
        private readonly Func<TIn, TOut> _func;

        public ProducerConsumer(Func<TIn, TOut> func)
        {
            _func = func ?? throw new ArgumentNullException();
        }

        public TOut Produce(TIn input) => _func(input);
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Puppy : Dog { }

    class Program
    {
        static void Main()
        {

            ProducerConsumer<Dog, Animal> dogFromAnimal = new(d => new Dog { Name = d.Name + " Jr." });

            ProducerConsumer<Animal, Puppy> animalFromPuppy = dogFromAnimal;

            var result = animalFromPuppy.Produce(new Puppy { Name = "Tiny" });
            Console.WriteLine($"Результат: {result.Name}");
        }
    }
}


37
using System;

namespace CovariantFactoryDemo
{
    interface IFactory<out T>
    {
        T Create();
    }

    class AnimalFactory : IFactory<Animal>
    {
        public Animal Create() => new Animal { Name = "New Animal" };
    }

    class DogFactory : IFactory<Dog>
    {
        public Dog Create() => new Dog { Name = "New Dog" };
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }

    class Program
    {
        static void Main()
        {

            IFactory<Dog> dogFactory = new DogFactory();

            IFactory<Animal> animalFactory = dogFactory;

            var animal = animalFactory.Create();
            Console.WriteLine($"Создано: {animal.Name} ({animal.GetType().Name})");
        }
    }
}


38
using System;

namespace ContravariantEventHandlerDemo
{
    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Puppy : Dog { }

    class EventPublisher
    {
        public event EventHandler<Animal> AnimalEvent;

        public void Raise(Animal animal)
        {
            AnimalEvent?.Invoke(this, new EventArgs<Animal>(animal));
        }
    }

    class EventArgs<T> : EventArgs
    {
        public T Data { get; }
        public EventArgs(T data) => Data = data;
    }

    class Program
    {
        static void HandleAnimal(object sender, EventArgs<Animal> e)
        {
            Console.WriteLine($"Обработано: {e.Data.Name}");
        }

        static void Main()
        {

            var publisher = new EventPublisher();
            publisher.AnimalEvent += HandleAnimal;

            EventHandler<Dog> dogHandler = (s, e) => publisher.Raise(e.Data);
            EventHandler<Puppy> puppyHandler = (s, e) => publisher.Raise(e.Data);

            dogHandler(null, new EventArgs<Dog>(new Dog { Name = "Rex" }));
        }
    }
}


39
using System;
using System.Collections.Generic;

namespace SafeVarianceCastingDemo
{
    interface IReadOnlyList<out T>
    {
        T this[int index] { get; }
        int Count { get; }
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }

    class AnimalList : IReadOnlyList<Animal>
    {
        private readonly List<Animal> _list;
        public AnimalList(List<Animal> list) => _list = list;
        public Animal this[int index] => _list[index];
        public int Count => _list.Count;
    }

    class Program
    {
        static void Main()
        {

            var dogs = new List<Dog> { new Dog { Name = "Rex" } };
            IReadOnlyList<Dog> dogList = new List<Dog>(dogs) as IReadOnlyList<Dog>;

            IReadOnlyList<Animal> animalList = dogList;

            Console.WriteLine($"Доступ: {animalList[0].Name}");
        }
    }
}


40
using System;
using System.Collections.Generic;

namespace CovariantRepositoryDemo2
{
    interface IRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

    class Product { public int Id { get; set; } public string Name { get; set; } }
    class Book : Product { public string Author { get; set; } }

    class ProductRepository : IRepository<Product>
    {
        private readonly Dictionary<int, Product> _data = new()
        {
            [1] = new Product { Id = 1, Name = "Laptop" },
            [2] = new Book { Id = 2, Name = "C# Book", Author = "Jon" }
        };

        public Product GetById(int id) => _data.GetValueOrDefault(id);
        public IEnumerable<Product> GetAll() => _data.Values;
    }

    class Program
    {
        static void Main()
        {

            IRepository<Book> bookRepo = null;
            IRepository<Product> productRepo = new ProductRepository();

            IRepository<Product> asProduct = bookRepo ?? productRepo;

            foreach (var p in asProduct.GetAll())
                Console.WriteLine($"  {p.Name}");
        }
    }
}


41
using System;

namespace ContravariantValidatorDemo
{
    interface IValidator<in T>
    {
        bool Validate(T obj);
    }

    class AnimalValidator : IValidator<Animal>
    {
        public bool Validate(Animal obj) => !string.IsNullOrEmpty(obj?.Name);
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }

    class Program
    {
        static void Main()
        {

            IValidator<Animal> validator = new AnimalValidator();

            IValidator<Dog> dogValidator = validator;

            Console.WriteLine(dogValidator.Validate(new Dog { Name = "Rex" }));
            Console.WriteLine(dogValidator.Validate(new Dog()));
        }
    }
}


42
using System;
using System.Collections.Generic;

namespace CombinedVarianceDemo
{
    interface ITransformer<in TIn, out TOut>
    {
        TOut Transform(TIn input);
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Puppy : Dog { }
    class PetInfo { public string Info { get; set; } }

    class DogToPetInfo : ITransformer<Dog, PetInfo>
    {
        public PetInfo Transform(Dog dog) => new PetInfo { Info = $"Dog: {dog.Name}" };
    }

    class Program
    {
        static void Main()
        {

            ITransformer<Dog, PetInfo> specific = new DogToPetInfo();

            ITransformer<Animal, PetInfo> inCovariant = specific;
            ITransformer<Dog, object> outCovariant = specific;
            ITransformer<Puppy, object> both = specific;

            var result = both.Transform(new Puppy { Name = "Tiny" });
            Console.WriteLine(((PetInfo)result).Info);
        }
    }
}


43
using System;

namespace VarianceConstraintDemo
{
    class Animal { public string Name { get; set; } }
    class Dog : Animal { }

    class Program
    {
        static void Process<in T>(Action<T> action, T item) where T : Animal
        {
            action(item);
        }

        static void Main()
        {

            Action<Animal> animalAction = a => Console.WriteLine(a.Name);
            Action<Dog> dogAction = d => Console.WriteLine($"Dog: {d.Name}");

            Process(animalAction, new Dog { Name = "Rex" });
            Process(dogAction, new Dog { Name = "Max" });
        }
    }
}


44
using System;
using System.Collections.Generic;

namespace CovariantIteratorDemo
{
    interface IIterator<out T>
    {
        bool MoveNext();
        T Current { get; }
    }

    class AnimalIterator : IIterator<Animal>
    {
        private readonly Animal[] _animals;
        private int _pos = -1;
        public AnimalIterator(Animal[] animals) => _animals = animals;
        public bool MoveNext() => ++_pos < _animals.Length;
        public Animal Current => _animals[_pos];
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }

    class Program
    {
        static void Main()
        {

            var dogs = new Dog[] { new Dog { Name = "Rex" } };
            IIterator<Dog> dogIterator = new AnimalIterator(dogs) as IIterator<Dog>;

            IIterator<Animal> animalIterator = dogIterator;

            while (animalIterator.MoveNext())
                Console.WriteLine(animalIterator.Current.Name);
        }
    }
}


45
using System;

namespace ContravariantErrorHandlerDemo
{
    interface IErrorHandler<in T> where T : Exception
    {
        void Handle(T exception);
    }

    class ExceptionHandler : IErrorHandler<Exception>
    {
        public void Handle(Exception ex) => Console.WriteLine($"Ошибка: {ex.Message}");
    }

    class Program
    {
        static void Main()
        {

            IErrorHandler<Exception> handler = new ExceptionHandler();

            IErrorHandler<ArgumentException> argHandler = handler;

            argHandler.Handle(new ArgumentException("Неверный аргумент"));
        }
    }
}


46
using System;

namespace EventHandlerVarianceDemo
{
    class Animal { }
    class Dog : Animal { }

    class AnimalEventArgs : EventArgs { public Animal Animal { get; } }
    class DogEventArgs : AnimalEventArgs { public Dog Dog => (Dog)Animal; }

    class Program
    {
        static void Main()
        {

            EventHandler<AnimalEventArgs> animalHandler = (s, e) => Console.WriteLine("Animal event");
            EventHandler<DogEventArgs> dogHandler = animalHandler;

            dogHandler(null, new DogEventArgs());
        }
    }
}


47
using System;

namespace ExplicitVarianceDemo
{
    interface IConverter<in TIn, out TOut>
    {
        TOut Convert(TIn input);
    }

    class StringToObject : IConverter<string, object>
    {
        public object Convert(string input) => input;
    }

    class Program
    {
        static void Main()
        {

            IConverter<string, object> conv = new StringToObject();

            IConverter<object, string> inVar = null;
            IConverter<string, string> outVar = null;
            IConverter<object, object> both = conv;

            Console.WriteLine(both.Convert("test"));
        }
    }
}


48
using System;

namespace VarianceConverterDemo
{
    interface IConverter<in TIn, out TOut>
    {
        TOut Convert(TIn input);
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class PetDto { public string PetName { get; set; } }

    class DogToDto : IConverter<Dog, PetDto>
    {
        public PetDto Convert(Dog dog) => new PetDto { PetName = dog.Name };
    }

    class Program
    {
        static void Main()
        {

            IConverter<Dog, PetDto> converter = new DogToDto();

            IConverter<Animal, object> combined = converter;

            var result = combined.Convert(new Dog { Name = "Rex" });
            Console.WriteLine(((PetDto)result).PetName);
        }
    }
}


49
using System;
using System.Collections.Generic;

namespace CovariantTypeSystemDemo
{
    interface IReadOnlyRepository<out T>
    {
        IEnumerable<T> GetAll();
    }

    class Base { }
    class Derived : Base { }

    class BaseRepo : IReadOnlyRepository<Base>
    {
        public IEnumerable<Base> GetAll() => new[] { new Base(), new Derived() };
    }

    class Program
    {
        static void Main()
        {

            IReadOnlyRepository<Derived> derivedRepo = null;
            IReadOnlyRepository<Base> baseRepo = new BaseRepo();

            IReadOnlyRepository<Base> repo = derivedRepo ?? baseRepo;

            foreach (var item in repo.GetAll())
                Console.WriteLine(item.GetType().Name);
        }
    }
}


50
using System;

namespace MultipleVarianceDemo
{
    interface IProcessor<in TIn1, in TIn2, out TOut>
    {
        TOut Process(TIn1 a, TIn2 b);
    }

    class Animal { public string Name { get; set; } }
    class Dog : Animal { }
    class Cat : Animal { }
    class Sound { public string Noise { get; set; } }

    class AnimalSoundProcessor : IProcessor<Dog, Cat, Sound>
    {
        public Sound Process(Dog dog, Cat cat) => new Sound { Noise = $"{dog.Name} barks, {cat.Name} meows" };
    }

    class Program
    {
        static void Main()
        {

            IProcessor<Dog, Cat, Sound> proc = new AnimalSoundProcessor();

            IProcessor<Animal, Animal, object> wide = proc;

            var result = wide.Process(new Dog { Name = "Rex" }, new Cat { Name = "Whiskers" });
            Console.WriteLine(((Sound)result).Noise);
        }
    }
}


51
using System;

namespace NullableDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Задание 51: Работа с int?, HasValue и Value ===\n");

            // Создание обнуляемых переменных
            int? nullableNumber1 = 42;
            int? nullableNumber2 = null;
            int? nullableNumber3 = 0;

            // Проверка HasValue
            Console.WriteLine("--- Проверка HasValue ---");
            Console.WriteLine($"nullableNumber1.HasValue: {nullableNumber1.HasValue}");
            Console.WriteLine($"nullableNumber2.HasValue: {nullableNumber2.HasValue}");
            Console.WriteLine($"nullableNumber3.HasValue: {nullableNumber3.HasValue}");

            // Доступ к Value с проверкой
            Console.WriteLine("\n--- Доступ к Value ---");
            if (nullableNumber1.HasValue)
            {
                Console.WriteLine($"nullableNumber1.Value: {nullableNumber1.Value}");
            }

            if (nullableNumber2.HasValue)
            {
                Console.WriteLine($"nullableNumber2.Value: {nullableNumber2.Value}");
            }
            else
            {
                Console.WriteLine("nullableNumber2.Value: недоступно (null)");
            }

            // Безопасное использование
            Console.WriteLine("\n--- Безопасное использование ---");
            DisplayNullableInfo(nullableNumber1);
            DisplayNullableInfo(nullableNumber2);
            DisplayNullableInfo(nullableNumber3);

            // Разные типы Nullable
            Console.WriteLine("\n--- Разные Nullable типы ---");
            bool? nullableBool = true;
            double? nullableDouble = 3.14;
            DateTime? nullableDate = DateTime.Now;
            DateTime? nullDate = null;

            Console.WriteLine($"nullableBool: {nullableBool?.ToString() ?? "null"}");
            Console.WriteLine($"nullableDouble: {nullableDouble?.ToString("F2") ?? "null"}");
            Console.WriteLine($"nullableDate: {nullableDate?.ToString("dd.MM.yyyy") ?? "null"}");
            Console.WriteLine($"nullDate: {nullDate?.ToString() ?? "null"}");
        }

        static void DisplayNullableInfo(int? number)
        {
            if (number.HasValue)
            {
                Console.WriteLine($"Значение: {number.Value}, Тип: {number.GetType()}");
            }
            else
            {
                Console.WriteLine("Значение: null");
            }
        }
    }
}


52
using System;

class NullableHelper
{
    // Безопасное получение значения или значения по умолчанию
    public static T GetSafeValue<T>(T? value, T defaultValue = default) where T : struct
        => value ?? defaultValue;

    // Выполнение действия если значение не null
    public static void IfHasValue<T>(T? value, Action<T> action) where T : struct
    {
        if (value.HasValue) action(value.Value);
    }
}

class Program
{
    static void Main()
    {
        int? num = 10;
        int? nullNum = null;

        // Тестирование GetSafeValue
        Console.WriteLine($"Безопасное значение: {NullableHelper.GetSafeValue(num)}");
        Console.WriteLine($"Null значение с default: {NullableHelper.GetSafeValue(nullNum, 100)}");

        // Тестирование IfHasValue
        NullableHelper.IfHasValue(num, n => Console.WriteLine($"Значение найдено: {n}"));
        NullableHelper.IfHasValue(nullNum, n => Console.WriteLine("Этот код не выполнится"));
    }
}


53
using System;

class GenericNullable
{
    // Универсальный метод для обработки любого Nullable типа
    public static void Process<T>(T? value) where T : struct
    {
        Console.WriteLine($"HasValue: {value.HasValue}");
        if (value.HasValue)
            Console.WriteLine($"Value: {value.Value}, Type: {value.Value.GetType()}");
        else
            Console.WriteLine("Значение равно null");
    }
}

class Program
{
    static void Main()
    {
        int? num = 42;
        double? d = 3.14;
        int? nullNum = null;

        // Обработка разных типов
        GenericNullable.Process(num);
        GenericNullable.Process(d);
        GenericNullable.Process(nullNum);
    }
}


54
using System;

class Validator
{
    // Проверка что значение не null перед использованием
    public static T Validate<T>(T? value, string parameterName) where T : struct
    {
        if (!value.HasValue)
            throw new ArgumentNullException(parameterName, $"{parameterName} не может быть null");
        return value.Value;
    }
}

class Program
{
    static void Main()
    {
        int? num = 10;
        int? nullNum = null;

        try
        {
            // Успешная проверка
            Console.WriteLine($"Валидное значение: {Validator.Validate(num, "num")}");

            // Проверка null значения (выбросит исключение)
            Console.WriteLine(Validator.Validate(nullNum, "nullNum"));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка валидации: {ex.Message}");
        }
    }
}


55
using System;

// Структура Point
struct Point
{
    public int X, Y;
    public override string ToString() => $"({X}, {Y})";
}

class Program
{
    static void Main()
    {
        // Nullable структура
        Point? point = new Point { X = 10, Y = 20 };
        Point? nullPoint = null;

        // Работа с nullable структурой
        Console.WriteLine($"Point: {point?.ToString() ?? "null"}");
        Console.WriteLine($"Null Point: {nullPoint?.ToString() ?? "null"}");

        // Проверка HasValue для структуры
        if (point.HasValue)
            Console.WriteLine($"Координаты: X={point.Value.X}, Y={point.Value.Y}");
    }
}


56
using System;

class Converter
{
    // Конвертация между разными Nullable типами
    public static TResult? Convert<T, TResult>(T? value, Func<T, TResult> converter)
        where T : struct
        where TResult : struct
    {
        return value.HasValue ? converter(value.Value) : (TResult?)null;
    }
}

class Program
{
    static void Main()
    {
        int? intValue = 100;

        // Конвертация int? в double?
        double? doubleValue = Converter.Convert(intValue, x => (double)x);
        Console.WriteLine($"int? {intValue} -> double? {doubleValue}");

        // Конвертация null значения
        int? nullValue = null;
        double? nullDouble = Converter.Convert(nullValue, x => (double)x);
        Console.WriteLine($"int? null -> double? {nullDouble?.ToString() ?? "null"}");
    }
}


57
using System;

class Optional<T>
{
    private readonly T _value;
    private readonly bool _hasValue;

    public Optional(T value)
    {
        _value = value;
        _hasValue = true;
    }

    public Optional()
    {
        _hasValue = false;
        _value = default;
    }

    public void IfPresent(Action<T> action)
    {
        if (_hasValue) action(_value);
    }

    public override string ToString() => _hasValue ? _value?.ToString() ?? "null" : "Empty";
}

class Program
{
    static void Main()
    {
        // Создание Optional значений
        var optional = new Optional<int>(42);
        var empty = new Optional<string>();

        // Работа с Optional
        optional.IfPresent(val => Console.WriteLine($"Значение: {val}"));
        empty.IfPresent(val => Console.WriteLine("Это не выполнится"));

        Console.WriteLine($"optional: {optional}");
        Console.WriteLine($"empty: {empty}");
    }
}


58
using System;

class Program
{
    static void Main()
    {
        int? a = 10;
        int? b = 10;
        int? c = null;
        int? d = 20;

        // Проверка Equals
        Console.WriteLine($"a.Equals(b): {a.Equals(b)}"); // True
        Console.WriteLine($"a.Equals(c): {a.Equals(c)}"); // False
        Console.WriteLine($"c.Equals(null): {c.Equals(null)}"); // True

        // GetHashCode
        Console.WriteLine($"a.GetHashCode(): {a.GetHashCode()}");
        Console.WriteLine($"c.GetHashCode(): {c.GetHashCode()}");

        // Сравнение значений
        Console.WriteLine($"a == b: {a == b}");
        Console.WriteLine($"a == d: {a == d}");
    }
}


59
using System;

class Person
{
    public string Name { get; set; }
    public int? Age { get; set; }
    public double? Height { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age?.ToString() ?? "Unknown"}, Height: {Height?.ToString("F2") ?? "Unknown"}";
    }
}

class Program
{
    static void Main()
    {
        var person = new Person
        {
            Name = "Иван",
            Age = 25,
            Height = 180.5
        };

        var unknownPerson = new Person
        {
            Name = "Аноним",
            Age = null,
            Height = null
        };

        Console.WriteLine(person);
        Console.WriteLine(unknownPerson);
    }
}


60
using System;

class DataValidator
{
    public static bool ValidatePerson(string name, int? age, double? height)
    {
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Ошибка: Имя обязательно");
            return false;
        }

        if (age.HasValue && age < 0)
        {
            Console.WriteLine("Ошибка: Возраст не может быть отрицательным");
            return false;
        }

        if (height.HasValue && height <= 0)
        {
            Console.WriteLine("Ошибка: Рост должен быть положительным");
            return false;
        }

        Console.WriteLine("Данные валидны");
        return true;
    }
}

class Program
{
    static void Main()
    {
        // Валидные данные
        DataValidator.ValidatePerson("Иван", 25, 180.5);

        // Невалидные данные
        DataValidator.ValidatePerson("", -5, 0);

        // Данные с null
        DataValidator.ValidatePerson("Петр", null, null);
    }
}


61
using System;
using System.Collections.Generic;

class DefaultValueHelper
{
    // Метод возвращает значение или значение по умолчанию
    public static T GetValueOrDefault<T>(T? nullableValue, T defaultValue = default) where T : struct
    {
        return nullableValue.GetValueOrDefault(defaultValue);
    }

    // Универсальный метод для любых типов (включая reference types)
    public static T GetValueOrDefault<T>(T value, T defaultValue)
    {
        return value ?? defaultValue;
    }
}

class Program
{
    static void Main()
    {
        int? number = 42;
        int? nullNumber = null;
        string text = "Hello";
        string nullText = null;

        // Для value types
        Console.WriteLine($"number: {DefaultValueHelper.GetValueOrDefault(number, 100)}");
        Console.WriteLine($"nullNumber: {DefaultValueHelper.GetValueOrDefault(nullNumber, 100)}");

        // Для reference types
        Console.WriteLine($"text: {DefaultValueHelper.GetValueOrDefault(text, "Default")}");
        Console.WriteLine($"nullText: {DefaultValueHelper.GetValueOrDefault(nullText, "Default")}");
    }
}


62
using System;
using System.Collections.Generic;
using System.Linq;

class NullableCollection<T> where T : struct
{
    private List<T?> _items = new List<T?>();

    public void Add(T? item) => _items.Add(item);

    public List<T> GetNonNullValues() => _items.Where(i => i.HasValue).Select(i => i.Value).ToList();

    public List<T> GetNonNullValuesWithDefault(T defaultValue) =>
        _items.Select(i => i.GetValueOrDefault(defaultValue)).ToList();

    public void PrintAll()
    {
        Console.WriteLine("Все элементы:");
        foreach (var item in _items)
        {
            Console.WriteLine($"  {item?.ToString() ?? "null"}");
        }
    }
}

class Program
{
    static void Main()
    {
        var collection = new NullableCollection<int>();
        collection.Add(1);
        collection.Add(null);
        collection.Add(3);
        collection.Add(null);
        collection.Add(5);

        collection.PrintAll();

        var nonNull = collection.GetNonNullValues();
        Console.WriteLine($"Не-null значения: {string.Join(", ", nonNull)}");

        var withDefaults = collection.GetNonNullValuesWithDefault(0);
        Console.WriteLine($"С значениями по умолчанию: {string.Join(", ", withDefaults)}");
    }
}


63
using System;

class NullToDefaultConverter
{
    // Метод расширения для преобразования null в default
    public static T ToDefault<T>(this T? nullableValue, T defaultValue = default) where T : struct
    {
        return nullableValue ?? defaultValue;
    }

    // Для reference types
    public static T ToDefault<T>(this T value, T defaultValue) where T : class
    {
        return value ?? defaultValue;
    }
}

class Program
{
    static void Main()
    {
        int? number = 42;
        int? nullNumber = null;
        string text = "Hello";
        string nullText = null;

        // Value types
        Console.WriteLine($"number: {number.ToDefault(100)}");
        Console.WriteLine($"nullNumber: {nullNumber.ToDefault(100)}");

        // Reference types
        Console.WriteLine($"text: {text.ToDefault("Default")}");
        Console.WriteLine($"nullText: {nullText.ToDefault("Default")}");

        // Использование в цепочках
        int result = GetNullableNumber().ToDefault(999);
        Console.WriteLine($"Результат цепочки: {result}");
    }

    static int? GetNullableNumber() => null;
}


64
using System;

class Configuration
{
    // Методы с опциональными nullable параметрами
    public void ProcessData(string required, int? optionalInt = null, string optionalString = null, double? optionalDouble = null)
    {
        Console.WriteLine($"Required: {required}");
        Console.WriteLine($"OptionalInt: {optionalInt?.ToString() ?? "не указан"}");
        Console.WriteLine($"OptionalString: {optionalString ?? "не указан"}");
        Console.WriteLine($"OptionalDouble: {optionalDouble?.ToString("F2") ?? "не указан"}");
        Console.WriteLine();
    }

    // Метод с валидацией опциональных параметров
    public void ProcessWithValidation(string name, int? age = null)
    {
        if (age.HasValue && age < 0)
            throw new ArgumentException("Возраст не может быть отрицательным");

        Console.WriteLine($"Name: {name}, Age: {age?.ToString() ?? "не указан"}");
    }
}

class Program
{
    static void Main()
    {
        var config = new Configuration();

        // Различные комбинации параметров
        config.ProcessData("Обязательный параметр");
        config.ProcessData("Обязательный", 100);
        config.ProcessData("Обязательный", optionalString: "Текст");
        config.ProcessData("Обязательный", 200, "Текст", 3.14);

        // С валидацией
        config.ProcessWithValidation("Иван", 25);
        config.ProcessWithValidation("Петр"); // age = null
    }
}


65
using System;

class CopyHelper
{
    // Создание nullable копии объекта
    public static T? CreateNullableCopy<T>(T obj) where T : class
    {
        return obj; // Просто возвращаем ссылку (для демонстрации)
    }

    // Глубокое копирование с возможностью null
    public static T CreateCopy<T>(T? original) where T : struct
    {
        return original ?? default(T);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"{Name} ({Age})";
}

class Program
{
    static void Main()
    {
        Person person = new Person { Name = "Иван", Age = 25 };
        Person? nullPerson = null;

        // Создание nullable копий
        Person? copy1 = CopyHelper.CreateNullableCopy(person);
        Person? copy2 = CopyHelper.CreateNullableCopy(nullPerson);

        Console.WriteLine($"Original: {person}");
        Console.WriteLine($"Copy: {copy1?.ToString() ?? "null"}");
        Console.WriteLine($"Null copy: {copy2?.ToString() ?? "null"}");

        // Для value types
        int? number = 42;
        int copyNumber = CopyHelper.CreateCopy(number);
        Console.WriteLine($"Number copy: {copyNumber}");
    }
}


66
using System;

class NullableComparer
{
    // Сравнение двух nullable значений
    public static bool AreEqual<T>(T? first, T? second) where T : struct, IEquatable<T>
    {
        if (!first.HasValue && !second.HasValue) return true;
        if (first.HasValue && second.HasValue) return first.Value.Equals(second.Value);
        return false;
    }

    // Сравнение с учетом порядка
    public static int Compare<T>(T? first, T? second) where T : struct, IComparable<T>
    {
        if (!first.HasValue && !second.HasValue) return 0;
        if (!first.HasValue) return -1;
        if (!second.HasValue) return 1;
        return first.Value.CompareTo(second.Value);
    }
}

class Program
{
    static void Main()
    {
        int? a = 10;
        int? b = 10;
        int? c = 20;
        int? d = null;
        int? e = null;

        // Проверка равенства
        Console.WriteLine($"a == b: {NullableComparer.AreEqual(a, b)}");
        Console.WriteLine($"a == c: {NullableComparer.AreEqual(a, c)}");
        Console.WriteLine($"d == e: {NullableComparer.AreEqual(d, e)}");
        Console.WriteLine($"a == d: {NullableComparer.AreEqual(a, d)}");

        // Сравнение
        Console.WriteLine($"Compare a-b: {NullableComparer.Compare(a, b)}");
        Console.WriteLine($"Compare a-c: {NullableComparer.Compare(a, c)}");
        Console.WriteLine($"Compare d-e: {NullableComparer.Compare(d, e)}");
        Console.WriteLine($"Compare a-d: {NullableComparer.Compare(a, d)}");
        Console.WriteLine($"Compare d-a: {NullableComparer.Compare(d, a)}");
    }
}


67
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new int?[] { 1, null, 3, null, 5, 6, null, 8 };

        // Фильтрация null значений
        var nonNullNumbers = numbers.Where(n => n.HasValue).Select(n => n.Value);
        Console.WriteLine($"Не-null числа: {string.Join(", ", nonNullNumbers)}");

        // Преобразование null в значения по умолчанию
        var withDefaults = numbers.Select(n => n ?? 0);
        Console.WriteLine($"С значениями по умолчанию: {string.Join(", ", withDefaults)}");

        // Группировка по наличию значения
        var grouped = numbers.GroupBy(n => n.HasValue ? "HasValue" : "Null");
        foreach (var group in grouped)
        {
            Console.WriteLine($"{group.Key}: {group.Count()} элементов");
        }

        // Агрегатные функции с null
        Console.WriteLine($"Сумма: {numbers.Sum() ?? 0}");
        Console.WriteLine($"Максимум: {numbers.Max() ?? 0}");
        Console.WriteLine($"Количество не-null: {numbers.Count(n => n.HasValue)}");

        // Сложный запрос с условиями
        var result = numbers
            .Where(n => n.HasValue && n > 3)
            .Select(n => n.Value * 2)
            .ToList();

        Console.WriteLine($"Числа > 3 умноженные на 2: {string.Join(", ", result)}");
    }
}


68
using System;

class ExceptionHandler
{
    public static T SafeGetValue<T>(T? nullableValue, string paramName) where T : struct
    {
        try
        {
            if (!nullableValue.HasValue)
                throw new ArgumentNullException(paramName, $"Параметр {paramName} не может быть null");

            return nullableValue.Value;
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Перехвачено ArgumentNullException: {ex.Message}");
            return default(T);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
            return default(T);
        }
    }

    public static void ProcessWithNullCheck<T>(T? value, Action<T> processor) where T : struct
    {
        try
        {
            processor(value ?? throw new InvalidOperationException("Значение не может быть null"));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка обработки: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        int? validValue = 42;
        int? nullValue = null;

        // Безопасное получение значения
        int result1 = ExceptionHandler.SafeGetValue(validValue, "validValue");
        int result2 = ExceptionHandler.SafeGetValue(nullValue, "nullValue");

        Console.WriteLine($"Result1: {result1}");
        Console.WriteLine($"Result2: {result2}");

        // Безопасная обработка
        ExceptionHandler.ProcessWithNullCheck(validValue, v => Console.WriteLine($"Обработка: {v * 2}"));
        ExceptionHandler.ProcessWithNullCheck(nullValue, v => Console.WriteLine("Это не выполнится"));
    }
}


69
using System;
using System.Collections.Generic;
using System.Linq;

class NullFilter
{
    // Фильтрация null значений из коллекции
    public static List<T> FilterNulls<T>(IEnumerable<T?> collection) where T : struct
    {
        return collection.Where(item => item.HasValue).Select(item => item.Value).ToList();
    }

    // Фильтрация с преобразованием
    public static List<TResult> FilterAndTransform<T, TResult>(
        IEnumerable<T?> collection,
        Func<T, TResult> transformer) where T : struct
    {
        return collection
            .Where(item => item.HasValue)
            .Select(item => transformer(item.Value))
            .ToList();
    }

    // Универсальный фильтр для любых типов
    public static List<T> FilterNullsGeneric<T>(IEnumerable<T> collection) where T : class
    {
        return collection.Where(item => item != null).ToList();
    }
}

class Program
{
    static void Main()
    {
        // Value types
        int?[] numbers = { 1, null, 3, null, 5, null, 7 };
        var filteredNumbers = NullFilter.FilterNulls(numbers);
        Console.WriteLine($"Отфильтрованные числа: {string.Join(", ", filteredNumbers)}");

        // С преобразованием
        var transformed = NullFilter.FilterAndTransform(numbers, n => n * 2);
        Console.WriteLine($"Преобразованные числа: {string.Join(", ", transformed)}");

        // Reference types
        string[] strings = { "a", null, "c", null, "e" };
        var filteredStrings = NullFilter.FilterNullsGeneric(strings);
        Console.WriteLine($"Отфильтрованные строки: {string.Join(", ", filteredStrings)}");
    }
}


70
using System;

class Wrapper<T>
{
    private T _value;
    private bool _hasValue;

    public Wrapper(T value)
    {
        _value = value;
        _hasValue = true;
    }

    public Wrapper()
    {
        _hasValue = false;
        _value = default;
    }

    public T Value
    {
        get
        {
            if (!_hasValue) throw new InvalidOperationException("Значение не установлено");
            return _value;
        }
        set
        {
            _value = value;
            _hasValue = true;
        }
    }

    public bool HasValue => _hasValue;

    public T GetValueOrDefault(T defaultValue = default)
    {
        return _hasValue ? _value : defaultValue;
    }

    public override string ToString()
    {
        return _hasValue ? _value?.ToString() ?? "null" : "No Value";
    }
}

class Program
{
    static void Main()
    {
        // Wrapper для value type
        var intWrapper = new Wrapper<int>(42);
        var nullIntWrapper = new Wrapper<int>();

        Console.WriteLine($"intWrapper: {intWrapper.Value}, HasValue: {intWrapper.HasValue}");
        Console.WriteLine($"nullIntWrapper: {nullIntWrapper.GetValueOrDefault(100)}, HasValue: {nullIntWrapper.HasValue}");

        // Wrapper для reference type
        var stringWrapper = new Wrapper<string>("Hello");
        var nullStringWrapper = new Wrapper<string>();

        Console.WriteLine($"stringWrapper: {stringWrapper.Value}");
        Console.WriteLine($"nullStringWrapper: {nullStringWrapper.GetValueOrDefault("Default")}");
    }
}


71
using System;
using System.Collections.Generic;

class GenericNullableExample
{
    // Generic метод работающий с Nullable типами
    public static TResult? ProcessNullable<T, TResult>(T? value, Func<T, TResult> processor)
        where T : struct
        where TResult : struct
    {
        return value.HasValue ? processor(value.Value) : (TResult?)null;
    }

    // Generic класс с nullable полем
    class Container<T> where T : struct
    {
        public T? Value { get; set; }

        public void Display()
        {
            Console.WriteLine($"Value: {Value?.ToString() ?? "null"}, Type: {typeof(T).Name}");
        }
    }

    // Generic метод с constraint на nullable
    public static bool IsNull<T>(T? value) where T : struct
    {
        return !value.HasValue;
    }
}

class Program
{
    static void Main()
    {
        // Использование generic метода
        int? number = 42;
        double? result = GenericNullableExample.ProcessNullable(number, n => (double)n * 1.5);
        Console.WriteLine($"Результат: {result}");

        // Использование generic класса
        var intContainer = new GenericNullableExample.Container<int> { Value = 100 };
        var nullContainer = new GenericNullableExample.Container<double> { Value = null };

        intContainer.Display();
        nullContainer.Display();

        // Проверка на null
        Console.WriteLine($"number is null: {GenericNullableExample.IsNull(number)}");
        Console.WriteLine($"null is null: {GenericNullableExample.IsNull((int?)null)}");
    }
}


72
using System;
using System.Collections.Generic;

class NullableMapper
{
    // Маппинг nullable значения
    public static TResult? Map<T, TResult>(T? source, Func<T, TResult> mapper, TResult? defaultValue = null)
        where T : struct
        where TResult : struct
    {
        return source.HasValue ? mapper(source.Value) : defaultValue;
    }

    // Маппинг коллекции с обработкой null
    public static List<TResult> MapCollection<T, TResult>(
        IEnumerable<T?> source,
        Func<T, TResult> mapper,
        TResult defaultForNull = default)
        where T : struct
    {
        var result = new List<TResult>();
        foreach (var item in source)
        {
            result.Add(item.HasValue ? mapper(item.Value) : defaultForNull);
        }
        return result;
    }

    // Условный маппинг
    public static TResult? MapWithCondition<T, TResult>(
        T? source,
        Func<T, bool> condition,
        Func<T, TResult> trueMapper,
        Func<T, TResult> falseMapper)
        where T : struct
        where TResult : struct
    {
        if (!source.HasValue) return null;
        return condition(source.Value) ? trueMapper(source.Value) : falseMapper(source.Value);
    }
}

class Program
{
    static void Main()
    {
        int? number = 42;
        int? nullNumber = null;

        // Простой маппинг
        string? result1 = NullableMapper.Map(number, n => $"Number: {n}");
        string? result2 = NullableMapper.Map(nullNumber, n => $"Number: {n}", "Default");

        Console.WriteLine($"result1: {result1}");
        Console.WriteLine($"result2: {result2}");

        // Маппинг коллекции
        int?[] numbers = { 1, null, 3, null, 5 };
        var mapped = NullableMapper.MapCollection(numbers, n => n * 2, 0);
        Console.WriteLine($"Маппинг коллекции: {string.Join(", ", mapped)}");

        // Условный маппинг
        var conditional = NullableMapper.MapWithCondition(
            number,
            n => n > 50,
            n => "Больше 50",
            n => "Меньше или равно 50");

        Console.WriteLine($"Условный маппинг: {conditional}");
    }
}


73
using System;
using System.Collections.Generic;

class MissingValueSystem<T>
{
    private Dictionary<string, T?> _storage = new Dictionary<string, T?>();

    public void SetValue(string key, T? value) where T : struct
    {
        _storage[key] = value;
    }

    public T? GetValue(string key)
    {
        return _storage.ContainsKey(key) ? _storage[key] : null;
    }

    public T GetValueOrDefault(string key, T defaultValue = default)
    {
        var value = GetValue(key);
        return value ?? defaultValue;
    }

    public bool HasValue(string key)
    {
        return _storage.ContainsKey(key) && _storage[key].HasValue;
    }

    public IEnumerable<string> GetKeysWithMissingValues()
    {
        foreach (var kvp in _storage)
        {
            if (!kvp.Value.HasValue)
                yield return kvp.Key;
        }
    }

    public void PrintAll()
    {
        foreach (var kvp in _storage)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value?.ToString() ?? "MISSING"}");
        }
    }
}

class Program
{
    static void Main()
    {
        var system = new MissingValueSystem<int>();

        // Добавление значений
        system.SetValue("age", 25);
        system.SetValue("height", 180);
        system.SetValue("weight", null); // Отсутствующее значение
        system.SetValue("score", null);  // Отсутствующее значение

        // Получение значений
        Console.WriteLine($"Age: {system.GetValueOrDefault("age", 0)}");
        Console.WriteLine($"Weight: {system.GetValueOrDefault("weight", 70)}");
        Console.WriteLine($"Unknown: {system.GetValueOrDefault("unknown", 999)}");

        // Проверка наличия значений
        Console.WriteLine($"Has age: {system.HasValue("age")}");
        Console.WriteLine($"Has weight: {system.HasValue("weight")}");

        // Ключи с отсутствующими значениями
        Console.WriteLine("Ключи с отсутствующими значениями:");
        foreach (var key in system.GetKeysWithMissingValues())
        {
            Console.WriteLine($"  {key}");
        }

        system.PrintAll();
    }
}


74
using System;
using System.Collections.Generic;

class NullableResultRegistry
{
    private List<object> _results = new List<object>();
    private List<string> _descriptions = new List<string>();

    // Регистрация nullable результата
    public void Register<T>(T? result, string description) where T : struct
    {
        _results.Add(result);
        _descriptions.Add($"{description}: {result?.ToString() ?? "null"}");
    }

    // Регистрация с преобразованием
    public void RegisterTransformed<T>(T? result, string description, Func<T, string> transformer) where T : struct
    {
        string value = result.HasValue ? transformer(result.Value) : "null";
        _results.Add(result);
        _descriptions.Add($"{description}: {value}");
    }

    // Получение всех зарегистрированных результатов
    public void PrintAll()
    {
        Console.WriteLine("Зарегистрированные результаты:");
        foreach (var desc in _descriptions)
        {
            Console.WriteLine($"  {desc}");
        }
    }

    // Статистика по результатам
    public void PrintStatistics()
    {
        int total = _results.Count;
        int nullCount = 0;

        foreach (var result in _results)
        {
            if (result == null || (result.GetType().IsGenericType &&
                result.GetType().GetGenericTypeDefinition() == typeof(Nullable<>) &&
                !(bool)result.GetType().GetProperty("HasValue").GetValue(result)))
            {
                nullCount++;
            }
        }

        Console.WriteLine($"Всего результатов: {total}");
        Console.WriteLine($"Null результатов: {nullCount}");
        Console.WriteLine($"Не-null результатов: {total - nullCount}");
    }
}

class Program
{
    static void Main()
    {
        var registry = new NullableResultRegistry();

        // Регистрация различных результатов
        registry.Register(42, "Число");
        registry.Register((int?)null, "Пустое число");
        registry.Register(3.14, "Дробное число");
        registry.Register((double?)null, "Пустое дробное число");

        // Регистрация с преобразованием
        registry.RegisterTransformed(100, "Большое число", n => $"*** {n} ***");

        // Вывод результатов
        registry.PrintAll();
        Console.WriteLine();
        registry.PrintStatistics();
    }
}


75
using System;
using System.Collections.Generic;

class NullableCache<TKey, TValue> where TValue : struct
{
    private Dictionary<TKey, TValue?> _cache = new Dictionary<TKey, TValue?>();
    private Dictionary<TKey, DateTime> _timestamps = new Dictionary<TKey, DateTime>();

    // Добавление в кеш
    public void Set(TKey key, TValue? value)
    {
        _cache[key] = value;
        _timestamps[key] = DateTime.Now;
    }

    // Получение из кеша
    public TValue? Get(TKey key)
    {
        return _cache.ContainsKey(key) ? _cache[key] : null;
    }

    // Получение с значением по умолчанию
    public TValue GetOrDefault(TKey key, TValue defaultValue = default)
    {
        return Get(key) ?? defaultValue;
    }

    // Проверка наличия не-null значения
    public bool HasValue(TKey key)
    {
        return _cache.ContainsKey(key) && _cache[key].HasValue;
    }

    // Очистка устаревших записей
    public void ClearOld(TimeSpan olderThan)
    {
        var cutoff = DateTime.Now - olderThan;
        var keysToRemove = new List<TKey>();

        foreach (var kvp in _timestamps)
        {
            if (kvp.Value < cutoff)
            {
                keysToRemove.Add(kvp.Key);
            }
        }

        foreach (var key in keysToRemove)
        {
            _cache.Remove(key);
            _timestamps.Remove(key);
        }
    }

    // Статистика кеша
    public void PrintStats()
    {
        int total = _cache.Count;
        int withValues = 0;

        foreach (var value in _cache.Values)
        {
            if (value.HasValue) withValues++;
        }

        Console.WriteLine($"Всего записей: {total}");
        Console.WriteLine($"С значениями: {withValues}");
        Console.WriteLine($"Null значений: {total - withValues}");
    }
}

class Program
{
    static void Main()
    {
        var cache = new NullableCache<string, int>();

        // Добавление данных в кеш
        cache.Set("age", 25);
        cache.Set("height", 180);
        cache.Set("weight", null); // Null значение
        cache.Set("score", 95);

        // Получение данных
        Console.WriteLine($"Age: {cache.GetOrDefault("age", 0)}");
        Console.WriteLine($"Weight: {cache.GetOrDefault("weight", 70)}");
        Console.WriteLine($"Unknown: {cache.GetOrDefault("unknown", 999)}");

        // Проверка наличия значений
        Console.WriteLine($"Has age: {cache.HasValue("age")}");
        Console.WriteLine($"Has weight: {cache.HasValue("weight")}");

        // Статистика
        cache.PrintStats();
    }
}


76
using System;

class Program
{
    static void Main()
    {
        string text = "Привет";
        string nullText = null;
        string emptyText = "";

        // Оператор ?? для строк
        string result1 = text ?? "По умолчанию";
        string result2 = nullText ?? "По умолчанию";
        string result3 = emptyText ?? "По умолчанию"; // emptyText не null, поэтому не используется значение по умолчанию

        Console.WriteLine($"text: '{text}' -> result: '{result1}'");
        Console.WriteLine($"nullText: null -> result: '{result2}'");
        Console.WriteLine($"emptyText: '{emptyText}' -> result: '{result3}'");

        // Комбинирование с другими операциями
        string input = null;
        string processed = (input ?? "Не указано").ToUpper();
        Console.WriteLine($"Обработанный результат: '{processed}'");
    }
}


77
using System;

class DataProcessor
{
    public static string GetUserName(int? userId)
    {
        // Обработка null результата из базы данных
        string nameFromDb = GetUserNameFromDatabase(userId) ?? "Неизвестный пользователь";
        return nameFromDb;
    }

    private static string GetUserNameFromDatabase(int? userId)
    {
        // Имитация запроса к базе данных
        if (userId == 1) return "Иван";
        if (userId == 2) return "Петр";
        return null; // Пользователь не найден
    }

    public static int CalculatePrice(int? basePrice, int? discount)
    {
        // Обработка null в расчетах
        int actualPrice = basePrice ?? 1000;
        int actualDiscount = discount ?? 0;

        return actualPrice - actualDiscount;
    }
}

class Program
{
    static void Main()
    {
        // Тестирование обработки нулевых результатов
        Console.WriteLine($"Пользователь 1: {DataProcessor.GetUserName(1)}");
        Console.WriteLine($"Пользователь 999: {DataProcessor.GetUserName(999)}"); // Несуществующий ID
        Console.WriteLine($"Пользователь null: {DataProcessor.GetUserName(null)}");

        // Расчет цены
        Console.WriteLine($"Цена с базовой ценой: {DataProcessor.CalculatePrice(500, 50)}");
        Console.WriteLine($"Цена без базовой цены: {DataProcessor.CalculatePrice(null, 50)}");
        Console.WriteLine($"Цена без скидки: {DataProcessor.CalculatePrice(500, null)}");
    }
}


78
using System;

class Program
{
    static void Main()
    {
        string value1 = null;
        string value2 = null;
        string value3 = "Третье значение";
        string value4 = "Четвертое значение";

        // Цепочка операторов ??
        string result1 = value1 ?? value2 ?? value3 ?? value4 ?? "Все значения null";
        string result2 = value1 ?? value2 ?? value3 ?? "Резервное значение";
        string result3 = value1 ?? value2 ?? "Второе резервное значение";

        Console.WriteLine($"Результат 1: {result1}");
        Console.WriteLine($"Результат 2: {result2}");
        Console.WriteLine($"Результат 3: {result3}");

        // Цепочка с разными типами
        int? a = null;
        int? b = null;
        int? c = 42;
        int final = a ?? b ?? c ?? 999;

        Console.WriteLine($"Числовой результат: {final}");

        // Практический пример: приоритет источников данных
        string configValue = GetFromConfig() ?? GetFromEnvironment() ?? GetDefaultValue();
        Console.WriteLine($"Значение конфигурации: {configValue}");
    }

    static string GetFromConfig() => null; // Конфиг не задан
    static string GetFromEnvironment() => "Из переменных окружения";
    static string GetDefaultValue() => "Значение по умолчанию";
}


79
using System;

class ValueFinder
{
    // Метод возвращает первое не-null значение из последовательности
    public static T GetFirstNonNull<T>(params T[] values) where T : class
    {
        foreach (T value in values)
        {
            if (value != null) return value;
        }
        return default(T);
    }

    // Метод возвращает первое не-null значение с преобразованием
    public static TResult GetFirstNonNull<T, TResult>(
        Func<T, TResult> converter,
        params T[] values) where T : class
    {
        foreach (T value in values)
        {
            if (value != null) return converter(value);
        }
        return default(TResult);
    }
}

class Program
{
    static void Main()
    {
        // Поиск первого не-null значения
        string result1 = ValueFinder.GetFirstNonNull(null, null, "Третье", "Четвертое");
        string result2 = ValueFinder.GetFirstNonNull(null, null, null);
        string result3 = ValueFinder.GetFirstNonNull("Первое", "Второе", "Третье");

        Console.WriteLine($"Результат 1: {result1 ?? "null"}");
        Console.WriteLine($"Результат 2: {result2 ?? "null"}");
        Console.WriteLine($"Результат 3: {result3}");

        // С преобразованием
        string num1 = null;
        string num2 = "42";
        string num3 = "100";

        int converted = ValueFinder.GetFirstNonNull<string, int>(
            s => int.Parse(s),
            num1, num2, num3
        );

        Console.WriteLine($"Преобразованное значение: {converted}");
    }
}


80
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ??= для переменных
        string text = null;
        text ??= "Значение по умолчанию";
        Console.WriteLine($"text после ??=: {text}");

        text ??= "Другое значение"; // Не выполнится, так как text уже не null
        Console.WriteLine($"text после второго ??=: {text}");

        // ??= в циклах
        List<string> names = new List<string> { null, "Иван", null, "Петр" };
        for (int i = 0; i < names.Count; i++)
        {
            names[i] ??= "Неизвестный";
        }
        Console.WriteLine($"Имена после обработки: {string.Join(", ", names)}");

        // ??= для свойств класса
        var config = new Configuration();
        config.AppName ??= "Мое приложение";
        config.Version ??= "1.0.0";

        Console.WriteLine($"Конфигурация: {config.AppName} v{config.Version}");
    }
}

class Configuration
{
    public string AppName { get; set; }
    public string Version { get; set; }
}


81
// Задание 81: ?? в условных выражениях
using System;

class Program
{
    static void Main()
    {
        string userInput = null;
        int? userAge = null;
        bool? isActive = null;

        // ?? в условиях if
        if ((userInput ?? "default").Length > 5)
        {
            Console.WriteLine("Длинный текст");
        }

        // ?? в тернарном операторе
        string status = (userAge ?? 0) >= 18 ? "Взрослый" : "Ребенок";
        Console.WriteLine($"Статус: {status}");

        // ?? в switch выражении
        string category = (userAge ?? 0) switch
        {
            < 18 => "Ребенок",
            < 65 => "Взрослый",
            _ => "Пенсионер"
        };
        Console.WriteLine($"Категория: {category}");

        // Комбинирование с другими операторами
        bool actualStatus = isActive ?? false;
        string message = actualStatus ? "Активен" : "Неактивен";
        Console.WriteLine($"Статус активности: {message}");

        // Сложное условие с ??
        int? score = null;
        int? bonus = 10;
        int total = (score ?? 0) + (bonus ?? 0);

        if (total > 50)
        {
            Console.WriteLine($"Высокий результат: {total}");
        }
        else
        {
            Console.WriteLine($"Низкий результат: {total}");
        }
    }
}


82
using System;

class ValueSetter
{
    // Установка значения только если текущее значение null
    public static void SetIfNull<T>(ref T field, T newValue) where T : class
    {
        field ??= newValue;
    }

    // Установка свойства только если null
    public static void SetPropertyIfNull<T>(object obj, string propertyName, T value) where T : class
    {
        var property = obj.GetType().GetProperty(propertyName);
        var currentValue = property.GetValue(obj) as T;
        if (currentValue == null)
        {
            property.SetValue(obj, value);
        }
    }
}

class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString() => $"Name: {Name ?? "Не указано"}, Email: {Email ?? "Не указан"}";
}

class Program
{
    static void Main()
    {
        // Установка значений в переменных
        string username = null;
        ValueSetter.SetIfNull(ref username, "Гость");
        Console.WriteLine($"Username: {username}");

        ValueSetter.SetIfNull(ref username, "Администратор"); // Не изменится
        Console.WriteLine($"Username после второй попытки: {username}");

        // Установка свойств объекта
        var user = new User();
        ValueSetter.SetPropertyIfNull(user, "Name", "Иван");
        ValueSetter.SetPropertyIfNull(user, "Email", "ivan@example.com");

        Console.WriteLine($"Пользователь: {user}");

        // Попытка установить снова (не сработает)
        ValueSetter.SetPropertyIfNull(user, "Name", "Петр");
        Console.WriteLine($"Пользователь после повторной установки: {user}");
    }
}


83
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = null;
        List<int> numbers = null;

        // ?? с List
        List<string> safeNames = names ?? new List<string> { "По умолчанию 1", "По умолчанию 2" };
        Console.WriteLine($"Имена: {string.Join(", ", safeNames)}");

        // ?? с массивом
        int[] data = null;
        int[] safeData = data ?? new[] { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Данные: {string.Join(", ", safeData)}");

        // ?? в цикле foreach
        foreach (var item in names ?? new List<string> { "Элемент 1", "Элемент 2" })
        {
            Console.WriteLine($"Элемент: {item}");
        }

        // ?? с Dictionary
        Dictionary<string, string> config = null;
        var value = (config ?? new Dictionary<string, string>()).GetValueOrDefault("key", "Не найдено");
        Console.WriteLine($"Значение из словаря: {value}");

        // Практический пример
        List<Product> products = GetProducts() ?? new List<Product>
        {
            new Product { Name = "Товар по умолчанию", Price = 100 }
        };

        Console.WriteLine("Товары:");
        foreach (var product in products)
        {
            Console.WriteLine($"  {product.Name} - {product.Price} руб.");
        }
    }

    static List<Product> GetProducts() => null;
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}


84
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var people = new List<Person>
        {
            new Person { Name = "Иван", Age = 25 },
            new Person { Name = null, Age = 30 },
            new Person { Name = "Петр", Age = null },
            new Person { Name = null, Age = null }
        };

        // ?? в Select
        var names = people.Select(p => p.Name ?? "Неизвестно").ToList();
        Console.WriteLine($"Имена: {string.Join(", ", names)}");

        // ?? в Where с преобразованием
        var adults = people.Where(p => (p.Age ?? 0) >= 18)
                          .Select(p => new { Name = p.Name ?? "Аноним", Age = p.Age ?? 0 })
                          .ToList();

        Console.WriteLine("Взрослые:");
        foreach (var adult in adults)
        {
            Console.WriteLine($"  {adult.Name} - {adult.Age} лет");
        }

        // ?? в агрегатных функциях
        double averageAge = people.Average(p => p.Age ?? 0);
        int maxAge = people.Max(p => p.Age ?? 0);

        Console.WriteLine($"Средний возраст: {averageAge:F1}");
        Console.WriteLine($"Максимальный возраст: {maxAge}");

        // ?? в GroupBy
        var grouped = people.GroupBy(p => p.Name ?? "Без имени")
                           .Select(g => new { Group = g.Key, Count = g.Count() })
                           .ToList();

        Console.WriteLine("Группировка:");
        foreach (var group in grouped)
        {
            Console.WriteLine($"  {group.Group}: {group.Count} чел.");
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int? Age { get; set; }
}


85
using System;

class Program
{
    static void Main()
    {
        User user = null;
        User defaultUser = new User { Name = "Гость", Email = "guest@example.com" };

        // ?? с объектами
        User safeUser = user ?? defaultUser;
        Console.WriteLine($"Пользователь: {safeUser.Name}");

        // ?? в цепочке свойств
        string userName = user?.Name ?? "Неизвестный пользователь";
        string userEmail = user?.Email ?? "email@example.com";

        Console.WriteLine($"Имя: {userName}");
        Console.WriteLine($"Email: {userEmail}");

        // Комбинирование ?. и ??
        Order order = null;
        string customerName = order?.Customer?.Name ?? "Клиент не указан";
        decimal total = order?.Total ?? 0m;

        Console.WriteLine($"Имя клиента: {customerName}");
        Console.WriteLine($"Сумма заказа: {total}");

        // ?? с методами объектов
        string description = user?.GetDescription() ?? "Описание недоступно";
        Console.WriteLine($"Описание: {description}");
    }
}

class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public string GetDescription() => $"{Name} ({Email})";
}

class Order
{
    public User Customer { get; set; }
    public decimal Total { get; set; }
}


86
using System;

class PropertyHelper
{
    // Установка значения свойства если оно null
    public static void SetPropertyIfNull<T>(object obj, string propertyName, T value)
    {
        var property = obj.GetType().GetProperty(propertyName);
        var currentValue = property.GetValue(obj);

        if (currentValue == null)
        {
            property.SetValue(obj, value);
        }
    }

    // Массовая установка свойств если они null
    public static void SetPropertiesIfNull(object obj, params (string, object)[] properties)
    {
        foreach (var (propertyName, value) in properties)
        {
            SetPropertyIfNull(obj, propertyName, value);
        }
    }
}

class Settings
{
    public string Theme { get; set; }
    public string Language { get; set; }
    public int? FontSize { get; set; }

    public override string ToString() =>
        $"Theme: {Theme ?? "Не задана"}, Language: {Language ?? "Не задан"}, FontSize: {FontSize?.ToString() ?? "Не задан"}";
}

class Program
{
    static void Main()
    {
        var settings = new Settings();

        Console.WriteLine("До установки:");
        Console.WriteLine(settings);

        // Установка отдельных свойств
        PropertyHelper.SetPropertyIfNull(settings, "Theme", "Dark");
        PropertyHelper.SetPropertyIfNull(settings, "Language", "Russian");

        Console.WriteLine("\nПосле установки отдельных свойств:");
        Console.WriteLine(settings);

        // Массовая установка
        PropertyHelper.SetPropertiesIfNull(settings,
            ("Theme", "Light"), // Не установится, так как уже есть значение
            ("FontSize", 14)
        );

        Console.WriteLine("\nПосле массовой установки:");
        Console.WriteLine(settings);
    }
}


87
using System;

class EventPublisher
{
    public event EventHandler<string> MessageReceived;

    public void SendMessage(string message)
    {
        // ?? для безопасного вызова события
        MessageReceived?.Invoke(this, message ?? "Сообщение не указано");
    }
}

class EventSubscriber
{
    private string _name;

    public EventSubscriber(string name)
    {
        _name = name ?? "Анонимный подписчик";
    }

    public void HandleMessage(object sender, string message)
    {
        Console.WriteLine($"[{_name}] Получено сообщение: {message}");
    }
}

class Program
{
    static void Main()
    {
        var publisher = new EventPublisher();
        var subscriber1 = new EventSubscriber("Первый");
        var subscriber2 = new EventSubscriber(null); // Будет "Анонимный подписчик"

        publisher.MessageReceived += subscriber1.HandleMessage;
        publisher.MessageReceived += subscriber2.HandleMessage;

        // Отправка сообщений (включая null)
        publisher.SendMessage("Привет!");
        publisher.SendMessage(null);
        publisher.SendMessage("Важное сообщение");
    }
}


88
using System;
using System.Collections.Generic;
using System.Linq;

class DataParser
{
    public static User ParseUser(Dictionary<string, object> data)
    {
        return new User
        {
            Name = (data.GetValueOrDefault("name") as string) ?? "Неизвестный",
            Age = (data.GetValueOrDefault("age") as int?) ?? 0,
            Email = (data.GetValueOrDefault("email") as string) ?? "Не указан",
            IsActive = (data.GetValueOrDefault("isActive") as bool?) ?? false
        };
    }

    public static List<string> ParseTags(object tags)
    {
        return (tags as List<string>) ?? new List<string> { "общий" };
    }
}

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
    public List<string> Tags { get; set; }

    public override string ToString() =>
        $"{Name} ({Age} лет) - {Email} [{(IsActive ? "Активен" : "Неактивен")}] Теги: {string.Join(", ", Tags)}";
}

class Program
{
    static void Main()
    {
        // Имитация данных из внешнего источника (JSON, XML и т.д.)
        var userData1 = new Dictionary<string, object>
        {
            ["name"] = "Иван",
            ["age"] = 25,
            ["email"] = "ivan@example.com",
            ["isActive"] = true,
            ["tags"] = new List<string> { "пользователь", "премиум" }
        };

        var userData2 = new Dictionary<string, object>
        {
            ["name"] = null, // Отсутствует имя
            ["age"] = null,  // Отсутствует возраст
            // email отсутствует полностью
            ["isActive"] = null,
            ["tags"] = null
        };

        // Разбор данных
        var user1 = DataParser.ParseUser(userData1);
        user1.Tags = DataParser.ParseTags(userData1["tags"]);

        var user2 = DataParser.ParseUser(userData2);
        user2.Tags = DataParser.ParseTags(userData2["tags"]);

        Console.WriteLine("Пользователь 1:");
        Console.WriteLine(user1);

        Console.WriteLine("\nПользователь 2 (с отсутствующими данными):");
        Console.WriteLine(user2);
    }
}


89
using System;

class Program
{
    static void Main()
    {
        Order order = null;
        Order validOrder = new Order
        {
            Customer = new User
            {
                Name = "Иван",
                Address = new Address { City = "Москва" }
            },
            Total = 1000
        };

        // Безопасная навигация по цепочке с ??
        string city1 = order?.Customer?.Address?.City ?? "Город не указан";
        string city2 = validOrder?.Customer?.Address?.City ?? "Город не указан";

        Console.WriteLine($"Город заказа 1: {city1}");
        Console.WriteLine($"Город заказа 2: {city2}");

        // Комбинирование с другими операциями
        decimal discount = validOrder?.Customer?.GetDiscount() ?? 0.1m;
        Console.WriteLine($"Скидка: {discount:P0}");

        // Сложная цепочка с преобразованием
        string orderInfo = validOrder?.Customer?.Name?.ToUpper() ?? "НЕТ ДАННЫХ";
        Console.WriteLine($"Информация о заказе: {orderInfo}");

        // Цепочка с методами
        string description = validOrder?.GetDescription() ?? "Описание недоступно";
        Console.WriteLine($"Описание: {description}");
    }
}

class Order
{
    public User Customer { get; set; }
    public decimal Total { get; set; }

    public string GetDescription() => $"Заказ на {Total} руб.";
}

class User
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public decimal GetDiscount() => 0.15m;
}

class Address
{
    public string City { get; set; }
    public string Street { get; set; }
}


90
using System;
using System.Collections.Generic;
using System.Linq;

class CollectionHelper
{
    public static List<T> SafeToList<T>(IEnumerable<T> collection)
    {
        return collection?.ToList() ?? new List<T>();
    }

    public static T[] SafeToArray<T>(IEnumerable<T> collection)
    {
        return collection?.ToArray() ?? Array.Empty<T>();
    }

    public static Dictionary<TKey, TValue> SafeToDictionary<TKey, TValue>(
        IEnumerable<KeyValuePair<TKey, TValue>> collection)
    {
        return collection?.ToDictionary(kv => kv.Key, kv => kv.Value)
               ?? new Dictionary<TKey, TValue>();
    }
}

class Program
{
    static void Main()
    {
        List<string> nullList = null;
        Dictionary<int, string> nullDict = null;

        // Безопасное преобразование коллекций
        var safeList = CollectionHelper.SafeToList(nullList);
        var safeArray = CollectionHelper.SafeToArray(nullList);
        var safeDict = CollectionHelper.SafeToDictionary(nullDict);

        Console.WriteLine($"Безопасный список: {string.Join(", ", safeList)}");
        Console.WriteLine($"Безопасный массив: {string.Join(", ", safeArray)}");
        Console.WriteLine($"Безопасный словарь: {safeDict.Count} элементов");

        // Практическое использование
        var data = GetDataFromSource() ?? new List<int> { 1, 2, 3 };
        Console.WriteLine($"Данные: {string.Join(", ", data)}");

        // ?? с методами коллекций
        int count = nullList?.Count ?? 0;
        bool anyItems = nullList?.Any() ?? false;

        Console.WriteLine($"Количество элементов: {count}");
        Console.WriteLine($"Есть элементы: {anyItems}");
    }

    static List<int> GetDataFromSource() => null;
}


91
using System;

class ParameterHelper
{
    // Метод с параметрами по умолчанию через ??
    public static string FormatMessage(string message, string prefix = null, string suffix = null)
    {
        prefix ??= "Сообщение: ";
        suffix ??= "!";

        return $"{prefix}{message}{suffix}";
    }

    // Метод с валидацией параметров
    public static void ProcessUser(string name, int? age, string email = null)
    {
        name ??= "Неизвестный";
        age ??= 0;
        email ??= "не указан";

        Console.WriteLine($"Пользователь: {name}, Возраст: {age}, Email: {email}");
    }

    // Метод с сложной логикой параметров
    public static void ConfigureService(
        string host = null,
        int? port = null,
        bool? useSsl = null,
        int timeout = 30)
    {
        host ??= "localhost";
        port ??= 8080;
        useSsl ??= false;

        Console.WriteLine($"Конфигурация сервиса:");
        Console.WriteLine($"  Хост: {host}");
        Console.WriteLine($"  Порт: {port}");
        Console.WriteLine($"  SSL: {useSsl}");
        Console.WriteLine($"  Таймаут: {timeout} сек.");
    }
}

class Program
{
    static void Main()
    {
        // Вызовы методов с разными комбинациями параметров
        ParameterHelper.ProcessUser("Иван", 25, "ivan@example.com");
        ParameterHelper.ProcessUser(null, null, null);
        ParameterHelper.ProcessUser("Петр", null);

        Console.WriteLine();

        ParameterHelper.FormatMessage("Привет");
        ParameterHelper.FormatMessage("Важно", "ВНИМАНИЕ: ", null);

        Console.WriteLine();

        ParameterHelper.ConfigureService();
        ParameterHelper.ConfigureService("example.com", 443, true);
        ParameterHelper.ConfigureService(port: 3000);
    }
}


92
using System;

class Program
{
    static void Main()
    {
        Action<string> nullAction = null;
        Action<string> validAction = msg => Console.WriteLine($"Действие: {msg}");

        Func<int, string> nullFunc = null;
        Func<int, string> validFunc = num => $"Число: {num}";

        // Безопасный вызов делегатов через ??
        nullAction?.Invoke("Тест"); // Не выполнится
        validAction?.Invoke("Тест"); // Выполнится

        // ?? с возвращаемым значением
        string result1 = nullFunc?.Invoke(42) ?? "Функция не задана";
        string result2 = validFunc?.Invoke(42) ?? "Функция не задана";

        Console.WriteLine($"Результат 1: {result1}");
        Console.WriteLine($"Результат 2: {result2}");

        // Комбинирование с событиями
        EventHandler<string> handler = null;
        handler?.Invoke(null, "Событие"); // Безопасный вызов

        // Практический пример с callback
        var processor = new DataProcessor();
        processor.ProcessData("Данные для обработки", result =>
            Console.WriteLine($"Результат обработки: {result ?? "Обработка не выполнена"}"));
    }
}

class DataProcessor
{
    public void ProcessData(string data, Func<string, string> callback = null)
    {
        // Обработка данных
        string result = data?.ToUpper();

        // Безопасный вызов callback
        callback?.Invoke(result);
    }
}


93
using System;
using System.Threading.Tasks;

class AsyncService
{
    public async Task<string> GetDataAsync(int? id)
    {
        // Имитация асинхронной операции
        await Task.Delay(100);

        return id?.ToString() ?? "ID не указан";
    }

    public async Task<int?> CalculateAsync(int? input)
    {
        await Task.Delay(50);
        return input * 2;
    }

    public async Task ProcessWithFallback(string data)
    {
        string actualData = data ?? await GetDefaultDataAsync();
        Console.WriteLine($"Обработка: {actualData}");
    }

    private async Task<string> GetDefaultDataAsync()
    {
        await Task.Delay(50);
        return "Данные по умолчанию";
    }
}

class Program
{
    static async Task Main()
    {
        var service = new AsyncService();

        // ?? с асинхронными результатами
        string result1 = await service.GetDataAsync(42) ?? "Нет данных";
        string result2 = await service.GetDataAsync(null) ?? "Нет данных";

        Console.WriteLine($"Результат 1: {result1}");
        Console.WriteLine($"Результат 2: {result2}");

        // ?? с nullable результатами
        int? calculation = await service.CalculateAsync(10) ?? 0;
        int? nullCalculation = await service.CalculateAsync(null) ?? 0;

        Console.WriteLine($"Расчет: {calculation}");
        Console.WriteLine($"Null расчет: {nullCalculation}");

        // Обработка с fallback
        await service.ProcessWithFallback("Мои данные");
        await service.ProcessWithFallback(null);
    }
}


94
using System;
using System.Collections.Generic;

class AppConfig
{
    private readonly Dictionary<string, string> _config;

    public AppConfig(Dictionary<string, string> config = null)
    {
        _config = config ?? new Dictionary<string, string>();
    }

    public string GetValue(string key, string defaultValue = null)
    {
        return _config.GetValueOrDefault(key) ?? defaultValue ?? "Значение не найдено";
    }

    public int GetIntValue(string key, int defaultValue = 0)
    {
        string value = _config.GetValueOrDefault(key);
        return int.TryParse(value, out int result) ? result : defaultValue;
    }

    public bool GetBoolValue(string key, bool defaultValue = false)
    {
        string value = _config.GetValueOrDefault(key);
        return bool.TryParse(value, out bool result) ? result : defaultValue;
    }
}

class Program
{
    static void Main()
    {
        // Конфигурация с некоторыми отсутствующими значениями
        var configData = new Dictionary<string, string>
        {
            ["AppName"] = "MyApp",
            ["Port"] = "8080",
            // ["Theme"] отсутствует
            ["DebugMode"] = "true"
        };

        var config = new AppConfig(configData);

        // Получение значений с fallback
        string appName = config.GetValue("AppName") ?? "DefaultApp";
        string theme = config.GetValue("Theme") ?? "Light";
        int port = config.GetIntValue("Port", 3000);
        bool debug = config.GetBoolValue("DebugMode", false);
        string missing = config.GetValue("MissingKey") ?? "Очень default";

        Console.WriteLine($"Конфигурация приложения:");
        Console.WriteLine($"  Имя: {appName}");
        Console.WriteLine($"  Тема: {theme}");
        Console.WriteLine($"  Порт: {port}");
        Console.WriteLine($"  Режим отладки: {debug}");
        Console.WriteLine($"  Отсутствующий ключ: {missing}");

        // Работа с пустой конфигурацией
        var emptyConfig = new AppConfig();
        string fromEmpty = emptyConfig.GetValue("AnyKey") ?? "Из пустой конфигурации";
        Console.WriteLine($"Из пустой конфигурации: {fromEmpty}");
    }
}


95
using System;
using System.Collections.Generic;
using System.Linq;

class GradeManager
{
    public static string GetGrade(int? score)
    {
        return (score ?? 0) switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
    }

    public static double CalculateGPA(List<int?> scores)
    {
        var validScores = scores.Select(s => s ?? 0).ToList();
        return validScores.Any() ? validScores.Average() : 0.0;
    }

    public static string GetStudentStatus(string name, int? score, bool? isActive)
    {
        name ??= "Неизвестный студент";
        int actualScore = score ?? 0;
        bool active = isActive ?? false;

        string status = active ? "Активен" : "Неактивен";
        string grade = GetGrade(actualScore);

        return $"{name} - {grade} ({actualScore} баллов) - {status}";
    }
}

class Program
{
    static void Main()
    {
        // Оценки студентов (некоторые отсутствуют)
        var students = new[]
        {
            new { Name = "Иван", Score = 85, IsActive = true },
            new { Name = "Петр", Score = (int?)null, IsActive = true },
            new { Name = "Мария", Score = 92, IsActive = (bool?)null },
            new { Name = (string)null, Score = 78, IsActive = false }
        };

        Console.WriteLine("Статусы студентов:");
        foreach (var student in students)
        {
            string status = GradeManager.GetStudentStatus(
                student.Name,
                student.Score,
                student.IsActive
            );
            Console.WriteLine($"  {status}");
        }

        // Расчет GPA
        var scores = students.Select(s => s.Score).ToList();
        double gpa = GradeManager.CalculateGPA(scores);
        Console.WriteLine($"\nСредний GPA: {gpa:F2}");

        // Получение отдельных оценок
        Console.WriteLine("\nОценки:");
        foreach (var student in students)
        {
            string grade = GradeManager.GetGrade(student.Score);
            Console.WriteLine($"  {student.Name ?? "Без имени"}: {grade}");
        }
    }
}


96
using System;
using System.Collections.Generic;
using System.Linq;

class CollectionHelper
{
    // Преобразование null в пустую коллекцию для IEnumerable
    public static IEnumerable<T> NullToEmpty<T>(IEnumerable<T> collection)
    {
        return collection ?? Enumerable.Empty<T>();
    }

    // Преобразование null в пустую коллекцию для List
    public static List<T> NullToEmptyList<T>(List<T> list)
    {
        return list ?? new List<T>();
    }

    // Преобразование null в пустую коллекцию для Dictionary
    public static Dictionary<TKey, TValue> NullToEmptyDictionary<TKey, TValue>(
        Dictionary<TKey, TValue> dictionary)
    {
        return dictionary ?? new Dictionary<TKey, TValue>();
    }

    // Универсальный метод для любого типа коллекции
    public static TCollection NullToEmptyCollection<TCollection, TItem>(
        TCollection collection,
        Func<TCollection> emptyFactory)
        where TCollection : class, IEnumerable<TItem>
    {
        return collection ?? emptyFactory();
    }
}

class Program
{
    static void Main()
    {
        List<string> nullList = null;
        Dictionary<int, string> nullDict = null;
        string[] nullArray = null;

        // Преобразование null коллекций в пустые
        var safeList = CollectionHelper.NullToEmptyList(nullList);
        var safeDict = CollectionHelper.NullToEmptyDictionary(nullDict);
        var safeEnumerable = CollectionHelper.NullToEmpty(nullArray);
        var safeArray = CollectionHelper.NullToEmptyCollection<string[], string>(
            nullArray, () => Array.Empty<string>());

        Console.WriteLine($"Пустой список: {safeList.Count} элементов");
        Console.WriteLine($"Пустой словарь: {safeDict.Count} элементов");
        Console.WriteLine($"Пустая enumerable: {safeEnumerable.Count()} элементов");
        Console.WriteLine($"Пустой массив: {safeArray.Length} элементов");

        // Практическое использование
        ProcessItems(nullList);
        ProcessItems(new List<string> { "A", "B", "C" });

        // Использование в LINQ
        var result = (nullList ?? new List<string>())
            .Where(x => x?.Length > 0)
            .Select(x => x.ToUpper())
            .ToList();

        Console.WriteLine($"Результат LINQ: {string.Join(", ", result)}");
    }

    static void ProcessItems(List<string> items)
    {
        var safeItems = items ?? new List<string>();
        Console.WriteLine($"Обработка {safeItems.Count} элементов");
    }
}


97
using System;
using System.Collections.Generic;

class MessageLogger
{
    private List<string> _messages = new List<string>();

    // Регистрация сообщения с обработкой null
    public void Log(string message, string category = null)
    {
        string safeMessage = message ?? "Сообщение не указано";
        string safeCategory = category ?? "Общее";

        string logEntry = $"[{DateTime.Now:HH:mm:ss}] [{safeCategory}] {safeMessage}";
        _messages.Add(logEntry);

        Console.WriteLine(logEntry);
    }

    // Регистрация с проверкой условия
    public void LogIf(bool condition, string message, string fallbackMessage = null)
    {
        if (condition)
        {
            Log(message ?? "Условное сообщение");
        }
        else
        {
            Log(fallbackMessage ?? "Условие не выполнено");
        }
    }

    // Регистрация с преобразованием
    public void LogObject<T>(T obj, Func<T, string> formatter = null)
    {
        string message = formatter?.Invoke(obj)
            ?? obj?.ToString()
            ?? "Объект не задан";

        Log(message, "Объект");
    }

    // Получение всех сообщений
    public void PrintAllMessages()
    {
        Console.WriteLine("\nВсе зарегистрированные сообщения:");
        foreach (var msg in _messages)
        {
            Console.WriteLine($"  {msg}");
        }
    }
}

class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString() => $"{Name} ({Email})";
}

class Program
{
    static void Main()
    {
        var logger = new MessageLogger();

        // Регистрация различных сообщений
        logger.Log("Приложение запущено", "Система");
        logger.Log(null, "Ошибка"); // Null сообщение
        logger.Log("Успешное завершение", null); // Null категория

        // Условная регистрация
        logger.LogIf(true, "Условие выполнено");
        logger.LogIf(false, null, "Резервное сообщение");

        // Регистрация объектов
        var user = new User { Name = "Иван", Email = "ivan@example.com" };
        logger.LogObject(user);
        logger.LogObject(user, u => $"Пользователь: {u.Name}");
        logger.LogObject<User>(null); // Null объект

        // Регистрация с цепочкой ??
        string externalMessage = GetExternalMessage();
        logger.Log(externalMessage ?? "Внешний источник не вернул сообщение", "Внешний");

        logger.PrintAllMessages();
    }

    static string GetExternalMessage() => null;
}


98
using System;
using System.Collections.Generic;
using System.Linq;

// Имитация классов для работы с БД
class DatabaseContext
{
    public List<User> Users { get; set; }
    public List<Order> Orders { get; set; }

    public DatabaseContext()
    {
        // Имитация данных из БД (некоторые могут быть null)
        Users = new List<User>
        {
            new User { Id = 1, Name = "Иван", Email = "ivan@example.com" },
            new User { Id = 2, Name = null, Email = "petr@example.com" },
            new User { Id = 3, Name = "Мария", Email = null }
        };

        Orders = new List<Order>
        {
            new Order { Id = 1, UserId = 1, Total = 1000, Description = "Первый заказ" },
            new Order { Id = 2, UserId = 1, Total = null, Description = null },
            new Order { Id = 3, UserId = 999, Total = 500, Description = "Заказ несуществующего пользователя" }
        };
    }
}

class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public decimal? Total { get; set; }
    public string Description { get; set; }
}

class Repository
{
    private DatabaseContext _context = new DatabaseContext();

    // Поиск пользователя с обработкой null
    public string GetUserName(int userId)
    {
        var user = _context.Users.FirstOrDefault(u => u.Id == userId);
        return user?.Name ?? "Пользователь не найден";
    }

    // Получение заказов с безопасным доступом к свойствам
    public List<string> GetOrderDescriptions(int userId)
    {
        return _context.Orders
            .Where(o => o.UserId == userId)
            .Select(o => o.Description ?? "Описание отсутствует")
            .ToList();
    }

    // Расчет общей суммы заказов
    public decimal GetUserTotalSpent(int userId)
    {
        return _context.Orders
            .Where(o => o.UserId == userId)
            .Sum(o => o.Total ?? 0);
    }

    // Получение информации о пользователе
    public string GetUserInfo(int userId)
    {
        var user = _context.Users.FirstOrDefault(u => u.Id == userId);

        if (user == null)
            return "Пользователь не найден";

        string name = user.Name ?? "Имя не указано";
        string email = user.Email ?? "Email не указан";

        return $"{name} ({email})";
    }

    // Безопасное соединение таблиц
    public List<string> GetOrdersWithUsers()
    {
        return (from order in _context.Orders
                join user in _context.Users on order.UserId equals user.Id into userGroup
                from user in userGroup.DefaultIfEmpty()
                select $"Заказ #{order.Id}: {order.Description ?? "Без описания"} - " +
                       $"Пользователь: {user?.Name ?? "Неизвестный"}")
               .ToList();
    }
}

class Program
{
    static void Main()
    {
        var repository = new Repository();

        Console.WriteLine("=== Работа с базой данных ===\n");

        // Поиск пользователей
        Console.WriteLine("Имена пользователей:");
        for (int i = 1; i <= 4; i++)
        {
            string name = repository.GetUserName(i);
            Console.WriteLine($"  ID {i}: {name}");
        }

        // Описания заказов
        Console.WriteLine("\nОписания заказов пользователя 1:");
        var descriptions = repository.GetOrderDescriptions(1);
        foreach (var desc in descriptions)
        {
            Console.WriteLine($"  - {desc}");
        }

        // Общая сумма
        Console.WriteLine($"\nОбщая сумма заказов пользователя 1: {repository.GetUserTotalSpent(1):C}");

        // Информация о пользователях
        Console.WriteLine("\nИнформация о пользователях:");
        for (int i = 1; i <= 4; i++)
        {
            string info = repository.GetUserInfo(i);
            Console.WriteLine($"  ID {i}: {info}");
        }

        // Соединение таблиц
        Console.WriteLine("\nЗаказы с пользователями:");
        var ordersWithUsers = repository.GetOrdersWithUsers();
        foreach (var orderInfo in ordersWithUsers)
        {
            Console.WriteLine($"  {orderInfo}");
        }
    }
}


99
using System;
using System.Collections.Generic;

class SmartConstructorExample
{
    class Product
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public List<string> Tags { get; }

        // Конструктор с обработкой null значений
        public Product(string name, string description = null, decimal? price = null, List<string> tags = null)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? "Описание отсутствует";
            Price = price ?? 0;
            Tags = tags ?? new List<string> { "общий" };
        }

        public override string ToString()
        {
            return $"{Name} - {Description} - {Price:C} [Теги: {string.Join(", ", Tags)}]";
        }
    }

    class User
    {
        public string Username { get; }
        public string Email { get; }
        public DateTime? CreatedAt { get; }

        // Конструктор с цепочкой ??
        public User(string username, string email = null, DateTime? createdAt = null)
        {
            Username = username ?? "guest_" + Guid.NewGuid().ToString()[..8];
            Email = email ?? $"{Username}@example.com";
            CreatedAt = createdAt ?? DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Username} ({Email}) - создан: {CreatedAt:dd.MM.yyyy}";
        }
    }

    class Configuration
    {
        public string AppName { get; }
        public string Environment { get; }
        public int? Port { get; }
        public bool? UseHttps { get; }

        // Конструктор с комплексной обработкой null
        public Configuration(
            string appName = null,
            string environment = null,
            int? port = null,
            bool? useHttps = null)
        {
            AppName = appName ?? GetDefaultAppName();
            Environment = environment ?? GetDefaultEnvironment();
            Port = port ?? GetDefaultPort();
            UseHttps = useHttps ?? GetDefaultUseHttps();
        }

        private string GetDefaultAppName() => "MyApplication";
        private string GetDefaultEnvironment() => "Development";
        private int GetDefaultPort() => 3000;
        private bool GetDefaultUseHttps() => false;

        public override string ToString()
        {
            return $"App: {AppName}, Env: {Environment}, Port: {Port}, HTTPS: {UseHttps}";
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Конструкторы с обработкой null ===\n");

        // Создание продуктов
        var product1 = new SmartConstructorExample.Product(
            "Ноутбук",
            "Игровой ноутбук",
            1500m,
            new List<string> { "электроника", "техника" });

        var product2 = new SmartConstructorExample.Product(
            "Мышь",
            null, // null описание
            null, // null цена
            null); // null теги

        Console.WriteLine("Продукты:");
        Console.WriteLine($"  {product1}");
        Console.WriteLine($"  {product2}");

        // Создание пользователей
        var user1 = new SmartConstructorExample.User("ivan", "ivan@example.com");
        var user2 = new SmartConstructorExample.User(null, null); // Все параметры null
        var user3 = new SmartConstructorExample.User("petr"); // Только имя

        Console.WriteLine("\nПользователи:");
        Console.WriteLine($"  {user1}");
        Console.WriteLine($"  {user2}");
        Console.WriteLine($"  {user3}");

        // Создание конфигураций
        var config1 = new SmartConstructorExample.Configuration("MyApp", "Production", 443, true);
        var config2 = new SmartConstructorExample.Configuration(); // Все параметры по умолчанию
        var config3 = new SmartConstructorExample.Configuration(null, "Staging"); // Частичные параметры

        Console.WriteLine("\nКонфигурации:");
        Console.WriteLine($"  {config1}");
        Console.WriteLine($"  {config2}");
        Console.WriteLine($"  {config3}");

        // Демонстрация исключения
        try
        {
            var invalidProduct = new SmartConstructorExample.Product(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"\nОшибка создания продукта: {ex.ParamName} не может быть null");
        }
    }
}


100
using System;
using System.Collections.Generic;

class ValidationHelper
{
    // Валидация и установка значения с fallback
    public static T ValidateAndSet<T>(T? value, T defaultValue, Func<T, bool> validator = null)
        where T : struct
    {
        if (!value.HasValue)
            return defaultValue;

        if (validator != null && !validator(value.Value))
            return defaultValue;

        return value.Value;
    }

    // Валидация строки
    public static string ValidateString(string value, string defaultValue, Func<string, bool> validator = null)
    {
        if (string.IsNullOrWhiteSpace(value))
            return defaultValue ?? "Не указано";

        if (validator != null && !validator(value))
            return defaultValue ?? "Невалидное значение";

        return value;
    }

    // Валидация коллекции
    public static List<T> ValidateCollection<T>(List<T> collection, List<T> defaultCollection = null)
    {
        return collection?.Count > 0 ? collection : defaultCollection ?? new List<T>();
    }

    // Комплексная валидация объекта
    public static User ValidateUser(User user, User defaultUser = null)
    {
        if (user == null)
            return defaultUser ?? new User { Name = "Гость", Age = 0 };

        user.Name = ValidateString(user.Name, "Неизвестный", name => name.Length >= 2);
        user.Age = ValidateAndSet(user.Age, 0, age => age >= 0 && age <= 150);
        user.Email = ValidateString(user.Email, "не указан", email => email.Contains("@"));

        return user;
    }

    // Валидация с преобразованием
    public static TResult ValidateAndConvert<T, TResult>(
        T? value,
        Func<T, TResult> converter,
        TResult defaultValue,
        Func<T, bool> validator = null)
        where T : struct
    {
        if (!value.HasValue)
            return defaultValue;

        if (validator != null && !validator(value.Value))
            return defaultValue;

        try
        {
            return converter(value.Value);
        }
        catch
        {
            return defaultValue;
        }
    }
}

class User
{
    public string Name { get; set; }
    public int? Age { get; set; }
    public string Email { get; set; }
    public List<string> Roles { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Age} лет) - {Email} [Роли: {string.Join(", ", Roles ?? new List<string>())}]";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Валидация и установка результатов ===\n");

        // Валидация простых значений
        int? score = null;
        int? negativeScore = -5;
        int? validScore = 85;

        int safeScore1 = ValidationHelper.ValidateAndSet(score, 0, s => s >= 0 && s <= 100);
        int safeScore2 = ValidationHelper.ValidateAndSet(negativeScore, 0, s => s >= 0 && s <= 100);
        int safeScore3 = ValidationHelper.ValidateAndSet(validScore, 0, s => s >= 0 && s <= 100);

        Console.WriteLine("Валидация оценок:");
        Console.WriteLine($"  null -> {safeScore1}");
        Console.WriteLine($"  -5 -> {safeScore2}");
        Console.WriteLine($"  85 -> {safeScore3}");

        // Валидация строк
        string nullString = null;
        string emptyString = "";
        string shortString = "A";
        string validString = "Иван";

        string safeString1 = ValidationHelper.ValidateString(nullString, "По умолчанию");
        string safeString2 = ValidationHelper.ValidateString(emptyString, "По умолчанию");
        string safeString3 = ValidationHelper.ValidateString(shortString, "По умолчанию", s => s.Length >= 2);
        string safeString4 = ValidationHelper.ValidateString(validString, "По умолчанию", s => s.Length >= 2);

        Console.WriteLine("\nВалидация строк:");
        Console.WriteLine($"  null -> '{safeString1}'");
        Console.WriteLine($"  empty -> '{safeString2}'");
        Console.WriteLine($"  'A' -> '{safeString3}'");
        Console.WriteLine($"  'Иван' -> '{safeString4}'");

        // Валидация пользователей
        var invalidUser = new User { Name = "A", Age = -5, Email = "invalid", Roles = null };
        var nullUser = (User)null;
        var validUser = new User { Name = "Мария", Age = 25, Email = "maria@example.com", Roles = new List<string> { "admin" } };

        var safeUser1 = ValidationHelper.ValidateUser(invalidUser);
        var safeUser2 = ValidationHelper.ValidateUser(nullUser);
        var safeUser3 = ValidationHelper.ValidateUser(validUser);

        Console.WriteLine("\nВалидация пользователей:");
        Console.WriteLine($"  Невалидный -> {safeUser1}");
        Console.WriteLine($"  Null -> {safeUser2}");
        Console.WriteLine($"  Валидный -> {safeUser3}");

        // Валидация с преобразованием
        string numberString = "42";
        string invalidNumberString = "abc";
        string nullNumberString = null;

        int converted1 = ValidationHelper.ValidateAndConvert(
            numberString != null ? int.Parse(numberString) : (int?)null,
            x => x * 2,
            0,
            x => x > 0
        );

        int converted2 = ValidationHelper.ValidateAndConvert(
            invalidNumberString != null ? int.Parse(invalidNumberString) : (int?)null,
            x => x * 2,
            -1,
            x => x > 0
        );

        Console.WriteLine("\nВалидация с преобразованием:");
        Console.WriteLine($"  '42' -> {converted1}");
        Console.WriteLine($"  'abc' -> {converted2}");
    }
}