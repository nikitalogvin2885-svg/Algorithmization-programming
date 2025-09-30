//6.7 19
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 1.1; x <= 2.9; x += 0.2)
//        {
//            double y = Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 2;
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 20
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 1; x <= 3; x += 0.2)
//        {
//            double y = 3 * Math.Sin(Math.Sqrt(x)) + 0.25 * x - 3;
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 21
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 0; x <= 2; x += 0.2)
//        {
//            double y = 3 * Math.Cos(x) - Math.Abs(x - 4) + 2;
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 22
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 1.1; x <= 2.9; x += 0.2)
//        {
//            double y = 0.25 * Math.Pow(x, 2) - 2.8 * x - 2;
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 23
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 1; x <= 3; x += 0.2)
//        {
//            double y = Math.Log(Math.Pow(x, 2)) - 1.8 * Math.Sin(x);
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 24
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 0.1; x <= 3; x += 0.2)
//        {
//            double y = Math.Pow(x, 2) + 4 * Math.Sin(Math.PI * x);
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 25
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 1; x <= 2.9; x += 0.2)
//        {
//            double y = 0.5 * Math.Pow(x, 2) - 1 - Math.Log10(x - 3);
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 26
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 0.1; x <= 3; x += 0.2)
//        {
//            double y = Math.Sqrt(1 + x) - 3 * Math.Cos(x);
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 27
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 1; x <= 3; x += 0.2)
//        {
//            double y = Math.Log(Math.Pow(x, 2)) + x - 5;
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 28
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 1; x <= 3; x += 0.2)
//        {
//            double y = Math.Pow(x, 3) - 1.75 * x + 0.75;
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 29
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 0; x <= 2; x += 0.2)
//        {
//            double y = 0.5 * x - 1 - 2 * Math.Cos(x + Math.PI / 4);
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}
//6.7 30
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (double x = 1.1; x <= 3.1; x += 0.2)
//        {
//            double y = 3 * x - 2 * Math.Log(x) - 5;
//            Console.WriteLine($"x = {x}, y = {y}");
//        }
//    }
//}

//6.8 6
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 3.8)
//            y = Math.Log(Math.Abs(1 + x));
//        else if (x >= 2.8 && x <= 3.8)
//            y = Math.Exp(-x);
//        else
//            y = Math.Cos(x);

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 7
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 3.61)
//            y = Math.Exp(-(x + 0.8));
//        else if (x >= 0 && x <= 3.61)
//            y = 1;
//        else
//            y = 0.5 * x;

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 8
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 1.5)
//            y = x;
//        else if (x >= 0 && x <= 1.5)
//            y = 2 * Math.Pow(x, 2) * Math.Sqrt(Math.Cos(2 * x));
//        else
//            y = Math.Exp(-Math.Cos(3 * x));

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 9
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 2.5)
//            y = 1 - Math.Sqrt(Math.Cos(2 * x));
//        else if (x >= 1 && x <= 2.5)
//            y = Math.Pow(x, 2) - x;
//        else
//            y = 1 / (1 + Math.Pow(x, 2));

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 10
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 4.5)
//            y = 2 * x;
//        else if (x >= 0 && x <= 4.5)
//            y = 1 / (1 - Math.Log(Math.Abs(1 + Math.Pow(x, 2))));
//        else
//            y = Math.Exp(-x);

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 11
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 2)
//            y = Math.Sqrt(Math.Log(Math.Pow(x, 2) - 1));
//        else if (x >= 0 && x <= 2)
//            y = -2 * Math.Pow(x, 3);
//        else
//            y = Math.Exp(Math.Cos(x));

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 12
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 3.5)
//            y = (1 - 2 * Math.Pow(x, 3)) / Math.Sqrt(Math.Cos(2 * x - 1));
//        else if (x >= 0 && x <= 3.5)
//            y = Math.Exp(-Math.Cos(2 * x));
//        else
//            y = x;

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 13
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 2.5)
//            y = x + 1;
//        else if (x >= 0 && x <= 2.5)
//            y = 1 / (1 - Math.Pow(x, 4));
//        else
//            y = x + Math.Log(Math.Abs(Math.Sin(x)));

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 14
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 2.5)
//            y = x - 2;
//        else if (x >= 0 && x <= 2.5)
//            y = 1 / (1 + Math.Pow(x, 2));
//        else
//            y = x * Math.Log(Math.Abs(Math.Cos(x)));

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.8 15
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double y;

//        if (x > 4.5)
//            y = 1 + 3 * x;
//        else if (x >= 1 && x <= 4.5)
//            y = Math.Exp(-2 * x);
//        else
//            y = Math.Cos(2 * x) / x;

//        Console.WriteLine($"y = {y:F4}");
//    }
//}

//6.9 6
//using System;

//class Program
//{
//    static double Factorial(int k)
//    {
//        double result = 1;
//        for (int i = 1; i <= k; i++)
//            result *= i;
//        return result;
//    }

//    static double Function(double x)
//    {
//        if (x > 0)
//        {
//            double sum = 0;
//            for (int k = 1; k <= 8; k++)
//                sum += Math.Pow(-1, k) * Math.Pow(x, k) / Factorial(k);
//            return sum;
//        }
//        else
//            return Math.Tan(Math.Pow(x, Math.PI));
//    }

//    static void Main()
//    {
//        double start = -3;
//        double end = 2.5;
//        double step = 1.1;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 7
//using System;

//class Program
//{
//    static double U(double x)
//    {
//        if (x <= 1.5)
//            return Math.Pow(x, 2) - x + 1;
//        else if (x <= 2.5)
//            return Math.Asin(x);
//        else
//            return Math.Pow(Math.Sin(x - 1), 3) + Math.Cos(x + 1);
//    }

//    static double Function(double x)
//    {
//        return 1.5 + Math.Log(Math.Abs(U(x)));
//    }

//    static void Main()
//    {
//        double start = 0;
//        double end = 4;
//        double step = 0.4;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 8
//using System;

//class Program
//{
//    static double Function(double x)
//    {
//        if (x > 0)
//            return Math.Log(Math.Abs(Math.Sqrt(x)));
//        else
//        {
//            double sum = 0;
//            for (int k = 1; k <= 5; k++)
//                sum += k * Math.Pow(x, k);
//            return sum;
//        }
//    }

//    static void Main()
//    {
//        double start = -1;
//        double end = 2;
//        double step = 0.15;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 9
//using System;

//class Program
//{
//    static double Factorial(int k)
//    {
//        double result = 1;
//        for (int i = 1; i <= k; i++)
//            result *= i;
//        return result;
//    }

//    static double Function(double x)
//    {
//        double sum = 0;
//        for (int k = 1; k <= 5; k++)
//            sum += Math.Pow(-3, k) * Math.Pow(x, k) / Factorial(k);
//        return sum;
//    }

//    static void Main()
//    {
//        double start = 0;
//        double end = 5.2;
//        double step = 0.15;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 10
//using System;

//class Program
//{
//    static double Function(double x)
//    {
//        if (x > 0)
//        {
//            double sum = 0;
//            for (int k = 3; k <= 9; k++)
//                sum += Math.Pow(x, k);
//            return sum;
//        }
//        else
//            return Math.Pow(2 - x, 2) - x;
//    }

//    static void Main()
//    {
//        double start = -2;
//        double end = 1;
//        double step = 0.5;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 11
//using System;

//class Program
//{
//    static double U(double x)
//    {
//        return Math.Pow(x, 2) - Math.Asin(Math.Pow(x, 2));
//    }

//    static double Function(double x)
//    {
//        double u = U(x);
//        if (x > Math.PI)
//            return Math.Pow(Math.Abs(u), Math.Log(Math.Abs(u)));
//        else
//            return Math.Pow(u, Math.Log(Math.Abs(u)));
//    }

//    static void Main()
//    {
//        double start = -1;
//        double end = 1;
//        double step = 0.25;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 12
//using System;

//class Program
//{
//    static double U(double x)
//    {
//        if (x <= 2)
//            return (Math.Pow(x, 2) + x + 1) / (3 - x);
//        else
//            return Math.Pow(Math.Sin(x - 1), 3) + Math.Cos(x + 1);
//    }

//    static double Function(double x)
//    {
//        return Math.Exp(U(x));
//    }

//    static void Main()
//    {
//        double start = 1;
//        double end = 3;
//        double step = 0.2;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 13
//using System;

//class Program
//{
//    static double Factorial(int k)
//    {
//        double result = 1;
//        for (int i = 1; i <= k; i++)
//            result *= i;
//        return result;
//    }

//    static double Function(double x)
//    {
//        if (x > 0)
//        {
//            double sum = 0;
//            for (int k = 1; k <= 7; k++)
//                sum += Math.Pow(x, k) / Factorial(k);
//            return sum;
//        }
//        else
//            return Math.Asin(Math.Pow(x, Math.PI));
//    }

//    static void Main()
//    {
//        double start = -1;
//        double end = 2;
//        double step = 0.2;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 14
//using System;

//class Program
//{
//    static double Factorial(int k)
//    {
//        double result = 1;
//        for (int i = 1; i <= k; i++)
//            result *= i;
//        return result;
//    }

//    static double Function(double x)
//    {
//        double sum = 0;
//        for (int k = 1; k <= 5; k++)
//            sum += Math.Pow(x, 2 * k) / Factorial(2 * k);
//        return sum;
//    }

//    static void Main()
//    {
//        double start = 1;
//        double end = 2;
//        double step = 0.1;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 15
//using System;

//class Program
//{
//    static double U(double x)
//    {
//        if (x > -3)
//            return Math.Pow(x, 2) - x + 1;
//        else if (x >= -3 && x <= 3)
//            return Math.Asin(x);
//        else
//            return Math.Sin(x - 1) + Math.Cos(x + 1);
//    }

//    static double Function(double x)
//    {
//        double u = U(x);
//        return 2.51 * Math.Pow(x, 2) * Math.Log10(Math.Abs(8 - Math.Sin(u)));
//    }

//    static void Main()
//    {
//        double start = -5;
//        double end = 5;
//        double step = 0.5;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

//6.9 16
//using System;

//class Program
//{
//    static double Factorial(int k)
//    {
//        double result = 1;
//        for (int i = 1; i <= k; i++)
//            result *= i;
//        return result;
//    }

//    static double Function(double x)
//    {
//        if (x > 0)
//        {
//            double sum = 0;
//            for (int k = 1; k <= 5; k++)
//                sum += Math.Pow(x, k) / Factorial(k);
//            return sum;
//        }
//        else
//            return Math.PI / (3.5 * x);
//    }

//    static void Main()
//    {
//        double start = -3;
//        double end = 2;
//        double step = 0.25;

//        for (double x = start; x <= end; x += step)
//        {
//            double y = Function(x);
//            Console.WriteLine($"x = {x:F2}, f(x) = {y:F4}");
//        }
//    }
//}

