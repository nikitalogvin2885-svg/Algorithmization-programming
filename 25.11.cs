//1
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 10, 25, 50, 75, 100, 150 };

//        var result = numbers.Where(x => x > 50).ToList();

//        Console.WriteLine("Числа больше 50:");
//        Console.WriteLine(string.Join(", ", result));
//    }
//}

//2
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        var even = numbers.Where(x => x % 2 == 0).ToList();

//        Console.WriteLine("Чётные числа:");
//        Console.WriteLine(string.Join(", ", even));
//    }
//}

//3
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] fruits = { "Apple", "Banana", "Apricot", "Orange", "Avocado" };

//        var startsWithA = fruits.Where(s => s.StartsWith("A")).ToList();

//        Console.WriteLine("Начинаются на A:");
//        Console.WriteLine(string.Join(", ", startsWithA));
//    }
//}

//4
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Анна", Age = 25 },
//            new Person { Name = "Борис", Age = 42 },
//            new Person { Name = "Вера", Age = 38 },
//            new Person { Name = "Глеб", Age = 19 }
//        };

//        var adults = people.Where(p => p.Age > 30).ToList();

//        Console.WriteLine("Старше 30 лет:");
//        foreach (var p in adults)
//            Console.WriteLine($"{p.Name} — {p.Age} лет");
//    }
//}

//5
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 4, 7, 12, 15, 23, 27, 30, 33 };

//        var divisibleBy3 = numbers.Where(x => x % 3 == 0).ToList();

//        Console.WriteLine("Делятся на 3:");
//        Console.WriteLine(string.Join(", ", divisibleBy3));
//    }
//}

//6
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student
//{
//    public string Name { get; set; }
//    public double AverageGrade { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Иван", AverageGrade = 4.8 },
//            new Student { Name = "Мария", AverageGrade = 3.9 },
//            new Student { Name = "Пётр", AverageGrade = 5.0 },
//            new Student { Name = "Ольга", AverageGrade = 4.2 }
//        };

//        var excellent = students.Where(s => s.AverageGrade > 4.0).ToList();

//        Console.WriteLine("Средний балл > 4.0:");
//        foreach (var s in excellent)
//            Console.WriteLine($"{s.Name} — {s.AverageGrade}");
//    }
//}

//7
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "Hi", "Hello", "World", "Programming" };

//        var longWords = words.Where(w => w.Length > 5).ToList();

//        Console.WriteLine("Длиннее 5 символов:");
//        Console.WriteLine(string.Join(", ", longWords));
//    }
//}

//8
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Ноутбук", Price = 85000 },
//            new Product { Name = "Наушники", Price = 350 },
//            new Product { Name = "Мышь", Price = 120 },
//            new Product { Name = "Клавиатура", Price = 450 }
//        };

//        var midPrice = products.Where(p => p.Price >= 100 && p.Price <= 500).ToList();

//        Console.WriteLine("Товары 100–500 руб:");
//        foreach (var p in midPrice)
//            Console.WriteLine($"{p.Name} — {p.Price} руб");
//    }
//}

//9
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { -5, 12, 0, -8, 27, -3, 15 };

//        var positive = numbers.Where(x => x > 0).ToList();

//        Console.WriteLine("Положительные числа:");
//        Console.WriteLine(string.Join(", ", positive));
//    }
//}

//10
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee
//{
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//    public int ExperienceYears { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Name = "Алексей", Salary = 80000, ExperienceYears = 5 },
//            new Employee { Name = "Дарья", Salary = 120000, ExperienceYears = 3 },
//            new Employee { Name = "Егор", Salary = 65000, ExperienceYears = 1 },
//            new Employee { Name = "Света", Salary = 95000, ExperienceYears = 4 }
//        };

//        decimal avgSalary = employees.Average(e => e.Salary);

//        var valuable = employees
//            .Where(e => e.Salary > avgSalary && e.ExperienceYears > 2)
//            .ToList();

//        Console.WriteLine($"Средняя зарплата: {avgSalary:0} руб");
//        Console.WriteLine("Ценные сотрудники:");
//        foreach (var e in valuable)
//            Console.WriteLine($"{e.Name} — {e.Salary} руб, стаж {e.ExperienceYears} лет");
//    }
//}

//11
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };

//        var squares = numbers.Select(x => x * x).ToList();

//        Console.WriteLine("Квадраты: " + string.Join(", ", squares));
//    }
//}

//12
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person { public string Name { get; set; } public int Age { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Анна", Age = 25 },
//            new Person { Name = "Борис", Age = 30 }
//        };

//        var names = people.Select(p => p.Name).ToList();

//        Console.WriteLine("Имена: " + string.Join(", ", names));
//    }
//}

//13
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person { public string Name { get; set; } public int Age { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Виктор", Age = 27 },
//            new Person { Name = "Ольга", Age = 34 }
//        };

//        var info = people.Select(p => $"{p.Name} - {p.Age}").ToList();

//        Console.WriteLine("Информация:");
//        foreach (var s in info) Console.WriteLine(s);
//    }
//}

//14
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "C#", "Java", "Python", "Go" };

//        var lengths = words.Select(w => w.Length).ToList();

//        Console.WriteLine("Длины: " + string.Join(", ", lengths));
//    }
//}

//15
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//    public string Category { get; set; }
//}

//public class ProductDto
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Ноутбук", Price = 75000, Category = "Электроника" }
//        };

//        var dtos = products.Select(p => new ProductDto
//        {
//            Name = p.Name,
//            Price = p.Price
//        }).ToList();

//        foreach (var dto in dtos)
//            Console.WriteLine($"{dto.Name}: {dto.Price} руб");
//    }
//}

//16
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        decimal[] pricesRub = { 5000, 12500, 8000 };

//        var pricesUsd = pricesRub.Select(p => p / 100m).ToList();

//        Console.WriteLine("Цены в USD: " + string.Join(", ", pricesUsd));
//    }
//}

//17
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public decimal Salary { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Name = "Мария", Age = 29, Salary = 120000 }
//        };

//        var projection = employees.Select(e => new
//        {
//            FullName = e.Name.ToUpper(),
//            YearlySalary = e.Salary * 12,
//            IsAdult = e.Age >= 18
//        }).ToList();

//        foreach (var item in projection)
//            Console.WriteLine($"{item.FullName}, годовая з/п: {item.YearlySalary}, взрослый: {item.IsAdult}");
//    }
//}

//18
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] items = { "яблоко", "банан", "груша" };

//        var withPrefix = items.Select(x => "Фрукт: " + x).ToList();

//        Console.WriteLine(string.Join(" | ", withPrefix));
//    }
//}

//19
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class User
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Email { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var users = new List<User>
//        {
//            new User { FirstName = "Иван", LastName = "Петров", Email = "ivan@example.com" }
//        };

//        var formatted = users.Select(u => new
//        {
//            Display = $"[{u.FirstName} {u.LastName}] <{u.Email.ToLower()}>"
//        }).ToList();

//        foreach (var f in formatted)
//            Console.WriteLine(f.Display);
//    }
//}

//20
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student
//{
//    public string Name { get; set; }
//    public int Grade { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Алексей", Grade = 5 },
//            new Student { Name = "Елена", Grade = 4 }
//        };

//        var tuples = students.Select(s => (s.Name, s.Grade)).ToList();

//        foreach (var (name, grade) in tuples)
//            Console.WriteLine($"{name} — оценка {grade}");
//    }
//}

//21
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 5, 2, 8, 1, 9 };

//        var sorted = numbers.OrderBy(x => x).ToList();

//        Console.WriteLine("По возрастанию: " + string.Join(" → ", sorted));
//    }
//}

//22
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] names = { "Олег", "Анна", "Виктор", "Мария", "Борис" };

//        var reversed = names.OrderByDescending(n => n).ToList();

//        Console.WriteLine("От Z до A: " + string.Join(" → ", reversed));
//    }
//}

//23
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Иван", Age = 25 },
//            new Person { Name = "Анна", Age = 30 },
//            new Person { Name = "Пётр", Age = 25 },
//            new Person { Name = "Мария", Age = 30 }
//        };

//        var sorted = people
//            .OrderBy(p => p.Age)
//            .ThenBy(p => p.Name)
//            .ToList();

//        foreach (var p in sorted)
//            Console.WriteLine($"{p.Name} — {p.Age} лет");
//    }
//}

//24
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "C#", "Python", "Go", "JavaScript", "Hi" };

//        var byLength = words.OrderBy(w => w.Length).ToList();

//        Console.WriteLine("От коротких к длинным: " + string.Join(" → ", byLength));
//    }
//}

//25
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Ноутбук", Price = 85000 },
//            new Product { Name = "Мышь", Price = 1200 },
//            new Product { Name = "Монитор", Price = 25000 }
//        };

//        var expensiveFirst = products.OrderByDescending(p => p.Price).ToList();

//        foreach (var p in expensiveFirst)
//            Console.WriteLine($"{p.Name} — {p.Price} руб");
//    }
//}

//26
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student
//{
//    public string Name { get; set; }
//    public int Score { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Иванов", Score = 85 },
//            new Student { Name = "Петров", Score = 92 },
//            new Student { Name = "Сидоров", Score = 92 },
//            new Student { Name = "Козлов", Score = 78 }
//        };

//        var ranked = students
//            .OrderByDescending(s => s.Score)
//            .ThenBy(s => s.Name)
//            .ToList();

//        foreach (var s in ranked)
//            Console.WriteLine($"{s.Name} — {s.Score} баллов");
//    }
//}

//27
//using System;
//using System.Linq;

//class Program
//{
//    static int CountDivisors(int n)
//    {
//        int count = 0;
//        for (int i = 1; i <= n; i++)
//            if (n % i == 0) count++;
//        return count;
//    }

//    static void Main()
//    {
//        int[] numbers = { 12, 5, 24, 7, 18, 9, 11 };

//        var sorted = numbers
//            .OrderBy(CountDivisors)
//            .ThenBy(n => n)
//            .ToList();

//        Console.WriteLine("По количеству делителей: " + string.Join(", ", sorted));
//    }
//}

//28
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee
//{
//    public string Name { get; set; }
//    public string Department { get; set; }
//    public decimal Salary { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Name = "Алексей", Department = "IT", Salary = 120000 },
//            new Employee { Name = "Ольга", Department = "HR", Salary = 90000 },
//            new Employee { Name = "Дмитрий", Department = "IT", Salary = 140000 }
//        };

//        var sorted = employees
//            .OrderBy(e => e.Department)
//            .ThenByDescending(e => e.Salary)
//            .ToList();

//        foreach (var e in sorted)
//            Console.WriteLine($"{e.Department} → {e.Name}: {e.Salary} руб");
//    }
//}

//29
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        DateTime[] dates =
//        {
//            new DateTime(2023, 12, 25),
//            new DateTime(2022, 8, 15),
//            new DateTime(2024, 1, 1)
//        };

//        var chronological = dates.OrderBy(d => d).ToList();

//        foreach (var d in chronological)
//            Console.WriteLine(d.ToString("yyyy-MM-dd"));
//    }
//}

//30
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Name { get; set; }
//    public string Category { get; set; }
//    public int Popularity { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Книга A", Category = "Книги", Popularity = 150 },
//            new Product { Name = "Книга B", Category = "Книги", Popularity = 200 },
//            new Product { Name = "Телефон X", Category = "Гаджеты", Popularity = 500 }
//        };

//        var sorted = products
//            .OrderBy(p => p.Category)
//            .ThenByDescending(p => p.Popularity)
//            .ToList();

//        foreach (var p in sorted)
//            Console.WriteLine($"{p.Category} → {p.Name} ({p.Popularity})");
//    }
//}

//31
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        var groups = numbers.GroupBy(n => n % 2 == 0 ? "Чётные" : "Нечётные");

//        foreach (var group in groups)
//        {
//            Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
//        }
//    }
//}

//32
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person { public string Name { get; set; } public int Age { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Анна", Age = 25 },
//            new Person { Name = "Борис", Age = 30 },
//            new Person { Name = "Вера", Age = 25 }
//        };

//        var byAge = people.GroupBy(p => p.Age);

//        foreach (var group in byAge)
//        {
//            Console.WriteLine($"Возраст {group.Key}: {string.Join(", ", group.Select(p => p.Name))}");
//        }
//    }
//}

//33
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product { public string Name { get; set; } public string Category { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Ноутбук", Category = "Электроника" },
//            new Product { Name = "Книга", Category = "Книги" },
//            new Product { Name = "Телефон", Category = "Электроника" }
//        };

//        var grouped = products.GroupBy(p => p.Category);

//        foreach (var g in grouped)
//        {
//            Console.WriteLine($"{g.Key}: {g.Count()} шт. ({string.Join(", ", g.Select(p => p.Name))})");
//        }
//    }
//}

//34
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student { public string Name { get; set; } public string Faculty { get; set; } public double Grade { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Иван", Faculty = "IT", Grade = 4.8 },
//            new Student { Name = "Мария", Faculty = "IT", Grade = 4.5 },
//            new Student { Name = "Пётр", Faculty = "Экономика", Grade = 4.2 }
//        };

//        var avgByFaculty = students
//            .GroupBy(s => s.Faculty)
//            .Select(g => new { Faculty = g.Key, AvgGrade = g.Average(s => s.Grade) });

//        foreach (var item in avgByFaculty)
//            Console.WriteLine($"{item.Faculty}: средний балл = {item.AvgGrade:F2}");
//    }
//}

//35
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee { public string Name { get; set; } public string Department { get; set; } public decimal Salary { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Name = "Алексей", Department = "IT", Salary = 120000 },
//            new Employee { Name = "Ольга", Department = "HR", Salary = 90000 },
//            new Employee { Name = "Дмитрий", Department = "IT", Salary = 140000 }
//        };

//        var salaryByDept = employees
//            .GroupBy(e => e.Department)
//            .Select(g => new { Dept = g.Key, TotalSalary = g.Sum(e => e.Salary) });

//        foreach (var item in salaryByDept)
//            Console.WriteLine($"{item.Dept}: общая зарплата = {item.TotalSalary} руб");
//    }
//}

//36
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Order { public string Client { get; set; } public decimal Amount { get; set; } public int OrderId { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var orders = new List<Order>
//        {
//            new Order { Client = "Иванов", Amount = 5000, OrderId = 1 },
//            new Order { Client = "Иванов", Amount = 15000, OrderId = 2 },
//            new Order { Client = "Петров", Amount = 8000, OrderId = 3 }
//        };

//        var maxByClient = orders
//            .GroupBy(o => o.Client)
//            .Select(g => new
//            {
//                Client = g.Key,
//                MaxAmount = g.Max(o => o.Amount),
//                OrderId = g.First(o => o.Amount == g.Max(x => x.Amount)).OrderId
//            });

//        foreach (var item in maxByClient)
//            Console.WriteLine($"{item.Client}: самый дорогой заказ #{item.OrderId} на {item.MaxAmount} руб");
//    }
//}

//37
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "Яблоко", "Банан", "Арбуз", "Груша", "Апельсин" };

//        var byFirstLetter = words.GroupBy(w => w[0]);

//        foreach (var g in byFirstLetter.OrderBy(g => g.Key))
//        {
//            Console.WriteLine($"{g.Key}: {string.Join(", ", g)}");
//        }
//    }
//}

//38
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var events = new List<DateTime>
//        {
//            new DateTime(2025, 1, 10),
//            new DateTime(2025, 1, 11),
//            new DateTime(2025, 1, 10),
//            new DateTime(2025, 1, 12)
//        };

//        var byDate = events
//            .GroupBy(e => e.Date)
//            .Select(g => new { Date = g.Key.ToString("yyyy-MM-dd"), Count = g.Count() })
//            .OrderBy(x => x.Date);

//        foreach (var item in byDate)
//            Console.WriteLine($"{item.Date}: {item.Count} событий");
//    }
//}

//39
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Sale { public DateTime Date { get; set; } public decimal Amount { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var sales = new List<Sale>
//        {
//            new Sale { Date = new DateTime(2025, 1, 15), Amount = 10000 },
//            new Sale { Date = new DateTime(2025, 1, 20), Amount = 15000 },
//            new Sale { Date = new DateTime(2025, 2, 5), Amount = 20000 }
//        };

//        var byMonth = sales
//            .GroupBy(s => new { s.Date.Year, s.Date.Month })
//            .Select(g => new
//            {
//                Month = $"{g.Key.Year}-{g.Key.Month:D2}",
//                Total = g.Sum(s => s.Amount)
//            });

//        foreach (var item in byMonth)
//            Console.WriteLine($"Месяц {item.Month}: {item.Total} руб");
//    }
//}

//40
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Category { get; set; }
//    public string Subcategory { get; set; }
//    public string Name { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Category = "Электроника", Subcategory = "Смартфоны", Name = "iPhone" },
//            new Product { Category = "Электроника", Subcategory = "Ноутбуки", Name = "MacBook" },
//            new Product { Category = "Одежда", Subcategory = "Обувь", Name = "Кроссовки" }
//        };

//        var nested = products
//            .GroupBy(p => p.Category)
//            .Select(cg => new
//            {
//                Category = cg.Key,
//                Subcategories = cg.GroupBy(p => p.Subcategory)
//                                  .Select(sg => new { Subcategory = sg.Key, Items = sg.Select(p => p.Name) })
//            });

//        foreach (var cat in nested)
//        {
//            Console.WriteLine($"► {cat.Category}");
//            foreach (var sub in cat.Subcategories)
//            {
//                Console.WriteLine($"   └─ {sub.Subcategory}: {string.Join(", ", sub.Items)}");
//            }
//        }
//    }
//}

//41
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student { public int Id { get; set; } public string Name { get; set; } }
//public class Grade { public int StudentId { get; set; } public string Subject { get; set; } public int Score { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Id = 1, Name = "Иван" },
//            new Student { Id = 2, Name = "Мария" }
//        };

//        var grades = new List<Grade>
//        {
//            new Grade { StudentId = 1, Subject = "Математика", Score = 5 },
//            new Grade { StudentId = 1, Subject = "Физика", Score = 4 },
//            new Grade { StudentId = 2, Subject = "Математика", Score = 5 }
//        };

//        var result = students
//            .Join(grades,
//                  s => s.Id,
//                  g => g.StudentId,
//                  (s, g) => new { s.Name, g.Subject, g.Score });

//        foreach (var r in result)
//            Console.WriteLine($"{r.Name} — {r.Subject}: {r.Score}");
//    }
//}

//42
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee { public int Id { get; set; } public string Name { get; set; } public int DeptId { get; set; } }
//public class Department { public int Id { get; set; } public string Name { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Id = 1, Name = "Алексей", DeptId = 10 },
//            new Employee { Id = 2, Name = "Ольга", DeptId = 20 }
//        };

//        var departments = new List<Department>
//        {
//            new Department { Id = 10, Name = "IT" },
//            new Department { Id = 20, Name = "HR" }
//        };

//        var joined = employees
//            .Join(departments,
//                  e => e.DeptId,
//                  d => d.Id,
//                  (e, d) => new { e.Name, Department = d.Name });

//        foreach (var j in joined)
//            Console.WriteLine($"{j.Name} работает в отделе {j.Department}");
//    }
//}

//43
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Customer { public int Id { get; set; } public string Name { get; set; } }
//public class Order { public int CustomerId { get; set; } public decimal Amount { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var customers = new List<Customer>
//        {
//            new Customer { Id = 1, Name = "Иван" },
//            new Customer { Id = 2, Name = "Пётр" },
//            new Customer { Id = 3, Name = "Анна" }
//        };

//        var orders = new List<Order>
//        {
//            new Order { CustomerId = 1, Amount = 5000 },
//            new Order { CustomerId = 1, Amount = 3000 }
//        };

//        var leftJoin = customers
//            .GroupJoin(orders,
//                       c => c.Id,
//                       o => o.CustomerId,
//                       (c, os) => new { c.Name, Orders = os.DefaultIfEmpty() })
//            .SelectMany(x => x.Orders.Select(o => new { x.Name, Amount = o?.Amount ?? 0 }));

//        foreach (var r in leftJoin)
//            Console.WriteLine($"{r.Name} → заказ на {r.Amount} руб");
//    }
//}

//44
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product { public int Id { get; set; } public string Name { get; set; } public int ManufacturerId { get; set; } }
//public class Manufacturer { public int Id { get; set; } public string Name { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Id = 101, Name = "iPhone 15", ManufacturerId = 1 }
//        };

//        var manufacturers = new List<Manufacturer>
//        {
//            new Manufacturer { Id = 1, Name = "Apple" },
//            new Manufacturer { Id = 2, Name = "Samsung" }
//        };

//        var result = products
//            .Join(manufacturers,
//                  p => p.ManufacturerId,
//                  m => m.Id,
//                  (p, m) => $"{p.Name} — производитель: {m.Name}");

//        foreach (var r in result)
//            Console.WriteLine(r);
//    }
//}

//45
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class OrderDetail { public int OrderId { get; set; } public int ProductId { get; set; } public int Quantity { get; set; } }
//public class Price { public int ProductId { get; set; } public DateTime Date { get; set; } public decimal Value { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var details = new List<OrderDetail>
//        {
//            new OrderDetail { OrderId = 100, ProductId = 5, Quantity = 2 }
//        };

//        var prices = new List<Price>
//        {
//            new Price { ProductId = 5, Date = new DateTime(2025, 1, 1), Value = 1000 }
//        };

//        var result = details
//            .Join(prices,
//                  d => new { d.ProductId, Date = new DateTime(2025, 1, 1) },
//                  p => new { p.ProductId, p.Date },
//                  (d, p) => new { d.OrderId, d.ProductId, d.Quantity, Total = d.Quantity * p.Value });

//        foreach (var r in result)
//            Console.WriteLine($"Заказ {r.OrderId}: {r.Total} руб");
//    }
//}

//46
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Customer { public int Id { get; set; } public string Name { get; set; } }
//public class Order { public int Id { get; set; } public int CustomerId { get; set; } public int ProductId { get; set; } }
//public class Product { public int Id { get; set; } public string Name { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var customers = new List<Customer> { new Customer { Id = 1, Name = "Иван" } };
//        var orders = new List<Order> { new Order { Id = 10, CustomerId = 1, ProductId = 100 } };
//        var products = new List<Product> { new Product { Id = 100, Name = "Ноутбук" } };

//        var report = customers
//            .Join(orders, c => c.Id, o => o.CustomerId, (c, o) => new { c.Name, o.Id, o.ProductId })
//            .Join(products, x => x.ProductId, p => p.Id, (x, p) => $"{x.Name} заказал {p.Name}");

//        foreach (var r in report)
//            Console.WriteLine(r);
//    }
//}

//47
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Department { public int Id { get; set; } public string Name { get; set; } }
//public class Employee { public string Name { get; set; } public int DeptId { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var depts = new List<Department>
//        {
//            new Department { Id = 1, Name = "IT" },
//            new Department { Id = 2, Name = "HR" }
//        };

//        var emps = new List<Employee>
//        {
//            new Employee { Name = "Алексей", DeptId = 1 },
//            new Employee { Name = "Ольга", DeptId = 1 }
//        };

//        var result = depts.GroupJoin(emps,
//            d => d.Id,
//            e => e.DeptId,
//            (d, employees) => new { Dept = d.Name, Employees = employees.Select(e => e.Name) });

//        foreach (var r in result)
//        {
//            Console.WriteLine($"{r.Dept}: {string.Join(", ", r.Employees.DefaultIfEmpty("нет сотрудников"))}");
//        }
//    }
//}

//48
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var colors = new[] { "Красный", "Синий" };
//        var sizes = new[] { "S", "M", "L" };

//        var combinations = colors
//            .SelectMany(c => sizes, (c, s) => $"{c} {s}");

//        foreach (var combo in combinations)
//            Console.WriteLine(combo);
//        Kuiper Belt
//    }
//}

//49
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product { public int Id { get; set; } public string Name { get; set; } public bool IsActive { get; set; } }
//public class Stock { public int ProductId { get; set; } public int Quantity { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Id = 1, Name = "Телефон", IsActive = true },
//            new Product { Id = 2, Name = "Старый товар", IsActive = false }
//        };

//        var stock = new List<Stock>
//        {
//            new Stock { ProductId = 1, Quantity = 10 },
//            new Stock { ProductId = 2, Quantity = 5 }
//        };

//        var result = products
//            .Where(p => p.IsActive)
//            .Join(stock,
//                  p => p.Id,
//                  s => s.ProductId,
//                  (p, s) => new { p.Name, s.Quantity });

//        foreach (var r in result)
//            Console.WriteLine($"{r.Name} — на складе: {r.Quantity}");
//    }
//}

//50
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class UserDto { public int UserId { get; set; } public string FullName { get; set; } }
//public class Profile { public int Id { get; set; } public string Email { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var users = new List<UserDto>
//        {
//            new UserDto { UserId = 1, FullName = "Иван Петров" }
//        };

//        var profiles = new List<Profile>
//        {
//            new Profile { Id = 1, Email = "ivan@example.com" }
//        };

//        var combined = users
//            .Join(profiles,
//                  u => u.UserId,
//                  p => p.Id,
//                  (u, p) => new { u.FullName, p.Email });

//        foreach (var c in combined)
//            Console.WriteLine($"{c.FullName} → {c.Email}");
//    }
//}

////51
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        int sum = numbers.Sum();
//        Console.WriteLine($"Сумма всех чисел: {sum}");
//    }
//}

////52
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        double average = numbers.Average();
//        Console.WriteLine($"Среднее значение: {average}");
//    }
//}

////53
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        int max = numbers.Max();
//        int min = numbers.Min();
//        Console.WriteLine($"Максимум: {max}, Минимум: {min}");
//    }
//}


////54
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 10, 15, 20 };
//        int count = numbers.Count(x => x > 5);
//        Console.WriteLine($"Количество элементов больше 5: {count}");
//    }
//}


////55
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        int product = numbers.Aggregate((acc, x) => acc * x);
//        Console.WriteLine($"Произведение всех чисел: {product}");
//    }
//}


////56
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        numbers.Sort();
//        int median = numbers[numbers.Count / 2];
//        Console.WriteLine($"Медиана: {median}");
//    }
//}

////57
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 101 };
//        bool hasGreaterThan100 = numbers.Any(x => x > 100);
//        Console.WriteLine($"Есть число больше 100: {hasGreaterThan100}");
//    }
//}

////58
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int number = 5;
//        int factorial = Enumerable.Range(1, number).Aggregate((acc, x) => acc * x);
//        Console.WriteLine($"Факториал числа {number}: {factorial}");
//    }
//}

////59
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        var squaresOfOdds = numbers.Where(x => x % 2 != 0).Select(x => x * x);
//        Console.WriteLine($"Квадраты нечетных чисел: {string.Join(", ", squaresOfOdds)}");
//    }
//}

////60
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<double> numbers = new List<double> { 1, 2, 3, 4, 5 };
//        double mean = numbers.Average();
//        double sumOfSquares = numbers.Sum(x => Math.Pow(x - mean, 2));
//        double standardDeviation = Math.Sqrt(sumOfSquares / numbers.Count);
//        Console.WriteLine($"Стандартное отклонение: {standardDeviation}");
//    }
//}

////61
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
//        List<int> uniqueNumbers = numbers.Distinct().ToList();
//        Console.WriteLine(string.Join(", ", uniqueNumbers)); // Вывод: 1, 2, 3, 4
//    }
//}

////62
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> list1 = new List<int> { 1, 2, 3 };
//        List<int> list2 = new List<int> { 3, 4, 5 };
//        List<int> union = list1.Union(list2).ToList();
//        Console.WriteLine(string.Join(", ", union)); // Вывод: 1, 2, 3, 4, 5
//    }
//}

////63
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> list1 = new List<int> { 1, 2, 3, 4 };
//        List<int> list2 = new List<int> { 3, 4, 5, 6 };
//        List<int> difference = list1.Except(list2).ToList();
//        Console.WriteLine(string.Join(", ", difference)); // Вывод: 1, 2
//    }
//}

////64
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> list1 = new List<int> { 1, 2, 3, 4 };
//        List<int> list2 = new List<int> { 3, 4, 5, 6 };
//        List<int> intersection = list1.Intersect(list2).ToList();
//        Console.WriteLine(string.Join(", ", intersection)); // Вывод: 3, 4
//    }
//}

////65
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<string> strings = new List<string> { "apple", "Apple", "banana", "Banana" };
//        List<string> uniqueStrings = strings.Distinct(StringComparer.Ordinal).ToList();
//        Console.WriteLine(string.Join(", ", uniqueStrings)); // Вывод: apple, Apple, banana, Banana
//    }
//}

////66
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<string> strings = new List<string> { "apple", "Apple", "banana", "Banana" };
//        List<string> uniqueStrings = strings.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
//        Console.WriteLine(string.Join(", ", uniqueStrings)); // Вывод: apple, banana
//    }
//}

////67
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> list1 = new List<int> { 1, 2, 3, 4 };
//        List<int> list2 = new List<int> { 3, 4, 5, 6 };
//        List<int> commonElements = list1.Intersect(list2).ToList();
//        Console.WriteLine(string.Join(", ", commonElements)); // Вывод: 3, 4
//    }
//}

////68
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> list1 = new List<int> { 1, 2, 3, 4 };
//        List<int> list2 = new List<int> { 3, 4, 5, 6 };
//        List<int> symmetricDifference = list1.Except(list2).Union(list2.Except(list1)).ToList();
//        Console.WriteLine(string.Join(", ", symmetricDifference)); // Вывод: 1, 2, 5, 6
//    }
//}

////69
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        List<int> firstThree = numbers.Take(3).ToList();
//        Console.WriteLine(string.Join(", ", firstThree)); // Вывод: 1, 2, 3
//    }
//}

////70
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        List<int> skipTwo = numbers.Skip(2).ToList();
//        Console.WriteLine(string.Join(", ", skipTwo)); // Вывод: 3, 4, 5
//    }
//}

////71
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        int firstEven = numbers.First(x => x % 2 == 0);
//        Console.WriteLine(firstEven); // Вывод: 2
//    }
//}

////72
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        int last = numbers.Last();
//        Console.WriteLine(last); // Вывод: 5
//    }
//}

////73
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int skip = 3, take = 4;
//        List<int> page = numbers.Skip(skip).Take(take).ToList();
//        Console.WriteLine(string.Join(", ", page)); // Вывод: 4, 5, 6, 7
//    }
//}

////74
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        List<int> takeWhileLessThanFour = numbers.TakeWhile(x => x < 4).ToList();
//        Console.WriteLine(string.Join(", ", takeWhileLessThanFour)); // Вывод: 1, 2, 3
//    }
//}

////75
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        List<int> skipWhileLessThanFour = numbers.SkipWhile(x => x < 4).ToList();
//        Console.WriteLine(string.Join(", ", skipWhileLessThanFour)); // Вывод: 4, 5
//    }
//}

////76
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        List<int> lastThree = numbers.Skip(numbers.Count - 3).ToList();
//        Console.WriteLine(string.Join(", ", lastThree)); // Вывод: 3, 4, 5
//    }
//}

////77
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<List<int>> listOfLists = new List<List<int>>
//        {
//            new List<int> { 1, 2, 3 },
//            new List<int> { 4, 5 },
//            new List<int> { 6, 7, 8, 9 }
//        };

//        List<int> flattenedList = listOfLists.SelectMany(list => list).ToList();
//        Console.WriteLine(string.Join(", ", flattenedList)); // Вывод: 1, 2, 3, 4, 5, 6, 7, 8, 9
//    }
//}

////78
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> list1 = new List<int> { 1, 2, 3 };
//        List<char> list2 = new List<char> { 'a', 'b' };

//        var cartesianProduct = list1.SelectMany(
//            x => list2,
//            (x, y) => new { Number = x, Letter = y }
//        ).ToList();

//        foreach (var item in cartesianProduct)
//            Console.WriteLine($"({item.Number}, {item.Letter})");
//        // Вывод: (1, a), (1, b), (2, a), (2, b), (3, a), (3, b)
//    }
//}

////79
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var tree = new List<Node>
//        {
//            new Node { Value = 1, Children = new List<Node>
//            {
//                new Node { Value = 2 },
//                new Node { Value = 3, Children = new List<Node>
//                {
//                    new Node { Value = 4 }
//                } }
//            } }
//        };

//        var flattened = tree.SelectMany(node => Flatten(node)).ToList();
//        Console.WriteLine(string.Join(", ", flattened)); // Вывод: 1, 2, 3, 4
//    }

//    static IEnumerable<int> Flatten(Node node)
//    {
//        yield return node.Value;
//        foreach (var child in node.Children.SelectMany(Flatten))
//            yield return child;
//    }
//}

//class Node
//{
//    public int Value { get; set; }
//    public List<Node> Children { get; set; } = new List<Node>();
//}

////80
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var nestedCollections = new List<IEnumerable<int>>
//        {
//            new List<int> { 1, 2, 3 },
//            new int[] { 4, 5, 6 },
//            new HashSet<int> { 7, 8, 9 }
//        };

//        var allElements = nestedCollections.SelectMany(collection => collection).ToList();
//        Console.WriteLine(string.Join(", ", allElements)); // Вывод: 1, 2, 3, 4, 5, 6, 7, 8, 9
//    }
//}

////81
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> list1 = new List<int> { 1, 2 };
//        List<char> list2 = new List<char> { 'a', 'b' };
//        List<string> list3 = new List<string> { "X", "Y" };

//        var combinations = list1.SelectMany(
//            x => list2.SelectMany(
//                y => list3,
//                (x, y, z) => new { x, y, z }
//            ),
//            (x, y, z) => new { x.x, y.y, z }
//        ).ToList();

//        foreach (var combo in combinations)
//            Console.WriteLine($"({combo.x}, {combo.y}, {combo.z})");
//        // Вывод: (1, a, X), (1, a, Y), (1, b, X), (1, b, Y), (2, a, X), (2, a, Y), (2, b, X), (2, b, Y)
//    }
//}

////82
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<string> words = new List<string> { "hello", "world" };
//        var characters = words.SelectMany(word => word.ToCharArray()).ToList();
//        Console.WriteLine(string.Join(", ", characters)); // Вывод: h, e, l, l, o, w, o, r, l, d
//    }
//}

////83
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<List<int>> listOfLists = new List<List<int>>
//        {
//            new List<int> { 1, 2, 3 },
//            new List<int> { 4, 5 },
//            new List<int> { 6, 7, 8, 9 }
//        };

//        var indexedItems = listOfLists.SelectMany(
//            (list, listIndex) => list.Select(
//                (item, itemIndex) => new { ListIndex = listIndex, ItemIndex = itemIndex, Value = item }
//            )
//        ).ToList();

//        foreach (var item in indexedItems)
//            Console.WriteLine($"List {item.ListIndex}, Item {item.ItemIndex}: {item.Value}");
//        // Вывод: List 0, Item 0: 1, List 0, Item 1: 2, ...
//    }
//}

////84
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> list1 = new List<int> { 1, 2, 3 };
//        List<int> list2 = new List<int> { 4, 5, 6 };
//        List<int> list3 = new List<int> { 7, 8, 9 };

//        var combined = new List<List<int>> { list1, list2, list3 }.SelectMany(list => list).ToList();
//        Console.WriteLine(string.Join(", ", combined)); // Вывод: 1, 2, 3, 4, 5, 6, 7, 8, 9
//    }
//}

////85
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 11, 5 };
//        bool hasGreaterThan10 = numbers.Any(x => x > 10);
//        Console.WriteLine(hasGreaterThan10); // Вывод: True
//    }
//}

////86
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        bool allPositive = numbers.All(x => x > 0);
//        Console.WriteLine(allPositive); // Вывод: True
//    }
//}

////87
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        bool containsThree = numbers.Contains(3);
//        Console.WriteLine(containsThree); // Вывод: True
//    }
//}

////88
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<Person> people = new List<Person>
//        {
//            new Person { Name = "Alice", Age = 25 },
//            new Person { Name = "Bob", Age = 30 },
//            new Person { Name = "Charlie", Age = 20 }
//        };

//        bool hasAdult = people.Any(person => person.Age >= 18);
//        Console.WriteLine(hasAdult); // Вывод: True
//    }
//}

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

////89
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int>();
//        bool isEmpty = !numbers.Any();
//        Console.WriteLine(isEmpty); // Вывод: True
//    }
//}

////90
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        int n = 5;
//        bool hasExactlyN = numbers.Count == n;
//        Console.WriteLine(hasExactlyN); // Вывод: True
//    }
//}

////91
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] array1 = { 1, 2, 3 };
//        int[] array2 = { 4, 5, 6 };
//        int[] concatenated = array1.Concat(array2).ToArray();
//        Console.WriteLine(string.Join(", ", concatenated)); // Вывод: 1, 2, 3, 4, 5, 6
//    }
//}

////92
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<string> words = new List<string> { "Hello", " ", "world", "!" };
//        string concatenated = string.Concat(words);
//        Console.WriteLine(concatenated); // Вывод: Hello world!
//    }
//}

////93
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<object> mixedList = new List<object> { 1, "two", 3, "four", 5 };
//        var numbers = mixedList.OfType<int>().ToList();
//        Console.WriteLine(string.Join(", ", numbers)); // Вывод: 1, 3, 5
//    }
//}

////94
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> sortedList1 = new List<int> { 1, 3, 5 };
//        List<int> sortedList2 = new List<int> { 2, 4, 6 };
//        var merged = sortedList1.Concat(sortedList2).OrderBy(x => x).ToList();
//        Console.WriteLine(string.Join(", ", merged)); // Вывод: 1, 2, 3, 4, 5, 6
//    }
//}

////95
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<object> objects = new List<object> { 1, 2, 3, "four", 5 };
//        var numbers = objects.OfType<int>().ToList();
//        Console.WriteLine(string.Join(", ", numbers)); // Вывод: 1, 2, 3, 5
//    }
//}

////96
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<object> mixedList = new List<object> { 1, "two", 3.0, "four", 5 };
//        var integers = mixedList.OfType<int>().ToList();
//        Console.WriteLine(string.Join(", ", integers)); // Вывод: 1, 5
//    }
//}

////97
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<object> mixedList = new List<object> { 1, "two", 3.14, "four", 5 };
//        var doubles = mixedList.OfType<double>().ToList();
//        Console.WriteLine(string.Join(", ", doubles)); // Вывод: 3.14
//    }
//}

////98
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<object> mixedList = new List<object> { 1, "two", 3, "four", 5 };
//        var numbers = mixedList.Where(x => x is int).Cast<int>().ToList();
//        Console.WriteLine(string.Join(", ", numbers)); // Вывод: 1, 3, 5
//    }
//}

////99
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<Person> people = new List<Person>
//        {
//            new Person { Name = "Alice", Age = 25, Department = "IT" },
//            new Person { Name = "Bob", Age = 30, Department = "HR" },
//            new Person { Name = "Charlie", Age = 20, Department = "IT" },
//            new Person { Name = "David", Age = 35, Department = "HR" },
//            new Person { Name = "Eve", Age = 28, Department = "IT" }
//        };

//        var result = people
//            .GroupBy(p => p.Department)
//            .Where(g => g.Average(p => p.Age) > 25)
//            .OrderBy(g => g.Key)
//            .Select(g => new
//            {
//                Department = g.Key,
//                AverageAge = g.Average(p => p.Age),
//                PeopleCount = g.Count()
//            })
//            .ToList();

//        foreach (var item in result)
//            Console.WriteLine($"{item.Department}: Avg Age = {item.AverageAge}, Count = {item.PeopleCount}");
//        // Вывод: HR: Avg Age = 32.5, Count = 2
//    }
//}

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Department { get; set; }
//}

////100
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<Employee> employees = new List<Employee>
//        {
//            new Employee { Id = 1, Name = "Alice", DepartmentId = 1 },
//            new Employee { Id = 2, Name = "Bob", DepartmentId = 2 },
//            new Employee { Id = 3, Name = "Charlie", DepartmentId = 1 },
//            new Employee { Id = 4, Name = "David", DepartmentId = 2 }
//        };

//        List<Department> departments = new List<Department>
//        {
//            new Department { Id = 1, Name = "IT" },
//            new Department { Id = 2, Name = "HR" }
//        };

//        var result = employees
//            .Join(
//                departments,
//                e => e.DepartmentId,
//                d => d.Id,
//                (e, d) => new { e.Name, d.Name }
//            )
//            .GroupBy(x => x.Name)
//            .Select(g => new
//            {
//                Department = g.Key,
//                EmployeeCount = g.Count(),
//                EmployeeNames = string.Join(", ", g.Select(x => x.Name))
//            })
//            .OrderByDescending(x => x.EmployeeCount)
//            .ToList();

//        foreach (var item in result)
//            Console.WriteLine($"{item.Department}: {item.EmployeeCount} ({item.EmployeeNames})");
//        // Вывод: IT: 2 (Alice, Charlie), HR: 2 (Bob, David)
//    }
//}

//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int DepartmentId { get; set; }
//}

//class Department
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
