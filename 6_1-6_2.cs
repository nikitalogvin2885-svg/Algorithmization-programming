
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.Write("Введите A: ");
            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Введите B (B > A): ");
            //int B = int.Parse(Console.ReadLine());

            //int N = 0;
            //Console.WriteLine("Целые числа между A и B (включая сами числа):");
            //for (int i = A; i <= B; i++)
            //{
            //    Console.Write(i + " ");
            //    N++;
            //}
            //Console.WriteLine($"\nКоличество чисел N: {N}");

            //2
            //Console.Write("Введите A: ");
            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Введите B (B > A): ");
            //int B = int.Parse(Console.ReadLine());

            //int N = 0;
            //Console.WriteLine("Целые числа между A и B (не включая сами числа) в порядке убывания:");
            //for (int i = B - 1; i > A; i--)
            //{
            //    Console.Write(i + " ");
            //    N++;
            //}
            //Console.WriteLine($"\nКоличество чисел N: {N}");

            //3
            //Console.Write("Введите вещественное число A: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double result = 1;
            //for (int i = 0; i < N; i++)
            //{
            //    result *= A;
            //}
            //Console.WriteLine($"{A} в степени {N} равно: {result}");

            //4
            //Console.Write("Введите вещественное число A: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Целые степени числа {A} от 1 до {N}:");
            //for (int i = 1; i <= N; i++)
            //{
            //    double result = Math.Pow(A, i);
            //    Console.WriteLine($"{A}^{i} = {result}");
            //}

            //5
            //Console.Write("Введите вещественное число A: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double sum = 0;
            //for (int i = 0; i <= N; i++)
            //{
            //    sum += Math.Pow(A, i);
            //}
            //Console.WriteLine($"Сумма: {sum}");

            //6
            //Console.Write("Введите N: ");
            //int N = int.Parse(Console.ReadLine());

            //Console.Write("Введите M (> 1): ");
            //int M = int.Parse(Console.ReadLine());

            //int K = 1;
            //while (3 * K <= N)
            //{
            //    K++;
            //}
            //Console.WriteLine($"Наименьшее целое K: {K}");
            //Console.WriteLine($"Значение 3K: {3 * K}");

            //7
            //Console.Write("Введите N: ");
            //int N = int.Parse(Console.ReadLine());

            //Console.Write("Введите M (> 1): ");
            //int M = int.Parse(Console.ReadLine());

            //int K = 1;
            //while (3 * (K + 1) < N)
            //{
            //    K++;
            //}
            //Console.WriteLine($"Наибольшее целое K: {K}");
            //Console.WriteLine($"Значение 3K: {3 * K}");

            //8
            //Console.Write("Введите вещественное число A (> 1): ");
            //double A = double.Parse(Console.ReadLine());

            //double sum = 0;
            //int N = 0;
            //while (sum <= A)
            //{
            //    N++;
            //    sum += 1.0 / N;
            //}
            //Console.WriteLine($"Наименьшее целое N: {N}");
            //Console.WriteLine($"Сумма: {sum}");


            //9
            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double product = 1;
            //for (int i = 1; i <= N; i++)
            //{
            //    product *= i;
            //}
            //Console.WriteLine($"Произведение: {product}");

            //10
            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double product = 1;
            //for (int i = 2; i <= N; i++)
            //{
            //    product *= i * (1.0 / i);
            //}
            //Console.WriteLine($"Произведение: {product}");

            //11
            //Console.Write("Введите вещественное число X: ");
            //double X = double.Parse(Console.ReadLine());

            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double sum = 1;
            //double term = 1;
            //for (int i = 1; i <= N; i++)
            //{
            //    term *= X / i;
            //    sum += term;
            //}
            //Console.WriteLine($"Значение: {sum}");

            //12
            //Console.Write("Введите вещественное число X: ");
            //double X = double.Parse(Console.ReadLine());

            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double sum = X;
            //double term = X;
            //for (int i = 1; i <= N; i++)
            //{
            //    term *= -X * X / ((2 * i) * (2 * i + 1));
            //    sum += term;
            //}
            //Console.WriteLine($"Значение: {sum}");

            //13
            //Console.Write("Введите вещественное число X: ");
            //double X = double.Parse(Console.ReadLine());

            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double sum = 1;
            //double term = 1;
            //for (int i = 1; i <= N; i++)
            //{
            //    term *= -X * X / ((2 * i - 1) * (2 * i));
            //    sum += term;
            //}
            //Console.WriteLine($"Значение: {sum}");

            //14
            //Console.Write("Введите вещественное число X (|X| < 1): ");
            //double X = double.Parse(Console.ReadLine());

            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double sum = 0;
            //for (int k = 1; k <= N; k++)
            //{
            //    double term = Math.Pow(-1, k + 1) * Math.Pow(X, k) / k;
            //    sum += term;
            //}
            //Console.WriteLine($"Приближённое значение ln(1+X): {sum}");

            //15
            //Console.Write("Введите вещественное число X (|X| < 1): ");
            //double X = double.Parse(Console.ReadLine());

            //Console.Write("Введите целое число N (> 0): ");
            //int N = int.Parse(Console.ReadLine());

            //double sum = 0;
            //for (int k = 0; k <= N; k++)
            //{
            //    double term = Math.Pow(-1, k) * Math.Pow(X, 2 * k + 1) / (2 * k + 1);
            //    sum += term;
            //}
            //Console.WriteLine($"Приближённое значение arctan(X): {sum}");

            //16
            //Console.Write("Введите целое число N (> 2): ");
            //int N = int.Parse(Console.ReadLine());

            //Console.Write("Введите начало отрезка A: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("Введите конец отрезка B (B > A): ");
            //double B = double.Parse(Console.ReadLine());

            //double H = (B - A) / N;
            //Console.WriteLine($"Значение H: {H}");

            //Console.WriteLine("Набор точек, образующих разбиение отрезка (A, B):");
            //for (int i = 0; i <= N; i++)
            //{
            //    double point = A + i * H;
            //    Console.WriteLine(point);
            //}

            //17
            //Console.Write("Введите целое число N (> 2): ");
            //int N = int.Parse(Console.ReadLine());

            //Console.Write("Введите начало отрезка A: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("Введите конец отрезка B (B > A): ");
            //double B = double.Parse(Console.ReadLine());

            //double H = (B - A) / (N - 1);
            //Console.WriteLine("Значения функции F(X) = 1 - sin(X) в равноотстоящих точках:");

            //for (int i = 0; i < N; i++)
            //{
            //    double X = A + i * H;
            //    double FX = 1 - Math.Sin(X);
            //    Console.WriteLine($"F({X}) = {FX}");
            //}

            //18
            //Console.Write("Введите число D (> 0): ");
            //double D = double.Parse(Console.ReadLine());

            //double A_prev = 2;
            //double A_current = 2 + 1 / A_prev;
            //int K = 2;

            //while (Math.Abs(A_current - A_prev) >= D)
            //{
            //    A_prev = A_current;
            //    A_current = 2 + 1 / A_prev;
            //    K++;
            //}

            //Console.WriteLine($"Номер K: {K}");
            //Console.WriteLine($"A_{K - 1}: {A_prev}");
            //Console.WriteLine($"A_{K}: {A_current}");

            //19
            //Console.Write("Введите число D (> 0): ");
            //double D = double.Parse(Console.ReadLine());

            //double A_prev_prev = 1;
            //double A_prev = 2;
            //double A_current = (A_prev_prev + A_prev) / 2;
            //int K = 3;

            //while (Math.Abs(A_current - A_prev) >= D)
            //{
            //    A_prev_prev = A_prev;
            //    A_prev = A_current;
            //    A_current = (A_prev_prev + A_prev) / 2;
            //    K++;
            //}

            //Console.WriteLine($"Номер K: {K}");
            //Console.WriteLine($"A_{K - 1}: {A_prev}");
            //Console.WriteLine($"A_{K}: {A_current}");

            //20
            //Console.Write("Введите натуральное число N (N > 10): ");
            //int N = int.Parse(Console.ReadLine());

            //Console.WriteLine("Нечетные кратные пяти числа от 10 до N:");
            //for (int i = 15; i <= N; i += 10)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //21
            //Console.WriteLine("Квадраты чисел от 11 до 99:");
            //for (int i = 11; i <= 99; i++)
            //{
            //    Console.WriteLine($"{i}^2 = {i * i}");
            //}

            //23
            //Console.Write("Введите натуральное число n: ");
            //int n = int.Parse(Console.ReadLine());

            //int factorial = 1;
            //int powerOfTwo = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    factorial *= i;
            //    powerOfTwo *= 2;
            //}

            //Console.WriteLine($"{n}! = {factorial}");
            //Console.WriteLine($"2^{n} = {powerOfTwo}");

            //24
            //Console.Write("Введите натуральное число N (N > 10): ");
            //int N = int.Parse(Console.ReadLine());

            //int maxDigit = 0;

            //for (int number = 10; number <= N; number++)
            //{
            //    int currentNumber = number;
            //    while (currentNumber > 0)
            //    {
            //        int digit = currentNumber % 10;
            //        if (digit > maxDigit)
            //        {
            //            maxDigit = digit;
            //        }
            //        currentNumber /= 10;
            //    }
            //}

            //Console.WriteLine($"Наибольшая цифра: {maxDigit}");

            //25
            //Console.Write("Введите натуральное число N (N > 10): ");
            //int N = int.Parse(Console.ReadLine());

            //for (int number = 10; number <= N; number++)
            //{
            //    int currentNumber = number;
            //    int firstDigit = currentNumber;
            //    while (firstDigit >= 10)
            //    {
            //        firstDigit /= 10;
            //    }

            //    int sumDigits = 0;
            //    currentNumber = number;
            //    while (currentNumber > 0)
            //    {
            //        sumDigits += currentNumber % 10;
            //        currentNumber /= 10;
            //    }

            //    Console.WriteLine($"Число: {number}, первая цифра: {firstDigit}, сумма цифр: {sumDigits}");
            //}

            //26
            //Console.Write("Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());

            //int originalNumber = number;
            //int reversedNumber = 0;

            //while (number > 0)
            //{
            //    reversedNumber = reversedNumber * 10 + number % 10;
            //    number /= 10;
            //}

            //if (originalNumber == reversedNumber)
            //{
            //    Console.WriteLine("Число является симметричным.");
            //}
            //else
            //{
            //    Console.WriteLine("Число не является симметричным.");
            //}

            //27
            //int sumOfSquares = 0;

            //for (int i = 12; i <= 80; i++)
            //{
            //    sumOfSquares += i * i;
            //    Console.WriteLine($"{i}^2 = {i * i}");
            //}

            //Console.WriteLine($"Сумма квадратов: {sumOfSquares}");

            //28
            //Console.Write("Введите число от 22 до 88: ");
            //int number = int.Parse(Console.ReadLine());

            //int differenceOfSquares = number * number - (number - 1) * (number - 1);

            //Console.WriteLine($"Разность квадратов {number}^2 - {(number - 1)}^2 = {differenceOfSquares}");

            //29
            //Console.Write("Введите вещественное число A: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("Введите натуральное число N (N > 0): ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    double difference = A * A - i * i;
            //    Console.WriteLine($"Разность квадратов A^2 - {i}^2 = {difference}");
            //}

            //30
            //Console.Write("Введите натуральное число N (N > 10): ");
            //int N = int.Parse(Console.ReadLine());

            //int minDigit = 9;

            //for (int number = 10; number <= N; number++)
            //{
            //    int currentNumber = number;
            //    while (currentNumber > 0)
            //    {
            //        int digit = currentNumber % 10;
            //        if (digit < minDigit)
            //        {
            //            minDigit = digit;
            //        }
            //        currentNumber /= 10;
            //    }
            //}

            //Console.WriteLine($"Наименьшая цифра: {minDigit}");

            Console.ReadKey();
        }
    }
}