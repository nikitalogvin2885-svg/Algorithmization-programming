//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Collections.Immutable;
//using System.Diagnostics;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Text.Json;
//using System.Text.RegularExpressions;

////1.1: Динамическое программирование - Задача рюкзаке (0/1 Рюкзак)
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Text;

//public class Knapsack01
//{
//    public static (int maxValue, List<int> items) Solve(int[] weights, int[] values, int capacity)
//    {
//        int n = weights.Length;
//        int[,] dp = new int[n + 1, capacity + 1];

//        // Заполнение таблицы dp
//        for (int i = 1; i <= n; i++)
//        {
//            for (int w = 1; w <= capacity; w++)
//            {
//                if (weights[i - 1] <= w)
//                {
//                    dp[i, w] = Math.Max(dp[i - 1, w], dp[i - 1, w - weights[i - 1]] + values[i - 1]);
//                }
//                else
//                {
//                    dp[i, w] = dp[i - 1, w];
//                }
//            }
//        }

//        // Восстановление выбранных предметов
//        int wRemaining = capacity;
//        List<int> items = new List<int>();
//        for (int i = n; i > 0; i--)
//        {
//            if (dp[i, wRemaining] != dp[i - 1, wRemaining])
//            {
//                items.Add(i - 1);
//                wRemaining -= weights[i - 1];
//            }
//        }

//        return (dp[n, capacity], items);
//    }
//}


//using System;
//using System.Collections.Generic;

//public class KnapsackBounded
//{
//    public static (int maxValue, List<(int item, int count)> items) Solve(
//        int[] weights, int[] values, int[] counts, int capacity)
//    {
//        int n = weights.Length;
//        int[] dp = new int[capacity + 1];

//        // Заполнение массива dp
//        for (int i = 0; i < n; i++)
//        {
//            for (int w = capacity; w >= weights[i]; w--)
//            {
//                for (int k = 1; k <= counts[i]; k++)
//                {
//                    if (w >= k * weights[i])
//                    {
//                        dp[w] = Math.Max(dp[w], dp[w - k * weights[i]] + k * values[i]);
//                    }
//                }
//            }
//        }

//        // Восстановление выбранных предметов
//        int wRemaining = capacity;
//        List<(int item, int count)> items = new List<(int, int)>();
//        for (int i = n - 1; i >= 0; i--)
//        {
//            int k = Math.Min(counts[i], wRemaining / weights[i]);
//            while (k > 0 && dp[wRemaining] == dp[wRemaining - k * weights[i]] + k * values[i])
//            {
//                items.Add((i, k));
//                wRemaining -= k * weights[i];
//                break;
//            }
//        }

//        return (dp[capacity], items);
//    }
//}


//using System;
//using System.Collections.Generic;

//public class KnapsackUnbounded
//{
//    public static (int maxValue, List<int> items) Solve(int[] weights, int[] values, int capacity)
//    {
//        int n = weights.Length;
//        int[] dp = new int[capacity + 1];

//        // Заполнение массива dp
//        for (int w = 1; w <= capacity; w++)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                if (weights[i] <= w)
//                {
//                    dp[w] = Math.Max(dp[w], dp[w - weights[i]] + values[i]);
//                }
//            }
//        }

//        // Восстановление выбранных предметов
//        int wRemaining = capacity;
//        List<int> items = new List<int>();
//        while (wRemaining > 0)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                if (wRemaining >= weights[i] && dp[wRemaining] == dp[wRemaining - weights[i]] + values[i])
//                {
//                    items.Add(i);
//                    wRemaining -= weights[i];
//                    break;
//                }
//            }
//        }

//        return (dp[capacity], items);
//    }
//}


//using System;
//using System.Collections.Generic;

//public class Knapsack01Optimized
//{
//    public static (int maxValue, List<int> items) Solve(int[] weights, int[] values, int capacity)
//    {
//        int n = weights.Length;
//        int[] dp = new int[capacity + 1];

//        // Заполнение массива dp
//        for (int i = 0; i < n; i++)
//        {
//            for (int w = capacity; w >= weights[i]; w--)
//            {
//                dp[w] = Math.Max(dp[w], dp[w - weights[i]] + values[i]);
//            }
//        }

//        // Восстановление выбранных предметов
//        int wRemaining = capacity;
//        List<int> items = new List<int>();
//        for (int i = n - 1; i >= 0; i--)
//        {
//            if (dp[wRemaining] != dp[wRemaining - weights[i]] + values[i])
//                continue;
//            items.Add(i);
//            wRemaining -= weights[i];
//        }

//        return (dp[capacity], items);
//    }
//}

////Пример использования
//class Program
//{
//    static void Main()
//    {
//        int[] weights = { 2, 3, 4, 5 };
//        int[] values = { 3, 4, 5, 6 };
//        int capacity = 5;

//        // 0/1 Рюкзак
//        var (maxValue01, items01) = Knapsack01.Solve(weights, values, capacity);
//        Console.WriteLine($"0/1 Рюкзак: maxValue = {maxValue01}, items = [{string.Join(", ", items01)}]");

//        // Ограниченный рюкзак
//        int[] counts = { 1, 1, 1, 1 };
//        var (maxValueBounded, itemsBounded) = KnapsackBounded.Solve(weights, values, counts, capacity);
//        Console.WriteLine($"Ограниченный рюкзак: maxValue = {maxValueBounded}, items = [{string.Join(", ", itemsBounded.Select(x => $"{x.item}({x.count})"))}]");

//        // Неограниченный рюкзак
//        var (maxValueUnbounded, itemsUnbounded) = KnapsackUnbounded.Solve(weights, values, capacity);
//        Console.WriteLine($"Неограниченный рюкзак: maxValue = {maxValueUnbounded}, items = [{string.Join(", ", itemsUnbounded)}]");

//        // Оптимизированное решение для 0/1 рюкзака
//        var (maxValueOptimized, itemsOptimized) = Knapsack01Optimized.Solve(weights, values, capacity);
//        Console.WriteLine($"Оптимизированное 0/1: maxValue = {maxValueOptimized}, items = [{string.Join(", ", itemsOptimized)}]");
//    }
//}


////1.2: Дерево сегментов(Дерево сегментов) с ленивым распространением
//using System;
//using System.Collections.Generic;

//// Узел дерева отрезков
//public class SegmentTreeNode<T>
//{
//    public int Left { get; set; }
//    public int Right { get; set; }
//    public T Sum { get; set; }
//    public T Min { get; set; }
//    public T Max { get; set; }
//    public T Lazy { get; set; } // Ленивое обновление
//    public SegmentTreeNode<T> LeftChild { get; set; }
//    public SegmentTreeNode<T> RightChild { get; set; }

//    public SegmentTreeNode(int left, int right)
//    {
//        Left = left;
//        Right = right;
//    }
//}

//// Дерево отрезков с ленивым распространением
//public class SegmentTree<T> where T : struct, IComparable<T>
//{
//    private readonly Func<T, T, T> _addOperation;
//    private readonly T _defaultValue;
//    private readonly SegmentTreeNode<T> _root;

//    public SegmentTree(T[] array, Func<T, T, T> addOperation, T defaultValue)
//    {
//        _addOperation = addOperation;
//        _defaultValue = defaultValue;
//        _root = Build(array, 0, array.Length - 1);
//    }

//    // Построение дерева
//    private SegmentTreeNode<T> Build(T[] array, int left, int right)
//    {
//        var node = new SegmentTreeNode<T>(left, right);
//        if (left == right)
//        {
//            node.Sum = node.Min = node.Max = array[left];
//            return node;
//        }

//        int mid = (left + right) / 2;
//        node.LeftChild = Build(array, left, mid);
//        node.RightChild = Build(array, mid + 1, right);

//        node.Sum = _addOperation(node.LeftChild.Sum, node.RightChild.Sum);
//        node.Min = Comparer<T>.Default.Compare(node.LeftChild.Min, node.RightChild.Min) <= 0
//            ? node.LeftChild.Min : node.RightChild.Min;
//        node.Max = Comparer<T>.Default.Compare(node.LeftChild.Max, node.RightChild.Max) >= 0
//            ? node.LeftChild.Max : node.RightChild.Max;

//        return node;
//    }

//    // Ленивое распространение
//    private void PushLazy(SegmentTreeNode<T> node)
//    {
//        if (!EqualityComparer<T>.Default.Equals(node.Lazy, _defaultValue))
//        {
//            // Применяем ленивое обновление к текущему узлу
//            node.Sum = _addOperation(node.Sum, node.Lazy);
//            node.Min = _addOperation(node.Min, node.Lazy);
//            node.Max = _addOperation(node.Max, node.Lazy);

//            // Если это не лист, передаем ленивое обновление детям
//            if (node.LeftChild != null)
//            {
//                node.LeftChild.Lazy = _addOperation(node.LeftChild.Lazy, node.Lazy);
//                node.RightChild.Lazy = _addOperation(node.RightChild.Lazy, node.Lazy);
//            }

//            // Сбрасываем ленивое обновление
//            node.Lazy = _defaultValue;
//        }
//    }

//    // Обновление на отрезке
//    public void UpdateRange(int l, int r, T value)
//    {
//        UpdateRange(_root, l, r, value);
//    }

//    private void UpdateRange(SegmentTreeNode<T> node, int l, int r, T value)
//    {
//        PushLazy(node);

//        if (node.Right < l || node.Left > r)
//            return;

//        if (l <= node.Left && node.Right <= r)
//        {
//            node.Lazy = _addOperation(node.Lazy, value);
//            PushLazy(node);
//            return;
//        }

//        UpdateRange(node.LeftChild, l, r, value);
//        UpdateRange(node.RightChild, l, r, value);

//        node.Sum = _addOperation(node.LeftChild.Sum, node.RightChild.Sum);
//        node.Min = Comparer<T>.Default.Compare(node.LeftChild.Min, node.RightChild.Min) <= 0
//            ? node.LeftChild.Min : node.RightChild.Min;
//        node.Max = Comparer<T>.Default.Compare(node.LeftChild.Max, node.RightChild.Max) >= 0
//            ? node.LeftChild.Max : node.RightChild.Max;
//    }

//    // Запрос суммы на отрезке
//    public T QuerySum(int l, int r)
//    {
//        return Query(_root, l, r, (node) => node.Sum);
//    }

//    // Запрос минимума на отрезке
//    public T QueryMin(int l, int r)
//    {
//        return Query(_root, l, r, (node) => node.Min);
//    }

//    // Запрос максимума на отрезке
//    public T QueryMax(int l, int r)
//    {
//        return Query(_root, l, r, (node) => node.Max);
//    }

//    private T Query(SegmentTreeNode<T> node, int l, int r, Func<SegmentTreeNode<T>, T> selector)
//    {
//        PushLazy(node);

//        if (node.Right < l || node.Left > r)
//            return _defaultValue;

//        if (l <= node.Left && node.Right <= r)
//            return selector(node);

//        T leftValue = Query(node.LeftChild, l, r, selector);
//        T rightValue = Query(node.RightChild, l, r, selector);

//        return _addOperation(leftValue, rightValue);
//    }
//}


//// Узел персистентного дерева отрезков
//public class PersistentSegmentTreeNode<T>
//{
//    public int Left { get; set; }
//    public int Right { get; set; }
//    public T Sum { get; set; }
//    public T Min { get; set; }
//    public T Max { get; set; }
//    public T Lazy { get; set; }
//    public PersistentSegmentTreeNode<T> LeftChild { get; set; }
//    public PersistentSegmentTreeNode<T> RightChild { get; set; }

//    public PersistentSegmentTreeNode(int left, int right)
//    {
//        Left = left;
//        Right = right;
//    }
//}

//// Персистентное дерево отрезков
//public class PersistentSegmentTree<T> where T : struct, IComparable<T>
//{
//    private readonly Func<T, T, T> _addOperation;
//    private readonly T _defaultValue;
//    private readonly List<PersistentSegmentTreeNode<T>> _roots = new List<PersistentSegmentTreeNode<T>>();

//    public PersistentSegmentTree(T[] array, Func<T, T, T> addOperation, T defaultValue)
//    {
//        _addOperation = addOperation;
//        _defaultValue = defaultValue;
//        _roots.Add(Build(array, 0, array.Length - 1));
//    }

//    // Построение дерева
//    private PersistentSegmentTreeNode<T> Build(T[] array, int left, int right)
//    {
//        var node = new PersistentSegmentTreeNode<T>(left, right);
//        if (left == right)
//        {
//            node.Sum = node.Min = node.Max = array[left];
//            return node;
//        }

//        int mid = (left + right) / 2;
//        node.LeftChild = Build(array, left, mid);
//        node.RightChild = Build(array, mid + 1, right);

//        node.Sum = _addOperation(node.LeftChild.Sum, node.RightChild.Sum);
//        node.Min = Comparer<T>.Default.Compare(node.LeftChild.Min, node.RightChild.Min) <= 0
//            ? node.LeftChild.Min : node.RightChild.Min;
//        node.Max = Comparer<T>.Default.Compare(node.LeftChild.Max, node.RightChild.Max) >= 0
//            ? node.LeftChild.Max : node.RightChild.Max;

//        return node;
//    }

//    // Создание новой версии после обновления
//    public void UpdateRange(int l, int r, T value)
//    {
//        _roots.Add(UpdateRange(_roots[^1], l, r, value));
//    }

//    private PersistentSegmentTreeNode<T> UpdateRange(PersistentSegmentTreeNode<T> node, int l, int r, T value)
//    {
//        var newNode = new PersistentSegmentTreeNode<T>(node.Left, node.Right)
//        {
//            Sum = node.Sum,
//            Min = node.Min,
//            Max = node.Max,
//            Lazy = node.Lazy,
//            LeftChild = node.LeftChild,
//            RightChild = node.RightChild
//        };

//        PushLazy(newNode);

//        if (newNode.Right < l || newNode.Left > r)
//            return newNode;

//        if (l <= newNode.Left && newNode.Right <= r)
//        {
//            newNode.Lazy = _addOperation(newNode.Lazy, value);
//            PushLazy(newNode);
//            return newNode;
//        }

//        newNode.LeftChild = UpdateRange(newNode.LeftChild, l, r, value);
//        newNode.RightChild = UpdateRange(newNode.RightChild, l, r, value);

//        newNode.Sum = _addOperation(newNode.LeftChild.Sum, newNode.RightChild.Sum);
//        newNode.Min = Comparer<T>.Default.Compare(newNode.LeftChild.Min, newNode.RightChild.Min) <= 0
//            ? newNode.LeftChild.Min : newNode.RightChild.Min;
//        newNode.Max = Comparer<T>.Default.Compare(newNode.LeftChild.Max, newNode.RightChild.Max) >= 0
//            ? newNode.LeftChild.Max : newNode.RightChild.Max;

//        return newNode;
//    }

//    // Ленивое распространение
//    private void PushLazy(PersistentSegmentTreeNode<T> node)
//    {
//        if (!EqualityComparer<T>.Default.Equals(node.Lazy, _defaultValue))
//        {
//            node.Sum = _addOperation(node.Sum, node.Lazy);
//            node.Min = _addOperation(node.Min, node.Lazy);
//            node.Max = _addOperation(node.Max, node.Lazy);

//            if (node.LeftChild != null)
//            {
//                node.LeftChild = new PersistentSegmentTreeNode<T>(node.LeftChild.Left, node.LeftChild.Right)
//                {
//                    Sum = node.LeftChild.Sum,
//                    Min = node.LeftChild.Min,
//                    Max = node.LeftChild.Max,
//                    Lazy = _addOperation(node.LeftChild.Lazy, node.Lazy),
//                    LeftChild = node.LeftChild.LeftChild,
//                    RightChild = node.LeftChild.RightChild
//                };

//                node.RightChild = new PersistentSegmentTreeNode<T>(node.RightChild.Left, node.RightChild.Right)
//                {
//                    Sum = node.RightChild.Sum,
//                    Min = node.RightChild.Min,
//                    Max = node.RightChild.Max,
//                    Lazy = _addOperation(node.RightChild.Lazy, node.Lazy),
//                    LeftChild = node.RightChild.LeftChild,
//                    RightChild = node.RightChild.RightChild
//                };
//            }

//            node.Lazy = _defaultValue;
//        }
//    }

//    // Запрос на версии `version`
//    public T QuerySum(int version, int l, int r)
//    {
//        return Query(_roots[version], l, r, (node) => node.Sum);
//    }

//    public T QueryMin(int version, int l, int r)
//    {
//        return Query(_roots[version], l, r, (node) => node.Min);
//    }

//    public T QueryMax(int version, int l, int r)
//    {
//        return Query(_roots[version], l, r, (node) => node.Max);
//    }

//    private T Query(PersistentSegmentTreeNode<T> node, int l, int r, Func<PersistentSegmentTreeNode<T>, T> selector)
//    {
//        PushLazy(node);

//        if (node.Right < l || node.Left > r)
//            return _defaultValue;

//        if (l <= node.Left && node.Right <= r)
//            return selector(node);

//        T leftValue = Query(node.LeftChild, l, r, selector);
//        T rightValue = Query(node.RightChild, l, r, selector);

//        return _addOperation(leftValue, rightValue);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 1, 3, 5, 7, 9, 11 };
//        var segmentTree = new SegmentTree<int>(
//            array,
//            (a, b) => a + b, // Операция сложения
//            0                // Нейтральный элемент
//        );

//        // Примеры запросов
//        Console.WriteLine("Сумма на [1, 3]: " + segmentTree.QuerySum(1, 3));
//        Console.WriteLine("Минимум на [2, 4]: " + segmentTree.QueryMin(2, 4));
//        Console.WriteLine("Максимум на [0, 5]: " + segmentTree.QueryMax(0, 5));

//        // Обновление на отрезке
//        segmentTree.UpdateRange(1, 3, 2);
//        Console.WriteLine("Сумма на [1, 3] после обновления: " + segmentTree.QuerySum(1, 3));

//        // Персистентное дерево
//        var persistentTree = new PersistentSegmentTree<int>(
//            array,
//            (a, b) => a + b,
//            0
//        );

//        // Создаем новую версию
//        persistentTree.UpdateRange(1, 3, 2);
//        Console.WriteLine("Сумма на [1, 3] в версии 1: " + persistentTree.QuerySum(1, 1, 3));
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int n = 1_000_000;
//        int[] array = new int[n];
//        Random random = new Random();
//        for (int i = 0; i < n; i++)
//            array[i] = random.Next(1, 100);

//        var segmentTree = new SegmentTree<int>(
//            array,
//            (a, b) => a + b,
//            0
//        );

//        Stopwatch stopwatch = Stopwatch.StartNew();
//        int sum = segmentTree.QuerySum(0, n - 1);
//        stopwatch.Stop();

//        Console.WriteLine($"Сумма на [0, {n - 1}]: {sum}");
//        Console.WriteLine($"Время выполнения запроса: {stopwatch.ElapsedMilliseconds} мс");

//        stopwatch.Restart();
//        segmentTree.UpdateRange(0, n - 1, 5);
//        stopwatch.Stop();

//        Console.WriteLine($"Время выполнения обновления: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}



////1.3: Графы - Алгоритм Дейкстры с восстановлением всех кратчайших путей
//using System;
//using System.Collections.Generic;

//// Класс для представления ребра графа
//public class Edge
//{
//    public int To { get; }
//    public int Weight { get; }

//    public Edge(int to, int weight)
//    {
//        To = to;
//        Weight = weight;
//    }
//}

//// Класс для представления графа
//public class Graph
//{
//    private readonly int _vertices;
//    private readonly List<List<Edge>> _adjacencyList;

//    public Graph(int vertices)
//    {
//        _vertices = vertices;
//        _adjacacencyList = new List<List<Edge>>();
//        for (int i = 0; i < vertices; i++)
//        {
//            _adjacacencyList.Add(new List<Edge>());
//        }
//    }

//    public void AddEdge(int from, int to, int weight)
//    {
//        _adjacacencyList[from].Add(new Edge(to, weight));
//    }

//    public List<Edge> GetEdges(int vertex)
//    {
//        return _adjacacencyList[vertex];
//    }

//    public int Vertices => _vertices;
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;

//// Результат алгоритма Дейкстры
//public class DijkstraResult
//{
//    public int[] Distances { get; }
//    public List<List<List<int>>> Paths { get; }

//    public DijkstraResult(int vertices)
//    {
//        Distances = new int[vertices];
//        Paths = new List<List<List<int>>>();
//        for (int i = 0; i < vertices; i++)
//        {
//            Paths.Add(new List<List<int>>());
//        }
//    }
//}

//// Алгоритм Дейкстры с восстановлением всех кратчайших путей
//public class DijkstraAllPaths
//{
//    public static DijkstraResult FindAllShortestPaths(Graph graph, int start)
//    {
//        int vertices = graph.Vertices;
//        DijkstraResult result = new DijkstraResult(vertices);

//        // Инициализация расстояний и путей
//        for (int i = 0; i < vertices; i++)
//        {
//            result.Distances[i] = int.MaxValue;
//        }
//        result.Distances[start] = 0;
//        result.Paths[start].Add(new List<int> { start });

//        // Приоритетная очередь: (расстояние, вершина)
//        var priorityQueue = new SortedSet<(int Distance, int Vertex)>(Comparer<(int, int)>.Create(
//            (a, b) => a.Distance != b.Distance ? a.Distance.CompareTo(b.Distance) : a.Vertex.CompareTo(b.Vertex)
//        ));
//        priorityQueue.Add((0, start));

//        while (priorityQueue.Count > 0)
//        {
//            var (currentDistance, currentVertex) = priorityQueue.Min;
//            priorityQueue.Remove(priorityQueue.Min);

//            // Если текущее расстояние больше известного, пропускаем
//            if (currentDistance > result.Distances[currentVertex])
//                continue;

//            // Перебираем все рёбра из текущей вершины
//            foreach (var edge in graph.GetEdges(currentVertex))
//            {
//                int newDistance = currentDistance + edge.Weight;
//                int neighbor = edge.To;

//                // Если нашли более короткий путь
//                if (newDistance < result.Distances[neighbor])
//                {
//                    result.Distances[neighbor] = newDistance;
//                    result.Paths[neighbor].Clear();
//                    foreach (var path in result.Paths[currentVertex])
//                    {
//                        var newPath = new List<int>(path) { neighbor };
//                        result.Paths[neighbor].Add(newPath);
//                    }
//                    priorityQueue.Add((newDistance, neighbor));
//                }
//                // Если нашли путь с тем же расстоянием, добавляем его
//                else if (newDistance == result.Distances[neighbor])
//                {
//                    foreach (var path in result.Paths[currentVertex])
//                    {
//                        var newPath = new List<int>(path) { neighbor };
//                        result.Paths[neighbor].Add(newPath);
//                    }
//                }
//            }
//        }

//        return result;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример графа
//        Graph graph = new Graph(6);
//        graph.AddEdge(0, 1, 4);
//        graph.AddEdge(0, 2, 2);
//        graph.AddEdge(1, 3, 5);
//        graph.AddEdge(2, 1, 1);
//        graph.AddEdge(2, 3, 8);
//        graph.AddEdge(2, 4, 10);
//        graph.AddEdge(3, 5, 3);
//        graph.AddEdge(4, 5, 1);

//        int startVertex = 0;
//        DijkstraResult result = DijkstraAllPaths.FindAllShortestPaths(graph, startVertex);

//        // Вывод результатов
//        for (int i = 0; i < graph.Vertices; i++)
//        {
//            Console.WriteLine($"Вершина {i}:");
//            Console.WriteLine($"  Расстояние: {result.Distances[i]}");
//            Console.WriteLine($"  Пути:");
//            foreach (var path in result.Paths[i])
//            {
//                Console.WriteLine($"    {string.Join(" -> ", path)}");
//            }
//        }
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 10_000;
//        int edges = 100_000;
//        Graph graph = new Graph(vertices);
//        Random random = new Random();

//        // Заполнение графа случайными рёбрами
//        for (int i = 0; i < edges; i++)
//        {
//            int from = random.Next(vertices);
//            int to = random.Next(vertices);
//            int weight = random.Next(1, 100);
//            graph.AddEdge(from, to, weight);
//        }

//        Stopwatch stopwatch = Stopwatch.StartNew();
//        DijkstraResult result = DijkstraAllPaths.FindAllShortestPaths(graph, 0);
//        stopwatch.Stop();

//        Console.WriteLine($"Время выполнения алгоритма Дейкстры: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.4: Суффиксное дерево(Suffix Tree) и поиск повторяющихся подстрок
//using System;
//using System.Collections.Generic;

//// Узел суффиксного дерева
//public class SuffixTreeNode
//{
//    public int Start { get; set; } // Начальная позиция подстроки в исходной строке
//    public int End { get; set; }   // Конечная позиция подстроки (используется для обозначения длины)
//    public int SuffixIndex { get; set; } // Индекс суффикса (для листьев)
//    public Dictionary<char, SuffixTreeNode> Children { get; } // Дети узла

//    public SuffixTreeNode(int start, int end, int suffixIndex = -1)
//    {
//        Start = start;
//        End = end;
//        SuffixIndex = suffixIndex;
//        Children = new Dictionary<char, SuffixTreeNode>();
//    }
//}


//using System;
//using System.Collections.Generic;

//// Суффиксное дерево
//public class SuffixTree
//{
//    private readonly string _text;
//    private SuffixTreeNode _root;
//    private SuffixTreeNode _activeNode;
//    private int _activeEdge = -1;
//    private int _activeLength = 0;
//    private int _remainingSuffixCount = 0;
//    private int _leafEnd = -1;
//    private readonly int[] _suffixArray;

//    public SuffixTree(string text)
//    {
//        _text = text;
//        _root = new SuffixTreeNode(-1, -1);
//        _activeNode = _root;
//        _suffixArray = new int[text.Length];
//        BuildSuffixTree();
//    }

//    // Построение суффиксного дерева по алгоритму Укконена
//    private void BuildSuffixTree()
//    {
//        for (int i = 0; i < _text.Length; i++)
//        {
//            _suffixArray[i] = i;
//            ExtendSuffixTree(i);
//        }
//    }

//    private void ExtendSuffixTree(int pos)
//    {
//        _leafEnd = pos;
//        _remainingSuffixCount++;
//        SuffixTreeNode lastNewNode = null;

//        while (_remainingSuffixCount > 0)
//        {
//            if (_activeLength == 0)
//            {
//                _activeEdge = pos;
//            }

//            char currentChar = _text[_activeEdge];
//            if (!_activeNode.Children.ContainsKey(currentChar))
//            {
//                _activeNode.Children[currentChar] = new SuffixTreeNode(pos, _text.Length - 1, pos);
//                if (lastNewNode != null)
//                {
//                    lastNewNode.SuffixIndex = pos;
//                    lastNewNode = null;
//                }
//            }
//            else
//            {
//                SuffixTreeNode nextNode = _activeNode.Children[currentChar];
//                if (WalkDown(nextNode))
//                {
//                    continue;
//                }

//                if (_text[nextNode.Start + _activeLength] == _text[pos])
//                {
//                    if (lastNewNode != null && _activeNode != _root)
//                    {
//                        lastNewNode.SuffixIndex = pos;
//                        lastNewNode = null;
//                    }
//                    _activeLength++;
//                    break;
//                }

//                int splitEnd = nextNode.Start + _activeLength - 1;
//                SuffixTreeNode splitNode = new SuffixTreeNode(nextNode.Start, splitEnd);
//                _activeNode.Children[currentChar] = splitNode;

//                splitNode.Children[_text[pos]] = new SuffixTreeNode(pos, _text.Length - 1, pos);
//                nextNode.Start += _activeLength;
//                splitNode.Children[_text[nextNode.Start]] = nextNode;

//                if (lastNewNode != null)
//                {
//                    lastNewNode.SuffixIndex = pos;
//                }
//                lastNewNode = splitNode;
//            }

//            _remainingSuffixCount--;
//            if (_activeNode == _root && _activeLength > 0)
//            {
//                _activeLength--;
//                _activeEdge = pos - _remainingSuffixCount + 1;
//            }
//            else if (_activeNode != _root)
//            {
//                _activeNode = _activeNode.SuffixIndex != -1 ? _root : _activeNode.Children.Values.First();
//            }
//        }
//    }

//    // Проверка возможности спуска по дереву
//    private bool WalkDown(SuffixTreeNode currentNode)
//    {
//        if (_activeLength >= currentNode.End - currentNode.Start + 1)
//        {
//            _activeEdge += currentNode.End - currentNode.Start + 1;
//            _activeLength -= currentNode.End - currentNode.Start + 1;
//            _activeNode = currentNode;
//            return true;
//        }
//        return false;
//    }

//    // Поиск подстроки в дереве
//    public bool ContainsSubstring(string substring)
//    {
//        SuffixTreeNode currentNode = _root;
//        int i = 0;
//        while (i < substring.Length)
//        {
//            if (!currentNode.Children.ContainsKey(substring[i]))
//            {
//                return false;
//            }
//            currentNode = currentNode.Children[substring[i]];
//            int j = currentNode.Start;
//            while (j <= currentNode.End && i < substring.Length)
//            {
//                if (_text[j] != substring[i])
//                {
//                    return false;
//                }
//                i++;
//                j++;
//            }
//            if (i == substring.Length)
//            {
//                return true;
//            }
//        }
//        return false;
//    }

//    // Поиск всех повторяющихся подстрок
//    public List<string> FindAllRepeatedSubstrings()
//    {
//        List<string> repeatedSubstrings = new List<string>();
//        FindRepeatedSubstrings(_root, repeatedSubstrings);
//        return repeatedSubstrings;
//    }

//    private void FindRepeatedSubstrings(SuffixTreeNode node, List<string> repeatedSubstrings)
//    {
//        if (node.Children.Count == 0)
//        {
//            return;
//        }

//        foreach (var child in node.Children.Values)
//        {
//            string currentSubstring = _text.Substring(child.Start, child.End - child.Start + 1);
//            if (child.Children.Count > 0)
//            {
//                FindRepeatedSubstrings(child, repeatedSubstrings);
//            }
//            if (child.Children.Count > 1 || (child.Children.Count == 1 && child.Children.Values.First().Children.Count > 0))
//            {
//                repeatedSubstrings.Add(currentSubstring);
//            }
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        string text = "banana";
//        SuffixTree suffixTree = new SuffixTree(text);

//        // Поиск подстроки
//        Console.WriteLine("Содержит 'nan': " + suffixTree.ContainsSubstring("nan"));
//        Console.WriteLine("Содержит 'cat': " + suffixTree.ContainsSubstring("cat"));

//        // Поиск повторяющихся подстрок
//        List<string> repeatedSubstrings = suffixTree.FindAllRepeatedSubstrings();
//        Console.WriteLine("Повторяющиеся подстроки:");
//        foreach (string substring in repeatedSubstrings)
//        {
//            Console.WriteLine(substring);
//        }
//    }
//}


//using System;
//using System.Diagnostics;
//using System.Text;

//class PerformanceTest
//{
//    static void Main()
//    {
//        // Генерация случайной строки
//        Random random = new Random();
//        StringBuilder sb = new StringBuilder();
//        for (int i = 0; i < 100_000; i++)
//        {
//            sb.Append((char)random.Next('a', 'z' + 1));
//        }
//        string text = sb.ToString();

//        Stopwatch stopwatch = Stopwatch.StartNew();
//        SuffixTree suffixTree = new SuffixTree(text);
//        stopwatch.Stop();

//        Console.WriteLine($"Время построения суффиксного дерева: {stopwatch.ElapsedMilliseconds} мс");

//        stopwatch.Restart();
//        bool contains = suffixTree.ContainsSubstring("abc");
//        stopwatch.Stop();

//        Console.WriteLine($"Время поиска подстроки: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.5: Система непересекающихся множеств (Union-Find) с эвристиками
//using System;

//// Класс для системы непересекающихся множеств
//public class UnionFind
//{
//    private int[] _parent;  // Массив родителей
//    private int[] _rank;    // Массив рангов (глубин деревьев)

//    // Инициализация структуры
//    public UnionFind(int size)
//    {
//        _parent = new int[size];
//        _rank = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            _parent[i] = i;  // Каждый элемент — свой собственный родитель
//            _rank[i] = 0;    // Начальный ранг — 0
//        }
//    }

//    // Поиск корня множества с эвристикой сжатия путей
//    public int Find(int x)
//    {
//        if (_parent[x] != x)
//        {
//            _parent[x] = Find(_parent[x]);  // Сжатие путей
//        }
//        return _parent[x];
//    }

//    // Объединение двух множеств с эвристикой объединения по рангу
//    public void Union(int x, int y)
//    {
//        int rootX = Find(x);
//        int rootY = Find(y);

//        if (rootX == rootY)
//            return;  // Уже в одном множестве

//        // Объединение по рангу
//        if (_rank[rootX] < _rank[rootY])
//        {
//            _parent[rootX] = rootY;
//        }
//        else if (_rank[rootX] > _rank[rootY])
//        {
//            _parent[rootY] = rootX;
//        }
//        else
//        {
//            _parent[rootY] = rootX;
//            _rank[rootX]++;
//        }
//    }

//    // Проверка, принадлежат ли два элемента одному множеству
//    public bool Connected(int x, int y)
//    {
//        return Find(x) == Find(y);
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        int size = 10;
//        UnionFind uf = new UnionFind(size);

//        // Объединение элементов
//        uf.Union(0, 1);
//        uf.Union(2, 3);
//        uf.Union(1, 2);

//        // Проверка связности
//        Console.WriteLine("0 и 1 связаны: " + uf.Connected(0, 1));  // True
//        Console.WriteLine("0 и 3 связаны: " + uf.Connected(0, 3));  // True
//        Console.WriteLine("4 и 5 связаны: " + uf.Connected(4, 5));  // False

//        // Поиск корней
//        Console.WriteLine("Корень 0: " + uf.Find(0));  // 2 (или 0, в зависимости от порядка объединений)
//        Console.WriteLine("Корень 3: " + uf.Find(3));  // 2
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int size = 1_000_000;
//        UnionFind uf = new UnionFind(size);
//        Random random = new Random();

//        // Тест на объединение
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        for (int i = 0; i < size / 2; i++)
//        {
//            int x = random.Next(size);
//            int y = random.Next(size);
//            uf.Union(x, y);
//        }
//        stopwatch.Stop();
//        Console.WriteLine($"Время объединения {size / 2} пар: {stopwatch.ElapsedMilliseconds} мс");

//        // Тест на поиск
//        stopwatch.Restart();
//        for (int i = 0; i < size; i++)
//        {
//            uf.Find(i);
//        }
//        stopwatch.Stop();
//        Console.WriteLine($"Время поиска корней для {size} элементов: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.6: B - дерево(B - дерево) для больших объемов данных
//using System;
//using System.Collections.Generic;

//// Узел B-дерева
//public class BTreeNode<T> where T : IComparable<T>
//{
//    public List<T> Keys { get; set; }          // Ключи в узле
//    public List<BTreeNode<T>> Children { get; set; }  // Дети узла
//    public bool IsLeaf { get; set; }          // Является ли узел листом

//    public BTreeNode(bool isLeaf)
//    {
//        Keys = new List<T>();
//        Children = new List<BTreeNode<T>>();
//        IsLeaf = isLeaf;
//    }
//}


//using System;
//using System.Collections.Generic;

//// B-дерево
//public class BTree<T> where T : IComparable<T>
//{
//    private readonly int _degree;  // Минимальная степень ветвления
//    private BTreeNode<T> _root;   // Корень дерева

//    public BTree(int degree)
//    {
//        _degree = degree;
//        _root = new BTreeNode<T>(true);
//    }

//    // Поиск ключа в дереве
//    public bool Search(T key)
//    {
//        return Search(_root, key);
//    }

//    private bool Search(BTreeNode<T> node, T key)
//    {
//        int i = 0;
//        while (i < node.Keys.Count && key.CompareTo(node.Keys[i]) > 0)
//        {
//            i++;
//        }

//        if (i < node.Keys.Count && key.CompareTo(node.Keys[i]) == 0)
//        {
//            return true;
//        }

//        if (node.IsLeaf)
//        {
//            return false;
//        }

//        return Search(node.Children[i], key);
//    }

//    // Вставка ключа в дерево
//    public void Insert(T key)
//    {
//        BTreeNode<T> root = _root;
//        if (root.Keys.Count == 2 * _degree - 1)
//        {
//            BTreeNode<T> newRoot = new BTreeNode<T>(false);
//            newRoot.Children.Add(root);
//            _root = newRoot;
//            SplitChild(newRoot, 0);
//        }
//        InsertNonFull(_root, key);
//    }

//    // Вставка ключа в неполный узел
//    private void InsertNonFull(BTreeNode<T> node, T key)
//    {
//        int i = node.Keys.Count - 1;
//        if (node.IsLeaf)
//        {
//            while (i >= 0 && key.CompareTo(node.Keys[i]) < 0)
//            {
//                i--;
//            }
//            node.Keys.Insert(i + 1, key);
//        }
//        else
//        {
//            while (i >= 0 && key.CompareTo(node.Keys[i]) < 0)
//            {
//                i--;
//            }
//            i++;
//            if (node.Children[i].Keys.Count == 2 * _degree - 1)
//            {
//                SplitChild(node, i);
//                if (key.CompareTo(node.Keys[i]) > 0)
//                {
//                    i++;
//                }
//            }
//            InsertNonFull(node.Children[i], key);
//        }
//    }

//    // Разделение дочернего узла
//    private void SplitChild(BTreeNode<T> parent, int index)
//    {
//        BTreeNode<T> child = parent.Children[index];
//        BTreeNode<T> newChild = new BTreeNode<T>(child.IsLeaf);
//        parent.Keys.Insert(index, child.Keys[_degree - 1]);
//        parent.Children.Insert(index + 1, newChild);

//        newChild.Keys.AddRange(child.Keys.GetRange(_degree, _degree - 1));
//        child.Keys.RemoveRange(_degree - 1, _degree);

//        if (!child.IsLeaf)
//        {
//            newChild.Children.AddRange(child.Children.GetRange(_degree, _degree));
//            child.Children.RemoveRange(_degree, _degree);
//        }
//    }

//    // Удаление ключа из дерева
//    public void Delete(T key)
//    {
//        Delete(_root, key);
//        if (_root.Keys.Count == 0 && !_root.IsLeaf)
//        {
//            _root = _root.Children[0];
//        }
//    }

//    private void Delete(BTreeNode<T> node, T key)
//    {
//        int i = 0;
//        while (i < node.Keys.Count && key.CompareTo(node.Keys[i]) > 0)
//        {
//            i++;
//        }

//        if (i < node.Keys.Count && key.CompareTo(node.Keys[i]) == 0)
//        {
//            if (node.IsLeaf)
//            {
//                node.Keys.RemoveAt(i);
//            }
//            else
//            {
//                DeleteInternal(node, key, i);
//            }
//        }
//        else
//        {
//            if (node.IsLeaf)
//            {
//                return;
//            }

//            bool isLastChild = i == node.Keys.Count;
//            if (node.Children[i].Keys.Count < _degree)
//            {
//                Fill(node, i);
//            }

//            if (isLastChild && i > node.Keys.Count)
//            {
//                Delete(node.Children[i - 1], key);
//            }
//            else
//            {
//                Delete(node.Children[i], key);
//            }
//        }
//    }

//    private void DeleteInternal(BTreeNode<T> node, T key, int index)
//    {
//        if (node.IsLeaf)
//        {
//            if (node.Keys[index].CompareTo(key) == 0)
//            {
//                node.Keys.RemoveAt(index);
//            }
//            return;
//        }

//        if (node.Children[index].Keys.Count >= _degree)
//        {
//            T predecessor = GetPredecessor(node, index);
//            node.Keys[index] = predecessor;
//            Delete(node.Children[index], predecessor);
//        }
//        else if (node.Children[index + 1].Keys.Count >= _degree)
//        {
//            T successor = GetSuccessor(node, index);
//            node.Keys[index] = successor;
//            Delete(node.Children[index + 1], successor);
//        }
//        else
//        {
//            Merge(node, index);
//            Delete(node.Children[index], key);
//        }
//    }

//    private T GetPredecessor(BTreeNode<T> node, int index)
//    {
//        BTreeNode<T> current = node.Children[index];
//        while (!current.IsLeaf)
//        {
//            current = current.Children[current.Children.Count - 1];
//        }
//        return current.Keys[current.Keys.Count - 1];
//    }

//    private T GetSuccessor(BTreeNode<T> node, int index)
//    {
//        BTreeNode<T> current = node.Children[index + 1];
//        while (!current.IsLeaf)
//        {
//            current = current.Children[0];
//        }
//        return current.Keys[0];
//    }

//    private void Fill(BTreeNode<T> node, int index)
//    {
//        if (index != 0 && node.Children[index - 1].Keys.Count >= _degree)
//        {
//            BorrowFromPrev(node, index);
//        }
//        else if (index != node.Keys.Count && node.Children[index + 1].Keys.Count >= _degree)
//        {
//            BorrowFromNext(node, index);
//        }
//        else
//        {
//            if (index != node.Keys.Count)
//            {
//                Merge(node, index);
//            }
//            else
//            {
//                Merge(node, index - 1);
//            }
//        }
//    }

//    private void BorrowFromPrev(BTreeNode<T> node, int index)
//    {
//        BTreeNode<T> child = node.Children[index];
//        BTreeNode<T> sibling = node.Children[index - 1];

//        child.Keys.Insert(0, node.Keys[index - 1]);
//        if (!child.IsLeaf)
//        {
//            child.Children.Insert(0, sibling.Children[sibling.Children.Count - 1]);
//        }

//        node.Keys[index - 1] = sibling.Keys[sibling.Keys.Count - 1];
//        sibling.Keys.RemoveAt(sibling.Keys.Count - 1);
//        if (!sibling.IsLeaf)
//        {
//            sibling.Children.RemoveAt(sibling.Children.Count - 1);
//        }
//    }

//    private void BorrowFromNext(BTreeNode<T> node, int index)
//    {
//        BTreeNode<T> child = node.Children[index];
//        BTreeNode<T> sibling = node.Children[index + 1];

//        child.Keys.Add(node.Keys[index]);
//        if (!child.IsLeaf)
//        {
//            child.Children.Add(sibling.Children[0]);
//        }

//        node.Keys[index] = sibling.Keys[0];
//        sibling.Keys.RemoveAt(0);
//        if (!sibling.IsLeaf)
//        {
//            sibling.Children.RemoveAt(0);
//        }
//    }

//    private void Merge(BTreeNode<T> node, int index)
//    {
//        BTreeNode<T> child = node.Children[index];
//        BTreeNode<T> sibling = node.Children[index + 1];

//        child.Keys.Add(node.Keys[index]);
//        child.Keys.AddRange(sibling.Keys);

//        if (!child.IsLeaf)
//        {
//            child.Children.AddRange(sibling.Children);
//        }

//        node.Keys.RemoveAt(index);
//        node.Children.RemoveAt(index + 1);
//    }

//    // Обход дерева (для отладки)
//    public void Traverse()
//    {
//        Traverse(_root, 0);
//    }

//    private void Traverse(BTreeNode<T> node, int level)
//    {
//        Console.WriteLine($"Level {level}:");
//        for (int i = 0; i < node.Keys.Count; i++)
//        {
//            Console.Write(node.Keys[i] + " ");
//        }
//        Console.WriteLine();

//        if (!node.IsLeaf)
//        {
//            for (int i = 0; i < node.Children.Count; i++)
//            {
//                Traverse(node.Children[i], level + 1);
//            }
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        BTree<int> bTree = new BTree<int>(3); // Степень ветвления = 3

//        // Вставка ключей
//        bTree.Insert(10);
//        bTree.Insert(20);
//        bTree.Insert(5);
//        bTree.Insert(15);
//        bTree.Insert(25);
//        bTree.Insert(30);
//        bTree.Insert(35);

//        // Поиск ключей
//        Console.WriteLine("Поиск 15: " + bTree.Search(15));  // True
//        Console.WriteLine("Поиск 40: " + bTree.Search(40));  // False

//        // Удаление ключей
//        bTree.Delete(15);
//        Console.WriteLine("Поиск 15 после удаления: " + bTree.Search(15));  // False

//        // Обход дерева
//        Console.WriteLine("Обход дерева:");
//        bTree.Traverse();
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        BTree<int> bTree = new BTree<int>(100); // Высокая степень ветвления
//        Random random = new Random();

//        // Вставка 1,000,000 элементов
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        for (int i = 0; i < 1_000_000; i++)
//        {
//            bTree.Insert(random.Next(1, 1_000_000));
//        }
//        stopwatch.Stop();
//        Console.WriteLine($"Время вставки 1,000,000 элементов: {stopwatch.ElapsedMilliseconds} мс");

//        // Поиск 10,000 элементов
//        stopwatch.Restart();
//        for (int i = 0; i < 10_000; i++)
//        {
//            bTree.Search(random.Next(1, 1_000_000));
//        }
//        stopwatch.Stop();
//        Console.WriteLine($"Время поиска 10,000 элементов: {stopwatch.ElapsedMilliseconds} мс");

//        // Удаление 10,000 элементов
//        stopwatch.Restart();
//        for (int i = 0; i < 10_000; i++)
//        {
//            bTree.Delete(random.Next(1, 1_000_000));
//        }
//        stopwatch.Stop();
//        Console.WriteLine($"Время удаления 10,000 элементов: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.7: Приоритетная очередь с операцией главных приоритетов
//using System;
//using System.Collections.Generic;

//// Приоритетная очередь на основе двоичной кучи
//public class PriorityQueue<T> where T : IComparable<T>
//{
//    private List<T> _heap;

//    public PriorityQueue()
//    {
//        _heap = new List<T>();
//    }

//    public int Count => _heap.Count;

//    // Вставка элемента в кучу
//    public void Insert(T item)
//    {
//        _heap.Add(item);
//        HeapifyUp(_heap.Count - 1);
//    }

//    // Извлечение максимального элемента
//    public T ExtractMax()
//    {
//        if (_heap.Count == 0)
//            throw new InvalidOperationException("Queue is empty");

//        T max = _heap[0];
//        _heap[0] = _heap[_heap.Count - 1];
//        _heap.RemoveAt(_heap.Count - 1);
//        HeapifyDown(0);
//        return max;
//    }

//    // Получение k главных приоритетов
//    public List<T> GetTopK(int k)
//    {
//        if (k <= 0 || k > _heap.Count)
//            throw new ArgumentOutOfRangeException(nameof(k), "Invalid value of k");

//        // Копируем кучу, чтобы не нарушать исходную
//        var heapCopy = new List<T>(_heap);
//        var topK = new List<T>(k);

//        for (int i = 0; i < k; i++)
//        {
//            topK.Add(heapCopy[0]);
//            heapCopy[0] = heapCopy[heapCopy.Count - 1];
//            heapCopy.RemoveAt(heapCopy.Count - 1);
//            HeapifyDown(heapCopy, 0);
//        }

//        return topK;
//    }

//    // Восстановление свойства кучи снизу вверх
//    private void HeapifyUp(int index)
//    {
//        while (index > 0)
//        {
//            int parentIndex = (index - 1) / 2;
//            if (_heap[index].CompareTo(_heap[parentIndex]) <= 0)
//                break;

//            Swap(index, parentIndex);
//            index = parentIndex;
//        }
//    }

//    // Восстановление свойства кучи сверху вниз
//    private void HeapifyDown(int index)
//    {
//        HeapifyDown(_heap, index);
//    }

//    private void HeapifyDown(List<T> heap, int index)
//    {
//        int leftChild, rightChild, largestChild;
//        while (true)
//        {
//            leftChild = 2 * index + 1;
//            rightChild = 2 * index + 2;
//            largestChild = index;

//            if (leftChild < heap.Count && heap[leftChild].CompareTo(heap[largestChild]) > 0)
//                largestChild = leftChild;

//            if (rightChild < heap.Count && heap[rightChild].CompareTo(heap[largestChild]) > 0)
//                largestChild = rightChild;

//            if (largestChild == index)
//                break;

//            Swap(heap, index, largestChild);
//            index = largestChild;
//        }
//    }

//    // Обмен элементов в куче
//    private void Swap(int i, int j)
//    {
//        T temp = _heap[i];
//        _heap[i] = _heap[j];
//        _heap[j] = temp;
//    }

//    private void Swap(List<T> heap, int i, int j)
//    {
//        T temp = heap[i];
//        heap[i] = heap[j];
//        heap[j] = temp;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

//        // Вставка элементов
//        priorityQueue.Insert(10);
//        priorityQueue.Insert(30);
//        priorityQueue.Insert(20);
//        priorityQueue.Insert(5);
//        priorityQueue.Insert(25);

//        // Извлечение максимального элемента
//        Console.WriteLine("Max element: " + priorityQueue.ExtractMax()); // 30

//        // Получение 3 главных приоритетов
//        List<int> top3 = priorityQueue.GetTopK(3);
//        Console.WriteLine("Top 3 elements: " + string.Join(", ", top3)); // 25, 20, 10
//    }
//}


//public List<T> GetTopKQuickSelect(int k)
//{
//    if (k <= 0 || k > _heap.Count)
//        throw new ArgumentOutOfRangeException(nameof(k), "Invalid value of k");

//    // Копируем кучу
//    var heapCopy = new List<T>(_heap);
//    var topK = new List<T>(k);

//    // Используем QuickSelect для нахождения k最大元素
//    QuickSelect(heapCopy, 0, heapCopy.Count - 1, k, topK);

//    // Сортируем topK по убыванию
//    topK.Sort((a, b) => b.CompareTo(a));

//    return topK;
//}

//private void QuickSelect(List<T> list, int left, int right, int k, List<T> topK)
//{
//    if (left == right)
//    {
//        topK.Add(list[left]);
//        return;
//    }

//    int pivotIndex = Partition(list, left, right);

//    if (k <= pivotIndex - left + 1)
//    {
//        QuickSelect(list, left, pivotIndex, k, topK);
//    }
//    else
//    {
//        for (int i = left; i <= pivotIndex; i++)
//        {
//            topK.Add(list[i]);
//        }
//        QuickSelect(list, pivotIndex + 1, right, k - (pivotIndex - left + 1), topK);
//    }
//}

//private int Partition(List<T> list, int left, int right)
//{
//    T pivot = list[right];
//    int i = left;

//    for (int j = left; j < right; j++)
//    {
//        if (list[j].CompareTo(pivot) >= 0)
//        {
//            Swap(list, i, j);
//            i++;
//        }
//    }

//    Swap(list, i, right);
//    return i;
//}


//using System;
//using System.Diagnostics;
//using System.Linq;

//class PerformanceTest
//{
//    static void Main()
//    {
//        PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
//        Random random = new Random();

//        // Вставка 1,000,000 элементов
//        for (int i = 0; i < 1_000_000; i++)
//        {
//            priorityQueue.Insert(random.Next(1, 1_000_000));
//        }

//        // Тест на получение 100 главных приоритетов
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        List<int> top100 = priorityQueue.GetTopK(100);
//        stopwatch.Stop();
//        Console.WriteLine($"Время получения 100 главных приоритетов: {stopwatch.ElapsedMilliseconds} мс");

//        // Тест на извлечение максимального элемента
//        stopwatch.Restart();
//        int maxElement = priorityQueue.ExtractMax();
//        stopwatch.Stop();
//        Console.WriteLine($"Время извлечения максимального элемента: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.8: Задача о максимальном потоке (Max Flow) - алгоритм Форда-Фалкерсона
//using System;
//using System.Collections.Generic;

//// Класс для представления ребра графа
//public class Edge
//{
//    public int To { get; }      // Вершина, в которую ведёт ребро
//    public int Capacity { get; } // Пропускная способность ребра
//    public int Flow { get; set; } // Текущий поток через ребро
//    public Edge Reverse { get; set; } // Обратное ребро для остаточной сети

//    public Edge(int to, int capacity)
//    {
//        To = to;
//        Capacity = capacity;
//        Flow = 0;
//    }

//    // Остаточная пропускная способность
//    public int ResidualCapacity => Capacity - Flow;
//}

//// Класс для представления графа
//public class FlowGraph
//{
//    private readonly int _vertices; // Количество вершин
//    private readonly List<List<Edge>> _adjacencyList; // Список смежности

//    public FlowGraph(int vertices)
//    {
//        _vertices = vertices;
//        _adjacencyList = new List<List<Edge>>();
//        for (int i = 0; i < vertices; i++)
//        {
//            _adjacencyList.Add(new List<Edge>());
//        }
//    }

//    // Добавление ребра в граф
//    public void AddEdge(int from, int to, int capacity)
//    {
//        Edge forwardEdge = new Edge(to, capacity);
//        Edge backwardEdge = new Edge(from, 0); // Обратное ребро с нулевой пропускной способностью

//        forwardEdge.Reverse = backwardEdge;
//        backwardEdge.Reverse = forwardEdge;

//        _adjacencyList[from].Add(forwardEdge);
//        _adjacencyList[to].Add(backwardEdge);
//    }

//    // Получение списка рёбер для вершины
//    public List<Edge> GetEdges(int vertex)
//    {
//        return _adjacencyList[vertex];
//    }

//    public int Vertices => _vertices;
//}


//using System;
//using System.Collections.Generic;

//// Алгоритм Форда-Фалкерсона с поиском в ширину (Edmonds-Karp)
//public class MaxFlow
//{
//    public static int FindMaxFlow(FlowGraph graph, int source, int sink)
//    {
//        int maxFlow = 0;
//        int[] parent = new int[graph.Vertices];

//        // Пока существует увеличивающий путь
//        while (Bfs(graph, source, sink, parent))
//        {
//            // Находим минимальную остаточную пропускную способность на пути
//            int pathFlow = int.MaxValue;
//            for (int v = sink; v != source; v = parent[v])
//            {
//                int u = parent[v];
//                foreach (Edge edge in graph.GetEdges(u))
//                {
//                    if (edge.To == v)
//                    {
//                        pathFlow = Math.Min(pathFlow, edge.ResidualCapacity);
//                        break;
//                    }
//                }
//            }

//            // Обновляем поток по пути
//            for (int v = sink; v != source; v = parent[v])
//            {
//                int u = parent[v];
//                foreach (Edge edge in graph.GetEdges(u))
//                {
//                    if (edge.To == v)
//                    {
//                        edge.Flow += pathFlow;
//                        edge.Reverse.Flow -= pathFlow;
//                        break;
//                    }
//                }
//            }

//            maxFlow += pathFlow;
//        }

//        return maxFlow;
//    }

//    // Поиск в ширину для нахождения увеличивающего пути
//    private static bool Bfs(FlowGraph graph, int source, int sink, int[] parent)
//    {
//        bool[] visited = new bool[graph.Vertices];
//        Queue<int> queue = new Queue<int>();
//        queue.Enqueue(source);
//        visited[source] = true;
//        parent[source] = -1;

//        while (queue.Count > 0)
//        {
//            int u = queue.Dequeue();
//            foreach (Edge edge in graph.GetEdges(u))
//            {
//                if (!visited[edge.To] && edge.ResidualCapacity > 0)
//                {
//                    parent[edge.To] = u;
//                    visited[edge.To] = true;
//                    queue.Enqueue(edge.To);

//                    if (edge.To == sink)
//                    {
//                        return true;
//                    }
//                }
//            }
//        }

//        return false;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример графа
//        FlowGraph graph = new FlowGraph(6);

//        // Добавляем рёбра
//        graph.AddEdge(0, 1, 16);
//        graph.AddEdge(0, 2, 13);
//        graph.AddEdge(1, 2, 10);
//        graph.AddEdge(1, 3, 12);
//        graph.AddEdge(2, 1, 4);
//        graph.AddEdge(2, 4, 14);
//        graph.AddEdge(3, 2, 9);
//        graph.AddEdge(3, 5, 20);
//        graph.AddEdge(4, 3, 7);
//        graph.AddEdge(4, 5, 4);

//        int source = 0; // Источник
//        int sink = 5;   // Сток

//        // Находим максимальный поток
//        int maxFlow = MaxFlow.FindMaxFlow(graph, source, sink);
//        Console.WriteLine($"Максимальный поток: {maxFlow}");
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 1000;
//        FlowGraph graph = new FlowGraph(vertices);
//        Random random = new Random();

//        // Заполнение графа случайными рёбрами
//        for (int i = 0; i < vertices; i++)
//        {
//            for (int j = i + 1; j < vertices; j++)
//            {
//                if (random.NextDouble() < 0.05) // Вероятность добавления ребра
//                {
//                    int capacity = random.Next(1, 100);
//                    graph.AddEdge(i, j, capacity);
//                }
//            }
//        }

//        int source = 0;
//        int sink = vertices - 1;

//        // Замер времени выполнения
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        int maxFlow = MaxFlow.FindMaxFlow(graph, source, sink);
//        stopwatch.Stop();

//        Console.WriteLine($"Максимальный поток: {maxFlow}");
//        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.9: Поиск всех мостов в графе (Bridge Finding)
//using System;
//using System.Collections.Generic;

//// Класс для представления графа
//public class Graph
//{
//    private readonly int _vertices; // Количество вершин
//    private readonly List<List<int>> _adjacencyList; // Список смежности

//    public Graph(int vertices)
//    {
//        _vertices = vertices;
//        _adjacencyList = new List<List<int>>();
//        for (int i = 0; i < vertices; i++)
//        {
//            _adjacencyList.Add(new List<int>());
//        }
//    }

//    // Добавление ребра
//    public void AddEdge(int u, int v)
//    {
//        _adjacencyList[u].Add(v);
//        _adjacencyList[v].Add(u);
//    }

//    // Получение списка смежности для вершины
//    public List<int> GetAdjacentVertices(int vertex)
//    {
//        return _adjacencyList[vertex];
//    }

//    public int Vertices => _vertices;
//}


//using System;
//using System.Collections.Generic;

//// Класс для поиска мостов в графе
//public class BridgeFinder
//{
//    private readonly Graph _graph;
//    private int[] _discoveryTime; // Время обнаружения вершины
//    private int[] _lowTime;       // Минимальное время достижимости
//    private bool[] _visited;      // Посещена ли вершина
//    private int _time;            // Текущее время
//    private List<(int, int)> _bridges; // Список мостов

//    public BridgeFinder(Graph graph)
//    {
//        _graph = graph;
//        _discoveryTime = new int[graph.Vertices];
//        _lowTime = new int[graph.Vertices];
//        _visited = new bool[graph.Vertices];
//        _bridges = new List<(int, int)>();
//    }

//    // Поиск мостов
//    public List<(int, int)> FindBridges()
//    {
//        _time = 0;
//        for (int i = 0; i < _graph.Vertices; i++)
//        {
//            if (!_visited[i])
//            {
//                Dfs(i, -1);
//            }
//        }
//        return _bridges;
//    }

//    // Рекурсивный обход в глубину
//    private void Dfs(int u, int parent)
//    {
//        _visited[u] = true;
//        _discoveryTime[u] = _lowTime[u] = ++_time;

//        foreach (int v in _graph.GetAdjacentVertices(u))
//        {
//            if (!_visited[v])
//            {
//                Dfs(v, u);
//                _lowTime[u] = Math.Min(_lowTime[u], _lowTime[v]);

//                // Проверка условия моста
//                if (_lowTime[v] > _discoveryTime[u])
//                {
//                    _bridges.Add((Math.Min(u, v), Math.Max(u, v)));
//                }
//            }
//            else if (v != parent)
//            {
//                _lowTime[u] = Math.Min(_lowTime[u], _discoveryTime[v]);
//            }
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример графа
//        Graph graph = new Graph(5);
//        graph.AddEdge(0, 1);
//        graph.AddEdge(0, 2);
//        graph.AddEdge(1, 2);
//        graph.AddEdge(2, 3);
//        graph.AddEdge(3, 4);

//        // Поиск мостов
//        BridgeFinder bridgeFinder = new BridgeFinder(graph);
//        List<(int, int)> bridges = bridgeFinder.FindBridges();

//        // Вывод мостов
//        Console.WriteLine("Мосты в графе:");
//        foreach (var bridge in bridges)
//        {
//            Console.WriteLine($"{bridge.Item1} -- {bridge.Item2}");
//        }
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 10_000;
//        Graph graph = new Graph(vertices);
//        Random random = new Random();

//        // Заполнение графа случайными рёбрами
//        for (int i = 0; i < vertices; i++)
//        {
//            for (int j = i + 1; j < Math.Min(i + 10, vertices); j++)
//            {
//                if (random.NextDouble() < 0.3) // Вероятность добавления ребра
//                {
//                    graph.AddEdge(i, j);
//                }
//            }
//        }

//        // Поиск мостов
//        BridgeFinder bridgeFinder = new BridgeFinder(graph);
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        var bridges = bridgeFinder.FindBridges();
//        stopwatch.Stop();

//        Console.WriteLine($"Найдено мостов: {bridges.Count}");
//        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.10: Поиск точек сочленения в графе (Точки артикуляции)
//using System;
//using System.Collections.Generic;

//// Класс для представления графа
//public class Graph
//{
//    private readonly int _vertices; // Количество вершин
//    private readonly List<List<int>> _adjacencyList; // Список смежности

//    public Graph(int vertices)
//    {
//        _vertices = vertices;
//        _adjacencyList = new List<List<int>>();
//        for (int i = 0; i < vertices; i++)
//        {
//            _adjacencyList.Add(new List<int>());
//        }
//    }

//    // Добавление ребра
//    public void AddEdge(int u, int v)
//    {
//        _adjacencyList[u].Add(v);
//        _adjacencyList[v].Add(u);
//    }

//    // Получение списка смежности для вершины
//    public List<int> GetAdjacentVertices(int vertex)
//    {
//        return _adjacencyList[vertex];
//    }

//    public int Vertices => _vertices;
//}


//using System;
//using System.Collections.Generic;

//// Класс для поиска точек сочленения в графе
//public class ArticulationPointFinder
//{
//    private readonly Graph _graph;
//    private int[] _discoveryTime; // Время обнаружения вершины
//    private int[] _lowTime;       // Минимальное время достижимости
//    private bool[] _visited;      // Посещена ли вершина
//    private bool[] _isArticulationPoint; // Является ли вершина точкой сочленения
//    private int _time;            // Текущее время

//    public ArticulationPointFinder(Graph graph)
//    {
//        _graph = graph;
//        _discoveryTime = new int[graph.Vertices];
//        _lowTime = new int[graph.Vertices];
//        _visited = new bool[graph.Vertices];
//        _isArticulationPoint = new bool[graph.Vertices];
//    }

//    // Поиск точек сочленения
//    public List<int> FindArticulationPoints()
//    {
//        _time = 0;
//        for (int i = 0; i < _graph.Vertices; i++)
//        {
//            if (!_visited[i])
//            {
//                Dfs(i, -1);
//            }
//        }
//        return GetArticulationPoints();
//    }

//    // Рекурсивный обход в глубину
//    private void Dfs(int u, int parent)
//    {
//        _visited[u] = true;
//        _discoveryTime[u] = _lowTime[u] = ++_time;
//        int children = 0;

//        foreach (int v in _graph.GetAdjacentVertices(u))
//        {
//            if (!_visited[v])
//            {
//                children++;
//                Dfs(v, u);
//                _lowTime[u] = Math.Min(_lowTime[u], _lowTime[v]);

//                // Проверка условия точки сочленения
//                if (parent != -1 && _lowTime[v] >= _discoveryTime[u])
//                {
//                    _isArticulationPoint[u] = true;
//                }
//            }
//            else if (v != parent)
//            {
//                _lowTime[u] = Math.Min(_lowTime[u], _discoveryTime[v]);
//            }
//        }

//        // Корень дерева DFS является точкой сочленения, если у него больше одного ребёнка
//        if (parent == -1 && children > 1)
//        {
//            _isArticulationPoint[u] = true;
//        }
//    }

//    // Получение списка точек сочленения
//    private List<int> GetArticulationPoints()
//    {
//        List<int> articulationPoints = new List<int>();
//        for (int i = 0; i < _graph.Vertices; i++)
//        {
//            if (_isArticulationPoint[i])
//            {
//                articulationPoints.Add(i);
//            }
//        }
//        return articulationPoints;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример графа
//        Graph graph = new Graph(5);
//        graph.AddEdge(0, 1);
//        graph.AddEdge(0, 2);
//        graph.AddEdge(1, 2);
//        graph.AddEdge(2, 3);
//        graph.AddEdge(3, 4);

//        // Поиск точек сочленения
//        ArticulationPointFinder apFinder = new ArticulationPointFinder(graph);
//        List<int> articulationPoints = apFinder.FindArticulationPoints();

//        // Вывод точек сочленения
//        Console.WriteLine("Точки сочленения в графе:");
//        foreach (int ap in articulationPoints)
//        {
//            Console.WriteLine(ap);
//        }
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 10_000;
//        Graph graph = new Graph(vertices);
//        Random random = new Random();

//        // Заполнение графа случайными рёбрами
//        for (int i = 0; i < vertices; i++)
//        {
//            for (int j = i + 1; j < Math.Min(i + 10, vertices); j++)
//            {
//                if (random.NextDouble() < 0.3) // Вероятность добавления ребра
//                {
//                    graph.AddEdge(i, j);
//                }
//            }
//        }

//        // Поиск точек сочленения
//        ArticulationPointFinder apFinder = new ArticulationPointFinder(graph);
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        var articulationPoints = apFinder.FindArticulationPoints();
//        stopwatch.Stop();

//        Console.WriteLine($"Найдено точек сочленения: {articulationPoints.Count}");
//        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.11: LCA(самый низкий общий предок) в дереве
//using System;
//using System.Collections.Generic;

//// Узел дерева
//public class TreeNode
//{
//    public int Value { get; }
//    public List<TreeNode> Children { get; }

//    public TreeNode(int value)
//    {
//        Value = value;
//        Children = new List<TreeNode>();
//    }
//}

//// Дерево
//public class Tree
//{
//    public TreeNode Root { get; }

//    public Tree(TreeNode root)
//    {
//        Root = root;
//    }
//}


//using System;
//using System.Collections.Generic;

//// Класс для поиска LCA с использованием бинарного подъёма
//public class LCASolver
//{
//    private readonly TreeNode _root;
//    private readonly int _maxLog;
//    private readonly Dictionary<TreeNode, int> _depth; // Глубина узла
//    private readonly Dictionary<TreeNode, TreeNode[]> _up; // up[v][j] — предок узла v на уровне 2^j

//    public LCASolver(Tree tree)
//    {
//        _root = tree.Root;
//        _maxLog = (int)Math.Log2(GetTreeSize(_root)) + 1;
//        _depth = new Dictionary<TreeNode, int>();
//        _up = new Dictionary<TreeNode, TreeNode[]>();

//        // Предварительная обработка дерева
//        Dfs(_root, null);
//    }

//    // Рекурсивный обход для заполнения _depth и _up
//    private void Dfs(TreeNode node, TreeNode parent)
//    {
//        _depth[node] = parent == null ? 0 : _depth[parent] + 1;
//        _up[node] = new TreeNode[_maxLog];
//        _up[node][0] = parent;

//        for (int j = 1; j < _maxLog; j++)
//        {
//            if (_up[node][j - 1] != null)
//            {
//                _up[node][j] = _up[_up[node][j - 1]][j - 1];
//            }
//        }

//        foreach (TreeNode child in node.Children)
//        {
//            Dfs(child, node);
//        }
//    }

//    // Поиск LCA для двух узлов
//    public TreeNode FindLCA(TreeNode u, TreeNode v)
//    {
//        // Поднимаем узел u до глубины узла v
//        if (_depth[u] > _depth[v])
//        {
//            (u, v) = (v, u);
//        }

//        // Поднимаем узел v до глубины узла u
//        v = LiftNode(v, _depth[v] - _depth[u]);

//        // Если u и v совпадают, возвращаем любой из них
//        if (u == v)
//        {
//            return u;
//        }

//        // Бинарный подъём для поиска LCA
//        for (int j = _maxLog - 1; j >= 0; j--)
//        {
//            if (_up[u][j] != _up[v][j])
//            {
//                u = _up[u][j];
//                v = _up[v][j];
//            }
//        }

//        return _up[u][0];
//    }

//    // Поднятие узла на заданное количество уровней вверх
//    private TreeNode LiftNode(TreeNode node, int levels)
//    {
//        for (int j = _maxLog - 1; j >= 0; j--)
//        {
//            if (levels >= (1 << j))
//            {
//                node = _up[node][j];
//                levels -= (1 << j);
//            }
//        }
//        return node;
//    }

//    // Вычисление размера дерева
//    private int GetTreeSize(TreeNode node)
//    {
//        int size = 1;
//        foreach (TreeNode child in node.Children)
//        {
//            size += GetTreeSize(child);
//        }
//        return size;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример дерева
//        TreeNode root = new TreeNode(1);
//        TreeNode node2 = new TreeNode(2);
//        TreeNode node3 = new TreeNode(3);
//        TreeNode node4 = new TreeNode(4);
//        TreeNode node5 = new TreeNode(5);
//        TreeNode node6 = new TreeNode(6);
//        TreeNode node7 = new TreeNode(7);

//        root.Children.Add(node2);
//        root.Children.Add(node3);
//        node2.Children.Add(node4);
//        node2.Children.Add(node5);
//        node3.Children.Add(node6);
//        node3.Children.Add(node7);

//        Tree tree = new Tree(root);

//        // Поиск LCA
//        LCASolver lcaSolver = new LCASolver(tree);

//        TreeNode lca45 = lcaSolver.FindLCA(node4, node5);
//        Console.WriteLine($"LCA(4, 5) = {lca45.Value}"); // 2

//        TreeNode lca46 = lcaSolver.FindLCA(node4, node6);
//        Console.WriteLine($"LCA(4, 6) = {lca46.Value}"); // 1

//        TreeNode lca67 = lcaSolver.FindLCA(node6, node7);
//        Console.WriteLine($"LCA(6, 7) = {lca67.Value}"); // 3
//    }
//}


//using System;
//using System.Diagnostics;

//// Генерация большого дерева
//public class LargeTreeGenerator
//{
//    public static Tree GenerateTree(int size)
//    {
//        TreeNode root = new TreeNode(1);
//        GenerateChildren(root, size, 2);
//        return new Tree(root);
//    }

//    private static void GenerateChildren(TreeNode node, int remainingSize, int currentValue)
//    {
//        if (remainingSize <= 1)
//            return;

//        int childrenCount = Math.Min(remainingSize - 1, 3); // Не более 3 детей
//        for (int i = 0; i < childrenCount; i++)
//        {
//            TreeNode child = new TreeNode(currentValue++);
//            node.Children.Add(child);
//            GenerateChildren(child, remainingSize - 1, currentValue);
//            remainingSize--;
//        }
//    }
//}

//class PerformanceTest
//{
//    static void Main()
//    {
//        int treeSize = 1_000_000;
//        Tree largeTree = LargeTreeGenerator.GenerateTree(treeSize);

//        Stopwatch stopwatch = Stopwatch.StartNew();
//        LCASolver lcaSolver = new LCASolver(largeTree);
//        stopwatch.Stop();

//        Console.WriteLine($"Время предобработки дерева из {treeSize} узлов: {stopwatch.ElapsedMilliseconds} мс");

//        // Тестирование запросов LCA
//        Random random = new Random();
//        TreeNode[] nodes = new TreeNode[1000];
//        CollectRandomNodes(largeTree.Root, nodes, random);

//        stopwatch.Restart();
//        for (int i = 0; i < 1000; i += 2)
//        {
//            TreeNode lca = lcaSolver.FindLCA(nodes[i], nodes[i + 1]);
//        }
//        stopwatch.Stop();

//        Console.WriteLine($"Время выполнения 500 запросов LCA: {stopwatch.ElapsedMilliseconds} мс");
//    }

//    private static void CollectRandomNodes(TreeNode node, TreeNode[] nodes, Random random, int index = 0)
//    {
//        if (index >= nodes.Length)
//            return;

//        nodes[index] = node;
//        index++;

//        foreach (TreeNode child in node.Children)
//        {
//            CollectRandomNodes(child, nodes, random, index);
//        }
//    }
//}


////1.12: Минимальное остовное дерево (MST) - алгоритм Крускала с оптимизацией
//using System;
//using System.Collections.Generic;

//// Класс для представления ребра графа
//public class Edge : IComparable<Edge>
//{
//    public int From { get; }
//    public int To { get; }
//    public int Weight { get; }

//    public Edge(int from, int to, int weight)
//    {
//        From = from;
//        To = to;
//        Weight = weight;
//    }

//    public int CompareTo(Edge other)
//    {
//        return Weight.CompareTo(other.Weight);
//    }
//}

//// Класс для представления графа
//public class Graph
//{
//    private readonly int _vertices; // Количество вершин
//    private readonly List<Edge> _edges; // Список рёбер

//    public Graph(int vertices)
//    {
//        _vertices = vertices;
//        _edges = new List<Edge>();
//    }

//    // Добавление ребра
//    public void AddEdge(int from, int to, int weight)
//    {
//        _edges.Add(new Edge(from, to, weight));
//    }

//    // Получение списка рёбер
//    public List<Edge> GetEdges()
//    {
//        return _edges;
//    }

//    public int Vertices => _vertices;
//}


//// Класс для системы непересекающихся множеств
//public class UnionFind
//{
//    private int[] _parent;  // Массив родителей
//    private int[] _rank;    // Массив рангов

//    public UnionFind(int size)
//    {
//        _parent = new int[size];
//        _rank = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            _parent[i] = i;
//            _rank[i] = 0;
//        }
//    }

//    // Поиск корня множества с эвристикой сжатия путей
//    public int Find(int x)
//    {
//        if (_parent[x] != x)
//        {
//            _parent[x] = Find(_parent[x]); // Сжатие путей
//        }
//        return _parent[x];
//    }

//    // Объединение двух множеств с эвристикой объединения по рангу
//    public void Union(int x, int y)
//    {
//        int rootX = Find(x);
//        int rootY = Find(y);

//        if (rootX == rootY)
//            return;

//        // Объединение по рангу
//        if (_rank[rootX] < _rank[rootY])
//        {
//            _parent[rootX] = rootY;
//        }
//        else if (_rank[rootX] > _rank[rootY])
//        {
//            _parent[rootY] = rootX;
//        }
//        else
//        {
//            _parent[rootY] = rootX;
//            _rank[rootX]++;
//        }
//    }
//}


//using System;
//using System.Collections.Generic;

//// Класс для поиска минимального остовного дерева (MST)
//public class KruskalMST
//{
//    public static List<Edge> FindMST(Graph graph)
//    {
//        List<Edge> edges = graph.GetEdges();
//        edges.Sort(); // Сортируем рёбра по весу

//        UnionFind uf = new UnionFind(graph.Vertices);
//        List<Edge> mst = new List<Edge>();

//        foreach (Edge edge in edges)
//        {
//            int fromRoot = uf.Find(edge.From);
//            int toRoot = uf.Find(edge.To);

//            if (fromRoot != toRoot)
//            {
//                mst.Add(edge);
//                uf.Union(edge.From, edge.To);
//            }
//        }

//        return mst;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример графа
//        Graph graph = new Graph(4);
//        graph.AddEdge(0, 1, 10);
//        graph.AddEdge(0, 2, 6);
//        graph.AddEdge(0, 3, 5);
//        graph.AddEdge(1, 3, 15);
//        graph.AddEdge(2, 3, 4);

//        // Поиск MST
//        List<Edge> mst = KruskalMST.FindMST(graph);

//        // Вывод MST
//        Console.WriteLine("Минимальное остовное дерево:");
//        foreach (Edge edge in mst)
//        {
//            Console.WriteLine($"{edge.From} -- {edge.To} (вес: {edge.Weight})");
//        }
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 10_000;
//        int edges = 100_000;
//        Graph graph = new Graph(vertices);
//        Random random = new Random();

//        // Заполнение графа случайными рёбрами
//        for (int i = 0; i < edges; i++)
//        {
//            int from = random.Next(vertices);
//            int to = random.Next(vertices);
//            int weight = random.Next(1, 100);
//            graph.AddEdge(from, to, weight);
//        }

//        // Поиск MST
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        List<Edge> mst = KruskalMST.FindMST(graph);
//        stopwatch.Stop();

//        Console.WriteLine($"Количество рёбер в MST: {mst.Count}");
//        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.13: Сильно связные компоненты (SCC) - алгоритм Косарайю
//using System;
//using System.Collections.Generic;

//// Класс для представления ориентированного графа
//public class DirectedGraph
//{
//    private readonly int _vertices; // Количество вершин
//    private readonly List<List<int>> _adjacencyList; // Список смежности
//    private readonly List<List<int>> _transposedAdjacencyList; // Транспонированный список смежности

//    public DirectedGraph(int vertices)
//    {
//        _vertices = vertices;
//        _adjacencyList = new List<List<int>>();
//        _transposedAdjacencyList = new List<List<int>>();
//        for (int i = 0; i < vertices; i++)
//        {
//            _adjacencyList.Add(new List<int>());
//            _transposedAdjacencyList.Add(new List<int>());
//        }
//    }

//    // Добавление ориентированного ребра
//    public void AddEdge(int from, int to)
//    {
//        _adjacencyList[from].Add(to);
//        _transposedAdjacencyList[to].Add(from); // Для транспонированного графа
//    }

//    // Получение списка смежности для вершины
//    public List<int> GetAdjacentVertices(int vertex)
//    {
//        return _adjacencyList[vertex];
//    }

//    // Получение транспонированного списка смежности для вершины
//    public List<int> GetTransposedAdjacentVertices(int vertex)
//    {
//        return _transposedAdjacencyList[vertex];
//    }

//    public int Vertices => _vertices;
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;

//// Класс для поиска сильно связных компонент (SCC)
//public class KosarajuSCC
//{
//    private readonly DirectedGraph _graph;
//    private bool[] _visited; // Массив посещённых вершин
//    private Stack<int> _orderStack; // Стек для хранения порядка обхода
//    private List<List<int>> _sccs; // Список сильно связных компонент

//    public KosarajuSCC(DirectedGraph graph)
//    {
//        _graph = graph;
//        _visited = new bool[graph.Vertices];
//        _orderStack = new Stack<int>();
//        _sccs = new List<List<int>>();
//    }

//    // Поиск сильно связных компонент
//    public List<List<int>> FindSCCs()
//    {
//        // Первый проход: заполнение стека порядка обхода
//        for (int i = 0; i < _graph.Vertices; i++)
//        {
//            if (!_visited[i])
//            {
//                FirstDfs(i);
//            }
//        }

//        // Сброс массива посещённых вершин
//        _visited = new bool[_graph.Vertices];

//        // Второй проход: обработка транспонированного графа
//        while (_orderStack.Count > 0)
//        {
//            int vertex = _orderStack.Pop();
//            if (!_visited[vertex])
//            {
//                List<int> scc = new List<int>();
//                SecondDfs(vertex, scc);
//                _sccs.Add(scc);
//            }
//        }

//        return _sccs;
//    }

//    // Первый проход DFS: заполнение стека
//    private void FirstDfs(int vertex)
//    {
//        _visited[vertex] = true;
//        foreach (int neighbor in _graph.GetAdjacentVertices(vertex))
//        {
//            if (!_visited[neighbor])
//            {
//                FirstDfs(neighbor);
//            }
//        }
//        _orderStack.Push(vertex);
//    }

//    // Второй проход DFS: поиск SCC
//    private void SecondDfs(int vertex, List<int> scc)
//    {
//        _visited[vertex] = true;
//        scc.Add(vertex);
//        foreach (int neighbor in _graph.GetTransposedAdjacentVertices(vertex))
//        {
//            if (!_visited[neighbor])
//            {
//                SecondDfs(neighbor, scc);
//            }
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример ориентированного графа
//        DirectedGraph graph = new DirectedGraph(5);
//        graph.AddEdge(0, 1);
//        graph.AddEdge(1, 2);
//        graph.AddEdge(2, 0);
//        graph.AddEdge(1, 3);
//        graph.AddEdge(3, 4);

//        // Поиск сильно связных компонент
//        KosarajuSCC kosaraju = new KosarajuSCC(graph);
//        List<List<int>> sccs = kosaraju.FindSCCs();

//        // Вывод сильно связных компонент
//        Console.WriteLine("Сильно связные компоненты:");
//        for (int i = 0; i < sccs.Count; i++)
//        {
//            Console.WriteLine($"Компонента {i + 1}: {string.Join(", ", sccs[i])}");
//        }
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 10_000;
//        int edges = 100_000;
//        DirectedGraph graph = new DirectedGraph(vertices);
//        Random random = new Random();

//        // Заполнение графа случайными рёбрами
//        for (int i = 0; i < edges; i++)
//        {
//            int from = random.Next(vertices);
//            int to = random.Next(vertices);
//            graph.AddEdge(from, to);
//        }

//        // Поиск сильно связных компонент
//        KosarajuSCC kosaraju = new KosarajuSCC(graph);
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        var sccs = kosaraju.FindSCCs();
//        stopwatch.Stop();

//        Console.WriteLine($"Количество сильно связных компонент: {sccs.Count}");
//        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.14: Задача коммивояжера(TSP) -приближенные алгоритмы
//using System;
//using System.Collections.Generic;

//// Класс для представления графа
//public class TSPGraph
//{
//    private readonly int _vertices; // Количество вершин
//    private readonly int[,] _distances; // Матрица расстояний

//    public TSPGraph(int vertices)
//    {
//        _vertices = vertices;
//        _distances = new int[vertices, vertices];
//    }

//    // Установка расстояния между вершинами
//    public void SetDistance(int from, int to, int distance)
//    {
//        _distances[from, to] = distance;
//        _distances[to, from] = distance; // Для неориентированного графа
//    }

//    // Получение расстояния между вершинами
//    public int GetDistance(int from, int to)
//    {
//        return _distances[from, to];
//    }

//    public int Vertices => _vertices;
//}


//using System;
//using System.Collections.Generic;

//// Жадный алгоритм (Nearest Neighbor)
//public class NearestNeighborTSP
//{
//    public static List<int> Solve(TSPGraph graph)
//    {
//        int vertices = graph.Vertices;
//        List<int> path = new List<int> { 0 }; // Начинаем с вершины 0
//        bool[] visited = new bool[vertices];
//        visited[0] = true;

//        for (int i = 1; i < vertices; i++)
//        {
//            int last = path[^1];
//            int next = FindNearestNeighbor(graph, last, visited);
//            path.Add(next);
//            visited[next] = true;
//        }

//        // Возвращаемся в начальную вершину
//        path.Add(0);

//        return path;
//    }

//    // Поиск ближайшего непосещённого соседа
//    private static int FindNearestNeighbor(TSPGraph graph, int current, bool[] visited)
//    {
//        int nearest = -1;
//        int minDistance = int.MaxValue;

//        for (int i = 0; i < graph.Vertices; i++)
//        {
//            if (!visited[i] && graph.GetDistance(current, i) < minDistance)
//            {
//                minDistance = graph.GetDistance(current, i);
//                nearest = i;
//            }
//        }

//        return nearest;
//    }
//}


//using System;
//using System.Collections.Generic;

//// Алгоритм двойного дерева (MST-based)
//public class MSTBasedTSP
//{
//    public static List<int> Solve(TSPGraph graph)
//    {
//        // Построение минимального остовного дерева (MST)
//        List<Edge> mst = KruskalMST.FindMST(ConvertToGraph(graph));

//        // Построение обхода дерева (Pre-order traversal)
//        List<int> path = PreOrderTraversal(mst, graph.Vertices);

//        // Удаление повторяющихся вершин
//        path = RemoveDuplicateVertices(path);

//        return path;
//    }

//    // Преобразование TSPGraph в Graph для алгоритма Крускала
//    private static Graph ConvertToGraph(TSPGraph tspGraph)
//    {
//        Graph graph = new Graph(tspGraph.Vertices);
//        for (int i = 0; i < tspGraph.Vertices; i++)
//        {
//            for (int j = i + 1; j < tspGraph.Vertices; j++)
//            {
//                graph.AddEdge(i, j, tspGraph.GetDistance(i, j));
//            }
//        }
//        return graph;
//    }

//    // Обход дерева в прямом порядке (Pre-order traversal)
//    private static List<int> PreOrderTraversal(List<Edge> mst, int vertices)
//    {
//        Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
//        foreach (int i in Enumerable.Range(0, vertices))
//        {
//            adjacencyList[i] = new List<int>();
//        }

//        foreach (Edge edge in mst)
//        {
//            adjacencyList[edge.From].Add(edge.To);
//            adjacencyList[edge.To].Add(edge.From);
//        }

//        List<int> path = new List<int>();
//        bool[] visited = new bool[vertices];
//        Dfs(0, adjacencyList, visited, path);

//        return path;
//    }

//    // Рекурсивный обход в глубину (DFS)
//    private static void Dfs(int vertex, Dictionary<int, List<int>> adjacencyList, bool[] visited, List<int> path)
//    {
//        visited[vertex] = true;
//        path.Add(vertex);

//        foreach (int neighbor in adjacencyList[vertex])
//        {
//            if (!visited[neighbor])
//            {
//                Dfs(neighbor, adjacencyList, visited, path);
//            }
//        }
//    }

//    // Удаление повторяющихся вершин
//    private static List<int> RemoveDuplicateVertices(List<int> path)
//    {
//        List<int> uniquePath = new List<int> { path[0] };
//        for (int i = 1; i < path.Count; i++)
//        {
//            if (path[i] != uniquePath[^1])
//            {
//                uniquePath.Add(path[i]);
//            }
//        }
//        return uniquePath;
//    }
//}

//// Класс для представления ребра графа
//public class Edge : IComparable<Edge>
//{
//    public int From { get; }
//    public int To { get; }
//    public int Weight { get; }

//    public Edge(int from, int to, int weight)
//    {
//        From = from;
//        To = to;
//        Weight = weight;
//    }

//    public int CompareTo(Edge other)
//    {
//        return Weight.CompareTo(other.Weight);
//    }
//}

//// Класс для представления графа
//public class Graph
//{
//    private readonly int _vertices;
//    private readonly List<Edge> _edges;

//    public Graph(int vertices)
//    {
//        _vertices = vertices;
//        _edges = new List<Edge>();
//    }

//    public void AddEdge(int from, int to, int weight)
//    {
//        _edges.Add(new Edge(from, to, weight));
//    }

//    public List<Edge> GetEdges()
//    {
//        return _edges;
//    }

//    public int Vertices => _vertices;
//}

//// Алгоритм Крускала для поиска MST
//public class KruskalMST
//{
//    public static List<Edge> FindMST(Graph graph)
//    {
//        List<Edge> edges = graph.GetEdges();
//        edges.Sort();

//        UnionFind uf = new UnionFind(graph.Vertices);
//        List<Edge> mst = new List<Edge>();

//        foreach (Edge edge in edges)
//        {
//            if (uf.Find(edge.From) != uf.Find(edge.To))
//            {
//                mst.Add(edge);
//                uf.Union(edge.From, edge.To);
//            }
//        }

//        return mst;
//    }
//}

//// Система непересекающихся множеств (Union-Find)
//public class UnionFind
//{
//    private int[] _parent;
//    private int[] _rank;

//    public UnionFind(int size)
//    {
//        _parent = new int[size];
//        _rank = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            _parent[i] = i;
//            _rank[i] = 0;
//        }
//    }

//    public int Find(int x)
//    {
//        if (_parent[x] != x)
//        {
//            _parent[x] = Find(_parent[x]);
//        }
//        return _parent[x];
//    }

//    public void Union(int x, int y)
//    {
//        int rootX = Find(x);
//        int rootY = Find(y);

//        if (rootX == rootY)
//            return;

//        if (_rank[rootX] < _rank[rootY])
//        {
//            _parent[rootX] = rootY;
//        }
//        else if (_rank[rootX] > _rank[rootY])
//        {
//            _parent[rootY] = rootX;
//        }
//        else
//        {
//            _parent[rootY] = rootX;
//            _rank[rootX]++;
//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример графа для TSP
//        TSPGraph graph = new TSPGraph(4);
//        graph.SetDistance(0, 1, 10);
//        graph.SetDistance(0, 2, 15);
//        graph.SetDistance(0, 3, 20);
//        graph.SetDistance(1, 2, 35);
//        graph.SetDistance(1, 3, 25);
//        graph.SetDistance(2, 3, 30);

//        // Жадный алгоритм
//        List<int> nearestNeighborPath = NearestNeighborTSP.Solve(graph);
//        Console.WriteLine("Жадный алгоритм (Nearest Neighbor):");
//        Console.WriteLine(string.Join(" -> ", nearestNeighborPath));

//        // Алгоритм двойного дерева
//        List<int> mstBasedPath = MSTBasedTSP.Solve(graph);
//        Console.WriteLine("\nАлгоритм двойного дерева (MST-based):");
//        Console.WriteLine(string.Join(" -> ", mstBasedPath));
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 100;
//        TSPGraph graph = new TSPGraph(vertices);
//        Random random = new Random();

//        // Заполнение графа случайными расстояниями
//        for (int i = 0; i < vertices; i++)
//        {
//            for (int j = i + 1; j < vertices; j++)
//            {
//                graph.SetDistance(i, j, random.Next(1, 100));
//            }
//        }

//        // Жадный алгоритм
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        List<int> nearestNeighborPath = NearestNeighborTSP.Solve(graph);
//        stopwatch.Stop();
//        Console.WriteLine($"Жадный алгоритм: {stopwatch.ElapsedMilliseconds} мс");

//        // Алгоритм двойного дерева
//        stopwatch.Restart();
//        List<int> mstBasedPath = MSTBasedTSP.Solve(graph);
//        stopwatch.Stop();
//        Console.WriteLine($"Алгоритм двойного дерева: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.15: Поиск циклов в графах - Обнаружение отрицательных циклов
//using System;
//using System.Collections.Generic;

//// Класс для представления ребра графа
//public class Edge
//{
//    public int From { get; }
//    public int To { get; }
//    public int Weight { get; }

//    public Edge(int from, int to, int weight)
//    {
//        From = from;
//        To = to;
//        Weight = weight;
//    }
//}

//// Класс для представления графа
//public class Graph
//{
//    private readonly int _vertices; // Количество вершин
//    private readonly List<Edge> _edges; // Список рёбер

//    public Graph(int vertices)
//    {
//        _vertices = vertices;
//        _edges = new List<Edge>();
//    }

//    // Добавление ребра
//    public void AddEdge(int from, int to, int weight)
//    {
//        _edges.Add(new Edge(from, to, weight));
//    }

//    // Получение списка рёбер
//    public List<Edge> GetEdges()
//    {
//        return _edges;
//    }

//    public int Vertices => _vertices;
//}


//using System;
//using System.Collections.Generic;

//// Класс для поиска отрицательных циклов
//public class NegativeCycleDetector
//{
//    public static bool HasNegativeCycle(Graph graph)
//    {
//        int vertices = graph.Vertices;
//        int[] distance = new int[vertices];
//        Array.Fill(distance, int.MaxValue);
//        distance[0] = 0; // Начинаем с вершины 0

//        // Основной цикл алгоритма Беллмана-Форда
//        for (int i = 0; i < vertices - 1; i++)
//        {
//            foreach (Edge edge in graph.GetEdges())
//            {
//                if (distance[edge.From] != int.MaxValue && distance[edge.To] > distance[edge.From] + edge.Weight)
//                {
//                    distance[edge.To] = distance[edge.From] + edge.Weight;
//                }
//            }
//        }

//        // Проверка на наличие отрицательных циклов
//        foreach (Edge edge in graph.GetEdges())
//        {
//            if (distance[edge.From] != int.MaxValue && distance[edge.To] > distance[edge.From] + edge.Weight)
//            {
//                return true; // Отрицательный цикл найден
//            }
//        }

//        return false; // Отрицательных циклов нет
//    }

//    // Поиск всех вершин, участвующих в отрицательных циклах
//    public static List<int> FindNegativeCycleVertices(Graph graph)
//    {
//        int vertices = graph.Vertices;
//        int[] distance = new int[vertices];
//        Array.Fill(distance, int.MaxValue);
//        distance[0] = 0;

//        int[] predecessor = new int[vertices];
//        Array.Fill(predecessor, -1);

//        // Основной цикл алгоритма Беллмана-Форда
//        for (int i = 0; i < vertices - 1; i++)
//        {
//            foreach (Edge edge in graph.GetEdges())
//            {
//                if (distance[edge.From] != int.MaxValue && distance[edge.To] > distance[edge.From] + edge.Weight)
//                {
//                    distance[edge.To] = distance[edge.From] + edge.Weight;
//                    predecessor[edge.To] = edge.From;
//                }
//            }
//        }

//        // Проверка на наличие отрицательных циклов
//        List<int> negativeCycleVertices = new List<int>();
//        for (int i = 0; i < vertices; i++)
//        {
//            foreach (Edge edge in graph.GetEdges())
//            {
//                if (distance[edge.From] != int.MaxValue && distance[edge.To] > distance[edge.From] + edge.Weight)
//                {
//                    // Находим вершины, участвующие в отрицательном цикле
//                    int current = edge.To;
//                    for (int j = 0; j < vertices; j++)
//                    {
//                        current = predecessor[current];
//                    }

//                    // Проверяем, что цикл действительно отрицательный
//                    int cycleStart = current;
//                    List<int> cycle = new List<int> { cycleStart };
//                    current = predecessor[current];
//                    while (current != cycleStart && current != -1)
//                    {
//                        cycle.Add(current);
//                        current = predecessor[current];
//                    }

//                    if (current == cycleStart)
//                    {
//                        negativeCycleVertices.AddRange(cycle);
//                    }
//                }
//            }
//        }

//        return negativeCycleVertices.Distinct().ToList();
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример графа с отрицательным циклом
//        Graph graph = new Graph(4);
//        graph.AddEdge(0, 1, 1);
//        graph.AddEdge(1, 2, -1);
//        graph.AddEdge(2, 3, -1);
//        graph.AddEdge(3, 0, -1);

//        // Проверка на наличие отрицательных циклов
//        bool hasNegativeCycle = NegativeCycleDetector.HasNegativeCycle(graph);
//        Console.WriteLine("Граф содержит отрицательный цикл: " + hasNegativeCycle);

//        // Поиск вершин, участвующих в отрицательных циклах
//        List<int> negativeCycleVertices = NegativeCycleDetector.FindNegativeCycleVertices(graph);
//        Console.WriteLine("Вершины, участвующие в отрицательных циклах:");
//        foreach (int vertex in negativeCycleVertices)
//        {
//            Console.WriteLine(vertex);
//        }
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 1000;
//        int edges = 10000;
//        Graph graph = new Graph(vertices);
//        Random random = new Random();

//        // Заполнение графа случайными рёбрами
//        for (int i = 0; i < edges; i++)
//        {
//            int from = random.Next(vertices);
//            int to = random.Next(vertices);
//            int weight = random.Next(-10, 10); // Веса могут быть отрицательными
//            graph.AddEdge(from, to, weight);
//        }

//        // Проверка на наличие отрицательных циклов
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        bool hasNegativeCycle = NegativeCycleDetector.HasNegativeCycle(graph);
//        stopwatch.Stop();

//        Console.WriteLine("Граф содержит отрицательный цикл: " + hasNegativeCycle);
//        Console.WriteLine("Время выполнения: " + stopwatch.ElapsedMilliseconds + " мс");
//    }
//}


////1.16: Неориентированное минимальное островное дерево с ограничениями
//using System;
//using System.Collections.Generic;

//// Класс для представления ребра графа
//public class Edge : IComparable<Edge>
//{
//    public int From { get; }
//    public int To { get; }
//    public int Weight { get; }

//    public Edge(int from, int to, int weight)
//    {
//        From = from;
//        To = to;
//        Weight = weight;
//    }

//    public int CompareTo(Edge other)
//    {
//        return Weight.CompareTo(other.Weight);
//    }
//}

//// Класс для представления графа с ограничениями
//public class ConstrainedGraph
//{
//    private readonly int _vertices; // Количество вершин
//    private readonly List<Edge> _edges; // Список рёбер
//    private readonly int[] _maxDegrees; // Ограничения на степени вершин

//    public ConstrainedGraph(int vertices, int[] maxDegrees)
//    {
//        _vertices = vertices;
//        _edges = new List<Edge>();
//        _maxDegrees = maxDegrees;
//    }

//    // Добавление ребра
//    public void AddEdge(int from, int to, int weight)
//    {
//        _edges.Add(new Edge(from, to, weight));
//    }

//    // Получение списка рёбер
//    public List<Edge> GetEdges()
//    {
//        return _edges;
//    }

//    // Получение ограничения на степень вершины
//    public int GetMaxDegree(int vertex)
//    {
//        return _maxDegrees[vertex];
//    }

//    public int Vertices => _vertices;
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;

//// Алгоритм Прима с ограничениями на степени вершин
//public class ConstrainedPrimMST
//{
//    public static List<Edge> FindMST(ConstrainedGraph graph)
//    {
//        int vertices = graph.Vertices;
//        List<Edge> mst = new List<Edge>();
//        int[] degrees = new int[vertices]; // Текущие степени вершин
//        bool[] inMST = new bool[vertices]; // Принадлежность вершины MST
//        int[] minWeight = new int[vertices]; // Минимальный вес ребра до вершины
//        int[] parent = new int[vertices]; // Родитель вершины в MST

//        // Инициализация
//        Array.Fill(minWeight, int.MaxValue);
//        Array.Fill(parent, -1);
//        minWeight[0] = 0; // Начинаем с вершины 0

//        // Приоритетная очередь для выбора вершины с минимальным весом ребра
//        PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
//        priorityQueue.Enqueue(0, 0);

//        while (priorityQueue.Count > 0)
//        {
//            int u = priorityQueue.Dequeue();
//            inMST[u] = true;

//            // Проверка ограничения на степень вершины
//            if (degrees[u] >= graph.GetMaxDegree(u))
//                continue;

//            // Добавляем ребро в MST, если родитель существует
//            if (parent[u] != -1)
//            {
//                mst.Add(new Edge(parent[u], u, minWeight[u]));
//                degrees[u]++;
//                degrees[parent[u]]++;
//            }

//            // Обновляем минимальные веса для соседей
//            foreach (Edge edge in graph.GetEdges().Where(e => e.From == u || e.To == u))
//            {
//                int v = edge.From == u ? edge.To : edge.From;
//                if (!inMST[v] && edge.Weight < minWeight[v] && degrees[v] < graph.GetMaxDegree(v))
//                {
//                    minWeight[v] = edge.Weight;
//                    parent[v] = u;
//                    priorityQueue.Enqueue(v, minWeight[v]);
//                }
//            }
//        }

//        return mst;
//    }
//}

//// Приоритетная очередь для алгоритма Прима
//public class PriorityQueue<T>
//{
//    private readonly List<(T Item, int Priority)> _elements = new List<(T, int)>();

//    public int Count => _elements.Count;

//    public void Enqueue(T item, int priority)
//    {
//        _elements.Add((item, priority));
//        int childIndex = Count - 1;
//        while (childIndex > 0)
//        {
//            int parentIndex = (childIndex - 1) / 2;
//            if (_elements[childIndex].Priority >= _elements[parentIndex].Priority)
//                break;
//            Swap(childIndex, parentIndex);
//            childIndex = parentIndex;
//        }
//    }

//    public T Dequeue()
//    {
//        var frontItem = _elements[0].Item;
//        int lastIndex = Count - 1;
//        _elements[0] = _elements[lastIndex];
//        _elements.RemoveAt(lastIndex);

//        lastIndex--;
//        int parentIndex = 0;
//        while (true)
//        {
//            int leftChildIndex = parentIndex * 2 + 1;
//            if (leftChildIndex > lastIndex)
//                break;
//            int rightChildIndex = leftChildIndex + 1;
//            if (rightChildIndex <= lastIndex && _elements[rightChildIndex].Priority < _elements[leftChildIndex].Priority)
//                leftChildIndex = rightChildIndex;
//            if (_elements[parentIndex].Priority <= _elements[leftChildIndex].Priority)
//                break;
//            Swap(parentIndex, leftChildIndex);
//            parentIndex = leftChildIndex;
//        }

//        return frontItem;
//    }

//    private void Swap(int i, int j)
//    {
//        var tmp = _elements[i];
//        _elements[i] = _elements[j];
//        _elements[j] = tmp;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        // Пример графа с ограничениями на степени вершин
//        int vertices = 4;
//        int[] maxDegrees = { 2, 2, 2, 2 }; // Ограничения на степени вершин
//        ConstrainedGraph graph = new ConstrainedGraph(vertices, maxDegrees);

//        // Добавляем рёбра
//        graph.AddEdge(0, 1, 10);
//        graph.AddEdge(0, 2, 6);
//        graph.AddEdge(0, 3, 5);
//        graph.AddEdge(1, 3, 15);
//        graph.AddEdge(2, 3, 4);

//        // Поиск минимального остовного дерева с ограничениями
//        List<Edge> mst = ConstrainedPrimMST.FindMST(graph);

//        // Вывод минимального остовного дерева
//        Console.WriteLine("Минимальное остовное дерево с ограничениями:");
//        foreach (Edge edge in mst)
//        {
//            Console.WriteLine($"{edge.From} -- {edge.To} (вес: {edge.Weight})");
//        }
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        int vertices = 1000;
//        int[] maxDegrees = new int[vertices];
//        Random random = new Random();

//        // Заполнение ограничений на степени вершин
//        for (int i = 0; i < vertices; i++)
//        {
//            maxDegrees[i] = random.Next(2, 5); // Ограничения от 2 до 4
//        }

//        ConstrainedGraph graph = new ConstrainedGraph(vertices, maxDegrees);

//        // Заполнение графа случайными рёбрами
//        for (int i = 0; i < vertices; i++)
//        {
//            for (int j = i + 1; j < vertices; j++)
//            {
//                if (random.NextDouble() < 0.1) // Вероятность добавления ребра
//                {
//                    graph.AddEdge(i, j, random.Next(1, 100));
//                }
//            }
//        }

//        // Поиск минимального остовного дерева с ограничениями
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        List<Edge> mst = ConstrainedPrimMST.FindMST(graph);
//        stopwatch.Stop();

//        Console.WriteLine($"Количество рёбер в MST: {mst.Count}");
//        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.17: Сопоставление шаблонов в текстах - алгоритм KMP
//using System;

//// Класс для реализации алгоритма KMP
//public class KMP
//{
//    // Построение префикс-функции для шаблона
//    private static int[] ComputePrefixFunction(string pattern)
//    {
//        int m = pattern.Length;
//        int[] prefixFunction = new int[m];
//        int j = 0;

//        for (int i = 1; i < m; i++)
//        {
//            while (j > 0 && pattern[i] != pattern[j])
//            {
//                j = prefixFunction[j - 1];
//            }

//            if (pattern[i] == pattern[j])
//            {
//                j++;
//            }

//            prefixFunction[i] = j;
//        }

//        return prefixFunction;
//    }

//    // Поиск всех вхождений шаблона в тексте
//    public static List<int> Search(string text, string pattern)
//    {
//        List<int> occurrences = new List<int>();
//        int n = text.Length;
//        int m = pattern.Length;

//        if (m == 0 || n < m)
//        {
//            return occurrences;
//        }

//        int[] prefixFunction = ComputePrefixFunction(pattern);
//        int j = 0;

//        for (int i = 0; i < n; i++)
//        {
//            while (j > 0 && text[i] != pattern[j])
//            {
//                j = prefixFunction[j - 1];
//            }

//            if (text[i] == pattern[j])
//            {
//                j++;
//            }

//            if (j == m)
//            {
//                occurrences.Add(i - m + 1);
//                j = prefixFunction[j - 1];
//            }
//        }

//        return occurrences;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        string text = "ABABDABACDABABCABAB";
//        string pattern = "ABABCABAB";

//        // Поиск подстроки
//        List<int> occurrences = KMP.Search(text, pattern);

//        // Вывод результатов
//        Console.WriteLine($"Текст: {text}");
//        Console.WriteLine($"Шаблон: {pattern}");
//        Console.WriteLine("Позиции вхождений:");
//        foreach (int position in occurrences)
//        {
//            Console.WriteLine(position);
//        }
//    }
//}
//using System;
//using System.Diagnostics;
//using System.Text;

//class PerformanceTest
//{
//    static void Main()
//    {
//        // Генерация большого текста и шаблона
//        StringBuilder textBuilder = new StringBuilder();
//        Random random = new Random();
//        for (int i = 0; i < 1_000_000; i++)
//        {
//            textBuilder.Append((char)random.Next('A', 'Z' + 1));
//        }
//        string text = textBuilder.ToString();

//        StringBuilder patternBuilder = new StringBuilder();
//        for (int i = 0; i < 1000; i++)
//        {
//            patternBuilder.Append((char)random.Next('A', 'Z' + 1));
//        }
//        string pattern = patternBuilder.ToString();

//        // Поиск подстроки
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        List<int> occurrences = KMP.Search(text, pattern);
//        stopwatch.Stop();

//        Console.WriteLine($"Количество вхождений: {occurrences.Count}");
//        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.18: Алгоритм Рабина-Карпа для поиска шаблонов
//using System;
//using System.Collections.Generic;

//// Класс для реализации алгоритма Рабина-Карпа
//public class RabinKarp
//{
//    private const int Prime = 101; // Простое число для хеширования
//    private const int Base = 256;  // Основание для хеширования (количество символов в алфавите)

//    // Вычисление хеша строки
//    private static long ComputeHash(string str, int length)
//    {
//        long hash = 0;
//        for (int i = 0; i < length; i++)
//        {
//            hash = (hash * Base + str[i]) % Prime;
//        }
//        return hash;
//    }

//    // Вычисление хеша для скользящего окна
//    private static long RollingHash(long previousHash, char oldChar, char newChar, int length, long power)
//    {
//        long hash = (previousHash - oldChar * power % Prime + Prime) % Prime;
//        hash = (hash * Base + newChar) % Prime;
//        return hash;
//    }

//    // Вычисление степени основания
//    private static long ComputePower(int length)
//    {
//        long power = 1;
//        for (int i = 0; i < length - 1; i++)
//        {
//            power = (power * Base) % Prime;
//        }
//        return power;
//    }


//    // Поиск всех вхождений шаблона в тексте
//    public static List<int> Search(string text, string pattern)
//    {
//        List<int> occurrences = new List<int>();
//        int n = text.Length;
//        int m = pattern.Length;

//        if (m == 0 || n < m)
//        {
//            return occurrences;
//        }

//        long patternHash = ComputeHash(pattern, m);
//        long textHash = ComputeHash(text, m);
//        long power = ComputePower(m);

//        if (textHash == patternHash && text.Substring(0, m) == pattern)
//        {
//            occurrences.Add(0);
//        }

//        for (int i = 1; i <= n - m; i++)
//        {
//            textHash = RollingHash(textHash, text[i - 1], text[i + m - 1], m, power);

//            if (textHash == patternHash && text.Substring(i, m) == pattern)
//            {
//                occurrences.Add(i);
//            }
//        }

//        return occurrences;
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        string text = "GEEKS FOR GEEKS";
//        string pattern = "GEEK";

//        // Поиск подстроки
//        List<int> occurrences = RabinKarp.Search(text, pattern);

//        // Вывод результатов
//        Console.WriteLine($"Текст: {text}");
//        Console.WriteLine($"Шаблон: {pattern}");
//        Console.WriteLine("Позиции вхождений:");
//        foreach (int position in occurrences)
//        {
//            Console.WriteLine(position);
//        }
//    }
//}


//using System;
//using System.Diagnostics;
//using System.Text;

//class PerformanceTest
//{
//    static void Main()
//    {
//        // Генерация большого текста и шаблона
//        StringBuilder textBuilder = new StringBuilder();
//        Random random = new Random();
//        for (int i = 0; i < 1_000_000; i++)
//        {
//            textBuilder.Append((char)random.Next('A', 'Z' + 1));
//        }
//        string text = textBuilder.ToString();

//        StringBuilder patternBuilder = new StringBuilder();
//        for (int i = 0; i < 100; i++)
//        {
//            patternBuilder.Append((char)random.Next('A', 'Z' + 1));
//        }
//        string pattern = patternBuilder.ToString();

//        // Поиск подстроки
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        List<int> occurrences = RabinKarp.Search(text, pattern);
//        stopwatch.Stop();

//        Console.WriteLine($"Количество вхождений: {occurrences.Count}");
//        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.19: Сортировка массивов драгоценного размера (внешняя сортировка)
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//// Класс для чтения и записи фрагментов
//public class ChunkManager
//{
//    private readonly string _directory;

//    public ChunkManager(string directory)
//    {
//        _directory = directory;
//        Directory.CreateDirectory(directory);
//    }

//    // Запись фрагмента в файл
//    public void WriteChunk(int[] chunk, int chunkIndex)
//    {
//        string filePath = Path.Combine(_directory, $"chunk_{chunkIndex}.bin");
//        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
//        {
//            foreach (int number in chunk)
//            {
//                writer.Write(number);
//            }
//        }
//    }

//    // Чтение фрагмента из файла
//    public List<int> ReadChunk(int chunkIndex)
//    {
//        string filePath = Path.Combine(_directory, $"chunk_{chunkIndex}.bin");
//        List<int> chunk = new List<int>();
//        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
//        {
//            while (reader.BaseStream.Position < reader.BaseStream.Length)
//            {
//                chunk.Add(reader.ReadInt32());
//            }
//        }
//        return chunk;
//    }

//    // Получение количества фрагментов
//    public int GetChunkCount()
//    {
//        return Directory.GetFiles(_directory, "chunk_*.bin").Length;
//    }

//    // Удаление всех фрагментов
//    public void CleanUp()
//    {
//        foreach (string file in Directory.GetFiles(_directory, "chunk_*.bin"))
//        {
//            File.Delete(file);
//        }
//    }
//}


//// Разделение массива на отсортированные фрагменты
//public static void SplitIntoSortedChunks(int[] array, int chunkSize, ChunkManager chunkManager)
//{
//    int chunkIndex = 0;
//    for (int i = 0; i < array.Length; i += chunkSize)
//    {
//        int end = Math.Min(i + chunkSize, array.Length);
//        int[] chunk = new int[end - i];
//        Array.Copy(array, i, chunk, 0, end - i);
//        Array.Sort(chunk);
//        chunkManager.WriteChunk(chunk, chunkIndex);
//        chunkIndex++;
//    }
//}


//// k-путевое слияние отсортированных фрагментов
//public static List<int> MergeSortedChunks(ChunkManager chunkManager, int chunkCount)
//{
//    // Приоритетная очередь для слияния
//    PriorityQueue<(int Value, int ChunkIndex, int Position)> priorityQueue =
//        new PriorityQueue<(int, int, int)>();

//    // Инициализация очереди первыми элементами каждого фрагмента
//    for (int i = 0; i < chunkCount; i++)
//    {
//        List<int> chunk = chunkManager.ReadChunk(i);
//        if (chunk.Count > 0)
//        {
//            priorityQueue.Enqueue((chunk[0], i, 0), chunk[0]);
//        }
//    }

//    List<int> result = new List<int>();

//    while (priorityQueue.Count > 0)
//    {
//        var (value, chunkIndex, position) = priorityQueue.Dequeue();
//        result.Add(value);

//        List<int> chunk = chunkManager.ReadChunk(chunkIndex);
//        if (position + 1 < chunk.Count)
//        {
//            priorityQueue.Enqueue((chunk[position + 1], chunkIndex, position + 1), chunk[position + 1]);
//        }
//    }

//    return result;
//}

//// Приоритетная очередь для слияния
//public class PriorityQueue<T> where T : IComparable<T>
//{
//    private readonly List<T> _elements = new List<T>();

//    public int Count => _elements.Count;

//    public void Enqueue(T item, int priority)
//    {
//        _elements.Add((dynamic)(item, priority));
//        int childIndex = Count - 1;
//        while (childIndex > 0)
//        {
//            int parentIndex = (childIndex - 1) / 2;
//            if (_elements[childIndex].priority >= _elements[parentIndex].priority)
//                break;
//            Swap(childIndex, parentIndex);
//            childIndex = parentIndex;
//        }
//    }

//    public T Dequeue()
//    {
//        var frontItem = _elements[0].Item1;
//        int lastIndex = Count - 1;
//        _elements[0] = _elements[lastIndex];
//        _elements.RemoveAt(lastIndex);

//        lastIndex--;
//        int parentIndex = 0;
//        while (true)
//        {
//            int leftChildIndex = parentIndex * 2 + 1;
//            if (leftChildIndex > lastIndex)
//                break;
//            int rightChildIndex = leftChildIndex + 1;
//            if (rightChildIndex <= lastIndex && _elements[rightChildIndex].priority < _elements[leftChildIndex].priority)
//                leftChildIndex = rightChildIndex;
//            if (_elements[parentIndex].priority <= _elements[leftChildIndex].priority)
//                break;
//            Swap(parentIndex, leftChildIndex);
//            parentIndex = leftChildIndex;
//        }

//        return frontItem;
//    }

//    private void Swap(int i, int j)
//    {
//        var tmp = _elements[i];
//        _elements[i] = _elements[j];
//        _elements[j] = tmp;
//    }
//}


//// Основной алгоритм внешней сортировки
//public static List<int> ExternalSort(int[] array, int chunkSize, string tempDirectory)
//{
//    ChunkManager chunkManager = new ChunkManager(tempDirectory);

//    // Разделение на отсортированные фрагменты
//    SplitIntoSortedChunks(array, chunkSize, chunkManager);

//    // Слияние фрагментов
//    int chunkCount = chunkManager.GetChunkCount();
//    List<int> sortedArray = MergeSortedChunks(chunkManager, chunkCount);

//    // Очистка временных файлов
//    chunkManager.CleanUp();

//    return sortedArray;
//}


//class Program
//{
//    static void Main()
//    {
//        // Генерация большого массива
//        int[] array = new int[1_000_000];
//        Random random = new Random();
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = random.Next(0, 1_000_000);
//        }

//        // Внешняя сортировка
//        string tempDirectory = "temp_chunks";
//        List<int> sortedArray = ExternalSort(array, 100_000, tempDirectory);

//        // Проверка первых 10 элементов
//        Console.WriteLine("Первые 10 элементов отсортированного массива:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(sortedArray[i]);
//        }
//    }
//}


//using System;
//using System.Diagnostics;

//class PerformanceTest
//{
//    static void Main()
//    {
//        // Генерация большого массива
//        int[] array = new int[10_000_000];
//        Random random = new Random();
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = random.Next(0, 10_000_000);
//        }

//        // Внешняя сортировка
//        string tempDirectory = "temp_chunks_perf";
//        Stopwatch stopwatch = Stopwatch.StartNew();
//        List<int> sortedArray = ExternalSort(array, 1_000_000, tempDirectory);
//        stopwatch.Stop();

//        Console.WriteLine($"Время выполнения внешней сортировки: {stopwatch.ElapsedMilliseconds} мс");
//    }
//}


////1.20: Поиск медианы в потоке данных
//using System;
//using System.Collections.Generic;

//public class MedianFinder
//{
//    private readonly PriorityQueue<int, int> maxHeap;

//    private readonly PriorityQueue<int, int> minHeap;

//    public MedianFinder()
//    {
//        maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
//        minHeap = new PriorityQueue<int, int>();
//    }

//    public void AddNum(int num)
//    {
//        maxHeap.Enqueue(num, num);

//        int maxFromLower = maxHeap.Dequeue();
//        minHeap.Enqueue(maxFromLower, maxFromLower);

//        if (maxHeap.Count < minHeap.Count)
//        {
//            int minFromUpper = minHeap.Dequeue();
//            maxHeap.Enqueue(minFromUpper, minFromUpper);
//        }
//    }

//    public double FindMedian()
//    {
//        if ((maxHeap.Count + minHeap.Count) % 2 == 1)
//        {
//            return maxHeap.Peek();
//        }

//        return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
//    }
//}

////2.1: Реализация паттерна Observer с обработкой исключений

//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Channels;
//using System.Threading.Tasks;

//public interface IEvent { }

//public interface ISubscriber<T> where T : IEvent
//{
//    ValueTask HandleAsync(T @event, CancellationToken ct);
//}

//public sealed class AdvancedEventBus : IDisposable
//{
//    private readonly ConcurrentDictionary<Type, object> _subscribers = new();
//    private readonly Channel<object> _fallbackQueue = Channel.CreateUnbounded<object>();
//    private readonly SemaphoreSlim _semaphore = new(1, 1);
//    private readonly CancellationTokenSource _cts = new();
//    private readonly Task _fallbackProcessor;

//    public long TotalPublished { get; private set; }
//    public long TotalDelivered { get; private set; }
//    public long TotalFailed { get; private set; }
//    public long TotalRetried { get; private set; }
//    public long QueueLength => _fallbackQueue.Reader.Count;

//    public AdvancedEventBus()
//    {
//        _fallbackProcessor = Task.Run(ProcessFallbackQueueAsync);
//    }

//    public void Subscribe<T>(ISubscriber<T> subscriber, Func<T, bool>? filter = null) where T : IEvent
//    {
//        var list = (ConcurrentDictionary<ISubscriber<T>, Func<T, bool>?>)
//            _subscribers.GetOrAdd(typeof(T), _ => new ConcurrentDictionary<ISubscriber<T>, Func<T, bool>?>());

//        list.TryAdd(subscriber, filter);
//    }

//    public void Unsubscribe<T>(ISubscriber<T> subscriber) where T : IEvent
//    {
//        if (_subscribers.TryGetValue(typeof(T), out var obj) &&
//            obj is ConcurrentDictionary<ISubscriber<T>, Func<T, bool>?> dict)
//        {
//            dict.TryRemove(subscriber, out _);
//        }
//    }

//    public async Task PublishAsync<T>(T @event, CancellationToken ct = default) where T : IEvent
//    {
//        Interlocked.Increment(ref TotalPublished);

//        if (!_subscribers.TryGetValue(typeof(T), out var obj))
//            return;

//        var subscribers = (ConcurrentDictionary<ISubscriber<T>, Func<T, bool>?>)obj;
//        var tasks = new List<Task>();

//        foreach (var (subscriber, filter) in subscribers)
//        {
//            if (filter != null && !filter(@event))
//                continue;

//            var captured = subscriber;
//            var task = Task.Run(async () =>
//            {
//                await _semaphore.WaitAsync(ct);
//                try
//                {
//                    await captured.HandleAsync(@event, ct);
//                    Interlocked.Increment(ref TotalDelivered);
//                }
//                catch (OperationCanceledException) when (ct.IsCancellationRequested) { }
//                catch
//                {
//                    Interlocked.Increment(ref TotalFailed);
//                    await _fallbackQueue.Writer.WriteAsync(new PendingEvent<T>(@event, captured), ct);
//                }
//                finally
//                {
//                    _semaphore.Release();
//                }
//            }, ct);

//            tasks.Add(task);
//        }

//        _ = Task.WhenAll(tasks).ContinueWith(t =>
//        {
//            if (t.IsFaulted)
//                Interlocked.Add(ref TotalFailed, t.Exception?.InnerExceptions.Count ?? 1);
//        }, TaskScheduler.Default);
//    }

//    private async Task ProcessFallbackQueueAsync()
//    {
//        await foreach (var item in _fallbackQueue.Reader.ReadAllAsync(_cts.Token))
//        {
//            if (item is not IPendingEvent pending) continue;

//            Interlocked.Increment(ref TotalRetried);

//            var retryTask = Task.Run(async () =>
//            {
//                await Task.Delay(100);
//                await pending.RetryAsync();
//            });

//            _ = retryTask.ContinueWith(t =>
//            {
//                if (t.IsFaulted)
//                    Interlocked.Increment(ref TotalFailed);
//                else
//                    Interlocked.Increment(ref TotalDelivered);
//            }, TaskScheduler.Default);
//        }
//    }

//    public void Dispose()
//    {
//        _cts.Cancel();
//        _cts.Dispose();
//        _semaphore.Dispose();
//        _fallbackQueue.Writer.Complete();
//    }
//}

//internal interface IPendingEvent
//{
//    Task RetryAsync();
//}

//internal record PendingEvent<T>(T Event, ISubscriber<T> Subscriber) : IPendingEvent where T : IEvent
//{
//    public async Task RetryAsync()
//    {
//        await Subscriber.HandleAsync(Event, CancellationToken.None);
//    }
//}

//public record OrderCreated(int OrderId, decimal Amount) : IEvent;

//public class EmailNotifier : ISubscriber<OrderCreated>
//{
//    public async ValueTask HandleAsync(OrderCreated @event, CancellationToken ct)
//    {
//        if (@event.Amount > 10000)
//            throw new InvalidOperationException("Large order!");

//        await Task.Delay(50, ct);
//        Console.WriteLine($"Email sent for order {@event.OrderId}");
//    }
//}

//public class AnalyticsService : ISubscriber<OrderCreated>
//{
//    public ValueTask HandleAsync(OrderCreated @event, CancellationToken ct)
//    {
//        Console.WriteLine($"Analytics: order {@event.OrderId}, amount {@event.Amount}");
//        return ValueTask.CompletedTask;
//    }
//}

////2.2: Паттерн Decorator для добавления функциональности
//using System;
//using System.Collections.Concurrent;
//using System.Diagnostics;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Threading.Tasks;

//[AttributeUsage(AttributeTargets.Parameter)]
//public sealed class NotNullAttribute : Attribute { }

//[AttributeUsage(AttributeTargets.Method)]
//public sealed class CacheableAttribute : Attribute { }

//public interface ILogger
//{
//    void Log(string message);
//}

//public sealed class ConsoleLogger : ILogger
//{
//    public void Log(string message) => Console.WriteLine(message);
//}

//public sealed class DecoratorProxy<T> : DispatchProxy where T : class
//{
//    private T _target;
//    private ILogger _logger;
//    private readonly ConcurrentDictionary<MethodInfo, ConcurrentDictionary<CacheKey, (object? Value, DateTime Expires)>> _cache = new();
//    private readonly Stopwatch _stopwatch = new();

//    public static T Create(T target, ILogger logger = null)
//    {
//        var proxy = Create<T, DecoratorProxy<T>>();
//        ((DecoratorProxy<T>)proxy).SetParameters(target, logger ?? new ConsoleLogger());
//        return proxy;
//    }

//    private void SetParameters(T target, ILogger logger)
//    {
//        _target = target ?? throw new ArgumentNullException(nameof(target));
//        _logger = logger;
//    }

//    protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
//    {
//        if (targetMethod == null) return null;

//        ValidateParameters(targetMethod, args);

//        var cacheAttr = targetMethod.GetCustomAttribute<CacheableAttribute>();
//        var cacheKey = cacheAttr != null ? new CacheKey(targetMethod, args) : default;
//        var methodCache = cacheAttr != null ? _cache.GetOrAdd(targetMethod, _ => new()) : null;

//        if (cacheAttr != null && methodCache!.TryGetValue(cacheKey, out var cached) && cached.Expires > DateTime.UtcNow)
//        {
//            _logger.Log($"[CACHE HIT] {targetMethod.Name}");
//            return cached.Value;
//        }

//        _logger.Log($"[CALL] {targetMethod.Name}({string.Join(", ", args ?? Array.Empty<object>())})");
//        _stopwatch.Restart();

//        try
//        {
//            var result = targetMethod.Invoke(_target, args);

//            if (result is Task task)
//            {
//                if (task.IsCompleted)
//                    return HandleCompletedTask(task, targetMethod, cacheKey, methodCache);
//                else
//                    return HandleAsyncTask(task, targetMethod, cacheKey, methodCache);
//            }

//            LogResult(targetMethod, result);
//            if (cacheAttr != null) methodCache![cacheKey] = (result, DateTime.UtcNow.AddSeconds(30));
//            return result;
//        }
//        catch (TargetInvocationException ex)
//        {
//            _logger.Log($"[ERROR] {targetMethod.Name}: {ex.InnerException?.Message}");
//            throw ex.InnerException ?? ex;
//        }
//        finally
//        {
//            _stopwatch.Stop();
//            _logger.Log($"[TIME] {targetMethod.Name}: {_stopwatch.ElapsedMilliseconds} ms");
//        }
//    }

//    private void ValidateParameters(MethodInfo method, object?[]? args)
//    {
//        var parameters = method.GetParameters();
//        for (int i = 0; i < parameters.Length; i++)
//        {
//            var notNull = parameters[i].GetCustomAttribute<NotNullAttribute>();
//            if (notNull != null && (args?[i] == null || args[i] is string s && string.IsNullOrWhiteSpace(s)))
//                throw new ArgumentNullException(parameters[i].Name);
//        }
//    }

//    private async Task HandleAsyncTask(Task task, MethodInfo method, CacheKey key, ConcurrentDictionary<CacheKey, (object?, DateTime)>? cache)
//    {
//        await task.ConfigureAwait(false);
//        var resultProperty = task.GetType().GetProperty("Result");
//        var result = resultProperty?.GetValue(task);

//        LogResult(method, result);
//        if (cache != null) cache[key] = (result, DateTime.UtcNow.AddSeconds(30));

//        if (method.ReturnType.IsGenericTask())
//            return result ?? Task.FromResult<object>(null);
//        return Task.CompletedTask;
//    }

//    private object HandleCompletedTask(Task task, MethodInfo method, CacheKey key, ConcurrentDictionary<CacheKey, (object?, DateTime)>? cache)
//    {
//        var resultProperty = task.GetType().GetProperty("Result");
//        var result = resultProperty?.GetValue(task);

//        LogResult(method, result);
//        if (cache != null) cache![key] = (result, DateTime.UtcNow.AddSeconds(30));

//        return result ?? Task.CompletedTask;
//    }

//    private void LogResult(MethodInfo method, object? result)
//    {
//        if (result is not Task)
//            _logger.Log($"[RESULT] {method.Name} => {result ?? "null"}");
//    }
//}

//file class CacheKey : Tuple<MethodInfo, object?[]>
//{
//    public CacheKey(MethodInfo method, object?[] args) : base(method, args) { }
//    public MethodInfo Method => Item1;
//}

//public static class Extensions
//{
//    public static bool IsGenericTask(this Type type) =>
//        type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Task<>);
//}

//public interface ICalculator
//{
//    int Add(int a, int b);
//    Task<double> DivideAsync(int a, int b);
//    string GetName();
//}

//public class Calculator : ICalculator
//{
//    public int Add(int a, int b) => a + b;

//    [Cacheable]
//    public Task<double> DivideAsync(int a, int b)
//    {
//        if (b == 0) throw new DivideByZeroException();
//        return Task.FromResult((double)a / b);
//    }

//    public string GetName() => "Calc";
//}

//class Program
//{
//    static async Task Main()
//    {
//        ICalculator calc = DecoratorProxy<ICalculator>.Create(new Calculator());

//        Console.WriteLine(calc.Add(10, 20));
//        Console.WriteLine(await calc.DivideAsync(10, 3));
//        Console.WriteLine(await calc.DivideAsync(10, 3));
//        Console.WriteLine(calc.GetName());
//    }
//}

//2.3: Паттерн Strategy с динамическим выбором алгоритма
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;

//public interface ISortingStrategy
//{
//    void Sort<T>(IList<T> list) where T : IComparable<T>;
//    string Name { get; }
//}

//public sealed class QuickSortStrategy : ISortingStrategy
//{
//    public string Name => "QuickSort";
//    public void Sort<T>(IList<T> list) where T : IComparable<T> => QuickSort(list, 0, list.Count - 1);
//    private static void QuickSort<T>(IList<T> list, int low, int high) where T : IComparable<T>
//    {
//        if (low < high)
//        {
//            int pi = Partition(list, low, high);
//            QuickSort(list, low, pi - 1);
//            QuickSort(list, pi + 1, high);
//        }
//    }
//    private static int Partition<T>(IList<T> list, int low, int high) where T : IComparable<T>
//    {
//        T pivot = list[high];
//        int i = low - 1;
//        for (int j = low; j < high; j++)
//        {
//            if (list[j].CompareTo(pivot) <= 0)
//                Swap(list, ++i, j);
//        }
//        Swap(list, ++i, high);
//        return i;
//    }
//    private static void Swap<T>(IList<T> list, int i, int j) { (list[i], list[j]) = (list[j], list[i]); }
//}

//public sealed class MergeSortStrategy : ISortingStrategy
//{
//    public string Name => "MergeSort";
//    public void Sort<T>(IList<T> list) where T : IComparable<T>
//    {
//        var aux = new T[list.Count];
//        MergeSort(list, aux, 0, list.Count - 1);
//    }
//    private static void MergeSort<T>(IList<T> list, T[] aux, int low, int high) where T : IComparable<T>
//    {
//        if (low >= high) return;
//        int mid = low + (high - low) / 2;
//        MergeSort(list, aux, low, mid);
//        MergeSort(list, aux, mid + 1, high);
//        Merge(list, aux, low, mid, high);
//    }
//    private static void Merge<T>(IList<T> list, T[] aux, int low, int mid, int high) where T : IComparable<T>
//    {
//        Array.Copy(list.ToArray(), low, aux, low, high - low + 1);
//        int i = low, j = mid + 1, k = low;
//        while (i <= mid && j <= high)
//            list[k++] = aux[i].CompareTo(aux[j]) <= 0 ? aux[i++] : aux[j++];
//        while (i <= mid) list[k++] = aux[i++];
//    }
//}

//public sealed class InsertionSortStrategy : ISortingStrategy
//{
//    public string Name => "InsertionSort";
//    public void Sort<T>(IList<T> list) where T : IComparable<T>
//    {
//        for (int i = 1; i < list.Count; i++)
//        {
//            T key = list[i];
//            int j = i - 1;
//            while (j >= 0 && list[j].CompareTo(key) > 0)
//                list[j + 1] = list[j--];
//            list[j + 1] = key;
//        }
//    }
//}

//public sealed class StrategyPerformance
//{
//    public string StrategyName { get; set; } = "";
//    public int Size { get; set; }
//    public long Ticks { get; set; }
//    public DateTime MeasuredAt { get; set; } = DateTime.UtcNow;
//}

//public sealed class AdaptiveSortingContext
//{
//    private readonly ConcurrentDictionary<string, ISortingStrategy> _strategyCache = new();
//    private readonly ConcurrentBag<StrategyPerformance> _performanceHistory = new();
//    private readonly object _lock = new();

//    public AdaptiveSortingContext()
//    {
//        RegisterStrategy(new QuickSortStrategy());
//        RegisterStrategy(new MergeSortStrategy());
//        RegisterStrategy(new InsertionSortStrategy());
//    }

//    public void RegisterStrategy(ISortingStrategy strategy)
//        => _strategyCache[strategy.Name] = strategy;

//    public void Sort<T>(IList<T> list) where T : IComparable<T>
//    {
//        if (list.Count <= 1) return;

//        var strategy = ChooseBestStrategy(list.Count);
//        var sw = Stopwatch.StartNew();
//        strategy.Sort(list);
//        sw.Stop();

//        _performanceHistory.Add(new StrategyPerformance
//        {
//            StrategyName = strategy.Name,
//            Size = list.Count,
//            Ticks = sw.ElapsedTicks
//        });
//    }

//    private ISortingStrategy ChooseBestStrategy(int size)
//    {
//        if (size <= 16) return _strategyCache["InsertionSort"];

//        var recent = _performanceHistory
//            .Where(p => p.Size >= size * 0.7 && p.Size <= size * 1.3)
//            .GroupBy(p => p.StrategyName)
//            .Select(g => new
//            {
//                Name = g.Key,
//                AvgTicks = g.Average(p => p.Ticks),
//                Count = g.Count()
//            })
//            .Where(x => x.Count >= 3)
//            .OrderBy(x => x.AvgTicks)
//            .FirstOrDefault();

//        if (recent != null && _strategyCache.TryGetValue(recent.Name, out var best))
//            return best;

//        return size <= 1000 ? _strategyCache["InsertionSort"] : _strategyCache["QuickSort"];
//    }

//    public IReadOnlyList<StrategyPerformance> GetPerformanceHistory() => _performanceHistory.ToArray();
//}

//public static class SortingExtensions
//{
//    public static void AdaptiveSort<T>(this IList<T> list) where T : IComparable<T>
//        => Sorting.Context.Sort(list);

//    private static readonly AdaptiveSortingContext Context = new();
//    public static AdaptiveSortingContext Context { get; } = Context;
//}

//class Program
//{
//    static void Main()
//    {
//        var data = Enumerable.Range(1, 100000).OrderBy(x => Guid.NewGuid()).ToList();
//        var small = Enumerable.Range(1, 10).OrderBy(x => Guid.NewGuid()).ToList();

//        small.AdaptiveSort();
//        data.AdaptiveSort();
//        data.AdaptiveSort();
//        data.AdaptiveSort();

//        var stats = SortingExtensions.Context.GetPerformanceHistory()
//            .GroupBy(x => x.StrategyName)
//            .Select(g => $"{g.Key}: {g.Average(x => x.Ticks):F2} ticks (n≈{g.First().Size})");

//        foreach (var s in stats) Console.WriteLine(s);
//    }
//}

////2.4: Паттерн Factory с регистрацией типов
//using System;
//using System.Collections.Concurrent;
//using System.Linq;
//using System.Reflection;

//public interface IService { }

//public class Logger : IService
//{
//    public void Log(string msg) => Console.WriteLine($"[LOG] {msg}");
//}

//public class Database : IService { }

//public interface IRepository
//{
//    void Save(string data);
//}

//public class UserRepository
//{
//    private readonly IService _logger;
//    private readonly IService _db;

//    public UserRepository(Logger logger, Database db)
//    {
//        _logger = logger;
//        _db = db;
//    }

//    public void Save(string data)
//    {
//        _logger.Log($"Saving: {data}");
//    }
//}

//public class AdvancedFactory
//{
//    private readonly ConcurrentDictionary<Type, Func<object[], object>> _constructors = new();
//    private readonly ConcurrentDictionary<Type, object> _singletons = new();
//    private readonly ConcurrentDictionary<Type, Registration> _registrations = new();

//    private sealed class Registration
//    {
//        public Type ImplementationType { get; set; }
//        public object Instance { get; set; }
//        public bool IsSingleton { get; set; }
//        public Func<object[], object> Factory { get; set; }
//    }

//    public AdvancedFactory Register<TContract, TImplementation>(bool singleton = false)
//        where TImplementation : TContract
//    {
//        Register(typeof(TContract), typeof(TImplementation), singleton);
//        return this;
//    }

//    public AdvancedFactory Register(Type contract, Type implementation, bool singleton = false)
//    {
//        _registrations[contract] = new Registration
//        {
//            ImplementationType = implementation,
//            IsSingleton = singleton
//        };
//        return this;
//    }

//    public AdvancedFactory RegisterInstance<T>(T instance)
//    {
//        _registrations[typeof(T)] = new Registration
//        {
//            Instance = instance,
//            IsSingleton = true
//        };
//        return this;
//    }

//    public AdvancedFactory RegisterFactory<T>(Func<object[], T> factory)
//    {
//        _registrations[typeof(T)] = new Registration
//        {
//            Factory = args => factory(args),
//            IsSingleton = false
//        };
//        return this;
//    }

//    public T Resolve<T>(params object[] parameters)
//        => (T)Resolve(typeof(T), parameters);

//    public object Resolve(Type type, params object[] parameters)
//    {
//        if (_registrations.TryGetValue(type, out var reg))
//        {
//            if (reg.Instance != null)
//                return reg.Instance;

//            if (reg.Factory != null)
//            {
//                var instance = reg.Factory(parameters);
//                if (reg.IsSingleton)
//                    reg.Instance = instance;
//                return instance;
//            }
//        }

//        var implType = reg?.ImplementationType ?? type;

//        if (_singletons.TryGetValue(implType, out var singleton))
//            return singleton;

//        var ctor = _constructors.GetOrAdd(implType, CreateConstructor);
//        var instance = ctor(parameters);

//        if (reg?.IsSingleton == true)
//        {
//            _singletons[implType] = instance;
//            if (reg != null) reg.Instance = instance;
//        }

//        return instance;
//    }

//    private static Func<object[], object> CreateConstructor(Type type)
//    {
//        var constructors = type.GetConstructors();
//        var ctor = constructors.OrderByDescending(c => c.GetParameters().Length).First();

//        var paramTypes = ctor.GetParameters();

//        return parameters =>
//        {
//            var resolvedParams = new object[paramTypes.Length];

//            for (int i = 0; i < paramTypes.Length; i++)
//            {
//                var paramType = paramTypes[i].ParameterType;

//                var explicitParam = parameters.Length > i ? parameters[i] : null;
//                if (explicitParam != null && paramType.IsAssignableFrom(explicitParam.GetType()))
//                {
//                    resolvedParams[i] = explicitParam;
//                    continue;
//                }

//                resolvedParams[i] = Activator.CreateInstance(paramType);
//            }

//            return ctor.Invoke(resolvedParams);
//        };
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var factory = new AdvancedFactory();

//        factory
//            .Register<ILogger, Logger>(singleton: true)
//            .Register<IService, Database>()
//            .Register<IRepository, UserRepository>()
//            .RegisterInstance<IService>(new Logger());

//        var repo1 = factory.Resolve<IRepository>();
//        var repo2 = factory.Resolve<IRepository>();

//        repo1.Save("User 123");
//        Console.WriteLine($"Same instance: {ReferenceEquals(repo1, repo2)}");

//        var logger = factory.Resolve<ILogger>();
//        Console.WriteLine($"Logger singleton: {factory.Resolve<ILogger>() == logger}");
//    }
//}

////2.5: Паттерн Builder с fluent interface
//using System;
//using System.Collections.Generic;
//using System.Collections.Immutable;
//using System.Text.RegularExpressions;

//public sealed class ConnectionString
//{
//    public string Server { get; }
//    public int Port { get; }
//    public string Database { get; }
//    public string User { get; }
//    public string Password { get; }
//    public IReadOnlyDictionary<string, string> Options { get; }
//    public TimeSpan Timeout { get; }
//    public bool Encrypt { get; }
//    public bool TrustCertificate { get; }

//    internal ConnectionString(
//        string server,
//        int port,
//        string database,
//        string user,
//        string password,
//        IReadOnlyDictionary<string, string> options,
//        TimeSpan timeout,
//        bool encrypt,
//        bool trustCertificate)
//    {
//        Server = server;
//        Port = port;
//        Database = database;
//        User = user;
//        Password = password;
//        Options = options;
//        Timeout = timeout;
//        Encrypt = encrypt;
//        TrustCertificate = trustCertificate;
//    }

//    public override string ToString()
//    {
//        var parts = new List<string>
//        {
//            $"Server={Server}",
//            $"Port={Port}",
//            $"Database={Database}",
//            $"User Id={User}",
//            $"Password={Password}",
//            $"Connect Timeout={(int)Timeout.TotalSeconds}",
//            $"Encrypt={Encrypt}",
//            $"Trust Server Certificate={TrustCertificate}"
//        };
//        foreach (var kv in Options)
//            parts.Add($"{kv.Key}={kv.Value}");
//        return string.Join(";", parts);
//    }
//}

//public sealed class ConnectionStringBuilder
//{
//    private string _server = "localhost";
//    private int _port = 5432;
//    private string _database = "appdb";
//    private string _user = "postgres";
//    private string _password = "";
//    private readonly ImmutableDictionary<string, string>.Builder _options;
//    private TimeSpan _timeout = TimeSpan.FromSeconds(15);
//    private bool _encrypt = true;
//    private bool _trustCertificate = false;

//    public ConnectionStringBuilder()
//    {
//        _options = ImmutableDictionary.CreateBuilder<string, string>();
//    }

//    private ConnectionStringBuilder(ConnectionString source)
//    {
//        _server = source.Server;
//        _port = source.Port;
//        _database = source.Database;
//        _user = source.User;
//        _password = source.Password;
//        _timeout = source.Timeout;
//        _encrypt = source.Encrypt;
//        _trustCertificate = source.TrustCertificate;
//        _options = source.Options.ToBuilder();
//    }

//    public static ConnectionStringBuilder Create() => new();

//    public ConnectionStringBuilder From(ConnectionString source) => new(source);

//    public ConnectionStringBuilder WithServer(string server)
//    {
//        if (string.IsNullOrWhiteSpace(server)) throw new ArgumentException("Server cannot be empty", nameof(server));
//        if (!Regex.IsMatch(server, @"^[a-zA-Z0-9\.\-]+$")) throw new ArgumentException("Invalid server name", nameof(server));
//        _server = server;
//        return this;
//    }

//    public ConnectionStringBuilder WithPort(int port)
//    {
//        if (port < 1 || port > 65535) throw new ArgumentOutOfRangeException(nameof(port), "Port must be 1-65535");
//        _port = port;
//        return this;
//    }

//    public ConnectionStringBuilder WithDatabase(string database)
//    {
//        if (string.IsNullOrWhiteSpace(database)) throw new ArgumentException("Database cannot be empty", nameof(database));
//        _database = database;
//        return this;
//    }

//    public ConnectionStringBuilder WithUser(string user)
//    {
//        if (string.IsNullOrWhiteSpace(user)) throw new ArgumentException("User cannot be empty", nameof(user));
//        _user = user;
//        return this;
//    }

//    public ConnectionStringBuilder WithPassword(string password)
//    {
//        _password = password ?? throw new ArgumentNullException(nameof(password));
//        return this;
//    }

//    public ConnectionStringBuilder WithTimeout(TimeSpan timeout)
//    {
//        if (timeout < TimeSpan.Zero || timeout > TimeSpan.FromMinutes(5))
//            throw new ArgumentOutOfRangeException(nameof(timeout), "Timeout must be 0-300 seconds");
//        _timeout = timeout;
//        return this;
//    }

//    public ConnectionStringBuilder WithEncryption(bool encrypt = true)
//    {
//        _encrypt = encrypt;
//        return this;
//    }

//    public ConnectionStringBuilder TrustServerCertificate(bool trust = true)
//    {
//        _trustCertificate = trust;
//        return this;
//    }

//    public ConnectionStringBuilder AddOption(string key, string value)
//    {
//        if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException("Key cannot be empty", nameof(key));
//        _options[key] = value ?? "";
//        return this;
//    }

//    public ConnectionStringBuilder RemoveOption(string key)
//    {
//        _options.Remove(key);
//        return this;
//    }

//    public ConnectionString Build()
//    {
//        if (string.IsNullOrEmpty(_password))
//            throw new InvalidOperationException("Password is required");

//        return new ConnectionString(
//            _server,
//            _port,
//            _database,
//            _user,
//            _password,
//            _options.ToImmutable(),
//            _timeout,
//            _encrypt,
//            _trustCertificate);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var baseConfig = ConnectionStringBuilder.Create()
//            .WithServer("prod-db.example.com")
//            .WithPort(5432)
//            .WithEncryption()
//            .WithTimeout(TimeSpan.FromSeconds(30))
//            .AddOption("Application Name", "MyApp-v2")
//            .Build();

//        var dev = ConnectionStringBuilder.Create()
//            .From(baseConfig)
//            .WithServer("localhost")
//            .WithDatabase("app_dev")
//            .WithPassword("dev123")
//            .TrustServerCertificate()
//            .Build();

//        var prod = ConnectionStringBuilder.Create()
//            .From(baseConfig)
//            .WithDatabase("app_prod")
//            .WithPassword(Environment.GetEnvironmentVariable("DB_PASS")!)
//            .Build();

//        Console.WriteLine(dev);
//        Console.WriteLine(prod);
//    }
//}

////2.6: Паттерн Proxy для ленивой загрузки
//using System;
//using System.Collections.Concurrent;
//using System.Threading;

//public interface IEntity
//{
//    int Id { get; }
//    string Name { get; set; }
//    DateTime ModifiedAt { get; set; }
//}

//public sealed class User : IEntity
//{
//    public int Id { get; init; }
//    public string Name { get; set; } = "";
//    public string Email { get; set; } = "";
//    public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
//    public override string ToString() => $"User #{Id}: {Name} <{Email}>";
//}

//public interface IUserRepository
//{
//    User Load(int id);
//    void Save(User user);
//}

//public sealed class DatabaseRepository : IUserRepository
//{
//    private static int _counter = 1000;
//    public User Load(int id)
//    {
//        Thread.Sleep(300);
//        return new User
//        {
//            Id = id,
//            Name = $"User_{id}",
//            Email = $"user{id}@example.com",
//            ModifiedAt = DateTime.UtcNow.AddHours(-1)
//        };
//    }
//    public void Save(User user)
//    {
//        Thread.Sleep(150);
//        user.ModifiedAt = DateTime.UtcNow;
//        Interlocked.Increment(ref _counter);
//    }
//}

//public sealed class LazyUserProxy : IEntity
//{
//    private readonly int _id;
//    private readonly IUserRepository _repository;
//    private readonly Lazy<User> _lazyEntity;
//    private readonly ReaderWriterLockSlim _rwLock = new(LockRecursionPolicy.SupportsRecursion);
//    private bool _isDirty = false;

//    public int Id => _id;

//    public string Name
//    {
//        get => Entity.Name;
//        set
//        {
//            _rwLock.EnterUpgradeableReadLock();
//            try
//            {
//                if (Entity.Name != value)
//                {
//                    _rwLock.EnterWriteLock();
//                    try { Entity.Name = value; MarkDirty(); }
//                    finally { _rwLock.ExitWriteLock(); }
//                }
//            }
//            finally { _rwLock.ExitUpgradeableReadLock(); }
//        }
//    }

//    public DateTime ModifiedAt
//    {
//        get => Entity.ModifiedAt;
//        set
//        {
//            _rwLock.EnterUpgradeableReadLock();
//            try
//            {
//                if (Entity.ModifiedAt != value)
//                {
//                    _rwLock.EnterWriteLock();
//                    try { Entity.ModifiedAt = value; MarkDirty(); }
//                    finally { _rwLock.ExitWriteLock(); }
//                }
//            }
//            finally { _rwLock.ExitUpgradeableReadLock(); }
//        }
//    }

//    private User Entity => _lazyEntity.Value;

//    public LazyUserProxy(int id, IUserRepository repository)
//    {
//        _id = id;
//        _repository = repository;
//        _lazyEntity = new Lazy<User>(LoadEntity, LazyThreadSafetyMode.ExecutionAndPublication);
//    }

//    private User LoadEntity()
//    {
//        return _repository.Load(_id);
//    }

//    private void MarkDirty()
//    {
//        _isDirty = true;
//    }

//    public void Save()
//    {
//        _rwLock.EnterReadLock();
//        try
//        {
//            if (_isDirty && _lazyEntity.IsValueCreated)
//            {
//                _rwLock.EnterWriteLock();
//                try
//                {
//                    _repository.Save(Entity);
//                    _isDirty = false;
//                }
//                finally { _rwLock.ExitWriteLock(); }
//            }
//        }
//        finally { _rwLock.ExitReadLock(); }
//    }

//    public override string ToString()
//    {
//        _rwLock.EnterReadLock();
//        try { return Entity.ToString(); }
//        finally { _rwLock.ExitReadLock(); }
//    }

//    ~LazyUserProxy()
//    {
//        Save();
//        _rwLock.Dispose();
//    }
//}

//public sealed class LazyProxyFactory
//{
//    private static readonly ConcurrentDictionary<int, LazyUserProxy> Cache = new();
//    private static readonly IUserRepository Repository = new DatabaseRepository();

//    public static IEntity GetUser(int id)
//    {
//        return Cache.GetOrAdd(id, userId => new LazyUserProxy(userId, Repository));
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var user1 = (LazyUserProxy)LazyProxyFactory.GetUser(1);
//        var user2 = (LazyUserProxy)LazyProxyFactory.GetUser(2);
//        var user1Again = (LazyUserProxy)LazyProxyFactory.GetUser(1);

//        Console.WriteLine("First access - triggers load");
//        Console.WriteLine(user1);

//        Console.WriteLine("Second access - from cache + lazy");
//        Console.WriteLine(user1);

//        user1.Name = "John Doe";
//        user1.Email = "john@example.com";

//        Thread.Sleep(1000);

//        Console.WriteLine($"Modified: {user1}");

//        user1.Save();

//        Console.WriteLine("Same instance: " + ReferenceEquals(user1, user1Again));
//        Console.WriteLine("Cache size: " + LazyProxyFactory.Cache.Count);
//    }
//}

////2.7: Паттерн Chain of Responsibility
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public sealed class RequestContext
//{
//    public string UserId { get; set; } = "";
//    public string Action { get; set; } = "";
//    public decimal Amount { get; set; }
//    public string Resource { get; set; } = "";
//    public bool IsApproved { get; set; }
//    public bool IsRejected { get; set; }
//    public StringBuilder AuditTrail { get; } = new();
//    public Dictionary<string, object> Metadata { get; } = new();
//}

//public interface IHandler
//{
//    IHandler? Next { get; set; }
//    Task<bool> HandleAsync(RequestContext context);
//}

//public abstract class HandlerBase : IHandler
//{
//    public IHandler? Next { get; set; }

//    protected void Log(RequestContext context, string message)
//    {
//        context.AuditTrail.AppendLine($"[{GetType().Name}] {message}");
//    }

//    public virtual Task<bool> HandleAsync(RequestContext context)
//    {
//        return Next?.HandleAsync(context) ?? Task.FromResult(true);
//    }

//    public IHandler SetNext(IHandler next)
//    {
//        Next = next;
//        return next;
//    }
//}

//public sealed class AuthenticationHandler : HandlerBase
//{
//    public override async Task<bool> HandleAsync(RequestContext context)
//    {
//        if (string.IsNullOrEmpty(context.UserId))
//        {
//            Log(context, "REJECTED: User not authenticated");
//            context.IsRejected = true;
//            return false;
//        }

//        Log(context, $"Authenticated as {context.UserId}");
//        return await base.HandleAsync(context);
//    }
//}

//public sealed class AuthorizationHandler : HandlerBase
//{
//    private readonly HashSet<string> _adminUsers = new() { "admin", "root" };

//    public override async Task<bool> HandleAsync(RequestContext context)
//    {
//        bool isAdmin = _adminUsers.Contains(context.UserId);
//        bool isSensitiveAction = context.Action is "Delete" or "Transfer" && context.Amount > 10000;

//        if (isSensitiveAction && !isAdmin)
//        {
//            Log(context, "REJECTED: Insufficient privileges");
//            context.IsRejected = true;
//            return false;
//        }

//        Log(context, isAdmin ? "Authorized as admin" : "Authorized as regular user");
//        return await base.HandleAsync(context);
//    }
//}

//public sealed class RateLimitHandler : HandlerBase
//{
//    private readonly Dictionary<string, (DateTime Last, int Count)> _requests = new();
//    private readonly TimeSpan _window = TimeSpan.FromSeconds(10);
//    private const int MaxRequests = 5;

//    public override Task<bool> HandleAsync(RequestContext context)
//    {
//        var now = DateTime.UtcNow;
//        var key = context.UserId;

//        if (_requests.TryGetValue(key, out var record))
//        {
//            if (now - record.Last > _window)
//                _requests[key] = (now, 1);
//            else if (record.Count >= MaxRequests)
//            {
//                Log(context, $"REJECTED: Rate limit exceeded ({record.Count})");
//                context.IsRejected = true;
//                return Task.FromResult(false);
//            }
//            else
//                _requests[key] = (record.Last, record.Count + 1);
//        }
//        else
//        {
//            _requests[key] = (now, 1);
//        }

//        Log(context, "Rate limit passed");
//        return base.HandleAsync(context);
//    }
//}

//public sealed class BusinessRuleHandler : HandlerBase
//{
//    public override async Task<bool> HandleAsync(RequestContext context)
//    {
//        if (context.Action == "Transfer" && context.Amount <= 0)
//        {
//            Log(context, "REJECTED: Invalid transfer amount");
//            context.IsRejected = true;
//            return false;
//        }

//        if (context.Action == "Delete" && context.Resource == "system")
//        {
//            Log(context, "REJECTED: Cannot delete system resource");
//            context.IsRejected = true;
//            return false;
//        }

//        Log(context, "Business rules validated");
//        context.IsApproved = true;
//        return await base.HandleAsync(context);
//    }
//}

//public sealed class LoggingHandler : HandlerBase
//{
//    public override Task<bool> HandleAsync(RequestContext context)
//    {
//        Log(context, "Final logging - request processed");
//        return Task.FromResult(true);
//    }
//}

//public sealed class RequestPipeline
//{
//    private IHandler? _first;

//    public RequestPipeline Use(IHandler handler)
//    {
//        if (_first == null)
//            _first = handler;
//        else
//        {
//            var last = _first;
//            while (last.Next != null) last = last.Next;
//            last.SetNext(handler);
//        }
//        return this;
//    }

//    public RequestPipeline InsertBefore<T>(IHandler newHandler) where T : IHandler
//    {
//        if (_first == null) return Use(newHandler);

//        if (_first is T)
//        {
//            newHandler.SetNext(_first);
//            _first = newHandler;
//            return this;
//        }

//        var current = _first;
//        while (current.Next != null)
//        {
//            if (current.Next is T)
//            {
//                newHandler.SetNext(current.Next);
//                current.SetNext(newHandler);
//                return this;
//            }
//            current = current.Next;
//        }
//        return this;
//    }

//    public RequestPipeline Remove<T>() where T : IHandler
//    {
//        if (_first == null) return this;

//        if (_first is T) { _first = _first.Next; return this; }

//        var current = _first;
//        while (current.Next != null)
//        {
//            if (current.Next is T)
//            {
//                current.SetNext(current.Next.Next);
//                break;
//            }
//            current = current.Next;
//        }
//        return this;
//    }

//    public async Task<bool> ExecuteAsync(RequestContext context)
//    {
//        return _first != null && await _first.HandleAsync(context);
//    }
//}

//class Program
//{
//    static async Task Main()
//    {
//        var pipeline = new RequestPipeline()
//            .Use(new AuthenticationHandler())
//            .Use(new RateLimitHandler())
//            .Use(new AuthorizationHandler())
//            .Use(new BusinessRuleHandler())
//            .Use(new LoggingHandler());

//        var requests = new[]
//        {
//            new RequestContext { UserId = "admin", Action = "Transfer", Amount = 50000, Resource = "account" },
//            new RequestContext { UserId = "user1", Action = "Transfer", Amount = 15000, Resource = "account" },
//            new RequestContext { UserId = "", Action = "Read", Amount = 0 },
//            new RequestContext { UserId = "user1", Action = "Delete", Amount = 0, Resource = "system" }
//        };

//        foreach (var req in requests)
//        {
//            Console.WriteLine($"Processing request: {req.UserId} - {req.Action} {req.Amount}");
//            await pipeline.ExecuteAsync(req);

//            Console.WriteLine($"Result: {(req.IsRejected ? "REJECTED" : req.IsApproved ? "APPROVED" : "PROCESSED")}");
//            Console.WriteLine("Audit Trail:");
//            Console.WriteLine(req.AuditTrail);
//            Console.WriteLine("---");
//        }

//        Console.WriteLine("Dynamically removing RateLimitHandler...");
//        pipeline.Remove<RateLimitHandler>();

//        var final = new RequestContext { UserId = "admin", Action = "Transfer", Amount = 100000 };
//        await pipeline.ExecuteAsync(final);
//        Console.WriteLine("Final audit trail without rate limiting:");
//        Console.WriteLine(final.AuditTrail);
//    }
//}


////2.8: Паттерн Command для отмены/повтора операций
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Threading.Tasks;

//public interface ICommand
//{
//    ValueTask ExecuteAsync();
//    ValueTask UndoAsync();
//    string Description { get; }
//    bool CanUndo => true;
//}

//public sealed class BankAccount
//{
//    public decimal Balance { get; private set; }
//    public string Owner { get; }

//    public BankAccount(string owner, decimal initial = 0)
//    {
//        Owner = owner;
//        Balance = initial;
//    }

//    public void Deposit(decimal amount)
//    {
//        if (amount <= 0) throw new ArgumentException("Amount must be positive");
//        Balance += amount;
//    }

//    public void Withdraw(decimal amount)
//    {
//        if (amount <= 0) throw new ArgumentException("Amount must be positive");
//        if (amount > Balance) throw new InvalidOperationException("Insufficient funds");
//        Balance -= amount;
//    }

//    public override string ToString() => $"{Owner}: {Balance:C}";
//}

//public sealed class DepositCommand : ICommand
//{
//    private readonly BankAccount _account;
//    private readonly decimal _amount;
//    public string Description => $"Deposit {_amount:C} to {_account.Owner}";

//    public DepositCommand(BankAccountAccount account, decimal amount)
//    {
//        _account = account;
//        _amount = amount;
//    }

//    public ValueTask ExecuteAsync()
//    {
//        _account.Deposit(_amount);
//        return ValueTask.CompletedTask;
//    }

//    public ValueTask UndoAsync()
//    {
//        _account.Withdraw(_amount);
//        return ValueTask.CompletedTask;
//    }
//}

//public sealed class WithdrawCommand : ICommand
//{
//    private readonly BankAccount _account;
//    private readonly decimal _amount;
//    public string Description => $"Withdraw {_amount:C} from {_account.Owner}";

//    public WithdrawCommand(BankAccount account, decimal amount)
//    {
//        _account = account;
//        _amount = amount;
//    }

//    public ValueTask ExecuteAsync()
//    {
//        _account.Withdraw(_amount);
//        return ValueTask.CompletedTask;
//    }

//    public ValueTask UndoAsync()
//    {
//        _account.Deposit(_amount);
//        return ValueTask.CompletedTask;
//    }
//}

//public sealed class TransferCommand : ICommand
//{
//    private readonly BankAccount _from;
//    private readonly BankAccount _to;
//    private readonly decimal _amount;
//    public string Description => $"Transfer {_amount:C} from {_from.Owner} to {_to.Owner}";

//    public TransferCommand(BankAccount from, BankAccount to, decimal amount)
//    {
//        _from = from;
//        _to = to;
//        _amount = amount;
//    }

//    public ValueTask ExecuteAsync()
//    {
//        _from.Withdraw(_amount);
//        _to.Deposit(_amount);
//        return ValueTask.CompletedTask;
//    }

//    public ValueTask UndoAsync()
//    {
//        _to.Withdraw(_amount);
//        _from.Deposit(_amount);
//        return ValueTask.CompletedTask;
//    }
//}

//public sealed class MacroCommand : ICommand
//{
//    private readonly List<ICommand> _commands;
//    public string Description => $"Macro: {string.Join(" → ", _commands.ConvertAll(c => c.Description))}";
//    public IReadOnlyList<ICommand> Commands => _commands;

//    public MacroCommand(params ICommand[] commands)
//    {
//        _commands = new List<ICommand>(commands);
//    }

//    public MacroCommand(IEnumerable<ICommand> commands)
//    {
//        _commands = new List<ICommand>(commands);
//    }

//    public ValueTask ExecuteAsync()
//    {
//        foreach (var cmd in _commands)
//            cmd.ExecuteAsync().AsTask().GetAwaiter().GetResult();
//        return ValueTask.CompletedTask;
//    }

//    public ValueTask UndoAsync()
//    {
//        for (int i = _commands.Count - 1; i >= 0; i--)
//            _commands[i].UndoAsync().AsTask().GetAwaiter().GetResult();
//        return ValueTask.CompletedTask;
//    }
//}

//public sealed class CommandHistory
//{
//    private readonly Stack<ICommand> _undoStack = new();
//    private readonly Stack<ICommand> _redoStack = new();
//    private readonly string _historyFile;

//    public int UndoCount => _undoStack.Count;
//    public int RedoCount => _redoStack.Count;
//    public bool CanUndo => UndoCount > 0;
//    public bool CanRedo => RedoCount > 0;

//    public CommandHistory(string filePath = "command_history.bin")
//    {
//        _historyFile = filePath;
//        Load();
//    }

//    public async Task ExecuteAsync(ICommand command)
//    {
//        await command.ExecuteAsync();
//        _undoStack.Push(command);
//        _redoStack.Clear();
//        await SaveAsync();
//    }

//    public async Task UndoAsync()
//    {
//        if (!CanUndo) throw new InvalidOperationException("Nothing to undo");

//        var command = _undoStack.Pop();
//        await command.UndoAsync();
//        _redoStack.Push(command);
//        await SaveAsync();
//    }

//    public async Task RedoAsync()
//    {
//        if (!CanRedo) throw new InvalidOperationException("Nothing to redo");

//        var command = _redoStack.Pop();
//        await command.ExecuteAsync();
//        _undoStack.Push(command);
//        await SaveAsync();
//    }

//    public void Clear()
//    {
//        _undoStack.Clear();
//        _redoStack.Clear();
//        if (File.Exists(_historyFile))
//            File.Delete(_historyFile);
//    }

//    private async Task SaveAsync()
//    {
//        var data = new HistoryData
//        {
//            UndoCommands = new List<ICommand>(_undoStack),
//            RedoCommands = new List<ICommand>(_redoStack)
//        };

//        using var stream = new MemoryStream();
//        new BinaryFormatter().Serialize(stream, data);
//        await File.WriteAllBytesAsync(_historyFile, stream.ToArray());
//    }

//    private void Load()
//    {
//        if (!File.Exists(_historyFile)) return;

//        try
//        {
//            var bytes = File.ReadAllBytes(_historyFile);
//            using var stream = new MemoryStream(bytes);
//            var data = (HistoryData)new BinaryFormatter().Deserialize(stream);

//            foreach (var cmd in data.UndoCommands)
//                _undoStack.Push(cmd);
//            foreach (var cmd in data.RedoCommands)
//                _redoStack.Push(cmd);
//        }
//        catch { File.Delete(_historyFile); }
//    }

//    [Serializable]
//    private class HistoryData
//    {
//        public List<ICommand> UndoCommands { get; set; } = new();
//        public List<ICommand> RedoCommands { get; set; } = new();
//    }
//}

//class Program
//{
//    static async Task Main()
//    {
//        var alice = new BankAccount("Alice", 1000);
//        var bob = new BankAccount("Bob", 500);

//        var history = new CommandHistory();

//        Console.WriteLine($"Initial: {alice} | {bob}");

//        await history.ExecuteAsync(new DepositCommand(alice, 500));
//        await history.ExecuteAsync(new WithdrawCommand(alice, 200));
//        await history.ExecuteAsync(new TransferCommand(alice, bob, 300));

//        Console.WriteLine($"After operations: {alice} | {bob}");

//        await history.UndoAsync();
//        Console.WriteLine($"After undo transfer: {alice} | {bob}");

//        await history.UndoAsync();
//        Console.WriteLine($"After undo withdraw: {alice} | {bob}");

//        await history.RedoAsync();
//        Console.WriteLine($"After redo withdraw: {alice} | {bob}");

//        var macro = new MacroCommand(
//            new DepositCommand(alice, 1000),
//            new TransferCommand(alice, bob, 700),
//            new WithdrawCommand(bob, 100)
//        );

//        await history.ExecuteAsync(macro);
//        Console.WriteLine($"After macro: {alice} | {bob}");

//        await history.UndoAsync();
//        Console.WriteLine($"After macro undo: {alice} | {bob}");

//        Console.WriteLine($"History saved to file. Undo/Redo count: {history.UndoCount}/{history.RedoCount}");
//    }
//}

////2.9: Паттерн Adapter для интеграции несовместимых систем
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.IO;
//using System.Linq;
//using System.Net.Http;
//using System.Text.Json;
//using System.Threading.Tasks;

//public record Product(int Id, string Name, decimal Price, string Category);

//public interface IProductRepository
//{
//    Task<IReadOnlyList<Product>> GetAllAsync();
//    Task<Product?> GetByIdAsync(int id);
//}

//public sealed class CsvProductRepository : IProductRepository
//{
//    private readonly string _filePath;
//    private readonly ConcurrentDictionary<int, Product> _cache = new();
//    private readonly SemaphoreSlim _sync = new(1, 1);

//    public CsvProductRepository(string filePath) => _filePath = filePath;

//    public async Task<IReadOnlyList<Product>> GetAllAsync()
//    {
//        await LoadAsync();
//        return _cache.Values.ToList();
//    }

//    public async Task<Product?> GetByIdAsync(int id)
//    {
//        await LoadAsync();
//        _cache.TryGetValue(id, out var product);
//        return product;
//    }

//    private async Task LoadAsync()
//    {
//        if (_cache.IsEmpty)
//        {
//            await _sync.WaitAsync();
//            try
//            {
//                if (_cache.IsEmpty)
//                {
//                    var lines = await File.ReadAllLinesAsync(_filePath);
//                    foreach (var line in lines.Skip(1))
//                    {
//                        var parts = line.Split(',');
//                        var product = new Product(
//                            int.Parse(parts[0]),
//                            parts[1].Trim('"'),
//                            decimal.Parse(parts[2]),
//                            parts[3].Trim('"')
//                        );
//                        _cache[product.Id] = product;
//                    }
//                }
//            }
//            finally { _sync.Release(); }
//        }
//    }
//}

//public sealed class JsonApiProductRepository : IProductRepository
//{
//    private readonly HttpClient _http;
//    private readonly string _url;
//    private readonly ConcurrentDictionary<int, Product> _cache = new();
//    private readonly SemaphoreSlim _sync = new(1, 1);

//    public JsonApiProductRepository(HttpClient http, string url)
//    {
//        _http = http;
//        _url = url;
//    }

//    public async Task<IReadOnlyList<Product>> GetAllAsync()
//    {
//        await LoadAsync();
//        return _cache.Values.ToList();
//    }

//    public async Task<Product?> GetByIdAsync(int id)
//    {
//        await LoadAsync();
//        _cache.TryGetValue(id, out var product);
//        return product;
//    }

//    private async Task LoadAsync()
//    {
//        if (_cache.IsEmpty)
//        {
//            await _sync.WaitAsync();
//            try
//            {
//                if (_cache.IsEmpty)
//                {
//                    var json = await _http.GetStringAsync(_url);
//                    var products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
//                    {
//                        PropertyNameCaseInsensitive = true
//                    })!;

//                    foreach (var p in products)
//                        _cache[p.Id] = p;
//                }
//            }
//            finally { _sync.Release(); }
//        }
//    }
//}

//public sealed class SqlProductRepository : IProductRepository
//{
//    private readonly string _connectionString;
//    private readonly ConcurrentDictionary<int, Product> _cache = new();
//    private readonly SemaphoreSlim _sync = new(1, 1);

//    public SqlProductRepository(string connectionString) => _connectionString = connectionString;

//    public async Task<IReadOnlyList<Product>> GetAllAsync()
//    {
//        await LoadAsync();
//        return _cache.Values.ToList();
//    }

//    public async Task<Product?> GetByIdAsync(int id)
//    {
//        await LoadAsync();
//        _cache.TryGetValue(id, out var product);
//        return product;
//    }

//    private async Task LoadAsync()
//    {
//        if (_cache.IsEmpty)
//        {
//            await _sync.WaitAsync();
//            try
//            {
//                if (_cache.IsEmpty)
//                {
//                    using var conn = new SqlConnection(_connectionString);
//                    await conn.OpenAsync();
//                    using var cmd = conn.CreateCommand();
//                    cmd.CommandText = "SELECT Id, Name, Price, Category FROM Products";

//                    using var reader = await cmd.ExecuteReaderAsync();
//                    while (await reader.ReadAsync())
//                    {
//                        var product = new Product(
//                            reader.GetInt32(0),
//                            reader.GetString(1),
//                            reader.GetDecimal(2),
//                            reader.GetString(3)
//                        );
//                        _cache[product.Id] = product;
//                    }
//                }
//            }
//            finally { _sync.Release(); }
//        }
//    }
//}

//public sealed class ProductService
//{
//    private readonly IProductRepository _repository;

//    public ProductService(IProductRepository repository) => _repository = repository;

//    public async Task PrintAllAsync()
//    {
//        var products = await _repository.GetAllAsync();
//        foreach (var p in products)
//            Console.WriteLine($"{p.Id}: {p.Name} - {p.Price:C} [{p.Category}]");
//    }

//    public async Task<Product?> FindAsync(int id)
//    {
//        return await _repository.GetByIdAsync(id);
//    }
//}

//class Program
//{
//    static async Task Main()
//    {
//        var httpClient = new HttpClient();

//        IProductRepository[] sources =
//        {
//            new CsvProductRepository("products.csv"),
//            new JsonApiProductRepository(httpClient, "https://api.example.com/products"),
//            new SqlProductRepository("Server=.;Database=Shop;Integrated Security=true")
//        };

//        foreach (var repo in sources)
//        {
//            Console.WriteLine($"\n=== Loading from {repo.GetType().Name} ===");
//            var service = new ProductService(repo);
//            await service.PrintAllAsync();

//            var product = await service.FindAsync(5);
//            Console.WriteLine(product != null ? $"Found #5: {product.Name}" : "Product #5 not found");
//        }
//    }
//}

////2.10: Паттерн Facade для упрощения сложной системы
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//// === СЛОЖНАЯ ПОДСИСТЕМА (внутренняя, не должна быть видна клиенту) ===

//internal interface IInventoryService
//{
//    bool CheckStock(int productId, int quantity);
//    void ReserveStock(int productId, int quantity);
//    void ReleaseStock(int productId, int quantity);
//}

//internal interface IPaymentGateway
//{
//    Task<PaymentResult> ProcessPayment(decimal amount, string cardToken);
//}

//internal interface IShippingCalculator
//{
//    Task<ShippingOption> CalculateShipping(Address address, List<CartItem> items);
//}

//internal interface IOrderRepository
//{
//    Task<int> CreateOrder(OrderData order);
//    Task ConfirmOrder(int orderId);
//    Task CancelOrder(int orderId, string reason);
//}

//internal interface INotificationService
//{
//    Task SendOrderConfirmationAsync(int orderId, string email);
//    Task SendOrderFailedAsync(string email, string reason);
//}

//internal record PaymentResult(bool Success, string TransactionId, string Error = "");
//internal record ShippingOption(string Carrier, decimal Cost, TimeSpan DeliveryTime);
//internal record Address(string Country, string City, string ZipCode, string Street);
//internal record CartItem(int ProductId, string Name, decimal Price, int Quantity);
//internal record OrderData(string CustomerEmail, List<CartItem> Items, Address ShippingAddress);

//// === ФАСАД — единственная точка входа для клиента ===

//public sealed class CheckoutFacade
//{
//    private readonly IInventoryService _inventory;
//    private readonly IPaymentGateway _payment;
//    private readonly IShippingCalculator _shipping;
//    private readonly IOrderRepository _orders;
//    private readonly INotificationService _notifications;
//    private readonly ILogger _logger;

//    public CheckoutFacade(
//        IInventoryService inventory,
//        IPaymentGateway payment,
//        IShippingCalculator shipping,
//        IOrderRepository orders,
//        INotificationService notifications,
//        ILogger logger)
//    {
//        _inventory = inventory;
//        _payment = payment;
//        _shipping = shipping;
//        _orders = orders;
//        _notifications = notifications;
//        _logger = logger;
//    }

//    public async Task<CheckoutResult> PlaceOrderAsync(
//        string customerEmail,
//        List<CartItem> items,
//        Address shippingAddress,
//        string cardToken)
//    {
//        var orderId = 0;
//        var operation = $"Checkout for {customerEmail} ({items.Count} items)";

//        try
//        {
//            _logger.LogInfo($"{operation} started");

//            // 1. Проверка наличия товара
//            foreach (var item in items)
//            {
//                if (!_inventory.CheckStock(item.ProductId, item.Quantity))
//                {
//                    _logger.LogError($"Out of stock: Product {item.ProductId}");
//                    return CheckoutResult.Failed("One or more items are out of stock");
//                }
//            }

//            // 2. Резервирование товара
//            foreach (var item in items)
//                _inventory.ReserveStock(item.ProductId, item.Quantity);

//            // 3. Расчёт доставки
//            var shipping = await _shipping.CalculateShipping(shippingAddress, items);
//            var totalAmount = items.Sum(i => i.Price * i.Quantity) + shipping.Cost;

//            // 4. Создание заказа в статусе "Pending"
//            orderId = await _orders.CreateOrder(new OrderData(customerEmail, items, shippingAddress));

//            // 5. Оплата
//            var paymentResult = await _payment.ProcessPayment(totalAmount, cardToken);
//            if (!paymentResult.Success)
//            {
//                await RollbackAsync(orderId, items);
//                await _notifications.SendOrderFailedAsync(customerEmail, paymentResult.Error);
//                _logger.LogError($"Payment failed: {paymentResult.Error}");
//                return CheckoutResult.Failed("Payment declined");
//            }

//            // 6. Подтверждение заказа
//            await _orders.ConfirmOrder(orderId);
//            await _notifications.SendOrderConfirmationAsync(orderId, customerEmail);

//            _logger.LogInfo($"Order {orderId} successfully placed. Transaction: {paymentResult.TransactionId}");
//            return CheckoutResult.Success(orderId, paymentResult.TransactionId);
//        }
//        catch (Exception ex)
//        {
//            _logger.LogError($"Unexpected error in {operation}: {ex.Message}");
//            if (orderId > 0) await RollbackAsync(orderId, items);
//            await _notifications.SendOrderFailedAsync(customerEmail, "Internal error");
//            return CheckoutResult.Failed("Something went wrong");
//        }
//    }

//    private async Task RollbackAsync(int orderId, List<CartItem> items)
//    {
//        try
//        {
//            foreach (var item in items)
//                _inventory.ReleaseStock(item.ProductId, item.Quantity);

//            if (orderId > 0)
//                await _orders.CancelOrder(orderId, "Payment failed or error");
//        }
//        catch (Exception rollbackEx)
//        {
//            _logger.LogError($"Rollback failed: {rollbackEx.Message}");
//        }
//    }
//}

//public sealed record CheckoutResult(bool IsSuccess, string Message, int OrderId = 0, string TransactionId = "")
//{
//    public static CheckoutResult Success(int orderId, string transactionId)
//        => new(true, "Order placed successfully", orderId, transactionId);

//    public static CheckoutResult Failed(string reason)
//        => new(false, reason);
//}

//// === Простейшие заглушки для демонстрации ===

//public interface ILogger
//{
//    void LogInfo(string message);
//    void LogError(string message);
//}

//public class ConsoleLogger : ILogger
//{
//    public void LogInfo(string message) => Console.WriteLine($"[INFO] {message}");
//    public void LogError(string message) => Console.WriteLine($"[ERROR] {message}");
//}

//// === Клиентский код — максимально простой ===

//class Program
//{
//    static async Task Main()
//    {
//        var facade = new CheckoutFacade(
//            inventory: new MockInventoryService(),
//            payment: new MockPaymentGateway(),
//            shipping: new MockShippingCalculator(),
//            orders: new MockOrderRepository(),
//            notifications: new MockNotificationService(),
//            logger: new ConsoleLogger()
//        );

//        var items = new List<CartItem>
//        {
//            new(1, "Laptop Pro", 1299.99m, 1),
//            new(2, "Mouse", 49.99m, 2)
//        };

//        var address = new Address("USA", "NY", "10001", "5th Ave");

//        var result = await facade.PlaceOrderAsync(
//            customerEmail: "john@example.com",
//            items: items,
//            shippingAddress: address,
//            cardToken: "tok_visa_1234");

//        Console.WriteLine("\n=== RESULT ===");
//        Console.WriteLine(result.IsSuccess
//            ? $"Order #{result.OrderId} placed! Transaction: {result.TransactionId}"
//            : $"Failed: {result.Message}");
//    }
//}

//internal class MockInventoryService : IInventoryService { public bool CheckStock(int p, int q) => true; public void ReserveStock(int p, int q) { } public void ReleaseStock(int p, int q) { } }
//internal class MockPaymentGateway : IPaymentGateway { public Task<PaymentResult> ProcessPayment(decimal a, string t) => Task.FromResult(new PaymentResult(true, Guid.NewGuid().ToString())); }
//internal class MockShippingCalculator : IShippingCalculator { public Task<ShippingOption> CalculateShipping(Address a, List<CartItem> i) => Task.FromResult(new ShippingOption("DHL", 29.99m, TimeSpan.FromDays(3))); }
//internal class MockOrderRepository : IOrderRepository { public Task<int> CreateOrder(OrderData o) => Task.FromResult(1001); public Task ConfirmOrder(int id) => Task.CompletedTask; public Task CancelOrder(int id, string r) => Task.CompletedTask; }
//internal class MockNotificationService : INotificationService { public Task SendOrderConfirmationAsync(int id, string e) { Console.WriteLine($"Email sent to {e}: Order {id} confirmed"); return Task.CompletedTask; } public Task SendOrderFailedAsync(string e, string r) { Console.WriteLine($"Email sent to {e}: Order failed ({r})"); return Task.CompletedTask; } }

////2.11: Паттерн Singleton с потокобезопасностью
//using System;
//using System.IO;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;

//[Serializable]
//public sealed class ThreadSafeLazySingleton : ISerializable
//{
//    private static readonly Lazy<ThreadSafeLazySingleton> _instance
//        = new Lazy<ThreadSafeLazySingleton>(() => new ThreadSafeLazySingleton(),
//            System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);

//    public static ThreadSafeLazySingleton Instance => _instance.Value;

//    public DateTime CreatedAt { get; } = DateTime.UtcNow;
//    public Guid Id { get; } = Guid.NewGuid();

//    private ThreadSafeLazySingleton()
//    {
//        if (_instance.IsValueCreated && _instance.Value != this)
//            throw new InvalidOperationException("Singleton instance already created via reflection or deserialization.");
//    }

//    private ThreadSafeLazySingleton(SerializationInfo info, StreamingContext context)
//    {
//        CreatedAt = info.GetDateTime(nameof(CreatedAt));
//        Id = (Guid)info.GetValue(nameof(Id), typeof(Guid));
//    }

//    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
//    {
//        info.AddValue(nameof(CreatedAt), CreatedAt);
//        info.AddValue(nameof(Id), Id);
//    }

//    public override string ToString() => $"Singleton #{Id:B} created at {CreatedAt:O}";
//}

//// Запрет клонирования
//public sealed +без ICloneable


//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Первый вызов:");
//        Console.WriteLine(ThreadSafeLazySingleton.Instance); ");
//        Console.WriteLine(ThreadSafeLazySingleton.Instance);

//        Console.WriteLine("\nМногопоточный тест (10 потоков):");
//        Parallel.For(0, 10, _ =>
//        {
//            var inst = ThreadSafeLazySingleton.Instance;
//            Console.WriteLine($"{Environment.CurrentManagedThreadId}: {inst.Id}");
//        });

//        Console.WriteLine("\nСериализация/десериализация:");
//        var original = ThreadSafeLazySingleton.Instance;

//        ThreadSafeLazySingleton deserialized;
//        using (var ms = new MemoryStream())
//        {
//            var formatter = new BinaryFormatter();
//            formatter.Serialize(ms, original);
//            ms.Position = 0;
//            deserialized = (ThreadSafeLazySingleton)formatter.Deserialize(ms);
//        }

//        Console.WriteLine($"Оригинал:     {original}");
//        Console.WriteLine($"После десериализации: {deserialized}");
//        Console.WriteLine($"Это один и тот же объект: {ReferenceEquals(original, deserialized)}");

//        Console.WriteLine($"\nЕдинственность сохранена: {ReferenceEquals(ThreadSafeLazySingleton.Instance, deserialized)}");
//    }
//}

////2.12: Паттерн Template Method с вариативностью
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Threading.Tasks;

//public abstract class DataProcessor
//{
//    public async Task<bool> ProcessAsync(string source)
//    {
//        try
//        {
//            OnBeginProcessing(source);

//            var rawData = await LoadDataAsync(source);
//            if (rawData == null || rawData.Count == 0)
//            {
//                OnEmptyData(source);
//                return false;
//            }

//            var validated = ValidateData(rawData);
//            if (!validated)
//            {
//                OnValidationFailed(rawData);
//                return false;
//            }

//            var transformed = TransformData(rawData);

//            BeforeSave(transformed);

//            await SaveDataAsync(transformed);

//            OnSuccess(transformed);
//            return true;
//        }
//        catch (Exception ex)
//        {
//            OnError(ex);
//            return false;
//        }
//    }

//    protected abstract Task<List<string>> LoadDataAsync(string source);
//    protected abstract bool ValidateData(List<string> data);
//    protected abstract List<Dictionary<string, object>> TransformData(List<string> data);
//    protected abstract Task SaveDataAsync(List<Dictionary<string, object>> data);

//    protected virtual void OnBeginProcessing(string source)
//        => Console.WriteLine($"[START] Processing {source}");

//    protected virtual void OnEmptyData(string source)
//        => Console.WriteLine($"[WARN] No data found in {source}");

//    protected virtual void OnValidationFailed(List<string> data)
//        => Console.WriteLine($"[ERROR] Data validation failed ({data.Count} rows)");

//    protected virtual void BeforeSave(List<Dictionary<string, object>> data)
//    {

//    }

//    protected virtual void OnSuccess(List<Dictionary<string, object>> data)
//        => Console.WriteLine($"[SUCCESS] Processed {data.Count} records");

//    protected virtual void OnError(Exception ex)
//        => Console.WriteLine($"[FATAL] {ex.GetType().Name}: {ex.Message}");
//}


//public sealed class CsvDataProcessor : DataProcessor
//{
//    private readonly string _delimiter;

//    public CsvDataProcessor(string delimiter = ",") => _delimiter = delimiter;

//    protected override async Task<List<string>> LoadDataAsync(string source)
//    {
//        Console.WriteLine($"  → Reading CSV: {source}");
//        await Task.Delay(200);
//        return File.ReadAllLines(source).Skip(1).ToList();
//    }

//    protected override bool ValidateData(List<string> data)
//    {
//        foreach (var line in data)
//        {
//            if (string.IsNullOrWhiteSpace(line) || line.Split(_delimiter).Length < 3)
//                return false;
//        }
//        return true;
//    }

//    protected override List<Dictionary<string, object>> TransformData(List<string> data)
//    {
//        var result = new List<Dictionary<string, object>>();
//        var headers = File.ReadAllLines("sample.csv").First().Split(_delimiter);

//        foreach (var line in data)
//        {
//            var values = line.Split(_delimiter);
//            var row = new Dictionary<string, object>();
//            for (int i = 0; i < headers.Length; i++)
//                row[headers[i]] = values[i];
//            result.Add(row);
//        }
//        return result;
//    }

//    protected override async Task SaveDataAsync(List<Dictionary<string, object>> data)
//    {
//        await Task.Delay(300);
//        Console.WriteLine($"  → Saved {data.Count} rows to database");
//    }

//    protected override void BeforeSave(List<Dictionary<string, object>> data)
//    {
//        Console.WriteLine($"  → Applying business rules to {data.Count} records...");
//    }
//}

//public sealed class JsonDataProcessor : DataProcessor
//{
//    protected override async Task<List<string>> LoadDataAsync(string source)
//    {
//        Console.WriteLine($"  → Loading JSON: {source}");
//        await Task.Delay(150);
//        var json = await File.ReadAllTextAsync(source);
//        return json.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();
//    }

//    protected override bool ValidateData(List<string> data)
//    {
//        return data.All(line => line.Trim().StartsWith("{") && line.Trim().EndsWith("}"));
//    }

//    protected override List<Dictionary<string, object>> TransformData(List<string> data)
//    {
//        return data.Select(line => new Dictionary<string, object>
//        {
//            ["Raw"] = line,
//            ["Length"] = line.Length,
//            ["ProcessedAt"] = DateTime.UtcNow
//        }).ToList();
//    }

//    protected override async Task SaveDataAsync(List<Dictionary<string, object>> data)
//    {
//        await Task.Delay(100);
//        Console.WriteLine($"  → Stored JSON objects in NoSQL");
//    }

//    protected override void OnSuccess(List<Dictionary<string, object>> data)
//    {
//        base.OnSuccess(data);
//        Console.WriteLine($"  → JSON pipeline completed");
//    }
//}

//public sealed class XmlDataProcessor : DataProcessor
//{
//    protected override Task<List<string>> LoadDataAsync(string source)
//        => Task.FromResult(new List<string> { $"<root><item from=\"{source}\"/></root>" });

//    protected override bool ValidateData(List<string> data) => true;

//    protected override List<Dictionary<string, object>> TransformData(List<string> data)
//        => new() { new Dictionary<string, object> { ["xml"] = data[0] } };

//    protected override Task SaveDataAsync(List<Dictionary<string, object>> data)
//        => Task.CompletedTask;

//    protected override void OnBeginProcessing(string source)
//        => Console.WriteLine($"[XML] Starting processing of {source}");
//}


////2.13: Паттерн State для конечных автоматов
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//public sealed class Order
//{
//    public int Id { get; }
//    public DateTime CreatedAt { get; }
//    public decimal TotalAmount { get; init; }

//    private IOrderState _currentState;
//    public IOrderState CurrentState
//    {
//        get => _currentState;
//        private set
//        {
//            var previous = _currentState;
//            _currentState = value;
//            _history.Add(new StateTransition(DateTime.UtcNow, previous?.Name ?? "None", value.Name, _lastEvent));
//            OnStateChanged(previous, value);
//        }
//    }

//    private string _lastEvent = "";
//    private readonly List<StateTransition> _history = new();

//    public IReadOnlyList<StateTransition> History => _history.AsReadOnly();
//    public string CurrentStateName => CurrentState.Name;

//    public Order(int id, decimal amount)
//    {
//        Id = id;
//        CreatedAt = DateTime.UtcNow;
//        TotalAmount = amount;
//        CurrentState = DraftState.Instance;
//    }

//    public bool CanTransitionTo(string eventName) => CurrentState.CanHandle(eventName);

//    public bool Trigger(string eventName)
//    {
//        if (!CurrentState.CanHandle(eventName))
//        {
//            Console.WriteLine($"[INVALID] Order {Id}: Cannot '{eventName}' from state '{CurrentState.Name}'");
//            return false;
//        }

//        _lastEvent = eventName;
//        CurrentState.Handle(this, eventName);
//        return true;
//    }

//    internal void TransitionTo(IOrderState newState)
//    {
//        CurrentState = newState;
//    }

//    private void OnStateChanged(IOrderState from, IOrderState to)
//    {
//        Console.WriteLine($"[TRANSITION] Order {Id}: {from?.Name ?? "None"} → {to.Name}");
//    }

//    public void PrintHistory()
//    {
//        Console.WriteLine($"\n=== History for Order {Id} ===");
//        foreach (var t in History)
//            Console.WriteLine($"{t.Timestamp:HH:mm:ss} | {t.From,-12} → {t.To,-12} | {t.Event}");
//    }

//    public string GenerateDiagram()
//    {
//        var sb = new StringBuilder();
//        sb.AppendLine("digraph OrderStateMachine {");
//        sb.AppendLine("    rankdir=LR; node [shape=box, style=rounded];");
//        sb.AppendLine("    Draft -> PendingPayment [label=\"Submit\"];");
//        sb.AppendLine("    PendingPayment -> Processing [label=\"Pay\"];");
//        sb.AppendLine("    PendingPayment -> Cancelled [label=\"Cancel\"];");
//        sb.AppendLine("    Processing -> Shipped [label=\"Ship\"];");
//        sb.AppendLine("    Processing -> Cancelled [label=\"Cancel\"];");
//        sb.AppendLine("    Shipped -> Delivered [label=\"Deliver\"];");
//        sb.AppendLine("    Shipped -> Returned [label=\"Return\"];");
//        sb.AppendLine("    Delivered -> Completed [label=\"Confirm\"];");
//        sb.AppendLine("    Returned -> Refunded [label=\"Refund\"];");
//        sb.AppendLine("    {Cancelled, Refunded, Completed} [shape=doublecircle];");
//        sb.AppendLine("}");
//        return sb.ToString();
//    }
//}

//public record StateTransition(DateTime Timestamp, string From, string To, string Event);

//public interface IOrderState
//{
//    string Name { get; }
//    bool CanHandle(string @event);
//    void Handle(Order order, string @event);
//}

//public sealed class DraftState : IOrderState
//{
//    public static readonly DraftState Instance = new();
//    public string Name => "Draft";
//    private DraftState() { }

//    public bool CanHandle(string @event) => @event is "Submit";
//    public void Handle(Order order, string @event)
//    {
//        if (@event == "Submit")
//            order.TransitionTo(PendingPaymentState.Instance);
//    }
//}

//public sealed class PendingPaymentState : IOrderState
//{
//    public static readonly PendingPaymentState Instance = new();
//    public string Name => "PendingPayment";
//    private PendingPaymentState() { }

//    public bool CanHandle(string @event) => @event is "Pay" or "Cancel";
//    public void Handle(Order order, string @event)
//    {
//        switch (@event)
//        {
//            case "Pay": order.TransitionTo(ProcessingState.Instance); break;
//            case "Cancel": order.TransitionTo(CancelledState.Instance); break;
//        }
//    }
//}

//public sealed class ProcessingState : IOrderState
//{
//    public static readonly ProcessingState Instance = new();
//    public string Name => "Processing";
//    private ProcessingState() { }

//    public bool CanHandle(string @event) => @event is "Ship" or "Cancel";
//    public void Handle(Order order, string @event)
//    {
//        switch (@event)
//        {
//            case "Ship": order.TransitionTo(ShippedState.Instance); break;
//            case "Cancel": order.TransitionTo(CancelledState.Instance); break;
//        }
//    }
//}

//public sealed class ShippedState : IOrderState
//{
//    public static readonly ShippedState Instance = new();
//    public string Name => "Shipped";
//    private ShippedState() { }

//    public bool CanHandle(string @event) => @event is "Deliver" or "Return";
//    public void Handle(Order order, string @event)
//    {
//        switch (@event)
//        {
//            case "Deliver": order.TransitionTo(DeliveredState.Instance); break;
//            case "Return": order.TransitionTo(ReturnedState.Instance); break;
//        }
//    }
//}

//public sealed class DeliveredState : IOrderState
//{
//    public static readonly DeliveredState Instance = new();
//    public string Name => "Delivered";
//    private DeliveredState() { }

//    public bool CanHandle(string @event) => @event == "Confirm";
//    public void Handle(Order order, string @event)
//    {
//        if (@event == "Confirm")
//            order.TransitionTo(CompletedState.Instance);
//    }
//}

//public sealed class ReturnedState : IOrderState
//{
//    public static readonly ReturnedState Instance = new();
//    public string Name => "Returned";
//    private ReturnedState() { }

//    public bool CanHandle(string @event) => @event == "Refund";
//    public void Handle(Order order, string @event)
//    {
//        if (@event == "Refund")
//            order.TransitionTo(RefundedState.Instance);
//    }
//}

//public sealed class CancelledState : IOrderState
//{
//    public static readonly CancelledState Instance = new();
//    public string Name => "Cancelled";
//    private CancelledState() { }
//    public bool CanHandle(string @event) => false;
//    public void Handle(Order order, string @event) { }
//}

//public sealed class RefundedState : IOrderState
//{
//    public static readonly RefundedState Instance = new();
//    public string Name => "Refunded";
//    private RefundedState() { }
//    public bool CanHandle(string @event) => false;
//    public void Handle(Order order, string @event) { }
//}

//public sealed class CompletedState : IOrderState
//{
//    public static readonly CompletedState Instance = new();
//    public string Name => "Completed";
//    private CompletedState() { }
//    public bool CanHandle(string @event) => false;
//    public void Handle(Order order, string @event) { }
//}

//class Program
//{
//    static void Main()
//    {
//        var order = new Order(1001, 1299.99m);

//        Console.WriteLine($"Initial state: {order.CurrentStateName}\n");

//        string[] events = { "Submit", "Pay", "Ship", "Deliver", "Confirm" };
//        foreach (var e in events)
//            order.Trigger(e);

//        Console.WriteLine($"\nFinal state: {order.CurrentStateName}");
//        order.PrintHistory();

//        Console.WriteLine("\nTrying invalid transition...");
//        order.Trigger("Cancel");

//        var order2 = new Order(1002, 599.00m);
//        order2.Trigger("Submit");
//        order2.Trigger("Cancel");
//        order2.PrintHistory();

//        Console.WriteLine("\n=== Graphviz Diagram ===");
//        Console.WriteLine(order.GenerateDiagram());
//        File.WriteAllText("order_state_machine.dot", order.GenerateDiagram());
//        Console.WriteLine("Diagram saved to order_state_machine.dot");
//    }
//}

////2.14: Паттерн Memento для сохранения состояния
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;

//public sealed class TextEditor
//{
//    private string _content = "";
//    private string _title = "Untitled";
//    private DateTime _lastModified = DateTime.UtcNow;
//    private readonly HistoryManager _history = new();

//    public string Content
//    {
//        get => _content;
//        set { _content = value; _lastModified = DateTime.UtcNow; }
//    }

//    public string Title
//    {
//        get => _title;
//        set { _title = value; _lastModified = DateTime.UtcNow; }
//    }

//    public DateTime LastModified => _lastModified;

//    public void Type(string text)
//    {
//        Content += text;
//        Console.WriteLine($"[Typed] {text}");
//    }

//    public void Save() => _history.Save(this);
//    public void Undo() => _history.Undo(this);
//    public void Redo() => _history.Redo(this);

//    public void PrintStatus()
//    {
//        Console.WriteLine($"Title: {_title}");
//        Console.WriteLine($"Content ({Content.Length} chars):");
//        Console.WriteLine(string.IsNullOrEmpty(Content) ? "<empty>" : Content);
//        Console.WriteLine($"Last modified: {_lastModified:HH:mm:ss}\n");
//    }

//    public EditorMemento CreateMemento()
//    {
//        return new EditorMemento(_title, _content, _lastModified);
//    }

//    public void RestoreFromMemento(EditorMemento memento)
//    {
//        _title = memento.Title;
//        _content = memento.Content;
//        _lastModified = memento.Timestamp;
//    }
//}

//[Serializable]
//public sealed class EditorMemento
//{
//    public string Title { get; }
//    public string Content { get; }
//    public DateTime Timestamp { get; }
//    public long ContentSize => Content.Length * 2; // UTF-16

//    public EditorMemento(string title, string content, DateTime timestamp)
//    {
//        Title = title;
//        Content = content;
//        Timestamp = timestamp;
//    }
//}

//public sealed class DeltaMemento : EditorMemento
//{
//    public string Diff { get; }
//    public int StartIndex { get; }
//    public int RemovedLength { get; }

//    public DeltaMemento(string title, string diff, int startIndex, int removedLength, DateTime timestamp)
//        : base(title, null!, timestamp)
//    {
//        Diff = diff;
//        StartIndex = startIndex;
//        RemovedLength = removedLength;
//    }
//}

//public sealed class HistoryManager
//{
//    private readonly Stack<EditorMemento> _undoStack = new();
//    private readonly Stack<EditorMemento> _redoStack = new();
//    private EditorMemento? _baseSnapshot = null;
//    private int _deltaCount = 0;
//    private const int MaxDeltas = 10;

//    public int UndoCount => _undoStack.Count;
//    public int RedoCount => _redoStack.Count;

//    public void Save(TextEditor editor)
//    {
//        var current = editor.CreateMemento();

//        if (_baseSnapshot == null || ShouldCreateFullSnapshot(editor))
//        {
//            _baseSnapshot = current;
//            _deltaCount = 0;
//            _undoStack.Push(current);
//            Console.WriteLine($"[FULL SNAPSHOT] saved ({current.ContentSize} bytes)");
//        }
//        else
//        {
//            var diff = CreateDelta(_baseSnapshot.Content, current.Content);
//            var delta = new DeltaMemento(current.Title, diff.Added, diff.StartIndex, diff.RemovedLength, current.Timestamp);
//            _undoStack.Push(delta);
//            _deltaCount++;
//            Console.WriteLine($"[DELTA] +{diff.Added.Length} -{diff.RemovedLength} chars ({diff.Added.Length * 2} bytes)");
//        }

//        _redoStack.Clear();
//    }

//    public void Undo(TextEditor editor)
//    {
//        if (_undoStack.Count == 0) return;

//        var memento = _undoStack.Pop();
//        _redoStack.Push(editor.CreateMemento());

//        if (memento is DeltaMemento delta)
//        {
//            var previousContent = ApplyInverseDelta(_baseSnapshot!.Content, delta);
//            editor.RestoreFromMemento(new EditorMemento(delta.Title, previousContent, delta.Timestamp));
//            Console.WriteLine($"[UNDO DELTA] restored to {delta.Timestamp:HH:mm:ss}");
//        }
//        else
//        {
//            editor.RestoreFromMemento(memento);
//            _baseSnapshot = memento;
//            _deltaCount = 0;
//            Console.WriteLine($"[UNDO FULL] restored to {memento.Timestamp:HH:mm:ss}");
//        }
//    }

//    public void Redo(TextEditor editor)
//    {
//        if (_redoStack.Count == 0) return;

//        var memento = _redoStack.Pop();
//        _undoStack.Push(editor.CreateMemento());
//        editor.RestoreFromMemento(memento);
//        Console.WriteLine($"[REDO] restored to {memento.Timestamp:HH:mm:ss}");
//    }

//    private bool ShouldCreateFullSnapshot(TextEditor editor)
//    {
//        return _deltaCount >= MaxDeltas ||
//               _baseSnapshot == null ||
//               Math.Abs(editor.Content.Length - _baseSnapshot.Content.Length) > 1000;
//    }

//    private (string Added, int StartIndex, int RemovedLength) CreateDelta(string oldText, string newText)
//    {
//        int i = 0;
//        while (i < oldText.Length && i < newText.Length && oldText[i] == newText[i]) i++;

//        int j = 0;
//        while (j < oldText.Length - i && j < newText.Length - i &&
//               oldText[oldText.Length - 1 - j] == newText[newText.Length - 1 - j]) j++;

//        var added = newText.Substring(i, newText.Length - i - j);
//        return (added, i, j);
//    }

//    private string ApplyInverseDelta(string baseText, DeltaMemento delta)
//    {
//        return baseText.Remove(delta.StartIndex, delta.Diff.Length);
//    }

//    public void PrintStats()
//    {
//        long totalBytes = _undoStack.Sum(m => m is DeltaMemento d ? d.Diff.Length * 2 : m.ContentSize);
//        Console.WriteLine($"History: {_undoStack.Count} snapshots, ~{totalBytes / 1024} KB used");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var editor = new TextEditor();
//        editor.Title = "My Document.txt";

//        editor.Type("Hello world!");
//        editor.Save();

//        editor.Type(" This is a test.");
//        editor.Save();

//        editor.Type(" Adding more text to demonstrate delta snapshots...");
//        editor.Save();
//        editor.Save();
//        editor.Save();

//        Console.WriteLine("\n=== Current State ===");
//        editor.PrintStatus();

//        Console.WriteLine("=== UNDO x3 ===");
//        editor.Undo();
//        editor.Undo();
//        editor.Undo();

//        editor.PrintStatus();

//        Console.WriteLine("=== REDO x2 ===");
//        editor.Redo();
//        editor.Redo();

//        editor.PrintStatus();

//        editor.Type(" Final changes.");
//        editor.Save();

//        ((HistoryManager)typeof(TextEditor).GetField("_history",
//            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
//            .GetValue(editor)!).PrintStats();
//    }
//}

////2.15: Паттерн Flyweight для экономии памяти
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;

//// Внутреннее (общее) состояние — тяжёлое, одинаковое для многих объектов
//public sealed class TreeType
//{
//    public string Name { get; }
//    public string Texture { get; }
//    public int[] ColorMap { get; }           // 256x256 RGBA = 262144 байт
//    public byte[] HeightMap { get; }         // 1024x1024 = 1 МБ
//    public double GrowthRate { get; }

//    public TreeType(string name, string texturePath)
//    {
//        Name = name;
//        Texture = texturePath;
//        ColorMap = GenerateColorMap();
//        HeightMap = GenerateHeightMap();
//        GrowthRate = Random.Shared.NextDouble() * 0.5 + 0.8;
//    }

//    private static int[] GenerateColorMap()
//    {
//        var map = new int[256 * 256];
//        var rnd = Random.Shared;
//        for (int i = 0; i < map.Length; i++)
//            map[i] = rnd.Next();
//        return map;
//    }

//    private static byte[] GenerateHeightMap()
//    {
//        var map = new byte[1024 * 1024];
//        Random.Shared.NextBytes(map);
//        return map;
//    }

//    public long IntrinsicMemory =>
//        Name.Length * 2 +
//        Texture.Length * 2 +
//        ColorMap.Length * 4 +
//        HeightMap.Length;
//}

//// Внешнее (уникальное) состояние — лёгкое, индивидуальное для каждого дерева
//public readonly struct Tree
//{
//    public double X { get; }
//    public double Y { get; }
//    public int Age { get; }
//    public double Height { get; }
//    public TreeType Type { get; }

//    public Tree(double x, double y, int age, TreeType type)
//    {
//        X = x; Y = y; Age = age;
//        Height = age * type.GrowthRate;
//        Type = type;
//    }

//    public void Render()
//    {
//        Console.WriteLine($"[Render] {Type.Name} at ({X:F0},{Y:F0}), age {Age}, height {Height:F1}m");
//    }
//}

//// Фабрика легковесов (Flyweight Factory)
//public sealed class TreeFactory
//{
//    private static readonly ConcurrentDictionary<string, TreeType> _types = new();

//    public static TreeType GetTreeType(string name, string texturePath = "")
//    {
//        return _types.GetOrAdd(name, key => new TreeType(key, texturePath));
//    }

//    public static IReadOnlyDictionary<string, TreeType> GetAllTypes() => _types;
//    public static void Clear() => _types.Clear();
//}

//// Контекст — лес с миллионами деревьев
//public sealed class Forest
//{
//    private readonly List<Tree> _trees = new();

//    public void PlantTree(double x, double y, string typeName, int age = 10)
//    {
//        var type = TreeFactory.GetTreeType(typeName);
//        _trees.Add(new Tree(x, y, age, type));
//    }

//    public void RenderAll()
//    {
//        Console.WriteLine($"Rendering {_trees.Count:N0} trees...");
//        foreach (var tree in _trees.Take(10)) // показываем только первые 10
//            tree.Render();
//        if (_trees.Count > 10)
//            Console.WriteLine($"... and {_trees.Count - 10:N0} more trees");
//    }

//    public void PrintMemoryStats()
//    {
//        var types = TreeFactory.GetAllTypes();
//        long intrinsicTotal = types.Values.Sum(t => t.IntrinsicMemory);
//        long extrinsicTotal = _trees.Count * (8 + 8 + 4 + 8 + 8); // double, double, int, double, ref

//        Console.WriteLine("\n=== MEMORY USAGE ===");
//        Console.WriteLine($"Tree types (shared):     {types.Count} objects");
//        Console.WriteLine($"Intrinsic data (shared): {intrinsicTotal / 1024 / 1024:F2} MB");
//        Console.WriteLine($"Trees (individual):      {_trees.Count:N0} objects");
//        Console.WriteLine($"Extrinsic data:          {extrinsicTotal / 1024 / 1024:F2} MB");
//        Console.WriteLine($"Total estimated memory:  {(intrinsicTotal + extrinsicTotal) / 1024 / 1024:F2} MB");
//        Console.WriteLine($"Memory saved with Flyweight: ~{extrinsicTotal / 1024 / 1024 + 5:F1} MB");
//        Console.WriteLine($"Memory WITHOUT Flyweight:  ~{(_trees.Count * (intrinsicTotal / types.Count + 100)) / 1024 / 1024:F1} MB");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Planting 1,000,000 trees using Flyweight pattern...\n");

//        var forest = new Forest();

//        var sw = Stopwatch.StartNew();

//        var rnd = new Random(42);
//        string[] species = { "Oak", "Pine", "Birch", "Maple", "Spruce" };

//        for (int i = 0; i < 1_000_000; i++)
//        {
//            var speciesName = species[rnd.Next(species.Length)];
//            forest.PlantTree(
//                x: rnd.NextDouble() * 10000, y: rnd.NextDouble() * 10000, typeName: speciesName, age: rnd.Next(1, 200));
//        }

//        sw.Stop();
//        Console.WriteLine($"Planted 1,000,000 trees in {sw.ElapsedMilliseconds} ms\n");

//        forest.RenderAll();
//        forest.PrintMemoryStats();

//        Console.WriteLine($"\nUnique tree types created: {TreeFactory.GetAllTypes().Count}");
//        Console.WriteLine($"Flyweight saved: ~{((1_000_000 * 1.2) - 5):F1} MB of RAM!");
//    }
//}

////2.16: Паттерн Interpreter для языков
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;

//public abstract record Expr
//{
//    public abstract double Eval(Dictionary<string, double> vars, Dictionary<string, Func<double[], double>> funcs);
//    public abstract Expr Optimize();
//    public abstract string ToString();
//}

//public sealed record NumberExpr(double Value) : Expr
//{
//    public override double Eval(Dictionary<string, double> _, Dictionary<string, Func<double[], double>> __) => Value;
//    public override Expr Optimize() => this;
//    public override string ToString() => Value.ToString("G");
//}

//public sealed record VariableExpr(string Name) : Expr
//{
//    public override double Eval(Dictionary<string, double> vars, Dictionary<string, Func<double[], double>> _)
//        => vars.TryGetValue(Name, out var v) ? v : throw new KeyNotFoundException($"Variable '{Name}' not defined");
//    public override Expr Optimize() => this;
//    public override string ToString() => Name;
//}

//public sealed record BinaryExpr(Expr Left, char Op, Expr Right) : Expr
//{
//    public override double Eval(Dictionary<string, double> vars, Dictionary<string, Func<double[], double>> funcs)
//    {
//        double a = Left.Eval(vars, funcs);
//        double b = Right.Eval(vars, funcs);
//        return Op switch
//        {
//            '+' => a + b,
//            '-' => a - b,
//            '*' => a * b,
//            '/' => b == 0 ? throw new DivideByZeroException() : a / b,
//            '^' => Math.Pow(a, b),
//            _ => throw new InvalidOperationException($"Unknown operator {Op}")
//        };
//    }

//    public override Expr Optimize()
//    {
//        var l = Left.Optimize();
//        var r = Right.Optimize();

//        if (l is NumberExpr ln && r is NumberExpr rn)
//        {
//            try { return new NumberExpr(Eval(new(), new())); }
//            catch { /* не константа */ }
//        }

//        if (Op == '+' && (IsZero(l) || IsZero(r))) return Op == '+' && IsZero(l) ? r : l;
//        if (Op == '*' && (IsZero(l) || IsZero(r))) return new NumberExpr(0);
//        if (Op == '*' && IsOne(l)) return r;
//        if (Op == '*' && IsOne(r)) return l;

//        return l == Left && r == Right ? this : new BinaryExpr(l, Op, r);
//    }

//    private static bool IsZero(Expr e) => e is NumberExpr n && Math.Abs(n.Value) < 1e-10;
//    private static bool IsOne(Expr e) => e is NumberExpr n && Math.Abs(n.Value - 1) < 1e-10;

//    public override string ToString() => $"({Left} {Op} {Right})";
//}

//public sealed record UnaryExpr(char Op, Expr Expr) : Expr
//{
//    public override double Eval(Dictionary<string, double> vars, Dictionary<string, Func<double[], double>> funcs)
//        => Op == '-' ? -Expr.Eval(vars, funcs) : Expr.Eval(vars, funcs);

//    public override Expr Optimize()
//    {
//        var e = Expr.Optimize();
//        if (e is NumberExpr n && Op == '-') return new NumberExpr(-n.Value);
//        return e == Expr ? this : new UnaryExpr(Op, e);
//    }

//    public override string ToString() => Op + Expr.ToString();
//}

//public sealed record CallExpr(string FuncName, Expr[] Args) : Expr
//{
//    public override double Eval(Dictionary<string, double> vars, Dictionary<string, Func<double[], double>> funcs)
//    {
//        if (!funcs.TryGetValue(FuncName, out var func))
//            throw new KeyNotFoundException($"Function '{FuncName}' not defined");

//        var args = Args.Select(a => a.Eval(vars, funcs)).ToArray();
//        return func(args);
//    }

//    public override Expr Optimize() => new CallExpr(FuncName, Args.Select(a => a.Optimize()).ToArray());
//    public override string ToString() => $"{FuncName}({string.Join(", ", Args)})";
//}

//public sealed class MathInterpreter
//{
//    private readonly Dictionary<string, Func<double[], double>> _functions = new()
//    {
//        ["sin"] = a => Math.Sin(a[0]),
//        ["cos"] = a => Math.Cos(a[0]),
//        ["tan"] = a => Math.Tan(a[0]),
//        ["log"] = a => Math.Log(a[0], a.Length > 1 ? a[1] : Math.E),
//        ["sqrt"] = a => Math.Sqrt(a[0]),
//        ["abs"] = a => Math.Abs(a[0]),
//        ["max"] = a => a.Max(),
//        ["min"] = a => a.Min(),
//        ["pow"] = a => Math.Pow(a[0], a[1])
//    };

//    private readonly string _input;
//    private int _pos;
//    private string? _currentToken;

//    public MathInterpreter(string input) => _input = input.Replace(" ", "");

//    public Expr Parse()
//    {
//        _pos = 0;
//        NextToken();
//        var expr = ParseExpression();
//        if (_currentToken != null)
//            throw new SyntaxException($"Unexpected token at position {_pos}: '{_currentToken}'");
//        return expr.Optimize();
//    }

//    private Expr ParseExpression() => ParseBinary(0);

//    private Expr ParseBinary(int precedence)
//    {
//        var left = precedence switch
//        {
//            0 => ParseUnary(),
//            _ => ParseBinary(precedence - 1)
//        };

//        while (true)
//        {
//            var op = GetOperatorPrecedence(CurrentToken());
//            if (op <= precedence) break;

//            NextToken();
//            var right = ParseBinary(op);
//            left = new BinaryExpr(left, CurrentToken()[0], right);
//        }
//        return left;
//    }

//    private Expr ParseUnary()
//    {
//        if (CurrentToken() is "-" or "+")
//        {
//            var op = CurrentToken()[0];
//            NextToken();
//            return new UnaryExpr(op, ParseUnary());
//        }
//        return ParsePrimary();
//    }

//    private Expr ParsePrimary()
//    {
//        var token = CurrentToken();

//        if (double.TryParse(token, out var num))
//        {
//            NextToken();
//            return new NumberExpr(num);
//        }

//        if (Regex.IsMatch(token!, @"^[a-zA-Z_][a-zA-Z0-9_]*$"))
//        {
//            if (PeekToken() == "(")
//            {
//                var name = token!;
//                NextToken(); NextToken();
//                var args = new List<Expr>();
//                if (CurrentToken() != ")")
//                {
//                    do
//                    {
//                        args.Add(ParseExpression());
//                    } while (CurrentToken() == "," && (NextToken(), true));
//                }
//                if (CurrentToken() != ")")
//                    throw new SyntaxException($"Expected ')' after function call, got '{CurrentToken()}'");
//                NextToken();
//                return new CallExpr(name, args.ToArray());
//            }
//            else
//            {
//                NextToken();
//                return new VariableExpr(token!);
//            }
//        }

//        if (token == "(")
//        {
//            NextToken();
//            var expr = ParseExpression();
//            if (CurrentToken() != ")")
//                throw new SyntaxException($"Expected ')', got '{CurrentToken()}' at pos {_pos}");
//            NextToken();
//            return expr;
//        }

//        throw new SyntaxException($"Unexpected token: '{token}' at position {_pos}");
//    }

//    private string? CurrentToken() => _currentToken;
//    private string? PeekToken()
//    {
//        var saved = _pos;
//        var token = NextToken();
//        _pos = saved;
//        _currentToken = token;
//        return token;
//    }

//    private string? NextToken()
//    {
//        while (_pos < _input.Length && char.IsWhiteSpace(_input[_pos])) _pos++;

//        if (_pos >= _input.Length)
//            return _currentToken = null;

//        var c = _input[_pos];

//        if (c is '+' or '-' or '*' or '/' or '^' or '(' or ')' or ',')
//        {
//            _pos++;
//            return _currentToken = c.ToString();
//        }

//        if (char.IsDigit(c) || c == '.')
//        {
//            int start = _pos;
//            while (_pos < _input.Length && (char.IsDigit(_input[_pos]) || _input[_pos] == '.'))
//                _pos++;
//            return _currentToken = _input[start.._pos];
//        }

//        if (char.IsLetter(c) || c == '_')
//        {
//            int start = _pos;
//            while (_pos < _input.Length && (char.IsLetterOrDigit(_input[_pos]) || _input[_pos] == '_'))
//                _pos++;
//            return _currentToken = _input[start.._pos];
//        }

//        throw new SyntaxException($"Invalid character: '{c}' at position {_pos}");
//    }

//    private static int GetOperatorPrecedence(string? op) => op switch
//    {
//        "+" or "-" => 1,
//        "*" or "/" => 2,
//        "^" => 3,
//        _ => 0
//    };
//}

//public class SyntaxException : Exception { public SyntaxException(string msg) : base(msg) { } }

//class Program
//{
//    static void Main()
//    {
//        var examples = new[]
//        {
//            "2 + 3 * 4",
//            "(2 + 3) * 4",
//            "sin(pi / 4) * 100",
//            "x ^ 2 + 2 * x + 1",
//            "sqrt(abs(-25)) + log(100, 10)",
//            "max(10, 20, 30) + min(5, -5)",
//            "2^3^2",
//            "0 * x + 100",
//            "1 * (x + y) + 0"
//        };

//        foreach (var expr in examples)
//        {
//            Console.WriteLine($"\nExpression: {expr}");
//            try
//            {
//                var interpreter = new MathInterpreter(expr);
//                var ast = interpreter.Parse();
//                var optimized = ast.Optimize();

//                Console.WriteLine($"AST:         {ast}");
//                Console.WriteLine($"Optimized:   {optimized}");

//                var vars = new Dictionary<string, double> { ["x"] = 5, ["y"] = 3, ["pi"] = Math.PI };
//                var result = ast.Eval(vars, interpreter._functions);
//                var optResult = optimized.Eval(vars, interpreter._functions);

//                Console.WriteLine($"Result:      {result}");
//                Console.WriteLine($"Optimized result: {optResult}");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"ERROR: {ex.Message}");
//            }
//        }
//    }
//}

////2.17: Паттерн Composite для древовидных структур
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public abstract class FileSystemItem
//{
//    public string Name { get; }
//    public DateTime CreatedAt { get; } = DateTime.UtcNow;

//    protected FileSystemItem(string name) => Name = name;

//    public abstract long GetSize();
//    public abstract IEnumerable<FileSystemItem> GetChildren();
//    public abstract void Accept(IFileSystemVisitor visitor);
//    public abstract FileSystemItem? Find(string name);
//    public abstract IEnumerable<FileSystemItem> Search(Func<FileSystemItem, bool> predicate);

//    public override string ToString() => $"{Name} [{GetType().Name.Replace("Item", "")}]";
//}

//public sealed class FileItem : FileSystemItem
//{
//    public long Size { get; }

//    public FileItem(string name, long size = 0) : base(name)
//    {
//        Size = size > 0 ? size : Random.Shared.Next(1000, 100_000);
//    }

//    public override long GetSize() => Size;
//    public override IEnumerable<FileSystemItem> GetChildren() => Enumerable.Empty<FileSystemItem>();
//    public override void Accept(IFileSystemVisitor visitor) => visitor.VisitFile(this);

//    public override FileSystemItem? Find(string name)
//        => string.Equals(Name, name, StringComparison.OrdinalIgnoreCase) ? this : null;

//    public override IEnumerable<FileSystemItem> Search(Func<FileSystemItem, bool> predicate)
//        => predicate(this) ? new[] { this } : Enumerable.Empty<FileSystemItem>();

//    public override string ToString() => $"{Name} ({Size / 1024.0:F1} KB)";
//}

//public sealed class DirectoryItem : FileSystemItem
//{
//    private readonly List<FileSystemItem> _children = new();

//    public IReadOnlyList<FileSystemItem> Children => _children;
//    public int FileCount => _children.OfType<FileItem>().Count();
//    public int DirectoryCount => _children.OfType<DirectoryItem>().Count();

//    public DirectoryItem(string name) : base(name) { }

//    public void Add(FileSystemItem item) => _children.Add(item);
//    public void Remove(FileSystemItem item) => _children.Remove(item);

//    public override long GetSize() => _children.Sum(c => c.GetSize());

//    public override IEnumerable<FileSystemItem> GetChildren() => _children;

//    public override void Accept(IFileSystemVisitor visitor)
//    {
//        visitor.VisitDirectory(this);
//        foreach (var child in _children)
//            child.Accept(visitor);
//    }

//    public override FileSystemItem? Find(string name)
//    {
//        if (string.Equals(Name, name, StringComparison.OrdinalIgnoreCase))
//            return this;

//        foreach (var child in _children)
//        {
//            var found = child.Find(name);
//            if (found != null) return found;
//        }
//        return null;
//    }

//    public override IEnumerable<FileSystemItem> Search(Func<FileSystemItem, bool> predicate)
//    {
//        var result = new List<FileSystemItem>();
//        if (predicate(this)) result.Add(this);
//        foreach (var child in _children)
//            result.AddRange(child.Search(predicate));
//        return result;
//    }

//    public override string ToString() => $"{Name}/ ({_children.Count} items, {GetSize() / 1024.0:F1} KB)";
//}

//public interface IFileSystemVisitor
//{
//    void VisitFile(FileItem file);
//    void VisitDirectory(DirectoryItem directory);
//}

//public sealed class SizeCalculatorVisitor : IFileSystemVisitor
//{
//    public long TotalSize { get; private set; }
//    public int FileCount { get; private set; }
//    public int DirectoryCount { get; private set; }

//    public void VisitFile(FileItem file)
//    {
//        TotalSize += file.GetSize();
//        FileCount++;
//    }

//    public void VisitDirectory(DirectoryItem directory) => DirectoryCount++;
//}

//public sealed class TreePrinterVisitor : IFileSystemVisitor
//{
//    private int _depth = 0;
//    private readonly string _indent = "  ";

//    public void VisitFile(FileItem file)
//        => Console.WriteLine($"{new string('│', _depth)}{_indent}└─ {file}");

//    public void VisitDirectory(DirectoryItem directory)
//    {
//        Console.WriteLine($"{new string('│', _depth)}{_indent}└─ {directory}");
//        _depth++;
//        foreach (var child in directory.Children)
//            child.Accept(this);
//        _depth--;
//    }
//}

//public sealed class SearchVisitor : IFileSystemVisitor
//{
//    private readonly string _searchName;
//    public List<FileSystemItem> Results { get; } = new();

//    public SearchVisitor(string name) => _searchName = name;

//    public void VisitFile(FileItem file)
//    {
//        if (file.Name.Contains(_searchName, StringComparison.OrdinalIgnoreCase))
//            Results.Add(file);
//    }

//    public void VisitDirectory(DirectoryItem directory)
//    {
//        if (directory.Name.Contains(_searchName, StringComparison.OrdinalIgnoreCase))
//            Results.Add(directory);
//    }
//}

//class Program
//{
//    static DirectoryItem CreateSampleFileSystem()
//    {
//        var root = new DirectoryItem("root");

//        var home = new DirectoryItem("home");
//        var docs = new DirectoryItem("Documents");
//        var pics = new DirectoryItem("Pictures");
//        var music = new DirectoryItem("Music");

//        docs.Add(new FileItem("resume.pdf", 250_000));
//        docs.Add(new FileItem("notes.txt", 5_000));
//        docs.Add(new FileItem("presentation.pptx", 2_500_000));

//        pics.Add(new FileItem("vacation.jpg", 4_200_000));
//        pics.Add(new FileItem("cat.png", 890_000));
//        var family = new DirectoryItem("Family");
//        family.Add(new FileItem("birthday.mp4", 125_000_000));
//        family.Add(new FileItem("photo1.jpg", 3_100_000));
//        pics.Add(family);

//        music.Add(new FileItem("song1.mp3", 8_500_000));
//        music.Add(new FileItem("album.zip", 98_000_000));

//        home.Add(docs);
//        home.Add(pics);
//        home.Add(music);
//        home.Add(new FileItem("readme.txt", 1200));

//        root.Add(home);
//        root.Add(new FileItem("config.ini", 800));
//        root.Add(new DirectoryItem("tmp"));

//        return root;
//    }

//    static void Main()
//    {
//        var fs = CreateSampleFileSystem();

//        Console.WriteLine("FILE SYSTEM TREE:");
//        fs.Accept(new TreePrinterVisitor());

//        Console.WriteLine("\nSTATISTICS:");
//        var calc = new SizeCalculatorVisitor();
//        fs.Accept(calc);
//        Console.WriteLine($"Total size: {calc.TotalSize / 1024.0 / 1024:F2} MB");
//        Console.WriteLine($"Files: {calc.FileCount}, Directories: {calc.DirectoryCount}");

//        Console.WriteLine("\nSEARCH 'photo':");
//        var search = new SearchVisitor("photo");
//        fs.Accept(search);
//        foreach (var item in search.Results)
//            Console.WriteLine($"  → {item}");

//        Console.WriteLine("\nFIND 'birthday.mp4':");
//        var found = fs.Find("birthday.mp4");
//        Console.WriteLine(found != null ? $"Found: {found}" : "Not found");

//        Console.WriteLine("\nSEARCH ALL > 10 MB:");
//        var largeFiles = fs.Search(f => f is FileItem file && file.GetSize() > 10_000_000).ToList();
//        foreach (var f in largeFiles)
//            Console.WriteLine($"  → {f}");
//    }
//}

////2.18: Паттерн Visitor для операций над структурами
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//public abstract record Expr
//{
//    public abstract T Accept<T>(IExprVisitor<T> visitor);
//    public abstract void Accept(IExprVisitor visitor);
//}

//public sealed record NumberExpr(double Value) : Expr
//{
//    public override T Accept<T>(IExprVisitor<T> v) => v.Visit(this);
//    public override void Accept(IExprVisitor v) => v.Visit(this);
//}

//public sealed record VariableExpr(string Name) : Expr
//{
//    public override T Accept<T>(IExprVisitor<T> v) => v.Visit(this);
//    public override void Accept(IExprVisitor v) => v.Visit(this);
//}

//public sealed record BinaryExpr(Expr Left, char Op, Expr Right) : Expr
//{
//    public override T Accept<T>(IExprVisitor<T> v) => v.Visit(this);
//    public override void Accept(IExprVisitor v) => v.Visit(this);
//}

//public sealed record UnaryExpr(char Op, Expr Expr) : Expr
//{
//    public override T Accept<T>(IExprVisitor<T> v) => v.Visit(this);
//    public override void Accept(IExprVisitor v) => v.Visit(this);
//}

//public sealed record CallExpr(string Name, Expr[] Args) : Expr
//{
//    public override T Accept<T>(IExprVisitor<T> v) => v.Visit(this);
//    public override void Accept(IExprVisitor v) => v.Visit(this);
//}

//public interface IExprVisitor<T>
//{
//    T Visit(NumberExpr expr);
//    T Visit(VariableExpr expr);
//    T Visit(BinaryExpr expr);
//    T Visit(UnaryExpr expr);
//    T Visit(CallExpr expr);
//}

//public interface IExprVisitor
//{
//    void Visit(NumberExpr expr);
//    void Visit(VariableExpr expr);
//    void Visit(BinaryExpr expr);
//    void Visit(UnaryExpr expr);
//    void Visit(CallExpr expr);
//}


//public sealed class Evaluator : IExprVisitor<double>
//{
//    private readonly Dictionary<string, double> _vars;
//    private readonly Dictionary<string, Func<double[], double>> _funcs;

//    public Evaluator(Dictionary<string, double>? vars = null, Dictionary<string, Func<double[], double>>? funcs = null)
//    {
//        _vars = vars ?? new();
//        _funcs = funcs ?? new()
//        {
//            ["sin"] = a => Math.Sin(a[0]),
//            ["cos"] = a => Math.Cos(a[0]),
//            ["pow"] = a => Math.Pow(a[0], a[1]),
//            ["max"] = a => a.Max(),
//            ["min"] = a => a.Min()
//        };
//    }

//    public double Visit(NumberExpr expr) => expr.Value;
//    public double Visit(VariableExpr expr)
//        => _vars.TryGetValue(expr.Name, out var v) ? v : throw new KeyNotFoundException(expr.Name);
//    public double Visit(BinaryExpr expr)
//    {
//        double l = expr.Left.Accept(this);
//        double r = expr.Right.Accept(this);
//        return expr.Op switch
//        {
//            '+' => l + r,
//            '-' => l - r,
//            '*' => l * r,
//            '/' => r == 0 ? throw new DivideByZeroException() : l / r,
//            '^' => Math.Pow(l, r),
//            _ => throw new NotSupportedException($"Op {expr.Op}")
//        };
//    }
//    public double Visit(UnaryExpr expr) => expr.Op == '-' ? -expr.Expr.Accept(this) : expr.Expr.Accept(this);
//    public double Visit(CallExpr expr)
//    {
//        var func = _funcs[expr.Name];
//        var args = expr.Args.Select(a => a.Accept(this)).ToArray();
//        return func(args);
//    }
//}

//public sealed class PrettyPrinter : IExprVisitor
//{
//    private readonly StringBuilder _sb = new();
//    private int _depth = 0;

//    public string Result => _sb.ToString();

//    public void Visit(NumberExpr expr) => _sb.Append(expr.Value);
//    public void Visit(VariableExpr expr) => _sb.Append(expr.Name);

//    public void Visit(BinaryExpr expr)
//    {
//        _sb.Append('(');
//        expr.Left.Accept(this);
//        _sb.Append($" {expr.Op} ");
//        expr.Right.Accept(this);
//        _sb.Append(')');
//    }

//    public void Visit(UnaryExpr expr)
//    {
//        _sb.Append(expr.Op);
//        expr.Expr.Accept(this);
//    }

//    public void Visit(CallExpr expr)
//    {
//        _sb.Append(expr.Name).Append('(');
//        for (int i = 0; i < expr.Args.Length; i++)
//        {
//            expr.Args[i].Accept(this);
//            if (i < expr.Args.Length - 1) _sb.Append(", ");
//        }
//        _sb.Append(')');
//    }
//}

//public sealed class Optimizer : IExprVisitor<Expr>
//{
//    public Expr Visit(NumberExpr expr) => expr;
//    public Expr Visit(VariableExpr expr) => expr;
//    public Expr Visit(UnaryExpr expr)
//    {
//        var e = expr.Expr.Accept(this);
//        if (e is NumberExpr n && expr.Op == '-') return new NumberExpr(-n.Value);
//        return e == expr.Expr ? expr : new UnaryExpr(expr.Op, e);
//    }

//    public Expr Visit(BinaryExpr expr)
//    {
//        var l = expr.Left.Accept(this);
//        var r = expr.Right.Accept(this);

//        if (l is NumberExpr ln && r is NumberExpr rn)
//        {
//            var eval = new Evaluator();
//            return new NumberExpr(new BinaryExpr(l, expr.Op, r).Accept(eval));
//        }

//        if (expr.Op == '+' && IsZero(l)) return r;
//        if (expr.Op == '+' && IsZero(r)) return l;

//        if (expr.Op == '*' && IsOne(l)) return r;
//        if (expr.Op == '*' && IsOne(r)) return l;

//        if (expr.Op == '*' && (IsZero(l) || IsZero(r))) return new NumberExpr(0);

//        return new BinaryExpr(l, expr.Op, r);
//    }

//    public Expr Visit(CallExpr expr)
//        => new CallExpr(expr.Name, expr.Args.Select(a => a.Accept(this)).ToArray());

//    private static bool IsZero(Expr e) => e is NumberExpr n && Math.Abs(n.Value) < 1e-12;
//    private static bool IsOne(Expr e) => e is NumberExpr n && Math.Abs(n.Value - 1) < 1e-12;
//}

//public sealed class RpnTransformer : IExprVisitor
//{
//    private readonly List<string> _output = new();

//    public string[] Result => _output.ToArray();

//    public void Visit(NumberExpr expr) => _output.Add(expr.Value.ToString());
//    public void Visit(VariableExpr expr) => _output.Add(expr.Name);
//    public void Visit(BinaryExpr expr)
//    {
//        expr.Left.Accept(this);
//        expr.Right.Accept(this);
//        _output.Add(expr.Op.ToString());
//    }
//    public void Visit(UnaryExpr expr)
//    {
//        expr.Expr.Accept(this);
//        _output.Add(expr.Op.ToString());
//    }
//    public void Visit(CallExpr expr)
//    {
//        foreach (var arg in expr.Args)
//            arg.Accept(this);
//        _output.Add(expr.Name);
//        _output.Add($"{expr.Args.Length} CALL");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var expressions = new Expr[]
//        {
//            new BinaryExpr(
//                new BinaryExpr(new NumberExpr(2), '+', new NumberExpr(3)),
//                '*',
//                new NumberExpr(4)
//            ),
//            new BinaryExpr(
//                new VariableExpr("x"),
//                '*',
//                new BinaryExpr(new NumberExpr(0), '+', new NumberExpr(100))
//            ),
//            new CallExpr("pow",
//                new Expr[] { new VariableExpr("x"), new NumberExpr(2) }
//            ),
//            new BinaryExpr(
//                new CallExpr("sin", new Expr[] { new VariableExpr("pi") }),
//                '*',
//                new NumberExpr(42)
//            )
//        };

//        foreach (var expr in expressions)
//        {
//            Console.WriteLine($"\nИсходное выражение:");
//            var printer = new PrettyPrinter();
//            expr.Accept(printer);
//            Console.WriteLine(printer.Result);

//            Console.WriteLine("Оптимизация:");
//            var optimized = expr.Accept(new Optimizer());
//            var optPrinter = new PrettyPrinter();
//            optimized.Accept(optPrinter);
//            Console.WriteLine(optPrinter.Result);

//            Console.WriteLine("Вычисление (x=5, pi=3.14159):");
//            var eval = new Evaluator(new() { ["x"] = 5, ["pi"] = Math.PI });
//            Console.WriteLine($"Результат: {optimized.Accept(eval)}");

//            Console.WriteLine("RPN (обратная польская нотация):");
//            var rpn = new RpnTransformer();
//            optimized.Accept(rpn);
//            Console.WriteLine(string.Join(" ", rpn.Result));

//            Console.WriteLine(new string('-', 60));
//        }
//    }
//}

////2.19: SOLID принципы - проектирование системы
//public interface IOrderRepository { Task SaveAsync(Order order); }
//public interface IEmailService { Task SendConfirmationAsync(Order order); }
//public interface IReportGenerator { Task<byte[]> GenerateAsync(Order order); }
//public interface ILogger { Task LogAsync(string message); }

//public interface IOrderProcessor
//{
//    Task ProcessAsync(Order order);
//}

//public sealed class StandardOrderProcessor : IOrderProcessor
//{
//    private readonly IOrderRepository _repo;
//    private readonly IEmailService _email;
//    private readonly ILogger _logger;

//    public StandardOrderProcessor(IOrderRepository repo, IEmailService email, ILogger logger)
//        => (_repo, _email, _logger) = (repo, email, logger);

//    public async Task ProcessAsync(Order order)
//    {
//        await _repo.SaveAsync(order);
//        await _email.SendConfirmationAsync(order);
//        await _logger.LogAsync($"Order {order.Id} processed");
//    }
//}

//public sealed class PremiumOrderProcessor : IOrderProcessor
//{
//    private readonly IOrderProcessor _next;
//    private readonly IReportGenerator _report;

//    public PremiumOrderProcessor(IOrderProcessor next, IReportGenerator report)
//        => (_next, _report) = (next, report);

//    public async Task ProcessAsync(Order order)
//    {
//        await _next.ProcessAsync(order);
//        var pdf = await _report.GenerateAsync(order);
//    }
//}

//public abstract record Discount
//{
//    public abstract decimal Apply(decimal amount);
//}

//public sealed record PercentageDiscount(decimal Percent) : Discount
//{
//    public override decimal Apply(decimal amount) => amount * (1 - Percent / 100);
//}

//public sealed record FixedDiscount(decimal Amount) : Discount
//{
//    public override decimal Apply(decimal amount)
//        => amount >= Amount ? amount - Amount : throw new InvalidOperationException("Not enough amount");
//}


//public sealed class OrderService
//{
//    private readonly IOrderProcessor _processor;

//    public OrderService(IOrderProcessor processor) => _processor = processor;

//    public Task Process(Order order) => _processor.ProcessAsync(order);
//}

//public static class ServiceCollectionExtensions
//{
//    public static IServiceCollection AddOrderProcessing(this IServiceCollection services)
//    {
//        services.AddSingleton<IOrderRepository, SqlOrderRepository>();
//        services.AddSingleton<IEmailService, SmtpEmailService>();
//        services.AddSingleton<ILogger, FileLogger>();
//        services.AddSingleton<IReportGenerator, PdfReportGenerator>();

//        services.AddSingleton<IOrderProcessor>(sp =>
//        {
//            var baseProcessor = new StandardOrderProcessor(
//                sp.GetRequiredService<IOrderRepository>(),
//                sp.GetRequiredService<IEmailService>(),
//                sp.GetRequiredService<ILogger>());

//            return new PremiumOrderProcessor(baseProcessor, sp.GetRequiredService<IReportGenerator>());
//        });

//        services.AddSingleton<OrderService>();
//        return services;
//    }
//}

////2.20: Паттерн Repository для доступа к данным
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Caching.Memory;

//public record Order(int Id, string Customer, decimal Amount, DateTime CreatedAt);
//public record Product(int Id, string Name, decimal Price);

//public interface IOrderRepository
//{
//    Task<Order?> GetAsync(int id);
//    Task<IReadOnlyList<Order>> GetByCustomerAsync(string customer);
//    Task AddAsync(Order order);
//    Task UpdateAsync(Order order);
//    Task DeleteAsync(int id);
//    IQueryable<Order> Query();
//}

//public interface IProductRepository
//{
//    Task<Product?> GetAsync(int id);
//    Task<IReadOnlyList<Product>> SearchAsync(string term);
//    Task AddAsync(Product product);
//}

//public interface IUnitOfWork : IDisposable
//{
//    IOrderRepository Orders { get; }
//    IProductRepository Products { get; }
//    Task<int> SaveChangesAsync();
//    Task BeginTransactionAsync();
//    Task CommitAsync();
//    Task RollbackAsync();
//}

//public sealed class ApplicationDbContext : DbContext
//{
//    public DbSet<Order> Orders => Set<Order>();
//    public DbSet<Product> Products => Set<Product>();

//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//        : base(options) { }
//}

//public sealed class UnitOfWork : IUnitOfWork
//{
//    private readonly ApplicationDbContext _db;
//    private readonly IMemoryCache _cache;
//    private bool _disposed;

//    public IOrderRepository Orders { get; }
//    public IProductRepository Products { get; }

//    public UnitOfWork(ApplicationDbContext db, IMemoryCache cache)
//    {
//        _db = db;
//        _cache = cache;
//        Orders = new CachedOrderRepository(new EfOrderRepository(db), cache);
//        Products = new EfProductRepository(db);
//    }

//    public Task<int> SaveChangesAsync() => _db.SaveChangesAsync();
//    public Task BeginTransactionAsync() => _db.Database.BeginTransactionAsync();
//    public Task CommitAsync() => _db.Database.CurrentTransaction?.CommitAsync() ?? Task.CompletedTask;
//    public Task RollbackAsync() => _db.Database.CurrentTransaction?.RollbackAsync() ?? Task.CompletedTask;

//    public void Dispose()
//    {
//        if (!_disposed)
//        {
//            _db.Dispose();
//            _disposed = true;
//        }
//    }
//}

//internal sealed class EfOrderRepository : IOrderRepository
//{
//    private readonly ApplicationDbContext _db;
//    public EfOrderRepository(ApplicationDbContext db) => _db = db;

//    public async Task<Order?> GetAsync(int id)
//        => await _db.Orders.FindAsync(id);

//    public async Task<IReadOnlyList<Order>> GetByCustomerAsync(string customer)
//        => await _db.Orders.Where(o => o.Customer == customer).ToListAsync();

//    public Task AddAsync(Order order) { _db.Orders.Add(order); return Task.CompletedTask; }
//    public Task UpdateAsync(Order order) { _db.Orders.Update(order); return Task.CompletedTask; }
//    public Task DeleteAsync(int id) => _db.Orders.Where(o => o.Id == id).ExecuteDeleteAsync();
//    public IQueryable<Order> Query() => _db.Orders.AsNoTracking();
//}

//internal sealed class EfProductRepository : IProductRepository
//{
//    private readonly ApplicationDbContext _db;
//    public EfProductRepository(ApplicationDbContext db) => _db = db;
//    public Task<Product?> GetAsync(int id) => _db.Products.FindAsync(id).AsTask();
//    public async Task<IReadOnlyList<Product>> SearchAsync(string term)
//        => await _db.Products.Where(p => p.Name.Contains(term)).ToListAsync();
//    public Task AddAsync(Product product) { _db.Products.Add(product); return Task.CompletedTask; }
//}

//internal sealed class CachedOrderRepository : IOrderRepository
//{
//    private readonly IOrderRepository _inner;
//    private readonly IMemoryCache _cache;
//    private const string CachePrefix = "order_";

//    public CachedOrderRepository(IOrderRepository inner, IMemoryCache cache)
//        => (_inner, _cache) = (inner, cache);

//    public async Task<Order?> GetAsync(int id)
//    {
//        var key = CachePrefix + id;
//        if (!_cache.TryGetValue(key, out Order? order))
//        {
//            order = await _inner.GetAsync(id);
//            if (order != null)
//                _cache.Set(key, order, TimeSpan.FromMinutes(10));
//        }
//        return order;
//    }

//    public Task<IReadOnlyList<Order>> GetByCustomerAsync(string customer)
//        => _inner.GetByCustomerAsync(customer);

//    public Task AddAsync(Order order)
//    {
//        _cache.Remove(CachePrefix + order.Id);
//        return _inner.AddAsync(order);
//    }

//    public Task UpdateAsync(Order order)
//    {
//        _cache.Remove(CachePrefix + order.Id);
//        return _inner.UpdateAsync(order);
//    }

//    public Task DeleteAsync(int id)
//    {
//        _cache.Remove(CachePrefix + id);
//        return _inner.DeleteAsync(id);
//    }

//    public IQueryable<Order> Query() => _inner.Query();
//}

//public sealed class OrderService
//{
//    private readonly IUnitOfWork _uow;

//    public OrderService(IUnitOfWork uow) => _uow = uow;

//    public async Task ProcessOrderAsync(int orderId)
//    {
//        await _uow.BeginTransactionAsync();
//        try
//        {
//            var order = await _uow.Orders.GetAsync(orderId);
//            if (order == null) throw new KeyNotFoundException();

//            await _uow.Orders.UpdateAsync(order with { Amount = order.Amount * 1.1m });

//            await _uow.SaveChangesAsync();
//            await _uow.CommitAsync();
//        }
//        catch
//        {
//            await _uow.RollbackAsync();
//            throw;
//        }
//    }
//}

////3.1: Реализация потокобезопасного кэшаusing System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Runtime.CompilerServices;
//using System.Threading;

//public interface IEvictionPolicy<TKey, TValue>
//{
//    void OnGet(TKey key);
//    void OnSet(TKey key, TValue value);
//    void OnRemove(TKey key);
//    IEnumerable<TKey> GetEvictionCandidates(int count);
//    void Clear();
//}

//internal sealed class LruPolicy<TKey, TValue> : IEvictionPolicy<TKey, TValue>
//{
//    private readonly LinkedList<TKey> _order = new();
//    private readonly Dictionary<TKey, LinkedListNode<TKey>> _nodes = new();

//    public void OnGet(TKey key)
//    {
//        if (_nodes.TryGetValue(key, out var node))
//        {
//            _order.Remove(node);
//            _order.AddLast(node);
//        }
//    }

//    public void OnSet(TKey key, TValue value)
//    {
//        if (_nodes.TryGetValue(key, out var node))
//        {
//            _order.Remove(node);
//        }
//        _nodes[key] = _order.AddLast(key);
//    }

//    public void OnRemove(TKey key)
//    {
//        if (_nodes.TryGetValue(key, out var node))
//        {
//            _order.Remove(node);
//            _nodes.Remove(key);
//        }
//    }

//    public IEnumerable<TKey> GetEvictionCandidates(int count)
//    {
//        var c = Math.Min(count, _order.Count);
//        for (int i = 0; i < c; i++)
//        {
//            var node = _order.First ?? break;
//            yield return node.Value;
//            _order.RemoveFirst();
//            _nodes.Remove(node.Value);
//        }
//    }

//    public void Clear()
//    {
//        _order.Clear();
//        _nodes.Clear();
//    }
//}

//internal sealed class TtlLfuPolicy<TKey, TValue> : IEvictionPolicy<TKey, TValue>
//{
//    private sealed class Entry
//    {
//        public TValue Value;
//        public DateTime ExpiresAt;
//        public int Frequency;
//    }

//    private readonly Dictionary<TKey, Entry> _dict = new();
//    private readonly int _ttlMs;

//    public TtlLfuPolicy(int ttlSeconds) => _ttlMs = ttlSeconds * 1000;

//    public void OnGet(TKey key)
//    {
//        if (_dict.TryGetValue(key, out var e) && e.ExpiresAt > DateTime.UtcNow)
//            e.Frequency++;
//    }

//    public void OnSet(TKey key, TValue value)
//    {
//        _dict[key] = new Entry
//        {
//            Value = value,
//            ExpiresAt = DateTime.UtcNow.AddMilliseconds(_ttlMs),
//            Frequency = 1
//        };
//    }

//    public void OnRemove(TKey key) => _dict.Remove(key);

//    public IEnumerable<TKey> GetEvictionCandidates(int count)
//    {
//        var now = DateTime.UtcNow;
//        var expired = _dict.Where(kv => kv.Value.ExpiresAt <= now).Select(kv => kv.Key).ToList();
//        foreach (var k in expired) { _dict.Remove(k); yield return k; }

//        var candidates = _dict.OrderBy(kv => kv.Value.Frequency).ThenBy(kv => kv.Value.ExpiresAt)
//                             .Take(count).Select(kv => kv.Key);
//        foreach (var k in candidates) { _dict.Remove(k); yield return k; }
//    }

//    public void Clear() => _dict.Clear();
//}

//public sealed class ThreadSafeCache<TKey, TValue> where TKey : notnull
//{
//    private readonly ConcurrentDictionary<TKey, CacheEntry> _store = new();
//    private readonly IEvictionPolicy<TKey, TValue> _policy;
//    private readonly int _capacity;
//    private readonly Timer _cleanupTimer;

//    private sealed class CacheEntry
//    {
//        public TValue Value;
//        public long Version;
//    }

//    private long _version = 0;

//    public ThreadSafeCache(int capacity, IEvictionPolicy<TKey, TValue> policy, int cleanupIntervalSec = 10)
//    {
//        _capacity = capacity;
//        _policy = policy;
//        _cleanupTimer = new Timer(_ => EvictIfNeeded(), null, TimeSpan.FromSeconds(cleanupIntervalSec),
//                                 TimeSpan.FromSeconds(cleanupIntervalSec));
//    }

//    [MethodImpl(MethodImplOptions.AggressiveInlining)]
//    public bool TryGet(TKey key, out TValue value)
//    {
//        if (_store.TryGetValue(key, out var entry))
//        {
//            var currentVersion = Interlocked.Read(ref _version);
//            if (entry.Version == currentVersion)
//            {
//                value = entry.Value;
//                _policy.OnGet(key);
//                return true;
//            }
//        }
//        value = default!;
//        return false;
//    }

//    public void Set(TKey key, TValue value)
//    {
//        var newEntry = new CacheEntry { Value = value, Version = Interlocked.Read(ref _version) };
//        _store[key] = newEntry;
//        _policy.OnSet(key, value);
//        EvictIfNeeded();
//    }

//    public bool Remove(TKey key)
//    {
//        if (_store.TryRemove(key, out var entry))
//        {
//            _policy.OnRemove(key);
//            return true;
//        }
//        return false;
//    }

//    private void EvictIfNeeded()
//    {
//        if (_store.Count <= _capacity) return;

//        var toEvict = _capacity / 10 + 1;
//        var candidates = _policy.GetEvictionCandidates(toEvict);

//        foreach (var key in candidates)
//            _store.TryRemove(key, out _);

//        Interlocked.Increment(ref _version);
//    }

//    public void Clear()
//    {
//        _store.Clear();
//        _policy.Clear();
//        Interlocked.Increment(ref _version);
//    }

//    public int Count => _store.Count;
//}

//public sealed class TieredCache<TKey, TValue>
//{
//    private readonly ThreadSafeCache<TKey, TValue> _l1;
//    private readonly ThreadSafeCache<TKey, TValue> _l2;

//    public TieredCache(int l1Capacity = 1000, int l2Capacity = 100_000)
//    {
//        _l1 = new ThreadSafeCache<TKey, TValue>(l1Capacity, new LruPolicy<TKey, TValue>());
//        _l2 = new ThreadSafeCache<TKey, TValue>(l2Capacity, new TtlLfuPolicy<TKey, TValue>(300));
//    }

//    public bool TryGet(TKey key, out TValue value)
//    {
//        if (_l1.TryGet(key, out value))
//            return true;

//        if (_l2.TryGet(key, out value))
//        {
//            _l1.Set(key, value);
//            return true;
//        }

//        return false;
//    }

//    public void Set(TKey key, TValue value)
//    {
//        _l1.Set(key, value);
//        _l2.Set(key, value);
//    }

//    public int L1Count => _l1.Count;
//    public int L2Count => _l2.Count;
//}

////3.2: Пул рабочих потоков (Thread Pool) с очередью
//using System;
//using System.Collections.Concurrent;
//using System.Diagnostics;
//using System.Threading;

//public sealed class CustomThreadPool : IDisposable
//{
//    private readonly ConcurrentQueue<Action> _queue = new();
//    private readonly List<Worker> _workers = new();
//    private readonly ManualResetEventSlim _hasWork = new(false);
//    private readonly object _lock = new();
//    private volatile bool _shutdown;
//    private int _activeWorkers;
//    private int _minThreads;
//    private int _maxThreads;

//    public int ActiveTasks => _activeWorkers;
//    public int QueuedTasks => _queue.Count;
//    public int TotalWorkers => _workers.Count;
//    public long CompletedTasks { get; private set; }

//    public CustomThreadPool(int minThreads = 4, int maxThreads = 64)
//    {
//        _minThreads = Math.Max(1, minThreads);
//        _maxThreads = Math.Max(minThreads, maxThreads);

//        for (int i = 0; i < _minThreads; i++)
//            AddWorker();
//    }

//    public void QueueUserWorkItem(Action action)
//    {
//        if (_shutdown) throw new InvalidOperationException("Pool is shutting down");
//        if (action == null) throw new ArgumentNullException(nameof(action));

//        _queue.Enqueue(action);
//        _hasWork.Set();

//        TrySpawnWorker();
//    }

//    private void TrySpawnWorker()
//    {
//        lock (_lock)
//        {
//            if (_workers.Count < _maxThreads && _queue.Count > _workers.Count * 2)
//            {
//                AddWorker();
//            }
//        }
//    }

//    private void AddWorker()
//    {
//        var worker = new Worker(this);
//        lock (_lock) _workers.Add(worker);
//        worker.Thread.Start();
//    }

//    private void WorkerLoop()
//    {
//        while (true)
//        {
//            _hasWork.Wait();

//            if (_shutdown && _queue.IsEmpty)
//                break;

//            if (_queue.TryDequeue(out var action))
//            {
//                Interlocked.Increment(ref _activeWorkers);
//                try
//                {
//                    action();
//                    Interlocked.Increment(ref CompletedTasks);
//                }
//                catch (Exception ex)
//                {
//                    ThreadPool.UnhandledException?.Invoke(this, new UnhandledExceptionEventArgs(ex, false));
//                }
//                finally
//                {
//                    Interlocked.Decrement(ref _activeWorkers);
//                }
//            }
//            else
//            {
//                _hasWork.Reset();
//            }

//            if (_workers.Count > _minThreads && _queue.IsEmpty && _activeWorkers == 0)
//            {
//                lock (_lock)
//                {
//                    if (_workers.Count > _minThreads && _queue.IsEmpty)
//                    {
//                        if (TryRemoveCurrentWorker())
//                            break;
//                    }
//                }
//            }
//        }
//    }

//    private bool TryRemoveCurrentWorker()
//    {
//        var current = Thread.CurrentThread;
//        lock (_lock)
//        {
//            var worker = _workers.Find(w => w.Thread == current);
//            if (worker != null)
//            {
//                _workers.Remove(worker);
//                return true;
//            }
//        }
//        return false;
//    }

//    public void Shutdown(bool waitForWorkers = true)
//    {
//        _shutdown = true;
//        _hasWork.Set();

//        if (waitForWorkers)
//        {
//            foreach (var w in _workers)
//                w.Thread.Join();
//        }
//    }

//    public void Dispose()
//    {
//        Shutdown(true);
//        _hasWork.Dispose();
//    }

//    private sealed class Worker
//    {
//        public Thread Thread { get; }
//        private readonly CustomThreadPool _pool;

//        public Worker(CustomThreadPool pool)
//        {
//            _pool = pool;
//            Thread = new Thread(_pool.WorkerLoop)
//            {
//                IsBackground = true,
//                Name = $"CustomPool-Worker-{Interlocked.Increment(ref _id)}"
//            };
//        }
//        private static int _id;
//    }

//    public static event UnhandledExceptionEventHandler? UnhandledException;
//}

//class Program
//{
//    static void Main()
//    {
//        using var pool = new CustomThreadPool(minThreads: 4, maxThreads: 32);

//        var sw = Stopwatch.StartNew();
//        const int tasks = 100_000;

//        for (int i = 0; i < tasks; i++)
//        {
//            int id = i;
//            pool.QueueUserWorkItem(() =>
//            {
//                Thread.SpinWait(1000);
//                if (id % 10000 == 0)
//                    Console.WriteLine($"Task {id} done on thread {Thread.CurrentThread.ManagedThreadId}");
//            });
//        }

//        while (pool.CompletedTasks < tasks)
//        {
//            Console.WriteLine($"Active: {pool.ActiveTasks}, Queue: {pool.QueuedTasks}, Workers: {pool.TotalWorkers}");
//            Thread.Sleep(500);
//        }

//        sw.Stop();
//        Console.WriteLine($"All {tasks} tasks completed in {sw.ElapsedMilliseconds} ms");
//        Console.WriteLine($"Peak workers: {pool.TotalWorkers}");
//    }
//}

////3.3: Асинхронная обработка данных из потока
//using System;
//using System.Buffers;
//using System.IO;
//using System.IO.Pipelines;
//using System.Threading;
//using System.Threading.Tasks;

//public sealed class AsyncStreamProcessor : IDisposable
//{
//    private readonly Stream _stream;
//    private readonly Func<ReadOnlyMemory<byte>, ValueTask> _processBatch;
//    private readonly Pipe _pipe = new();
//    private readonly CancellationTokenSource _cts = new();
//    private readonly Task _readTask;
//    private readonly Task _processTask;

//    public AsyncStreamProcessor(
//        Stream stream,
//        Func<ReadOnlyMemory<byte>, ValueTask> processBatch,
//        int bufferSize = 65536)
//    {
//        _stream = stream;
//        _processBatch = processBatch;
//        _readTask = Task.Run(ReadFromStreamAsync);
//        _processTask = Task.Run(ProcessPipeAsync);
//    }

//    private async Task ReadFromStreamAsync()
//    {
//        try
//        {
//            while (!_cts.Token.IsCancellationRequested)
//            {
//                var memory = _pipe.Writer.GetMemory(65536);
//                int bytesRead = await _stream.ReadAsync(memory, _cts.Token);
//                if (bytesRead == 0) break;
//                _pipe.Writer.Advance(bytesRead);
//                var result = await _pipe.Writer.FlushAsync(_cts.Token);
//                if (result.IsCompleted) break;
//            }
//            _pipe.Writer.Complete();
//        }
//        catch (Exception ex)
//        {
//            _pipe.Writer.Complete(ex);
//        }
//    }

//    private async Task ProcessPipeAsync()
//    {
//        try
//        {
//            while (true)
//            {
//                var result = await _pipe.Reader.ReadAsync(_cts.Token);
//                var buffer = result.Buffer;
//                if (buffer.IsEmpty && result.IsCompleted) break;

//                foreach (var segment in buffer)
//                {
//                    if (segment.Length > 0)
//                        await _processBatch(segment);
//                }

//                _pipe.Reader.AdvanceTo(buffer.End);
//                if (result.IsCompleted) break;
//            }
//            _pipe.Reader.Complete();
//        }
//        catch (Exception ex)
//        {
//            _pipe.Reader.Complete(ex);
//        }
//    }

//    public Task Completion => Task.WhenAll(_readTask, _processTask);

//    public void Dispose()
//    {
//        _cts.Cancel();
//        _cts.Dispose();
//        _pipe.Writer.Complete();
//        _pipe.Reader.Complete();
//    }
//}

////3.4: Producer - Consumer паттерн
//using System;
//using System.Collections.Concurrent;
//using System.Threading;
//using System.Threading.Tasks;

//public sealed class ProducerConsumer<T> : IDisposable
//{
//    private readonly BlockingCollection<T> _queue;
//    private readonly Task[] _consumers;
//    private readonly SemaphoreSlim _throttle;
//    private readonly CancellationTokenSource _cts = new();

//    public ProducerConsumer(
//        int maxQueueSize = 10000,
//        int consumerCount = 8,
//        int maxConcurrency = 4)
//    {
//        _queue = new BlockingCollection<T>(maxQueueSize);
//        _throttle = new SemaphoreSlim(maxConcurrency);
//        _consumers = new Task[consumerCount];

//        for (int i = 0; i < consumerCount; i++)
//        {
//            _consumers[i] = Task.Run(() => ConsumerLoop());
//        }
//    }

//    public bool TryAdd(T item, int millisecondsTimeout = 100)
//        => _queue.TryAdd(item, millisecondsTimeout, _cts.Token);

//    public void Add(T item) => _queue.Add(item, _cts.Token);

//    public void CompleteAdding() => _queue.CompleteAdding();

//    private async Task ConsumerLoop()
//    {
//        try
//        {
//            while (!_queue.IsCompleted)
//            {
//                if (_queue.TryTake(out var item, 100, _cts.Token))
//                {
//                    await _throttle.WaitAsync(_cts.Token);
//                    try
//                    {
//                        await ProcessItemAsync(item);
//                    }
//                    finally
//                    {
//                        _throttle.Release();
//                    }
//                }
//            }
//        }
//        catch (OperationCanceledException) { }
//    }

//    protected virtual Task ProcessItemAsync(T item)
//        => Task.CompletedTask;

//    public Task Completion => Task.WhenAll(_consumers);

//    public void Dispose()
//    {
//        _cts.Cancel();
//        CompleteAdding();
//        _throttle.Dispose();
//        _cts.Dispose();
//    }
//}

////3.5: Барьер синхронизации(Barrier) для координации потоков
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//public sealed class ReusableBarrier : IDisposable
//{
//    private readonly int _participantCount;
//    private int _remaining;
//    private int _generation;
//    private readonly ManualResetEventSlim _event = new();
//    private Action? _postPhaseAction;
//    private Exception? _exception;

//    public ReusableBarrier(int participantCount, Action? postPhaseAction = null)
//    {
//        if (participantCount <= 0) throw new ArgumentOutOfRangeException();
//        _participantCount = participantCount;
//        _remaining = participantCount;
//        _postPhaseAction = postPhaseAction;
//    }

//    public void SignalAndWait(CancellationToken token = default)
//    {
//        int gen = _generation;
//        int rem = Interlocked.Decrement(ref _remaining);
//        if (rem == 0)
//        {
//            _exception = null;
//            try { _postPhaseAction?.Invoke(); }
//            catch (Exception ex) { _exception = ex; }
//            Interlocked.Increment(ref _generation);
//            _remaining = _participantCount;
//            _event.Set();
//        }
//        else
//        {
//            while (gen == _generation && !token.IsCancellationRequested)
//                _event.Wait(50);
//            if (token.IsCancellationRequested) throw new OperationCanceledException();
//            if (_exception != null) throw new AggregateException(_exception);
//        }
//    }

//    public void Dispose() => _event.Dispose();
//}

////3.6: Семафор с справедливостью (Fair Semaphore)
//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;

//public sealed class FairSemaphore : IDisposable
//{
//    private readonly Queue<TaskCompletionSource<bool>> _waiters = new();
//    private int _currentCount;
//    private readonly object _lock = new();
//    private bool _disposed;

//    public FairSemaphore(int initialCount) => _currentCount = initialCount;

//    public Task WaitAsync(CancellationToken token = default)
//    {
//        lock (_lock)
//        {
//            if (_disposed) throw new ObjectDisposedException(nameof(FairSemaphore));
//            if (_currentCount > 0)
//            {
//                _currentCount--;
//                return Task.CompletedTask;
//            }

//            var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
//            token.Register(() => tcs.TrySetCanceled(), false);
//            _waiters.Enqueue(tcs);
//            return tcs.Task;
//        }
//    }

//    public async Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken token = default)
//    {
//        var waitTask = WaitAsync(token);
//        using var cts = new CancellationTokenSource(millisecondsTimeout);
//        var completed = await Task.WhenAny(waitTask, Task.Delay(-1, cts.Token)).ConfigureAwait(false);
//        return completed == waitTask;
//    }

//    public void Release()
//    {
//        TaskCompletionSource<bool>? tcs = null;
//        lock (_lock)
//        {
//            if (_disposed) return;
//            if (_waiters.Count > 0)
//                tcs = _waiters.Dequeue();
//            else
//                _currentCount++;
//        }
//        tcs?.TrySetResult(true);
//    }

//    public int CurrentCount
//    {
//        get { lock (_lock) return _currentCount; }
//    }

//    public void Dispose()
//    {
//        lock (_lock)
//        {
//            if (_disposed) return;
//            _disposed = true;
//            while (_waiters.Count > 0)
//                _waiters.Dequeue().TrySetCanceled();
//        }
//    }
//}

////3.7: ReadWriteLock для оптимизации чтения
//using System;
//using System.Threading;

//public sealed class ReadWriteLock : IDisposable
//{
//    private int _readers = 0;
//    private int _writersWaiting = 0;
//    private int _activeWriter = 0;
//    private readonly object _lock = new();
//    private readonly SemaphoreSlim _writerGate = new(1, 1);

//    public void EnterReadLock()
//    {
//        while (true)
//        {
//            lock (_lock)
//            {
//                if (_activeWriter == 0 && _writersWaiting == 0)
//                {
//                    _readers++;
//                    return;
//                }
//            }
//            Thread.Yield();
//        }
//    }

//    public void ExitReadLock()
//    {
//        lock (_lock)
//        {
//            if (--_readers == 0)
//                Monitor.PulseAll(_lock);
//        }
//    }

//    public void EnterWriteLock()
//    {
//        lock (_lock) _writersWaiting++;
//        try
//        {
//            while (_readers > 0 || _activeWriter > 0)
//                Monitor.Wait(_lock);
//            _activeWriter = 1;
//        }
//        finally
//        {
//            lock (_lock) _writersWaiting--;
//        }
//    }

//    public void ExitWriteLock()
//    {
//        lock (_lock)
//        {
//            _activeWriter = 0;
//            Monitor.PulseAll(_lock);
//        }
//    }

//    public void Dispose()
//    {
//        _writerGate.Dispose();
//    }
//}

////3.8: Асинхронные цепочки операций
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//public sealed class AsyncPipeline<T>
//{
//    private readonly Func<T, CancellationToken, Task<T>> _step;
//    private readonly TimeSpan _timeout;
//    private readonly Action<Exception>? _onError;

//    private AsyncPipeline(Func<T, CancellationToken, Task<T>> step, TimeSpan? timeout = null, Action<Exception>? onError = null)
//    {
//        _step = step;
//        _timeout = timeout ?? Timeout.InfiniteTimeSpan;
//        _onError = onError;
//    }

//    public static AsyncPipeline<T> Step(Func<T, CancellationToken, Task<T>> action, TimeSpan? timeout = null)
//        => new(action, timeout ?? Timeout.InfiniteTimeSpan);

//    public AsyncPipeline<T> Then(Func<T, CancellationToken, Task<T>> next, TimeSpan? timeout = null)
//        => new(async (input, ct) =>
//        {
//            var result = await _step(input, ct).ConfigureAwait(false);
//            using var cts = CancellationTokenSource.CreateLinkedTokenSource(ct);
//            if (_timeout != Timeout.InfiniteTimeSpan) cts.CancelAfter(_timeout);
//            if (timeout.HasValue) cts.CancelAfter(timeout.Value);
//            return await next(result, cts.Token).ConfigureAwait(false);
//        }, timeout ?? _timeout, _onError);

//    public AsyncPipeline<T> Catch(Action<Exception> handler)
//        => new(_step, _timeout, handler);

//    public async Task<T> ExecuteAsync(T input, CancellationToken externalToken = default)
//    {
//        using var cts = CancellationTokenSource.CreateLinkedTokenSource(externalToken);
//        if (_timeout != Timeout.InfiniteTimeSpan) cts.CancelAfter(_timeout);

//        try
//        {
//            return await _step(input, cts.Token).ConfigureAwait(false);
//        }
//        catch (Exception ex) when (_onError != null)
//        {
//            _onError(ex);
//            throw;
//        }
//    }
//}

////3.9: Параллельная обработка коллекций с PLINQ
//using System;
//using System.Collections.Concurrent;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//public static class ParallelProcessor
//{
//    public static async Task<long> ProcessLargeCollectionAsync<T>(
//        IEnumerable<T> source,
//        Func<T, CancellationToken, Task<long>> processor,
//        CancellationToken token = default)
//    {
//        var sw = Stopwatch.StartNew();
//        var items = source as T[] ?? source.ToArray();
//        int chunkSize = Math.Max(1000, items.Length / (Environment.ProcessorCount * 4));

//        var result = await Task.WhenAll(
//            Partitioner.Create(items, true)
//                .AsParallel()
//                .WithDegreeOfParallelism(Environment.ProcessorCount)
//                .WithCancellation(token)
//                .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
//                .Select(async item =>
//                {
//                    try { return await processor(item, token).ConfigureAwait(false); }
//                    catch { return 0L; }
//                })
//                .Unwrap()
//        );

//        sw.Stop();
//        Console.WriteLine($"Processed {items.Length:N0} items in {sw.ElapsedMilliseconds} ms (parallel)");
//        return result.Sum();
//    }

//    public static async Task<long> ProcessSequentialAsync<T>(
//        IEnumerable<T> source,
//        Func<T, CancellationToken, Task<long>> processor,
//        CancellationToken token = default)
//    {
//        var sw = Stopwatch.StartNew();
//        long total = 0;
//        foreach (var item in source)
//        {
//            token.ThrowIfCancellationRequested();
//            total += await processor(item, token);
//        }
//        sw.Stop();
//        Console.WriteLine($"Processed {source.Count():N0} items in {sw.ElapsedMilliseconds} ms (sequential)");
//        return total;
//    }
//}

////3.10: Реактивное программирование с Rx
//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;

//public interface IObservable<T>
//{
//    IDisposable Subscribe(IObserver<T> observer);
//}

//public interface IObserver<T>
//{
//    void OnNext(T value);
//    void OnError(Exception error);
//    void OnCompleted();
//}

//public sealed class Subject<T> : IObservable<T>, IObserver<T>
//{
//    private readonly object _lock = new();
//    private readonly List<IObserver<T>> _observers = new();
//    private bool _completed;
//    private Exception? _error;

//    public IDisposable Subscribe(IObserver<T> observer)
//    {
//        lock (_lock)
//        {
//            if (_completed) observer.OnCompleted();
//            else if (_error != null) observer.OnError(_error);
//            else _observers.Add(observer);
//        }
//        return new Subscription(this, observer);
//    }

//    public void OnNext(T value)
//    {
//        lock (_lock)
//        {
//            if (_completed || _error != null) return;
//            foreach (var obs in _observers.ToArray())
//                obs.OnNext(value);
//        }
//    }

//    public void OnError(Exception error)
//    {
//        lock (_lock)
//        {
//            if (_completed || _error != null) return;
//            _error = error;
//            foreach (var obs in _observers.ToArray())
//                obs.OnError(error);
//            _observers.Clear();
//        }
//    }

//    public void OnCompleted()
//    {
//        lock (_lock)
//        {
//            if (_completed) return;
//            _completed = true;
//            foreach (var obs in _observers.ToArray())
//                obs.OnCompleted();
//            _observers.Clear();
//        }
//    }

//    private sealed class Subscription : IDisposable
//    {
//        private Subject<T> _parent;
//        private IObserver<T> _observer;

//        public Subscription(Subject<T> parent, IObserver<T> observer)
//            => (_parent, _observer) = (parent, observer);

//        public void Dispose()
//        {
//            lock (_parent._lock)
//                _parent._observers.Remove(_observer);
//        }
//    }
//}

//public static class ObservableExtensions
//{
//    public static IObservable<TResult> Select<TSource, TResult>(
//        this IObservable<TSource> source,
//        Func<TSource, TResult> selector)
//    {
//        return new TransformObservable<TSource, TResult>(source, selector);
//    }

//    public static IObservable<T> Where<T>(
//        this IObservable<T> source,
//        Func<T, bool> predicate)
//    {
//        return new FilterObservable<T>(source, predicate);
//    }

//    public static IObservable<T> Throttle<T>(
//        this IObservable<T> source,
//        TimeSpan dueTime)
//    {
//        return new ThrottleObservable<T>(source, dueTime);
//    }

//    public static IDisposable Subscribe<T>(
//        this IObservable<T> source,
//        Action<T> onNext,
//        Action<Exception>? onError = null,
//        Action? onCompleted = null)
//    {
//        var observer = new LambdaObserver<T>(onNext, onError, onCompleted);
//        return source.Subscribe(observer);
//    }
//}

//file class TransformObservable<TSource, TResult> : IObservable<TResult>
//{
//    private readonly IObservable<TSource> _source;
//    private readonly Func<TSource, TResult> _selector;

//    public TransformObservable(IObservable<TSource> source, Func<TSource, TResult> selector)
//        => (_source, _selector) = (source, selector);

//    public IDisposable Subscribe(IObserver<TResult> observer)
//        => _source.Subscribe(new TransformObserver(observer, _selector));

//    private sealed class TransformObserver : IObserver<TSource>
//    {
//        private readonly IObserver<TResult> _observer;
//        private readonly Func<TSource, TResult> _selector;
//        public TransformObserver(IObserver<TResult> observer, Func<TSource, TResult> selector)
//            => (_observer, _selector) = (observer, selector);
//        public void OnNext(TSource value) => _observer.OnNext(_selector(value));
//        public void OnError(Exception error) => _observer.OnError(error);
//        public void OnCompleted() => _observer.OnCompleted();
//    }
//}

//file class FilterObservable<T> : IObservable<T>
//{
//    private readonly IObservable<T> _source;
//    private readonly Func<T, bool> _predicate;
//    public FilterObservable(IObservable<T> source, Func<T, bool> predicate)
//        => (_source, _predicate) = (source, predicate);
//    public IDisposable Subscribe(IObserver<T> observer)
//        => _source.Subscribe(new FilterObserver(observer, _predicate));

//    private sealed class FilterObserver : IObserver<T>
//    {
//        private readonly IObserver<T> _observer;
//        private readonly Func<T, bool> _predicate;
//        public FilterObserver(IObserver<T> observer, Func<T, bool> predicate)
//            => (_observer, _predicate) = (observer, predicate);
//        public void OnNext(T value) { if (_predicate(value)) _observer.OnNext(value); }
//        public void OnError(Exception error) => _observer.OnError(error);
//        public void OnCompleted() => _observer.OnCompleted();
//    }
//}

//file class LambdaObserver<T> : IObserver<T>
//{
//    private readonly Action<T> _onNext;
//    private readonly Action<Exception>? _onError;
//    private readonly Action? _onCompleted;

//    public LambdaObserver(Action<T> onNext, Action<Exception>? onError, Action? onCompleted)
//        => (_onNext, _onError, _onCompleted) = (onNext, onError, onCompleted);

//    public void OnNext(T value) => _onNext(value);
//    public void OnError(Exception error) => _onError?.Invoke(error);
//    public void OnCompleted() => _onCompleted?.Invoke();
//}

////3.11: Распределенная обработка(Map-Reduce)
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//public static class MapReduce
//{
//    public static async Task<IDictionary<TKey, TResult>> ExecuteAsync<TInput, TKey, TValue, TResult>(
//        IEnumerable<TInput> source,
//        Func<TInput, IEnumerable<KeyValuePair<TKey, TValue>>> mapper,
//        Func<TKey, IEnumerable<TValue>, TResult> reducer,
//        int partitionCount = 0,
//        string tempPath = "mr-temp")
//    {
//        if (!Directory.Exists(tempPath)) Directory.CreateDirectory(tempPath);
//        partitionCount = partitionCount > 0 ? partitionCount : Environment.ProcessorCount * 4;

//        var partitions = new List<string>[partitionCount];
//        for (int i = 0; i < partitions.Length; i++) partitions[i] = new();

//        await foreach (var kv in source
//            .AsParallel()
//            .WithDegreeOfParallelism(Environment.ProcessorCount)
//            .SelectMany(item => mapper(item)
//                .Select(kv => new { Partition = Math.Abs(kv.Key.GetHashCode() % partitionCount), kv })))
//        {
//            int p = kv.Partition;
//            string file = Path.Combine(tempPath, $"part-{p:D5}-{Guid.NewGuid():N}.tmp");
//            partitions[p].Add(file);
//            await File.AppendAllLinesAsync(file, new[] { $"{kv.kv.Key}\t{kv.kv.Value}" });
//        }

//        var results = new ConcurrentDictionary<TKey, TResult>();
//        await Task.WhenAll(
//            partitions.Select((files, partitionId) => Task.Run(() =>
//            {
//                var groups = new Dictionary<TKey, List<TValue>>();
//                foreach (var file in files)
//                {
//                    foreach (var line in File.ReadLines(file))
//                    {
//                        var parts = line.Split('\t');
//                        var key = (TKey)Convert.ChangeType(parts[0], typeof(TKey));
//                        var value = (TValue)Convert.ChangeType(parts[1], typeof(TValue));
//                        if (!groups.TryGetValue(key, out var list))
//                            groups[key] = list = new();
//                        list.Add(value);
//                    }
//                    File.Delete(file);
//                }

//                foreach (var g in groups)
//                    results[g.Key] = reducer(g.Key, g.Value);
//            }))
//        );

//        Directory.Delete(tempPath, true);
//        return results;
//    }
//}

////3.12: Таймер с произвольной точностью
//using System;
//using System.Collections.Concurrent;
//using System.Diagnostics;
//using System.Threading;
//using System.Threading.Tasks;

//public sealed class PrecisionTimer : IDisposable
//{
//    private readonly Action _callback;
//    private readonly long _intervalTicks;
//    private readonly Thread _thread;
//    private readonly Stopwatch _sw = Stopwatch.StartNew();
//    private volatile bool _running = true;
//    private long _nextTick;
//    private readonly ConcurrentQueue<long> _driftHistory = new();

//    public PrecisionTimer(TimeSpan interval, Action callback)
//    {
//        _callback = callback;
//        _intervalTicks = interval.Ticks;
//        _nextTick = _sw.ElapsedTicks + _intervalTicks;
//        _thread = new Thread(TimerLoop) { IsBackground = true, Priority = ThreadPriority.Highest };
//        _thread.Start();
//    }

//    private void TimerLoop()
//    {
//        long driftSum = 0;
//        int count = 0;

//        while (_running)
//        {
//            long now = _sw.ElapsedTicks;
//            long sleepUntil = _nextTick - now;

//            if (sleepUntil > 0)
//            {
//                if (sleepUntil > TimeSpan.TicksPerMillisecond * 2)
//                    Thread.Sleep(1);
//                while (_sw.ElapsedTicks < _nextTick) Thread.Yield();
//            }

//            long actual = _sw.ElapsedTicks;
//            long drift = actual - _nextTick;
//            _driftHistory.Enqueue(drift);
//            if (_driftHistory.Count > 100) _driftHistory.TryDequeue(out _);

//            driftSum += drift;
//            count++;

//            if (count % 50 == 0 && count > 0)
//            {
//                long avgDrift = driftSum / count;
//                if (Math.Abs(avgDrift) > TimeSpan.TicksPerMillisecond)
//                    _nextTick -= avgDrift / 2;
//                driftSum = 0; count = 0;
//            }

//            _nextTick += _intervalTicks;
//            try { _callback(); }
//            catch { }
//        }
//    }

//    public double AverageJitterMs => _driftHistory.IsEmpty ? 0 :
//        _driftHistory.Average(d => Math.Abs(d) * 1000.0 / Stopwatch.Frequency);

//    public void Dispose()
//    {
//        _running = false;
//        _thread.Join(100);
//    }
//}

////3.13: Система с timeout и deadline
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//public readonly struct Deadline : IEquatable<Deadline>
//{
//    private readonly DateTime _utc;
//    public static Deadline None => new(DateTime.MaxValue);
//    public bool IsExpired => DateTime.UtcNow >= _utc;
//    public TimeSpan Remaining => _utc == DateTime.MaxValue ? Timeout.InfiniteTimeSpan : _utc - DateTime.UtcNow;

//    public Deadline(TimeSpan timeout) : this(DateTime.UtcNow + timeout) { }
//    private Deadline(DateTime utc) => _utc = utc;

//    public CancellationToken CreateCancellationToken()
//    {
//        if (_utc == DateTime.MaxValue) return CancellationToken.None;
//        var cts = new CancellationTokenSource();
//        if (_utc < DateTime.UtcNow)
//            cts.Cancel();
//        else
//            cts.CancelAfter(_utc - DateTime.UtcNow);
//        return cts.Token;
//    }

//    public static Deadline FromNow(TimeSpan timeout) => new(timeout);
//    public static Deadline Min(Deadline a, Deadline b) => new(a._utc < b._utc ? a._utc : b._utc);

//    public bool Equals(Deadline other) => _utc == other._utc;
//    public override bool Equals(object? obj) => obj is Deadline d && Equals(d);
//    public override int GetHashCode() => _utc.GetHashCode();
//    public static bool operator ==(Deadline a, Deadline b) => a.Equals(b);
//    public static bool operator !=(Deadline a, Deadline b) => !a.Equals(b);
//}

//public static class TaskExtensions
//{
//    public static async Task<T> WithDeadline<T>(this Task<T> task, Deadline deadline)
//    {
//        if (task.IsCompleted) return await task;
//        if (deadline.IsExpired) throw new TimeoutException();

//        using var cts = CancellationTokenSource.CreateLinkedTokenSource(deadline.CreateCancellationToken());
//        var completed = await Task.WhenAny(task, Task.Delay(Timeout.Infinite, cts.Token));
//        cts.Token.ThrowIfCancellationRequested();
//        return await task;
//    }

//    public static async Task WithDeadline(this Task task, Deadline deadline)
//        => await WithDeadline(Task.Run(() => { task.Wait(); }, deadline.CreateCancellationToken()), deadline);
//}

