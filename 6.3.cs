//1
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double sum = 0;

//        for (int i = -2; i <= k; i++)
//        {
//            if (i == 4) continue;
//            int fact = 1;
//            for (int j = 1; j <= i + 3; j++) fact *= j;
//            sum += Math.Pow(-1, i) * fact / (2 * (i - 4));
//        }
//        Console.WriteLine($"W = {sum}");
//    }
//}

//2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;

//        for (int t = 2; t <= k; t++)
//        {
//            double sum = 0;
//            for (int i = 1; i <= t; i++)
//            {
//                if (i == 6) continue;
//                sum += (i - 4) / (double)(i - 6);
//            }
//            product *= Math.Pow(t, x) * sum;
//        }
//        Console.WriteLine($"U = {product}");
//    }
//}

//3
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        Console.Write("введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        double sum = 0;

//        for (int k = 1; k <= n; k++)
//        {
//            if (k == 2) continue;

//            double numerator1 = Math.Pow(-3, 3 * k + 1);
//            double denominator1 = 2 * (k - 2) * Math.Pow(x, 3 * k + 1);

//            double product = 1;
//            for (int m = 1; m <= k + 2; m++)
//            {
//                if (m == 4) continue;
//                double term = (Math.Pow(m, 3) - 7) / (double)(m - 4);
//                product *= term;
//            }

//            sum += (numerator1 / denominator1) * product;
//        }
//        Console.WriteLine($"S = {sum}");
//    }
//}

//4
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
//            for (int i = 1; i <= n - k; i++) fact *= i;
//            sum += Math.Pow(-1, k) * (k - 7) / (2.0 * fact);
//        }
//        Console.WriteLine($"Q = {sum}");
//    }
//}

//5
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        double sum = 0;

//        for (int i = 1; i <= 9; i++)
//        {
//            if (i == 3) continue;
//            double prod = 1;
//            for (int n = i; n <= 17; n++)
//                if (n != 12) prod *= (n * n * n - 8) / (n - 12.0);
//            sum += Math.Pow(Math.Abs(7 - x), i) / Math.Pow(i - 3, 5) * prod;
//        }
//        Console.WriteLine($"W = {sum:F4}");
//    }
//}

//6
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double sum = 0;

//        for (int i = -2; i <= k; i++)
//        {
//            if (i == 4) continue;
//            int fact = 1;
//            for (int j = 1; j <= i + 3; j++) fact *= j;
//            sum += Math.Pow(-1, i) * fact / (i - 4.0);
//        }
//        Console.WriteLine($"W = {sum}");
//    }
//}

//7
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        Console.Write("введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        double sum = 0;

//        for (int k = 1; k <= n; k++)
//        {
//            int fact = 1;
//            for (int i = 1; i <= k; i++) fact *= i;
//            sum += Math.Pow(-1, k) * Math.Pow(x + 3, 2) / fact;
//        }
//        Console.WriteLine($"Q = {sum}");
//    }
//}

//8
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите значение k: ");
//        int k = Convert.ToInt32(Console.ReadLine());

//        double result = 1.0;

//        for (int j = -1; j <= k; j++)
//        {
//            if (j == 4 || j == 0 || j == 1) continue;
//            double productTerm = ((j - j * j) * k) / (j - 4.0);

//            double sum = 0.0;
//            int count = 0;
//            for (int i = j; i <= k + 2; i++)
//            {
//                if (i == 7) continue;
//                double term = Math.Sqrt(Math.Abs(i - 5)) / Math.Abs(i - 7.0);
//                sum += term;
//                count++;
//            }

//            if (count == 0) continue;
//            double totalTerm = productTerm * sum;
//            result *= totalTerm;
//        }

//        Console.WriteLine("Результат P: " + result);
//    }
//}

//9
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double sum = 0;
//        for (int i = 1; i <= k; i++)
//        {
//            if (i == 4) continue;
//            int fact = 1;
//            for (int j = 1; j <= i + 3; j++) fact *= j;
//            sum += Math.Pow(-1, i) * fact / (2.0 * (i - 4));
//        }
//        Console.WriteLine($"W = {sum}");
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
//        double sum = 0;
//        for (int k = 1; k <= n; k++)
//        {
//            int fact = 1;
//            for (int i = 1; i <= k; i++) fact *= i;
//            sum += Math.Pow(-1, k) * (Math.Pow(k, 3) - 8) / fact;
//        }
//        Console.WriteLine($"S = {sum}");
//    }
//}

//11
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int i = 1; i <= k; i++)
//        {
//            product *= (Math.Pow(i, 2) - 4) / (Math.Pow(i, 2) + 3 * i - 4.0);
//        }
//        Console.WriteLine($"Z = {product}");
//    }
//}

//12
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int i = 1; i <= k; i++)
//        {
//            product *= Math.Pow(x, i) / (Math.Pow(i, 2) + 2 * i - 3.0);
//        }
//        Console.WriteLine($"U = {product}");
//    }
//}

//13
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int j = 1; j <= k; j++)
//        {
//            product *= (Math.Pow(j, 2) - 1) / (Math.Pow(j, 2) + 4 * j + 3.0);
//        }
//        Console.WriteLine($"P = {product}");
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
//        for (int k = 1; k <= n; k++)
//        {
//            int fact = 1;
//            for (int i = 1; i <= k; i++) fact *= i;
//            sum += Math.Pow(-1, k) * (Math.Pow(k, 2) - 5) / fact;
//        }
//        Console.WriteLine($"Q = {sum}");
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
//        double product = 1;
//        for (int j = 1; j <= k; j++)
//        {
//            product *= (Math.Pow(j, 2) - 9) / (Math.Pow(j, 2) + 5 * j + 6.0);
//        }
//        Console.WriteLine($"A = {product}");
//    }
//}

//16
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double Z = 1.0;
//        for (int n = -3; n <= k; n++)
//            if (n != -2 && (n + 2) != 0)
//                Z *= (n + 2) * Math.Abs(n - 4) / Factorial(n + 3);
//        Console.WriteLine($"Z = {Z:F15}");
//    }

//    static double Factorial(int n)
//    {
//        if (n < 0) return 1;
//        double result = 1.0;
//        for (int i = 1; i <= n; i++)
//            result *= i;
//        return result;
//    }
//}

//17
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double sum = 0;
//        for (int i = -5; i <= k; i++)
//        {
//            double product = 1;
//            for (int n = 2; n <= i + 3; n++)
//            {
//                product *= (2 * Math.Pow(k, 3) - 8) / (n + 4.0);
//            }
//            sum += Math.Pow(-1, i) * product;
//        }
//        Console.WriteLine($"W = {sum}");
//    }
//}

//18
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int j = 1; j <= k; j++)
//        {
//            double innerProduct = 1;
//            for (int i = 5; i <= j + 2; i++)
//            {
//                if (i == 7) continue;
//                innerProduct *= Math.Sqrt(i - 5) / (i - 7.0);
//            }
//            product *= ((j - j * j) * k) / Math.Sqrt(j + 14) * innerProduct;
//        }
//        Console.WriteLine($"P = {product}");
//    }
//}

//19
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
//            for (int i = 1; i <= k + 2; i++) fact *= i;
//            sum += Math.Pow(-1, k) * (Math.Pow(k, 3) - 27) / (3.0 * fact);
//        }
//        Console.WriteLine($"S = {sum}");
//    }
//}

//20
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
//            double innerProduct = 1;
//            for (int i = 5; i <= j + 5; i++)
//            {
//                if (i == 11) continue;
//                innerProduct *= Math.Sqrt(i - 5) / (i - 11.0);
//            }
//            product *= j * (j + 2) * innerProduct;
//        }
//        Console.WriteLine($"Z = {product}");
//    }
//}

//21
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите x: ");
//        double x = double.Parse(Console.ReadLine());
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int i = 2; i <= k; i++)
//        {
//            double sum = 0;
//            for (int t = 1; t <= i - 3; t++)
//            {
//                if (i == 7) continue;
//                sum += (i - 2.0) / (i - 7.0);
//            }
//            product *= Math.Pow(x, i) * sum;
//        }
//        Console.WriteLine($"U = {product}");
//    }
//}

//22
//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        double product = 1;
//        for (int j = 1; j <= k; j++)
//        {
//            double innerProduct = 1;
//            for (int i = 3; i <= j - 1; i++)
//            {
//                if (i == 7) continue;
//                innerProduct *= (i - 3.0) / (i - 7.0);
//            }
//            product *= (j * j - 4) * j * innerProduct;
//        }
//        Console.WriteLine($"A = {product}");
//    }
//}

//23
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
//            int factK = 1;
//            for (int i = 1; i <= k; i++) factK *= i;
//            int factK4 = 1;
//            for (int i = 1; i <= k - 4; i++) factK4 *= i;
//            sum += factK4 * (k + 7) / (double)factK;
//        }
//        Console.WriteLine($"S = {sum}");
//    }
//}
