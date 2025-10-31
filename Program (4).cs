//1
//class Animal
//{
//    protected string name;
//    public Animal(string name)
//    {
//        this.name = name;
//    }
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Животное издает звук");
//    }
//}

//class Cat : Animal
//{
//    public Cat(string name) : base(name) { }
//    public override void MakeSound()
//    {
//        Console.WriteLine($"{name} говорит: Мяу!");
//    }
//}

//2
//class Vehicle
//{
//    protected string brand;
//    public Vehicle(string brand)
//    {
//        this.brand = brand;
//    }
//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Транспорт: {brand}");
//    }
//}

//class Car : Vehicle
//{
//    private int doors;
//    public Car(string brand, int doors) : base(brand)
//    {
//        this.doors = doors;
//    }
//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Автомобиль {brand}, {doors} дверей");
//    }
//}

//class Bus : Vehicle
//{
//    private int passengers;
//    public Bus(string brand, int passengers) : base(brand)
//    {
//        this.passengers = passengers;
//    }
//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Автобус {brand}, {passengers} пассажиров");
//    }
//}

//3
//class Shape
//{
//    protected string color;
//    public Shape(string color)
//    {
//        this.color = color;
//    }
//    public virtual void Draw()
//    {
//        Console.WriteLine($"Рисую фигуру цвета {color}");
//    }
//}

//class Circle : Shape
//{
//    private double radius;
//    public Circle(string color, double radius) : base(color)
//    {
//        this.radius = radius;
//    }
//    public override void Draw()
//    {
//        Console.WriteLine($"Рисую круг цвета {color}, радиус: {radius}");
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
//    public override void Draw()
//    {
//        Console.WriteLine($"Рисую прямоугольник цвета {color}, размер: {width}x{height}");
//    }
//}

//4
//class BaseClass
//{
//    public virtual void ShowMessage()
//    {
//        Console.WriteLine("Сообщение из базового класса");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public override void ShowMessage()
//    {
//        Console.WriteLine("Сообщение из производного класса");
//    }
//}

//5
//class Person
//{
//    protected string name;
//    public Person(string name)
//    {
//        this.name = name;
//    }
//}

//class Student : Person
//{
//    private int grade;
//    public Student(string name, int grade) : base(name)
//    {
//        this.grade = grade;
//    }
//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Студент: {name}, класс: {grade}");
//    }
//}

//6
//class Employee
//{
//    protected string name;
//    protected decimal salary;
//    public Employee(string name, decimal salary)
//    {
//        this.name = name;
//        this.salary = salary;
//    }
//    public virtual void Work()
//    {
//        Console.WriteLine($"{name} работает");
//    }
//}

//class Manager : Employee
//{
//    private string department;
//    public Manager(string name, decimal salary, string department) : base(name, salary)
//    {
//        this.department = department;
//    }
//    public override void Work()
//    {
//        Console.WriteLine($"{name} управляет отделом {department}");
//    }
//}

//class Developer : Employee
//{
//    private string language;
//    public Developer(string name, decimal salary, string language) : base(name, salary)
//    {
//        this.language = language;
//    }
//    public override void Work()
//    {
//        Console.WriteLine($"{name} программирует на {language}");
//    }
//}

//7
//class Person2
//{
//    protected string name;
//    protected int age;
//    public Person2(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }
//}

//class Student2 : Person2
//{
//    private string studentId;
//    public Student2(string name, int age, string studentId) : base(name, age)
//    {
//        this.studentId = studentId;
//    }
//    public void Display()
//    {
//        Console.WriteLine($"Студент: {name}, возраст: {age}, ID: {studentId}");
//    }
//}

//8
//class BaseClass2
//{
//    protected int protectedField = 10;
//    protected string GetProtectedInfo()
//    {
//        return "Защищенная информация";
//    }
//}

//class DerivedClass2 : BaseClass2
//{
//    public void AccessProtected()
//    {
//        Console.WriteLine($"Защищенное поле: {protectedField}");
//        Console.WriteLine(GetProtectedInfo());
//    }
//}

//9
//class Shape2
//{
//    protected string color;
//    public Shape2(string color)
//    {
//        this.color = color;
//    }
//    public virtual double CalculateArea()
//    {
//        return 0;
//    }
//}

//class Circle2 : Shape2
//{
//    private double radius;
//    public Circle2(string color, double radius) : base(color)
//    {
//        this.radius = radius;
//    }
//    public override double CalculateArea()
//    {
//        return Math.PI * radius * radius;
//    }
//}

//class Rectangle2 : Shape2
//{
//    private double width;
//    private double height;
//    public Rectangle2(string color, double width, double height) : base(color)
//    {
//        this.width = width;
//        this.height = height;
//    }
//    public override double CalculateArea()
//    {
//        return width * height;
//    }
//}

//10
//class Animal2
//{
//    protected string type;
//    public Animal2(string type)
//    {
//        this.type = type;
//    }
//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Тип животного: {type}");
//    }
//}

//class Mammal : Animal2
//{
//    public Mammal(string type) : base(type) { }
//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Млекопитающее: {type}");
//    }
//}

//class Bird : Animal2
//{
//    public Bird(string type) : base(type) { }
//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"Птица: {type}");
//    }
//}

//11
//abstract class AnimalBase
//{
//    protected string name;
//    public AnimalBase(string name)
//    {
//        this.name = name;
//    }
//    public abstract void MakeSound();
//    public void Sleep()
//    {
//        Console.WriteLine($"{name} спит");
//    }
//}

//class Dog : AnimalBase
//{
//    public Dog(string name) : base(name) { }
//    public override void MakeSound()
//    {
//        Console.WriteLine($"{name} говорит: Гав!");
//    }
//}

//12
//class Shape3
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Рисую фигуру");
//    }
//}

//class Triangle : Shape3
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Рисую треугольник");
//    }
//}

//13
//class Animal3
//{
//    protected string species;
//    public Animal3(string species)
//    {
//        this.species = species;
//    }
//    public virtual void Display()
//    {
//        Console.WriteLine($"Вид: {species}");
//    }
//}

//class Lion : Animal3
//{
//    public Lion() : base("Лев") { }
//    public override void Display()
//    {
//        Console.WriteLine($"Царь зверей - {species}");
//    }
//}

//class Elephant : Animal3
//{
//    public Elephant() : base("Слон") { }
//    public override void Display()
//    {
//        Console.WriteLine($"Большой {species}");
//    }
//}

//14
//interface IDrawable
//{
//    void Draw();
//}

//class Square : IDrawable
//{
//    public void Draw()
//    {
//        Console.WriteLine("Рисую квадрат");
//    }
//}

//15
//class Transport
//{
//    protected string name;
//    public Transport(string name)
//    {
//        this.name = name;
//    }
//}

//class GroundTransport : Transport
//{
//    public GroundTransport(string name) : base(name) { }
//}

//class AirTransport : Transport
//{
//    public AirTransport(string name) : base(name) { }
//}

//class Car2 : GroundTransport
//{
//    public Car2(string name) : base(name) { }
//}

//class Plane : AirTransport
//{
//    public Plane(string name) : base(name) { }
//}
//16
//class Example16
//{
//    private int privateField;
//    public int PublicProperty
//    {
//        get { return privateField; }
//        set { privateField = value; }
//    }
//}

//17
//class BaseClass17
//{
//    protected int protectedField = 42;
//}

//class DerivedClass17 : BaseClass17
//{
//    public void AccessProtected()
//    {
//        Console.WriteLine(protectedField);
//    }
//}

//18
//internal class InternalClass18
//{
//    public void ShowMessage()
//    {
//        Console.WriteLine("Internal class");
//    }
//}

//19
//class Example19
//{
//    protected internal int protectedInternalField = 100;
//}

//20
//class Example20
//{
//    public int publicField;
//}

//21
//class Example21
//{
//    private int privateField;
//    public int GetPrivateField()
//    {
//        return privateField;
//    }
//}

//22
//class BaseClass22
//{
//    protected void ProtectedMethod()
//    {
//        Console.WriteLine("Protected method");
//    }
//}

//class DerivedClass22 : BaseClass22
//{
//    public void CallProtected()
//    {
//        ProtectedMethod();
//    }
//}

//23
//class Example23
//{
//    protected Example23() { }
//}

//24
//internal class InternalClass24
//{
//    public void InternalMethod()
//    {
//        Console.WriteLine("Internal method");
//    }
//}

//25
//class Example25
//{
//    private int privateData;
//    public void SetPrivateData(int value)
//    {
//        if (value < 0) throw new Exception("Access denied");
//        privateData = value;
//    }
//}

//26
//public class OpenClass26
//{
//    public void PublicMethod()
//    {
//        Console.WriteLine("Public method");
//    }
//}

//27
//class Example27
//{
//    private void PrivateMethod()
//    {
//        Console.WriteLine("Private method");
//    }
//}

//28
//internal class InternalClass28
//{
//    public void InternalAccess()
//    {
//        Console.WriteLine("Internal access");
//    }
//}

//public class PublicClass28
//{
//    public void PublicAccess()
//    {
//        Console.WriteLine("Public access");
//    }
//}

//29
//class Example29
//{
//    protected internal void ProtectedInternalMethod()
//    {
//        Console.WriteLine("Protected internal method");
//    }
//}

//30
//class Example30
//{
//    private int privateProperty { get; set; }
//    public int GetPrivateProperty()
//    {
//        return privateProperty;
//    }
//    public void SetPrivateProperty(int value)
//    {
//        privateProperty = value;
//    }
//}
//31
//class BaseClass31
//{
//    protected string name;
//    public BaseClass31(string name)
//    {
//        this.name = name;
//    }
//}

//class DerivedClass31 : BaseClass31
//{
//    public DerivedClass31(string name) : base(name) { }
//}

//32
//class BaseClass32
//{
//    protected int id;
//    public BaseClass32(int id)
//    {
//        this.id = id;
//    }
//}

//class DerivedClass32 : BaseClass32
//{
//    private string description;
//    public DerivedClass32(int id, string description) : base(id)
//    {
//        this.description = description;
//    }
//}

//33
//class BaseClass33
//{
//    protected string baseField;
//    public BaseClass33(string value)
//    {
//        baseField = value;
//    }
//}

//class DerivedClass33 : BaseClass33
//{
//    private string derivedField;
//    public DerivedClass33(string baseVal, string derivedVal) : base(baseVal)
//    {
//        derivedField = derivedVal;
//    }
//}

//34
//class BaseClass34
//{
//    protected int number;
//    protected string text;
//    public BaseClass34(int num, string txt)
//    {
//        number = num;
//        text = txt;
//    }
//    public void DisplayBase()
//    {
//        Console.WriteLine($"Base: {number}, {text}");
//    }
//}

//class DerivedClass34 : BaseClass34
//{
//    public DerivedClass34(int num, string txt) : base(num, txt) { }
//    public void UseBaseMethod()
//    {
//        DisplayBase();
//    }
//}

//35
//class BaseClass35
//{
//    protected int value;
//    public BaseClass35()
//    {
//        value = 0;
//    }
//    public BaseClass35(int val)
//    {
//        value = val;
//    }
//}

//class DerivedClass35 : BaseClass35
//{
//    public DerivedClass35() : base() { }
//    public DerivedClass35(int val) : base(val) { }
//}

//36
//class BaseClass36
//{
//    protected string data;
//    public BaseClass36(string data)
//    {
//        this.data = data;
//    }
//}

//class DerivedClass36 : BaseClass36
//{
//    public DerivedClass36(string baseData) : base(baseData) { }
//}

//37
//class BaseClass37
//{
//    protected bool initialized;
//    public BaseClass37()
//    {
//        initialized = true;
//    }
//}

//class DerivedClass37 : BaseClass37
//{
//    public DerivedClass37() : base() { }
//}

//38
//class BaseClass38
//{
//    protected int baseValue;
//    public BaseClass38(int value)
//    {
//        baseValue = value;
//    }
//}

//class DerivedClass38 : BaseClass38
//{
//    public DerivedClass38(int val) : base(val)
//    {
//        Console.WriteLine($"Base value initialized: {baseValue}");
//    }
//}

//39
//class BaseClass39
//{
//    protected object data;
//    public BaseClass39(object obj)
//    {
//        data = obj;
//    }
//}

//class DerivedClass39 : BaseClass39
//{
//    public DerivedClass39(string str) : base(str) { }
//    public DerivedClass39(int num) : base(num) { }
//}

//40
//class BaseClass40
//{
//    protected string name;
//    public BaseClass40()
//    {
//        name = "Default";
//    }
//    public BaseClass40(string name)
//    {
//        this.name = name;
//    }
//}

//class DerivedClass40 : BaseClass40
//{
//    public DerivedClass40() : base() { }
//    public DerivedClass40(string name) : base(name) { }
//}

//41
//class BaseClass41
//{
//    protected int x;
//    public BaseClass41(int x)
//    {
//        this.x = x;
//    }
//}

//class DerivedClass41 : BaseClass41
//{
//    private int y;
//    public DerivedClass41(int x) : this(x, 0) { }
//    public DerivedClass41(int x, int y) : base(x)
//    {
//        this.y = y;
//    }
//}

//42
//class BaseClass42
//{
//    protected List<string> items;
//    public BaseClass42()
//    {
//        items = new List<string>();
//        Console.WriteLine("Base constructor logic executed");
//    }
//}

//class DerivedClass42 : BaseClass42
//{
//    public DerivedClass42() : base() { }
//}

//43
//class BaseClass43
//{
//    public string Name { get; protected set; }
//    public int Age { get; protected set; }
//    public BaseClass43(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

//class DerivedClass43 : BaseClass43
//{
//    public DerivedClass43(string name, int age) : base(name, age) { }
//}

//44
//class BaseClass44
//{
//    protected int id;
//    protected string title;
//    public BaseClass44(int id, string title)
//    {
//        this.id = id;
//        this.title = title;
//    }
//}

//class DerivedClass44 : BaseClass44
//{
//    private string description;
//    public DerivedClass44(int id, string title, string desc) : base(id, title)
//    {
//        description = desc;
//    }
//}

//45
//class BaseClass45
//{
//    protected int level;
//    public BaseClass45(int level)
//    {
//        this.level = level;
//    }
//}

//class MiddleClass45 : BaseClass45
//{
//    protected string name;
//    public MiddleClass45(int level, string name) : base(level)
//    {
//        this.name = name;
//    }
//}

//class DerivedClass45 : MiddleClass45
//{
//    public DerivedClass45(int level, string name) : base(level, name) { }
//}

//46
//class Animal46
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Animal sound");
//    }
//}

//class Dog46 : Animal46
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Woof!");
//    }
//}

//Animal46 animal = new Dog46();

//47
//interface IFlyable47
//{
//    void Fly();
//}

//class Bird47 : IFlyable47
//{
//    public void Fly()
//    {
//        Console.WriteLine("Flying high");
//    }
//}

//IFlyable47 flyer = new Bird47();

//48
//class Shape48
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Drawing shape");
//    }
//}

//class Circle48 : Shape48
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing circle");
//    }
//}

//class Square48 : Shape48
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing square");
//    }
//}

//List<Shape48> shapes = new List<Shape48> {
//    new Circle48(),
//    new Square48()
//};

//49
//class Processor49
//{
//    public void Process(Animal46 animal)
//    {
//        animal.MakeSound();
//    }
//}

//Dog46 dog = new Dog46();
//Processor49 processor = new Processor49();
//processor.Process(dog);

//50
//Vehicle50[] vehicles = new Vehicle50[] {
//    new Car50(),
//    new Bus50()
//};

//class Vehicle50 { }
//class Car50 : Vehicle50 { }
//class Bus50 : Vehicle50 { }

//51
//abstract class Shape51
//{
//    public abstract void Draw();
//}

//class Circle51 : Shape51
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing circle");
//    }
//}

//Shape51 shape = new Circle51();

//52
//class Base52
//{
//    public void BaseMethod()
//    {
//        Console.WriteLine("Base method");
//    }
//}

//class Derived52 : Base52
//{
//    public void DerivedMethod()
//    {
//        Console.WriteLine("Derived method");
//    }
//}

//Derived52 derived = new Derived52();
//Base52 baseRef = derived;
//baseRef.BaseMethod();

//53
//Dog46 dog53 = new Dog46();
//Animal46 animalRef = dog53;

//54
//class Printer54
//{
//    public static void Print(Animal46 animal)
//    {
//        animal.MakeSound();
//    }
//}

//Dog46 dog54 = new Dog46();
//Animal46 animal54 = dog54;
//Printer54.Print(animal54);

//55
//class Animal55 { }
//class Cat55 : Animal55 { }

//Cat55 cat = new Cat55();
//Animal55 animal55 = cat;


//56
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new DerivedClass();
//        DerivedClass derivedObj = (DerivedClass)baseObj;
//        derivedObj.Show();
//    }
//}


//57
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new DerivedClass();
//        DerivedClass derivedObj = baseObj as DerivedClass;
//        if (derivedObj != null)
//        {
//            derivedObj.Show();
//        }
//    }
//}


//58
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new DerivedClass();
//        if (baseObj is DerivedClass)
//        {
//            DerivedClass derivedObj = (DerivedClass)baseObj;
//            derivedObj.Show();
//        }
//    }
//}


//59
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new BaseClass();
//        DerivedClass derivedObj = baseObj as DerivedClass;
//        if (derivedObj != null)
//        {
//            derivedObj.Show();
//        }
//        else
//        {
//            Console.WriteLine("Приведение невозможно.");
//        }
//    }
//}


//60
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new BaseClass();
//        try
//        {
//            DerivedClass derivedObj = (DerivedClass)baseObj;
//            derivedObj.Show();
//        }
//        catch (InvalidCastException ex)
//        {
//            Console.WriteLine("Ошибка приведения: " + ex.Message);
//        }
//    }
//}


//61
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new DerivedClass();

//        if (baseObj is DerivedClass)
//        {
//            DerivedClass derivedObj = baseObj as DerivedClass;
//            derivedObj.Show();
//        }
//    }
//}


//62
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass Show Method");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new DerivedClass();
//        DerivedClass derivedObj = (DerivedClass)baseObj;
//        derivedObj.Show();
//    }
//}


//63
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new BaseClass();
//        try
//        {
//            DerivedClass derivedObj = (DerivedClass)baseObj;
//            derivedObj.Show();
//        }
//        catch (InvalidCastException ex)
//        {
//            Console.WriteLine("Исключение при некорректном приведении: " + ex.Message);
//        }
//    }
//}


//64
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass Show Method");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new DerivedClass();
//        DerivedClass derivedObj = (DerivedClass)baseObj;
//        derivedObj.Show();
//    }
//}


//65
//using System;

//class BaseClass
//{
//    public void Display()
//    {
//        Console.WriteLine("BaseClass");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public void Show()
//    {
//        Console.WriteLine("DerivedClass Show Method");
//    }

//    public void SpecialMethod()
//    {
//        Console.WriteLine("Special Method of DerivedClass");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass baseObj = new DerivedClass();
//        DerivedClass derivedObj = (DerivedClass)baseObj;
//        derivedObj.Show();
//        derivedObj.SpecialMethod();
//    }
//}


//66
//using System;

//class BaseClass
//{
//    public virtual void Display()
//    {
//        Console.WriteLine("Метод базового класса.");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public override void Display()
//    {
//        Console.WriteLine("Метод производного класса.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BaseClass derived = new DerivedClass();
//        derived.Display();
//    }
//}


//67
//using System;

//abstract class AbstractBaseClass
//{
//    public abstract void AbstractMethod();

//    public virtual void VirtualMethod()
//    {
//        Console.WriteLine("Виртуальный метод базового класса.");
//    }
//}

//class DerivedFromAbstract : AbstractBaseClass
//{
//    public override void AbstractMethod()
//    {
//        Console.WriteLine("Реализация абстрактного метода.");
//    }

//    public override void VirtualMethod()
//    {
//        Console.WriteLine("Переопределенный виртуальный метод.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        AbstractBaseClass derived = new DerivedFromAbstract();
//        derived.AbstractMethod();
//        derived.VirtualMethod();
//    }
//}


//68
//using System;

//interface IAnimal
//{
//    void Speak();
//}

//class Dog : IAnimal
//{
//    public void Speak()
//    {
//        Console.WriteLine("Гав!");
//    }
//}

//class Cat : IAnimal
//{
//    public void Speak()
//    {
//        Console.WriteLine("Мяу!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        IAnimal dog = new Dog();
//        IAnimal cat = new Cat();

//        dog.Speak();
//        cat.Speak();
//    }
//}


//69
//using System;

//class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Рисую фигуру.");
//    }
//}

//class Circle : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Рисую круг.");
//    }
//}

//class Square : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Рисую квадрат.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape[] shapes = { new Circle(), new Square(), new Shape() };

//        foreach (Shape shape in shapes)
//        {
//            shape.Draw();
//        }
//    }
//}


//70
//using System;

//class Vehicle
//{
//    public virtual void Move()
//    {
//        Console.WriteLine("Транспортное средство движется.");
//    }
//}

//class Car : Vehicle
//{
//    public override void Move()
//    {
//        Console.WriteLine("Машина едет по дороге.");
//    }
//}

//class Airplane : Vehicle
//{
//    public override void Move()
//    {
//        Console.WriteLine("Самолет летит по небу.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Vehicle car = new Car();
//        Vehicle airplane = new Airplane();

//        car.Move();
//        airplane.Move();
//    }
//}


//71
//using System;

//interface IWorker
//{
//    void Work();
//}

//class Manager : IWorker
//{
//    public void Work()
//    {
//        Console.WriteLine("Менеджер управляет командой.");
//    }
//}

//class Developer : IWorker
//{
//    public void Work()
//    {
//        Console.WriteLine("Разработчик пишет код.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        object worker = new Developer();

//        IWorker developer = worker as IWorker;
//        if (developer != null)
//        {
//            developer.Work();
//        }
//    }
//}


//72
//using System;

//class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("Животное издает звук.");
//    }
//}

//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Гав!");
//    }
//}

//class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Мяу!");
//    }
//}

//class Program
//{
//    static void MakeAnimalSpeak(dynamic animal)
//    {
//        animal.Speak();
//    }

//    static void Main()
//    {
//        Animal dog = new Dog();
//        Animal cat = new Cat();

//        MakeAnimalSpeak(dog);
//        MakeAnimalSpeak(cat);
//    }
//}


//73
//using System;

//class BaseClass
//{
//    public virtual void Display()
//    {
//        Console.WriteLine("Метод базового класса.");
//    }
//}

//class DerivedClass : BaseClass
//{
//    public override void Display()
//    {
//        Console.WriteLine("Переопределенный метод производного класса.");
//    }

//    public void Display(string message)
//    {
//        Console.WriteLine($"Перегруженный метод: {message}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        DerivedClass derived = new DerivedClass();
//        derived.Display();
//        derived.Display("Привет!");
//    }
//}


//74
//using System;

//class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Рисую фигуру.");
//    }
//}

//class Circle : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Рисую круг.");
//    }
//}

//class Square : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Рисую квадрат.");
//    }
//}

//class Program
//{
//    static void DrawShape(Shape shape)
//    {
//        shape.Draw();
//    }

//    static void Main()
//    {
//        Shape circle = new Circle();
//        Shape square = new Square();

//        DrawShape(circle);
//        DrawShape(square);
//    }
//}


//75
//using System;

//abstract class ElectronicDevice
//{
//    public abstract void TurnOn();

//    public virtual void TurnOff()
//    {
//        Console.WriteLine("Устройство выключено.");
//    }
//}

//class Smartphone : ElectronicDevice
//{
//    public override void TurnOn()
//    {
//        Console.WriteLine("Смартфон включен.");
//    }

//    public override void TurnOff()
//    {
//        Console.WriteLine("Смартфон выключен.");
//    }
//}

//class Laptop : ElectronicDevice
//{
//    public override void TurnOn()
//    {
//        Console.WriteLine("Ноутбук включен.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ElectronicDevice smartphone = new Smartphone();
//        ElectronicDevice laptop = new Laptop();

//        smartphone.TurnOn();
//        smartphone.TurnOff();

//        laptop.TurnOn();
//        laptop.TurnOff();
//    }
//}


//76
//using System;

//interface ILogger
//{
//    void Log(string message);
//}

//class FileLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Запись в файл: {message}");
//    }
//}

//class ConsoleLogger : ILogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Вывод на консоль: {message}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ILogger fileLogger = new FileLogger();
//        ILogger consoleLogger = new ConsoleLogger();

//        fileLogger.Log("Ошибка в системе!");
//        consoleLogger.Log("Ошибка в системе!");
//    }
//}


//77
//using System;

//class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("Животное издает звук.");
//    }
//}

//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Гав!");
//    }
//}

//class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Мяу!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal1 = new Dog();
//        Animal animal2 = new Cat();

//        animal1.Speak();
//        animal2.Speak();
//    }
//}


//78
//using System;

//class Product
//{
//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine("Информация о продукте.");
//    }
//}

//class Book : Product
//{
//    public override void DisplayInfo()
//    {
//        Console.WriteLine("Информация о книге.");
//    }
//}

//class Electronic : Product
//{
//    public override void DisplayInfo()
//    {
//        Console.WriteLine("Информация об электронном устройстве.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product[] products = { new Book(), new Electronic(), new Product() };

//        foreach (Product product in products)
//        {
//            product.DisplayInfo();
//        }
//    }
//}


//79
//using System;
//using System.Collections.Generic;

//class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("Животное издает звук.");
//    }
//}

//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Гав!");
//    }
//}

//class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Мяу!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Animal> animals = new List<Animal> { new Dog(), new Cat(), new Animal() };

//        foreach (Animal animal in animals)
//        {
//            animal.Speak();
//        }
//    }
//}


//80
//using System;

//class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("Животное издает звук.");
//    }
//}

//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Гав!");
//    }
//}

//class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Мяу!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Dog();
//        animal.Speak();

//        animal = new Cat();
//        animal.Speak();
//    }
//}


//81
//using System;

//partial class TypeChecker
//{
//    public static void CheckType(Animal animal)
//    {
//        if (animal is Dog)
//        {
//            Console.WriteLine("Это объект типа Dog.");
//        }
//    }
//}

//class Animal { }
//class Dog : Animal { }

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Dog();
//        TypeChecker.CheckType(animal);
//    }
//}


//82
//using System;

//partial class TypeCaster
//{
//    public static Dog CastWithAs(Animal animal)
//    {
//        return animal as Dog;
//    }
//}

//class Animal { }
//class Dog : Animal { }

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Dog();
//        Dog dog = TypeCaster.CastWithAs(animal);
//    }
//}


//83
//using System;

//partial class TypeCheckerWithIs
//{
//    public static void CheckAndBark(Animal animal)
//    {
//        if (animal is Dog d)
//        {
//            d.Bark();
//        }
//    }
//}

//class Animal { }
//class Dog : Animal
//{
//    public void Bark() { Console.WriteLine("Гав!"); }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Dog();
//        TypeCheckerWithIs.CheckAndBark(animal);
//    }
//}


//84
//using System;

//partial class SafeTypeCaster
//{
//    public static void SafeCastAndBark(Animal animal)
//    {
//        if (animal is Dog dog)
//        {
//            dog.Bark();
//        }
//    }
//}

//class Animal { }
//class Dog : Animal
//{
//    public void Bark() { Console.WriteLine("Гав!"); }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Dog();
//        SafeTypeCaster.SafeCastAndBark(animal);
//    }
//}


//85
//using System;

//partial class NullTypeCaster
//{
//    public static void CastAndCheckNull(Animal animal)
//    {
//        Dog dog = animal as Dog;
//        if (dog == null)
//        {
//            Console.WriteLine("Приведение невозможно.");
//        }
//    }
//}

//class Animal { }
//class Dog : Animal { }
//class Cat : Animal { }

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Cat();
//        NullTypeCaster.CastAndCheckNull(animal);
//    }
//}


//86
//using System;

//partial class NullLogicTypeCaster
//{
//    public static void NullLogicWithAs(Animal animal)
//    {
//        Dog dog = animal as Dog;
//        if (dog == null)
//        {
//            Console.WriteLine("Объект не является Dog.");
//        }
//    }
//}

//class Animal { }
//class Dog : Animal { }
//class Cat : Animal { }

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Cat();
//        NullLogicTypeCaster.NullLogicWithAs(animal);
//    }
//}


//87
//using System;

//partial class ExceptionTypeCaster
//{
//    public static void CastWithExceptionHandling(Animal animal)
//    {
//        try
//        {
//            Dog dog = (Dog)animal;
//        }
//        catch (InvalidCastException)
//        {
//            Console.WriteLine("Ошибка приведения типов.");
//        }
//    }
//}

//class Animal { }
//class Dog : Animal { }
//class Cat : Animal { }

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Cat();
//        ExceptionTypeCaster.CastWithExceptionHandling(animal);
//    }
//}


//88
//using System;

//interface IBarkable
//{
//    void Bark();
//}

//partial class InterfaceMethodUser
//{
//    public static void UseInterfaceMethod(Animal animal)
//    {
//        if (animal is IBarkable barkable)
//        {
//            barkable.Bark();
//        }
//    }
//}

//class Animal { }
//class Dog : Animal, IBarkable
//{
//    public void Bark() { Console.WriteLine("Гав!"); }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Dog();
//        InterfaceMethodUser.UseInterfaceMethod(animal);
//    }
//}


//89
//using System;

//partial class TypeAndMethodChecker
//{
//    public static void CheckTypeAndCallMethod(Animal animal)
//    {
//        if (animal is Dog dog)
//        {
//            dog.Bark();
//        }
//    }
//}

//class Animal { }
//class Dog : Animal
//{
//    public void Bark() { Console.WriteLine("Гав!"); }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Dog();
//        TypeAndMethodChecker.CheckTypeAndCallMethod(animal);
//    }
//}


//90
//using System;

//partial class IsAndAsComparator
//{
//    public static void CompareIsAndAs(Animal animal)
//    {
//        if (animal is Dog dog1)
//        {
//            dog1.Bark();
//        }

//        Dog dog2 = animal as Dog;
//        if (dog2 != null)
//        {
//            dog2.Bark();
//        }
//    }
//}

//class Animal { }
//class Dog : Animal
//{
//    public void Bark() { Console.WriteLine("Гав!"); }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Dog();
//        IsAndAsComparator.CompareIsAndAs(animal);
//    }
//}


//91
//using System;

//sealed partial class SealedForm
//{
//    public void Show()
//    {
//        Console.WriteLine("Форма отображена.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SealedForm sealedForm = new SealedForm();
//        sealedForm.Show();
//    }
//}


//92
//using System;

//sealed partial class SealedClass
//{
//    private void PrivateMethod()
//    {
//        Console.WriteLine("Закрытый метод.");
//    }

//    public void PublicMethod()
//    {
//        Console.WriteLine("Публичный метод.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SealedClass sealedClass = new SealedClass();
//        sealedClass.PublicMethod();
//    }
//}


//93
//using System;

//sealed partial class FinalClass
//{
//    public void Display()
//    {
//        Console.WriteLine("Этот класс нельзя наследовать.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        FinalClass finalClass = new FinalClass();
//        finalClass.Display();
//    }
//}


//94
//using System;

//sealed class SealedClass
//{
//    public void Display()
//    {
//        Console.WriteLine("Это запечатанный метод.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SealedClass sealedClass = new SealedClass();
//        sealedClass.Display(); // Вызов метода запечатанного класса
//    }
//}


//95
//using System;

//sealed partial class PublicSealedClass
//{
//    public void PublicMethod()
//    {
//        Console.WriteLine("Публичный метод в запечатанном классе.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        PublicSealedClass publicSealedClass = new PublicSealedClass();
//        publicSealedClass.PublicMethod();
//    }
//}


//96
//using System;

//sealed partial class SealedWithConstructor
//{
//    public SealedWithConstructor(int value)
//    {
//        Console.WriteLine($"Конструктор с параметром: {value}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SealedWithConstructor sealedWithConstructor = new SealedWithConstructor(10);
//    }
//}


//97
//using System;

//sealed partial class Logger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Лог: {message}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Logger logger = new Logger();
//        logger.Log("Сообщение для регистрации.");
//    }
//}



//98
//using System;

//sealed partial class ConfidentialData
//{
//    private string secret;

//    public ConfidentialData(string secret)
//    {
//        this.secret = secret;
//    }

//    public void DisplaySecret()
//    {
//        Console.WriteLine($"Секрет: {secret}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ConfidentialData confidentialData = new ConfidentialData("Секретное сообщение");
//        confidentialData.DisplaySecret();
//    }
//}


//99
//using System;

//sealed partial class ProtectedSealedClass
//{
//    protected string protectedField = "Защищённое поле";

//    public void Display()
//    {
//        Console.WriteLine(protectedField);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ProtectedSealedClass protectedSealedClass = new ProtectedSealedClass();
//        protectedSealedClass.Display();
//    }
//}


//100
//using System;

//sealed partial class ControlObject
//{
//    public void Control()
//    {
//        Console.WriteLine("Контрольный объект.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ControlObject controlObject = new ControlObject();
//        controlObject.Control();
//    }
//}
