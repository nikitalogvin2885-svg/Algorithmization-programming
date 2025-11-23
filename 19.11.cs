//1.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Hello, World!");
//        Console.ReadKey();
//    }
//}

//1.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите первое число:");
//        double a = double.Parse(Console.ReadLine());

//        Console.WriteLine("Введите второе число:");
//        double b = double.Parse(Console.ReadLine());

//        Console.WriteLine($"Сумма: {a + b}");
//        Console.WriteLine($"Разность: {a - b}");
//        Console.WriteLine($"Произведение: {a * b}");
//        Console.WriteLine($"Частное: {(b != 0 ? a / b : "на ноль делить нельзя")}");

//        Console.ReadKey();
//    }
//}

//1.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите температуру в °C: ");
//        double c = double.Parse(Console.ReadLine());

//        double f = c * 9.0 / 5.0 + 32;
//        Console.WriteLine($"Температура в °F: {f}");

//        Console.ReadKey();
//    }
//}

//1.4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите длину прямоугольника: ");
//        double length = double.Parse(Console.ReadLine());

//        Console.Write("Введите ширину прямоугольника: ");
//        double width = double.Parse(Console.ReadLine());

//        double area = length * width;
//        double perimeter = 2 * (length + width);

//        Console.WriteLine($"Площадь = {area}");
//        Console.WriteLine($"Периметр = {perimeter}");

//        Console.ReadKey();
//    }
//}

//1.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите делимое: ");
//        int a = int.Parse(Console.ReadLine());

//        Console.Write("Введите делитель: ");
//        int b = int.Parse(Console.ReadLine());

//        Console.WriteLine($"Остаток от деления {a} % {b} = {a % b}");

//        Console.ReadKey();
//    }
//}

//1.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите a: ");
//        int a = int.Parse(Console.ReadLine());

//        Console.Write("Введите b: ");
//        int b = int.Parse(Console.ReadLine());

//        a = a + b;
//        b = a - b;
//        a = a - b;

//        Console.WriteLine($"После обмена: a = {a}, b = {b}");

//        Console.ReadKey();
//    }
//}

//1.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите первое число: ");
//        double a = double.Parse(Console.ReadLine());

//        Console.Write("Введите второе число: ");
//        double b = double.Parse(Console.ReadLine());

//        Console.Write("Введите третье число: ");
//        double c = double.Parse(Console.ReadLine());

//        double average = (a + b + c) / 3;

//        Console.WriteLine($"Среднее арифметическое = {average}");

//        Console.ReadKey();
//    }
//}

//1.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите радиус круга: ");
//        double r = double.Parse(Console.ReadLine());

//        double area = Math.PI * r * r;

//        Console.WriteLine($"Площадь круга = {area}");

//        Console.ReadKey();
//    }
//}

//1.9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Сколько вам лет? ");
//        int years = int.Parse(Console.ReadLine());

//        long seconds = (long)years * 365 * 24 * 60 * 60;

//        Console.WriteLine($"Вы прожили примерно {seconds} секунд");

//        Console.ReadKey();
//    }
//}

//1.10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите сумму в рублях: ");
//        double rub = double.Parse(Console.ReadLine());

//        double usd = rub / 97.5;
//        double eur = rub / 105.3;

//        Console.WriteLine($"{rub} руб. = {usd:F2} USD");
//        Console.WriteLine($"{rub} руб. = {eur:F2} EUR");

//        Console.ReadKey();
//    }
//}

//2.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        int n = int.Parse(Console.ReadLine());

//        if (n % 2 == 0)
//            Console.WriteLine("Чётное");
//        else
//            Console.WriteLine("Нечётное");

//        Console.ReadKey();
//    }
//}

//2.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите три числа через пробел: ");
//        string[] s = Console.ReadLine().Split();
//        int a = int.Parse(s[0]), b = int.Parse(s[1]), c = int.Parse(s[2]);

//        int max = a;
//        if (b > max) max = b;
//        if (c > max) max = c;

//        Console.WriteLine($"Максимум: {max}");
//        Console.ReadKey();
//    }
//}

//2.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Первое число: ");
//        double a = double.Parse(Console.ReadLine());
//        Console.Write("Второе число: ");
//        double b = double.Parse(Console.ReadLine());
//        Console.Write("Операция (+ - * /): ");
//        string op = Console.ReadLine();

//        switch (op)
//        {
//            case "+": Console.WriteLine(a + b); break;
//            case "-": Console.WriteLine(a - b); break;
//            case "*": Console.WriteLine(a * b); break;
//            case "/":
//                if (b == 0) Console.WriteLine("Ошибка: деление на 0");
//                else Console.WriteLine(a / b);
//                break;
//            default: Console.WriteLine("Неизвестная операция"); break;
//        }
//        Console.ReadKey();
//    }
//}

//2.4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите год: ");
//        int year = int.Parse(Console.ReadLine());

//        bool leap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
//        Console.WriteLine(leap ? "Високосный год" : "Обычный год");

//        Console.ReadKey();
//    }
//}

//2.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите баллы (0-100): ");
//        int score = int.Parse(Console.ReadLine());

//        if (score >= 90) Console.WriteLine("A");
//        else if (score >= 80) Console.WriteLine("B");
//        else if (score >= 70) Console.WriteLine("C");
//        else if (score >= 60) Console.WriteLine("D");
//        else Console.WriteLine("F");

//        Console.ReadKey();
//    }
//}

//2.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Который час (0-23): ");
//        int h = int.Parse(Console.ReadLine());

//        if (h >= 5 && h < 12) Console.WriteLine("Утро");
//        else if (h >= 12 && h < 18) Console.WriteLine("День");
//        else if (h >= 18 && h < 23) Console.WriteLine("Вечер");
//        else Console.WriteLine("Ночь");

//        Console.ReadKey();
//    }
//}

//2.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите три стороны: ");
//        string[] s = Console.ReadLine().Split();
//        double a = double.Parse(s[0]), b = double.Parse(s[1]), c = double.Parse(s[2]);

//        if (a + b <= c || b + c <= a || a + c <= b)
//            Console.WriteLine("Не существует");
//        else if (a == b && b == c)
//            Console.WriteLine("Равносторонний");
//        else if (a == b || b == c || a == c)
//            Console.WriteLine("Равнобедренный");
//        else
//            Console.WriteLine("Разносторонний");

//        Console.ReadKey();
//    }
//}

//2.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите возраст: ");
//        int age = int.Parse(Console.ReadLine());

//        if (age < 13) Console.WriteLine("Ребёнок");
//        else if (age < 18) Console.WriteLine("Подросток");
//        else if (age < 65) Console.WriteLine("Взрослый");
//        else Console.WriteLine("Пенсионер");

//        Console.ReadKey();
//    }
//}

//2.9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("a = "); double a = double.Parse(Console.ReadLine());
//        Console.Write("b = "); double b = double.Parse(Console.ReadLine());
//        Console.Write("c = "); double c = double.Parse(Console.ReadLine());

//        double d = b * b - 4 * a * c;

//        if (d < 0)
//            Console.WriteLine("Нет действительных корней");
//        else if (d == 0)
//            Console.WriteLine($"x = {-b / (2 * a)}");
//        else
//        {
//            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//            Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
//        }
//        Console.ReadKey();
//    }
//}

//2.10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Сумма покупки: ");
//        double sum = double.Parse(Console.ReadLine());

//        if (sum >= 5000) sum *= 0.85;
//        else if (sum >= 1000) sum *= 0.90;

//        Console.WriteLine($"К оплате: {sum}");
//        Console.ReadKey();
//    }
//}

//2.11
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Номер месяца (1-12): ");
//        int m = int.Parse(Console.ReadLine());

//        switch (m)
//        {
//            case 1: Console.WriteLine("Январь"); break;
//            case 2: Console.WriteLine("Февраль"); break;
//            case 3: Console.WriteLine("Март"); break;
//            case 4: Console.WriteLine("Апрель"); break;
//            case 5: Console.WriteLine("Май"); break;
//            case 6: Console.WriteLine("Июнь"); break;
//            case 7: Console.WriteLine("Июль"); break;
//            case 8: Console.WriteLine("Август"); break;
//            case 9: Console.WriteLine("Сентябрь"); break;
//            case 10: Console.WriteLine("Октябрь"); break;
//            case 11: Console.WriteLine("Ноябрь"); break;
//            case 12: Console.WriteLine("Декабрь"); break;
//            default: Console.WriteLine("Некорректный номер"); break;
//        }
//        Console.ReadKey();
//    }
//}

//2.12
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите пароль: ");
//        string p = Console.ReadLine();

//        if (p.Length < 8)
//            Console.WriteLine("Слабый");
//        else if (!p.Any(char.IsUpper) || !p.Any(char.IsLower) || !p.Any(char.IsDigit))
//            Console.WriteLine("Средний");
//        else
//            Console.WriteLine("Сильный");

//        Console.ReadKey();
//    }
//}

//3.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("N = ");
//        int n = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= n; i++)
//            Console.Write(i + " ");

//        Console.ReadKey();
//    }
//}

//3.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("N = ");
//        int n = int.Parse(Console.ReadLine());
//        int sum = 0;

//        for (int i = 1; i <= n; i++)
//            sum += i;

//        Console.WriteLine($"Сумма = {sum}");
//        Console.ReadKey();
//    }
//}

//3.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 9; i++)
//        {
//            for (int j = 1; j <= 9; j++)
//                Console.Write($"{i} × {j} = {i * j}\t");
//            Console.WriteLine();
//        }
//        Console.ReadKey();
//    }
//}

//3.4
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("N = ");
//        int n = int.Parse(Console.ReadLine());
//        long fact = 1;

//        for (int i = 1; i <= n; i++)
//            fact *= i;

//        Console.WriteLine($"{n}! = {fact}");
//        Console.ReadKey();
//    }
//}

//3.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Сколько чисел Фибоначчи вывести? ");
//        int n = int.Parse(Console.ReadLine());

//        long a = 0, b = 1;
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(a + " ");
//            long temp = a + b;
//            a = b;
//            b = temp;
//        }
//        Console.ReadKey();
//    }
//}

//3.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("N = ");
//        int n = int.Parse(Console.ReadLine());

//        if (n < 2)
//        {
//            Console.WriteLine("Не простое");
//            Console.ReadKey(); return;
//        }

//        bool prime = true;
//        for (int i = 2; i * i <= n; i++)
//            if (n % i == 0) { prime = false; break; }

//        Console.WriteLine(prime ? "Простое" : "Не простое");
//        Console.ReadKey();
//    }
//}

//3.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Число = ");
//        int n = int.Parse(Console.ReadLine());
//        int rev = 0;

//        while (n > 0)
//        {
//            rev = rev * 10 + n % 10;
//            n /= 10;
//        }
//        Console.WriteLine($"Перевёрнутое: {rev}");
//        Console.ReadKey();
//    }
//}

//3.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Число = ");
//        int n = int.Parse(Console.ReadLine());
//        int sum = 0;

//        while (n > 0)
//        {
//            sum += n % 10;
//            n /= 10;
//        }
//        Console.WriteLine($"Сумма цифр = {sum}");
//        Console.ReadKey();
//    }
//}

//3.9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("До какого числа вывести простые? ");
//        int n = int.Parse(Console.ReadLine());

//        for (int i = 2; i <= n; i++)
//        {
//            bool prime = true;
//            for (int j = 2; j * j <= i; j++)
//                if (i % j == 0) { prime = false; break; }
//            if (prime) Console.Write(i + " ");
//        }
//        Console.ReadKey();
//    }
//}

//3.10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Random rnd = new Random();
//        int number = rnd.Next(1, 101);
//        int guess;

//        Console.WriteLine("Угадай число от 1 до 100!");

//        do
//        {
//            Console.Write("Твой вариант: ");
//            guess = int.Parse(Console.ReadLine());

//            if (guess < number) Console.WriteLine("Больше ↑");
//            else if (guess > number) Console.WriteLine("Меньше ↓");
//        } while (guess != number);

//        Console.WriteLine("Угадал!");
//        Console.ReadKey();
//    }
//}

//3.11
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Высота пирамиды: ");
//        int h = int.Parse(Console.ReadLine());

//        for (int i = 1; i <= h; i++)
//        {
//            for (int j = 0; j < h - i; j++) Console.Write(" ");
//            for (int j = 0; j < 2 * i - 1; j++) Console.Write("*");
//            Console.WriteLine();
//        }
//        Console.ReadKey();
//    }
//}

//3.12
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("a = "); int a = int.Parse(Console.ReadLine());
//        Console.Write("b = "); int b = int.Parse(Console.ReadLine());

//        while (b != 0)
//        {
//            int temp = b;
//            b = a % b;
//            a = temp;
//        }
//        Console.WriteLine($"НОД = {a}");
//        Console.ReadKey();
//    }
//}

//4.1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Размер массива: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] a = new int[n];
//        Random r = new Random();

//        for (int i = 0; i < n; i++)
//            a[i] = r.Next(-50, 51);

//        Console.WriteLine("Массив:");
//        foreach (int x in a) Console.Write(x + " ");
//        Console.ReadKey();
//    }
//}

//4.2
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] a = { 3, 7, 2, 9, 5 };
//        int sum = 0;

//        foreach (int x in a)
//            sum += x;

//        Console.WriteLine($"Сумма = {sum}");
//        Console.ReadKey();
//    }
//}

//4.3
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] a = { 4, -2, 8, 1, 9, 3 };
//        int max = a[0], index = 0;

//        for (int i = 1; i < a.Length; i++)
//            if (a[i] > max) { max = a[i]; index = i; }

//        Console.WriteLine($"Максимум = {max}, индекс = {index}");
//        Console.ReadKey();
//    }
//}

//4.4
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] a = { 1, 2, 3, 4, 5 };
//        Array.Reverse(a);

//        Console.WriteLine(string.Join(" ", a));
//        Console.ReadKey();
//    }
//}

//4.5
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] a = { 5, 8, 2, 9, 12 };
//        Console.Write("Какое число искать? ");
//        int x = int.Parse(Console.ReadLine());
//        int pos = -1;

//        for (int i = 0; i < a.Length; i++)
//            if (a[i] == x) { pos = i; break; }

//        Console.WriteLine(pos == -1 ? "Не найдено" : $"Найдено на позиции {pos}");
//        Console.ReadKey();
//    }
//}

//4.6
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] a = { 3, 6, 7, 8, 11, 14, 15 };
//        int even = 0, odd = 0;

//        foreach (int x in a)
//            if (x % 2 == 0) even++; else odd++;

//        Console.WriteLine($"Чётных: {even}, Нечётных: {odd}");
//        Console.ReadKey();
//    }
//}

//4.7
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] a = { 64, 34, 25, 12, 22, 11, 90 };

//        for (int i = 0; i < a.Length - 1; i++)
//            for (int j = 0; j < a.Length - i - 1; j++)
//                if (a[j] > a[j + 1])
//                {
//                    int temp = a[j];
//                    a[j] = a[j + 1];
//                    a[j + 1] = temp;
//                }

//        Console.WriteLine(string.Join(" ", a));
//        Console.ReadKey();
//    }
//}

//4.8
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] m = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        for (int i = 0; i < m.GetLength(0); i++)
//        {
//            for (int j = 0; j < m.GetLength(1); j++)
//                Console.Write(m[i, j] + "\t");
//            Console.WriteLine();
//        }
//        Console.ReadKey();
//    }
//}

//4.9
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] m = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        int sumMain = 0, sumAnti = 0;
//        int n = m.GetLength(0);

//        for (int i = 0; i < n; i++)
//        {
//            sumMain += m[i, i];
//            sumAnti += m[i, n - 1 - i];
//        }

//        Console.WriteLine($"Главная диагональ: {sumMain}");
//        Console.WriteLine($"Побочная диагональ: {sumAnti}");
//        Console.ReadKey();
//    }
//}

//4.10
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[][] j = new int[4][];
//        Random r = new Random();

//        for (int i = 0; i < j.Length; i++)
//        {
//            j[i] = new int[r.Next(3, 8)];
//            for (int k = 0; k < j[i].Length; k++)
//                j[i][k] = r.Next(100);
//        }

//        foreach (int[] row in j)
//            Console.WriteLine(string.Join(" ", row));

//        Console.ReadKey();
//    }
//}

//4.11
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] m = {
//            {1, 2, 3},
//            {4, 5, 6},
//            {7, 8, 9}
//        };

//        int rows = m.GetLength(0);
//        int cols = m.GetLength(1);
//        int[,] t = new int[cols, rows];

//        for (int i = 0; i < rows; i++)
//            for (int j = 0; j < cols; j++)
//                t[j, i] = m[i, j];

//        for (int i = 0; i < cols; i++)
//        {
//            for (int j = 0; j < rows; j++)
//                Console.Write(t[i, j] + "\t");
//            Console.WriteLine();
//        }
//        Console.ReadKey();
//    }
//}

//4.12
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] a = { 1, 3, 5, 7 };
//        int[] b = { 2, 4, 6, 8, 10 };

//        int[] c = new int[a.Length + b.Length];
//        int i = 0, j = 0, k = 0;

//        while (i < a.Length && j < b.Length)
//            c[k++] = (a[i] <= b[j]) ? a[i++] : b[j++];

//        while (i < a.Length) c[k++] = a[i++];
//        while (j < b.Length) c[k++] = b[j++];

//        Console.WriteLine(string.Join(" ", c));
//        Console.ReadKey();
//    }
//}

//5.1
//using System;

//class Program
//{
//    static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    static void Main()
//    {
//        Console.Write("a = "); int a = int.Parse(Console.ReadLine());
//        Console.Write("b = "); int b = int.Parse(Console.ReadLine());
//        Console.WriteLine($"Сумма = {Sum(a, b)}");
//        Console.ReadKey();
//    }
//}

//5.2
//using System;

//class Program
//{
//    static bool IsEven(int n)
//    {
//        return n % 2 == 0;
//    }

//    static void Main()
//    {
//        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
//        Console.WriteLine(IsEven(n) ? "Чётное" : "Нечётное");
//        Console.ReadKey();
//    }
//}

//5.3
//using System;

//class Program
//{
//    static long Factorial(int n)
//    {
//        long res = 1;
//        for (int i = 2; i <= n; i++)
//            res *= i;
//        return res;
//    }

//    static void Main()
//    {
//        Console.Write("N = "); int n = int.Parse(Console.ReadLine());
//        Console.WriteLine($"{n}! = {Factorial(n)}");
//        Console.ReadKey();
//    }
//}

//5.4
//using System;

//class Program
//{
//    static void Greet(string name = "Гость")
//    {
//        Console.WriteLine($"Привет, {name}!");
//    }

//    static void Main()
//    {
//        Greet("Алексей");
//        Greet();
//        Console.ReadKey();
//    }
//}

//5.5
//using System;

//class Program
//{
//    static int FindMax(int[] arr)
//    {
//        int max = arr[0];
//        foreach (int x in arr)
//            if (x > max) max = x;
//        return max;
//    }

//    static void Main()
//    {
//        int[] a = { 3, 7, 2, 9, 5 };
//        Console.WriteLine($"Максимум = {FindMax(a)}");
//        Console.ReadKey();
//    }
//}

//5.6
//using System;

//class Program
//{
//    static int Square(int x) => x * x;
//    static double Square(double x) => x * x;

//    static void Main()
//    {
//        Console.WriteLine(Square(5));
//        Console.WriteLine(Square(3.5));
//        Console.ReadKey();
//    }
//}

//5.7
//using System;

//class Program
//{
//    static void Swap(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }

//    static void Main()
//    {
//        int x = 10, y = 20;
//        Swap(ref x, ref y);
//        Console.WriteLine($"x = {x}, y = {y}");
//        Console.ReadKey();
//    }
//}

//5.8
//using System;

//class Program
//{
//    static bool TryParse(string s, out int result)
//    {
//        result = 0;
//        if (!int.TryParse(s, out result)) return false;
//        return true;
//    }

//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        string input = Console.ReadLine();

//        if (TryParse(input, out int value))
//            Console.WriteLine($"Успешно: {value * 2}");
//        else
//            Console.WriteLine("Ошибка ввода");
//        Console.ReadKey();
//    }
//}

//5.9
//using System;

//class Program
//{
//    static void BubbleSort(int[] arr)
//    {
//        for (int i = 0; i < arr.Length - 1; i++)
//            for (int j = 0; j < arr.Length - i - 1; j++)
//                if (arr[j] > arr[j + 1])
//                {
//                    int temp = arr[j];
//                    arr[j] = arr[j + 1];
//                    arr[j + 1] = temp;
//                }
//    }

//    static void Main()
//    {
//        int[] a = { 64, 34, 25, 12, 22 };
//        BubbleSort(a);
//        Console.WriteLine(string.Join(" ", a));
//        Console.ReadKey();
//    }
//}

//5.10
//using System;

//class Program
//{
//    static bool IsPalindrome(string s)
//    {
//        s = s.ToLower();
//        int left = 0, right = s.Length - 1;
//        while (left < right)
//            if (s[left++] != s[right--]) return false;
//        return true;
//    }

//    static void Main()
//    {
//        Console.Write("Строка: ");
//        string s = Console.ReadLine();
//        Console.WriteLine(IsPalindrome(s) ? "Палиндром" : "Не палиндром");
//        Console.ReadKey();
//    }
//}

//5.11
//using System;

//class Program
//{
//    static int Sum(params int[] numbers)
//    {
//        int total = 0;
//        foreach (int n in numbers)
//            total += n;
//        return total;
//    }

//    static void Main()
//    {
//        Console.WriteLine(Sum(1, 2, 3, 4, 5));
//        Console.WriteLine(Sum(10, 20));
//        Console.WriteLine(Sum());
//        Console.ReadKey();
//    }
//}


//6.1
//using System;

//class Program
//{
//    static int Factorial(int n)
//    {
//        if (n == 0 || n == 1)
//            return 1;
//        return n * Factorial(n - 1);
//    }

//    static void Main()
//    {
//        int number = 5;
//        Console.WriteLine($"Факториал числа {number} равен {Factorial(number)}");
//    }
//}

//6.2
//using System;

//class Program
//{
//    static int Fibonacci(int n)
//    {
//        if (n <= 1)
//            return n;
//        return Fibonacci(n - 1) + Fibonacci(n - 2);
//    }

//    static void Main()
//    {
//        int number = 10;
//        Console.WriteLine($"{number}-е число Фибоначчи: {Fibonacci(number)}");
//    }
//}

//6.3
//using System;

//class Program
//{
//    static int SumDigits(int n)
//    {
//        if (n < 10)
//            return n;
//        return n % 10 + SumDigits(n / 10);
//    }

//    static void Main()
//    {
//        int number = 12345;
//        Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}");
//    }
//}

//6.4
//using System;

//class Program
//{
//    static double Power(double x, int n)
//    {
//        if (n == 0)
//            return 1;
//        if (n < 0)
//            return 1 / Power(x, -n);
//        return x * Power(x, n - 1);
//    }

//    static void Main()
//    {
//        double x = 2;
//        int n = 5;
//        Console.WriteLine($"{x} в степени {n} равно {Power(x, n)}");
//    }
//}

//6.5
//using System;

//class Program
//{
//    static int GCD(int a, int b)
//    {
//        if (b == 0)
//            return a;
//        return GCD(b, a % b);
//    }

//    static void Main()
//    {
//        int a = 48, b = 18;
//        Console.WriteLine($"НОД чисел {a} и {b} равен {GCD(a, b)}");
//    }
//}

//6.6
//using System;

//class Program
//{
//    static string ReverseString(string s)
//    {
//        if (s.Length <= 1)
//            return s;
//        return ReverseString(s.Substring(1)) + s[0];
//    }

//    static void Main()
//    {
//        string str = "hello";
//        Console.WriteLine($"Перевернутая строка: {ReverseString(str)}");
//    }
//}

//6.7
//using System;

//class Program
//{
//    static int BinarySearch(int[] arr, int target, int left, int right)
//    {
//        if (left > right)
//            return -1;
//        int mid = left + (right - left) / 2;
//        if (arr[mid] == target)
//            return mid;
//        if (arr[mid] > target)
//            return BinarySearch(arr, target, left, mid - 1);
//        return BinarySearch(arr, target, mid + 1, right);
//    }

//    static void Main()
//    {
//        int[] arr = { 1, 3, 5, 7, 9, 11, 13 };
//        int target = 7;
//        int result = BinarySearch(arr, target, 0, arr.Length - 1);
//        Console.WriteLine($"Элемент {target} найден на позиции: {result}");
//    }
//}

//6.8
//using System;

//class Program
//{
//    static int SumArray(int[] arr, int index)
//    {
//        if (index == arr.Length)
//            return 0;
//        return arr[index] + SumArray(arr, index + 1);
//    }

//    static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4, 5 };
//        Console.WriteLine($"Сумма элементов массива: {SumArray(arr, 0)}");
//    }
//}

//6.9
//using System;

//class Program
//{
//    static void HanoiTowers(int n, char from, char to, char aux)
//    {
//        if (n == 1)
//        {
//            Console.WriteLine($"Переместить диск 1 с {from} на {to}");
//            return;
//        }
//        HanoiTowers(n - 1, from, aux, to);
//        Console.WriteLine($"Переместить диск {n} с {from} на {to}");
//        HanoiTowers(n - 1, aux, to, from);
//    }

//    static void Main()
//    {
//        int disks = 3;
//        HanoiTowers(disks, 'A', 'C', 'B');
//    }
//}

//6.10
//using System;

//class Program
//{
//    static bool IsPalindrome(string s, int left, int right)
//    {
//        if (left >= right)
//            return true;
//        if (s[left] != s[right])
//            return false;
//        return IsPalindrome(s, left + 1, right - 1);
//    }

//    static void Main()
//    {
//        string str = "madam";
//        bool result = IsPalindrome(str, 0, str.Length - 1);
//        Console.WriteLine($"Строка '{str}' {(result ? "является" : "не является")} палиндромом.");
//    }
//}

//7.1
//using System;

//class Program
//{
//    static void SelectionSort(int[] arr)
//    {
//        for (int i = 0; i < arr.Length - 1; i++)
//        {
//            int minIndex = i;
//            for (int j = i + 1; j < arr.Length; j++)
//            {
//                if (arr[j] < arr[minIndex])
//                    minIndex = j;
//            }
//            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
//        }
//    }

//    static void Main()
//    {
//        int[] arr = { 64, 25, 12, 22, 11 };
//        SelectionSort(arr);
//        Console.WriteLine("Сортировка выбором: " + string.Join(", ", arr));
//    }
//}

//7.2
//using System;

//class Program
//{
//    static void InsertionSort(int[] arr)
//    {
//        for (int i = 1; i < arr.Length; i++)
//        {
//            int key = arr[i];
//            int j = i - 1;
//            while (j >= 0 && arr[j] > key)
//            {
//                arr[j + 1] = arr[j];
//                j--;
//            }
//            arr[j + 1] = key;
//        }
//    }

//    static void Main()
//    {
//        int[] arr = { 12, 11, 13, 5, 6 };
//        InsertionSort(arr);
//        Console.WriteLine("Сортировка вставками: " + string.Join(", ", arr));
//    }
//}

//7.3
//using System;

//class Program
//{
//    static void QuickSort(int[] arr, int left, int right)
//    {
//        if (left < right)
//        {
//            int pivot = Partition(arr, left, right);
//            QuickSort(arr, left, pivot - 1);
//            QuickSort(arr, pivot + 1, right);
//        }
//    }

//    static int Partition(int[] arr, int left, int right)
//    {
//        int pivot = arr[right];
//        int i = left - 1;
//        for (int j = left; j < right; j++)
//        {
//            if (arr[j] < pivot)
//            {
//                i++;
//                (arr[i], arr[j]) = (arr[j], arr[i]);
//            }
//        }
//        (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
//        return i + 1;
//    }

//    static void Main()
//    {
//        int[] arr = { 10, 7, 8, 9, 1, 5 };
//        QuickSort(arr, 0, arr.Length - 1);
//        Console.WriteLine("Быстрая сортировка: " + string.Join(", ", arr));
//    }
//}

//7.4
//using System;

//class Program
//{
//    static void MergeSort(int[] arr, int left, int right)
//    {
//        if (left < right)
//        {
//            int mid = left + (right - left) / 2;
//            MergeSort(arr, left, mid);
//            MergeSort(arr, mid + 1, right);
//            Merge(arr, left, mid, right);
//        }
//    }

//    static void Merge(int[] arr, int left, int mid, int right)
//    {
//        int n1 = mid - left + 1;
//        int n2 = right - mid;
//        int[] L = new int[n1];
//        int[] R = new int[n2];

//        Array.Copy(arr, left, L, 0, n1);
//        Array.Copy(arr, mid + 1, R, 0, n2);

//        int i = 0, j = 0, k = left;
//        while (i < n1 && j < n2)
//        {
//            if (L[i] <= R[j])
//                arr[k++] = L[i++];
//            else
//                arr[k++] = R[j++];
//        }

//        while (i < n1)
//            arr[k++] = L[i++];
//        while (j < n2)
//            arr[k++] = R[j++];
//    }

//    static void Main()
//    {
//        int[] arr = { 12, 11, 13, 5, 6, 7 };
//        MergeSort(arr, 0, arr.Length - 1);
//        Console.WriteLine("Сортировка слиянием: " + string.Join(", ", arr));
//    }
//}

//7.5
//using System;

//class Program
//{
//    static int LinearSearch(int[] arr, int target)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] == target)
//                return i;
//        }
//        return -1;
//    }

//    static void Main()
//    {
//        int[] arr = { 2, 3, 4, 10, 40 };
//        int target = 10;
//        int result = LinearSearch(arr, target);
//        Console.WriteLine($"Линейный поиск: элемент {target} найден на позиции {result}");
//    }
//}

//7.6
//using System;

//class Program
//{
//    static int BinarySearch(int[] arr, int target)
//    {
//        int left = 0, right = arr.Length - 1;
//        while (left <= right)
//        {
//            int mid = left + (right - left) / 2;
//            if (arr[mid] == target)
//                return mid;
//            if (arr[mid] < target)
//                left = mid + 1;
//            else
//                right = mid - 1;
//        }
//        return -1;
//    }

//    static void Main()
//    {
//        int[] arr = { 1, 3, 5, 7, 9 };
//        int target = 5;
//        int result = BinarySearch(arr, target);
//        Console.WriteLine($"Бинарный поиск: элемент {target} найден на позиции {result}");
//    }
//}

//7.7
//using System;

//class Program
//{
//    static void FindMinMax(int[] arr, out int min, out int max)
//    {
//        min = max = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < min)
//                min = arr[i];
//            if (arr[i] > max)
//                max = arr[i];
//        }
//    }

//    static void Main()
//    {
//        int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6 };
//        FindMinMax(arr, out int min, out int max);
//        Console.WriteLine($"Минимум: {min}, Максимум: {max}");
//    }
//}

//7.8
//using System;

//class Program
//{
//    static void SieveOfEratosthenes(int n)
//    {
//        bool[] isPrime = new bool[n + 1];
//        for (int i = 2; i <= n; i++)
//            isPrime[i] = true;

//        for (int p = 2; p * p <= n; p++)
//        {
//            if (isPrime[p])
//            {
//                for (int i = p * p; i <= n; i += p)
//                    isPrime[i] = false;
//            }
//        }

//        Console.Write("Простые числа до " + n + ": ");
//        for (int i = 2; i <= n; i++)
//        {
//            if (isPrime[i])
//                Console.Write(i + " ");
//        }
//    }

//    static void Main()
//    {
//        SieveOfEratosthenes(30);
//    }
//}

//7.9
//using System;
//using System.Linq;

//class Program
//{
//    static bool AreAnagrams(string s1, string s2)
//    {
//        if (s1.Length != s2.Length)
//            return false;

//        char[] arr1 = s1.ToLower().ToCharArray();
//        char[] arr2 = s2.ToLower().ToCharArray();

//        Array.Sort(arr1);
//        Array.Sort(arr2);

//        return arr1.SequenceEqual(arr2);
//    }

//    static void Main()
//    {
//        string s1 = "listen", s2 = "silent";
//        Console.WriteLine($"Строки '{s1}' и '{s2}' {(AreAnagrams(s1, s2) ? "являются" : "не являются")} анаграммами.");
//    }
//}

//7.10
//using System;

//class Program
//{
//    static int KadaneAlgorithm(int[] arr)
//    {
//        int maxCurrent = maxGlobal = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            maxCurrent = Math.Max(arr[i], maxCurrent + arr[i]);
//            if (maxCurrent > maxGlobal)
//                maxGlobal = maxCurrent;
//        }
//        return maxGlobal;
//    }

//    static void Main()
//    {
//        int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };
//        Console.WriteLine($"Максимальная подпоследовательность: {KadaneAlgorithm(arr)}");
//    }
//}

//7.11
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void FindDuplicates(int[] arr)
//    {
//        Dictionary<int, int> frequency = new Dictionary<int, int>();
//        foreach (int num in arr)
//        {
//            if (frequency.ContainsKey(num))
//                frequency[num]++;
//            else
//                frequency[num] = 1;
//        }

//        Console.Write("Повторяющиеся элементы: ");
//        foreach (var pair in frequency)
//        {
//            if (pair.Value > 1)
//                Console.Write(pair.Key + " ");
//        }
//    }

//    static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4, 2, 7, 8, 8, 3 };
//        FindDuplicates(arr);
//    }
//}

//8.1
//using System;

//class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string University { get; set; }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Университет: {University}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student { Name = "Иван", Age = 20, University = "МГУ" };
//        student.DisplayInfo();
//    }
//}

//8.2
//using System;

//class BankAccount
//{
//    private double balance;

//    public BankAccount(double initialBalance)
//    {
//        balance = initialBalance;
//    }

//    public void Deposit(double amount)
//    {
//        if (amount > 0)
//            balance += amount;
//    }

//    public void Withdraw(double amount)
//    {
//        if (amount > 0 && balance >= amount)
//            balance -= amount;
//    }

//    public double GetBalance()
//    {
//        return balance;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount(1000);
//        account.Deposit(500);
//        account.Withdraw(200);
//        Console.WriteLine($"Баланс: {account.GetBalance()}");
//    }
//}

//8.3
//using System;

//class Animal
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Животное издает звук");
//    }
//}

//class Dog : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Собака лает");
//    }
//}

//class Cat : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Кошка мяукает");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal dog = new Dog();
//        Animal cat = new Cat();
//        dog.MakeSound();
//        cat.MakeSound();
//    }
//}

//8.4
//using System;

//class Rectangle
//{
//    public double Width { get; }
//    public double Height { get; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public double Area()
//    {
//        return Width * Height;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rectangle = new Rectangle(5, 10);
//        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}");
//    }
//}

//8.5
//using System;

//class Counter
//{
//    public static int Count { get; private set; }

//    public Counter()
//    {
//        Count++;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        new Counter();
//        new Counter();
//        Console.WriteLine($"Количество объектов: {Counter.Count}");
//    }
//}

//8.6
//using System;

//abstract class Shape
//{
//    public abstract double Area();
//}

//class Circle : Shape
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

//class Square : Shape
//{
//    public double Side { get; }

//    public Square(double side)
//    {
//        Side = side;
//    }

//    public override double Area()
//    {
//        return Side * Side;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape circle = new Circle(5);
//        Shape square = new Square(4);
//        Console.WriteLine($"Площадь круга: {circle.Area():F2}");
//        Console.WriteLine($"Площадь квадрата: {square.Area():F2}");
//    }
//}

//8.7
//using System;
//using System.Collections.Generic;

//class Person : IComparable<Person>
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public int CompareTo(Person other)
//    {
//        return Age.CompareTo(other.Age);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Person> people = new List<Person>
//        {
//            new Person { Name = "Алиса", Age = 25 },
//            new Person { Name = "Боб", Age = 20 }
//        };
//        people.Sort();
//        foreach (var person in people)
//            Console.WriteLine($"{person.Name} - {person.Age}");
//    }
//}

//8.8
//using System;

//class Book
//{
//    private string title;
//    private string author;

//    public string Title
//    {
//        get => title;
//        set => title = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Название не может быть пустым");
//    }

//    public string Author
//    {
//        get => author;
//        set => author = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Автор не может быть пустым");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book { Title = "Война и мир", Author = "Л. Толстой" };
//        Console.WriteLine($"Книга: {book.Title}, Автор: {book.Author}");
//    }
//}

//8.9
//using System;

//class ComplexNumber
//{
//    public double Real { get; }
//    public double Imaginary { get; }

//    public ComplexNumber(double real, double imaginary)
//    {
//        Real = real;
//        Imaginary = imaginary;
//    }

//    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
//    {
//        return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
//    }

//    public override string ToString()
//    {
//        return $"{Real} + {Imaginary}i";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ComplexNumber a = new ComplexNumber(1, 2);
//        ComplexNumber b = new ComplexNumber(3, 4);
//        ComplexNumber sum = a + b;
//        Console.WriteLine($"Сумма: {sum}");
//    }
//}

//8.10
//using System;

//class Engine
//{
//    public string Type { get; }

//    public Engine(string type)
//    {
//        Type = type;
//    }
//}

//class Car
//{
//    public string Model { get; }
//    public Engine Engine { get; }

//    public Car(string model, Engine engine)
//    {
//        Model = model;
//        Engine = engine;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Engine engine = new Engine("V6");
//        Car car = new Car("Toyota", engine);
//        Console.WriteLine($"Автомобиль: {car.Model}, Двигатель: {car.Engine.Type}");
//    }
//}

//8.11
//using System;
//using System.Collections.Generic;

//class ShoppingList
//{
//    private List<string> items = new List<string>();

//    public string this[int index]
//    {
//        get => items[index];
//        set => items[index] = value;
//    }

//    public void Add(string item)
//    {
//        items.Add(item);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ShoppingList list = new ShoppingList();
//        list.Add("Хлеб");
//        list.Add("Молоко");
//        Console.WriteLine($"Первый элемент: {list[0]}");
//    }
//}

//8.12
//using System;

//class Calculator
//{
//    public int Divide(int a, int b)
//    {
//        try
//        {
//            return a / b;
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("Ошибка: деление на ноль!");
//            return 0;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calculator = new Calculator();
//        int result = calculator.Divide(10, 0);
//        Console.WriteLine($"Результат: {result}");
//    }
//}

//9.1
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = "example.txt";
//        string text = "Привет, мир!";

//        using (StreamWriter writer = new StreamWriter(path))
//        {
//            writer.WriteLine(text);
//        }

//        Console.WriteLine("Текст записан в файл.");
//    }
//}

//9.2
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = "example.txt";

//        using (StreamReader reader = new StreamReader(path))
//        {
//            string content = reader.ReadToEnd();
//            Console.WriteLine("Содержимое файла:");
//            Console.WriteLine(content);
//        }
//    }
//}

//9.3
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = "example.txt";

//        using (StreamReader reader = new StreamReader(path))
//        {
//            string line;
//            Console.WriteLine("Строки файла:");
//            while ((line = reader.ReadLine()) != null)
//            {
//                Console.WriteLine(line);
//            }
//        }
//    }
//}

//9.4
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = "example.txt";
//        int lineCount = 0;

//        using (StreamReader reader = new StreamReader(path))
//        {
//            while (reader.ReadLine() != null)
//            {
//                lineCount++;
//            }
//        }

//        Console.WriteLine($"Количество строк в файле: {lineCount}");
//    }
//}

//9.5
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = "example.txt";
//        string additionalText = "\nДополнительная строка";

//        using (StreamWriter writer = new StreamWriter(path, append: true))
//        {
//            writer.Write(additionalText);
//        }

//        Console.WriteLine("Текст добавлен в файл.");
//    }
//}

//9.6
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string sourcePath = "example.txt";
//        string destPath = "copy_example.txt";

//        File.Copy(sourcePath, destPath, overwrite: true);

//        Console.WriteLine("Файл скопирован.");
//    }
//}

//9.7
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = "example.txt";
//        string searchWord = "мир";
//        int count = 0;

//        using (StreamReader reader = new StreamReader(path))
//        {
//            string content = reader.ReadToEnd();
//            string[] words = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

//            foreach (string word in words)
//            {
//                if (word.Equals(searchWord, StringComparison.OrdinalIgnoreCase))
//                {
//                    count++;
//                }
//            }
//        }

//        Console.WriteLine($"Слово '{searchWord}' встречается {count} раз(а).");
//    }
//}

//9.8
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        string path = "array.txt";

//        using (StreamWriter writer = new StreamWriter(path))
//        {
//            foreach (int number in numbers)
//            {
//                writer.WriteLine(number);
//            }
//        }

//        Console.WriteLine("Массив записан в файл.");
//    }
//}

//9.9
//using System;
//using System.IO;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        string path = "array.txt";
//        List<int> numbers = new List<int>();

//        using (StreamReader reader = new StreamReader(path))
//        {
//            string line;
//            while ((line = reader.ReadLine()) != null)
//            {
//                if (int.TryParse(line, out int number))
//                {
//                    numbers.Add(number);
//                }
//            }
//        }

//        Console.WriteLine("Числа из файла:");
//        foreach (int number in numbers)
//        {
//            Console.Write(number + " ");
//        }
//    }
//}

//9.10
//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = "example.txt";
//        int lineCount = 0;
//        int wordCount = 0;
//        int charCount = 0;

//        using (StreamReader reader = new StreamReader(path))
//        {
//            string line;
//            while ((line = reader.ReadLine()) != null)
//            {
//                lineCount++;
//                charCount += line.Length;
//                string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//                wordCount += words.Length;
//            }
//        }

//        Console.WriteLine($"Статистика файла:");
//        Console.WriteLine($"Строк: {lineCount}");
//        Console.WriteLine($"Слов: {wordCount}");
//        Console.WriteLine($"Символов: {charCount}");
//    }
//}
