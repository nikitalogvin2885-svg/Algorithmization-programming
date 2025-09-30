////1
//using System;
//using System.Numerics;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число a: ");
//            double a = double.Parse(Console.ReadLine());

//            Console.Write("введите степень n: ");
//            int n = int.Parse(Console.ReadLine());

//            double result = Math.Pow(a, n);

//            Console.WriteLine($"результат: {result}");
//            Console.ReadKey();
//        }
//    }
//}

//2
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите целое число n: ");
//            int n = int.Parse(Console.ReadLine());

//            long factorial = 1;

//            for (int i = 1; i <= n; i++)
//            {
//                factorial *= i;
//            }

//            Console.WriteLine($"факториал: {factorial}");
//            Console.ReadKey();
//        }
//    }
//}

//3
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число n: ");
//            int n = int.Parse(Console.ReadLine());

//            int sum = 0;

//            for (int i = 1; i <= n; i++)
//            {
//                sum += i * i;
//            }

//            Console.WriteLine($"сумма квадратов {sum}");
//            Console.ReadKey();
//        }
//    }
//}

//4
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число n: ");
//            int n = int.Parse(Console.ReadLine());

//            int sum = 0;

//            for (int i = 1; i <= n; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    sum += i * i;
//                }
//                else
//                {
//                    sum += i * i * i;
//                }
//            }

//            Console.WriteLine($"сумма квадратов чётных и кубов нечётных чисел от 1 до {n} равна {sum}");
//            Console.ReadKey();
//        }
//    }
//}

//5
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число n: ");
//            int n = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= n; i++)
//            {
//                if (i % 5 != 0 && i % 3 == 0)
//                {
//                    int sumDigits = 0;
//                    int temp = i;
//                    while (temp > 0)
//                    {
//                        sumDigits += temp % 10;
//                        temp /= 10;
//                    }

//                    if (sumDigits % 5 != 0 && sumDigits % 3 == 0)
//                    {
//                        Console.WriteLine(i);
//                    }
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}

//6
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число n: ");
//            int n = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= n; i++)
//            {
//                if (i % 5 == 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}

//7
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите натуральное число: ");
//            int n = int.Parse(Console.ReadLine());

//            bool isPowerOfTwo = (n & (n - 1)) == 0 && n > 0;

//            if (isPowerOfTwo)
//            {
//                Console.WriteLine("число явл степенью двойки");
//            }
//            else
//            {
//                Console.WriteLine("число не явл степенью двойки");
//            }

//            Console.ReadKey();
//        }
//    }
//}

//8
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число: ");
//            int n = int.Parse(Console.ReadLine());

//            Console.Write($"простые множители числа {n}: ");

//            for (int i = 2; i <= n; i++)
//            {
//                while (n % i == 0)
//                {
//                    Console.Write($"{i} ");
//                    n /= i;
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}

//9
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число x: ");
//            int x = int.Parse(Console.ReadLine());

//            Console.WriteLine($"совершенные числа в интервале от 2 до {x}: ");

//            for (int i = 2; i <= x; i++)
//            {
//                int sum = 0;
//                for (int j = 1; j < i; j++)
//                {
//                    if (i % j == 0)
//                    {
//                        sum += j;
//                    }
//                }

//                if (sum == i)
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}

//10
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число m: ");
//            int m = int.Parse(Console.ReadLine());

//            Console.Write("введите число n: ");
//            int n = int.Parse(Console.ReadLine());

//            int sum = 0;

//            for (int i = m; i <= n; i++)
//            {
//                sum += i * i;
//            }

//            Console.WriteLine($"сумма квадратов чисел {sum}");
//            Console.ReadKey();
//        }
//    }
//}

//11
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число m: ");
//            int m = int.Parse(Console.ReadLine());

//            Console.Write("введите число n: ");
//            int n = int.Parse(Console.ReadLine());

//            int sum = 0;

//            for (int i = m; i <= n; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    sum += i * i;
//                }
//            }

//            Console.WriteLine($"сумма квадратов нечётных чисел {sum}");
//            Console.ReadKey();
//        }
//    }
//}

//12
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            long product = 1;
//            bool found = false;

//            for (int i = -80; i <= 80; i++)
//            {
//                if (i % 2 != 0 && i % 7 == 0)
//                {
//                    product *= i;
//                    found = true;
//                }
//            }

//            if (found)
//                Console.WriteLine($"произведение нечётных чисел, кратных 7: {product}");
//            else
//                Console.WriteLine("нет чисел, удовлетворяющих условию");

//            Console.ReadKey();
//        }
//    }
//}

//13
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;

//            for (int i = -10; i <= 10; i++)
//            {
//                if (i > 0 && i % 9 == 0)
//                {
//                    sum += i;
//                }
//            }

//            Console.WriteLine($"сумма положительных чисел, кратных 9: {sum}");
//            Console.ReadKey();
//        }
//    }
//}

//14
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите натуральное число n: ");
//            int n = int.Parse(Console.ReadLine());

//            int count = 0;

//            for (int i = 100; i <= 800; i++)
//            {
//                if (i > n)
//                {
//                    count++;
//                }
//            }

//            Console.WriteLine($"колво трёхзначных чисел больше {n}: {count}");
//            Console.ReadKey();
//        }
//    }
//}

//15
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static int GCD(int a, int b)
//        {
//            while (b != 0)
//            {
//                int temp = b;
//                b = a % b;
//                a = temp;
//            }
//            return a;
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("введите натуральное число n: ");
//            int n = int.Parse(Console.ReadLine());

//            Console.WriteLine($"числа, взаимно простые с {n}: ");

//            for (int i = 1; i < n; i++)
//            {
//                if (GCD(i, n) == 1)
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}

//16
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static int GCD(int a, int b)
//        {
//            while (b != 0)
//            {
//                int temp = b;
//                b = a % b;
//                a = temp;
//            }
//            return a;
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("введите число p: ");
//            int p = int.Parse(Console.ReadLine());

//            Console.Write("введите число q: ");
//            int q = int.Parse(Console.ReadLine());

//            Console.WriteLine($"делители числа {q}, взаимно простые с {p}: ");

//            for (int i = 1; i <= q; i++)
//            {
//                if (q % i == 0 && GCD(i, p) == 1)
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}

//17
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static bool IsPrime(int number)
//        {
//            if (number <= 1) return false;
//            if (number == 2) return true;
//            if (number % 2 == 0) return false;

//            for (int i = 3; i * i <= number; i += 2)
//            {
//                if (number % i == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }

//        static void Main(string[] args)
//        {
//            Console.Write("введите натуральное число n: ");
//            int n = int.Parse(Console.ReadLine());

//            Console.WriteLine($"простые делители числа {n}: ");

//            for (int i = 2; i <= n; i++)
//            {
//                if (n % i == 0 && IsPrime(i))
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}

//18
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static bool IsPrime(int number)
//        {
//            if (number <= 1) return false;
//            if (number == 2) return true;
//            if (number % 2 == 0) return false;

//            for (int i = 3; i * i <= number; i += 2)
//            {
//                if (number % i == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }

//        static void Main(string[] args)
//        {
//            int count = 0;
//            int number = 2;

//            Console.WriteLine("первые 100 простых чисел: ");

//            while (count < 100)
//            {
//                if (IsPrime(number))
//                {
//                    Console.WriteLine(number);
//                    count++;
//                }
//                number++;
//            }

//            Console.ReadKey();
//        }
//    }
//}

//19
//using System;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число m: ");
//            int m = int.Parse(Console.ReadLine());

//            Console.Write("Введите число n: ");
//            int n = int.Parse(Console.ReadLine());

//            long product = 1;

//            for (int i = m; i <= n; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    product *= i * i;
//                }
//            }

//            Console.WriteLine($"произведение квадратов чётных чисел от {m} до {n}: {product}");
//            Console.ReadKey();
//        }
//    }
//}

//20
//using System;
//using System.Numerics;

//namespace ConsoleApp8
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите натуральное число n: ");
//            int n = int.Parse(Console.ReadLine());

//            BigInteger product = 1;

//            for (int i = 1; i <= 2 * n; i++)
//            {
//                product *= i;
//            }

//            Console.WriteLine($"произведение чисел от 1 до 2n: {product}");
//            Console.ReadKey();
//        }
//    }
//}

//21
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите количество нечётных чисел N: ");
//            int N = int.Parse(Console.ReadLine());

//            int difference = 0;
//            int oddNumber = 1;

//            for (int i = 1; i <= N; i++)
//            {
//                difference -= oddNumber * oddNumber;
//                oddNumber += 2;
//            }

//            Console.WriteLine($"разность квадратов нечётных чисел: {difference}");
//            Console.ReadKey();
//        }
//    }
//}

//22
//using System;

//namespace ConsoleApp1
//{
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("введите число m: ");
//            int m = int.Parse(Console.ReadLine());

//            Console.Write("введите число n: ");
//            int n = int.Parse(Console.ReadLine());

//            long sumCubes = 0;

//            for (int i = m; i <= n; i++)
//            {
//                sumCubes += i * i * i;
//            }

//            long squareOfDifference = sumCubes * sumCubes;

//            Console.WriteLine($"квадрат разности кубов чисел: {squareOfDifference}");
//            Console.ReadKey();
//        }
//    }
//}
