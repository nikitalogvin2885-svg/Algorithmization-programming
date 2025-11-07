using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//1
//public struct Point
//{
//    public double X;
//    public double Y;

//    public Point(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }

//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//2
//public struct Rectangle
//{
//    public double Width;
//    public double Height;

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public double GetArea()
//    {
//        return Width * Height;
//    }

//    public double GetPerimeter()
//    {
//        return 2 * (Width + Height);
//    }
//}

//3
//public struct Color
//{
//    public byte R;
//    public byte G;
//    public byte B;

//    public Color(byte r, byte g, byte b)
//    {
//        R = r;
//        G = g;
//        B = b;
//    }

//    public string ToHex()
//    {
//        return $"#{R:X2}{G:X2}{B:X2}";
//    }
//}

//4
//public struct Date
//{
//    public int Day;
//    public int Month;
//    public int Year;

//    public Date(int day, int month, int year)
//    {
//        Day = day;
//        Month = month;
//        Year = year;
//    }

//    public override string ToString()
//    {
//        return $"{Day:D2}.{Month:D2}.{Year}";
//    }
//}

//5
//public struct Money
//{
//    public decimal Amount { get; set; }
//    public string Currency { get; set; }

//    public Money(decimal amount, string currency = "USD")
//    {
//        Amount = amount;
//        Currency = currency;
//    }

//    public override string ToString()
//    {
//        return $"{Amount:F2} {Currency}";
//    }

//    public string FormatDetailed()
//    {
//        return $"Amount: {Amount:C}, Currency: {Currency}";
//    }

//    public string FormatShort()
//    {
//        var currencySymbols = new Dictionary<string, string>
//        {
//            { "USD", "$" },
//            { "EUR", "€" },
//            { "GBP", "£" },
//            { "RUB", "₽" },
//            { "JPY", "¥" }
//        };

//        string symbol = currencySymbols.ContainsKey(Currency) ? currencySymbols[Currency] : Currency;
//        return $"{symbol}{Amount:F2}";
//    }

//    public Money Add(Money other)
//    {
//        if (this.Currency != other.Currency)
//            throw new InvalidOperationException("Cannot add different currencies");
//        return new Money(this.Amount + other.Amount, this.Currency);
//    }

//    public Money Subtract(Money other)
//    {
//        if (this.Currency != other.Currency)
//            throw new InvalidOperationException("Cannot subtract different currencies");
//        return new Money(this.Amount - other.Amount, this.Currency);
//    }
//}


//6
//public struct Temperature
//{
//    private double _celsius;

//    public double Celsius
//    {
//        get { return _celsius; }
//        set { _celsius = value; }
//    }

//    public double Fahrenheit
//    {
//        get { return _celsius * 9 / 5 + 32; }
//        set { _celsius = (value - 32) * 5 / 9; }
//    }

//    public Temperature(double celsius)
//    {
//        _celsius = celsius;
//    }
//}

//7
//public struct Vector3D
//{
//    public double X;
//    public double Y;
//    public double Z;

//    public Vector3D(double x, double y, double z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }

//    public double Length()
//    {
//        return Math.Sqrt(X * X + Y * Y + Z * Z);
//    }

//    public Vector3D Add(Vector3D other)
//    {
//        return new Vector3D(X + other.X, Y + other.Y, Z + other.Z);
//    }

//    public Vector3D Multiply(double scalar)
//    {
//        return new Vector3D(X * scalar, Y * scalar, Z * scalar);
//    }

//    public double DotProduct(Vector3D other)
//    {
//        return X * other.X + Y * other.Y + Z * other.Z;
//    }
//}

//8
//public struct Size
//{
//    public double Width;
//    public double Height;

//    public Size(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public double GetPerimeter()
//    {
//        return 2 * (Width + Height);
//    }

//    public double GetArea()
//    {
//        return Width * Height;
//    }
//}

//9
//public struct Coordinate
//{
//    public double X { get; set; }
//    public double Y { get; set; }

//    public Coordinate(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }

//    public double DistanceTo(Coordinate other)
//    {
//        double deltaX = this.X - other.X;
//        double deltaY = this.Y - other.Y;
//        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
//    }

//    public double ManhattanDistanceTo(Coordinate other)
//    {
//        return Math.Abs(this.X - other.X) + Math.Abs(this.Y - other.Y);
//    }

//    public Coordinate Translate(double dx, double dy)
//    {
//        return new Coordinate(this.X + dx, this.Y + dy);
//    }

//    public override string ToString()
//    {
//        return $"({X:F2}, {Y:F2})";
//    }

//    public override bool Equals(object obj)
//    {
//        if (!(obj is Coordinate))
//            return false;

//        10
//public struct PhoneNumber
//    {
//        public string CountryCode;
//        public string Number;

//        public PhoneNumber(string countryCode, string number)
//        {
//            CountryCode = countryCode;
//            Number = number;
//        }

//        public override string ToString()
//        {
//            return $"+{CountryCode} {Number}";
//        }
//    }

// 11
//public struct Rating
//    {
//        private int _value;

//        public int Value
//        {
//            get { return _value; }
//            set
//            {
//                if (IsValid(value))
//                    _value = value;
//                else
//                    throw new ArgumentException("Rating must be between 1 and 5");
//            }
//        }

//        public Rating(int value)
//        {
//            _value = 1;
//            Value = value;
//        }

//        public bool IsValid(int value)
//        {
//            return value >= 1 && value <= 5;
//        }
//    }

// 12
//public struct Time
//    {
//        public int Hours;
//        public int Minutes;
//        public int Seconds;

//        public Time(int hours, int minutes, int seconds = 0)
//        {
//            Hours = hours;
//            Minutes = minutes;
//            Seconds = seconds;
//        }

//        public override string ToString()
//        {
//            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
//        }

//        public int TotalSeconds()
//        {
//            return Hours * 3600 + Minutes * 60 + Seconds;
//        }
//    }

// 13
//public struct Interval
//    {
//        public double Start;
//        public double End;

//        public Interval(double start, double end)
//        {
//            Start = start;
//            End = end;
//        }

//        public double Length()
//        {
//            return Math.Abs(End - Start);
//        }

//        public bool Contains(double value)
//        {
//            return value >= Start && value <= End;
//        }
//    }

// 14
//public struct ComplexNumber
//    {
//        public double Real;
//        public double Imaginary;

//        public ComplexNumber(double real, double imaginary)
//        {
//            Real = real;
//            Imaginary = imaginary;
//        }

//        public ComplexNumber Add(ComplexNumber other)
//        {
//            return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
//        }

//        public ComplexNumber Multiply(ComplexNumber other)
//        {
//            return new ComplexNumber(
//                Real * other.Real - Imaginary * other.Imaginary,
//                Real * other.Imaginary + Imaginary * other.Real
//            );
//        }

//        public override string ToString()
//        {
//            return $"{Real} + {Imaginary}i";
//        }
//    }

// 15
//public struct Dimensions
//    {
//        public double Length;
//        public double Width;
//        public double Height;

//        public Dimensions(double length, double width, double height)
//        {
//            Length = length;
//            Width = width;
//            Height = height;
//        }

//        public double GetVolume()
//        {
//            return Length * Width * Height;
//        }

//        public double GetSurfaceArea()
//        {
//            return 2 * (Length * Width + Length * Height + Width * Height);
//        }
//    }

// 16
//public struct Pixel
//    {
//        public int X;
//        public int Y;
//        public Color Color;

//        public Pixel(int x, int y, Color color)
//        {
//            X = x;
//            Y = y;
//            Color = color;
//        }

//        public override string ToString()
//        {
//            return $"Pixel at ({X}, {Y}) with color {Color.ToHex()}";
//        }
//    }

// 17
//public struct Angle
//    {
//        public double Degrees;

//        public Angle(double degrees)
//        {
//            Degrees = degrees;
//        }

//        public double ToRadians()
//        {
//            return Degrees * Math.PI / 180;
//        }

//        public Angle Normalize()
//        {
//            double normalized = Degrees % 360;
//            if (normalized < 0) normalized += 360;
//            return new Angle(normalized);
//        }
//    }

// 18
//public struct Speed
//    {
//        public double Value;
//        public string Unit;

//        public Speed(double value, string unit = "km/h")
//        {
//            Value = value;
//            Unit = unit;
//        }

//        public override string ToString()
//        {
//            return $"{Value:F1} {Unit}";
//        }
//    }

// 19
//public struct Weight
//    {
//        public double Kilograms;

//        public Weight(double kilograms)
//        {
//            Kilograms = kilograms;
//        }

//        public double ToPounds()
//        {
//            return Kilograms * 2.20462;
//        }

//        public double ToOunces()
//        {
//            return Kilograms * 35.274;
//        }
//    }

// 20
//public struct Duration
//    {
//        public int Days;
//        public int Hours;
//        public int Minutes;
//        public int Seconds;

//        public Duration(int days, int hours, int minutes, int seconds)
//        {
//            Days = days;
//            Hours = hours;
//            Minutes = minutes;
//            Seconds = seconds;
//        }

//        public int TotalSeconds()
//        {
//            return Days * 86400 + Hours * 3600 + Minutes * 60 + Seconds;
//        }

//        public override string ToString()
//        {
//            return $"{Days}d {Hours}h {Minutes}m {Seconds}s";
//        }
//    }

// 21
//public struct Position
//    {
//        public double X;
//        public double Y;

//        public Position(double x, double y)
//        {
//            X = x;
//            Y = y;
//        }

//        public int GetQuadrant()
//        {
//            if (X > 0 && Y > 0) return 1;
//            if (X < 0 && Y > 0) return 2;
//            if (X < 0 && Y < 0) return 3;
//            if (X > 0 && Y < 0) return 4;
//            return 0;
//        }
//    }

// 22
//public struct Fraction
//    {
//        public int Numerator;
//        public int Denominator;

//        public Fraction(int numerator, int denominator)
//        {
//            Numerator = numerator;
//            Denominator = denominator;
//        }

//        public void Simplify()
//        {
//            int gcd = GCD(Numerator, Denominator);
//            Numerator /= gcd;
//            Denominator /= gcd;
//        }

//        private int GCD(int a, int b)
//        {
//            while (b != 0)
//            {
//                int temp = b;
//                b = a % b;
//                a = temp;
//            }
//            return a;
//        }

//        public override string ToString()
//        {
//            return $"{Numerator}/{Denominator}";
//        }
//    }

// 23
//public struct Version
//    {
//        public int Major;
//        public int Minor;
//        public int Build;

//        public Version(int major, int minor, int build)
//        {
//            Major = major;
//            Minor = minor;
//            Build = build;
//        }

//        public override string ToString()
//        {
//            return $"{Major}.{Minor}.{Build}";
//        }
//    }

// 24
//public struct DataSize
//    {
//        public long Bytes;

//        public DataSize(long bytes)
//        {
//            Bytes = bytes;
//        }

//        public string Format()
//        {
//            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
//            double len = Bytes;
//            int order = 0;

//            while (len >= 1024 && order < sizes.Length - 1)
//            {
//                order++;
//                len /= 1024;
//            }

//            return $"{len:F2} {sizes[order]}";
//        }
//    }

// 25
//public struct GameScore
//    {
//        public string PlayerName;
//        public int Score;

//        public GameScore(string playerName, int score)
//        {
//            PlayerName = playerName;
//            Score = score;
//        }

//        public override string ToString()
//        {
//            return $"{PlayerName}: {Score} points";
//        }
//    }

// 26
//public struct Point
//    {
//        public double X;
//        public double Y;

//        public Point()
//        {
//            X = 0;
//            Y = 0;
//        }

//        public Point(double x, double y)
//        {
//            X = x;
//            Y = y;
//        }

//        public Point(double value)
//        {
//            X = value;
//            Y = value;
//        }
//    }

// 27
//public struct Rectangle
//    {
//        public double Width;
//        public double Height;

//        public Rectangle(double width, double height)
//        {
//            Width = width;
//            Height = height;
//        }

//        public double GetArea()
//        {
//            return Width * Height;
//        }
//    }

// 28
//public struct Color
//    {
//        public byte R;
//        public byte G;
//        public byte B;

//        public Color(byte r, byte g, byte b)
//        {
//            R = r;
//            G = g;
//            B = b;
//        }

//        public Color(string hex)
//        {
//            if (hex.StartsWith("#"))
//                hex = hex.Substring(1);

//            if (hex.Length != 6)
//                throw new ArgumentException("Hex code must be 6 characters long");

//            R = Convert.ToByte(hex.Substring(0, 2), 16);
//            G = Convert.ToByte(hex.Substring(2, 2), 16);
//            B = Convert.ToByte(hex.Substring(4, 2), 16);
//        }

//        public string ToHex()
//        {
//            return $"#{R:X2}{G:X2}{B:X2}";
//        }
//    }

// 29
//public struct Person
//    {
//        public string Name;
//        public int Age;
//        public string City;

//        public Person(string name, int age, string city)
//        {
//            Name = name;
//            Age = age;
//            City = city;
//        }

//        public override string ToString()
//        {
//            return $"{Name}, {Age} years, {City}";
//        }
//    }

// 30
//public struct Date
//    {
//        public int Day;
//        public int Month;
//        public int Year;

//        public Date(int day, int month, int year)
//        {
//            if (!IsValidDate(day, month, year))
//                throw new ArgumentException("Invalid date");

//            Day = day;
//            Month = month;
//            Year = year;
//        }

//        private bool IsValidDate(int day, int month, int year)
//        {
//            if (year < 1 || month < 1 || month > 12 || day < 1)
//                return false;

//            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

//            if (IsLeapYear(year))
//                daysInMonth[1] = 29;

//            return day <= daysInMonth[month - 1];
//        }

//        private bool IsLeapYear(int year)
//        {
//            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
//        }

//        public override string ToString()
//        {
//            return $"{Day:D2}.{Month:D2}.{Year}";
//        }
//    }

// 31
//public struct Money
//    {
//        private decimal _amount;
//        private string _currency;

//        public decimal Amount
//        {
//            get { return _amount; }
//            set
//            {
//                if (value < 0)
//                    throw new ArgumentException("Amount cannot be negative");
//                _amount = value;
//            }
//        }

//        public string Currency
//        {
//            get { return _currency; }
//            set
//            {
//                if (string.IsNullOrWhiteSpace(value) || value.Length != 3)
//                    throw new ArgumentException("Currency must be 3-letter code");
//                _currency = value.ToUpper();
//            }
//        }

//        public Money(decimal amount, string currency = "USD")
//        {
//            _amount = 0;
//            _currency = "USD";

//            Amount = amount;
//            Currency = currency;
//        }

//        public override string ToString()
//        {
//            return $"{Amount:F2} {Currency}";
//        }
//    }

// 32
//public struct Vector
//    {
//        public double X;
//        public double Y;
//        public double Z;

//        public Vector(double x, double y, double z)
//        {
//            X = x;
//            Y = y;
//            Z = z;
//        }

//        public void Initialize(double x, double y, double z)
//        {
//            X = x;
//            Y = y;
//            Z = z;
//        }

//        public double Length()
//        {
//            return Math.Sqrt(X * X + Y * Y + Z * Z);
//        }

//        public Vector Normalize()
//        {
//            double len = Length();
//            return new Vector(X / len, Y / len, Z / len);
//        }
//    }

// 33
//public struct Time
//    {
//        private int _hours;
//        private int _minutes;
//        private int _seconds;

//        public int Hours
//        {
//            get { return _hours; }
//            set
//            {
//                if (value < 0 || value > 23)
//                    throw new ArgumentException("Hours must be 0-23");
//                _hours = value;
//            }
//        }

//        public int Minutes
//        {
//            get { return _minutes; }
//            set
//            {
//                if (value < 0 || value > 59)
//                    throw new ArgumentException("Minutes must be 0-59");
//                _minutes = value;
//            }
//        }

//        public int Seconds
//        {
//            get { return _seconds; }
//            set
//            {
//                if (value < 0 || value > 59)
//                    throw new ArgumentException("Seconds must be 0-59");
//                _seconds = value;
//            }
//        }

//        public Time(int hours, int minutes, int seconds = 0)
//        {
//            _hours = 0;
//            _minutes = 0;
//            _seconds = 0;

//            Hours = hours;
//            Minutes = minutes;
//            Seconds = seconds;
//        }

//        public override string ToString()
//        {
//            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
//        }
//    }

// 34
//public struct Book
//    {
//        public string Title;
//        public string Author;
//        public int Year;
//        public string ISBN;

//        public Book(string title, string author, int year, string isbn)
//        {
//            Title = title;
//            Author = author;
//            Year = year;
//            ISBN = isbn;
//        }

//        public override string ToString()
//        {
//            return $"{Title} by {Author} ({Year}) ISBN: {ISBN}";
//        }
//    }

// 35
//public struct Circle
//    {
//        public Point Center;
//        public double Radius;

//        public Circle(Point center, double radius)
//        {
//            Center = center;
//            Radius = radius;
//        }

//        public Circle(double centerX, double centerY, double radius)
//        {
//            Center = new Point(centerX, centerY);
//            Radius = radius;
//        }

//        public double GetArea()
//        {
//            return Math.PI * Radius * Radius;
//        }

//        public double GetCircumference()
//        {
//            return 2 * Math.PI * Radius;
//        }
//    }

// 36
//public struct Product
//    {
//        public int ID;
//        public string Name;
//        public decimal Price;
//        public int Quantity;

//        public Product(int id, string name, decimal price, int quantity)
//        {
//            ID = id;
//            Name = name;
//            Price = price;
//            Quantity = quantity;
//        }

//        public decimal GetTotalValue()
//        {
//            return Price * Quantity;
//        }

//        public override string ToString()
//        {
//            return $"{ID}: {Name} - {Price:C} (Qty: {Quantity})";
//        }
//    }

// 37
//public struct Triangle
//    {
//        public double SideA;
//        public double SideB;
//        public double SideC;

//        public Triangle(double a, double b, double c)
//        {
//            if (!IsValidTriangle(a, b, c))
//                throw new ArgumentException("Invalid triangle sides");

//            SideA = a;
//            SideB = b;
//            SideC = c;
//        }

//        private bool IsValidTriangle(double a, double b, double c)
//        {
//            return a > 0 && b > 0 && c > 0 &&
//                   a + b > c && a + c > b && b + c > a;
//        }

//        public double GetPerimeter()
//        {
//            return SideA + SideB + SideC;
//        }

//        public double GetArea()
//        {
//            double p = GetPerimeter() / 2;
//            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
//        }
//    }

// 38
//public struct Student
//    {
//        public string FirstName;
//        public string LastName;
//        public int Age;
//        public string Group;
//        public double AverageGrade;

//        public Student(string firstName, string lastName, int age, string group, double averageGrade)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Age = age;
//            Group = group;
//            AverageGrade = averageGrade;
//        }

//        public string GetFullName()
//        {
//            return $"{FirstName} {LastName}";
//        }

//        public override string ToString()
//        {
//            return $"{GetFullName()}, {Age} years, Group: {Group}, Grade: {AverageGrade:F1}";
//        }
//    }

// 39
//public struct Address
//    {
//        public string Street;
//        public string City;
//        public string State;
//        public string ZipCode;
//        public string Country;

//        public Address(string street, string city, string state, string zipCode, string country = "USA")
//        {
//            Street = street;
//            City = city;
//            State = state;
//            ZipCode = zipCode;
//            Country = country;
//        }

//        public string GetFullAddress()
//        {
//            return $"{Street}, {City}, {State} {ZipCode}, {Country}";
//        }

//        public override string ToString()
//        {
//            return GetFullAddress();
//        }
//    }

// 40
//public struct BankAccount
//    {
//        public string AccountNumber;
//        public decimal Balance;

//        public BankAccount(string accountNumber, decimal initialBalance = 0)
//        {
//            if (string.IsNullOrWhiteSpace(accountNumber))
//                throw new ArgumentException("Account number cannot be empty");

//            AccountNumber = accountNumber;
//            Balance = initialBalance;
//        }

//        public void Deposit(decimal amount)
//        {
//            if (amount <= 0)
//                throw new ArgumentException("Deposit amount must be positive");
//            Balance += amount;
//        }

//        public bool Withdraw(decimal amount)
//        {
//            if (amount <= 0 || amount > Balance)
//                return false;

//            Balance -= amount;
//            return true;
//        }

//        public override string ToString()
//        {
//            return $"Account: {AccountNumber}, Balance: {Balance:C}";
//        }
//    }

// 41
//public struct Car
//    {
//        public string Make;
//        public string Model;
//        public int Year;

//        public Car(string make, string model, int year)
//        {
//            Make = make;
//            Model = model;
//            Year = year;
//        }

//        public int GetAge(int currentYear)
//        {
//            return currentYear - Year;
//        }

//        public override string ToString()
//        {
//            return $"{Year} {Make} {Model}";
//        }
//    }

// 42
//public struct PhoneNumber
//    {
//        public string CountryCode;
//        public string Number;

//        public PhoneNumber(string countryCode, string number)
//        {
//            CountryCode = countryCode;
//            Number = number;
//        }

//        public PhoneNumber(string phoneString)
//        {
//            if (string.IsNullOrWhiteSpace(phoneString))
//                throw new ArgumentException("Phone string cannot be empty");

//            if (phoneString.StartsWith("+"))
//            {
//                int spaceIndex = phoneString.IndexOf(' ');
//                if (spaceIndex > 0)
//                {
//                    CountryCode = phoneString.Substring(1, spaceIndex - 1);
//                    Number = phoneString.Substring(spaceIndex + 1);
//                }
//                else
//                {
//                    throw new ArgumentException("Invalid phone number format");
//                }
//            }
//            else
//            {
//                CountryCode = "7";
//                Number = phoneString;
//            }
//        }

//        public override string ToString()
//        {
//            return $"+{CountryCode} {Number}";
//        }
//    }

// 43
//public struct Matrix
//    {
//        private int _rows;
//        private int _cols;
//        private double[,] _data;

//        public int Rows => _rows;
//        public int Cols => _cols;

//        public Matrix(int rows, int cols)
//        {
//            if (rows <= 0 || cols <= 0)
//                throw new ArgumentException("Matrix dimensions must be positive");

//            _rows = rows;
//            _cols = cols;
//            _data = new double[rows, cols];
//        }

//        public double this[int row, int col]
//        {
//            get => _data[row, col];
//            set => _data[row, col] = value;
//        }

//        public void Fill(double value)
//        {
//            for (int i = 0; i < _rows; i++)
//                for (int j = 0; j < _cols; j++)
//                    _data[i, j] = value;
//        }

//        public override string ToString()
//        {
//            var sb = new StringBuilder();
//            for (int i = 0; i < _rows; i++)
//            {
//                for (int j = 0; j < _cols; j++)
//                {
//                    sb.Append(_data[i, j].ToString("F2").PadLeft(8));
//                }
//                sb.AppendLine();
//            }
//            return sb.ToString();
//        }
//    }

// 44
//public struct Employee
//    {
//        public string FirstName;
//        public string LastName;
//        public string Position;
//        public decimal Salary;

//        public Employee(string firstName, string lastName, string position, decimal salary)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Position = position;
//            Salary = salary;
//        }

//        public string GetFullName()
//        {
//            return $"{FirstName} {LastName}";
//        }

//        public decimal GetAnnualSalary()
//        {
//            return Salary * 12;
//        }

//        public override string ToString()
//        {
//            return $"{GetFullName()}, {Position}, Salary: {Salary:C}";
//        }
//    }

// 45
//public struct Email
//    {
//        private string _address;

//        public string Address
//        {
//            get { return _address; }
//            set
//            {
//                if (!IsValidEmail(value))
//                    throw new ArgumentException("Invalid email address");
//                _address = value;
//            }
//        }

//        public Email(string address)
//        {
//            _address = "";
//            Address = address;
//        }

//        private bool IsValidEmail(string email)
//        {
//            if (string.IsNullOrWhiteSpace(email))
//                return false;

//            try
//            {
//                var addr = new System.Net.Mail.MailAddress(email);
//                return addr.Address == email;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//        public string GetUsername()
//        {
//            return _address.Split('@')[0];
//        }

//        public string GetDomain()
//        {
//            return _address.Split('@')[1];
//        }

//        public override string ToString()
//        {
//            return _address;
//        }
//    }

// 46
//public struct Appointment
//    {
//        public Date Date;
//        public Time Time;
//        public string Description;

//        public Appointment(Date date, Time time, string description)
//        {
//            Date = date;
//            Time = time;
//            Description = description;
//        }

//        public override string ToString()
//        {
//            return $"{Date} {Time} - {Description}";
//        }
//    }

// 47
//public struct Recipe
//    {
//        public string Name;
//        public string[] Ingredients;
//        public string Instructions;

//        public Recipe(string name, string[] ingredients, string instructions = "")
//        {
//            Name = name;
//            Ingredients = ingredients;
//            Instructions = instructions;
//        }

//        public int GetIngredientCount()
//        {
//            return Ingredients?.Length ?? 0;
//        }

//        public override string ToString()
//        {
//            return $"{Name} ({GetIngredientCount()} ingredients)";
//        }
//    }

// 48
//public struct SocialProfile
//    {
//        public string Username;
//        public string Platform;

//        public SocialProfile(string username, string platform)
//        {
//            Username = username;
//            Platform = platform;
//        }

//        public string GetProfileUrl()
//        {
//            return Platform.ToLower() switch
//            {
//                "twitter" => $"https://twitter.com/{Username}",
//                "instagram" => $"https://instagram.com/{Username}",
//                "github" => $"https://github.com/{Username}",
//                _ => $"https://{Platform}.com/{Username}"
//            };
//        }

//        public override string ToString()
//        {
//            return $"{Username} on {Platform}";
//        }
//    }

// 49
//public struct Measurement
//    {
//        public double Value;
//        public string Unit;

//        public Measurement(double value, string unit)
//        {
//            Value = value;
//            Unit = unit;
//        }

//        public Measurement ConvertTo(string newUnit)
//        {
//            double newValue = Value;

//            if (Unit == "cm" && newUnit == "m")
//                newValue = Value / 100;
//            else if (Unit == "m" && newUnit == "cm")
//                newValue = Value * 100;
//            else if (Unit == "kg" && newUnit == "g")
//                newValue = Value * 1000;
//            else if (Unit == "g" && newUnit == "kg")
//                newValue = Value / 1000;

//            return new Measurement(newValue, newUnit);
//        }

//        public override string ToString()
//        {
//            return $"{Value} {Unit}";
//        }
//    }

// 50
//public struct Password
//    {
//        private string _value;

//        public string Value
//        {
//            get { return _value; }
//            set
//            {
//                if (!IsStrongPassword(value))
//                    throw new ArgumentException("Password does not meet strength requirements");
//                _value = value;
//            }
//        }

//        public Password(string password)
//        {
//            _value = "";
//            Value = password;
//        }

//        private bool IsStrongPassword(string password)
//        {
//            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
//                return false;

//            bool hasUpper = false;
//            bool hasLower = false;
//            bool hasDigit = false;
//            bool hasSpecial = false;

//            foreach (char c in password)
//            {
//                if (char.IsUpper(c)) hasUpper = true;
//                if (char.IsLower(c)) hasLower = true;
//                if (char.IsDigit(c)) hasDigit = true;
//                if (char.IsPunctuation(c) || char.IsSymbol(c)) hasSpecial = true;
//            }

//            return hasUpper && hasLower && hasDigit && hasSpecial;
//        }

//        public int GetStrengthScore()
//        {
//            int score = 0;
//            if (_value.Length >= 8) score++;
//            if (_value.Length >= 12) score++;

//            bool hasUpper = _value.Any(char.IsUpper);
//            bool hasLower = _value.Any(char.IsLower);
//            bool hasDigit = _value.Any(char.IsDigit);
//            bool hasSpecial = _value.Any(c => char.IsPunctuation(c) || char.IsSymbol(c));

//            if (hasUpper && hasLower) score++;
//            if (hasDigit) score++;
//            if (hasSpecial) score++;

//            return score;
//        }
//    }

//51
//public interface IShape
//{
//    double Area();
//}

//public struct Point
//{
//    public double X { get; }
//    public double Y { get; }

//    public Point(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }
//}

//public struct Shape : IShape
//{
//    public virtual double Area()
//    {
//        return 0;
//    }
//}

//public struct Circle : Shape
//{
//    public double Radius { get; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public override double Area()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//52
//public struct Vehicle
//{
//    public string Type { get; }

//    public Vehicle(string type)
//    {
//        Type = type;
//    }
//}

//public struct Car : Vehicle
//{
//    public string Model { get; }

//    public Car(string model) : base("Автомобиль")
//    {
//        Model = model;
//    }
//}

//public struct Bicycle : Vehicle
//{
//    public bool HasBasket { get; }

//    public Bicycle(bool hasBasket) : base("Велосипед")
//    {
//        HasBasket = hasBasket;
//    }
//}

//53
//public struct Animal
//{
//    public string Name { get; }

//    public Animal(string name)
//    {
//        Name = name;
//    }
//}

//public struct Dog : Animal
//{
//    public Dog(string name) : base(name) { }

//    public void Bark()
//    {
//        Console.WriteLine($"{Name} says: Woof!");
//    }
//}

//54
//public struct Point : IComparable<Point>
//{
//    public double X { get; }
//    public double Y { get; }

//    public Point(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }

//    public int CompareTo(Point other)
//    {
//        double thisMagnitude = Math.Sqrt(X * X + Y * Y);
//        double otherMagnitude = Math.Sqrt(other.X * other.X + other.Y * other.Y);
//        return thisMagnitude.CompareTo(otherMagnitude);
//    }
//}

//55
//public struct Number : IEquatable<Number>
//{
//    public int Value { get; }

//    public Number(int value)
//    {
//        Value = value;
//    }

//    public bool Equals(Number other)
//    {
//        return Value == other.Value;
//    }
//}

//56
//public struct Employee : ICloneable
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Employee(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public object Clone()
//    {
//        return new Employee(Name, Age);
//    }
//}

//57
//public interface IDrawable
//{
//    void Draw();
//}

//public struct Shape : IDrawable
//{
//    public void Draw()
//    {
//        Console.WriteLine("Drawing a shape.");
//    }
//}

//58
//public interface IValidatable
//{
//    bool IsValid();
//}

//public struct Person : IValidatable
//{
//    public string Name { get; }
//    public int Age { get; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public bool IsValid()
//    {
//        return !string.IsNullOrEmpty(Name) && Age > 0;
//    }
//}

//59
//public interface ISaveable
//{
//    void Save();
//}

//public struct Document : ISaveable
//{
//    public string Content { get; set; }

//    public void Save()
//    {
//        Console.WriteLine("Document saved.");
//    }
//}

//60
//public struct Container<T> : IEnumerable
//{
//    private T[] items;

//    public Container(T[] items)
//    {
//        this.items = items;
//    }

//    public IEnumerator GetEnumerator()
//    {
//        return items.GetEnumerator();
//    }
//}

//61
//public struct Stream : IDisposable
//{
//    public void Dispose()
//    {
//        Console.WriteLine("Stream disposed.");
//    }
//}

//62
//public struct Person : IComparable<Person>
//{
//    public string Name { get; }
//    public int Age { get; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public int CompareTo(Person other)
//    {
//        return Age.CompareTo(other.Age);
//    }
//}

//63
//public struct Money : IFormattable
//{
//    public decimal Amount { get; }

//    public Money(decimal amount)
//    {
//        Amount = amount;
//    }

//    public string ToString(string format, IFormatProvider formatProvider)
//    {
//        return Amount.ToString(format, formatProvider);
//    }
//}

//64
//public struct Event
//{
//    public event Action OnEvent;

//    public void TriggerEvent()
//    {
//        OnEvent?.Invoke();
//    }
//}

//65
//public interface ILogger
//{
//    void Log(string message);
//}

//public struct Logger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Log: {message}");
//    }
//}

//66
//public struct Collection<T> : ICollection
//{
//    private ArrayList items = new ArrayList();

//    public int Count => items.Count;
//    public bool IsSynchronized => false;
//    public object SyncRoot => this;

//    public void CopyTo(Array array, int index)
//    {
//        items.CopyTo(array, index);
//    }

//    public IEnumerator GetEnumerator()
//    {
//        return items.GetEnumerator();
//    }
//}

//67
//public interface IObserver<T>
//{
//    void OnNext(T value);
//}

//public struct Observer<T> : IObserver<T>
//{
//    public void OnNext(T value)
//    {
//        Console.WriteLine($"Observed: {value}");
//    }
//}

//68
//public struct Service : IDisposable
//{
//    public void Dispose()
//    {
//        Console.WriteLine("Service disposed.");
//    }

//    ~Service()
//    {
//        Dispose();
//    }
//}

//69
//public interface IValidator<T>
//{
//    bool Validate(T item);
//}

//public struct Validator<T> : IValidator<T>
//{
//    public bool Validate(T item)
//    {
//        return item != null;
//    }
//}

//70
//public struct Handler
//{
//    public event Action OnHandle;

//    public void Handle()
//    {
//        OnHandle?.Invoke();
//    }
//}

//71
//public interface ICacheable
//{
//    void Cache();
//}

//public struct Cache : ICacheable
//{
//    public void Cache()
//    {
//        Console.WriteLine("Data cached.");
//    }
//}

//72
//public interface IParser<T>
//{
//    T Parse(string input);
//}

//public struct Parser<T> : IParser<T>
//{
//    public T Parse(string input)
//    {
//        return (T)(object)input;
//    }
//}

//73
//public struct Comparer<T> : IComparer
//{
//    public int Compare(object x, object y)
//    {
//        return Comparer<T>.Default.Compare((T)x, (T)y);
//    }
//}

//74
//public struct Serializable : ISerializable
//{
//    public void GetObjectData(SerializationInfo info, StreamingContext context)
//    {
//        info.AddValue("Data", "Serializable Data");
//    }
//}

//75
//public struct AsyncTask
//{
//    public async Task DoAsync()
//    {
//        await Task.Delay(1000);
//        Console.WriteLine("Async operation completed.");
//    }
//}

//76
//public struct Employee
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Employee(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

//public struct Company
//{
//    public string Name { get; set; }
//    public Employee[] Employees { get; set; }

//    public Company(string name, Employee[] employees)
//    {
//        Name = name;
//        Employees = employees;
//    }
//}

//77
//public class Node<T>
//{
//    public T Value { get; set; }
//    public List<Node<T>> Children { get; set; }

//    public Node(T value)
//    {
//        Value = value;
//        Children = new List<Node<T>>();
//    }
//}

//public struct Tree<T>
//{
//    public Node<T> Root { get; set; }

//    public Tree(Node<T> root)
//    {
//        Root = root;
//    }
//}

//78
//public class Vertex<T>
//{
//    public T Value { get; set; }

//    public Vertex(T value)
//    {
//        Value = value;
//    }
//}

//public class Edge<T>
//{
//    public Vertex<T> From { get; set; }
//    public Vertex<T> To { get; set; }

//    public Edge(Vertex<T> from, Vertex<T> to)
//    {
//        From = from;
//        To = to;
//    }
//}

//public struct Graph<T>
//{
//    public List<Vertex<T>> Vertices { get; set; }
//    public List<Edge<T>> Edges { get; set; }

//    public Graph(List<Vertex<T>> vertices, List<Edge<T>> edges)
//    {
//        Vertices = vertices;
//        Edges = edges;
//    }
//}

//79
//public struct Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }

//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }
//}

//public struct Library
//{
//    public string Name { get; set; }
//    public List<Book> Books { get; set; }

//    public Library(string name, List<Book> books)
//    {
//        Name = name;
//        Books = books;
//    }
//}

//80
//public struct Article
//{
//    public string Term { get; set; }
//    public string Definition { get; set; }

//    public Article(string term, string definition)
//    {
//        Term = term;
//        Definition = definition;
//    }
//}

//public struct Dictionary
//{
//    public string Name { get; set; }
//    public List<Article> Articles { get; set; }

//    public Dictionary(string name, List<Article> articles)
//    {
//        Name = name;
//        Articles = articles;
//    }
//}

//81
//public class Node<T>
//{
//    public T Value { get; set; }
//    public Node<T> Next { get; set; }

//    public Node(T value)
//    {
//        Value = value;
//        Next = null;
//    }
//}

//public struct LinkedList<T>
//{
//    public Node<T> Head { get; set; }

//    public LinkedList(Node<T> head)
//    {
//        Head = head;
//    }
//}

//82
//public class Column
//{
//    public string Name { get; set; }
//    public string Type { get; set; }

//    public Column(string name, string type)
//    {
//        Name = name;
//        Type = type;
//    }
//}

//public class Table
//{
//    public string Name { get; set; }
//    public List<Column> Columns { get; set; }

//    public Table(string name, List<Column> columns)
//    {
//        Name = name;
//        Columns = columns;
//    }
//}

//public struct Database
//{
//    public string Name { get; set; }
//    public List<Table> Tables { get; set; }

//    public Database(string name, List<Table> tables)
//    {
//        Name = name;
//        Tables = tables;
//    }
//}

//83
//public class Button
//{
//    public string Text { get; set; }

//    public Button(string text)
//    {
//        Text = text;
//    }
//}

//public class TextField
//{
//    public string Placeholder { get; set; }

//    public TextField(string placeholder)
//    {
//        Placeholder = placeholder;
//    }
//}

//public struct Window
//{
//    public string Title { get; set; }
//    public List<Button> Buttons { get; set; }
//    public List<TextField> TextFields { get; set; }

//    public Window(string title, List<Button> buttons, List<TextField> textFields)
//    {
//        Title = title;
//        Buttons = buttons;
//        TextFields = textFields;
//    }
//}

//84
//public struct Player
//{
//    public string Name { get; set; }
//    public int Score { get; set; }

//    public Player(string name, int score)
//    {
//        Name = name;
//        Score = score;
//    }
//}

//public struct Level
//{
//    public int Number { get; set; }
//    public string Difficulty { get; set; }

//    public Level(int number, string difficulty)
//    {
//        Number = number;
//        Difficulty = difficulty;
//    }
//}

//public struct Game
//{
//    public string Name { get; set; }
//    public Player[] Players { get; set; }
//    public Level[] Levels { get; set; }

//    public Game(string name, Player[] players, Level[] levels)
//    {
//        Name = name;
//        Players = players;
//        Levels = levels;
//    }
//}

//85
//public class Request
//{
//    public string Endpoint { get; set; }
//    public string Method { get; set; }

//    public Request(string endpoint, string method)
//    {
//        Endpoint = endpoint;
//        Method = method;
//    }
//}

//public class Response
//{
//    public int StatusCode { get; set; }
//    public string Body { get; set; }

//    public Response(int statusCode, string body)
//    {
//        StatusCode = statusCode;
//        Body = body;
//    }
//}

//public struct API
//{
//    public string Name { get; set; }
//    public List<Request> Requests { get; set; }
//    public List<Response> Responses { get; set; }

//    public API(string name, List<Request> requests, List<Response> responses)
//    {
//        Name = name;
//        Requests = requests;
//        Responses = responses;
//    }
//}

//86
//public class Task
//{
//    public string Name { get; set; }
//    public bool IsCompleted { get; set; }

//    public Task(string name, bool isCompleted)
//    {
//        Name = name;
//        IsCompleted = isCompleted;
//    }
//}

//public class Milestone
//{
//    public string Name { get; set; }
//    public DateTime Deadline { get; set; }

//    public Milestone(string name, DateTime deadline)
//    {
//        Name = name;
//        Deadline = deadline;
//    }
//}

//public struct Project
//{
//    public string Name { get; set; }
//    public List<Task> Tasks { get; set; }
//    public List<Milestone> Milestones { get; set; }

//    public Project(string name, List<Task> tasks, List<Milestone> milestones)
//    {
//        Name = name;
//        Tasks = tasks;
//        Milestones = milestones;
//    }
//}

//87
//public class Item
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }

//    public Item(string name, decimal price)
//    {
//        Name = name;
//        Price = price;
//    }
//}

//public class Submenu
//{
//    public string Name { get; set; }
//    public List<Item> Items { get; set; }

//    public Submenu(string name, List<Item> items)
//    {
//        Name = name;
//        Items = items;
//    }
//}

//public struct Menu
//{
//    public string Name { get; set; }
//    public List<Submenu> Submenus { get; set; }

//    public Menu(string name, List<Submenu> submenus)
//    {
//        Name = name;
//        Submenus = submenus;
//    }
//}

//88
//public class Paragraph
//{
//    public string Text { get; set; }

//    public Paragraph(string text)
//    {
//        Text = text;
//    }
//}

//public class Section
//{
//    public string Title { get; set; }
//    public List<Paragraph> Paragraphs { get; set; }

//    public Section(string title, List<Paragraph> paragraphs)
//    {
//        Title = title;
//        Paragraphs = paragraphs;
//    }
//}

//public struct Document
//{
//    public string Title { get; set; }
//    public List<Section> Sections { get; set; }

//    public Document(string title, List<Section> sections)
//    {
//        Title = title;
//        Sections = sections;
//    }
//}

//89
//public struct Port
//{
//    public int Number { get; set; }
//    public string Protocol { get; set; }

//    public Port(int number, string protocol)
//    {
//        Number = number;
//        Protocol = protocol;
//    }
//}

//public struct Host
//{
//    public string IPAddress { get; set; }
//    public List<Port> Ports { get; set; }

//    public Host(string ipAddress, List<Port> ports)
//    {
//        IPAddress = ipAddress;
//        Ports = ports;
//    }
//}

//public struct Network
//{
//    public string Name { get; set; }
//    public List<Host> Hosts { get; set; }

//    public Network(string name, List<Host> hosts)
//    {
//        Name = name;
//        Hosts = hosts;
//    }
//}

//90
//public struct Detail
//{
//    public string Product { get; set; }
//    public int Quantity { get; set; }

//    public Detail(string product, int quantity)
//    {
//        Product = product;
//        Quantity = quantity;
//    }
//}

//public struct Transaction
//{
//    public int Id { get; set; }
//    public List<Detail> Details { get; set; }

//    public Transaction(int id, List<Detail> details)
//    {
//        Id = id;
//        Details = details;
//    }
//}

//91
//public class Field
//{
//    public string Name { get; set; }
//    public string Value { get; set; }

//    public Field(string name, string value)
//    {
//        Name = name;
//        Value = value;
//    }
//}

//public struct Form
//{
//    public string Title { get; set; }
//    public List<Field> Fields { get; set; }

//    public Form(string title, List<Field> fields)
//    {
//        Title = title;
//        Fields = fields;
//    }
//}

//92
//public class Header
//{
//    public string Title { get; set; }
//    public DateTime Date { get; set; }

//    public Header(string title, DateTime date)
//    {
//        Title = title;
//        Date = date;
//    }
//}

//public class Body
//{
//    public string Content { get; set; }

//    public Body(string content)
//    {
//        Content = content;
//    }
//}

//public struct Report
//{
//    public Header Header { get; set; }
//    public Body Body { get; set; }

//    public Report(Header header, Body body)
//    {
//        Header = header;
//        Body = body;
//    }
//}

//93
//public struct CartItem
//{
//    public string Product { get; set; }
//    public int Quantity { get; set; }

//    public CartItem(string product, int quantity)
//    {
//        Product = product;
//        Quantity = quantity;
//    }
//}

//public struct Shopping
//{
//    public List<CartItem> CartItems { get; set; }

//    public Shopping(List<CartItem> cartItems)
//    {
//        CartItems = cartItems;
//    }
//}

//94
//public class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Student(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

//public class Class
//{
//    public string Name { get; set; }
//    public List<Student> Students { get; set; }

//    public Class(string name, List<Student> students)
//    {
//        Name = name;
//        Students = students;
//    }
//}

//public struct School
//{
//    public string Name { get; set; }
//    public List<Class> Classes { get; set; }

//    public School(string name, List<Class> classes)
//    {
//        Name = name;
//        Classes = classes;
//    }
//}

//95
//public struct Doctor
//{
//    public string Name { get; set; }
//    public string Specialization { get; set; }

//    public Doctor(string name, string specialization)
//    {
//        Name = name;
//        Specialization = specialization;
//    }
//}

//public struct Patient
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Patient(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

//public struct Hospital
//{
//    public string Name { get; set; }
//    public List<Doctor> Doctors { get; set; }
//    public List<Patient> Patients { get; set; }

//    public Hospital(string name, List<Doctor> doctors, List<Patient> patients)
//    {
//        Name = name;
//        Doctors = doctors;
//        Patients = patients;
//    }
//}

//96
//public class Node<T>
//{
//    public T Value { get; set; }
//    public Node<T> Next { get; set; }

//    public Node(T value)
//    {
//        Value = value;
//        Next = null;
//    }
//}

//public struct Queue<T>
//{
//    public Node<T> Head { get; set; }
//    public Node<T> Tail { get; set; }

//    public void Enqueue(T value)
//    {
//        Node<T> newNode = new Node<T>(value);
//        if (Head == null)
//        {
//            Head = newNode;
//            Tail = newNode;
//        }
//        else
//        {
//            Tail.Next = newNode;
//            Tail = newNode;
//        }
//    }
//}

//97
//public class Element<T>
//{
//    public T Value { get; set; }
//    public Element<T> Next { get; set; }

//    public Element(T value)
//    {
//        Value = value;
//        Next = null;
//    }
//}

//public struct Stack<T>
//{
//    public Element<T> Top { get; set; }

//    public void Push(T value)
//    {
//        Element<T> newElement = new Element<T>(value);
//        newElement.Next = Top;
//        Top = newElement;
//    }
//}

//98
//public interface IElement
//{
//    void Display();
//}

//public struct Container<T> where T : IElement
//{
//    public List<T> Elements { get; set; }

//    public Container(List<T> elements)
//    {
//        Elements = elements;
//    }

//    public void DisplayAll()
//    {
//        foreach (var element in Elements)
//        {
//            element.Display();
//        }
//    }
//}

//99
//public class Comment
//{
//    public string Author { get; set; }
//    public string Text { get; set; }

//    public Comment(string author, string text)
//    {
//        Author = author;
//        Text = text;
//    }
//}

//public class Post
//{
//    public string Title { get; set; }
//    public string Content { get; set; }
//    public List<Comment> Comments { get; set; }

//    public Post(string title, string content, List<Comment> comments)
//    {
//        Title = title;
//        Content = content;
//        Comments = comments;
//    }
//}

//public struct Blog
//{
//    public string Name { get; set; }
//    public List<Post> Posts { get; set; }

//    public Blog(string name, List<Post> posts)
//    {
//        Name = name;
//        Posts = posts;
//    }
//}

//100
//public struct Entity
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Entity(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }
//}

//public struct Repository
//{
//    public string Name { get; set; }
//    public List<Entity> Entities { get; set; }

//    public Repository(string name, List<Entity> entities)
//    {
//        Name = name;
//        Entities = entities;
//    }
//}
