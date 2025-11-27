using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

// Фабрика объектов
public class ObjectFactory
{
    private static readonly Dictionary<string, Type> _typeCache = new Dictionary<string, Type>();
    private static readonly Dictionary<string, object> _singletonCache = new Dictionary<string, object>();

    public object CreateInstance(string typeName, params object[] args)
    {
        try
        {
            Type type = GetTypeFromCacheOrLoad(typeName);
            return Activator.CreateInstance(type, args);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Ошибка при создании экземпляра типа {typeName}: {ex.Message}");
        }
    }

    public object CreateAndInitialize(string typeName, Dictionary<string, object> properties)
    {
        try
        {
            Type type = GetTypeFromCacheOrLoad(typeName);
            object instance = Activator.CreateInstance(type);

            foreach (var prop in properties)
            {
                PropertyInfo propertyInfo = type.GetProperty(prop.Key, BindingFlags.Public | BindingFlags.Instance);
                if (propertyInfo != null && propertyInfo.CanWrite)
                    propertyInfo.SetValue(instance, prop.Value);
                else
                    throw new ArgumentException($"Свойство {prop.Key} не найдено или недоступно для записи в типе {typeName}.");
            }

            return instance;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Ошибка при инициализации экземпляра типа {typeName}: {ex.Message}");
        }
    }

    public void RegisterSingleton(string name, object instance)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException(nameof(name));
        if (instance == null)
            throw new ArgumentNullException(nameof(instance));

        _singletonCache[name] = instance;
    }

    public object GetSingleton(string name)
    {
        if (_singletonCache.TryGetValue(name, out object instance))
            return instance;
        throw new KeyNotFoundException($"Синглтон с именем {name} не найден.");
    }

    public object CreateFromAssembly(Assembly assembly, string typeName, params object[] args)
    {
        try
        {
            Type type = assembly.GetTypes().FirstOrDefault(t => t.Name == typeName || t.FullName == typeName);
            if (type == null)
                throw new TypeLoadException($"Тип {typeName} не найден в сборке.");
            return Activator.CreateInstance(type, args);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Ошибка при создании экземпляра типа {typeName} из сборки: {ex.Message}");
        }
    }

    private Type GetTypeFromCacheOrLoad(string typeName)
    {
        if (_typeCache.TryGetValue(typeName, out Type type))
            return type;

        type = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .FirstOrDefault(t => t.Name == typeName || t.FullName == typeName);

        if (type == null)
            throw new TypeLoadException($"Тип {typeName} не найден.");

        _typeCache[typeName] = type;
        return type;
    }
}

// Примеры классов для тестирования
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person() { }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"{Name}, {Age} лет";
}

public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public override string ToString() => $"{Model} ({Year})";
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book() { }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString() => $"{Title} by {Author}";
}

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"({X}, {Y})";
}

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle() { }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString() => $"{Width}x{Height}";
}

public class Logger
{
    public void Log(string message) => Console.WriteLine($"LOG: {message}");
}

public class DatabaseConnection
{
    public string ConnectionString { get; set; }

    public DatabaseConnection(string connectionString)
    {
        ConnectionString = connectionString;
    }

    public override string ToString() => $"Connection: {ConnectionString}";
}

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User() { }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public override string ToString() => $"User: {Username}";
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"{Name} (${Price})";
}

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public Order() { }

    public Order(int id, DateTime date)
    {
        Id = id;
        Date = date;
    }

    public override string ToString() => $"Order #{Id} from {Date:d}";
}

// Тестирование
class Program
{
    static void Main()
    {
        var factory = new ObjectFactory();

        var person1 = factory.CreateInstance("Person", "Иван", 30);
        Console.WriteLine($"1. {person1}");

        var personProps = new Dictionary<string, object> { { "Name", "Мария" }, { "Age", 25 } };
        var person2 = factory.CreateAndInitialize("Person", personProps);
        Console.WriteLine($"2. {person2}");

        var car = factory.CreateInstance("Car", "Toyota Camry", 2020);
        Console.WriteLine($"3. {car}");

        var book = factory.CreateInstance("Book", "Война и мир", "Л. Н. Толстой");
        Console.WriteLine($"4. {book}");

        var point = factory.CreateInstance("Point", 10, 20);
        Console.WriteLine($"5. {point}");

        var rectProps = new Dictionary<string, object> { { "Width", 100 }, { "Height", 50 } };
        var rectangle = factory.CreateAndInitialize("Rectangle", rectProps);
        Console.WriteLine($"6. {rectangle}");

        factory.RegisterSingleton("Logger", new Logger());
        var logger = factory.GetSingleton("Logger") as Logger;
        logger.Log("Это тестовое сообщение");

        var dbConnection = factory.CreateInstance("DatabaseConnection", "Server=myServer;Database=myDB;");
        Console.WriteLine($"8. {dbConnection}");

        var userProps = new Dictionary<string, object> { { "Username", "ivan2004" }, { "Password", "12345" } };
        var user = factory.CreateAndInitialize("User", userProps);
        Console.WriteLine($"9. {user}");

        var product = factory.CreateInstance("Product", "Ноутбук", 999.99m);
        Console.WriteLine($"10. {product}");
    }
}

