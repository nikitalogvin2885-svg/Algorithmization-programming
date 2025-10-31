//1
//using System;

//partial class Person
//{
//    private string name;
//    private int age;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int Age
//    {
//        get { return age; }
//        set { age = value; }
//    }
//}

//partial class Person
//{
//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
//    }
//}


//2
//using System;

//partial class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }
//}

//partial class Calculator
//{
//    public int Subtract(int a, int b)
//    {
//        return a - b;
//    }
//}


//3
//using System;

//partial class Customer
//{
//    private string name;

//    public Customer(string name)
//    {
//        this.name = name;
//    }

//    public void DisplayPhysicalInfo()
//    {
//        Console.WriteLine($"Имя клиента: {name}");
//    }
//}

//partial class Customer
//{
//    public void ApplyDiscount(double price, double discountRate)
//    {
//        double discountedPrice = price * (1 - discountRate);
//        Console.WriteLine($"Цена со скидкой: {discountedPrice:C}");
//    }
//}


//4
//using System;

//partial class Product
//{
//    public string Name { get; set; }
//    public double Price { get; set; }
//}

//partial class Product
//{
//    public double CalculateTotalPrice(int quantity)
//    {
//        return Price * quantity;
//    }
//}


//5
//using System;

//partial class Student
//{
//    private string name;
//    private int age;

//    public Student(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//}

//partial class Student
//{
//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Студент: {name}, Возраст: {age}");
//    }
//}


//6
//using System;

//partial class Employee
//{
//    private string name;
//    private double salary;

//    public Employee(string name, double salary)
//    {
//        this.name = name;
//        this.salary = salary;
//    }
//}

//partial class Employee
//{
//    public void CalculateAnnualSalary()
//    {
//        Console.WriteLine($"Годовая зарплата: {salary * 12:C}");
//    }
//}


//7
//using System;

//partial class Rectangle
//{
//    public int Width { get; set; }
//    public int Height { get; set; }
//}

//partial class Rectangle
//{
//    public int CalculateArea()
//    {
//        return Width * Height;
//    }
//}


//8
//using System;

//partial class BankAccount
//{
//    private double balance;

//    public BankAccount(double initialBalance)
//    {
//        balance = initialBalance;
//    }

//    public void Deposit(double amount)
//    {
//        balance += amount;
//    }
//}

//partial class BankAccount
//{
//    public void LogBalance()
//    {
//        Console.WriteLine($"Текущий баланс: {balance:C}");
//    }
//}


//9
//using System;

//partial class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//}

//partial class Book
//{
//    public void DisplayBookInfo()
//    {
//        Console.WriteLine($"Книга: {Title}, Автор: {Author}");
//    }
//}


//10
//using System;

//partial class Car
//{
//    public string Model { get; set; }
//    public int Year { get; set; }
//}

//partial class Car
//{
//    public void DisplayCarInfo()
//    {
//        Console.WriteLine($"Автомобиль: {Model}, Год выпуска: {Year}");
//    }
//}


//11
//using System;

//partial class House
//{
//    public int NumberOfRooms { get; set; }
//    public double Area { get; set; }
//}

//partial class House
//{
//    public void DisplayHouseInfo()
//    {
//        Console.WriteLine($"Дом: {NumberOfRooms} комнат, Площадь: {Area} м²");
//    }
//}


//12
//using System;

//partial class Game
//{
//    public string Name { get; set; }
//}

//partial class Game
//{
//    public void StartGame()
//    {
//        Console.WriteLine($"Игра {Name} началась!");
//    }
//}


//13
//using System;

//partial class Database
//{
//    public void Connect()
//    {
//        Console.WriteLine("Подключение к базе данных...");
//    }
//}

//partial class Database
//{
//    public void Query(string sql)
//    {
//        Console.WriteLine($"Выполняется запрос: {sql}");
//    }
//}


//14
//using System;

//partial class Logger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Лог: {message}");
//    }
//}

//partial class Logger
//{
//    public void DisplayLogs()
//    {
//        Console.WriteLine("Отображение всех логов...");
//    }
//}


//15
//using System;

//partial class Configuration
//{
//    public void Load()
//    {
//        Console.WriteLine("Конфигурация загружена.");
//    }
//}

//partial class Configuration
//{
//    public void Save()
//    {
//        Console.WriteLine("Конфигурация сохранена.");
//    }
//}


//16
//using System;

//class Validator
//{
//    private string data;

//    public Validator(string inputData)
//    {
//        data = inputData;
//    }

//    public bool Validate()
//    {
//        Console.WriteLine("Начало валидации...");
//        OnValidation();
//        Console.WriteLine("Валидация завершена.");
//        return true;
//    }

//    partial void OnValidation();

//    private partial void OnValidation()
//    {
//        if (string.IsNullOrEmpty(data))
//        {
//            Console.WriteLine("Ошибка: данные пусты!");
//        }
//        else if (data.Length < 3)
//        {
//            Console.WriteLine("Ошибка: данные слишком короткие!");
//        }
//        else
//        {
//            Console.WriteLine($"✓ Данные валидны: {data}");
//        }
//    }
//}


//17
//using System;

//class Logger
//{
//    public void LogError(string errorMessage)
//    {
//        Console.WriteLine("Обработка ошибки...");
//        OnError(errorMessage);
//    }

//    partial void OnError(string errorMessage);

//    private partial void OnError(string errorMessage)
//    {
//        Console.WriteLine($"Ошибка: {errorMessage}");
//    }
//}


//18
//using System;

//class NotificationObject
//{
//    private string propertyName;

//    public void ChangeProperty(string newPropertyName)
//    {
//        propertyName = newPropertyName;
//        OnPropertyChanged(propertyName);
//    }

//    partial void OnPropertyChanged(string propertyName);

//    private partial void OnPropertyChanged(string propertyName)
//    {
//        Console.WriteLine($"Свойство {propertyName} было изменено.");
//    }
//}


//19
//using System;

//class Application
//{
//    public void Initialize()
//    {
//        Console.WriteLine("Инициализация приложения...");
//        OnInitialize();
//    }

//    partial void OnInitialize();

//    private partial void OnInitialize()
//    {
//        Console.WriteLine("Приложение успешно инициализировано.");
//    }
//}


//20
//using System;

//class DataManager
//{
//    public void LoadData()
//    {
//        Console.WriteLine("Загрузка данных...");
//        OnDataLoaded();
//    }

//    partial void OnDataLoaded();

//    private partial void OnDataLoaded()
//    {
//        Console.WriteLine("Данные успешно загружены.");
//    }
//}


//21
//using System;

//class StateMachine
//{
//    private string currentState;

//    public void ChangeState(string newState)
//    {
//        currentState = newState;
//        OnStateChanged(currentState);
//    }

//    partial void OnStateChanged(string newState);

//    private partial void OnStateChanged(string newState)
//    {
//        Console.WriteLine($"Состояние изменено на: {newState}");
//    }
//}


//22
//using System;

//class Entity
//{
//    public void Save()
//    {
//        Console.WriteLine("Сохранение объекта...");
//        OnBeforeSave();
//    }

//    partial void OnBeforeSave();

//    private partial void OnBeforeSave()
//    {
//        Console.WriteLine("Выполняются действия перед сохранением.");
//    }
//}


//23
//using System;

//class Repository
//{
//    public void Delete(int id)
//    {
//        Console.WriteLine($"Удаление объекта с ID: {id}...");
//        OnAfterDelete(id);
//    }

//    partial void OnAfterDelete(int id);

//    private partial void OnAfterDelete(int id)
//    {
//        Console.WriteLine($"Объект с ID: {id} успешно удален.");
//    }
//}


//24
//using System;

//class DataProcessor
//{
//    public void Process()
//    {
//        Console.WriteLine("Обработка данных...");
//        OnProcessing();
//    }

//    partial void OnProcessing();

//    private partial void OnProcessing()
//    {
//        Console.WriteLine("Данные успешно обработаны.");
//    }
//}


//25
//using System;

//class Connection
//{
//    public void Open()
//    {
//        Console.WriteLine("Открытие соединения...");
//        OnConnectionOpened();
//    }

//    partial void OnConnectionOpened();

//    private partial void OnConnectionOpened()
//    {
//        Console.WriteLine("Соединение успешно открыто.");
//    }
//}


//26
//using System;

//class Authenticator
//{
//    public void Authenticate(string username, string password)
//    {
//        Console.WriteLine($"Попытка аутентификации пользователя {username}...");
//        OnAuthenticationFailed(username);
//    }

//    partial void OnAuthenticationFailed(string username);

//    private partial void OnAuthenticationFailed(string username)
//    {
//        Console.WriteLine($"Аутентификация пользователя {username} не удалась.");
//    }
//}


//27
//using System;

//class Cache
//{
//    public void CheckCache()
//    {
//        Console.WriteLine("Проверка кэша...");
//        OnCacheExpired();
//    }

//    partial void OnCacheExpired();

//    private partial void OnCacheExpired()
//    {
//        Console.WriteLine("Кэш истек.");
//    }
//}


//28
//using System;

//class RetryPolicy
//{
//    public void Retry()
//    {
//        Console.WriteLine("Повторная попытка...");
//        OnRetry();
//    }

//    partial void OnRetry();

//    private partial void OnRetry()
//    {
//        Console.WriteLine("Повторная попытка выполнена.");
//    }
//}


//29
//using System;

//class Request
//{
//    public void Execute()
//    {
//        Console.WriteLine("Выполнение запроса...");
//        OnTimeout();
//    }

//    partial void OnTimeout();

//    private partial void OnTimeout()
//    {
//        Console.WriteLine("Время ожидания запроса истекло.");
//    }
//}


//30
//using System;

//class AsyncTask
//{
//    public void Run()
//    {
//        Console.WriteLine("Запуск асинхронной задачи...");
//        OnCompleted();
//    }

//    partial void OnCompleted();

//    private partial void OnCompleted()
//    {
//        Console.WriteLine("Асинхронная задача завершена.");
//    }
//}

//31
//using System;

//class Circle
//{
//    private readonly double radius;

//    public Circle(double radius)
//    {
//        if (radius <= 0)
//            throw new ArgumentException("Радиус должен быть положительным.");

//        this.radius = radius;
//    }

//    public double Radius
//    {
//        get { return radius; }
//    }

//    public double CalculateArea()
//    {
//        return Math.PI * radius * radius;
//    }
//}


//32
//using System;

//class Point
//{
//    private readonly double x;
//    private readonly double y;

//    public Point(double x, double y)
//    {
//        this.x = x;
//        this.y = y;
//    }

//    public double X
//    {
//        get { return x; }
//    }

//    public double Y
//    {
//        get { return y; }
//    }
//}


//33
//using System;

//class Color
//{
//    private readonly int red;
//    private readonly int green;
//    private readonly int blue;

//    public Color(int red, int green, int blue)
//    {
//        if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255)
//            throw new ArgumentException("Значения RGB должны быть в диапазоне от 0 до 255.");

//        this.red = red;
//        this.green = green;
//        this.blue = blue;
//    }

//    public int Red
//    {
//        get { return red; }
//    }

//    public int Green
//    {
//        get { return green; }
//    }

//    public int Blue
//    {
//        get { return blue; }
//    }
//}


//34
//using System;

//class Vector
//{
//    private readonly double x;
//    private readonly double y;

//    public Vector(double x, double y)
//    {
//        this.x = x;
//        this.y = y;
//    }

//    public double Magnitude
//    {
//        get { return Math.Sqrt(x * x + y * y); }
//    }
//}


//35
//using System;

//class Complex
//{
//    private readonly double real;
//    private readonly double imaginary;

//    public Complex(double real, double imaginary)
//    {
//        this.real = real;
//        this.imaginary = imaginary;
//    }

//    public double Real
//    {
//        get { return real; }
//    }

//    public double Imaginary
//    {
//        get { return imaginary; }
//    }
//}


//36
//using System;

//class Fraction
//{
//    private readonly int numerator;
//    private readonly int denominator;

//    public Fraction(int numerator, int denominator)
//    {
//        if (denominator == 0)
//            throw new ArgumentException("Знаменатель не может быть нулем.");

//        this.numerator = numerator;
//        this.denominator = denominator;
//    }

//    public int Numerator
//    {
//        get { return numerator; }
//    }

//    public int Denominator
//    {
//        get { return denominator; }
//    }
//}


//37
//using System;

//class Date
//{
//    private readonly int day;
//    private readonly int month;
//    private readonly int year;

//    public Date(int day, int month, int year)
//    {
//        if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1)
//            throw new ArgumentException("Некорректная дата.");

//        this.day = day;
//        this.month = month;
//        this.year = year;
//    }

//    public int Day
//    {
//        get { return day; }
//    }

//    public int Month
//    {
//        get { return month; }
//    }

//    public int Year
//    {
//        get { return year; }
//    }
//}


//38
//using System;

//class Time
//{
//    private readonly int hours;
//    private readonly int minutes;
//    private readonly int seconds;

//    public Time(int hours, int minutes, int seconds)
//    {
//        if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
//            throw new ArgumentException("Некорректное время.");

//        this.hours = hours;
//        this.minutes = minutes;
//        this.seconds = seconds;
//    }

//    public int Hours
//    {
//        get { return hours; }
//    }

//    public int Minutes
//    {
//        get { return minutes; }
//    }

//    public int Seconds
//    {
//        get { return seconds; }
//    }
//}


//39
//using System;

//class Money
//{
//    private readonly decimal amount;
//    private readonly string currency;

//    public Money(decimal amount, string currency)
//    {
//        if (amount < 0)
//            throw new ArgumentException("Сумма не может быть отрицательной.");

//        this.amount = amount;
//        this.currency = currency;
//    }

//    public decimal Amount
//    {
//        get { return amount; }
//    }

//    public string Currency
//    {
//        get { return currency; }
//    }
//}


//40
//using System;

//class Range
//{
//    private readonly int min;
//    private readonly int max;

//    public Range(int min, int max)
//    {
//        if (min > max)
//            throw new ArgumentException("Минимальное значение не может быть больше максимального.");

//        this.min = min;
//        this.max = max;
//    }

//    public int Min
//    {
//        get { return min; }
//    }

//    public int Max
//    {
//        get { return max; }
//    }
//}


//41
//using System;

//class Rectangle
//{
//    private readonly double width;
//    private readonly double height;

//    public Rectangle(double width, double height)
//    {
//        if (width <= 0 || height <= 0)
//            throw new ArgumentException("Ширина и высота должны быть положительными.");

//        this.width = width;
//        this.height = height;
//    }

//    public double Width
//    {
//        get { return width; }
//    }

//    public double Height
//    {
//        get { return height; }
//    }
//}


//42
//using System;

//class Triangle
//{
//    private readonly double sideA;
//    private readonly double sideB;
//    private readonly double sideC;

//    public Triangle(double sideA, double sideB, double sideC)
//    {
//        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
//            throw new ArgumentException("Стороны должны быть положительными.");

//        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
//            throw new ArgumentException("Некорректные стороны треугольника.");

//        this.sideA = sideA;
//        this.sideB = sideB;
//        this.sideC = sideC;
//    }

//    public double SideA
//    {
//        get { return sideA; }
//    }

//    public double SideB
//    {
//        get { return sideB; }
//    }

//    public double SideC
//    {
//        get { return sideC; }
//    }
//}


//43
//using System;

//class Coordinates
//{
//    private readonly double latitude;
//    private readonly double longitude;

//    public Coordinates(double latitude, double longitude)
//    {
//        if (latitude < -90 || latitude > 90 || longitude < -180 || longitude > 180)
//            throw new ArgumentException("Некорректные координаты.");

//        this.latitude = latitude;
//        this.longitude = longitude;
//    }

//    public double Latitude
//    {
//        get { return latitude; }
//    }

//    public double Longitude
//    {
//        get { return longitude; }
//    }
//}


//44
//using System;

//class Version
//{
//    private readonly int major;
//    private readonly int minor;
//    private readonly int patch;

//    public Version(int major, int minor, int patch)
//    {
//        if (major < 0 || minor < 0 || patch < 0)
//            throw new ArgumentException("Версия не может содержать отрицательные числа.");

//        this.major = major;
//        this.minor = minor;
//        this.patch = patch;
//    }

//    public int Major
//    {
//        get { return major; }
//    }

//    public int Minor
//    {
//        get { return minor; }
//    }

//    public int Patch
//    {
//        get { return patch; }
//    }
//}


//45
//using System;

//class Interval
//{
//    private readonly double start;
//    private readonly double end;

//    public Interval(double start, double end)
//    {
//        if (start > end)
//            throw new ArgumentException("Начало интервала не может быть больше конца.");

//        this.start = start;
//        this.end = end;
//    }

//    public double Start
//    {
//        get { return start; }
//    }

//    public double End
//    {
//        get { return end; }
//    }
//}


//46
//using System;

//class Matrix
//{
//    private readonly int order;

//    public Matrix(int order)
//    {
//        if (order <= 0)
//            throw new ArgumentException("Размер матрицы должен быть положительным.");

//        this.order = order;
//    }

//    public int Order
//    {
//        get { return order; }
//    }
//}


//47
//using System;

//class Person
//{
//    private readonly DateTime birthDate;

//    public Person(DateTime birthDate)
//    {
//        if (birthDate > DateTime.Now)
//            throw new ArgumentException("Дата рождения не может быть в будущем.");

//        this.birthDate = birthDate;
//    }

//    public DateTime BirthDate
//    {
//        get { return birthDate; }
//    }
//}


//48
//using System;

//class Employee
//{
//    private readonly int employeeID;

//    public Employee(int employeeID)
//    {
//        if (employeeID <= 0)
//            throw new ArgumentException("ID сотрудника должен быть положительным.");

//        this.employeeID = employeeID;
//    }

//    public int EmployeeID
//    {
//        get { return employeeID; }
//    }
//}


//49
//using System;

//class Document
//{
//    private readonly int documentID;
//    private readonly DateTime createdDate;

//    public Document(int documentID)
//    {
//        if (documentID <= 0)
//            throw new ArgumentException("ID документа должен быть положительным.");

//        this.documentID = documentID;
//        this.createdDate = DateTime.Now;
//    }

//    public int DocumentID
//    {
//        get { return documentID; }
//    }

//    public DateTime CreatedDate
//    {
//        get { return createdDate; }
//    }
//}


//50
//using System;

//class ISBN
//{
//    private readonly string code;

//    public ISBN(string code)
//    {
//        if (string.IsNullOrEmpty(code) || code.Length != 10 && code.Length != 13)
//            throw new ArgumentException("Некорректный формат ISBN.");

//        this.code = code;
//    }

//    public string Code
//    {
//        get { return code; }
//    }
//}


//using System.Text.RegularExpressions;

//51
//using System;

//public class BankAccount
//{
//    private decimal balance;
//    private string accountNumber;
//    private string ownerName;

//    public BankAccount(string accountNumber, string ownerName, decimal initialBalance = 0)
//    {
//        if (string.IsNullOrWhiteSpace(accountNumber))
//            throw new ArgumentException("Номер счета не может быть пустым");

//        if (string.IsNullOrWhiteSpace(ownerName))
//            throw new ArgumentException("Имя владельца не может быть пустым");

//        if (initialBalance < 0)
//            throw new ArgumentException("Начальный баланс не может быть отрицательным");

//        this.accountNumber = accountNumber;
//        this.ownerName = ownerName;
//        this.balance = initialBalance;
//    }

//    public decimal GetBalance()
//    {
//        return balance;
//    }

//    public void Deposit(decimal amount)
//    {
//        if (amount <= 0)
//            throw new ArgumentException("Сумма депозита должна быть положительной");

//        balance += amount;
//        Console.WriteLine($"Успешно внесено: {amount:C}. Новый баланс: {balance:C}");
//    }

//    public bool Withdraw(decimal amount)
//    {
//        if (amount <= 0)
//            throw new ArgumentException("Сумма снятия должна быть положительной");

//        if (amount > balance)
//        {
//            Console.WriteLine($"Ошибка: Недостаточно средств. Запрошено: {amount:C}, доступно: {balance:C}");
//            return false;
//        }

//        balance -= amount;
//        Console.WriteLine($"Успешно снято: {amount:C}. Новый баланс: {balance:C}");
//        return true;
//    }

//    public void Transfer(BankAccount targetAccount, decimal amount)
//    {
//        if (targetAccount == null)
//            throw new ArgumentNullException(nameof(targetAccount));

//        if (Withdraw(amount))
//        {
//            targetAccount.Deposit(amount);
//            Console.WriteLine($"Перевод {amount:C} на счет {targetAccount.accountNumber} выполнен успешно");
//        }
//    }

//    public string AccountNumber => accountNumber;
//    public string OwnerName => ownerName;

//    public void DisplayAccountInfo()
//    {
//        Console.WriteLine($"Счет: {accountNumber}");
//        Console.WriteLine($"Владелец: {ownerName}");
//        Console.WriteLine($"Баланс: {balance:C}");
//    }
//}

//class BankAccountDemo
//{
//    static void Main()
//    {
//        try
//        {
//            BankAccount account1 = new BankAccount("1234567890", "Иван Иванов", 1000);
//            BankAccount account2 = new BankAccount("0987654321", "Петр Петров", 500);

//            account1.DisplayAccountInfo();
//            Console.WriteLine();

//            account1.Deposit(250);
//            account1.Withdraw(300);

//            Console.WriteLine();
//            account1.Transfer(account2, 200);

//            Console.WriteLine("\nИтоговое состояние счетов:");
//            account1.DisplayAccountInfo();
//            Console.WriteLine();
//            account2.DisplayAccountInfo();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}

//52
//using System;

//public class Person
//{
//    private string name;
//    private int age;
//    private string idNumber;
//    private DateTime birthDate;

//    public Person(string name, int age, string idNumber, DateTime birthDate)
//    {
//        Name = name;
//        Age = age;
//        IdNumber = idNumber;
//        BirthDate = birthDate;
//    }

//    public string Name
//    {
//        get { return name; }
//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//                throw new ArgumentException("Имя не может быть пустым");

//            if (value.Length < 2)
//                throw new ArgumentException("Имя должно содержать минимум 2 символа");

//            name = value.Trim();
//        }
//    }

//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if (value < 0 || value > 150)
//                throw new ArgumentException("Возраст должен быть от 0 до 150 лет");

//            age = value;
//        }
//    }

//    public string IdNumber
//    {
//        get { return idNumber; }
//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//                throw new ArgumentException("Идентификационный номер не может быть пустым");

//            if (value.Length != 10)
//                throw new ArgumentException("Идентификационный номер должен содержать 10 символов");

//            idNumber = value;
//        }
//    }

//    public DateTime BirthDate
//    {
//        get { return birthDate; }
//        set
//        {
//            if (value > DateTime.Now)
//                throw new ArgumentException("Дата рождения не может быть в будущем");

//            if (DateTime.Now.Year - value.Year > 150)
//                throw new ArgumentException("Дата рождения не может быть более 150 лет назад");

//            birthDate = value;
//        }
//    }

//    public bool IsAdult()
//    {
//        return Age >= 18;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Имя: {Name}");
//        Console.WriteLine($"Возраст: {Age}");
//        Console.WriteLine($"Идентификационный номер: {IdNumber}");
//        Console.WriteLine($"Дата рождения: {BirthDate:dd.MM.yyyy}");
//        Console.WriteLine($"Совершеннолетний: {(IsAdult() ? "Да" : "Нет")}");
//    }
//}

//class PersonDemo
//{
//    static void Main()
//    {
//        try
//        {
//            Person person = new Person("Анна Сидорова", 25, "1234567890", new DateTime(1998, 5, 15));
//            person.DisplayInfo();

//            Console.WriteLine("\nПопытка установки невалидных данных:");
//            try
//            {
//                person.Age = -5;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка возраста: {ex.Message}");
//            }

//            try
//            {
//                person.Name = "А";
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка имени: {ex.Message}");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка создания объекта: {ex.Message}");
//        }
//    }
//}

//53
//using System;
//using System.Text.RegularExpressions;

//public class Password
//{
//    private string password;

//    public Password(string password)
//    {
//        if (!ValidatePassword(password))
//            throw new ArgumentException("Пароль не соответствует требованиям безопасности");

//        this.password = password;
//    }

//    private bool ValidatePassword(string password)
//    {
//        return HasMinimumLength(password) &&
//               HasUpperCase(password) &&
//               HasLowerCase(password) &&
//               HasDigit(password) &&
//               HasSpecialCharacter(password) &&
//               !HasSpaces(password);
//    }

//    private bool HasMinimumLength(string password)
//    {
//        return password.Length >= 8;
//    }

//    private bool HasUpperCase(string password)
//    {
//        return Regex.IsMatch(password, "[A-Z]");
//    }

//    private bool HasLowerCase(string password)
//    {
//        return Regex.IsMatch(password, "[a-z]");
//    }

//    private bool HasDigit(string password)
//    {
//        return Regex.IsMatch(password, "[0-9]");
//    }

//    private bool HasSpecialCharacter(string password)
//    {
//        return Regex.IsMatch(password, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]");
//    }

//    private bool HasSpaces(string password)
//    {
//        return password.Contains(" ");
//    }

//    public bool Verify(string inputPassword)
//    {
//        return password == inputPassword;
//    }

//    public string GetStrength()
//    {
//        int strength = 0;

//        if (password.Length >= 12) strength++;
//        if (Regex.IsMatch(password, "[A-Z]")) strength++;
//        if (Regex.IsMatch(password, "[a-z]")) strength++;
//        if (Regex.IsMatch(password, "[0-9]")) strength++;
//        if (Regex.IsMatch(password, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]")) strength++;

//        return strength switch
//        {
//            <= 2 => "Слабый",
//            3 => "Средний",
//            4 => "Сильный",
//            >= 5 => "Очень сильный",
//            _ => "Неизвестно"
//        };
//    }

//    public void ChangePassword(string oldPassword, string newPassword)
//    {
//        if (!Verify(oldPassword))
//            throw new UnauthorizedAccessException("Старый пароль неверен");

//        if (!ValidatePassword(newPassword))
//            throw new ArgumentException("Новый пароль не соответствует требованиям безопасности");

//        password = newPassword;
//        Console.WriteLine("Пароль успешно изменен");
//    }

//    public bool IsValid => ValidatePassword(password);
//}

//class PasswordDemo
//{
//    static void Main()
//    {
//        try
//        {
//            Password password = new Password("SecurePass123!");
//            Console.WriteLine($"Пароль создан успешно");
//            Console.WriteLine($"Сила пароля: {password.GetStrength()}");
//            Console.WriteLine($"Проверка верного пароля: {password.Verify("SecurePass123!")}");
//            Console.WriteLine($"Проверка неверного пароля: {password.Verify("WrongPass")}");
//            Console.WriteLine("\nПопытка создания слабого пароля:");
//            try
//            {
//                Password weakPassword = new Password("weak");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}

//54
//using System;
//using System.Text.RegularExpressions;

//public class Email
//{
//    private string emailAddress;

//    public Email(string email)
//    {
//        if (!IsValidEmail(email))
//            throw new ArgumentException("Некорректный формат email адреса");

//        emailAddress = email.ToLower();
//    }

//    private bool IsValidEmail(string email)
//    {
//        if (string.IsNullOrWhiteSpace(email))
//            return false;

//        try
//        {
//            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
//        }
//        catch
//        {
//            return false;
//        }
//    }

//    public string Address => emailAddress;

//    public string Username
//    {
//        get
//        {
//            int atIndex = emailAddress.IndexOf('@');
//            return emailAddress.Substring(0, atIndex);
//        }
//    }

//    public string Domain
//    {
//        get
//        {
//            int atIndex = emailAddress.IndexOf('@');
//            return emailAddress.Substring(atIndex + 1);
//        }
//    }

//    public bool IsCorporate()
//    {
//        string[] corporateDomains = { "company.com", "corp.com", "business.com" };
//        return Array.Exists(corporateDomains, domain =>
//            Domain.Equals(domain, StringComparison.OrdinalIgnoreCase));
//    }

//    public void ChangeEmail(string newEmail)
//    {
//        if (!IsValidEmail(newEmail))
//            throw new ArgumentException("Некорректный формат нового email адреса");

//        emailAddress = newEmail.ToLower();
//        Console.WriteLine($"Email успешно изменен на: {emailAddress}");
//    }

//    public override string ToString()
//    {
//        return emailAddress;
//    }

//    public void DisplayEmailInfo()
//    {
//        Console.WriteLine($"Полный адрес: {Address}");
//        Console.WriteLine($"Имя пользователя: {Username}");
//        Console.WriteLine($"Домен: {Domain}");
//        Console.WriteLine($"Корпоративный: {(IsCorporate() ? "Да" : "Нет")}");
//    }
//}

//class EmailDemo
//{
//    static void Main()
//    {
//        try
//        {
//            Email email = new Email("user@example.com");
//            email.DisplayEmailInfo();

//            Console.WriteLine();

//            Email corporateEmail = new Email("employee@company.com");
//            corporateEmail.DisplayEmailInfo();

//            Console.WriteLine("\nПопытка создания некорректного email:");
//            try
//            {
//                Email invalidEmail = new Email("invalid-email");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}

//55
//using System;

//public class Temperature
//{
//    private double celsius;

//    public Temperature()
//    {
//        celsius = 0;
//    }

//    public Temperature(double celsius)
//    {
//        this.celsius = celsius;
//    }

//    private double CelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }

//    private double FahrenheitToCelsius(double fahrenheit)
//    {
//        return (fahrenheit - 32) * 5 / 9;
//    }

//    private double CelsiusToKelvin(double celsius)
//    {
//        return celsius + 273.15;
//    }

//    private double KelvinToCelsius(double kelvin)
//    {
//        return kelvin - 273.15;
//    }

//    public double Celsius
//    {
//        get { return celsius; }
//        set { celsius = value; }
//    }

//    public double Fahrenheit
//    {
//        get { return CelsiusToFahrenheit(celsius); }
//        set { celsius = FahrenheitToCelsius(value); }
//    }

//    public double Kelvin
//    {
//        get { return CelsiusToKelvin(celsius); }
//        set
//        {
//            if (value < 0)
//                throw new ArgumentException("Температура в Кельвинах не может быть отрицательной");

//            celsius = KelvinToCelsius(value);
//        }
//    }

//    public static Temperature FromCelsius(double celsius)
//    {
//        return new Temperature(celsius);
//    }

//    public static Temperature FromFahrenheit(double fahrenheit)
//    {
//        Temperature temp = new Temperature();
//        temp.Fahrenheit = fahrenheit;
//        return temp;
//    }

//    public static Temperature FromKelvin(double kelvin)
//    {
//        Temperature temp = new Temperature();
//        temp.Kelvin = kelvin;
//        return temp;
//    }

//    public string GetWeatherDescription()
//    {
//        return celsius switch
//        {
//            < -20 => "Экстремально холодно",
//            < 0 => "Очень холодно",
//            < 10 => "Холодно",
//            < 20 => "Прохладно",
//            < 25 => "Комфортно",
//            < 30 => "Тепло",
//            < 35 => "Жарко",
//            _ => "Очень жарко"
//        };
//    }

//    public bool IsFreezing => celsius < 0;
//    public bool IsBoiling => celsius >= 100;

//    public void DisplayAllScales()
//    {
//        Console.WriteLine($"Цельсий: {Celsius:F2}°C");
//        Console.WriteLine($"Фаренгейт: {Fahrenheit:F2}°F");
//        Console.WriteLine($"Кельвин: {Kelvin:F2}K");
//        Console.WriteLine($"Описание: {GetWeatherDescription()}");
//        Console.WriteLine($"Замерзание: {(IsFreezing ? "Да" : "Нет")}");
//        Console.WriteLine($"Кипение: {(IsBoiling ? "Да" : "Нет")}");
//    }

//    public static Temperature operator +(Temperature t1, Temperature t2)
//    {
//        return new Temperature(t1.Celsius + t2.Celsius);
//    }

//    public static Temperature operator -(Temperature t1, Temperature t2)
//    {
//        return new Temperature(t1.Celsius - t2.Celsius);
//    }
//}

//class TemperatureDemo
//{
//    static void Main()
//    {
//        try
//        {
//            Temperature temp1 = new Temperature(25);
//            Temperature temp2 = Temperature.FromFahrenheit(77);
//            Temperature temp3 = Temperature.FromKelvin(298.15);

//            Console.WriteLine("Температура 25°C в разных представлениях:");
//            temp1.DisplayAllScales();

//            Console.WriteLine("\nИзменение температуры через свойство Фаренгейт:");
//            temp1.Fahrenheit = 100;
//            temp1.DisplayAllScales();

//            Console.WriteLine("\nРабота с операторами:");
//            Temperature sum = temp1 + temp2;
//            Console.WriteLine($"Сумма температур: {sum.Celsius}°C");

//            Console.WriteLine("\nПопытка установки некорректной температуры в Кельвинах:");
//            try
//            {
//                temp1.Kelvin = -5;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}

//56
//using System;

//class Animal
//{
//    protected string name;
//    protected int age;

//    public Animal(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Животное издает звук");
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Имя: {name}, Возраст: {age} лет");
//    }
//}

//class Dog : Animal
//{
//    private string breed;

//    public Dog(string name, int age, string breed) : base(name, age)
//    {
//        this.breed = breed;
//    }

//    public override void MakeSound()
//    {
//        Console.WriteLine("Гав! Гав!");
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Порода: {breed}");
//    }

//    public void Fetch()
//    {
//        Console.WriteLine($"{name} приносит мяч!");
//    }
//}

//class Program56
//{
//    static void Main()
//    {
//        Animal animal = new Animal("Питомец", 5);
//        animal.MakeSound();
//        animal.DisplayInfo();

//        Console.WriteLine();

//        Dog dog = new Dog("Шарик", 3, "Лабрадор");
//        dog.MakeSound();
//        dog.DisplayInfo();
//        dog.Fetch();
//    }
//}

//57
//using System;

//class Vehicle
//{
//    protected string brand;
//    protected int year;
//    protected double speed;

//    public Vehicle(string brand, int year, double speed)
//    {
//        this.brand = brand;
//        this.year = year;
//        this.speed = speed;
//    }

//    public virtual void Start()
//    {
//        Console.WriteLine($"{brand} запускается");
//    }

//    public virtual void Stop()
//    {
//        Console.WriteLine($"{brand} останавливается");
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Марка: {brand}, Год: {year}, Скорость: {speed} км/ч");
//    }
//}

//class Car : Vehicle
//{
//    private int doors;

//    public Car(string brand, int year, double speed, int doors) : base(brand, year, speed)
//    {
//        this.doors = doors;
//    }

//    public override void Start()
//    {
//        Console.WriteLine($"Автомобиль {brand} заводится ключом");
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Количество дверей: {doors}");
//    }

//    public void Honk()
//    {
//        Console.WriteLine("Би-бип!");
//    }
//}

//class Motorcycle : Vehicle
//{
//    private bool hasSidecar;

//    public Motorcycle(string brand, int year, double speed, bool hasSidecar) : base(brand, year, speed)
//    {
//        this.hasSidecar = hasSidecar;
//    }

//    public override void Start()
//    {
//        Console.WriteLine($"Мотоцикл {brand} заводится кнопкой");
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Есть коляска: {(hasSidecar ? "Да" : "Нет")}");
//    }

//    public void Wheelie()
//    {
//        Console.WriteLine($"{brand} делает вилли!");
//    }
//}

//class Program57
//{
//    static void Main()
//    {
//        Car car = new Car("Toyota", 2022, 180, 4);
//        car.Start();
//        car.DisplayInfo();
//        car.Honk();

//        Console.WriteLine();

//        Motorcycle motorcycle = new Motorcycle("Yamaha", 2023, 220, false);
//        motorcycle.Start();
//        motorcycle.DisplayInfo();
//        motorcycle.Wheelie();
//    }
//}

//58
//using System;

//class Shape
//{
//    protected string color;

//    public Shape(string color)
//    {
//        this.color = color;
//    }

//    public virtual double GetArea()
//    {
//        return 0;
//    }

//    public virtual double GetPerimeter()
//    {
//        return 0;
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Фигура цвета: {color}");
//    }
//}

//class Circle : Shape
//{
//    private double radius;

//    public Circle(string color, double radius) : base(color)
//    {
//        this.radius = radius;
//    }

//    public override double GetArea()
//    {
//        return Math.PI * radius * radius;
//    }

//    public override double GetPerimeter()
//    {
//        return 2 * Math.PI * radius;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Тип: Круг, Радиус: {radius}, Площадь: {GetArea():F2}, Периметр: {GetPerimeter():F2}");
//    }
//}

//class Rectangle : Shape
//{
//    private double width;
//    private double height;

//    public Rectangle(string color, double width, double height) : base(color)
//    {
//        this.width = width;
//        this.height = height;
//    }

//    public override double GetArea()
//    {
//        return width * height;
//    }

//    public override double GetPerimeter()
//    {
//        return 2 * (width + height);
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Тип: Прямоугольник, Ширина: {width}, Высота: {height}, Площадь: {GetArea():F2}, Периметр: {GetPerimeter():F2}");
//    }
//}

//class Program58
//{
//    static void Main()
//    {
//        Circle circle = new Circle("Красный", 5);
//        circle.DisplayInfo();

//        Console.WriteLine();

//        Rectangle rectangle = new Rectangle("Синий", 4, 6);
//        rectangle.DisplayInfo();
//    }
//}

//59
//using System;

//class Employee
//{
//    protected string name;
//    protected double salary;
//    protected string department;

//    public Employee(string name, double salary, string department)
//    {
//        this.name = name;
//        this.salary = salary;
//        this.department = department;
//    }

//    public virtual void Work()
//    {
//        Console.WriteLine($"{name} выполняет свои обязанности");
//    }

//    public virtual void CalculateBonus()
//    {
//        Console.WriteLine($"Бонус {name}: {salary * 0.1:C}");
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Сотрудник: {name}, Зарплата: {salary:C}, Отдел: {department}");
//    }
//}

//class Manager : Employee
//{
//    private int teamSize;

//    public Manager(string name, double salary, string department, int teamSize) : base(name, salary, department)
//    {
//        this.teamSize = teamSize;
//    }

//    public override void Work()
//    {
//        Console.WriteLine($"{name} управляет командой из {teamSize} человек");
//    }

//    public override void CalculateBonus()
//    {
//        Console.WriteLine($"Бонус менеджера {name}: {salary * 0.2 + teamSize * 100:C}");
//    }

//    public void ConductMeeting()
//    {
//        Console.WriteLine($"{name} проводит собрание");
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Должность: Менеджер, Размер команды: {teamSize}");
//    }
//}

//class Developer : Employee
//{
//    private string programmingLanguage;

//    public Developer(string name, double salary, string department, string programmingLanguage) : base(name, salary, department)
//    {
//        this.programmingLanguage = programmingLanguage;
//    }

//    public override void Work()
//    {
//        Console.WriteLine($"{name} пишет код на {programmingLanguage}");
//    }

//    public override void CalculateBonus()
//    {
//        Console.WriteLine($"Бонус разработчика {name}: {salary * 0.15:C}");
//    }

//    public void DebugCode()
//    {
//        Console.WriteLine($"{name} отлаживает код");
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Должность: Разработчик, Язык программирования: {programmingLanguage}");
//    }
//}

//class Program59
//{
//    static void Main()
//    {
//        Manager manager = new Manager("Иван Иванов", 5000, "IT", 5);
//        manager.DisplayInfo();
//        manager.Work();
//        manager.CalculateBonus();
//        manager.ConductMeeting();

//        Console.WriteLine();

//        Developer developer = new Developer("Петр Петров", 4000, "IT", "C#");
//        developer.DisplayInfo();
//        developer.Work();
//        developer.CalculateBonus();
//        developer.DebugCode();
//    }
//}

//60
//using System;

//class Account
//{
//    protected string accountNumber;
//    protected string ownerName;
//    protected decimal balance;

//    public Account(string accountNumber, string ownerName, decimal balance)
//    {
//        this.accountNumber = accountNumber;
//        this.ownerName = ownerName;
//        this.balance = balance;
//    }

//    public virtual void Deposit(decimal amount)
//    {
//        balance += amount;
//        Console.WriteLine($"Внесено: {amount:C}. Новый баланс: {balance:C}");
//    }

//    public virtual bool Withdraw(decimal amount)
//    {
//        if (amount <= balance)
//        {
//            balance -= amount;
//            Console.WriteLine($"Снято: {amount:C}. Новый баланс: {balance:C}");
//            return true;
//        }
//        Console.WriteLine($"Недостаточно средств. Запрошено: {amount:C}, доступно: {balance:C}");
//        return false;
//    }

//    public virtual void CalculateInterest()
//    {
//        Console.WriteLine("Начисление процентов: 0%");
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Счет: {accountNumber}, Владелец: {ownerName}, Баланс: {balance:C}");
//    }
//}

//class SavingsAccount : Account
//{
//    private decimal interestRate;

//    public SavingsAccount(string accountNumber, string ownerName, decimal balance, decimal interestRate)
//        : base(accountNumber, ownerName, balance)
//    {
//        this.interestRate = interestRate;
//    }

//    public override void CalculateInterest()
//    {
//        decimal interest = balance * interestRate / 100;
//        balance += interest;
//        Console.WriteLine($"Начислены проценты: {interest:C} ({interestRate}%). Новый баланс: {balance:C}");
//    }

//    public override bool Withdraw(decimal amount)
//    {
//        if (balance - amount >= 10)
//        {
//            balance -= amount;
//            Console.WriteLine($"Снято: {amount:C}. Новый баланс: {balance:C}");
//            return true;
//        }
//        Console.WriteLine($"Недостаточно средств или нарушено минимальное сальдо. Запрошено: {amount:C}, доступно: {balance:C}");
//        return false;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Тип: Сберегательный, Процентная ставка: {interestRate}%");
//    }
//}

//class CheckingAccount : Account
//{
//    private decimal overdraftLimit;

//    public CheckingAccount(string accountNumber, string ownerName, decimal balance, decimal overdraftLimit)
//        : base(accountNumber, ownerName, balance)
//    {
//        this.overdraftLimit = overdraftLimit;
//    }

//    public override bool Withdraw(decimal amount)
//    {
//        if (amount <= balance + overdraftLimit)
//        {
//            balance -= amount;
//            Console.WriteLine($"Снято: {amount:C}. Новый баланс: {balance:C}");
//            return true;
//        }
//        Console.WriteLine($"Превышен лимит овердрафта. Запрошено: {amount:C}, доступно: {balance + overdraftLimit:C}");
//        return false;
//    }

//    public void WriteCheck(decimal amount)
//    {
//        Console.WriteLine($"Выписан чек на {amount:C} со счета {accountNumber}");
//        Withdraw(amount);
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Тип: Расчетный, Лимит овердрафта: {overdraftLimit:C}");
//    }
//}

//class Program60
//{
//    static void Main()
//    {
//        SavingsAccount savings = new SavingsAccount("SAV123", "Иван Иванов", 1000, 2.5m);
//        savings.DisplayInfo();
//        savings.Deposit(500);
//        savings.CalculateInterest();
//        savings.Withdraw(200);

//        Console.WriteLine();

//        CheckingAccount checking = new CheckingAccount("CHK456", "Петр Петров", 500, 1000);
//        checking.DisplayInfo();
//        checking.WriteCheck(1200);
//        checking.WriteCheck(500);
//    }
//}

//61
//using System;

//class Animal
//{
//    protected string name;

//    public Animal(string name)
//    {
//        this.name = name;
//    }

//    public virtual void MakeSound()
//    {
//        Console.WriteLine($"{name} издает звук");
//    }
//}

//class Dog : Animal
//{
//    public Dog(string name) : base(name) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{name} говорит: Гав-гав!");
//    }
//}

//class Cat : Animal
//{
//    public Cat(string name) : base(name) { }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{name} говорит: Мяу-мяу!");
//    }
//}

//class Program61
//{
//    static void Main()
//    {
//        Animal[] animals = new Animal[]
//        {
//            new Animal("Неизвестное животное"),
//            new Dog("Шарик"),
//            new Cat("Мурка")
//        };

//        foreach (Animal animal in animals)
//        {
//            animal.MakeSound();
//        }
//    }
//}

//62
//using System;

//abstract class Shape
//{
//    protected string color;

//    public Shape(string color)
//    {
//        this.color = color;
//    }

//    public abstract double CalculateArea();

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Фигура цвета: {color}");
//    }
//}

//class Circle : Shape
//{
//    private double radius;

//    public Circle(string color, double radius) : base(color)
//    {
//        this.radius = radius;
//    }

//    public override double CalculateArea()
//    {
//        return Math.PI * radius * radius;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Круг с радиусом {radius}, площадь: {CalculateArea():F2}");
//    }
//}

//class Rectangle : Shape
//{
//    private double width;
//    private double height;

//    public Rectangle(string color, double width, double height) : base(color)
//    {
//        this.width = width;
//        this.height = height;
//    }

//    public override double CalculateArea()
//    {
//        return width * height;
//    }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"Прямоугольник {width}x{height}, площадь: {CalculateArea():F2}");
//    }
//}

//class Program62
//{
//    static void Main()
//    {
//        Shape circle = new Circle("Красный", 5);
//        Shape rectangle = new Rectangle("Синий", 4, 6);

//        circle.DisplayInfo();
//        rectangle.DisplayInfo();
//    }
//}

//63
//using System;

//interface IPayable
//{
//    decimal CalculatePayment();
//    string GetPaymentInfo();
//}

//class Employee : IPayable
//{
//    private string name;
//    private decimal salary;

//    public Employee(string name, decimal salary)
//    {
//        this.name = name;
//        this.salary = salary;
//    }

//    public decimal CalculatePayment()
//    {
//        return salary;
//    }

//    public string GetPaymentInfo()
//    {
//        return $"Сотрудник: {name}, Зарплата: {salary:C}";
//    }
//}

//class Contractor : IPayable
//{
//    private string name;
//    private decimal hourlyRate;
//    private int hoursWorked;

//    public Contractor(string name, decimal hourlyRate, int hoursWorked)
//    {
//        this.name = name;
//        this.hourlyRate = hourlyRate;
//        this.hoursWorked = hoursWorked;
//    }

//    public decimal CalculatePayment()
//    {
//        return hourlyRate * hoursWorked;
//    }

//    public string GetPaymentInfo()
//    {
//        return $"Подрядчик: {name}, Ставка: {hourlyRate:C}/час, Часы: {hoursWorked}, К оплате: {CalculatePayment():C}";
//    }
//}

//class Program63
//{
//    static void Main()
//    {
//        IPayable[] payables = new IPayable[]
//        {
//            new Employee("Иван Иванов", 50000),
//            new Contractor("Петр Петров", 1500, 40)
//        };

//        foreach (IPayable payable in payables)
//        {
//            Console.WriteLine(payable.GetPaymentInfo());
//        }
//    }
//}

//64
//using System;

//class Product
//{
//    protected string name;

//    public Product(string name)
//    {
//        this.name = name;
//    }

//    public virtual decimal Price
//    {
//        get { return 0; }
//        set { }
//    }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Товар: {name}, Цена: {Price:C}");
//    }
//}

//class PhysicalProduct : Product
//{
//    private decimal costPrice;

//    public PhysicalProduct(string name, decimal costPrice) : base(name)
//    {
//        this.costPrice = costPrice;
//    }

//    public override decimal Price
//    {
//        get { return costPrice * 1.2m; }
//        set { costPrice = value / 1.2m; }
//    }

//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Физический товар: {name}, Себестоимость: {costPrice:C}, Цена продажи: {Price:C}");
//    }
//}

//class DigitalProduct : Product
//{
//    private decimal basePrice;

//    public DigitalProduct(string name, decimal basePrice) : base(name)
//    {
//        this.basePrice = basePrice;
//    }

//    public override decimal Price
//    {
//        get { return basePrice * 0.8m; }
//        set { basePrice = value / 0.8m; }
//    }

//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Цифровой товар: {name}, Базовая цена: {basePrice:C}, Цена со скидкой: {Price:C}");
//    }
//}

//class Program64
//{
//    static void Main()
//    {
//        Product[] products = new Product[]
//        {
//            new PhysicalProduct("Книга", 500),
//            new DigitalProduct("Электронная книга", 500)
//        };

//        foreach (Product product in products)
//        {
//            product.DisplayInfo();
//        }
//    }
//}

//65
//using System;

//abstract class Shape
//{
//    public abstract double CalculateArea();
//}

//class Circle : Shape
//{
//    private double radius;

//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }

//    public override double CalculateArea()
//    {
//        return Math.PI * radius * radius;
//    }
//}

//class Rectangle : Shape
//{
//    private double width;
//    private double height;

//    public Rectangle(double width, double height)
//    {
//        this.width = width;
//        this.height = height;
//    }

//    public override double CalculateArea()
//    {
//        return width * height;
//    }
//}

//class Triangle : Shape
//{
//    private double baseLength;
//    private double height;

//    public Triangle(double baseLength, double height)
//    {
//        this.baseLength = baseLength;
//        this.height = height;
//    }

//    public override double CalculateArea()
//    {
//        return 0.5 * baseLength * height;
//    }
//}

//class Program65
//{
//    static void Main()
//    {
//        Shape[] shapes = new Shape[]
//        {
//            new Circle(5),
//            new Rectangle(4, 6),
//            new Triangle(3, 4),
//            new Circle(3),
//            new Rectangle(2, 8)
//        };

//        double totalArea = 0;

//        for (int i = 0; i < shapes.Length; i++)
//        {
//            double area = shapes[i].CalculateArea();
//            totalArea += area;
//            Console.WriteLine($"Фигура {i + 1}: Площадь = {area:F2}");
//        }

//        Console.WriteLine($"\nОбщая площадь всех фигур: {totalArea:F2}");
//    }
//}

//66
//using System;

//abstract class DatabaseConnection
//{
//    protected string connectionString;
//    protected bool isConnected;

//    public DatabaseConnection(string connectionString)
//    {
//        this.connectionString = connectionString;
//        this.isConnected = false;
//    }

//    public abstract void Connect();
//    public abstract void Disconnect();
//    public abstract void ExecuteQuery(string query);

//    public bool IsConnected
//    {
//        get { return isConnected; }
//    }

//    public virtual void DisplayStatus()
//    {
//        Console.WriteLine($"Статус подключения: {(isConnected ? "Подключено" : "Отключено")}");
//    }
//}

//class SqlConnection : DatabaseConnection
//{
//    public SqlConnection(string connectionString) : base(connectionString) { }

//    public override void Connect()
//    {
//        Console.WriteLine($"Подключаемся к SQL Server: {connectionString}");
//        isConnected = true;
//    }

//    public override void Disconnect()
//    {
//        Console.WriteLine("Отключаемся от SQL Server");
//        isConnected = false;
//    }

//    public override void ExecuteQuery(string query)
//    {
//        if (!isConnected)
//        {
//            Console.WriteLine("Ошибка: Нет подключения к базе данных");
//            return;
//        }
//        Console.WriteLine($"Выполняем SQL запрос: {query}");
//    }
//}

//class MySqlConnection : DatabaseConnection
//{
//    public MySqlConnection(string connectionString) : base(connectionString) { }

//    public override void Connect()
//    {
//        Console.WriteLine($"Подключаемся к MySQL: {connectionString}");
//        isConnected = true;
//    }

//    public override void Disconnect()
//    {
//        Console.WriteLine("Отключаемся от MySQL");
//        isConnected = false;
//    }

//    public override void ExecuteQuery(string query)
//    {
//        if (!isConnected)
//        {
//            Console.WriteLine("Ошибка: Нет подключения к базе данных");
//            return;
//        }
//        Console.WriteLine($"Выполняем MySQL запрос: {query}");
//    }
//}

//class Program66
//{
//    static void Main()
//    {
//        DatabaseConnection[] connections = new DatabaseConnection[]
//        {
//            new SqlConnection("Server=localhost;Database=test;User=admin"),
//            new MySqlConnection("Server=localhost;Database=app;User=root")
//        };

//        foreach (DatabaseConnection connection in connections)
//        {
//            connection.Connect();
//            connection.ExecuteQuery("SELECT * FROM users");
//            connection.DisplayStatus();
//            connection.Disconnect();
//            Console.WriteLine();
//        }
//    }
//}

//67
//using System;
//using System.Collections.Generic;

//interface IRepository<T>
//{
//    void Add(T entity);
//    void Update(T entity);
//    void Delete(int id);
//    T GetById(int id);
//    List<T> GetAll();
//    List<T> Find(Func<T, bool> predicate);
//}

//class UserRepository : IRepository<User>
//{
//    private List<User> users = new List<User>();
//    private int nextId = 1;

//    public void Add(User user)
//    {
//        user.Id = nextId++;
//        users.Add(user);
//        Console.WriteLine($"Добавлен пользователь: {user.Name}");
//    }

//    public void Update(User user)
//    {
//        var existingUser = users.Find(u => u.Id == user.Id);
//        if (existingUser != null)
//        {
//            existingUser.Name = user.Name;
//            existingUser.Email = user.Email;
//            Console.WriteLine($"Обновлен пользователь: {user.Name}");
//        }
//    }

//    public void Delete(int id)
//    {
//        var user = users.Find(u => u.Id == id);
//        if (user != null)
//        {
//            users.Remove(user);
//            Console.WriteLine($"Удален пользователь: {user.Name}");
//        }
//    }

//    public User GetById(int id)
//    {
//        return users.Find(u => u.Id == id);
//    }

//    public List<User> GetAll()
//    {
//        return new List<User>(users);
//    }

//    public List<User> Find(Func<User, bool> predicate)
//    {
//        return users.FindAll(u => predicate(u));
//    }
//}

//class User
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Email { get; set; }

//    public User(string name, string email)
//    {
//        Name = name;
//        Email = email;
//    }
//}

//class ProductRepository : IRepository<Product>
//{
//    private List<Product> products = new List<Product>();
//    private int nextId = 1;

//    public void Add(Product product)
//    {
//        product.Id = nextId++;
//        products.Add(product);
//        Console.WriteLine($"Добавлен товар: {product.Name}");
//    }

//    public void Update(Product product)
//    {
//        var existingProduct = products.Find(p => p.Id == product.Id);
//        if (existingProduct != null)
//        {
//            existingProduct.Name = product.Name;
//            existingProduct.Price = product.Price;
//            Console.WriteLine($"Обновлен товар: {product.Name}");
//        }
//    }

//    public void Delete(int id)
//    {
//        var product = products.Find(p => p.Id == id);
//        if (product != null)
//        {
//            products.Remove(product);
//            Console.WriteLine($"Удален товар: {product.Name}");
//        }
//    }

//    public Product GetById(int id)
//    {
//        return products.Find(p => p.Id == id);
//    }

//    public List<Product> GetAll()
//    {
//        return new List<Product>(products);
//    }

//    public List<Product> Find(Func<Product, bool> predicate)
//    {
//        return products.FindAll(p => predicate(p));
//    }
//}

//class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public decimal Price { get; set; }

//    public Product(string name, decimal price)
//    {
//        Name = name;
//        Price = price;
//    }
//}

//class Program67
//{
//    static void Main()
//    {
//        IRepository<User> userRepo = new UserRepository();
//        userRepo.Add(new User("Иван Иванов", "ivan@mail.ru"));
//        userRepo.Add(new User("Петр Петров", "petr@mail.ru"));

//        var users = userRepo.GetAll();
//        Console.WriteLine($"Всего пользователей: {users.Count}");

//        IRepository<Product> productRepo = new ProductRepository();
//        productRepo.Add(new Product("Ноутбук", 50000));
//        productRepo.Add(new Product("Мышь", 1500));

//        var expensiveProducts = productRepo.Find(p => p.Price > 10000);
//        Console.WriteLine($"Дорогих товаров: {expensiveProducts.Count}");
//    }
//}

//68
//using System;

//abstract class Logger
//{
//    protected string loggerName;

//    public Logger(string name)
//    {
//        loggerName = name;
//    }

//    public abstract void Log(string message, LogLevel level);
//    public abstract void LogInfo(string message);
//    public abstract void LogError(string message);
//    public abstract void LogWarning(string message);

//    protected string FormatMessage(string message, LogLevel level)
//    {
//        return $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] [{loggerName}] {message}";
//    }
//}

//enum LogLevel
//{
//    INFO,
//    WARNING,
//    ERROR
//}

//class FileLogger : Logger
//{
//    private string filePath;

//    public FileLogger(string name, string filePath) : base(name)
//    {
//        this.filePath = filePath;
//    }

//    public override void Log(string message, LogLevel level)
//    {
//        string formattedMessage = FormatMessage(message, level);
//        Console.WriteLine($"Запись в файл {filePath}: {formattedMessage}");
//    }

//    public override void LogInfo(string message)
//    {
//        Log(message, LogLevel.INFO);
//    }

//    public override void LogError(string message)
//    {
//        Log(message, LogLevel.ERROR);
//    }

//    public override void LogWarning(string message)
//    {
//        Log(message, LogLevel.WARNING);
//    }
//}

//class ConsoleLogger : Logger
//{
//    public ConsoleLogger(string name) : base(name) { }

//    public override void Log(string message, LogLevel level)
//    {
//        string formattedMessage = FormatMessage(message, level);
//        ConsoleColor originalColor = Console.ForegroundColor;

//        Console.ForegroundColor = level switch
//        {
//            LogLevel.INFO => ConsoleColor.White,
//            LogLevel.WARNING => ConsoleColor.Yellow,
//            LogLevel.ERROR => ConsoleColor.Red,
//            _ => ConsoleColor.White
//        };

//        Console.WriteLine(formattedMessage);
//        Console.ForegroundColor = originalColor;
//    }

//    public override void LogInfo(string message)
//    {
//        Log(message, LogLevel.INFO);
//    }

//    public override void LogError(string message)
//    {
//        Log(message, LogLevel.ERROR);
//    }

//    public override void LogWarning(string message)
//    {
//        Log(message, LogLevel.WARNING);
//    }
//}

//class Program68
//{
//    static void Main()
//    {
//        Logger[] loggers = new Logger[]
//        {
//            new ConsoleLogger("ConsoleLogger"),
//            new FileLogger("FileLogger", "app.log")
//        };

//        foreach (Logger logger in loggers)
//        {
//            logger.LogInfo("Приложение запущено");
//            logger.LogWarning("Небольшое предупреждение");
//            logger.LogError("Критическая ошибка!");
//            Console.WriteLine();
//        }
//    }
//}

//69
//using System;
//using System.Text.RegularExpressions;

//interface IValidator
//{
//    bool Validate(object obj);
//    string GetErrorMessage();
//}

//class EmailValidator : IValidator
//{
//    private string email;

//    public EmailValidator(string email)
//    {
//        this.email = email;
//    }

//    public bool Validate(object obj)
//    {
//        if (string.IsNullOrEmpty(email))
//            return false;

//        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//        return Regex.IsMatch(email, pattern);
//    }

//    public string GetErrorMessage()
//    {
//        return "Некорректный формат email адреса";
//    }
//}

//class PasswordValidator : IValidator
//{
//    private string password;

//    public PasswordValidator(string password)
//    {
//        this.password = password;
//    }

//    public bool Validate(object obj)
//    {
//        if (string.IsNullOrEmpty(password) || password.Length < 8)
//            return false;

//        return Regex.IsMatch(password, "[A-Z]") &&
//               Regex.IsMatch(password, "[a-z]") &&
//               Regex.IsMatch(password, "[0-9]");
//    }

//    public string GetErrorMessage()
//    {
//        return "Пароль должен содержать минимум 8 символов, включая заглавные и строчные буквы и цифры";
//    }
//}

//class AgeValidator : IValidator
//{
//    private int age;

//    public AgeValidator(int age)
//    {
//        this.age = age;
//    }

//    public bool Validate(object obj)
//    {
//        return age >= 0 && age <= 150;
//    }

//    public string GetErrorMessage()
//    {
//        return "Возраст должен быть от 0 до 150 лет";
//    }
//}

//class UserRegistration
//{
//    private IValidator[] validators;

//    public UserRegistration(IValidator[] validators)
//    {
//        this.validators = validators;
//    }

//    public bool RegisterUser()
//    {
//        foreach (var validator in validators)
//        {
//            if (!validator.Validate(null))
//            {
//                Console.WriteLine($"Ошибка: {validator.GetErrorMessage()}");
//                return false;
//            }
//        }

//        Console.WriteLine("Регистрация прошла успешно!");
//        return true;
//    }
//}

//class Program69
//{
//    static void Main()
//    {
//        IValidator[] validators1 = new IValidator[]
//        {
//            new EmailValidator("user@example.com"),
//            new PasswordValidator("StrongPass123"),
//            new AgeValidator(25)
//        };

//        IValidator[] validators2 = new IValidator[]
//        {
//            new EmailValidator("invalid-email"),
//            new PasswordValidator("weak"),
//            new AgeValidator(200)
//        };

//        UserRegistration registration1 = new UserRegistration(validators1);
//        Console.WriteLine("Попытка 1:");
//        registration1.RegisterUser();

//        Console.WriteLine("\nПопытка 2:");
//        UserRegistration registration2 = new UserRegistration(validators2);
//        registration2.RegisterUser();
//    }
//}

//70
//using System;

//abstract class PaymentProcessor
//{
//    protected decimal amount;
//    protected string currency;

//    public PaymentProcessor(decimal amount, string currency)
//    {
//        this.amount = amount;
//        this.currency = currency;
//    }

//    public abstract bool ProcessPayment();
//    public abstract void RefundPayment();
//    public abstract string GetPaymentDetails();

//    protected virtual bool ValidateAmount()
//    {
//        return amount > 0;
//    }

//    protected virtual void LogPayment(string status)
//    {
//        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Платеж {amount} {currency}: {status}");
//    }
//}

//class CreditCardProcessor : PaymentProcessor
//{
//    private string cardNumber;
//    private string cardHolder;

//    public CreditCardProcessor(decimal amount, string currency, string cardNumber, string cardHolder)
//        : base(amount, currency)
//    {
//        this.cardNumber = cardNumber;
//        this.cardHolder = cardHolder;
//    }

//    public override bool ProcessPayment()
//    {
//        if (!ValidateAmount())
//        {
//            Console.WriteLine("Неверная сумма платежа");
//            return false;
//        }

//        Console.WriteLine($"Обработка платежа по карте {MaskCardNumber(cardNumber)}");
//        Console.WriteLine($"Держатель карты: {cardHolder}");

//        bool success = SimulateBankProcessing();

//        LogPayment(success ? "Успешно" : "Ошибка");
//        return success;
//    }

//    public override void RefundPayment()
//    {
//        Console.WriteLine($"Возврат средств на карту {MaskCardNumber(cardNumber)}");
//        LogPayment("Возврат");
//    }

//    public override string GetPaymentDetails()
//    {
//        return $"Кредитная карта: {MaskCardNumber(cardNumber)}, Держатель: {cardHolder}, Сумма: {amount} {currency}";
//    }

//    private string MaskCardNumber(string cardNumber)
//    {
//        if (cardNumber.Length < 4) return cardNumber;
//        return new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4);
//    }

//    private bool SimulateBankProcessing()
//    {
//        return amount <= 10000;
//    }
//}

//class PayPalProcessor : PaymentProcessor
//{
//    private string email;

//    public PayPalProcessor(decimal amount, string currency, string email)
//        : base(amount, currency)
//    {
//        this.email = email;
//    }

//    public override bool ProcessPayment()
//    {
//        if (!ValidateAmount())
//        {
//            Console.WriteLine("Неверная сумма платежа");
//            return false;
//        }

//        Console.WriteLine($"Обработка PayPal платежа для {email}");

//        bool success = SimulatePayPalProcessing();

//        LogPayment(success ? "Успешно" : "Ошибка");
//        return success;
//    }

//    public override void RefundPayment()
//    {
//        Console.WriteLine($"Возврат средств на PayPal аккаунт {email}");
//        LogPayment("Возврат");
//    }

//    public override string GetPaymentDetails()
//    {
//        return $"PayPal: {email}, Сумма: {amount} {currency}";
//    }

//    private bool SimulatePayPalProcessing()
//    {
//        return amount <= 5000;
//    }
//}

//class CryptoProcessor : PaymentProcessor
//{
//    private string walletAddress;

//    public CryptoProcessor(decimal amount, string currency, string walletAddress)
//        : base(amount, currency)
//    {
//        this.walletAddress = walletAddress;
//    }

//    public override bool ProcessPayment()
//    {
//        if (!ValidateAmount())
//        {
//            Console.WriteLine("Неверная сумма платежа");
//            return false;
//        }

//        Console.WriteLine($"Обработка крипто-платежа с кошелька {MaskWalletAddress(walletAddress)}");

//        bool success = SimulateBlockchainProcessing();

//        LogPayment(success ? "Успешно" : "Ошибка");
//        return success;
//    }

//    public override void RefundPayment()
//    {
//        Console.WriteLine("Возврат крипто-платежей не поддерживается");
//        LogPayment("Возврат отклонен");
//    }

//    public override string GetPaymentDetails()
//    {
//        return $"Крипто-кошелек: {MaskWalletAddress(walletAddress)}, Сумма: {amount} {currency}";
//    }

//    private string MaskWalletAddress(string address)
//    {
//        if (address.Length < 8) return address;
//        return address.Substring(0, 6) + "..." + address.Substring(address.Length - 4);
//    }

//    private bool SimulateBlockchainProcessing()
//    {
//        return true;
//    }
//}

//class Program70
//{
//    static void Main()
//    {
//        PaymentProcessor[] processors = new PaymentProcessor[]
//        {
//            new CreditCardProcessor(5000, "RUB", "1234567812345678", "Иван Иванов"),
//            new PayPalProcessor(3000, "USD", "user@example.com"),
//            new CryptoProcessor(0.1m, "BTC", "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
//        };

//        foreach (var processor in processors)
//        {
//            Console.WriteLine($"\nДетали платежа: {processor.GetPaymentDetails()}");
//            bool success = processor.ProcessPayment();

//            if (success)
//            {
//                processor.RefundPayment();
//            }
//            Console.WriteLine(new string('-', 40));
//        }
//    }
//}

//71
//using System;
//using System.Collections.Generic;

//public class Author
//{
//    public string Name { get; set; }
//    public string Nationality { get; set; }
//    public List<Book> Books { get; set; }

//    public Author(string name, string nationality)
//    {
//        Name = name;
//        Nationality = nationality;
//        Books = new List<Book>();
//    }

//    public void AddBook(Book book)
//    {
//        Books.Add(book);
//    }
//}

//public class Book
//{
//    public string Title { get; set; }
//    public string ISBN { get; set; }
//    public int PublicationYear { get; set; }
//    public Author Author { get; set; }

//    public Book(string title, string isbn, int publicationYear, Author author)
//    {
//        Title = title;
//        ISBN = isbn;
//        PublicationYear = publicationYear;
//        Author = author;
//        author.AddBook(this);
//    }
//}

//public class Library
//{
//    public string Name { get; set; }
//    public List<Book> Books { get; set; }

//    public Library(string name)
//    {
//        Name = name;
//        Books = new List<Book>();
//    }

//    public void AddBook(Book book)
//    {
//        Books.Add(book);
//    }

//    public void DisplayBooks()
//    {
//        Console.WriteLine($"Библиотека: {Name}");
//        foreach (var book in Books)
//        {
//            Console.WriteLine($"- {book.Title} ({book.PublicationYear}) - {book.Author.Name}");
//        }
//    }
//}

//72
//using System;
//using System.Collections.Generic;

//public class Student
//{
//    public string Name { get; set; }
//    public int StudentId { get; set; }
//    public int GradeLevel { get; set; }
//    public List<Course> Courses { get; set; }

//    public Student(string name, int studentId, int gradeLevel)
//    {
//        Name = name;
//        StudentId = studentId;
//        GradeLevel = gradeLevel;
//        Courses = new List<Course>();
//    }

//    public void EnrollInCourse(Course course)
//    {
//        Courses.Add(course);
//        course.AddStudent(this);
//    }
//}

//public class Teacher
//{
//    public string Name { get; set; }
//    public string Subject { get; set; }
//    public List<Course> Courses { get; set; }

//    public Teacher(string name, string subject)
//    {
//        Name = name;
//        Subject = subject;
//        Courses = new List<Course>();
//    }

//    public void AssignToCourse(Course course)
//    {
//        Courses.Add(course);
//        course.Teacher = this;
//    }
//}

//public class Course
//{
//    public string CourseName { get; set; }
//    public string CourseCode { get; set; }
//    public Teacher Teacher { get; set; }
//    public List<Student> Students { get; set; }

//    public Course(string courseName, string courseCode)
//    {
//        CourseName = courseName;
//        CourseCode = courseCode;
//        Students = new List<Student>();
//    }

//    public void AddStudent(Student student)
//    {
//        Students.Add(student);
//    }

//    public void DisplayCourseInfo()
//    {
//        Console.WriteLine($"Курс: {CourseName} ({CourseCode})");
//        Console.WriteLine($"Преподаватель: {Teacher?.Name ?? "Не назначен"}");
//        Console.WriteLine($"Студентов: {Students.Count}");
//    }
//}

//73
//using System;
//using System.Collections.Generic;

//public class Customer
//{
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public string Address { get; set; }
//    public List<Order> Orders { get; set; }

//    public Customer(string name, string email, string address)
//    {
//        Name = name;
//        Email = email;
//        Address = address;
//        Orders = new List<Order>();
//    }

//    public void PlaceOrder(Order order)
//    {
//        Orders.Add(order);
//    }
//}

//public class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//    public string Description { get; set; }
//    public int StockQuantity { get; set; }

//    public Product(string name, decimal price, string description, int stockQuantity)
//    {
//        Name = name;
//        Price = price;
//        Description = description;
//        StockQuantity = stockQuantity;
//    }
//}

//public class Order
//{
//    public string OrderId { get; set; }
//    public DateTime OrderDate { get; set; }
//    public Customer Customer { get; set; }
//    public List<Product> Products { get; set; }
//    public decimal TotalAmount { get; set; }

//    public Order(string orderId, Customer customer)
//    {
//        OrderId = orderId;
//        OrderDate = DateTime.Now;
//        Customer = customer;
//        Products = new List<Product>();
//        customer.PlaceOrder(this);
//    }

//    public void AddProduct(Product product)
//    {
//        Products.Add(product);
//        TotalAmount += product.Price;
//    }
//}

//74
//using System;
//using System.Collections.Generic;

//public class Team
//{
//    public string Name { get; set; }
//    public List<TeamMember> Members { get; set; }
//    public List<Project> Projects { get; set; }

//    public Team(string name)
//    {
//        Name = name;
//        Members = new List<TeamMember>();
//        Projects = new List<Project>();
//    }

//    public void AddMember(TeamMember member)
//    {
//        Members.Add(member);
//        member.Team = this;
//    }
//}

//public class Project
//{
//    public string Name { get; set; }
//    public string Description { get; set; }
//    public DateTime Deadline { get; set; }
//    public Team Team { get; set; }
//    public List<Task> Tasks { get; set; }

//    public Project(string name, string description, DateTime deadline)
//    {
//        Name = name;
//        Description = description;
//        Deadline = deadline;
//        Tasks = new List<Task>();
//    }

//    public void AssignTeam(Team team)
//    {
//        Team = team;
//        team.Projects.Add(this);
//    }
//}

//public class Task
//{
//    public string Title { get; set; }
//    public string Description { get; set; }
//    public TaskStatus Status { get; set; }
//    public TeamMember Assignee { get; set; }
//    public Project Project { get; set; }

//    public Task(string title, string description, Project project)
//    {
//        Title = title;
//        Description = description;
//        Status = TaskStatus.Pending;
//        Project = project;
//        project.Tasks.Add(this);
//    }
//}

//public class TeamMember
//{
//    public string Name { get; set; }
//    public string Role { get; set; }
//    public Team Team { get; set; }
//    public List<Task> Tasks { get; set; }

//    public TeamMember(string name, string role)
//    {
//        Name = name;
//        Role = role;
//        Tasks = new List<Task>();
//    }
//}

//public enum TaskStatus
//{
//    Pending,
//    InProgress,
//    Completed
//}

//75
//using System;
//using System.Collections.Generic;

//public class Doctor
//{
//    public string Name { get; set; }
//    public string Specialization { get; set; }
//    public List<Appointment> Appointments { get; set; }

//    public Doctor(string name, string specialization)
//    {
//        Name = name;
//        Specialization = specialization;
//        Appointments = new List<Appointment>();
//    }
//}

//public class Patient
//{
//    public string Name { get; set; }
//    public DateTime DateOfBirth { get; set; }
//    public string MedicalHistory { get; set; }
//    public List<Appointment> Appointments { get; set; }

//    public Patient(string name, DateTime dateOfBirth, string medicalHistory)
//    {
//        Name = name;
//        DateOfBirth = dateOfBirth;
//        MedicalHistory = medicalHistory;
//        Appointments = new List<Appointment>();
//    }
//}

//public class Appointment
//{
//    public DateTime AppointmentDate { get; set; }
//    public string Reason { get; set; }
//    public Doctor Doctor { get; set; }
//    public Patient Patient { get; set; }

//    public Appointment(DateTime appointmentDate, string reason, Doctor doctor, Patient patient)
//    {
//        AppointmentDate = appointmentDate;
//        Reason = reason;
//        Doctor = doctor;
//        Patient = patient;
//        doctor.Appointments.Add(this);
//        patient.Appointments.Add(this);
//    }
//}

//76
//using System;
//using System.Collections.Generic;

//public class Character
//{
//    public string Name { get; set; }
//    public int Level { get; set; }
//    public int Health { get; set; }
//    public Inventory Inventory { get; set; }

//    public Character(string name)
//    {
//        Name = name;
//        Level = 1;
//        Health = 100;
//        Inventory = new Inventory();
//    }

//    public void UseItem(Item item)
//    {
//        Console.WriteLine($"{Name} использует {item.Name}");
//        Inventory.RemoveItem(item);
//    }
//}

//public class Inventory
//{
//    public List<Item> Items { get; set; }
//    public int Capacity { get; set; }

//    public Inventory()
//    {
//        Items = new List<Item>();
//        Capacity = 20;
//    }

//    public void AddItem(Item item)
//    {
//        if (Items.Count < Capacity)
//        {
//            Items.Add(item);
//        }
//    }

//    public void RemoveItem(Item item)
//    {
//        Items.Remove(item);
//    }
//}

//public class Item
//{
//    public string Name { get; set; }
//    public ItemType Type { get; set; }
//    public int Value { get; set; }

//    public Item(string name, ItemType type, int value)
//    {
//        Name = name;
//        Type = type;
//        Value = value;
//    }
//}

//public enum ItemType
//{
//    Weapon,
//    Armor,
//    Potion,
//    Quest
//}

//77
//using System;
//using System.Collections.Generic;

//public class Menu
//{
//    public string Name { get; set; }
//    public List<Dish> Dishes { get; set; }

//    public Menu(string name)
//    {
//        Name = name;
//        Dishes = new List<Dish>();
//    }

//    public void AddDish(Dish dish)
//    {
//        Dishes.Add(dish);
//    }
//}

//public class Dish
//{
//    public string Name { get; set; }
//    public string Description { get; set; }
//    public decimal Price { get; set; }
//    public string Category { get; set; }

//    public Dish(string name, string description, decimal price, string category)
//    {
//        Name = name;
//        Description = description;
//        Price = price;
//        Category = category;
//    }
//}

//public class RestaurantOrder
//{
//    public string OrderId { get; set; }
//    public DateTime OrderTime { get; set; }
//    public List<Dish> Dishes { get; set; }
//    public decimal TotalAmount { get; set; }
//    public OrderStatus Status { get; set; }

//    public RestaurantOrder(string orderId)
//    {
//        OrderId = orderId;
//        OrderTime = DateTime.Now;
//        Dishes = new List<Dish>();
//        Status = OrderStatus.Pending;
//    }

//    public void AddDish(Dish dish)
//    {
//        Dishes.Add(dish);
//        TotalAmount += dish.Price;
//    }
//}

//public enum OrderStatus
//{
//    Pending,
//    Cooking,
//    Ready,
//    Served
//}

//78
//using System;
//using System.Collections.Generic;

//public class Hotel
//{
//    public string Name { get; set; }
//    public string Address { get; set; }
//    public List<Room> Rooms { get; set; }

//    public Hotel(string name, string address)
//    {
//        Name = name;
//        Address = address;
//        Rooms = new List<Room>();
//    }

//    public void AddRoom(Room room)
//    {
//        Rooms.Add(room);
//        room.Hotel = this;
//    }
//}

//public class Room
//{
//    public string RoomNumber { get; set; }
//    public RoomType Type { get; set; }
//    public decimal PricePerNight { get; set; }
//    public bool IsAvailable { get; set; }
//    public Hotel Hotel { get; set; }

//    public Room(string roomNumber, RoomType type, decimal pricePerNight)
//    {
//        RoomNumber = roomNumber;
//        Type = type;
//        PricePerNight = pricePerNight;
//        IsAvailable = true;
//    }
//}

//public class Booking
//{
//    public string BookingId { get; set; }
//    public DateTime CheckInDate { get; set; }
//    public DateTime CheckOutDate { get; set; }
//    public Room Room { get; set; }
//    public string GuestName { get; set; }

//    public Booking(string bookingId, DateTime checkIn, DateTime checkOut, Room room, string guestName)
//    {
//        BookingId = bookingId;
//        CheckInDate = checkIn;
//        CheckOutDate = checkOut;
//        Room = room;
//        GuestName = guestName;
//        room.IsAvailable = false;
//    }

//    public decimal CalculateTotal()
//    {
//        int nights = (CheckOutDate - CheckInDate).Days;
//        return nights * Room.PricePerNight;
//    }
//}

//public enum RoomType
//{
//    Single,
//    Double,
//    Suite,
//    Deluxe
//}

//79
//using System;
//using System.Collections.Generic;

//public class Vehicle
//{
//    public string LicensePlate { get; set; }
//    public string Model { get; set; }
//    public int Capacity { get; set; }
//    public Driver Driver { get; set; }

//    public Vehicle(string licensePlate, string model, int capacity)
//    {
//        LicensePlate = licensePlate;
//        Model = model;
//        Capacity = capacity;
//    }

//    public void AssignDriver(Driver driver)
//    {
//        Driver = driver;
//        driver.AssignedVehicle = this;
//    }
//}

//public class Driver
//{
//    public string Name { get; set; }
//    public string LicenseNumber { get; set; }
//    public Vehicle AssignedVehicle { get; set; }
//    public List<Route> Routes { get; set; }

//    public Driver(string name, string licenseNumber)
//    {
//        Name = name;
//        LicenseNumber = licenseNumber;
//        Routes = new List<Route>();
//    }
//}

//public class Route
//{
//    public string RouteId { get; set; }
//    public string StartPoint { get; set; }
//    public string EndPoint { get; set; }
//    public int Distance { get; set; }
//    public Driver Driver { get; set; }
//    public Vehicle Vehicle { get; set; }

//    public Route(string routeId, string startPoint, string endPoint, int distance)
//    {
//        RouteId = routeId;
//        StartPoint = startPoint;
//        EndPoint = endPoint;
//        Distance = distance;
//    }

//    public void AssignDriverAndVehicle(Driver driver, Vehicle vehicle)
//    {
//        Driver = driver;
//        Vehicle = vehicle;
//        driver.Routes.Add(this);
//    }
//}

//80
//using System;
//using System.Collections.Generic;

//public class Bank
//{
//    public string Name { get; set; }
//    public string Address { get; set; }
//    public List<Account> Accounts { get; set; }

//    public Bank(string name, string address)
//    {
//        Name = name;
//        Address = address;
//        Accounts = new List<Account>();
//    }

//    public void AddAccount(Account account)
//    {
//        Accounts.Add(account);
//        account.Bank = this;
//    }
//}

//public class Account
//{
//    public string AccountNumber { get; set; }
//    public decimal Balance { get; set; }
//    public string OwnerName { get; set; }
//    public Bank Bank { get; set; }
//    public List<Transaction> Transactions { get; set; }

//    public Account(string accountNumber, string ownerName, decimal initialBalance)
//    {
//        AccountNumber = accountNumber;
//        OwnerName = ownerName;
//        Balance = initialBalance;
//        Transactions = new List<Transaction>();
//    }

//    public void AddTransaction(Transaction transaction)
//    {
//        Transactions.Add(transaction);
//        Balance += transaction.Amount;
//    }
//}

//public class Transaction
//{
//    public string TransactionId { get; set; }
//    public DateTime TransactionDate { get; set; }
//    public decimal Amount { get; set; }
//    public TransactionType Type { get; set; }
//    public Account Account { get; set; }

//    public Transaction(string transactionId, decimal amount, TransactionType type, Account account)
//    {
//        TransactionId = transactionId;
//        Amount = type == TransactionType.Debit ? -amount : amount;
//        Type = type;
//        Account = account;
//        TransactionDate = DateTime.Now;
//        account.AddTransaction(this);
//    }
//}

//public enum TransactionType
//{
//    Debit,
//    Credit
//}

//81
//using System;
//using System.Collections.Generic;

//public class SchoolStudent
//{
//    public string Name { get; set; }
//    public int StudentId { get; set; }
//    public List<Grade> Grades { get; set; }

//    public SchoolStudent(string name, int studentId)
//    {
//        Name = name;
//        StudentId = studentId;
//        Grades = new List<Grade>();
//    }

//    public void AddGrade(Grade grade)
//    {
//        Grades.Add(grade);
//    }

//    public decimal CalculateGPA()
//    {
//        if (Grades.Count == 0) return 0;

//        decimal totalPoints = 0;
//        foreach (var grade in Grades)
//        {
//            totalPoints += grade.GetGradePoints();
//        }
//        return totalPoints / Grades.Count;
//    }
//}

//public class Subject
//{
//    public string Name { get; set; }
//    public string Code { get; set; }
//    public List<Grade> Grades { get; set; }

//    public Subject(string name, string code)
//    {
//        Name = name;
//        Code = code;
//        Grades = new List<Grade>();
//    }
//}

//public class Grade
//{
//    public SchoolStudent Student { get; set; }
//    public Subject Subject { get; set; }
//    public decimal Score { get; set; }
//    public DateTime DateAssigned { get; set; }

//    public Grade(SchoolStudent student, Subject subject, decimal score)
//    {
//        Student = student;
//        Subject = subject;
//        Score = score;
//        DateAssigned = DateTime.Now;
//        student.AddGrade(this);
//        subject.Grades.Add(this);
//    }

//    public decimal GetGradePoints()
//    {
//        return Score switch
//        {
//            >= 90 => 4.0m,
//            >= 80 => 3.0m,
//            >= 70 => 2.0m,
//            >= 60 => 1.0m,
//            _ => 0.0m
//        };
//    }

//    public string GetLetterGrade()
//    {
//        return Score switch
//        {
//            >= 90 => "A",
//            >= 80 => "B",
//            >= 70 => "C",
//            >= 60 => "D",
//            _ => "F"
//        };
//    }
//}

//82
//using System;
//using System.Collections.Generic;

//public class Event
//{
//    public string Name { get; set; }
//    public DateTime Date { get; set; }
//    public string Description { get; set; }
//    public Venue Venue { get; set; }
//    public List<Attendee> Attendees { get; set; }

//    public Event(string name, DateTime date, string description)
//    {
//        Name = name;
//        Date = date;
//        Description = description;
//        Attendees = new List<Attendee>();
//    }

//    public void SetVenue(Venue venue)
//    {
//        Venue = venue;
//        venue.Events.Add(this);
//    }

//    public void AddAttendee(Attendee attendee)
//    {
//        Attendees.Add(attendee);
//        attendee.Events.Add(this);
//    }
//}

//public class Attendee
//{
//    public string Name { get; set; }
//    public string Email { get; set; }
//    public List<Event> Events { get; set; }

//    public Attendee(string name, string email)
//    {
//        Name = name;
//        Email = email;
//        Events = new List<Event>();
//    }
//}

//public class Venue
//{
//    public string Name { get; set; }
//    public string Address { get; set; }
//    public int Capacity { get; set; }
//    public List<Event> Events { get; set; }

//    public Venue(string name, string address, int capacity)
//    {
//        Name = name;
//        Address = address;
//        Capacity = capacity;
//        Events = new List<Event>();
//    }
//}

//83
//using System;
//using System.Collections.Generic;

//public class SocialUser
//{
//    public string Username { get; set; }
//    public string Email { get; set; }
//    public DateTime JoinDate { get; set; }
//    public List<Post> Posts { get; set; }
//    public List<Comment> Comments { get; set; }

//    public SocialUser(string username, string email)
//    {
//        Username = username;
//        Email = email;
//        JoinDate = DateTime.Now;
//        Posts = new List<Post>();
//        Comments = new List<Comment>();
//    }

//    public Post CreatePost(string content)
//    {
//        var post = new Post(content, this);
//        Posts.Add(post);
//        return post;
//    }

//    public Comment AddComment(string content, Post post)
//    {
//        var comment = new Comment(content, this, post);
//        Comments.Add(comment);
//        return comment;
//    }
//}

//public class Post
//{
//    public string Content { get; set; }
//    public DateTime PostDate { get; set; }
//    public SocialUser Author { get; set; }
//    public List<Comment> Comments { get; set; }

//    public Post(string content, SocialUser author)
//    {
//        Content = content;
//        Author = author;
//        PostDate = DateTime.Now;
//        Comments = new List<Comment>();
//    }

//    public void AddComment(Comment comment)
//    {
//        Comments.Add(comment);
//    }
//}

//public class Comment
//{
//    public string Content { get; set; }
//    public DateTime CommentDate { get; set; }
//    public SocialUser Author { get; set; }
//    public Post Post { get; set; }

//    public Comment(string content, SocialUser author, Post post)
//    {
//        Content = content;
//        Author = author;
//        Post = post;
//        CommentDate = DateTime.Now;
//        post.AddComment(this);
//    }
//}

//84
//using System;
//using System.Collections.Generic;

//public class SportsTeam
//{
//    public string Name { get; set; }
//    public string City { get; set; }
//    public List<Player> Players { get; set; }
//    public List<Match> HomeMatches { get; set; }
//    public List<Match> AwayMatches { get; set; }

//    public SportsTeam(string name, string city)
//    {
//        Name = name;
//        City = city;
//        Players = new List<Player>();
//        HomeMatches = new List<Match>();
//        AwayMatches = new List<Match>();
//    }

//    public void AddPlayer(Player player)
//    {
//        Players.Add(player);
//        player.Team = this;
//    }
//}

//public class Player
//{
//    public string Name { get; set; }
//    public int Number { get; set; }
//    public string Position { get; set; }
//    public SportsTeam Team { get; set; }

//    public Player(string name, int number, string position)
//    {
//        Name = name;
//        Number = number;
//        Position = position;
//    }
//}

//public class Match
//{
//    public DateTime MatchDate { get; set; }
//    public SportsTeam HomeTeam { get; set; }
//    public SportsTeam AwayTeam { get; set; }
//    public string Score { get; set; }
//    public string Location { get; set; }

//    public Match(DateTime matchDate, SportsTeam homeTeam, SportsTeam awayTeam, string location)
//    {
//        MatchDate = matchDate;
//        HomeTeam = homeTeam;
//        AwayTeam = awayTeam;
//        Location = location;
//        homeTeam.HomeMatches.Add(this);
//        awayTeam.AwayMatches.Add(this);
//    }
//}

//85
//using System;
//using System.Collections.Generic;

//public class Movie
//{
//    public string Title { get; set; }
//    public int ReleaseYear { get; set; }
//    public string Genre { get; set; }
//    public int Duration { get; set; }
//    public List<Actor> Cast { get; set; }
//    public List<Cinema> Cinemas { get; set; }

//    public Movie(string title, int releaseYear, string genre, int duration)
//    {
//        Title = title;
//        ReleaseYear = releaseYear;
//        Genre = genre;
//        Duration = duration;
//        Cast = new List<Actor>();
//        Cinemas = new List<Cinema>();
//    }

//    public void AddActor(Actor actor)
//    {
//        Cast.Add(actor);
//        actor.Movies.Add(this);
//    }

//    public void AddCinema(Cinema cinema)
//    {
//        Cinemas.Add(cinema);
//        cinema.Movies.Add(this);
//    }
//}

//public class Actor
//{
//    public string Name { get; set; }
//    public DateTime BirthDate { get; set; }
//    public string Nationality { get; set; }
//    public List<Movie> Movies { get; set; }

//    public Actor(string name, DateTime birthDate, string nationality)
//    {
//        Name = name;
//        BirthDate = birthDate;
//        Nationality = nationality;
//        Movies = new List<Movie>();
//    }
//}

//public class Cinema
//{
//    public string Name { get; set; }
//    public string Location { get; set; }
//    public int Screens { get; set; }
//    public List<Movie> Movies { get; set; }

//    public Cinema(string name, string location, int screens)
//    {
//        Name = name;
//        Location = location;
//        Screens = screens;
//        Movies = new List<Movie>();
//    }
//}

//86
//using System;
//using System.Collections.Generic;

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public Person Manager { get; set; }
//    public List<Person> Subordinates { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//        Subordinates = new List<Person>();
//    }

//    public void SetManager(Person manager)
//    {
//        Manager = manager;
//        manager.Subordinates.Add(this);
//    }

//    public void AddSubordinate(Person subordinate)
//    {
//        subordinate.Manager = this;
//        Subordinates.Add(subordinate);
//    }

//    public void DisplayHierarchy(int level = 0)
//    {
//        string indent = new string(' ', level * 2);
//        Console.WriteLine($"{indent}- {Name} (Возраст: {Age})");

//        foreach (var subordinate in Subordinates)
//        {
//            subordinate.DisplayHierarchy(level + 1);
//        }
//    }

//    public List<Person> GetAllSubordinates()
//    {
//        var allSubordinates = new List<Person>();

//        foreach (var subordinate in Subordinates)
//        {
//            allSubordinates.Add(subordinate);
//            allSubordinates.AddRange(subordinate.GetAllSubordinates());
//        }

//        return allSubordinates;
//    }
//}

//87
//using System;
//using System.Collections.Generic;

//public class Node
//{
//    public string Name { get; set; }
//    public Node Parent { get; set; }
//    public List<Node> Children { get; set; }

//    public Node(string name)
//    {
//        Name = name;
//        Children = new List<Node>();
//    }

//    public void AddChild(Node child)
//    {
//        child.Parent = this;
//        Children.Add(child);
//    }

//    public void RemoveChild(Node child)
//    {
//        Children.Remove(child);
//        child.Parent = null;
//    }

//    public void DisplayTree(int level = 0)
//    {
//        string indent = new string(' ', level * 2);
//        Console.WriteLine($"{indent}└─ {Name}");

//        foreach (var child in Children)
//        {
//            child.DisplayTree(level + 1);
//        }
//    }

//    public int GetDepth()
//    {
//        int depth = 0;
//        Node current = this;

//        while (current.Parent != null)
//        {
//            depth++;
//            current = current.Parent;
//        }

//        return depth;
//    }

//    public List<Node> GetAllDescendants()
//    {
//        var descendants = new List<Node>();

//        foreach (var child in Children)
//        {
//            descendants.Add(child);
//            descendants.AddRange(child.GetAllDescendants());
//        }

//        return descendants;
//    }

//    public bool IsRoot => Parent == null;
//    public bool IsLeaf => Children.Count == 0;
//}

//88
//using System;
//using System.Collections.Generic;

//public class Employee
//{
//    public string Name { get; set; }
//    public string Position { get; set; }
//    public decimal Salary { get; set; }
//    public Employee Manager { get; set; }
//    public List<Employee> TeamMembers { get; set; }

//    public Employee(string name, string position, decimal salary)
//    {
//        Name = name;
//        Position = position;
//        Salary = salary;
//        TeamMembers = new List<Employee>();
//    }

//    public void SetManager(Employee manager)
//    {
//        Manager = manager;
//        manager.TeamMembers.Add(this);
//    }

//    public void AddTeamMember(Employee teamMember)
//    {
//        teamMember.Manager = this;
//        TeamMembers.Add(teamMember);
//    }

//    public void DisplayOrganizationChart(int level = 0)
//    {
//        string indent = new string(' ', level * 3);
//        string managerInfo = Manager != null ? $", Менеджер: {Manager.Name}" : "";
//        Console.WriteLine($"{indent}├─ {Name} ({Position}) - {Salary:C}{managerInfo}");

//        foreach (var member in TeamMembers)
//        {
//            member.DisplayOrganizationChart(level + 1);
//        }
//    }

//    public decimal GetTeamSalary()
//    {
//        decimal totalSalary = Salary;

//        foreach (var member in TeamMembers)
//        {
//            totalSalary += member.GetTeamSalary();
//        }

//        return totalSalary;
//    }

//    public int GetTeamSize()
//    {
//        int size = 1;

//        foreach (var member in TeamMembers)
//        {
//            size += member.GetTeamSize();
//        }

//        return size;
//    }

//    public List<Employee> GetManagersChain()
//    {
//        var chain = new List<Employee>();
//        Employee current = this;

//        while (current.Manager != null)
//        {
//            chain.Add(current.Manager);
//            current = current.Manager;
//        }

//        return chain;
//    }
//}

//89
//using System;
//using System.Collections.Generic;

//public class Category
//{
//    public string Name { get; set; }
//    public string Description { get; set; }
//    public Category ParentCategory { get; set; }
//    public List<Category> SubCategories { get; set; }

//    public Category(string name, string description)
//    {
//        Name = name;
//        Description = description;
//        SubCategories = new List<Category>();
//    }

//    public void SetParentCategory(Category parent)
//    {
//        ParentCategory = parent;
//        parent.SubCategories.Add(this);
//    }

//    public void AddSubCategory(Category subCategory)
//    {
//        subCategory.ParentCategory = this;
//        SubCategories.Add(subCategory);
//    }

//    public void DisplayCategoryTree(int level = 0)
//    {
//        string indent = new string(' ', level * 2);
//        string parentInfo = ParentCategory != null ? $", Родитель: {ParentCategory.Name}" : "";
//        Console.WriteLine($"{indent}📁 {Name} - {Description}{parentInfo}");

//        foreach (var subCategory in SubCategories)
//        {
//            subCategory.DisplayCategoryTree(level + 1);
//        }
//    }

//    public List<Category> GetPathToRoot()
//    {
//        var path = new List<Category>();
//        Category current = this;

//        while (current != null)
//        {
//            path.Add(current);
//            current = current.ParentCategory;
//        }

//        path.Reverse();
//        return path;
//    }

//    public List<Category> GetAllSubCategories()
//    {
//        var allSubCategories = new List<Category>();

//        foreach (var subCategory in SubCategories)
//        {
//            allSubCategories.Add(subCategory);
//            allSubCategories.AddRange(subCategory.GetAllSubCategories());
//        }

//        return allSubCategories;
//    }

//    public int GetDepth()
//    {
//        int depth = 0;
//        Category current = this;

//        while (current.ParentCategory != null)
//        {
//            depth++;
//            current = current.ParentCategory;
//        }

//        return depth;
//    }

//    public bool IsRootCategory => ParentCategory == null;
//    public bool IsLeafCategory => SubCategories.Count == 0;
//}

//90
//using System;
//using System.Collections.Generic;

//public class TreeNode<T>
//{
//    public T Data { get; set; }
//    public TreeNode<T> Parent { get; set; }
//    public List<TreeNode<T>> Children { get; set; }

//    public TreeNode(T data)
//    {
//        Data = data;
//        Children = new List<TreeNode<T>>();
//    }

//    public TreeNode<T> AddChild(T data)
//    {
//        var childNode = new TreeNode<T>(data);
//        childNode.Parent = this;
//        Children.Add(childNode);
//        return childNode;
//    }

//    public void AddChild(TreeNode<T> childNode)
//    {
//        childNode.Parent = this;
//        Children.Add(childNode);
//    }

//    public void RemoveChild(TreeNode<T> childNode)
//    {
//        Children.Remove(childNode);
//        childNode.Parent = null;
//    }

//    public void Traverse(Action<T> action)
//    {
//        action(Data);
//        foreach (var child in Children)
//        {
//            child.Traverse(action);
//        }
//    }

//    public void TraverseWithLevel(Action<T, int> action, int level = 0)
//    {
//        action(Data, level);
//        foreach (var child in Children)
//        {
//            child.TraverseWithLevel(action, level + 1);
//        }
//    }

//    public TreeNode<T> FindNode(Func<T, bool> predicate)
//    {
//        if (predicate(Data))
//            return this;

//        foreach (var child in Children)
//        {
//            var found = child.FindNode(predicate);
//            if (found != null)
//                return found;
//        }

//        return null;
//    }

//    public int GetHeight()
//    {
//        if (Children.Count == 0)
//            return 0;

//        int maxHeight = 0;
//        foreach (var child in Children)
//        {
//            int childHeight = child.GetHeight();
//            if (childHeight > maxHeight)
//                maxHeight = childHeight;
//        }

//        return maxHeight + 1;
//    }

//    public int CountNodes()
//    {
//        int count = 1;
//        foreach (var child in Children)
//        {
//            count += child.CountNodes();
//        }
//        return count;
//    }

//    public void DisplayTree(Func<T, string> formatter, int level = 0)
//    {
//        string indent = new string(' ', level * 2);
//        Console.WriteLine($"{indent}└─ {formatter(Data)}");

//        foreach (var child in Children)
//        {
//            child.DisplayTree(formatter, level + 1);
//        }
//    }
//}

//91
//using System;

//public class LinkedListNode<T>
//{
//    public T Data { get; set; }
//    public LinkedListNode<T> Next { get; set; }

//    public LinkedListNode(T data)
//    {
//        Data = data;
//        Next = null;
//    }

//    public void Append(T data)
//    {
//        if (Next == null)
//        {
//            Next = new LinkedListNode<T>(data);
//        }
//        else
//        {
//            Next.Append(data);
//        }
//    }

//    public void Append(LinkedListNode<T> node)
//    {
//        if (Next == null)
//        {
//            Next = node;
//        }
//        else
//        {
//            Next.Append(node);
//        }
//    }

//    public void Traverse(Action<T> action)
//    {
//        action(Data);
//        if (Next != null)
//        {
//            Next.Traverse(action);
//        }
//    }

//    public LinkedListNode<T> Find(Func<T, bool> predicate)
//    {
//        if (predicate(Data))
//            return this;

//        return Next?.Find(predicate);
//    }

//    public int Count()
//    {
//        return 1 + (Next?.Count() ?? 0);
//    }

//    public LinkedListNode<T> GetNodeAt(int index)
//    {
//        if (index == 0)
//            return this;

//        return Next?.GetNodeAt(index - 1);
//    }

//    public void Reverse(LinkedListNode<T> previous = null)
//    {
//        var next = Next;
//        Next = previous;

//        if (next != null)
//        {
//            next.Reverse(this);
//        }
//    }

//    public void DisplayList()
//    {
//        Console.Write($"{Data}");
//        if (Next != null)
//        {
//            Console.Write(" -> ");
//            Next.DisplayList();
//        }
//        else
//        {
//            Console.WriteLine(" -> null");
//        }
//    }

//    public bool Contains(T data)
//    {
//        if (Data.Equals(data))
//            return true;

//        return Next?.Contains(data) ?? false;
//    }

//    public LinkedListNode<T> Remove(T data)
//    {
//        if (Data.Equals(data))
//        {
//            return Next;
//        }

//        if (Next != null)
//        {
//            Next = Next.Remove(data);
//        }

//        return this;
//    }
//}

//public class LinkedList<T>
//{
//    public LinkedListNode<T> Head { get; set; }

//    public void AddFirst(T data)
//    {
//        var newNode = new LinkedListNode<T>(data);
//        newNode.Next = Head;
//        Head = newNode;
//    }

//    public void AddLast(T data)
//    {
//        if (Head == null)
//        {
//            Head = new LinkedListNode<T>(data);
//        }
//        else
//        {
//            Head.Append(data);
//        }
//    }

//    public void Display()
//    {
//        if (Head != null)
//        {
//            Head.DisplayList();
//        }
//        else
//        {
//            Console.WriteLine("Список пуст");
//        }
//    }
//}

//92
//using System;
//using System.Collections.Generic;

//public class Student
//{
//    public string Name { get; set; }
//    public int StudentId { get; set; }
//    public List<Course> Courses { get; set; }

//    public Student(string name, int studentId)
//    {
//        Name = name;
//        StudentId = studentId;
//        Courses = new List<Course>();
//    }

//    public void EnrollInCourse(Course course)
//    {
//        if (!Courses.Contains(course))
//        {
//            Courses.Add(course);
//            course.AddStudent(this);
//        }
//    }

//    public void DisplayCourses()
//    {
//        Console.WriteLine($"Студент: {Name}");
//        foreach (var course in Courses)
//        {
//            Console.WriteLine($"  - {course.CourseName}");
//        }
//    }
//}

//public class Course
//{
//    public string CourseName { get; set; }
//    public string CourseCode { get; set; }
//    public List<Student> Students { get; set; }

//    public Course(string courseName, string courseCode)
//    {
//        CourseName = courseName;
//        CourseCode = courseCode;
//        Students = new List<Student>();
//    }

//    public void AddStudent(Student student)
//    {
//        if (!Students.Contains(student))
//        {
//            Students.Add(student);
//        }
//    }

//    public void DisplayStudents()
//    {
//        Console.WriteLine($"Курс: {CourseName} ({CourseCode})");
//        foreach (var student in Students)
//        {
//            Console.WriteLine($"  - {student.Name}");
//        }
//    }
//}

//93
//using System;
//using System.Collections.Generic;

//public class Doctor
//{
//    public string Name { get; set; }
//    public string Specialization { get; set; }
//    public List<Patient> Patients { get; set; }

//    public Doctor(string name, string specialization)
//    {
//        Name = name;
//        Specialization = specialization;
//        Patients = new List<Patient>();
//    }

//    public void AddPatient(Patient patient)
//    {
//        if (!Patients.Contains(patient))
//        {
//            Patients.Add(patient);
//            patient.AssignDoctor(this);
//        }
//    }

//    public void DisplayPatients()
//    {
//        Console.WriteLine($"Доктор: {Name} ({Specialization})");
//        foreach (var patient in Patients)
//        {
//            Console.WriteLine($"  - {patient.Name}");
//        }
//    }
//}

//public class Patient
//{
//    public string Name { get; set; }
//    public DateTime DateOfBirth { get; set; }
//    public Doctor Doctor { get; set; }

//    public Patient(string name, DateTime dateOfBirth)
//    {
//        Name = name;
//        DateOfBirth = dateOfBirth;
//    }

//    public void AssignDoctor(Doctor doctor)
//    {
//        Doctor = doctor;
//    }

//    public void DisplayDoctor()
//    {
//        Console.WriteLine($"Пациент: {Name}");
//        if (Doctor != null)
//        {
//            Console.WriteLine($"  Лечащий врач: {Doctor.Name} ({Doctor.Specialization})");
//        }
//    }
//}

//94
//using System;
//using System.Collections.Generic;

//public class Author
//{
//    public string Name { get; set; }
//    public string Nationality { get; set; }
//    public List<Book> Books { get; set; }

//    public Author(string name, string nationality)
//    {
//        Name = name;
//        Nationality = nationality;
//        Books = new List<Book>();
//    }

//    public void WriteBook(Book book)
//    {
//        if (!Books.Contains(book))
//        {
//            Books.Add(book);
//            book.SetAuthor(this);
//        }
//    }

//    public void DisplayBooks()
//    {
//        Console.WriteLine($"Автор: {Name}");
//        foreach (var book in Books)
//        {
//            Console.WriteLine($"  - {book.Title} ({book.Year})");
//        }
//    }
//}

//public class Book
//{
//    public string Title { get; set; }
//    public int Year { get; set; }
//    public string ISBN { get; set; }
//    public Author Author { get; set; }

//    public Book(string title, int year, string isbn)
//    {
//        Title = title;
//        Year = year;
//        ISBN = isbn;
//    }

//    public void SetAuthor(Author author)
//    {
//        Author = author;
//    }

//    public void DisplayAuthor()
//    {
//        Console.WriteLine($"Книга: {Title}");
//        if (Author != null)
//        {
//            Console.WriteLine($"  Автор: {Author.Name}");
//        }
//    }
//}

//95
//using System;
//using System.Collections.Generic;

//public class Teacher
//{
//    public string Name { get; set; }
//    public string Subject { get; set; }
//    public List<Class> Classes { get; set; }

//    public Teacher(string name, string subject)
//    {
//        Name = name;
//        Subject = subject;
//        Classes = new List<Class>();
//    }

//    public void AssignToClass(Class classObj)
//    {
//        if (!Classes.Contains(classObj))
//        {
//            Classes.Add(classObj);
//            classObj.AssignTeacher(this);
//        }
//    }

//    public void DisplayClasses()
//    {
//        Console.WriteLine($"Учитель: {Name} ({Subject})");
//        foreach (var classObj in Classes)
//        {
//            Console.WriteLine($"  - {classObj.ClassName}");
//        }
//    }
//}

//public class Class
//{
//    public string ClassName { get; set; }
//    public string Room { get; set; }
//    public Teacher Teacher { get; set; }

//    public Class(string className, string room)
//    {
//        ClassName = className;
//        Room = room;
//    }

//    public void AssignTeacher(Teacher teacher)
//    {
//        Teacher = teacher;
//    }

//    public void DisplayTeacher()
//    {
//        Console.WriteLine($"Класс: {ClassName} (Аудитория: {Room})");
//        if (Teacher != null)
//        {
//            Console.WriteLine($"  Учитель: {Teacher.Name} ({Teacher.Subject})");
//        }
//    }
//}

//96
//using System;
//using System.Collections.Generic;

//public class Company
//{
//    public string Name { get; set; }
//    public string Industry { get; set; }
//    public List<Employee> Employees { get; set; }

//    public Company(string name, string industry)
//    {
//        Name = name;
//        Industry = industry;
//        Employees = new List<Employee>();
//    }

//    public void HireEmployee(Employee employee)
//    {
//        if (!Employees.Contains(employee))
//        {
//            Employees.Add(employee);
//            employee.SetCompany(this);
//        }
//    }

//    public void DisplayEmployees()
//    {
//        Console.WriteLine($"Компания: {Name} ({Industry})");
//        foreach (var employee in Employees)
//        {
//            Console.WriteLine($"  - {employee.Name} ({employee.Position})");
//        }
//    }
//}

//public class Employee
//{
//    public string Name { get; set; }
//    public string Position { get; set; }
//    public decimal Salary { get; set; }
//    public Company Company { get; set; }

//    public Employee(string name, string position, decimal salary)
//    {
//        Name = name;
//        Position = position;
//        Salary = salary;
//    }

//    public void SetCompany(Company company)
//    {
//        Company = company;
//    }

//    public void DisplayCompany()
//    {
//        Console.WriteLine($"Сотрудник: {Name} ({Position})");
//        if (Company != null)
//        {
//            Console.WriteLine($"  Компания: {Company.Name}");
//        }
//    }
//}

//97
//using System;
//using System.Collections.Generic;

//public class Library
//{
//    public string Name { get; set; }
//    public string Address { get; set; }
//    public List<Book> Books { get; set; }

//    public Library(string name, string address)
//    {
//        Name = name;
//        Address = address;
//        Books = new List<Book>();
//    }

//    public void AddBook(Book book)
//    {
//        if (!Books.Contains(book))
//        {
//            Books.Add(book);
//            book.SetLibrary(this);
//        }
//    }

//    public void DisplayBooks()
//    {
//        Console.WriteLine($"Библиотека: {Name} ({Address})");
//        foreach (var book in Books)
//        {
//            Console.WriteLine($"  - {book.Title} - {book.Author}");
//        }
//    }
//}

//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Year { get; set; }
//    public Library Library { get; set; }

//    public Book(string title, string author, int year)
//    {
//        Title = title;
//        Author = author;
//        Year = year;
//    }

//    public void SetLibrary(Library library)
//    {
//        Library = library;
//    }

//    public void DisplayLibrary()
//    {
//        Console.WriteLine($"Книга: {Title} - {Author} ({Year})");
//        if (Library != null)
//        {
//            Console.WriteLine($"  Библиотека: {Library.Name}");
//        }
//    }
//}

//98
//using System;
//using System.Collections.Generic;

//public class Team
//{
//    public string Name { get; set; }
//    public string Sport { get; set; }
//    public List<Player> Players { get; set; }

//    public Team(string name, string sport)
//    {
//        Name = name;
//        Sport = sport;
//        Players = new List<Player>();
//    }

//    public void AddPlayer(Player player)
//    {
//        if (!Players.Contains(player))
//        {
//            Players.Add(player);
//            player.SetTeam(this);
//        }
//    }

//    public void DisplayPlayers()
//    {
//        Console.WriteLine($"Команда: {Name} ({Sport})");
//        foreach (var player in Players)
//        {
//            Console.WriteLine($"  - {player.Name} (#{player.Number})");
//        }
//    }
//}

//public class Player
//{
//    public string Name { get; set; }
//    public int Number { get; set; }
//    public string Position { get; set; }
//    public Team Team { get; set; }

//    public Player(string name, int number, string position)
//    {
//        Name = name;
//        Number = number;
//        Position = position;
//    }

//    public void SetTeam(Team team)
//    {
//        Team = team;
//    }

//    public void DisplayTeam()
//    {
//        Console.WriteLine($"Игрок: {Name} (#{Number}, {Position})");
//        if (Team != null)
//        {
//            Console.WriteLine($"  Команда: {Team.Name}");
//        }
//    }
//}

//99
//using System;
//using System.Collections.Generic;

//public class Order
//{
//    public string OrderId { get; set; }
//    public DateTime OrderDate { get; set; }
//    public List<Product> Products { get; set; }
//    public decimal TotalAmount { get; set; }

//    public Order(string orderId)
//    {
//        OrderId = orderId;
//        OrderDate = DateTime.Now;
//        Products = new List<Product>();
//        TotalAmount = 0;
//    }

//    public void AddProduct(Product product)
//    {
//        if (!Products.Contains(product))
//        {
//            Products.Add(product);
//            TotalAmount += product.Price;
//            product.AddToOrder(this);
//        }
//    }

//    public void DisplayProducts()
//    {
//        Console.WriteLine($"Заказ: {OrderId} ({OrderDate:dd.MM.yyyy})");
//        foreach (var product in Products)
//        {
//            Console.WriteLine($"  - {product.Name}: {product.Price:C}");
//        }
//        Console.WriteLine($"  Итого: {TotalAmount:C}");
//    }
//}

//public class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//    public string Category { get; set; }
//    public List<Order> Orders { get; set; }

//    public Product(string name, decimal price, string category)
//    {
//        Name = name;
//        Price = price;
//        Category = category;
//        Orders = new List<Order>();
//    }

//    public void AddToOrder(Order order)
//    {
//        if (!Orders.Contains(order))
//        {
//            Orders.Add(order);
//        }
//    }

//    public void DisplayOrders()
//    {
//        Console.WriteLine($"Товар: {Name} ({Category}) - {Price:C}");
//        foreach (var order in Orders)
//        {
//            Console.WriteLine($"  - Заказ {order.OrderId} от {order.OrderDate:dd.MM.yyyy}");
//        }
//    }
//}

//100
//using System;
//using System.Collections.Generic;

//public class Project
//{
//    public string Name { get; set; }
//    public string Description { get; set; }
//    public DateTime Deadline { get; set; }
//    public List<Developer> Developers { get; set; }

//    public Project(string name, string description, DateTime deadline)
//    {
//        Name = name;
//        Description = description;
//        Deadline = deadline;
//        Developers = new List<Developer>();
//    }

//    public void AssignDeveloper(Developer developer)
//    {
//        if (!Developers.Contains(developer))
//        {
//            Developers.Add(developer);
//            developer.AssignToProject(this);
//        }
//    }

//    public void DisplayDevelopers()
//    {
//        Console.WriteLine($"Проект: {Name}");
//        Console.WriteLine($"Описание: {Description}");
//        Console.WriteLine($"Дедлайн: {Deadline:dd.MM.yyyy}");
//        Console.WriteLine("Разработчики:");
//        foreach (var developer in Developers)
//        {
//            Console.WriteLine($"  - {developer.Name} ({developer.Specialization})");
//        }
//    }
//}

//public class Developer
//{
//    public string Name { get; set; }
//    public string Specialization { get; set; }
//    public int Experience { get; set; }
//    public List<Project> Projects { get; set; }

//    public Developer(string name, string specialization, int experience)
//    {
//        Name = name;
//        Specialization = specialization;
//        Experience = experience;
//        Projects = new List<Project>();
//    }

//    public void AssignToProject(Project project)
//    {
//        if (!Projects.Contains(project))
//        {
//            Projects.Add(project);
//        }
//    }

//    public void DisplayProjects()
//    {
//        Console.WriteLine($"Разработчик: {Name} ({Specialization}, опыт: {Experience} лет)");
//        foreach (var project in Projects)
//        {
//            Console.WriteLine($"  - {project.Name} (до {project.Deadline:dd.MM.yyyy})");
//        }
//    }
//}