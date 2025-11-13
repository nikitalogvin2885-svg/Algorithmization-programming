using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Timers;

////1
//using System;
//using System.Diagnostics;

//namespace SimpleDelegateDemo
//{
//    class Program
//    {
//        public delegate int MathOperation(int a, int b);

//        static int Add(int a, int b)
//        {
//            return a + b;
//        }

//        static int Multiply(int a, int b)
//        {
//            return a * b;
//        }

//        static void Main()
//        {
//            MathOperation addDelegate = Add;
//            MathOperation multiplyDelegate = Multiply;

//            Console.WriteLine($"10 + 5 = {addDelegate(10, 5)}");
//            Console.WriteLine($"10 * 5 = {multiplyDelegate(10, 5)}");

//            MathOperation subtract = (a, b) => a - b;
//            MathOperation divide = (a, b) => b != 0 ? a / b : 0;

//            Console.WriteLine($"15 - 8 = {subtract(15, 8)}");
//            Console.WriteLine($"20 / 4 = {divide(20, 4)}");

//            MathOperation multiOperation = Add;
//            multiOperation += Multiply;

//            int result = multiOperation(10, 2);
//            Console.WriteLine($"Последний результат: {result}");
//        }
//    }
//}

////2
//using System;

//namespace ArithmeticDelegateDemo
//{
//    class Program
//    {
//        public delegate int ArithmeticOperation(int x, int y);

//        static int Calculate(ArithmeticOperation operation, int a, int b)
//        {
//            return operation(a, b);
//        }

//        static void Main()
//        {
//            ArithmeticOperation addition = (x, y) => x + y;
//            ArithmeticOperation subtraction = (x, y) => x - y;
//            ArithmeticOperation multiplication = (x, y) => x * y;

//            int num1 = 20, num2 = 5;
//            Console.WriteLine($"{num1} + {num2} = {Calculate(addition, num1, num2)}");
//            Console.WriteLine($"{num1} - {num2} = {Calculate(subtraction, num1, num2)}");
//            Console.WriteLine($"{num1} * {num2} = {Calculate(multiplication, num1, num2)}");

//            ArithmeticOperation power = (x, y) => (int)Math.Pow(x, y);
//            ArithmeticOperation modulus = (x, y) => x % y;

//            Console.WriteLine($"2 ^ 8 = {Calculate(power, 2, 8)}");
//            Console.WriteLine($"17 % 5 = {Calculate(modulus, 17, 5)}");
//        }
//    }
//}

////3
//using System;

//namespace MessageDelegateDemo
//{
//    class Program
//    {
//        public delegate void MessageDelegate(string message);

//        static void PrintUpperCase(string message)
//        {
//            Console.WriteLine(message.ToUpper());
//        }

//        static void PrintWithStars(string message)
//        {
//            Console.WriteLine($"*** {message} ***");
//        }

//        static void Main()
//        {
//            MessageDelegate upperPrinter = PrintUpperCase;
//            MessageDelegate starPrinter = PrintWithStars;

//            upperPrinter("это сообщение в верхнем регистре");
//            starPrinter("важное сообщение");

//            MessageDelegate reversePrinter = msg =>
//            {
//                char[] arr = msg.ToCharArray();
//                Array.Reverse(arr);
//                Console.WriteLine(new string(arr));
//            };

//            reversePrinter("делегаты в C#");

//            MessageDelegate multiDelegate = PrintUpperCase;
//            multiDelegate += PrintWithStars;
//            multiDelegate += reversePrinter;

//            multiDelegate("многоадресный делегат");
//        }
//    }
//}

////4
//using System;
//using System.Collections.Generic;

//namespace PredicateDelegateDemo
//{
//    class Program
//    {
//        public delegate bool PredicateDelegate<T>(T item);

//        static void Main()
//        {
//            PredicateDelegate<int> isEven = x => x % 2 == 0;
//            PredicateDelegate<int> isPositive = x => x > 0;
//            PredicateDelegate<string> isLong = s => s.Length > 5;

//            Console.WriteLine($"10 четное: {isEven(10)}");
//            Console.WriteLine($"-5 положительное: {isPositive(-5)}");
//            Console.WriteLine($"'hello' длинное: {isLong("hello")}");

//            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            PredicateDelegate<int> isPrime = n =>
//            {
//                if (n < 2) return false;
//                for (int i = 2; i <= Math.Sqrt(n); i++)
//                    if (n % i == 0) return false;
//                return true;
//            };

//            List<int> primes = numbers.FindAll(n => isPrime(n));
//            Console.WriteLine($"Простые числа: {string.Join(", ", primes)}");

//            PredicateDelegate<string> containsA = s => s.Contains("a");
//            List<string> words = new List<string> { "apple", "banana", "cherry", "date" };
//            List<string> wordsWithA = words.FindAll(w => containsA(w));
//            Console.WriteLine($"Слова с 'a': {string.Join(", ", wordsWithA)}");
//        }
//    }
//}

////5
//using System;
//using System.Collections.Generic;

//namespace ActionDelegateDemo
//{
//    class Program
//    {
//        public delegate void MessagePrinter(string message);
//        public delegate void NumberProcessor(int number);

//        static void PrintMessage(string msg)
//        {
//            Console.WriteLine($"[INFO] {msg}");
//        }

//        static void LogMessage(string msg)
//        {
//            Console.WriteLine($"[LOG] {DateTime.Now}: {msg}");
//        }

//        static void ProcessNumber(int num)
//        {
//            Console.WriteLine($"Число: {num}, Квадрат: {num * num}, Куб: {num * num * num}");
//        }

//        static void Main()
//        {
//            Action<string> printAction = Console.WriteLine;
//            printAction("Hello от Action делегата");

//            Action<string, int> displayInfo = (name, age) =>
//            {
//                Console.WriteLine($"Имя: {name}, Возраст: {age}");
//            };
//            displayInfo("Иван", 25);

//            MessagePrinter printer = PrintMessage;
//            printer("Задача выполнена успешно");

//            Action<string> multiAction = PrintMessage;
//            multiAction += LogMessage;
//            multiAction("Работа с файлами");

//            NumberProcessor processor = ProcessNumber;
//            processor(5);

//            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
//            names.ForEach(name => Console.WriteLine($"  - {name}"));

//            Action<int> conditionalAction = (num) =>
//            {
//                if (num % 2 == 0)
//                    Console.WriteLine($"{num} - четное число");
//                else
//                    Console.WriteLine($"{num} - нечетное число");
//            };
//            conditionalAction(7);

//            Action<string> notificationSystem = null;
//            notificationSystem += msg => Console.WriteLine($"[EMAIL] Отправка письма: {msg}");
//            notificationSystem += msg => Console.WriteLine($"[SMS] Отправка SMS: {msg}");

//            notificationSystem("Важное сообщение");
//        }
//    }
//}

////6
//using System;

//namespace FuncDelegateDemo
//{
//    class Program
//    {
//        public delegate TResult ConverterDelegate<T, TResult>(T input);

//        static void Main()
//        {
//            ConverterDelegate<string, int> stringToInt = s => int.Parse(s);
//            ConverterDelegate<int, string> intToBinary = n => Convert.ToString(n, 2);
//            ConverterDelegate<double, double> celsiusToFahrenheit = c => c * 9 / 5 + 32;

//            Console.WriteLine(stringToInt("123"));
//            Console.WriteLine(intToBinary(42));
//            Console.WriteLine(celsiusToFahrenheit(25));

//            Func<string, string> reverseString = s =>
//            {
//                char[] chars = s.ToCharArray();
//                Array.Reverse(chars);
//                return new string(chars);
//            };

//            Console.WriteLine(reverseString("hello"));
//        }
//    }
//}

////7
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace FilterDelegateDemo
//{
//    class Program
//    {
//        public delegate bool FilterDelegate(int number);

//        static List<int> FilterNumbers(List<int> numbers, FilterDelegate filter)
//        {
//            return numbers.Where(n => filter(n)).ToList();
//        }

//        static void Main()
//        {
//            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            FilterDelegate isEven = n => n % 2 == 0;
//            FilterDelegate isOdd = n => n % 2 != 0;
//            FilterDelegate isPrime = n =>
//            {
//                if (n < 2) return false;
//                for (int i = 2; i <= Math.Sqrt(n); i++)
//                    if (n % i == 0) return false;
//                return true;
//            };

//            Console.WriteLine(string.Join(", ", FilterNumbers(numbers, isEven)));
//            Console.WriteLine(string.Join(", ", FilterNumbers(numbers, isOdd)));
//            Console.WriteLine(string.Join(", ", FilterNumbers(numbers, isPrime)));
//        }
//    }
//}


////8
//using System;
//using System.Threading;

//namespace CallbackDelegateDemo
//{
//    class Program
//    {
//        public delegate void CallbackDelegate(string result);

//        static void LongRunningOperation(CallbackDelegate callback)
//        {
//            Thread thread = new Thread(() =>
//            {
//                Thread.Sleep(2000);
//                callback("Операция завершена успешно");
//            });
//            thread.Start();
//        }

//        static void Main()
//        {
//            CallbackDelegate callback = result => Console.WriteLine($"Результат: {result}");

//            Console.WriteLine("Запуск асинхронной операции...");
//            LongRunningOperation(callback);

//            Console.WriteLine("Основной поток продолжает работу...");
//            Thread.Sleep(3000);
//        }
//    }
//}

////9
//using System;
//using System.Collections.Generic;

//namespace SortingDelegateDemo
//{
//    class Program
//    {
//        public class Student
//        {
//            public string Name { get; set; }
//            public int Age { get; set; }
//            public double GPA { get; set; }

//            public override string ToString()
//            {
//                return $"{Name,-10} Age: {Age,2}  GPA: {GPA:F2}";
//            }
//        }

//        public delegate int StudentComparer(Student a, Student b);

//        static void Main()
//        {
//            List<Student> students = new List<Student>
//            {
//                new Student { Name = "Alice", Age = 22, GPA = 3.8 },
//                new Student { Name = "Bob", Age = 20, GPA = 3.5 },
//                new Student { Name = "Charlie", Age = 23, GPA = 3.9 }
//            };

//            StudentComparer byName = (a, b) => a.Name.CompareTo(b.Name);
//            StudentComparer byAge = (a, b) => a.Age.CompareTo(b.Age);
//            StudentComparer byGPADesc = (a, b) => b.GPA.CompareTo(a.GPA);

//            students.Sort((a, b) => byName(a, b));
//            students.ForEach(Console.WriteLine);
//        }
//    }
//}

////10
//using System;

//namespace ErrorHandlerDelegateDemo
//{
//    class Program
//    {
//        public delegate void ErrorHandlerDelegate(Exception ex);

//        static void ExecuteWithHandling(Action action, ErrorHandlerDelegate errorHandler)
//        {
//            try
//            {
//                action();
//            }
//            catch (Exception ex)
//            {
//                errorHandler(ex);
//            }
//        }

//        static void Main()
//        {
//            ErrorHandlerDelegate consoleHandler = ex =>
//                Console.WriteLine($"Ошибка: {ex.Message}");

//            ErrorHandlerDelegate fileHandler = ex =>
//                Console.WriteLine($"[FILE] Ошибка: {ex.GetType().Name}");

//            ExecuteWithHandling(() =>
//            {
//                throw new InvalidOperationException("Тестовая ошибка");
//            }, consoleHandler);
//        }
//    }
//}

////11
//using System;

//namespace StringTransformerDelegateDemo
//{
//    class Program
//    {
//        public delegate string StringTransformer(string input);

//        static void Main()
//        {
//            StringTransformer toUpper = s => s.ToUpper();
//            StringTransformer reverse = s =>
//            {
//                char[] chars = s.ToCharArray();
//                Array.Reverse(chars);
//                return new string(chars);
//            };
//            StringTransformer addStars = s => $"*** {s} ***";

//            Console.WriteLine(toUpper("hello"));
//            Console.WriteLine(reverse("delegate"));
//            Console.WriteLine(addStars("important"));
//        }
//    }
//}

////12
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace SearchDelegateDemo
//{
//    class Program
//    {
//        public delegate bool SearchDelegate<T>(T item);

//        static T FindItem<T>(List<T> collection, SearchDelegate<T> search)
//        {
//            return collection.FirstOrDefault(item => search(item));
//        }

//        static void Main()
//        {
//            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };

//            SearchDelegate<string> startsWithA = s => s.StartsWith("A");
//            SearchDelegate<string> length5 = s => s.Length == 5;

//            Console.WriteLine(FindItem(names, startsWithA));
//            Console.WriteLine(FindItem(names, length5));
//        }
//    }
//}

////13
//using System;

//namespace ValidationDelegateDemo
//{
//    class Program
//    {
//        public delegate bool ValidationDelegate(string data);

//        static bool ValidateData(string data, ValidationDelegate validator)
//        {
//            return validator(data);
//        }

//        static void Main()
//        {
//            ValidationDelegate emailValidator = s => s.Contains("@") && s.Contains(".");
//            ValidationDelegate passwordValidator = s => s.Length >= 8;
//            ValidationDelegate phoneValidator = s => s.All(char.IsDigit) && s.Length == 11;

//            Console.WriteLine(ValidateData("test@mail.com", emailValidator));
//            Console.WriteLine(ValidateData("12345", passwordValidator));
//        }
//    }
//}

////14
//using System;

//namespace FormatterDelegateDemo
//{
//    class Program
//    {
//        public class Person
//        {
//            public string Name { get; set; }
//            public int Age { get; set; }
//        }

//        public delegate string FormatterDelegate<T>(T obj);

//        static void Main()
//        {
//            Person person = new Person { Name = "John", Age = 30 };

//            FormatterDelegate<Person> simpleFormat = p => $"{p.Name} ({p.Age})";
//            FormatterDelegate<Person> detailedFormat = p =>
//                $"Имя: {p.Name}, Возраст: {p.Age} лет";

//            Console.WriteLine(simpleFormat(person));
//            Console.WriteLine(detailedFormat(person));
//        }
//    }
//}

////15
//using System;
//using System.Collections.Generic;

//namespace ComparisonDelegateDemo
//{
//    class Program
//    {
//        public delegate int CustomComparison<T>(T x, T y);

//        static void Main()
//        {
//            List<string> words = new List<string> { "apple", "banana", "cherry", "date" };

//            CustomComparison<string> byLength = (x, y) => x.Length.CompareTo(y.Length);
//            CustomComparison<string> byReverse = (x, y) =>
//                string.Compare(new string(x.Reverse().ToArray()), new string(y.Reverse().ToArray()));

//            words.Sort((x, y) => byLength(x, y));
//            words.ForEach(Console.WriteLine);
//        }
//    }
//}

////16
//using System;

//namespace ConverterDelegateDemo
//{
//    class Program
//    {
//        public delegate TOutput ConverterDelegate<TInput, TOutput>(TInput input);

//        static void Main()
//        {
//            ConverterDelegate<string, int> stringToInt = int.Parse;
//            ConverterDelegate<int, string> intToHex = n => n.ToString("X");
//            ConverterDelegate<double, int> doubleToInt = d => (int)Math.Round(d);

//            Console.WriteLine(stringToInt("123"));
//            Console.WriteLine(intToHex(255));
//            Console.WriteLine(doubleToInt(3.7));
//        }
//    }
//}

////17
//using System;
//using System.Collections.Generic;

//namespace ProcessorDelegateDemo
//{
//    class Program
//    {
//        public delegate void ProcessorDelegate<T>(T item);

//        static void ProcessCollection<T>(List<T> collection, ProcessorDelegate<T> processor)
//        {
//            foreach (var item in collection)
//            {
//                processor(item);
//            }
//        }

//        static void Main()
//        {
//            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

//            ProcessorDelegate<int> square = n => Console.WriteLine($"{n}² = {n * n}");
//            ProcessorDelegate<int> cube = n => Console.WriteLine($"{n}³ = {n * n * n}");

//            ProcessCollection(numbers, square);
//            ProcessCollection(numbers, cube);
//        }
//    }
//}

////18
//using System;

//namespace MathFunctionDelegateDemo
//{
//    class Program
//    {
//        public delegate double MathFunction(double x);

//        static void Main()
//        {
//            MathFunction sine = Math.Sin;
//            MathFunction square = x => x * x;
//            MathFunction exponential = Math.Exp;

//            Console.WriteLine(sine(Math.PI / 2));
//            Console.WriteLine(square(5));
//            Console.WriteLine(exponential(1));
//        }
//    }
//}


////19
//using System;
//using System.Collections.Generic;

//namespace TreeTraversalDelegateDemo
//{
//    class Program
//    {
//        public class TreeNode
//        {
//            public string Value { get; set; }
//            public List<TreeNode> Children { get; set; } = new List<TreeNode>();
//        }

//        public delegate void TreeTraversalDelegate<T>(T node);

//        static void TraverseTree(TreeNode root, TreeTraversalDelegate<TreeNode> action)
//        {
//            action(root);
//            foreach (var child in root.Children)
//            {
//                TraverseTree(child, action);
//            }
//        }

//        static void Main()
//        {
//            TreeNode root = new TreeNode { Value = "A" };
//            root.Children.Add(new TreeNode { Value = "B" });
//            root.Children.Add(new TreeNode { Value = "C" });

//            TreeTraversalDelegate<TreeNode> printNode = node => Console.WriteLine(node.Value);
//            TraverseTree(root, printNode);
//        }
//    }
//}

////20
//using System;

//namespace FactoryDelegateDemo
//{
//    class Program
//    {
//        public class Product
//        {
//            public string Name { get; set; }
//            public override string ToString() => Name;
//        }

//        public delegate T FactoryDelegate<T>();

//        static void Main()
//        {
//            FactoryDelegate<Product> productFactory = () => new Product { Name = "New Product" };
//            FactoryDelegate<string> stringFactory = () => Guid.NewGuid().ToString();
//            FactoryDelegate<DateTime> dateFactory = () => DateTime.Now;

//            Console.WriteLine(productFactory());
//            Console.WriteLine(stringFactory());
//            Console.WriteLine(dateFactory());
//        }
//    }
//}

////21
//using System;
//using System.Collections.Generic;

//namespace CacheDelegateDemo
//{
//    class Program
//    {
//        public delegate TResult CachedFunction<T, TResult>(T input);

//        static CachedFunction<int, long> CreateCachedFunction(Func<int, long> originalFunction)
//        {
//            var cache = new Dictionary<int, long>();

//            return input =>
//            {
//                if (cache.ContainsKey(input))
//                {
//                    Console.WriteLine($"Из кеша: {input} -> {cache[input]}");
//                    return cache[input];
//                }

//                long result = originalFunction(input);
//                cache[input] = result;
//                Console.WriteLine($"Вычислено: {input} -> {result}");
//                return result;
//            };
//        }

//        static long Factorial(int n)
//        {
//            if (n <= 1) return 1;
//            return n * Factorial(n - 1);
//        }

//        static void Main()
//        {
//            CachedFunction<int, long> cachedFactorial = CreateCachedFunction(Factorial);

//            Console.WriteLine(cachedFactorial(5));
//            Console.WriteLine(cachedFactorial(4));
//            Console.WriteLine(cachedFactorial(5));
//            Console.WriteLine(cachedFactorial(6));
//        }
//    }
//}

////22
//using System;

//namespace LoggingDelegateDemo
//{
//    class Program
//    {
//        public delegate void LoggerDelegate(string message, string level);

//        static void ExecuteWithLogging(Action action, LoggerDelegate logger, string operationName)
//        {
//            logger($"Начало: {operationName}", "INFO");

//            try
//            {
//                action();
//                logger($"Успешно: {operationName}", "SUCCESS");
//            }
//            catch (Exception ex)
//            {
//                logger($"Ошибка: {operationName} - {ex.Message}", "ERROR");
//            }
//        }

//        static void Main()
//        {
//            LoggerDelegate consoleLogger = (msg, level) =>
//                Console.WriteLine($"[{level}] {DateTime.Now:HH:mm:ss}: {msg}");

//            LoggerDelegate fileLogger = (msg, level) =>
//                Console.WriteLine($"[FILE][{level}] {msg}");

//            ExecuteWithLogging(() =>
//            {
//                Console.WriteLine("Выполняется операция...");
//            }, consoleLogger, "Тестовая операция");
//        }
//    }
//}

////23
//using System;
//using System.Threading;

//namespace TimerDelegateDemo
//{
//    class Program
//    {
//        public delegate void TimerDelegate();

//        static void ExecuteAfterDelay(TimerDelegate action, int delayMs)
//        {
//            Thread timerThread = new Thread(() =>
//            {
//                Thread.Sleep(delayMs);
//                action();
//            });
//            timerThread.Start();
//        }

//        static void Main()
//        {
//            TimerDelegate helloAction = () => Console.WriteLine("Привет после задержки!");
//            TimerDelegate timeAction = () => Console.WriteLine($"Время: {DateTime.Now:HH:mm:ss}");

//            Console.WriteLine("Запуск таймеров...");

//            ExecuteAfterDelay(helloAction, 2000);
//            ExecuteAfterDelay(timeAction, 3000);

//            Console.WriteLine("Таймеры запущены, ожидайте...");
//            Thread.Sleep(4000);
//        }
//    }
//}

////24
//using System;

//namespace InputDelegateDemo
//{
//    class Program
//    {
//        public delegate void InputHandlerDelegate(string input);

//        static void ProcessUserInput(InputHandlerDelegate handler)
//        {
//            while (true)
//            {
//                Console.Write("Введите команду (exit для выхода): ");
//                string input = Console.ReadLine();

//                if (input?.ToLower() == "exit")
//                    break;

//                handler(input);
//            }
//        }

//        static void Main()
//        {
//            InputHandlerDelegate echoHandler = input =>
//                Console.WriteLine($"Вы ввели: {input}");

//            InputHandlerDelegate lengthHandler = input =>
//                Console.WriteLine($"Длина: {input?.Length ?? 0} символов");

//            InputHandlerDelegate upperHandler = input =>
//                Console.WriteLine($"В верхнем регистре: {input?.ToUpper()}");

//            InputHandlerDelegate multiHandler = echoHandler;
//            multiHandler += lengthHandler;
//            multiHandler += upperHandler;

//            ProcessUserInput(multiHandler);
//        }
//    }
//}

////25
//using System;
//using System.Collections.Generic;

//namespace ObserverDelegateDemo
//{
//    class Program
//    {
//        public delegate void ObserverDelegate<T>(T data);

//        class Observable<T>
//        {
//            private List<ObserverDelegate<T>> _observers = new List<ObserverDelegate<T>>();

//            public void Subscribe(ObserverDelegate<T> observer)
//            {
//                _observers.Add(observer);
//            }

//            public void Unsubscribe(ObserverDelegate<T> observer)
//            {
//                _observers.Remove(observer);
//            }

//            public void Notify(T data)
//            {
//                foreach (var observer in _observers)
//                {
//                    observer(data);
//                }
//            }
//        }

//        static void Main()
//        {
//            Observable<string> newsAgency = new Observable<string>();

//            ObserverDelegate<string> emailSubscriber = news =>
//                Console.WriteLine($"[EMAIL] Новость: {news}");

//            ObserverDelegate<string> smsSubscriber = news =>
//                Console.WriteLine($"[SMS] Новость: {news}");

//            ObserverDelegate<string> consoleSubscriber = news =>
//                Console.WriteLine($"[CONSOLE] {news}");

//            newsAgency.Subscribe(emailSubscriber);
//            newsAgency.Subscribe(smsSubscriber);
//            newsAgency.Subscribe(consoleSubscriber);

//            newsAgency.Notify("Запуск новой версии системы");
//            newsAgency.Notify("Технические работы запланированы");

//            newsAgency.Unsubscribe(smsSubscriber);
//            newsAgency.Notify("SMS подписка отключена");
//        }
//    }
//}

////26
//using System;

//namespace AddOperatorDelegateDemo
//{
//    class Program
//    {
//        public delegate void ProcessDelegate(string message);

//        static void LogMessage(string msg)
//        {
//            Console.WriteLine($"[LOG] {msg}");
//        }

//        static void PrintMessage(string msg)
//        {
//            Console.WriteLine($"[PRINT] {msg}");
//        }

//        static void SaveMessage(string msg)
//        {
//            Console.WriteLine($"[SAVE] {msg}");
//        }

//        static void Main()
//        {
//            ProcessDelegate logger = LogMessage;
//            ProcessDelegate printer = PrintMessage;
//            ProcessDelegate saver = SaveMessage;

//            ProcessDelegate combined = logger + printer;
//            combined("Первое сообщение");

//            combined += saver;
//            combined("Второе сообщение");

//            Console.WriteLine($"Количество методов: {combined.GetInvocationList().Length}");
//        }
//    }
//}

////27
//using System;

//namespace ChainDelegateDemo
//{
//    class Program
//    {
//        public delegate string StringProcessor(string input);

//        static string ToUpper(string s) => s.ToUpper();
//        static string AddStars(string s) => $"*** {s} ***";
//        static string Reverse(string s)
//        {
//            char[] chars = s.ToCharArray();
//            Array.Reverse(chars);
//            return new string(chars);
//        }

//        static void Main()
//        {
//            StringProcessor processor = ToUpper;
//            processor += AddStars;
//            processor += Reverse;

//            string result = "hello";
//            foreach (StringProcessor method in processor.GetInvocationList())
//            {
//                result = method(result);
//                Console.WriteLine($"Промежуточный результат: {result}");
//            }

//            Console.WriteLine($"Финальный результат: {result}");
//        }
//    }
//}

////28
//using System;

//namespace MulticastDelegateDemo
//{
//    class Program
//    {
//        public delegate void CalculationDelegate(int a, int b);

//        static void Add(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
//        static void Subtract(int a, int b) => Console.WriteLine($"{a} - {b} = {a - b}");
//        static void Multiply(int a, int b) => Console.WriteLine($"{a} * {b} = {a * b}");
//        static void Divide(int a, int b) => Console.WriteLine($"{a} / {b} = {(b != 0 ? a / b : 0)}");

//        static void Main()
//        {
//            CalculationDelegate calculator = Add;
//            calculator += Subtract;
//            calculator += Multiply;
//            calculator += Divide;

//            Console.WriteLine("Многоадресный делегат:");
//            calculator(10, 5);

//            Console.WriteLine($"Количество методов: {calculator.GetInvocationList().Length}");

//            Delegate[] methods = calculator.GetInvocationList();
//            foreach (CalculationDelegate method in methods)
//            {
//                Console.WriteLine($"Метод: {method.Method.Name}");
//            }
//        }
//    }
//}

////29
//using System;

//namespace SubscriptionDelegateDemo
//{
//    class Program
//    {
//        public delegate void NotificationDelegate(string message);

//        static void EmailNotification(string msg) => Console.WriteLine($"[EMAIL] {msg}");
//        static void SMSNotification(string msg) => Console.WriteLine($"[SMS] {msg}");
//        static void PushNotification(string msg) => Console.WriteLine($"[PUSH] {msg}");
//        static void LogNotification(string msg) => Console.WriteLine($"[LOG] {DateTime.Now}: {msg}");

//        static void Main()
//        {
//            NotificationDelegate notifications = null;

//            notifications += EmailNotification;
//            notifications += SMSNotification;
//            notifications += PushNotification;
//            notifications += LogNotification;

//            Console.WriteLine("Все обработчики подписаны:");
//            notifications("Система запущена");

//            Console.WriteLine($"Всего обработчиков: {notifications.GetInvocationList().Length}");
//        }
//    }
//}

////30
//using System;

//namespace LogAndEmailDelegateDemo
//{
//    class Program
//    {
//        public delegate void LogAndNotifyDelegate(string message);

//        static void LogToFile(string msg)
//        {
//            Console.WriteLine($"[FILE] Запись в лог: {msg}");
//        }

//        static void SendEmail(string msg)
//        {
//            Console.WriteLine($"[EMAIL] Отправка: {msg}");
//        }

//        static void LogToConsole(string msg)
//        {
//            Console.WriteLine($"[CONSOLE] {DateTime.Now:HH:mm:ss}: {msg}");
//        }

//        static void Main()
//        {
//            LogAndNotifyDelegate processor = LogToConsole;
//            processor += LogToFile;
//            processor += SendEmail;

//            processor("Критическая ошибка в системе");

//            Console.WriteLine("Все операции выполнены одновременно");
//        }
//    }
//}

////31
//using System;

//namespace UnsubscribeDelegateDemo
//{
//    class Program
//    {
//        public delegate void EventHandlerDelegate(string eventName);

//        static void LogEvent(string name) => Console.WriteLine($"[LOG] Событие: {name}");
//        static void SaveEvent(string name) => Console.WriteLine($"[SAVE] Сохранено: {name}");
//        static void NotifyEvent(string name) => Console.WriteLine($"[NOTIFY] Уведомление: {name}");
//        static void EmailEvent(string name) => Console.WriteLine($"[EMAIL] Отправлено: {name}");

//        static void Main()
//        {
//            EventHandlerDelegate handler = LogEvent;
//            handler += SaveEvent;
//            handler += NotifyEvent;
//            handler += EmailEvent;

//            Console.WriteLine("Все обработчики:");
//            handler("UserLogin");

//            handler -= EmailEvent;
//            handler -= SaveEvent;

//            Console.WriteLine("\nПосле отписки:");
//            handler("UserLogout");

//            Console.WriteLine($"Осталось обработчиков: {handler.GetInvocationList().Length}");
//        }
//    }
//}

////32
//using System;

//namespace NotificationSystemDelegateDemo
//{
//    class Program
//    {
//        public delegate void NotificationDelegate(string message, string type);

//        class NotificationSystem
//        {
//            private NotificationDelegate _notifications;

//            public void Subscribe(NotificationDelegate handler)
//            {
//                _notifications += handler;
//            }

//            public void Unsubscribe(NotificationDelegate handler)
//            {
//                _notifications -= handler;
//            }

//            public void SendNotification(string message, string type)
//            {
//                _notifications?.Invoke(message, type);
//            }
//        }

//        static void Main()
//        {
//            NotificationSystem system = new NotificationSystem();

//            NotificationDelegate adminHandler = (msg, type) =>
//            {
//                if (type == "admin") Console.WriteLine($"[ADMIN] {msg}");
//            };

//            NotificationDelegate userHandler = (msg, type) =>
//            {
//                if (type == "user") Console.WriteLine($"[USER] {msg}");
//            };

//            NotificationDelegate allHandler = (msg, type) =>
//            {
//                Console.WriteLine($"[ALL] {type}: {msg}");
//            };

//            system.Subscribe(adminHandler);
//            system.Subscribe(userHandler);
//            system.Subscribe(allHandler);

//            system.SendNotification("Система обновлена", "admin");
//            system.SendNotification("Добро пожаловать", "user");
//        }
//    }
//}

////33
//using System;

//namespace EventChainDelegateDemo
//{
//    class Program
//    {
//        public delegate bool ValidationDelegate(string data);

//        static bool ValidateLength(string data)
//        {
//            bool valid = data.Length >= 5;
//            Console.WriteLine($"Длина: {valid}");
//            return valid;
//        }

//        static bool ValidateDigits(string data)
//        {
//            bool valid = data.Any(char.IsDigit);
//            Console.WriteLine($"Цифры: {valid}");
//            return valid;
//        }

//        static bool ValidateLetters(string data)
//        {
//            bool valid = data.Any(char.IsLetter);
//            Console.WriteLine($"Буквы: {valid}");
//            return valid;
//        }

//        static void Main()
//        {
//            ValidationDelegate validator = ValidateLength;
//            validator += ValidateDigits;
//            validator += ValidateLetters;

//            string testData = "abc123";
//            bool isValid = true;

//            foreach (ValidationDelegate method in validator.GetInvocationList())
//            {
//                if (!method(testData))
//                {
//                    isValid = false;
//                    break;
//                }
//            }

//            Console.WriteLine($"Результат валидации: {isValid}");
//        }
//    }
//}

////34
//using System;

//namespace SequentialDelegateDemo
//{
//    class Program
//    {
//        public delegate void OperationDelegate(int number);

//        static void Double(int n) => Console.WriteLine($"Удвоить: {n} -> {n * 2}");
//        static void Square(int n) => Console.WriteLine($"Квадрат: {n} -> {n * n}");
//        static void Increment(int n) => Console.WriteLine($"Увеличить: {n} -> {n + 1}");
//        static void Decrement(int n) => Console.WriteLine($"Уменьшить: {n} -> {n - 1}");

//        static void Main()
//        {
//            OperationDelegate operations = Double;
//            operations += Square;
//            operations += Increment;
//            operations += Decrement;

//            Console.WriteLine("Последовательное выполнение:");
//            operations(5);

//            Console.WriteLine("\nРеверс операций:");
//            operations = Decrement;
//            operations += Increment;
//            operations += Square;
//            operations += Double;
//            operations(5);
//        }
//    }
//}

////35
//using System;

//namespace MultiClassDelegateDemo
//{
//    class Program
//    {
//        public delegate void ReportDelegate(string message);

//        class Logger
//        {
//            public void Log(string msg) => Console.WriteLine($"[LOGGER] {msg}");
//        }

//        class Notifier
//        {
//            public void Notify(string msg) => Console.WriteLine($"[NOTIFIER] {msg}");
//        }

//        class Archiver
//        {
//            public void Archive(string msg) => Console.WriteLine($"[ARCHIVER] {msg}");
//        }

//        static void Main()
//        {
//            Logger logger = new Logger();
//            Notifier notifier = new Notifier();
//            Archiver archiver = new Archiver();

//            ReportDelegate reporter = logger.Log;
//            reporter += notifier.Notify;
//            reporter += archiver.Archive;

//            reporter("Отчет сгенерирован");

//            Console.WriteLine($"Методы из разных классов: {reporter.GetInvocationList().Length}");
//        }
//    }
//}

////36
//using System;
//using System.Collections.Generic;

//namespace LogSaveDisplayDelegateDemo
//{
//    class Program
//    {
//        public delegate void DataProcessorDelegate(string data);

//        static void LogData(string data)
//        {
//            Console.WriteLine($"[LOG] {DateTime.Now:HH:mm:ss}: {data}");
//        }

//        static void SaveData(string data)
//        {
//            Console.WriteLine($"[SAVE] Сохранено в базу: {data}");
//        }

//        static void DisplayData(string data)
//        {
//            Console.WriteLine($"[DISPLAY] >>> {data.ToUpper()} <<<");
//        }

//        static void ProcessData(string data, DataProcessorDelegate processor)
//        {
//            Console.WriteLine($"Обработка данных: {data}");
//            processor(data);
//        }

//        static void Main()
//        {
//            DataProcessorDelegate processor = LogData;
//            processor += SaveData;
//            processor += DisplayData;

//            ProcessData("Важная информация", processor);
//        }
//    }
//}

////37
//using System;
//using System.Collections.Generic;

//namespace MultiListenerSubscriptionDemo
//{
//    class Program
//    {
//        public delegate void EventListenerDelegate(string eventData);

//        class EventPublisher
//        {
//            private List<EventListenerDelegate> _listeners = new List<EventListenerDelegate>();

//            public void Subscribe(EventListenerDelegate listener)
//            {
//                _listeners.Add(listener);
//            }

//            public void Unsubscribe(EventListenerDelegate listener)
//            {
//                _listeners.Remove(listener);
//            }

//            public void PublishEvent(string eventData)
//            {
//                foreach (var listener in _listeners)
//                {
//                    listener(eventData);
//                }
//            }
//        }

//        static void Main()
//        {
//            EventPublisher publisher = new EventPublisher();

//            EventListenerDelegate listener1 = data => Console.WriteLine($"[Listener1] {data}");
//            EventListenerDelegate listener2 = data => Console.WriteLine($"[Listener2] {data}");
//            EventListenerDelegate listener3 = data => Console.WriteLine($"[Listener3] {data}");

//            publisher.Subscribe(listener1);
//            publisher.Subscribe(listener2);
//            publisher.Subscribe(listener3);

//            publisher.PublishEvent("Событие 1");

//            publisher.Unsubscribe(listener2);
//            publisher.PublishEvent("Событие 2");
//        }
//    }
//}

////38
//using System;

//namespace ExceptionChainDelegateDemo
//{
//    class Program
//    {
//        public delegate void OperationDelegate();

//        static void SafeExecute(OperationDelegate operation)
//        {
//            foreach (OperationDelegate method in operation.GetInvocationList())
//            {
//                try
//                {
//                    method();
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Ошибка в {method.Method.Name}: {ex.Message}");
//                }
//            }
//        }

//        static void Operation1()
//        {
//            Console.WriteLine("Операция 1 выполнена");
//        }

//        static void Operation2()
//        {
//            throw new InvalidOperationException("Ошибка в операции 2");
//        }

//        static void Operation3()
//        {
//            Console.WriteLine("Операция 3 выполнена");
//        }

//        static void Main()
//        {
//            OperationDelegate operations = Operation1;
//            operations += Operation2;
//            operations += Operation3;

//            SafeExecute(operations);
//        }
//    }
//}

////39
//using System;

//namespace ResultCheckDelegateDemo
//{
//    class Program
//    {
//        public delegate bool ValidationStepDelegate(string data);

//        static bool CheckLength(string data)
//        {
//            bool result = data.Length >= 3;
//            Console.WriteLine($"Проверка длины: {result}");
//            return result;
//        }

//        static bool CheckDigits(string data)
//        {
//            bool result = data.Any(char.IsDigit);
//            Console.WriteLine($"Проверка цифр: {result}");
//            return result;
//        }

//        static bool CheckUpperCase(string data)
//        {
//            bool result = data.Any(char.IsUpper);
//            Console.WriteLine($"Проверка заглавных: {result}");
//            return result;
//        }

//        static void Main()
//        {
//            ValidationStepDelegate validator = CheckLength;
//            validator += CheckDigits;
//            validator += CheckUpperCase;

//            string testData = "Abc123";
//            bool allValid = true;

//            foreach (ValidationStepDelegate step in validator.GetInvocationList())
//            {
//                if (!step(testData))
//                {
//                    allValid = false;
//                    break;
//                }
//            }

//            Console.WriteLine($"Все проверки пройдены: {allValid}");
//        }
//    }
//}

////40
//using System;
//using System.Threading;

//namespace SyncOperationsDelegateDemo
//{
//    class Program
//    {
//        public delegate void SyncOperationDelegate();

//        static void Operation1()
//        {
//            Thread.Sleep(1000);
//            Console.WriteLine("Операция 1 завершена");
//        }

//        static void Operation2()
//        {
//            Thread.Sleep(500);
//            Console.WriteLine("Операция 2 завершена");
//        }

//        static void Operation3()
//        {
//            Thread.Sleep(800);
//            Console.WriteLine("Операция 3 завершена");
//        }

//        static void ExecuteSynchronously(SyncOperationDelegate operations)
//        {
//            Console.WriteLine("Начало синхронного выполнения...");

//            foreach (SyncOperationDelegate operation in operations.GetInvocationList())
//            {
//                operation();
//            }

//            Console.WriteLine("Все операции завершены");
//        }

//        static void Main()
//        {
//            SyncOperationDelegate syncOperations = Operation1;
//            syncOperations += Operation2;
//            syncOperations += Operation3;

//            ExecuteSynchronously(syncOperations);
//        }
//    }
//}

////41
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace AsyncQueueDelegateDemo
//{
//    class Program
//    {
//        public delegate Task AsyncOperationDelegate();

//        static async Task ExecuteSequentially(AsyncOperationDelegate operations)
//        {
//            foreach (AsyncOperationDelegate operation in operations.GetInvocationList())
//            {
//                await operation();
//            }
//        }

//        static async Task AsyncOperation1()
//        {
//            await Task.Delay(1000);
//            Console.WriteLine("Асинхронная операция 1 завершена");
//        }

//        static async Task AsyncOperation2()
//        {
//            await Task.Delay(500);
//            Console.WriteLine("Асинхронная операция 2 завершена");
//        }

//        static async Task AsyncOperation3()
//        {
//            await Task.Delay(800);
//            Console.WriteLine("Асинхронная операция 3 завершена");
//        }

//        static async Task Main()
//        {
//            AsyncOperationDelegate asyncOperations = AsyncOperation1;
//            asyncOperations += AsyncOperation2;
//            asyncOperations += AsyncOperation3;

//            Console.WriteLine("Последовательное выполнение асинхронных операций:");
//            await ExecuteSequentially(asyncOperations);

//            Console.WriteLine("Все операции завершены");
//        }
//    }
//}

////42
//using System;

//namespace ConditionalDelegateDemo
//{
//    class Program
//    {
//        public delegate void ConditionalOperationDelegate(int number);

//        static void ExecuteConditionally(ConditionalOperationDelegate operations, int number, Func<int, bool> condition)
//        {
//            if (condition(number))
//            {
//                operations(number);
//            }
//            else
//            {
//                Console.WriteLine("Условие не выполнено, операции пропущены");
//            }
//        }

//        static void Double(int n) => Console.WriteLine($"Удвоение: {n} -> {n * 2}");
//        static void Square(int n) => Console.WriteLine($"Возведение в квадрат: {n} -> {n * n}");
//        static void Increment(int n) => Console.WriteLine($"Инкремент: {n} -> {n + 1}");

//        static void Main()
//        {
//            ConditionalOperationDelegate operations = Double;
//            operations += Square;
//            operations += Increment;

//            ExecuteConditionally(operations, 5, n => n > 0);
//            ExecuteConditionally(operations, -2, n => n > 0);
//        }
//    }
//}

////43
//using System;

//namespace ReduceDelegateDemo
//{
//    class Program
//    {
//        public delegate int AccumulatorDelegate(int current, int value);

//        static int Reduce(int[] values, int initial, AccumulatorDelegate accumulator)
//        {
//            int result = initial;

//            foreach (AccumulatorDelegate method in accumulator.GetInvocationList())
//            {
//                foreach (int value in values)
//                {
//                    result = method(result, value);
//                }
//            }

//            return result;
//        }

//        static int Sum(int current, int value) => current + value;
//        static int Multiply(int current, int value) => current * value;
//        static int Max(int current, int value) => Math.Max(current, value);

//        static void Main()
//        {
//            int[] numbers = { 1, 2, 3, 4, 5 };

//            AccumulatorDelegate sumAccumulator = Sum;
//            Console.WriteLine($"Сумма: {Reduce(numbers, 0, sumAccumulator)}");

//            AccumulatorDelegate productAccumulator = Multiply;
//            Console.WriteLine($"Произведение: {Reduce(numbers, 1, productAccumulator)}");

//            AccumulatorDelegate maxAccumulator = Max;
//            Console.WriteLine($"Максимум: {Reduce(numbers, int.MinValue, maxAccumulator)}");
//        }
//    }
//}

////44
//using System;

//namespace StepLoggingDelegateDemo
//{
//    class Program
//    {
//        public delegate int CalculationStepDelegate(int x);

//        static int ExecuteWithLogging(CalculationStepDelegate calculation, int startValue)
//        {
//            int result = startValue;

//            foreach (CalculationStepDelegate step in calculation.GetInvocationList())
//            {
//                int oldValue = result;
//                result = step(result);
//                Console.WriteLine($"{step.Method.Name}: {oldValue} -> {result}");
//            }

//            return result;
//        }

//        static int AddFive(int x) => x + 5;
//        static int MultiplyByTwo(int x) => x * 2;
//        static int SubtractThree(int x) => x - 3;
//        static int Square(int x) => x * x;

//        static void Main()
//        {
//            CalculationStepDelegate calculation = AddFive;
//            calculation += MultiplyByTwo;
//            calculation += SubtractThree;
//            calculation += Square;

//            int finalResult = ExecuteWithLogging(calculation, 10);
//            Console.WriteLine($"Финальный результат: {finalResult}");
//        }
//    }
//}

////45
//using System;
//using System.Collections.Generic;

//namespace PluginSystemDelegateDemo
//{
//    class Program
//    {
//        public delegate void PluginDelegate(string data);

//        class PluginSystem
//        {
//            private List<PluginDelegate> _plugins = new List<PluginDelegate>();

//            public void RegisterPlugin(PluginDelegate plugin)
//            {
//                _plugins.Add(plugin);
//            }

//            public void ExecutePlugins(string data)
//            {
//                foreach (var plugin in _plugins)
//                {
//                    plugin(data);
//                }
//            }
//        }

//        static void TextPlugin(string data)
//        {
//            Console.WriteLine($"[TEXT_PLUGIN] Обработка: {data}");
//        }

//        static void NumberPlugin(string data)
//        {
//            if (int.TryParse(data, out int number))
//            {
//                Console.WriteLine($"[NUMBER_PLUGIN] Число: {number}");
//            }
//        }

//        static void FormatPlugin(string data)
//        {
//            Console.WriteLine($"[FORMAT_PLUGIN] Форматировано: {data.ToUpper()}");
//        }

//        static void Main()
//        {
//            PluginSystem system = new PluginSystem();

//            system.RegisterPlugin(TextPlugin);
//            system.RegisterPlugin(NumberPlugin);
//            system.RegisterPlugin(FormatPlugin);

//            system.ExecutePlugins("hello");
//            system.ExecutePlugins("42");
//            system.ExecutePlugins("test data");
//        }
//    }
//}

////46
//using System;
//using System.Collections.Generic;

//namespace MultiRuleValidationDelegateDemo
//{
//    class Program
//    {
//        public delegate bool ValidationRuleDelegate(string data);

//        static bool ValidateLength(string data)
//        {
//            bool isValid = data.Length >= 5 && data.Length <= 20;
//            Console.WriteLine($"Правило длины: {isValid}");
//            return isValid;
//        }

//        static bool ValidateHasDigits(string data)
//        {
//            bool isValid = data.Any(char.IsDigit);
//            Console.WriteLine($"Правило цифр: {isValid}");
//            return isValid;
//        }

//        static bool ValidateHasLetters(string data)
//        {
//            bool isValid = data.Any(char.IsLetter);
//            Console.WriteLine($"Правило букв: {isValid}");
//            return isValid;
//        }

//        static bool ValidateNoSpecialChars(string data)
//        {
//            bool isValid = !data.Any(ch => !char.IsLetterOrDigit(ch));
//            Console.WriteLine($"Правило спецсимволов: {isValid}");
//            return isValid;
//        }

//        static bool ValidateAllRules(string data, ValidationRuleDelegate validator)
//        {
//            bool allValid = true;

//            foreach (ValidationRuleDelegate rule in validator.GetInvocationList())
//            {
//                if (!rule(data))
//                {
//                    allValid = false;
//                }
//            }

//            return allValid;
//        }

//        static void Main()
//        {
//            ValidationRuleDelegate validator = ValidateLength;
//            validator += ValidateHasDigits;
//            validator += ValidateHasLetters;
//            validator += ValidateNoSpecialChars;

//            string[] testData = { "abc123", "short", "123456", "test@mail", "ValidPassword123" };

//            foreach (string data in testData)
//            {
//                Console.WriteLine($"\nВалидация: '{data}'");
//                bool isValid = ValidateAllRules(data, validator);
//                Console.WriteLine($"Результат: {(isValid ? "ПРОЙДЕНО" : "НЕ ПРОЙДЕНО")}");
//            }
//        }
//    }
//}

////47
//using System;

//namespace MultiChannelNotificationDelegateDemo
//{
//    class Program
//    {
//        public delegate void NotificationChannelDelegate(string message, string recipient);

//        static void EmailNotification(string message, string recipient)
//        {
//            Console.WriteLine($"[EMAIL] Отправлено для {recipient}: {message}");
//        }

//        static void SMSNotification(string message, string recipient)
//        {
//            Console.WriteLine($"[SMS] Отправлено для {recipient}: {message}");
//        }

//        static void PushNotification(string message, string recipient)
//        {
//            Console.WriteLine($"[PUSH] Отправлено для {recipient}: {message}");
//        }

//        static void TelegramNotification(string message, string recipient)
//        {
//            Console.WriteLine($"[TELEGRAM] Отправлено для {recipient}: {message}");
//        }

//        static void SendToAllChannels(string message, string recipient, NotificationChannelDelegate notifier)
//        {
//            Console.WriteLine($"Отправка уведомления для {recipient}: {message}");
//            notifier(message, recipient);
//        }

//        static void Main()
//        {
//            NotificationChannelDelegate allChannels = EmailNotification;
//            allChannels += SMSNotification;
//            allChannels += PushNotification;
//            allChannels += TelegramNotification;

//            SendToAllChannels("Система обновлена", "user@example.com", allChannels);

//            Console.WriteLine("\nТолько SMS и Push:");
//            NotificationChannelDelegate limitedChannels = SMSNotification;
//            limitedChannels += PushNotification;
//            SendToAllChannels("Срочное уведомление", "+79123456789", limitedChannels);
//        }
//    }
//}

////48
//using System;
//using System.Diagnostics;

//namespace PerformanceMonitorDelegateDemo
//{
//    class Program
//    {
//        public delegate void MonitoredOperationDelegate();

//        static void ExecuteWithMonitoring(MonitoredOperationDelegate operation, string operationName)
//        {
//            Stopwatch stopwatch = Stopwatch.StartNew();

//            try
//            {
//                operation();
//            }
//            finally
//            {
//                stopwatch.Stop();
//                Console.WriteLine($"[PERFORMANCE] {operationName}: {stopwatch.ElapsedMilliseconds}ms");
//            }
//        }

//        static void MonitorAllOperations(MonitoredOperationDelegate operations, string baseName)
//        {
//            int operationCount = 0;

//            foreach (MonitoredOperationDelegate operation in operations.GetInvocationList())
//            {
//                operationCount++;
//                string operationName = $"{baseName}_{operationCount}";
//                ExecuteWithMonitoring(operation, operationName);
//            }
//        }

//        static void FastOperation()
//        {
//            for (int i = 0; i < 1000; i++) { }
//        }

//        static void MediumOperation()
//        {
//            for (int i = 0; i < 1000000; i++) { }
//        }

//        static void SlowOperation()
//        {
//            for (int i = 0; i < 10000000; i++) { }
//        }

//        static void Main()
//        {
//            MonitoredOperationDelegate operations = FastOperation;
//            operations += MediumOperation;
//            operations += SlowOperation;

//            Console.WriteLine("Мониторинг производительности операций:");
//            MonitorAllOperations(operations, "Operation");
//        }
//    }
//}

////49
//using System;
//using System.Collections.Generic;

//namespace CachingWithLoggingDelegateDemo
//{
//    class Program
//    {
//        public delegate int CachedCalculationDelegate(int input);

//        static CachedCalculationDelegate CreateCachedCalculator(Func<int, int> calculator, string operationName)
//        {
//            var cache = new Dictionary<int, int>();

//            return input =>
//            {
//                if (cache.ContainsKey(input))
//                {
//                    Console.WriteLine($"[CACHE_HIT] {operationName}({input}) = {cache[input]}");
//                    return cache[input];
//                }

//                Console.WriteLine($"[CALCULATING] {operationName}({input})");
//                int result = calculator(input);
//                cache[input] = result;
//                Console.WriteLine($"[CACHE_SAVE] {operationName}({input}) = {result}");
//                return result;
//            };
//        }

//        static int Fibonacci(int n)
//        {
//            if (n <= 1) return n;
//            return Fibonacci(n - 1) + Fibonacci(n - 2);
//        }

//        static int Factorial(int n)
//        {
//            if (n <= 1) return 1;
//            return n * Factorial(n - 1);
//        }

//        static void Main()
//        {
//            CachedCalculationDelegate cachedFib = CreateCachedCalculator(Fibonacci, "Fibonacci");
//            CachedCalculationDelegate cachedFact = CreateCachedCalculator(Factorial, "Factorial");

//            Console.WriteLine("Fibonacci с кешированием:");
//            Console.WriteLine(cachedFib(5));
//            Console.WriteLine(cachedFib(5));
//            Console.WriteLine(cachedFib(6));

//            Console.WriteLine("\nFactorial с кешированием:");
//            Console.WriteLine(cachedFact(5));
//            Console.WriteLine(cachedFact(5));
//            Console.WriteLine(cachedFact(6));

//            Console.WriteLine("\nКомбинированные вычисления:");
//            CachedCalculationDelegate combined = cachedFib;
//            combined += cachedFact;

//            foreach (CachedCalculationDelegate calc in combined.GetInvocationList())
//            {
//                Console.WriteLine($"Результат: {calc(5)}");
//            }
//        }
//    }
//}

////50
//using System;
//using System.Collections.Generic;
//using System.Threading;

//namespace TaskQueueDelegateDemo
//{
//    class Program
//    {
//        public delegate void TaskDelegate();

//        class TaskQueue
//        {
//            private Queue<TaskDelegate> _tasks = new Queue<TaskDelegate>();

//            public void EnqueueTask(TaskDelegate task)
//            {
//                _tasks.Enqueue(task);
//                Console.WriteLine($"[QUEUE] Задача добавлена. Всего в очереди: {_tasks.Count}");
//            }

//            public void ProcessAllTasks()
//            {
//                Console.WriteLine($"[QUEUE] Начало обработки {_tasks.Count} задач");

//                while (_tasks.Count > 0)
//                {
//                    TaskDelegate task = _tasks.Dequeue();
//                    Console.WriteLine($"[QUEUE] Выполнение задачи. Осталось: {_tasks.Count}");
//                    task();
//                }

//                Console.WriteLine("[QUEUE] Все задачи выполнены");
//            }
//        }

//        static void QuickTask()
//        {
//            Console.WriteLine("  Быстрая задача выполнена");
//        }

//        static void MediumTask()
//        {
//            Thread.Sleep(500);
//            Console.WriteLine("  Средняя задача выполнена");
//        }

//        static void LongTask()
//        {
//            Thread.Sleep(1000);
//            Console.WriteLine("  Долгая задача выполнена");
//        }

//        static void Main()
//        {
//            TaskQueue queue = new TaskQueue();

//            queue.EnqueueTask(QuickTask);
//            queue.EnqueueTask(MediumTask);
//            queue.EnqueueTask(LongTask);
//            queue.EnqueueTask(QuickTask);
//            queue.EnqueueTask(() => Console.WriteLine("  Анонимная задача выполнена"));

//            Console.WriteLine("\nЗапуск обработки очереди:");
//            queue.ProcessAllTasks();
//        }
//    }
//}

//51
//using System;

//namespace AnonymousMethods51
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 51: Простая операция (int, int) -> int ===\n");

//            // Анонимный метод для сложения
//            Func<int, int, int> add = delegate (int a, int b) { return a + b; };

//            // Анонимный метод для умножения
//            Func<int, int, int> multiply = delegate (int x, int y) { return x * y; };

//            // Анонимный метод для нахождения максимума
//            Func<int, int, int> max = delegate (int a, int b) { return a > b ? a : b; };

//            Console.WriteLine($"Сложение: 5 + 3 = {add(5, 3)}");
//            Console.WriteLine($"Умножение: 4 * 7 = {multiply(4, 7)}");
//            Console.WriteLine($"Максимум: 10 и 15 = {max(10, 15)}");

//            // Использование в вычислениях
//            int result = add(multiply(2, 3), multiply(4, 5));
//            Console.WriteLine($"Сложное выражение: (2*3) + (4*5) = {result}");
//        }
//    }
//}


//52
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AnonymousMethods52
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 52: Сбор фильтров ===\n");

//            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

//            // Коллекция анонимных методов-фильтров
//            List<Predicate<int>> filters = new List<Predicate<int>>
//            {
//                delegate(int x) { return x % 2 == 0; }, // Четные
//                delegate(int x) { return x > 5; },      // Больше 5
//                delegate(int x) { return x % 3 == 0; }, // Кратные 3
//                delegate(int x) { return x < 10; }      // Меньше 10
//            };

//            Console.WriteLine("Исходный список: " + string.Join(", ", numbers));

//            // Применение каждого фильтра по отдельности
//            for (int i = 0; i < filters.Count; i++)
//            {
//                var filtered = numbers.Where(x => filters[i](x)).ToList();
//                Console.WriteLine($"Фильтр {i + 1}: {string.Join(", ", filtered)}");
//            }

//            // Комбинированный фильтр (И)
//            Console.WriteLine("\nКомбинированный фильтр (все условия):");
//            var combinedFilter = numbers.Where(x => filters.All(filter => filter(x))).ToList();
//            Console.WriteLine(string.Join(", ", combinedFilter));

//            // Комбинированный фильтр (ИЛИ)
//            Console.WriteLine("Комбинированный фильтр (любое условие):");
//            var anyFilter = numbers.Where(x => filters.Any(filter => filter(x))).ToList();
//            Console.WriteLine(string.Join(", ", anyFilter));
//        }
//    }
//}


//53
//using System;
//using System.Collections.Generic;

//namespace AnonymousMethods53
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 53: Определение элемента ===\n");

//            List<string> items = new List<string>
//            {
//                "яблоко", "банан", "апельсин", "киви", "манго", "груша"
//            };

//            // Анонимные методы для определения характеристик элементов
//            Predicate<string> isFruit = delegate (string item)
//            {
//                string[] fruits = { "яблоко", "банан", "апельсин", "киви", "манго", "груша" };
//                return Array.Exists(fruits, f => f == item.ToLower());
//            };

//            Predicate<string> startsWithVowel = delegate (string item)
//            {
//                char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
//                return Array.Exists(vowels, v => char.ToLower(item[0]) == v);
//            };

//            Predicate<string> hasMoreThan5Letters = delegate (string item)
//            {
//                return item.Length > 5;
//            };

//            Predicate<string> containsLetterK = delegate (string item)
//            {
//                return item.ToLower().Contains('к');
//            };

//            Console.WriteLine("Список элементов: " + string.Join(", ", items));
//            Console.WriteLine("\nАнализ элементов:");

//            foreach (var item in items)
//            {
//                Console.WriteLine($"\n{item}:");
//                Console.WriteLine($"  - Фрукт: {isFruit(item)}");
//                Console.WriteLine($"  - Начинается с гласной: {startsWithVowel(item)}");
//                Console.WriteLine($"  - Более 5 букв: {hasMoreThan5Letters(item)}");
//                Console.WriteLine($"  - Содержит 'к': {containsLetterK(item)}");
//            }

//            // Поиск элементов по критериям
//            Console.WriteLine("\nЭлементы, начинающиеся с гласной и содержащие 'к':");
//            var specialItems = items.FindAll(delegate (string item)
//            {
//                return startsWithVowel(item) && containsLetterK(item);
//            });
//            Console.WriteLine(string.Join(", ", specialItems));
//        }
//    }
//}


//54
//using System;

//namespace AnonymousMethods54
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 54: Замыкания (внешние переменные) ===\n");

//            // Счетчик вызовов
//            int callCount = 0;

//            // Множитель, который можно менять
//            int multiplier = 2;

//            // Базовая стоимость
//            double basePrice = 100.0;

//            // Анонимный метод с замыканием на внешние переменные
//            Func<double, double> calculatePrice = delegate (double discount)
//            {
//                callCount++; // изменяем внешнюю переменную
//                double finalPrice = (basePrice * multiplier) * (1 - discount / 100);
//                return Math.Round(finalPrice, 2);
//            };

//            // Накопитель
//            double totalSales = 0;
//            Action<double> addSale = delegate (double amount)
//            {
//                totalSales += amount;
//                Console.WriteLine($"Продажа: {amount}, Общий объем: {totalSales}");
//            };

//            Console.WriteLine("Расчет цен со скидкой:");
//            for (int discount = 0; discount <= 30; discount += 10)
//            {
//                double price = calculatePrice(discount);
//                Console.WriteLine($"Скидка {discount}%: {price}");
//                addSale(price);
//            }

//            Console.WriteLine($"\nСтатистика:");
//            Console.WriteLine($"Количество вызовов: {callCount}");
//            Console.WriteLine($"Общий объем продаж: {totalSales}");

//            // Изменяем множитель и видим как это влияет на замыкание
//            Console.WriteLine("\nПосле изменения множителя на 3:");
//            multiplier = 3;
//            double newPrice = calculatePrice(20);
//            Console.WriteLine($"Цена со скидкой 20%: {newPrice}");
//            Console.WriteLine($"Новое количество вызовов: {callCount}");
//        }
//    }
//}


//55
//using System;
//using System.Timers;

//namespace AnonymousMethods55
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 55: Обработка событий ===\n");

//            EventProducer producer = new EventProducer();

//            // Анонимные методы для обработки событий
//            producer.OnMessageReceived += delegate (string message)
//            {
//                Console.WriteLine($"[ОБРАБОТЧИК 1] Получено сообщение: {message}");
//                Console.WriteLine($"[ОБРАБОТЧИК 1] Длина сообщения: {message.Length} символов");
//            };

//            producer.OnMessageReceived += delegate (string message)
//            {
//                Console.WriteLine($"[ОБРАБОТЧИК 2] Сообщение в верхнем регистре: {message.ToUpper()}");
//            };

//            int processCount = 0;
//            producer.OnMessageProcessed += delegate (object sender, EventArgs e)
//            {
//                processCount++;
//                Console.WriteLine($"[ПРОЦЕСС] Сообщение обработано! Всего обработано: {processCount}");
//            };

//            producer.OnError += delegate (string error)
//            {
//                Console.WriteLine($"[ОШИБКА] {error}");
//                Console.Beep(); // Звуковой сигнал при ошибке
//            };

//            // Имитация работы
//            Console.WriteLine("Имитация работы системы:");
//            producer.StartWork();

//            Console.WriteLine("\nНажмите любую клавишу для остановки...");
//            Console.ReadKey();
//            producer.StopWork();
//        }
//    }

//    public class EventProducer
//    {
//        private Timer timer;
//        private Random random = new Random();
//        private int messageCount = 0;

//        // События
//        public event Action<string> OnMessageReceived;
//        public event EventHandler OnMessageProcessed;
//        public event Action<string> OnError;

//        public void StartWork()
//        {
//            timer = new Timer(1000); // 1 секунда
//            timer.Elapsed += delegate (object sender, ElapsedEventArgs e)
//            {
//                messageCount++;

//                // Генерируем случайное сообщение
//                string[] messages = { "Привет", "Ошибка соединения", "Данные получены", "Внимание", "Тестовое сообщение" };
//                string message = messages[random.Next(messages.Length)];

//                // Вызываем события
//                OnMessageReceived?.Invoke($"{message} #{messageCount}");

//                // Имитация обработки
//                if (message != "Ошибка соединения")
//                {
//                    OnMessageProcessed?.Invoke(this, EventArgs.Empty);
//                }
//                else
//                {
//                    OnError?.Invoke("Произошла ошибка соединения!");
//                }
//            };
//            timer.Start();
//        }

//        public void StopWork()
//        {
//            timer?.Stop();
//            timer?.Dispose();
//        }
//    }
//}


//56
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace AnonymousMethods56
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 56: Преобразование данных ===\n");

//            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 10, 15, 20 };
//            List<string> words = new List<string> { "apple", "banana", "cherry", "date" };
//            List<double> temperatures = new List<double> { 0, 10, 20, 30, 40, 100 };

//            // Анонимные методы преобразования
//            Func<int, string> numberToText = delegate (int n)
//            {
//                return $"Число: {n}, Квадрат: {n * n}, Четное: {n % 2 == 0}";
//            };

//            Func<string, string> wordTransformer = delegate (string word)
//            {
//                return $"{word.ToUpper()} (длина: {word.Length})";
//            };

//            Func<double, double> celsiusToFahrenheit = delegate (double celsius)
//            {
//                return Math.Round(celsius * 9 / 5 + 32, 1);
//            };

//            Func<double, string> temperatureInfo = delegate (double temp)
//            {
//                string state = temp switch
//                {
//                    < 0 => "Лёд",
//                    >= 0 and < 100 => "Вода",
//                    >= 100 => "Пар",
//                    _ => "Неизвестно"
//                };
//                return $"{temp}°C = {celsiusToFahrenheit(temp)}°F ({state})";
//            };

//            Console.WriteLine("Преобразование чисел:");
//            numbers.ForEach(n => Console.WriteLine($"  {numberToText(n)}"));

//            Console.WriteLine("\nПреобразование слов:");
//            words.ForEach(w => Console.WriteLine($"  {wordTransformer(w)}"));

//            Console.WriteLine("\nПреобразование температур:");
//            temperatures.ForEach(t => Console.WriteLine($"  {temperatureInfo(t)}"));

//            // Комплексное преобразование
//            Console.WriteLine("\nКомплексное преобразование (фильтрация + преобразование):");
//            var complexResult = numbers
//                .Where(delegate (int n) { return n % 2 == 0 && n > 5; })
//                .Select(delegate (int n)
//                {
//                    return new
//                    {
//                        Number = n,
//                        Square = n * n,
//                        Cube = n * n * n,
//                        IsPrime = IsPrime(n)
//                    };
//                });

//            foreach (var item in complexResult)
//            {
//                Console.WriteLine($"  Число: {item.Number}, Квадрат: {item.Square}, Куб: {item.Cube}, Простое: {item.IsPrime}");
//            }
//        }

//        static bool IsPrime(int n)
//        {
//            if (n <= 1) return false;
//            if (n == 2) return true;
//            if (n % 2 == 0) return false;

//            for (int i = 3; i <= Math.Sqrt(n); i += 2)
//            {
//                if (n % i == 0) return false;
//            }
//            return true;
//        }
//    }
//}


//57
//using System;
//using System.Collections.Generic;

//namespace AnonymousMethods57
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 57: Проверка значений ===\n");

//            // Коллекция валидаторов
//            List<Validator> validators = new List<Validator>
//            {
//                new Validator
//                {
//                    Name = "Проверка email",
//                    Validate = delegate(string value)
//                    {
//                        return !string.IsNullOrEmpty(value) &&
//                               value.Contains("@") &&
//                               value.Contains(".");
//                    }
//                },
//                new Validator
//                {
//                    Name = "Проверка пароля",
//                    Validate = delegate(string value)
//                    {
//                        return !string.IsNullOrEmpty(value) &&
//                               value.Length >= 8 &&
//                               value.Any(char.IsDigit) &&
//                               value.Any(char.IsUpper);
//                    }
//                },
//                new Validator
//                {
//                    Name = "Проверка возраста",
//                    Validate = delegate(string value)
//                    {
//                        if (int.TryParse(value, out int age))
//                        {
//                            return age >= 18 && age <= 120;
//                        }
//                        return false;
//                    }
//                },
//                new Validator
//                {
//                    Name = "Проверка номера телефона",
//                    Validate = delegate(string value)
//                    {
//                        return !string.IsNullOrEmpty(value) &&
//                               value.Length >= 10 &&
//                               value.All(char.IsDigit);
//                    }
//                }
//            };

//            // Тестовые данные
//            var testData = new Dictionary<string, string>
//            {
//                { "email", "user@example.com" },
//                { "password", "Password123" },
//                { "age", "25" },
//                { "phone", "1234567890" },
//                { "invalid_email", "userexample.com" },
//                { "weak_password", "123" },
//                { "invalid_age", "150" }
//            };

//            // Проверка данных
//            foreach (var data in testData)
//            {
//                Console.WriteLine($"\nПроверка: {data.Key} = '{data.Value}'");

//                foreach (var validator in validators)
//                {
//                    // Определяем, какой валидатор применять по ключу
//                    bool shouldValidate = data.Key.Contains(validator.Name.ToLower().Replace("проверка ", ""));

//                    if (shouldValidate)
//                    {
//                        bool isValid = validator.Validate(data.Value);
//                        Console.WriteLine($"  {validator.Name}: {(isValid ? "✓ ВАЛИДНО" : "✗ НЕВАЛИДНО")}");

//                        if (!isValid)
//                        {
//                            // Дополнительная диагностика
//                            validator.Diagnose?.Invoke(data.Value);
//                        }
//                    }
//                }
//            }

//            // Композитная проверка
//            Console.WriteLine("\n=== Композитная проверка ===");
//            Func<string, bool> compositeEmailCheck = delegate (string email)
//            {
//                return !string.IsNullOrEmpty(email) &&
//                       email.Contains("@") &&
//                       email.Length > 5 &&
//                       email.IndexOf('@') > 0 &&
//                       email.IndexOf('@') < email.Length - 1;
//            };

//            string testEmail = "test@domain.com";
//            Console.WriteLine($"Композитная проверка email '{testEmail}': {compositeEmailCheck(testEmail)}");
//        }
//    }

//    public class Validator
//    {
//        public string Name { get; set; }
//        public Func<string, bool> Validate { get; set; }
//        public Action<string> Diagnose { get; set; }
//    }
//}


//58
//using System;
//using System.Collections.Generic;

//namespace AnonymousMethods58
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 58: Сортировка коллекции ===\n");

//            List<Person> people = new List<Person>
//            {
//                new Person("Иван", 25, 75000),
//                new Person("Мария", 30, 85000),
//                new Person("Петр", 22, 50000),
//                new Person("Анна", 35, 95000),
//                new Person("Сергей", 28, 65000)
//            };

//            List<Product> products = new List<Product>
//            {
//                new Product("Ноутбук", 50000, 4.5),
//                new Product("Телефон", 30000, 4.2),
//                new Product("Планшет", 25000, 4.7),
//                new Product("Наушники", 5000, 4.8),
//                new Product("Монитор", 15000, 4.3)
//            };

//            Console.WriteLine("Исходный список людей:");
//            people.ForEach(p => Console.WriteLine($"  {p}"));

//            // Анонимные методы для сортировки
//            Comparison<Person> sortByName = delegate (Person x, Person y)
//            {
//                return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
//            };

//            Comparison<Person> sortByAgeDesc = delegate (Person x, Person y)
//            {
//                return y.Age.CompareTo(x.Age);
//            };

//            Comparison<Person> sortBySalaryThenAge = delegate (Person x, Person y)
//            {
//                int salaryCompare = y.Salary.CompareTo(x.Salary);
//                return salaryCompare != 0 ? salaryCompare : x.Age.CompareTo(y.Age);
//            };

//            // Сортировка и вывод результатов
//            Console.WriteLine("\nСортировка по имени:");
//            people.Sort(sortByName);
//            people.ForEach(p => Console.WriteLine($"  {p}"));

//            Console.WriteLine("\nСортировка по возрасту (по убыванию):");
//            people.Sort(sortByAgeDesc);
//            people.ForEach(p => Console.WriteLine($"  {p}"));

//            Console.WriteLine("\nСортировка по зарплате (по убыванию), затем по возрасту:");
//            people.Sort(sortBySalaryThenAge);
//            people.ForEach(p => Console.WriteLine($"  {p}"));

//            // Сортировка продуктов
//            Console.WriteLine("\n\nИсходный список продуктов:");
//            products.ForEach(p => Console.WriteLine($"  {p}"));

//            Comparison<Product> sortByValue = delegate (Product x, Product y)
//            {
//                double xValue = x.Price / x.Rating;
//                double yValue = y.Price / y.Rating;
//                return xValue.CompareTo(yValue);
//            };

//            Console.WriteLine("\nСортировка продуктов по соотношению цена/рейтинг:");
//            products.Sort(sortByValue);
//            products.ForEach(p => Console.WriteLine($"  {p} (ценность: {p.Price / p.Rating:F2})"));

//            // Динамическая сортировка
//            Console.WriteLine("\n=== Динамическая сортировка ===");
//            string sortCriteria = "rating"; // можно менять на "price", "name"

//            Comparison<Product> dynamicSorter = delegate (Product x, Product y)
//            {
//                return sortCriteria.ToLower() switch
//                {
//                    "name" => string.Compare(x.Name, y.Name, StringComparison.Ordinal),
//                    "price" => x.Price.CompareTo(y.Price),
//                    "rating" => y.Rating.CompareTo(x.Rating),
//                    _ => 0
//                };
//            };

//            products.Sort(dynamicSorter);
//            Console.WriteLine($"Продукты отсортированы по: {sortCriteria}");
//            products.ForEach(p => Console.WriteLine($"  {p}"));
//        }
//    }

//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public decimal Salary { get; set; }

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

//    public class Product
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }
//        public double Rating { get; set; }

//        public Product(string name, decimal price, double rating)
//        {
//            Name = name;
//            Price = price;
//            Rating = rating;
//        }

//        public override string ToString()
//        {
//            return $"{Name}, Цена: {Price:C}, Рейтинг: {Rating}";
//        }
//    }
//}


//59
//using System;
//using System.Collections.Generic;
//using System.Threading;

//namespace AnonymousMethods59
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 59: Регистрация операций ===\n");

//            OperationLogger logger = new OperationLogger();

//            // Регистрация анонимных методов для операций
//            logger.RegisterOperation("Сложение", delegate (double a, double b)
//            {
//                Thread.Sleep(100); // Имитация долгой операции
//                return a + b;
//            });

//            logger.RegisterOperation("Умножение", delegate (double a, double b)
//            {
//                Thread.Sleep(150);
//                return a * b;
//            });

//            logger.RegisterOperation("Степень", delegate (double a, double b)
//            {
//                Thread.Sleep(200);
//                return Math.Pow(a, b);
//            });

//            logger.RegisterOperation("Максимум", delegate (double a, double b)
//            {
//                Thread.Sleep(50);
//                return Math.Max(a, b);
//            });

//            // Выполнение операций
//            Console.WriteLine("Выполнение операций:");
//            double x = 5, y = 3;

//            foreach (var opName in logger.GetOperationNames())
//            {
//                try
//                {
//                    double result = logger.ExecuteOperation(opName, x, y);
//                    Console.WriteLine($"  {opName}({x}, {y}) = {result}");
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"  {opName}: Ошибка - {ex.Message}");
//                }
//            }

//            // Статистика
//            Console.WriteLine("\nСтатистика выполнения:");
//            logger.PrintStatistics();

//            // Цепочка операций
//            Console.WriteLine("\nЦепочка операций:");
//            double chainResult = logger.ExecuteOperation("Сложение",
//                logger.ExecuteOperation("Умножение", 2, 3),
//                logger.ExecuteOperation("Степень", 2, 4));
//            Console.WriteLine($"Сложение(Умножение(2,3), Степень(2,4)) = {chainResult}");

//            // Параллельное выполнение
//            Console.WriteLine("\nПараллельное выполнение операций:");
//            logger.ExecuteParallel(new[] { ("Сложение", 1, 2), ("Умножение", 3, 4), ("Степень", 2, 3) });
//        }
//    }

//    public class OperationLogger
//    {
//        private Dictionary<string, Func<double, double, double>> operations =
//            new Dictionary<string, Func<double, double, double>>();

//        private Dictionary<string, TimeSpan> executionTimes =
//            new Dictionary<string, TimeSpan>();

//        private Dictionary<string, int> executionCounts =
//            new Dictionary<string, TimeSpan>();

//        public void RegisterOperation(string name, Func<double, double, double> operation)
//        {
//            operations[name] = operation;
//            executionCounts[name] = 0;
//        }

//        public double ExecuteOperation(string name, double a, double b)
//        {
//            if (!operations.ContainsKey(name))
//                throw new ArgumentException($"Операция '{name}' не зарегистрирована");

//            var watch = System.Diagnostics.Stopwatch.StartNew();
//            double result = operations[name](a, b);
//            watch.Stop();

//            executionTimes[name] = executionTimes.ContainsKey(name)
//                ? executionTimes[name] + watch.Elapsed
//                : watch.Elapsed;

//            executionCounts[name]++;

//            return result;
//        }

//        public IEnumerable<string> GetOperationNames()
//        {
//            return operations.Keys;
//        }

//        public void PrintStatistics()
//        {
//            foreach (var op in operations)
//            {
//                if (executionCounts[op.Key] > 0)
//                {
//                    double avgTime = executionTimes[op.Key].TotalMilliseconds / executionCounts[op.Key];
//                    Console.WriteLine($"  {op.Key}: {executionCounts[op.Key]} вызовов, " +
//                                    $"среднее время: {avgTime:F2} мс");
//                }
//            }
//        }

//        public void ExecuteParallel((string op, double a, double b)[] operationsList)
//        {
//            List<Thread> threads = new List<Thread>();

//            foreach (var (opName, a, b) in operationsList)
//            {
//                var thread = new Thread(delegate ()
//                {
//                    try
//                    {
//                        double result = ExecuteOperation(opName, a, b);
//                        Console.WriteLine($"  [Поток {Thread.CurrentThread.ManagedThreadId}] {opName}({a}, {b}) = {result}");
//                    }
//                    catch (Exception ex)
//                    {
//                        Console.WriteLine($"  [Поток {Thread.CurrentThread.ManagedThreadId}] {opName}: Ошибка - {ex.Message}");
//                    }
//                });

//                threads.Add(thread);
//                thread.Start();
//            }

//            // Ожидание завершения всех потоков
//            foreach (var thread in threads)
//            {
//                thread.Join();
//            }
//        }
//    }
//}


//60
//using System;

//namespace AnonymousMethod60
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 60: Параметр ref ===\n");

//            // Анонимный метод с ref параметром
//            ActionRef<int> increment = delegate (ref int x) { x++; };
//            ActionRef<string> capitalize = delegate (ref string s)
//            {
//                s = char.ToUpper(s[0]) + s.Substring(1).ToLower();
//            };

//            int number = 5;
//            string text = "hello";

//            Console.WriteLine($"До: number={number}, text={text}");

//            increment(ref number);
//            capitalize(ref text);

//            Console.WriteLine($"После: number={number}, text={text}");
//        }

//        delegate void ActionRef<T>(ref T value);
//    }
//}


//61
//using System;

//namespace AnonymousMethod61
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 61: Расчет факториала ===\n");

//            Func<int, long> factorial = delegate (int n)
//            {
//                long result = 1;
//                for (int i = 2; i <= n; i++) result *= i;
//                return result;
//            };

//            for (int i = 1; i <= 10; i++)
//                Console.WriteLine($"{i}! = {factorial(i)}");
//        }
//    }
//}


//62
//using System;

//namespace AnonymousMethod62
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 62: Работа со строками ===\n");

//            Func<string, string> reverse = delegate (string s)
//            {
//                char[] chars = s.ToCharArray();
//                Array.Reverse(chars);
//                return new string(chars);
//            };

//            Func<string, string> removeSpaces = delegate (string s)
//            {
//                return s.Replace(" ", "");
//            };

//            string test = "Hello World";
//            Console.WriteLine($"Исходная: {test}");
//            Console.WriteLine($"Обратная: {reverse(test)}");
//            Console.WriteLine($"Без пробелов: {removeSpaces(test)}");
//        }
//    }
//}


//63
//using System;

//namespace AnonymousMethod63
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 63: Обработка исключений ===\n");

//            Action riskyAction = delegate
//            {
//                Console.WriteLine("Выполняем рискованную операцию...");
//                throw new InvalidOperationException("Тестовая ошибка!");
//            };

//            Action safeAction = delegate
//            {
//                try { riskyAction(); }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Поймали исключение: {ex.Message}");
//                }
//            };

//            safeAction();
//        }
//    }
//}


//64
//using System;
//using System.Collections.Generic;

//namespace AnonymousMethod64
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 64: Кешированное значение ===\n");

//            var cache = new Dictionary<int, long>();
//            Func<int, long> cachedFibonacci = delegate (int n)
//            {
//                if (cache.ContainsKey(n))
//                {
//                    Console.WriteLine($"Из кэша: Fib({n})");
//                    return cache[n];
//                }

//                long result = n <= 1 ? n : cachedFibonacci(n - 1) + cachedFibonacci(n - 2);
//                cache[n] = result;
//                Console.WriteLine($"Вычислено: Fib({n}) = {result}");
//                return result;
//            };

//            Console.WriteLine($"Fib(5) = {cachedFibonacci(5)}");
//            Console.WriteLine($"Fib(5) = {cachedFibonacci(5)}"); // Из кэша
//        }
//    }
//}


//65
//using System;
//using System.IO;

//namespace AnonymousMethod65
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 65: Файловая система ===\n");

//            Action<string> processFile = delegate (string path)
//            {
//                if (File.Exists(path))
//                {
//                    string content = File.ReadAllText(path);
//                    Console.WriteLine($"Файл: {Path.GetFileName(path)}");
//                    Console.WriteLine($"Размер: {content.Length} символов");
//                }
//            };

//            processFile("test.txt"); // Создайте файл для теста
//        }
//    }
//}


//66
//using System;
//using System.Linq;

//namespace AnonymousMethod66
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 66: Анализ данных ===\n");

//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            Func<int[], string> analyze = delegate (int[] data)
//            {
//                return $"Сумма: {data.Sum()}, Среднее: {data.Average():F1}, " +
//                       $"Макс: {data.Max()}, Мин: {data.Min()}";
//            };

//            Console.WriteLine(analyze(numbers));
//        }
//    }
//}


//67
//using System;

//namespace AnonymousMethod67
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 67: Работа с базовыми данными ===\n");

//            Func<object, string> typeInfo = delegate (object obj)
//            {
//                return $"Тип: {obj.GetType().Name}, Значение: {obj}";
//            };

//            Console.WriteLine(typeInfo(42));
//            Console.WriteLine(typeInfo("Hello"));
//            Console.WriteLine(typeInfo(3.14));
//        }
//    }
//}


//68
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace AnonymousMethod68
//{
//    class Program
//    {
//        static async Task Main()
//        {
//            Console.WriteLine("=== Задание 68: Асинхронные операции ===\n");

//            Func<int, Task<string>> asyncOperation = async delegate (int seconds)
//            {
//                await Task.Delay(seconds * 1000);
//                return $"Операция завершена через {seconds} секунд";
//            };

//            string result = await asyncOperation(2);
//            Console.WriteLine(result);
//        }
//    }
//}


//69
//using System;
//using System.Collections.Generic;

//namespace AnonymousMethod69
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 69: Обход коллекции ===\n");

//            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

//            Action<List<string>> processList = delegate (List<string> list)
//            {
//                foreach (var item in list)
//                    Console.WriteLine($"- {item}");
//            };

//            processList(names);
//        }
//    }
//}


//70
//using System;
//using System.Linq;

//namespace AnonymousMethod70
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 70: Группировка данных ===\n");

//            var people = new[]
//            {
//                new { Name = "Alice", Age = 25 },
//                new { Name = "Bob", Age = 30 },
//                new { Name = "Charlie", Age = 25 }
//            };

//            Action groupByAge = delegate
//            {
//                var groups = people.GroupBy(p => p.Age);
//                foreach (var group in groups)
//                {
//                    Console.WriteLine($"Возраст {group.Key}:");
//                    foreach (var person in group)
//                        Console.WriteLine($"  {person.Name}");
//                }
//            };

//            groupByAge();
//        }
//    }
//}


//71
//using System;
//using System.Linq;

//namespace AnonymousMethod71
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 71: Сумма элементов ===\n");

//            Func<int[], int> sumCalculator = delegate (int[] numbers)
//            {
//                return numbers.Sum();
//            };

//            int[] data = { 1, 2, 3, 4, 5 };
//            Console.WriteLine($"Сумма [1,2,3,4,5] = {sumCalculator(data)}");
//        }
//    }
//}


//72
//using System;

//namespace AnonymousMethod72
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 72: Работа с датами ===\n");

//            Func<DateTime, string> dateInfo = delegate (DateTime date)
//            {
//                return $"{date:dd.MM.yyyy} ({date.DayOfWeek})";
//            };

//            Console.WriteLine($"Сегодня: {dateInfo(DateTime.Today)}");
//        }
//    }
//}


//73
//using System;
//using System.Text;

//namespace AnonymousMethod73
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 73: Шифрование данных ===\n");

//            Func<string, string> simpleEncrypt = delegate (string text)
//            {
//                byte[] bytes = Encoding.UTF8.GetBytes(text);
//                for (int i = 0; i < bytes.Length; i++) bytes[i] ^= 0xFF;
//                return Convert.ToBase64String(bytes);
//            };

//            string original = "Secret";
//            string encrypted = simpleEncrypt(original);
//            Console.WriteLine($"'{original}' -> '{encrypted}'");
//        }
//    }
//}


//74
//using System;
//using System.Linq;

//namespace AnonymousMethod74
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 74: Вывод отчетов ===\n");

//            int[] sales = { 100, 200, 150, 300 };

//            Action generateReport = delegate
//            {
//                Console.WriteLine("=== ОТЧЕТ О ПРОДАЖАХ ===");
//                Console.WriteLine($"Всего продаж: {sales.Length}");
//                Console.WriteLine($"Общий объем: {sales.Sum()}");
//                Console.WriteLine($"Среднее: {sales.Average():F1}");
//            };

//            generateReport();
//        }
//    }
//}


//75
//using System;

//namespace AnonymousMethod75
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 75: Системная регистрация ===\n");

//            Action<string, string> logEvent = delegate (string type, string message)
//            {
//                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {type}: {message}");
//            };

//            logEvent("INFO", "Система запущена");
//            logEvent("WARNING", "Низкий уровень памяти");
//            logEvent("ERROR", "Ошибка подключения к БД");
//        }
//    }
//}


//76
//using System;

//namespace Lambda76
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 76: Простая математическая операция ===\n");

//            Func<int, int> multiplyByTwo = x => x * 2;

//            Console.WriteLine($"5 * 2 = {multiplyByTwo(5)}");
//            Console.WriteLine($"10 * 2 = {multiplyByTwo(10)}");
//        }
//    }
//}


//77
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Lambda77
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 77: Фильтрация списка ===\n");

//            List<int> numbers = new List<int> { 1, 6, 3, 8, 2, 9, 4 };
//            var filtered = numbers.Where(x => x > 5).ToList();

//            Console.WriteLine($"Числа > 5: {string.Join(", ", filtered)}");
//        }
//    }
//}


//78
//using System;
//using System.Linq;

//namespace Lambda78
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 78: Преобразование строки ===\n");

//            Func<string, string> toUpper = s => s.ToUpper();
//            string[] words = { "hello", "world", "lambda" };

//            var upperWords = words.Select(s => s.ToUpper());
//            Console.WriteLine($"В верхнем регистре: {string.Join(", ", upperWords)}");
//        }
//    }
//}


//79
//using System;
//using System.Linq;

//namespace Lambda79
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 79: LINQ операции ===\n");

//            int[] numbers = { 5, 2, 8, 1, 9, 3, 7, 4, 6 };

//            var result = numbers
//                .Where(x => x > 3)
//                .Select(x => x * 2)
//                .OrderBy(x => x);

//            Console.WriteLine($"Результат: {string.Join(", ", result)}");
//        }
//    }
//}


//80
//using System;

//namespace Lambda80
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 80: Несколько параметров ===\n");

//            Func<int, int, int> add = (x, y) => x + y;
//            Func<string, string, string> concat = (s1, s2) => s1 + " " + s2;

//            Console.WriteLine($"5 + 3 = {add(5, 3)}");
//            Console.WriteLine($"Concat: {concat("Hello", "World")}");
//        }
//    }
//}


//81
//using System;
//using System.Linq;

//namespace Lambda81
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 81: Фильтрация сложных объектов ===\n");

//            var people = new[]
//            {
//                new { Name = "Alice", Age = 25 },
//                new { Name = "Bob", Age = 30 },
//                new { Name = "Charlie", Age = 20 }
//            };

//            var adults = people.Where(p => p.Age >= 25);

//            foreach (var person in adults)
//                Console.WriteLine($"{person.Name}, {person.Age} лет");
//        }
//    }
//}


//82
//using System;
//using System.Linq;

//namespace Lambda82
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 82: Группировка данных ===\n");

//            var products = new[]
//            {
//                new { Name = "Laptop", Category = "Electronics", Price = 1000 },
//                new { Name = "Phone", Category = "Electronics", Price = 500 },
//                new { Name = "Book", Category = "Education", Price = 20 }
//            };

//            var groups = products.GroupBy(p => p.Category);

//            foreach (var group in groups)
//            {
//                Console.WriteLine($"Категория: {group.Key}");
//                foreach (var product in group)
//                    Console.WriteLine($"  - {product.Name}: ${product.Price}");
//            }
//        }
//    }
//}


//83
//using System;
//using System.Linq;

//namespace Lambda83
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 83: Проверка условий ===\n");

//            int[] numbers = { 1, 2, 3, 4, 5, 6 };

//            bool allEven = numbers.All(x => x % 2 == 0);
//            bool anyEven = numbers.Any(x => x % 2 == 0);
//            bool containsThree = numbers.Contains(3);

//            Console.WriteLine($"Все четные: {allEven}");
//            Console.WriteLine($"Есть четные: {anyEven}");
//            Console.WriteLine($"Содержит 3: {containsThree}");
//        }
//    }
//}


//84
//using System;
//using System.Linq;

//namespace Lambda84
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 84: Ограничение минимума и максимума ===\n");

//            int[] numbers = { 10, 5, 8, 3, 12, 7, 15 };

//            var inRange = numbers.Where(x => x >= 5 && x <= 10);

//            Console.WriteLine($"Числа от 5 до 10: {string.Join(", ", inRange)}");
//        }
//    }
//}


//85
//using System;
//using System.Linq;

//namespace Lambda85
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 85: Сортировка ===\n");

//            string[] names = { "Charlie", "Alice", "Bob", "David" };

//            var sorted = names.OrderBy(name => name);
//            var sortedDesc = names.OrderByDescending(name => name);

//            Console.WriteLine($"По возрастанию: {string.Join(", ", sorted)}");
//            Console.WriteLine($"По убыванию: {string.Join(", ", sortedDesc)}");
//        }
//    }
//}


//86
//using System;
//using System.Linq;

//namespace Lambda86
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 86: Работа с датами ===\n");

//            DateTime[] dates =
//            {
//                new DateTime(2024, 1, 15),
//                new DateTime(2024, 2, 20),
//                new DateTime(2024, 1, 10)
//            };

//            var januaryDates = dates.Where(d => d.Month == 1)
//                                   .OrderBy(d => d.Day);

//            foreach (var date in januaryDates)
//                Console.WriteLine(date.ToString("dd.MM.yyyy"));
//        }
//    }
//}


//87
//using System;
//using System.Linq;

//namespace Lambda87
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 87: Вложенные коллекции ===\n");

//            int[][] matrix =
//            {
//                new[] { 1, 2, 3 },
//                new[] { 4, 5, 6 },
//                new[] { 7, 8, 9 }
//            };

//            var allNumbers = matrix.SelectMany(row => row);
//            var evenNumbers = matrix.SelectMany(row => row.Where(n => n % 2 == 0));

//            Console.WriteLine($"Все числа: {string.Join(", ", allNumbers)}");
//            Console.WriteLine($"Четные числа: {string.Join(", ", evenNumbers)}");
//        }
//    }
//}


//88
//using System;
//using System.Linq;

//namespace Lambda88
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 88: Преобразование типа ===\n");

//            string[] stringNumbers = { "1", "2", "3", "4", "5" };

//            var intNumbers = stringNumbers.Select(s => int.Parse(s));

//            Console.WriteLine($"Целые числа: {string.Join(", ", intNumbers)}");
//        }
//    }
//}


//89
//using System;
//using System.Linq;

//namespace Lambda89
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 89: Подсчет элементов ===\n");

//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            int evenCount = numbers.Count(x => x % 2 == 0);
//            int oddCount = numbers.Count(x => x % 2 != 0);

//            Console.WriteLine($"Четных: {evenCount}, Нечетных: {oddCount}");
//        }
//    }
//}


//90
//using System;
//using System.Linq;

//namespace Lambda90
//{
//    class Program
//    {
//        enum Status { Pending, Active, Completed, Cancelled }

//        static void Main()
//        {
//            Console.WriteLine("=== Задание 90: Работа с перечислениями ===\n");

//            Status[] statuses = { Status.Pending, Status.Active, Status.Completed, Status.Pending };

//            var pendingCount = statuses.Count(s => s == Status.Pending);
//            var activeOrCompleted = statuses.Where(s => s == Status.Active || s == Status.Completed);

//            Console.WriteLine($"Pending статусов: {pendingCount}");
//            Console.WriteLine($"Active/Completed: {string.Join(", ", activeOrCompleted)}");
//        }
//    }
//}


//91
//using System;
//using System.Linq;

//namespace Lambda91
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 91: Создание словаря ===\n");

//            var people = new[]
//            {
//                new { Id = 1, Name = "Alice" },
//                new { Id = 2, Name = "Bob" },
//                new { Id = 3, Name = "Charlie" }
//            };

//            var dict = people.ToDictionary(p => p.Id, p => p.Name);

//            foreach (var item in dict)
//                Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
//        }
//    }
//}


//92
//using System;
//using System.Linq;

//namespace Lambda92
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 92: Фильтр с несколькими действиями ===\n");

//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            var result = numbers
//                .Where(x => x > 3)
//                .Where(x => x < 8)
//                .Select(x => x * 10)
//                .Where(x => x % 20 == 0);

//            Console.WriteLine($"Результат: {string.Join(", ", result)}");
//        }
//    }
//}


//93
//using System;

//namespace Lambda93
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 93: Рекурсивные операции ===\n");

//            Func<int, int> factorial = null;
//            factorial = n => n <= 1 ? 1 : n * factorial(n - 1);

//            Console.WriteLine($"Факториал 5 = {factorial(5)}");
//        }
//    }
//}


//94
//using System;
//using System.Linq;

//namespace Lambda94
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 94: Работа с исключениями ===\n");

//            string[] inputs = { "1", "2", "abc", "4", "5" };

//            var numbers = inputs.Select(s =>
//            {
//                try { return int.Parse(s); }
//                catch { return 0; }
//            });

//            Console.WriteLine($"Результат: {string.Join(", ", numbers)}");
//        }
//    }
//}


//95
//using System;
//using System.Linq;

//namespace Lambda95
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 95: Параллельная обработка ===\n");

//            int[] numbers = Enumerable.Range(1, 100).ToArray();

//            var parallelResult = numbers.AsParallel()
//                                      .Where(x => x % 2 == 0)
//                                      .Select(x => x * x);

//            Console.WriteLine($"Первые 10 результатов: {string.Join(", ", parallelResult.Take(10))}");
//        }
//    }
//}


//96
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Lambda96
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 96: Работа со словарем ===\n");

//            var dict = new Dictionary<string, int>
//            {
//                ["apple"] = 5,
//                ["banana"] = 3,
//                ["orange"] = 7
//            };

//            var filtered = dict.Where(kvp => kvp.Value > 4)
//                              .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

//            foreach (var item in filtered)
//                Console.WriteLine($"{item.Key}: {item.Value}");
//        }
//    }
//}


//97
//using System;
//using System.Linq;

//namespace Lambda97
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 97: LINQ to Objects ===\n");

//            var students = new[]
//            {
//                new { Name = "Alice", Grade = 85 },
//                new { Name = "Bob", Grade = 92 },
//                new { Name = "Charlie", Grade = 78 }
//            };

//            var topStudents = from s in students
//                              where s.Grade >= 80
//                              orderby s.Grade descending
//                              select s.Name;

//            Console.WriteLine($"Лучшие студенты: {string.Join(", ", topStudents)}");
//        }
//    }
//}


//98
//using System;
//using System.Linq;

//namespace Lambda98
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 98: Анонимные типы ===\n");

//            var products = new[]
//            {
//                new { Name = "Laptop", Price = 1000 },
//                new { Name = "Mouse", Price = 25 }
//            };

//            var productInfo = products.Select(p => new
//            {
//                p.Name,
//                TaxedPrice = p.Price * 1.2m
//            });

//            foreach (var info in productInfo)
//                Console.WriteLine($"{info.Name}: ${info.TaxedPrice:F2}");
//        }
//    }
//}


//99
//using System;
//using System.IO;
//using System.Linq;

//namespace Lambda99
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 99: Работа с файлами ===\n");

//            string[] files = Directory.GetFiles(".", "*.txt");

//            var largeFiles = files.Where(f => new FileInfo(f).Length > 1000)
//                                 .Select(f => new {
//                                     Name = Path.GetFileName(f),
//                                     Size = new FileInfo(f).Length
//                                 });

//            foreach (var file in largeFiles)
//                Console.WriteLine($"{file.Name}: {file.Size} bytes");
//        }
//    }
//}


//100
//using System;
//using System.Linq.Expressions;

//namespace Lambda100
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("=== Задание 100: Деревья выражений ===\n");

//            Expression<Func<int, int, int>> addExpr = (a, b) => a + b;

//            Console.WriteLine($"Тип выражения: {addExpr.NodeType}");
//            Console.WriteLine($"Тело: {addExpr.Body}");
//            Console.WriteLine($"Параметры: {string.Join(", ", addExpr.Parameters.Select(p => p.Name))}");
//        }
//    }
//}