using System;
using System.Diagnostics;
using System.Reflection;

//1
//abstract class Animal
//{
//    protected string name;

//    public Animal(string name)
//    {
//        this.name = name;
//    }

//    public abstract void MakeSound();

//    public void Introduce()
//    {
//        Console.WriteLine($"Я {name}");
//    }
//}

//class Dog : Animal
//{
//    public Dog(string name) : base(name)
//    {
//    }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Гав! Гав!");
//    }
//}

//class Cat : Animal
//{
//    public Cat(string name) : base(name)
//    {
//    }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Мяу! Мяу!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Dog dog = new Dog("Шарик");
//        dog.Introduce();
//        dog.MakeSound();

//        Console.WriteLine();

//        Cat cat = new Cat("Мурзик");
//        cat.Introduce();
//        cat.MakeSound();

//        Console.WriteLine("\nПолиморфное поведение:");
//        Animal[] animals = { dog, cat };
//        foreach (Animal animal in animals)
//        {
//            animal.MakeSound();
//        }
//    }
//}


//2
//abstract class Shape
//{
//    public abstract double CalculateArea();
//}

//class Circle : Shape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public override double CalculateArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public override double CalculateArea()
//    {
//        return Width * Height;
//    }
//}


//3
//abstract class Vehicle
//{
//    public abstract void DisplayInfo();
//}

//class Car : Vehicle
//{
//    public override void DisplayInfo()
//    {
//        Console.WriteLine("Это машина.");
//    }
//}

//class Motorcycle : Vehicle
//{
//    public override void DisplayInfo()
//    {
//        Console.WriteLine("Это мотоцикл.");
//    }
//}


//4
//abstract class BaseClass
//{
//    public abstract string GetDescription();
//}

//class DerivedClass : BaseClass
//{
//    public override string GetDescription()
//    {
//        return "Это описание производного класса.";
//    }
//}


//5
//abstract class Employee
//{
//    public abstract double CalculateSalary();
//}

//class FullTimeEmployee : Employee
//{
//    public double MonthlySalary { get; set; }

//    public FullTimeEmployee(double monthlySalary)
//    {
//        MonthlySalary = monthlySalary;
//    }

//    public override double CalculateSalary()
//    {
//        return MonthlySalary;
//    }
//}

//class PartTimeEmployee : Employee
//{
//    public double HourlyRate { get; set; }
//    public int HoursWorked { get; set; }

//    public PartTimeEmployee(double hourlyRate, int hoursWorked)
//    {
//        HourlyRate = hourlyRate;
//        HoursWorked = hoursWorked;
//    }

//    public override double CalculateSalary()
//    {
//        return HourlyRate * HoursWorked;
//    }
//}


//6
//abstract class Database
//{
//    public abstract void Connect();
//    public abstract void Disconnect();
//}

//class MySQLDatabase : Database
//{
//    public override void Connect()
//    {
//        Console.WriteLine("Подключение к базе данных MySQL.");
//    }

//    public override void Disconnect()
//    {
//        Console.WriteLine("Отключение от базы данных MySQL.");
//    }
//}


//7
//abstract class AbstractClassWithProperty
//{
//    public abstract string Name { get; set; }
//}

//class ConcreteClass : AbstractClassWithProperty
//{
//    public override string Name { get; set; }
//}


//8
//abstract class Animal
//{
//    public abstract void MakeSound();
//}

//class Dog : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Гав! Гав!");
//    }
//}

//class Cat : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Мяу! Мяу!");
//    }
//}

//class Cow : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Мууу!");
//    }
//}


//9
//abstract class Payment
//{
//    public abstract void Process();
//}

//class CreditCardPayment : Payment
//{
//    public override void Process()
//    {
//        Console.WriteLine("Обработка платежа по кредитной карте.");
//    }
//}

//class PayPalPayment : Payment
//{
//    public override void Process()
//    {
//        Console.WriteLine("Обработка платежа через PayPal.");
//    }
//}


//10
//abstract class AbstractClassWithConstructor
//{
//    protected string name;

//    public AbstractClassWithConstructor(string name)
//    {
//        this.name = name;
//    }
//}

//class ConcreteClassWithConstructor : AbstractClassWithConstructor
//{
//    public ConcreteClassWithConstructor(string name) : base(name)
//    {
//    }
//}


//11
//abstract class Figure
//{
//    public abstract double CalculateArea();
//}

//class Triangle : Figure
//{
//    public double Base { get; set; }
//    public double Height { get; set; }

//    public Triangle(double @base, double height)
//    {
//        Base = @base;
//        Height = height;
//    }

//    public override double CalculateArea()
//    {
//        return 0.5 * Base * Height;
//    }
//}


//12
//abstract class Logger
//{
//    public abstract void Log(string message);
//}

//class FileLogger : Logger
//{
//    public override void Log(string message)
//    {
//        Console.WriteLine($"Логирование в файл: {message}");
//    }
//}

//class ConsoleLogger : Logger
//{
//    public override void Log(string message)
//    {
//        Console.WriteLine($"Логирование в консоль: {message}");
//    }
//}


//13
//abstract class AbstractClassWithMultipleMethods
//{
//    public abstract void Method1();
//    public abstract void Method2();
//}

//class ConcreteClassWithMultipleMethods : AbstractClassWithMultipleMethods
//{
//    public override void Method1()
//    {
//        Console.WriteLine("Реализация метода 1.");
//    }

//    public override void Method2()
//    {
//        Console.WriteLine("Реализация метода 2.");
//    }
//}


//14
//abstract class AnimalType
//{
//    public abstract void Eat();
//}

//class Herbivore : AnimalType
//{
//    public override void Eat()
//    {
//        Console.WriteLine("Травоядное ест траву.");
//    }
//}

//class Carnivore : AnimalType
//{
//    public override void Eat()
//    {
//        Console.WriteLine("Хищник ест мясо.");
//    }
//}


//15
//abstract class DataProcessor
//{
//    public abstract void ProcessData();
//}

//class TextDataProcessor : DataProcessor
//{
//    public override void ProcessData()
//    {
//        Console.WriteLine("Обработка текстовых данных.");
//    }
//}


//16
//abstract class Authentication
//{
//    public abstract bool Authenticate(string username, string password);
//}

//class SimpleAuthentication : Authentication
//{
//    public override bool Authenticate(string username, string password)
//    {
//        return username == "admin" && password == "password";
//    }
//}


//17
//abstract class ReportGenerator
//{
//    public abstract void GenerateReport();
//}

//class PDFReportGenerator : ReportGenerator
//{
//    public override void GenerateReport()
//    {
//        Console.WriteLine("Генерация отчета в формате PDF.");
//    }
//}


//18
//abstract class FileHandler
//{
//    public abstract void ReadFile(string filePath);
//}

//class TextFileHandler : FileHandler
//{
//    public override void ReadFile(string filePath)
//    {
//        Console.WriteLine($"Чтение текстового файла: {filePath}");
//    }
//}


//19
//abstract class Validator
//{
//    public abstract bool Validate(string data);
//}

//class EmailValidator : Validator
//{
//    public override bool Validate(string data)
//    {
//        return data.Contains("@");
//    }
//}


//20
//abstract class Notification
//{
//    public abstract void SendNotification(string message);
//}

//class EmailNotification : Notification
//{
//    public override void SendNotification(string message)
//    {
//        Console.WriteLine($"Отправка уведомления по email: {message}");
//    }
//}


//21
//abstract class Calculator
//{
//    public abstract double Add(double a, double b);
//    public abstract double Subtract(double a, double b);
//}

//class SimpleCalculator : Calculator
//{
//    public override double Add(double a, double b)
//    {
//        return a + b;
//    }

//    public override double Subtract(double a, double b)
//    {
//        return a - b;
//    }
//}


//22
//abstract class Connection
//{
//    public abstract void Open();
//    public abstract void Close();
//}

//class SQLConnection : Connection
//{
//    public override void Open()
//    {
//        Console.WriteLine("Открытие соединения с SQL базой данных.");
//    }

//    public override void Close()
//    {
//        Console.WriteLine("Закрытие соединения с SQL базой данных.");
//    }
//}


//23
//abstract class Cache
//{
//    public abstract void AddToCache(string key, object value);
//    public abstract object GetFromCache(string key);
//}

//class MemoryCache : Cache
//{
//    private Dictionary<string, object> cache = new Dictionary<string, object>();

//    public override void AddToCache(string key, object value)
//    {
//        cache[key] = value;
//    }

//    public override object GetFromCache(string key)
//    {
//        return cache.ContainsKey(key) ? cache[key] : null;
//    }
//}


//24
//abstract class Parser
//{
//    public abstract void Parse(string data);
//}

//class XMLParser : Parser
//{
//    public override void Parse(string data)
//    {
//        Console.WriteLine($"Парсинг XML данных: {data}");
//    }
//}


//25
//abstract class Serializer
//{
//    public abstract string Serialize(object obj);
//}

//class JSONSerializer : Serializer
//{
//    public override string Serialize(object obj)
//    {
//        return $"JSON: {obj.ToString()}";
//    }
//}


//26
//abstract class Compressor
//{
//    public abstract void Compress(string filePath);
//}

//class ZipCompressor : Compressor
//{
//    public override void Compress(string filePath)
//    {
//        Console.WriteLine($"Сжатие файла {filePath} в ZIP-архив.");
//    }
//}


//27
//abstract class Encryptor
//{
//    public abstract string Encrypt(string data);
//}

//class AESEncryptor : Encryptor
//{
//    public override string Encrypt(string data)
//    {
//        Console.WriteLine($"Шифрование данных: {data}");
//        return "Зашифрованные данные";
//    }
//}


//28
//abstract class Formatter
//{
//    public abstract string Format(object data);
//}

//class JSONFormatter : Formatter
//{
//    public override string Format(object data)
//    {
//        return $"JSON: {data}";
//    }
//}


//29
//abstract class Filter
//{
//    public abstract bool Apply(string data);
//}

//class LengthFilter : Filter
//{
//    public int MinLength { get; set; }

//    public LengthFilter(int minLength)
//    {
//        MinLength = minLength;
//    }

//    public override bool Apply(string data)
//    {
//        return data.Length >= MinLength;
//    }
//}


//30
//abstract class Sorter
//{
//    public abstract void Sort(List<int> data);
//}

//class QuickSorter : Sorter
//{
//    public override void Sort(List<int> data)
//    {
//        data.Sort();
//        Console.WriteLine("Сортировка выполнена.");
//    }
//}


//31
//abstract class Builder
//{
//    public abstract void BuildPartA();
//    public abstract void BuildPartB();
//}

//class ConcreteBuilder : Builder
//{
//    public override void BuildPartA()
//    {
//        Console.WriteLine("Построение части A.");
//    }

//    public override void BuildPartB()
//    {
//        Console.WriteLine("Построение части B.");
//    }
//}


//32
//abstract class Strategy
//{
//    public abstract void Execute();
//}

//class ConcreteStrategyA : Strategy
//{
//    public override void Execute()
//    {
//        Console.WriteLine("Выполнение стратегии A.");
//    }
//}


//33
//abstract class Adapter
//{
//    public abstract void Request();
//}

//class ConcreteAdapter : Adapter
//{
//    public override void Request()
//    {
//        Console.WriteLine("Адаптация запроса.");
//    }
//}


//34
//abstract class Observable
//{
//    public abstract void NotifyObservers();
//}

//class ConcreteObservable : Observable
//{
//    public override void NotifyObservers()
//    {
//        Console.WriteLine("Уведомление наблюдателей.");
//    }
//}


//35
//abstract class Command
//{
//    public abstract void Execute();
//}

//class ConcreteCommand : Command
//{
//    public override void Execute()
//    {
//        Console.WriteLine("Выполнение команды.");
//    }
//}


//36
//interface IAnimal
//{
//    void MakeSound();
//}

//class Dog : IAnimal
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Гав! Гав!");
//    }
//}


//37
//interface IShape
//{
//    double CalculateArea();
//}

//class Circle : IShape
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public double CalculateArea()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}


//38
//interface IComparable<T>
//{
//    int CompareTo(T other);
//}

//class Person : IComparable<Person>
//{
//    public string Name { get; set; }

//    public int CompareTo(Person other)
//    {
//        return Name.CompareTo(other.Name);
//    }
//}


//39
//interface IPayable
//{
//    void Pay();
//}

//class Invoice : IPayable
//{
//    public void Pay()
//    {
//        Console.WriteLine("Оплата счета.");
//    }
//}


//40
//interface IDrawable
//{
//    void Draw();
//}

//class Rectangle : IDrawable
//{
//    public void Draw()
//    {
//        Console.WriteLine("Рисование прямоугольника.");
//    }
//}


//41
//using System.Collections;

//interface IEnumerable<T>
//{
//    IEnumerator<T> GetEnumerator();
//}

//class MyCollection<T> : IEnumerable<T>
//{
//    private List<T> items = new List<T>();

//    public IEnumerator<T> GetEnumerator()
//    {
//        return items.GetEnumerator();
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}


//42
//interface IDisposable
//{
//    void Dispose();
//}

//class Resource : IDisposable
//{
//    public void Dispose()
//    {
//        Console.WriteLine("Освобождение ресурсов.");
//    }
//}


//43
//interface ICloneable<T>
//{
//    T Clone();
//}

//class Document : ICloneable<Document>
//{
//    public string Content { get; set; }

//    public Document Clone()
//    {
//        return new Document { Content = this.Content };
//    }
//}


//44
//interface INotifyPropertyChanged
//{
//    event EventHandler PropertyChanged;
//}

//class Person : INotifyPropertyChanged
//{
//    public event EventHandler PropertyChanged;

//    private string name;

//    public string Name
//    {
//        get { return name; }
//        set
//        {
//            if (name != value)
//            {
//                name = value;
//                PropertyChanged?.Invoke(this, EventArgs.Empty);
//            }
//        }
//    }
//}


//45
//interface IRepository<T>
//{
//    void Add(T item);
//    void Remove(T item);
//}

//class UserRepository : IRepository<string>
//{
//    private List<string> users = new List<string>();

//    public void Add(string user)
//    {
//        users.Add(user);
//    }

//    public void Remove(string user)
//    {
//        users.Remove(user);
//    }
//}


//46
//interface ILogger
//{
//    void Log(string message);
//}

//class FileLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Логирование в файл: {message}");
//    }
//}


//47
//interface IValidator<T>
//{
//    bool Validate(T data);
//}

//class EmailValidator : IValidator<string>
//{
//    public bool Validate(string email)
//    {
//        return email.Contains("@");
//    }
//}


//48
//interface IConverter<TInput, TOutput>
//{
//    TOutput Convert(TInput input);
//}

//class StringToIntConverter : IConverter<string, int>
//{
//    public int Convert(string input)
//    {
//        return int.Parse(input);
//    }
//}


//49
//interface IParser<T>
//{
//    T Parse(string data);
//}

//class IntParser : IParser<int>
//{
//    public int Parse(string data)
//    {
//        return int.Parse(data);
//    }
//}


//50
//interface ISerializer<T>
//{
//    string Serialize(T obj);
//}

//class JsonSerializer<T> : ISerializer<T>
//{
//    public string Serialize(T obj)
//    {
//        return $"JSON: {obj}";
//    }
//}


//51
//public interface IEncryptor
//{
//    string Encrypt(string data);
//    string Decrypt(string encryptedData);
//}

//public class AESEncryptor : IEncryptor
//{
//    public string Encrypt(string data)
//    {
//        Console.WriteLine($"Шифрование данных: {data}");
//        return "Зашифрованные данные";
//    }

//    public string Decrypt(string encryptedData)
//    {
//        Console.WriteLine($"Расшифровка данных: {encryptedData}");
//        return "Расшифрованные данные";
//    }
//}


//52
//public interface ICompressor
//{
//    void Compress(string filePath);
//    void Decompress(string compressedFilePath);
//}

//public class ZipCompressor : ICompressor
//{
//    public void Compress(string filePath)
//    {
//        Console.WriteLine($"Сжатие файла: {filePath}");
//    }

//    public void Decompress(string compressedFilePath)
//    {
//        Console.WriteLine($"Распаковка файла: {compressedFilePath}");
//    }
//}


//53
//public interface IFilter<T>
//{
//    bool Apply(T data);
//}

//public class LengthFilter : IFilter<string>
//{
//    public int MinLength { get; set; }

//    public LengthFilter(int minLength)
//    {
//        MinLength = minLength;
//    }

//    public bool Apply(string data)
//    {
//        return data.Length >= MinLength;
//    }
//}


//54
//public interface ISorter<T>
//{
//    void Sort(List<T> data);
//}

//public class QuickSorter : ISorter<int>
//{
//    public void Sort(List<int> data)
//    {
//        data.Sort();
//        Console.WriteLine("Сортировка выполнена.");
//    }
//}


//55
//public interface IBuilder
//{
//    void BuildPartA();
//    void BuildPartB();
//}

//public class ConcreteBuilder : IBuilder
//{
//    public void BuildPartA()
//    {
//        Console.WriteLine("Построение части A.");
//    }

//    public void BuildPartB()
//    {
//        Console.WriteLine("Построение части B.");
//    }
//}


//56
//public interface IStrategy
//{
//    void Execute();
//}

//public class ConcreteStrategyA : IStrategy
//{
//    public void Execute()
//    {
//        Console.WriteLine("Выполнение стратегии A.");
//    }
//}


//57
//public interface IAdapter
//{
//    void Request();
//}

//public class ConcreteAdapter : IAdapter
//{
//    public void Request()
//    {
//        Console.WriteLine("Адаптация запроса.");
//    }
//}


//58
//public interface IObserver
//{
//    void Update(string message);
//}

//public interface IObservable
//{
//    void Attach(IObserver observer);
//    void Detach(IObserver observer);
//    void NotifyObservers();
//}

//public class ConcreteObservable : IObservable
//{
//    private List<IObserver> observers = new List<IObserver>();

//    public void Attach(IObserver observer)
//    {
//        observers.Add(observer);
//    }

//    public void Detach(IObserver observer)
//    {
//        observers.Remove(observer);
//    }

//    public void NotifyObservers()
//    {
//        foreach (var observer in observers)
//        {
//            observer.Update("Сообщение от наблюдаемого объекта.");
//        }
//    }
//}

//public class ConcreteObserver : IObserver
//{
//    public void Update(string message)
//    {
//        Console.WriteLine($"Получено сообщение: {message}");
//    }
//}


//59
//public interface ICommand
//{
//    void Execute();
//}

//public class ConcreteCommand : ICommand
//{
//    public void Execute()
//    {
//        Console.WriteLine("Выполнение команды.");
//    }
//}


//60
//public interface IFactory<T>
//{
//    T Create();
//}

//public class ConcreteFactory : IFactory<string>
//{
//    public string Create()
//    {
//        return "Новый объект";
//    }
//}


//61
//public interface IConnection
//{
//    void Open();
//    void Close();
//}

//public class DatabaseConnection : IConnection
//{
//    public void Open()
//    {
//        Console.WriteLine("Открытие соединения с базой данных.");
//    }

//    public void Close()
//    {
//        Console.WriteLine("Закрытие соединения с базой данных.");
//    }
//}


//62
//public interface ICache<TKey, TValue>
//{
//    void Add(TKey key, TValue value);
//    TValue Get(TKey key);
//}

//public class MemoryCache<TKey, TValue> : ICache<TKey, TValue>
//{
//    private Dictionary<TKey, TValue> cache = new Dictionary<TKey, TValue>();

//    public void Add(TKey key, TValue value)
//    {
//        cache[key] = value;
//    }

//    public TValue Get(TKey key)
//    {
//        return cache.ContainsKey(key) ? cache[key] : default(TValue);
//    }
//}


//63
//public interface IAuthentication
//{
//    bool Authenticate(string username, string password);
//}

//public class SimpleAuthentication : IAuthentication
//{
//    public bool Authenticate(string username, string password)
//    {
//        return username == "admin" && password == "password";
//    }
//}


//64
//public interface IAuthorization
//{
//    bool Authorize(string role);
//}

//public class SimpleAuthorization : IAuthorization
//{
//    public bool Authorize(string role)
//    {
//        return role == "Admin";
//    }
//}


//65
//public interface ILogger
//{
//    void Log(string message);
//}

//public interface INotifier
//{
//    void Notify(string message);
//}

//public class LoggerNotifier : ILogger, INotifier
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Логирование: {message}");
//    }

//    public void Notify(string message)
//    {
//        Console.WriteLine($"Уведомление: {message}");
//    }
//}


//66
//public interface IExample
//{
//    string Name { get; set; }
//    void DoSomething();
//}

//public class Example : IExample
//{
//    public string Name { get; set; }

//    public void DoSomething()
//    {
//        Console.WriteLine($"Выполнение действия для {Name}.");
//    }
//}


//67
//public interface IExample
//{
//    void Show();
//}

//public class Example : IExample
//{
//    public void Show()
//    {
//        Console.WriteLine("Неявная реализация интерфейса.");
//    }
//}


//68
//public interface IExample
//{
//    void Show();
//}

//public class Example : IExample
//{
//    void IExample.Show()
//    {
//        Console.WriteLine("Явная реализация интерфейса.");
//    }
//}


//69
//public interface IBaseInterface
//{
//    void BaseMethod();
//}

//public interface IDerivedInterface : IBaseInterface
//{
//    void DerivedMethod();
//}

//public class Example : IDerivedInterface
//{
//    public void BaseMethod()
//    {
//        Console.WriteLine("Метод базового интерфейса.");
//    }

//    public void DerivedMethod()
//    {
//        Console.WriteLine("Метод производного интерфейса.");
//    }
//}


//70
//public interface IExample
//{
//    void Show()
//    {
//        Console.WriteLine("Метод по умолчанию.");
//    }
//}

//public class Example : IExample
//{
//    // Метод по умолчанию можно не реализовывать
//}


//71
//public interface ILogger
//{
//    void Log(string message);
//}

//public class ConsoleLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Логирование: {message}");
//    }
//}

//public class MyService
//{
//    private readonly ILogger logger;

//    public MyService(ILogger logger)
//    {
//        this.logger = logger;
//    }

//    public void DoWork()
//    {
//        logger.Log("Выполнение работы.");
//    }
//}


//72
//public interface ILogger
//{
//    void Log(string message);
//}

//public class FileLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Логирование в файл: {message}");
//    }
//}

//public class MyClass
//{
//    private readonly ILogger logger;

//    public MyClass(ILogger logger)
//    {
//        this.logger = logger;
//    }

//    public void DoSomething()
//    {
//        logger.Log("Выполнение действия.");
//    }
//}


//73
//public interface ILogger
//{
//    void Log(string message);
//}

//public interface INotifier
//{
//    void Notify(string message);
//}

//public class FileLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Логирование в файл: {message}");
//    }
//}

//public class EmailNotifier : INotifier
//{
//    public void Notify(string message)
//    {
//        Console.WriteLine($"Отправка уведомления: {message}");
//    }
//}

//public class MyService
//{
//    private readonly ILogger logger;
//    private readonly INotifier notifier;

//    public MyService(ILogger logger, INotifier notifier)
//    {
//        this.logger = logger;
//        this.notifier = notifier;
//    }

//    public void DoWork()
//    {
//        logger.Log("Выполнение работы.");
//        notifier.Notify("Работа завершена.");
//    }
//}


//74
//public class SimpleDIContainer
//{
//    private Dictionary<Type, object> services = new Dictionary<Type, object>();

//    public void Register<T>(T service)
//    {
//        services[typeof(T)] = service;
//    }

//    public T Resolve<T>()
//    {
//        return (T)services[typeof(T)];
//    }
//}

//// Использование
//var container = new SimpleDIContainer();
//container.Register(new FileLogger());
//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//75
//public interface ILogger
//{
//    void Log(string message);
//}

//public class MyService
//{
//    public ILogger Logger { get; set; }

//    public void DoWork()
//    {
//        Logger?.Log("Выполнение работы.");
//    }
//}

//// Использование
//var service = new MyService();
//service.Logger = new FileLogger();
//service.DoWork();


//76
//public interface ILogger
//{
//    void Log(string message);
//}

//public class FileLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Логирование в файл: {message}");
//    }
//}

//public class LoggerFactory
//{
//    public ILogger CreateLogger()
//    {
//        return new FileLogger();
//    }
//}

//// Использование
//var factory = new LoggerFactory();
//ILogger logger = factory.CreateLogger();
//logger.Log("Привет, мир!");


//77
//public class SingletonDIContainer
//{
//    private Dictionary<Type, object> services = new Dictionary<Type, object>();

//    public void RegisterSingleton<T>(T service)
//    {
//        services[typeof(T)] = service;
//    }

//    public T Resolve<T>()
//    {
//        return (T)services[typeof(T)];
//    }
//}

//// Использование
//var container = new SingletonDIContainer();
//container.RegisterSingleton(new FileLogger());
//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//78
//public class TransientDIContainer
//{
//    private Dictionary<Type, Func<object>> services = new Dictionary<Type, Func<object>>();

//    public void RegisterTransient<T>(Func<T> factory)
//    {
//        services[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        return (T)services[typeof(T)]();
//    }
//}

//// Использование
//var container = new TransientDIContainer();
//container.RegisterTransient<ILogger>(() => new FileLogger());
//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//79
//public class AutoRegisterDIContainer
//{
//    private Dictionary<Type, Type> services = new Dictionary<Type, Type>();

//    public void Register<TInterface, TImplementation>()
//    {
//        services[typeof(TInterface)] = typeof(TImplementation);
//    }

//    public T Resolve<T>()
//    {
//        var type = services[typeof(T)];
//        return (T)Activator.CreateInstance(type);
//    }
//}

//// Использование
//var container = new AutoRegisterDIContainer();
//container.Register<ILogger, FileLogger>();
//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//80
//public interface ILogger
//{
//    void Log(string message);
//}

//public interface INotifier
//{
//    void Notify(string message);
//}

//public class FileLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Логирование в файл: {message}");
//    }
//}

//public class EmailNotifier : INotifier
//{
//    public void Notify(string message)
//    {
//        Console.WriteLine($"Отправка уведомления: {message}");
//    }
//}

//public class MyService
//{
//    private readonly ILogger logger;
//    private readonly INotifier notifier;

//    public MyService(ILogger logger, INotifier notifier)
//    {
//        this.logger = logger;
//        this.notifier = notifier;
//    }

//    public void DoWork()
//    {
//        logger.Log("Выполнение работы.");
//        notifier.Notify("Работа завершена.");
//    }
//}

//public class DIContainer
//{
//    private Dictionary<Type, object> services = new Dictionary<Type, object>();

//    public void Register<T>(T service)
//    {
//        services[typeof(T)] = service;
//    }

//    public T Resolve<T>()
//    {
//        return (T)services[typeof(T)];
//    }
//}

//// Использование
//var container = new DIContainer();
//container.Register(new FileLogger());
//container.Register(new EmailNotifier());

//var logger = container.Resolve<ILogger>();
//var notifier = container.Resolve<INotifier>();

//var service = new MyService(logger, notifier);
//service.DoWork();


//81
//public class CyclicDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//public interface IServiceA { void DoWork(); }
//public interface IServiceB { void DoWork(); }

//public class ServiceA : IServiceA
//{
//    private readonly Lazy<IServiceB> _serviceB;

//    public ServiceA(Lazy<IServiceB> serviceB)
//    {
//        _serviceB = serviceB;
//    }

//    public void DoWork()
//    {
//        Console.WriteLine("ServiceA работает.");
//        _serviceB.Value.DoWork();
//    }
//}

//public class ServiceB : IServiceB
//{
//    private readonly Lazy<IServiceA> _serviceA;

//    public ServiceB(Lazy<IServiceA> serviceA)
//    {
//        _serviceA = serviceA;
//    }

//    public void DoWork()
//    {
//        Console.WriteLine("ServiceB работает.");
//        _serviceA.Value.DoWork();
//    }
//}

//// Регистрация
//var container = new CyclicDIContainer();
//container.Register<IServiceA>(() => new ServiceA(new Lazy<IServiceB>(() => container.Resolve<IServiceB>())));
//container.Register<IServiceB>(() => new ServiceB(new Lazy<IServiceA>(() => container.Resolve<IServiceA>())));

//// Разрешение
//var serviceA = container.Resolve<IServiceA>();
//serviceA.DoWork();


//82
//public interface ILogger
//{
//    void Log(string message);
//}

//public class ConsoleLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Лог: {message}");
//    }
//}

//public class MyService
//{
//    private ILogger _logger;

//    public void SetLogger(ILogger logger)
//    {
//        _logger = logger;
//    }

//    public void DoWork()
//    {
//        _logger.Log("Выполнение работы.");
//    }
//}

//// Использование
//var service = new MyService();
//service.SetLogger(new ConsoleLogger());
//service.DoWork();


//83
//public static class ServiceLocator
//{
//    private static readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

//    public static void Register<T>(T service)
//    {
//        _services[typeof(T)] = service;
//    }

//    public static T Resolve<T>()
//    {
//        return (T)_services[typeof(T)];
//    }
//}

//// Пример использования
//ServiceLocator.Register<ILogger>(new ConsoleLogger());
//var logger = ServiceLocator.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//84
//public class ParametrizedDIContainer
//{
//    private readonly Dictionary<Type, Func<object[], object>> _factories = new Dictionary<Type, Func<object[], object>>();

//    public void Register<T>(Func<object[], T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>(params object[] args)
//    {
//        return (T)_factories[typeof(T)](args);
//    }
//}

//// Пример использования
//public class MyService
//{
//    private readonly string _name;

//    public MyService(string name)
//    {
//        _name = name;
//    }

//    public void DoWork()
//    {
//        Console.WriteLine($"Работает сервис {_name}.");
//    }
//}

//var container = new ParametrizedDIContainer();
//container.Register<MyService>(args => new MyService((string)args[0]));

//var service = container.Resolve<MyService>("MyService");
//service.DoWork();


//85
//public class GenericDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//public interface IRepository<T>
//{
//    void Add(T item);
//}

//public class UserRepository : IRepository<string>
//{
//    public void Add(string user)
//    {
//        Console.WriteLine($"Добавлен пользователь: {user}");
//    }
//}

//var container = new GenericDIContainer();
//container.Register<IRepository<string>>(() => new UserRepository());

//var repository = container.Resolve<IRepository<string>>();
//repository.Add("Иван");


//86
//public class DecoratorDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }

//    public void Decorate<TInterface, TDecorator>() where TDecorator : TInterface
//    {
//        var originalFactory = _factories[typeof(TInterface)];
//        _factories[typeof(TInterface)] = () =>
//        {
//            var original = originalFactory();
//            return Activator.CreateInstance(typeof(TDecorator), original);
//        };
//    }
//}

//// Пример использования
//public interface ILogger
//{
//    void Log(string message);
//}

//public class ConsoleLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Лог: {message}");
//    }
//}

//public class TimedLogger : ILogger
//{
//    private readonly ILogger _logger;

//    public TimedLogger(ILogger logger)
//    {
//        _logger = logger;
//    }

//    public void Log(string message)
//    {
//        Console.WriteLine($"Время: {DateTime.Now}");
//        _logger.Log(message);
//    }
//}

//var container = new DecoratorDIContainer();
//container.Register<ILogger>(() => new ConsoleLogger());
//container.Decorate<ILogger, TimedLogger>();

//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//87
//public class InterceptorDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();
//    private readonly List<Func<object, object, object>> _interceptors = new List<Func<object, object, object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public void AddInterceptor(Func<object, object, object> interceptor)
//    {
//        _interceptors.Add(interceptor);
//    }

//    public T Resolve<T>()
//    {
//        var instance = _factories[typeof(T)]();
//        foreach (var interceptor in _interceptors)
//        {
//            instance = interceptor(instance, null);
//        }
//        return (T)instance;
//    }
//}

//// Пример использования
//var container = new InterceptorDIContainer();
//container.Register<ILogger>(() => new ConsoleLogger());
//container.AddInterceptor((instance, context) =>
//{
//    Console.WriteLine("Перед вызовом метода.");
//    return instance;
//});

//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//88
//public class FactoryDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//public interface ILoggerFactory
//{
//    ILogger CreateLogger();
//}

//public class ConsoleLoggerFactory : ILoggerFactory
//{
//    public ILogger CreateLogger()
//    {
//        return new ConsoleLogger();
//    }
//}

//var container = new FactoryDIContainer();
//container.Register<ILoggerFactory>(() => new ConsoleLoggerFactory());

//var factory = container.Resolve<ILoggerFactory>();
//var logger = factory.CreateLogger();
//logger.Log("Привет, мир!");


//89
//public class StackTraceDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = () =>
//        {
//            try
//            {
//                return factory();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка при создании {typeof(T).Name}: {ex}");
//                throw;
//            }
//        };
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//var container = new StackTraceDIContainer();
//container.Register<ILogger>(() => new ConsoleLogger());

//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//90
//public class ProfilingDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = () =>
//        {
//            var stopwatch = Stopwatch.StartNew();
//            var instance = factory();
//            stopwatch.Stop();
//            Console.WriteLine($"Создание {typeof(T).Name} заняло {stopwatch.ElapsedMilliseconds} мс.");
//            return instance;
//        };
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//var container = new ProfilingDIContainer();
//container.Register<ILogger>(() => new ConsoleLogger());

//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//91
//public class HierarchicalDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();
//    private readonly HierarchicalDIContainer _parent;

//    public HierarchicalDIContainer(HierarchicalDIContainer parent = null)
//    {
//        _parent = parent;
//    }

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        if (_factories.TryGetValue(typeof(T), out var factory))
//        {
//            return (T)factory();
//        }
//        return _parent?.Resolve<T>();
//    }
//}

//// Пример использования
//var parentContainer = new HierarchicalDIContainer();
//parentContainer.Register<ILogger>(() => new ConsoleLogger());

//var childContainer = new HierarchicalDIContainer(parentContainer);
//childContainer.Register<ILogger>(() => new FileLogger());

//var logger = childContainer.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//92
//public class MockDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//public interface ILogger
//{
//    void Log(string message);
//}

//public class MockLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Мок: {message}");
//    }
//}

//var container = new MockDIContainer();
//container.Register<ILogger>(() => new MockLogger());

//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//93
//public class ConfigurableDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();
//    private readonly Dictionary<string, object> _config = new Dictionary<string, object>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public void SetConfig(string key, object value)
//    {
//        _config[key] = value;
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }

//    public object GetConfig(string key)
//    {
//        return _config[key];
//    }
//}

//// Пример использования
//var container = new ConfigurableDIContainer();
//container.SetConfig("LogLevel", "Debug");
//container.Register<ILogger>(() => new ConsoleLogger());

//var logger = container.Resolve<ILogger>();
//logger.Log($"Уровень логирования: {container.GetConfig("LogLevel")}");


//94
//public class PluginDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public void LoadPlugins(string pluginPath)
//    {
//        // Загрузка плагинов из указанной директории
//        Console.WriteLine($"Загрузка плагинов из {pluginPath}");
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//var container = new PluginDIContainer();
//container.LoadPlugins("./plugins");
//container.Register<ILogger>(() => new ConsoleLogger());

//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//95
//[AttributeUsage(AttributeTargets.Class)]
//public class ServiceAttribute : Attribute { }

//public class AttributeDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void RegisterAssembly(Assembly assembly)
//    {
//        foreach (var type in assembly.GetTypes())
//        {
//            if (type.GetCustomAttribute<ServiceAttribute>() != null)
//            {
//                _factories[type] = () => Activator.CreateInstance(type);
//            }
//        }
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//[Service]
//public class ConsoleLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Лог: {message}");
//    }
//}

//var container = new AttributeDIContainer();
//container.RegisterAssembly(Assembly.GetExecutingAssembly());

//var logger = container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//96
//public class AsyncDIContainer
//{
//    private readonly Dictionary<Type, Func<Task<object>>> _factories = new Dictionary<Type, Func<Task<object>>>();

//    public void Register<T>(Func<Task<T>> factory)
//    {
//        _factories[typeof(T)] = async () => await factory();
//    }

//    public async Task<T> Resolve<T>()
//    {
//        return (T)await _factories[typeof(T)]();
//    }
//}

//// Пример использования
//public class AsyncLogger : ILogger
//{
//    public async Task InitAsync()
//    {
//        await Task.Delay(100);
//    }

//    public void Log(string message)
//    {
//        Console.WriteLine($"Лог: {message}");
//    }
//}

//var container = new AsyncDIContainer();
//container.Register<ILogger>(async () =>
//{
//    var logger = new AsyncLogger();
//    await logger.InitAsync();
//    return logger;
//});

//var logger = await container.Resolve<ILogger>();
//logger.Log("Привет, мир!");


//97
//public class ChainedDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//public class ServiceA
//{
//    public ServiceA(ServiceB serviceB)
//    {
//        Console.WriteLine("Создан ServiceA");
//    }
//}

//public class ServiceB
//{
//    public ServiceB(ServiceC serviceC)
//    {
//        Console.WriteLine("Создан ServiceB");
//    }
//}

//public class ServiceC
//{
//    public ServiceC()
//    {
//        Console.WriteLine("Создан ServiceC");
//    }
//}

//var container = new ChainedDIContainer();
//container.Register<ServiceC>(() => new ServiceC());
//container.Register<ServiceB>(() => new ServiceB(container.Resolve<ServiceC>()));
//container.Register<ServiceA>(() => new ServiceA(container.Resolve<ServiceB>()));

//var serviceA = container.Resolve<ServiceA>();


//98
//public class MicroserviceDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        return (T)_factories[typeof(T)]();
//    }
//}

//// Пример использования
//public interface IOrderService
//{
//    void ProcessOrder();
//}

//public class OrderService : IOrderService
//{
//    public void ProcessOrder()
//    {
//        Console.WriteLine("Обработка заказа.");
//    }
//}

//var container = new MicroserviceDIContainer();
//container.Register<IOrderService>(() => new OrderService());

//var orderService = container.Resolve<IOrderService>();
//orderService.ProcessOrder();


//99
//public class VersionedDIContainer
//{
//    private readonly Dictionary<(Type, int), Func<object>> _factories = new Dictionary<(Type, int), Func<object>>();

//    public void Register<T>(int version, Func<T> factory)
//    {
//        _factories[(typeof(T), version)] = factory;
//    }

//    public T Resolve<T>(int version)
//    {
//        return (T)_factories[(typeof(T), version)]();
//    }
//}

//// Пример использования
//public interface ILogger
//{
//    void Log(string message);
//}

//public class LoggerV1 : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Лог V1: {message}");
//    }
//}

//public class LoggerV2 : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Лог V2: {message}");
//    }
//}

//var container = new VersionedDIContainer();
//container.Register<ILogger>(1, () => new LoggerV1());
//container.Register<ILogger>(2, () => new LoggerV2());

//var loggerV1 = container.Resolve<ILogger>(1);
//loggerV1.Log("Привет, мир!");

//var loggerV2 = container.Resolve<ILogger>(2);
//loggerV2.Log("Привет, мир!");


//100
//public class BackupDIContainer
//{
//    private readonly Dictionary<Type, Func<object>> _factories = new Dictionary<Type, Func<object>>();
//    private readonly Dictionary<Type, object> _backup = new Dictionary<Type, object>();

//    public void Register<T>(Func<T> factory)
//    {
//        _factories[typeof(T)] = factory;
//    }

//    public T Resolve<T>()
//    {
//        if (!_backup.TryGetValue(typeof(T), out var backupInstance))
//        {
//            backupInstance = _factories[typeof(T)]();
//            _backup[typeof(T)] = backupInstance;
//        }
//        return (T)backupInstance;
//    }
//}

//// Пример использования
//public class MyService
//{
//    public void DoWork()
//    {
//        Console.WriteLine("Выполнение работы.");
//    }
//}

//var container = new BackupDIContainer();
//container.Register<MyService>(() => new MyService());

//var service = container.Resolve<MyService>();
//service.DoWork();
