//9
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите значение k: ");
//        int k = int.Parse(Console.ReadLine());

//        double w = 0;
//        for (int i = 1; i <= k; i++)
//            w += Math.Pow(-1, i) * (i - 3) * (i - 3) / Factorial(i);

//        Console.WriteLine("W: " + w);
//    }

//    static double Factorial(int n)
//    {
//        double result = 1;
//        for (int i = 2; i <= n; i++)
//            result *= i;
//        return n > 1 ? result : 1;
//    }
//}

//10
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите n: ");
//        int n = int.Parse(Console.ReadLine());

//        double q = 0.0;
//        for (int k = 1; k <= n; k++)
//        {
//            double numerator = Math.Pow(-1, k) * (k - 7);
//            double denominator = Factorial(k + n);
//            q += numerator / denominator;
//        }

//        Console.WriteLine($"Q = {q}");
//    }

//    static double Factorial(int x)
//    {
//        if (x == 0) return 1;
//        double result = 1;
//        for (int i = 1; i <= x; i++)
//        {
//            result *= i;
//        }
//        return result;
//    }
//}
////11
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        double Q = 0;
//        for (int k = 1; k <= n; k++) Q += k == 3 ? 0 : Math.Pow(k - 3, k - 5) * (k + 7) / Factorial(k);
//        Console.WriteLine($"Q = {Q}");
//    }

//    static double Factorial(int k)
//    {
//        double r = 1; for (int i = 1; i <= k; i++) r *= i; return r;
//    }
//}

//12
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double sum = 0;
//        for (int i = 2; i <= k; i++)
//        {
//            double product = 1;
//            for (int n = 1; n <= i + 3; n++)
//            {
//                product *= (Math.Pow(n, 3) - 8) / (n + 2.0);
//            }
//            sum += Math.Pow(-1, i) * product / (i - 3.0);
//        }
//        Console.WriteLine($"W = {sum}");
//    }
//}

//13
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        double sum = 0;
//        for (int k = 1; k <= n; k++)
//        {
//            int fact = 1;
//            for (int i = 1; i <= k; i++) fact *= i;
//            sum += (k - 3) * Math.Pow(k, 2) * (k + 7) / (double)fact;
//        }
//        Console.WriteLine($"Q = {sum}");
//    }
//}

//14
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        double sum = 0;
//        for (int k = 3; k <= n; k++)
//        {
//            double product = 1;
//            for (int i = 1; i <= k - 7; i++)
//            {
//                if (i == 7) continue;
//                product *= (Math.Pow(i, 3) - 27) / (i - 7.0);
//            }
//            sum += Math.Pow(-2, k + 1) * product / ((k - 5.0) * Math.Pow(k, 3));
//        }
//        Console.WriteLine($"S = {sum}");
//    }
//}

//15
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double sum = 0;
//        for (int n = 2; n <= k; n++)
//        {
//            int fact = 1;
//            for (int i = 1; i <= 3 * n; i++) fact *= i;
//            sum += Math.Pow(-1, 2 * n) * Math.Pow(n * n - 9, 2) / (double)fact;
//        }
//        Console.WriteLine($"Y = {sum}");
//    }
//}

//24
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int j = 3; j <= k; j++)
//        {
//            double sum = 0;
//            for (int i = 1; i <= 5; i++)
//            {
//                if (i == 11) continue;
//                sum += (i + 5.0) / (i - 11.0);
//            }
//            product *= (j + 2) * Math.Pow(j, 2) * sum / Math.Sqrt(j + 3);
//        }
//        Console.WriteLine($"Z = {product}");
//    }
//}

//25
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        double sum = 0;
//        for (int k = 2; k <= n; k++)
//        {
//            double product = 1;
//            for (int m = 1; m <= k + 3; m++)
//            {
//                if (m == 3) continue;
//                product *= (Math.Pow(m, 3) - 8) / (m - 3.0);
//            }
//            sum += Math.Pow(-3, k + 1) * product / (Math.Pow(k, 2) - 2.0);
//        }
//        Console.WriteLine($"S = {sum}");
//    }
//}

//26
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int j = 3; j <= k; j++)
//        {
//            double sum = 0;
//            for (int i = 1; i <= 5; i++)
//            {
//                if (i == 11) continue;
//                sum += Math.Sqrt(i + 5.0) / (i - 11.0);
//            }
//            product *= (j - 6) * j * sum / Math.Sqrt(j + 3);
//        }
//        Console.WriteLine($"P = {product}");
//    }
//}

//27
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int j = 4; j <= k; j++)
//        {
//            double sum = 0;
//            for (int i = 1; i <= 5; i++)
//            {
//                if (i == 11) continue;
//                sum += Math.Sqrt(i + 5.0) / (i - 11.0);
//            }
//            product *= (j + 2) * Math.Pow(j, 2) * sum / Math.Sqrt(j + 5);
//        }
//        Console.WriteLine($"Z = {product}");
//    }
//}

//28
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        Console.Write("введите p: ");
//        double p = double.Parse(Console.ReadLine());
//        double product = 1;
//        for (int n = 3; n <= k; n++)
//        {
//            int fact = 1;
//            for (int i = 1; i <= n + 3; i++) fact *= i;
//            product *= (n + 2) * Math.Pow(p, n - 9) / (double)fact;
//        }
//        Console.WriteLine($"Z = {product}");
//    }
//}

//29
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int j = 2; j <= k; j++)
//        {
//            product *= (j - 6.0) * j / ((j - 3.0) * Math.Pow(j, 3) - 1);
//        }
//        Console.WriteLine($"P = {product}");
//    }
//}

//30
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int j = 4; j <= k; j++)
//        {
//            product *= (j - 4.0) * Math.Pow(j, 4) / Math.Sqrt(j + 5);
//        }
//        Console.WriteLine($"A = {product}");
//    }
//}
