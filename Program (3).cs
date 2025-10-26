//Одномерные
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 1: Подсчет четных элементов в массиве из 14 элементов");

//        int[] array = new int[14];

//        Console.WriteLine("Введите 14 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int evenCount = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 == 0)
//            {
//                evenCount++;
//            }
//        }

//        Console.WriteLine($"Количество четных элементов: {evenCount}");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 2: Замена пятого элемента на среднее арифметическое");

//        int[] array = new int[12];

//        Console.WriteLine("Введите 12 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        double average = array.Average();

//        int[] newArray = new int[12];
//        Array.Copy(array, newArray, array.Length);

//        newArray[4] = (int)Math.Round(average);

//        Console.WriteLine("\nИсходный массив: [" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Среднее арифметическое: {average:F2}");
//        Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3: Подсчет элементов с |значением| > среднего арифметического");

//        int[] array = new int[11];

//        Console.WriteLine("Введите 11 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        double average = array.Average();

//        int count = 0;
//        Console.WriteLine("\nЭлементы, |значение| которых больше среднего:");

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (Math.Abs(array[i]) > average)
//            {
//                Console.WriteLine($"array[{i}] = {array[i]}, |{array[i]}| = {Math.Abs(array[i])}");
//                count++;
//            }
//        }

//        Console.WriteLine($"\nСреднее арифметическое: {average:F2}");
//        Console.WriteLine($"Количество элементов: {count}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 4: Обмен максимального и первого элементов");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("\nИсходный массив: [" + string.Join(", ", array) + "]");

//        int maxIndex = 0;
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > array[maxIndex])
//            {
//                maxIndex = i;
//            }
//        }

//        Console.WriteLine($"Максимальный элемент: {array[maxIndex]} (индекс {maxIndex})");
//        Console.WriteLine($"Первый элемент: {array[0]} (индекс 0)");

//        if (maxIndex != 0)
//        {
//            int temp = array[0];
//            array[0] = array[maxIndex];
//            array[maxIndex] = temp;

//            Console.WriteLine("\nПосле обмена: [" + string.Join(", ", array) + "]");
//        }
//        else
//        {
//            Console.WriteLine("\nМаксимальный элемент уже находится на первой позиции.");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5: Обмен максимального и минимального элементов");

//        int[] array = new int[9];

//        Console.WriteLine("Введите 9 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("\nИсходный массив: [" + string.Join(", ", array) + "]");

//        int maxIndex = 0, minIndex = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > array[maxIndex])
//                maxIndex = i;
//            if (array[i] < array[minIndex])
//                minIndex = i;
//        }

//        Console.WriteLine($"Максимальный элемент: {array[maxIndex]} (индекс {maxIndex})");
//        Console.WriteLine($"Минимальный элемент: {array[minIndex]} (индекс {minIndex})");

//        if (maxIndex != minIndex)
//        {
//            int temp = array[maxIndex];
//            array[maxIndex] = array[minIndex];
//            array[minIndex] = temp;

//            Console.WriteLine("\nПосле обмена: [" + string.Join(", ", array) + "]");
//        }
//        else
//        {
//            Console.WriteLine("\nВсе элементы массива одинаковы.");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6: Определение количества четных и нечетных элементов");

//        int[] array = new int[20];

//        Console.WriteLine("Введите 20 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int evenCount = 0, oddCount = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 == 0)
//            {
//                evenCount++;
//            }
//            else
//            {
//                oddCount++;
//            }
//        }

//        Console.WriteLine($"Количество четных элементов: {evenCount}");
//        Console.WriteLine($"Количество нечетных элементов: {oddCount}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7: Определение количества элементов, значения которых больше первого элемента");

//        double[] array = new double[15];

//        Console.WriteLine("Введите 15 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        double firstElement = array[0];
//        int count = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > firstElement)
//            {
//                count++;
//            }
//        }

//        Console.WriteLine($"Количество элементов, значения которых больше первого элемента: {count}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8: Определение индексов максимального и минимального элементов");

//        double[] array = new double[16];

//        Console.WriteLine("Введите 16 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int maxIndex = 0, minIndex = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > array[maxIndex])
//                maxIndex = i;
//            if (array[i] < array[minIndex])
//                minIndex = i;
//        }

//        Console.WriteLine($"Индекс максимального элемента: {maxIndex}");
//        Console.WriteLine($"Индекс минимального элемента: {minIndex}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9: Получение нового массива между элементами исходного массива");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[array.Length - 1];
//        for (int i = 0; i < newArray.Length; i++)
//        {
//            newArray[i] = (array[i] + array[i + 1]) / 2;
//        }

//        Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10: Сумма элементов с абсолютным значением больше среднего арифметического модулей отрицательных элементов");

//        int[] array = new int[17];

//        Console.WriteLine("Введите 17 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        double negativeAverage = array.Where(x => x < 0).Select(x => Math.Abs(x)).Average();
//        int sum = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (Math.Abs(array[i]) > negativeAverage)
//            {
//                sum += array[i];
//            }
//        }

//        Console.WriteLine($"Сумма элементов с |значением| > среднего арифметического модулей отрицательных элементов: {sum}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11: Количество и сумма четных по значению положительных элементов");

//        int[] array = new int[14];

//        Console.WriteLine("Введите 14 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int count = 0, sum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > 0 && array[i] % 2 == 0)
//            {
//                count++;
//                sum += array[i];
//            }
//        }

//        Console.WriteLine($"Количество четных положительных элементов: {count}");
//        Console.WriteLine($"Сумма четных положительных элементов: {sum}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12: Сумма максимального и минимального элементов");

//        double[] array = new double[12];

//        Console.WriteLine("Введите 12 вещественных чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        double max = array[0], min = array[0];

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > max)
//                max = array[i];
//            if (array[i] < min)
//                min = array[i];
//        }

//        double sum = max + min;
//        Console.WriteLine($"Сумма максимального и минимального элементов: {sum}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13: Сумма и разность максимального и минимального элементов");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int max = array[0], min = array[0];

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > max)
//                max = array[i];
//            if (array[i] < min)
//                min = array[i];
//        }

//        int sum = max + min;
//        int difference = max - min;

//        Console.WriteLine($"Сумма максимального и минимального элементов: {sum}");
//        Console.WriteLine($"Разность максимального и минимального элементов: {difference}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 14: Замена элементов, кратных трем, на сумму нечетных по значению элементов");

//        int[] array = new int[17];

//        Console.WriteLine("Введите 17 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int oddSum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 != 0)
//            {
//                oddSum += array[i];
//            }
//        }

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 3 == 0)
//            {
//                array[i] = oddSum;
//            }
//        }

//        Console.WriteLine("Массив после замены: [" + string.Join(", ", array) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 15: Расположение элементов с 1 по 7 по возрастанию, с 8 по 14 — по убыванию");

//        double[] array = new double[14];

//        Console.WriteLine("Введите 14 элементов:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = i + 1; j < 7; j++)
//            {
//                if (array[i] > array[j])
//                {
//                    double temp = array[i];
//                    array[i] = array[j];
//                    array[j] = temp;
//                }
//            }
//        }

//        for (int i = 7; i < 14; i++)
//        {
//            for (int j = i + 1; j < 14; j++)
//            {
//                if (array[i] < array[j])
//                {
//                    double temp = array[i];
//                    array[i] = array[j];
//                    array[j] = temp;
//                }
//            }
//        }

//        Console.WriteLine("Массив после сортировки: [" + string.Join(", ", array) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 16: Количество чисел между максимальным и минимальным элементами");

//        double[] array = new double[12];

//        Console.WriteLine("Введите 12 элементов:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int maxIndex = 0, minIndex = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > array[maxIndex])
//                maxIndex = i;
//            if (array[i] < array[minIndex])
//                minIndex = i;
//        }

//        int start = Math.Min(maxIndex, minIndex);
//        int end = Math.Max(maxIndex, minIndex);

//        int count = end - start - 1;

//        Console.WriteLine($"Количество чисел между максимальным и минимальным элементами: {count}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 17: Количество отрицательных, произведение положительных и количество нулевых элементов");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int negativeCount = 0;
//        int positiveProduct = 1;
//        int zeroCount = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < 0)
//            {
//                negativeCount++;
//            }
//            else if (array[i] > 0)
//            {
//                positiveProduct *= array[i];
//            }
//            else
//            {
//                zeroCount++;
//            }
//        }

//        Console.WriteLine($"Количество отрицательных элементов: {negativeCount}");
//        Console.WriteLine($"Произведение положительных элементов: {positiveProduct}");
//        Console.WriteLine($"Количество нулевых элементов: {zeroCount}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 18: Определение границ интервала значений элементов массива");

//        double[] array = new double[12];

//        Console.WriteLine("Введите 12 элементов:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        double min = array[0], max = array[0];

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < min)
//                min = array[i];
//            if (array[i] > max)
//                max = array[i];
//        }

//        Console.WriteLine($"Границы интервала: от {min} до {max}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 19: Сумма элементов до первого отрицательного элемента");

//        int[] array = new int[19];

//        Console.WriteLine("Введите 19 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int sum = 0;
//        bool negativeFound = false;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] < 0)
//            {
//                negativeFound = true;
//                break;
//            }
//            sum += array[i];
//        }

//        if (negativeFound)
//        {
//            Console.WriteLine($"Сумма элементов до первого отрицательного элемента: {sum}");
//        }
//        else
//        {
//            Console.WriteLine("Отрицательных элементов в массиве нет.");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 20: Замена элементов, кратных трем, нулями");

//        int[] array = new int[16];

//        Console.WriteLine("Введите 16 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int replacementCount = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 3 == 0)
//            {
//                array[i] = 0;
//                replacementCount++;
//            }
//        }

//        Console.WriteLine("Массив после замены: [" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Количество замен: {replacementCount}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 21: Увеличение минимального элемента в три раза и замена с последним элементом");

//        double[] array = new double[12];

//        Console.WriteLine("Введите 12 элементов:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int minIndex = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < array[minIndex])
//                minIndex = i;
//        }

//        array[minIndex] *= 3;

//        double temp = array[minIndex];
//        array[minIndex] = array[array.Length - 1];
//        array[array.Length - 1] = temp;

//        Console.WriteLine("Массив после изменений: [" + string.Join(", ", array) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 22: Расположение элементов в обратном порядке");

//        double[] array = new double[15];

//        Console.WriteLine("Введите 15 элементов:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        Array.Reverse(array);

//        Console.WriteLine("Массив в обратном порядке: [" + string.Join(", ", array) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 23: Сумма четных по индексу и произведение нечетных по значению элементов");

//        int[] array = new int[14];

//        Console.WriteLine("Введите 14 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int evenIndexSum = 0;
//        int oddValueProduct = 1;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (i % 2 == 0)
//            {
//                evenIndexSum += array[i];
//            }
//            if (array[i] % 2 != 0)
//            {
//                oddValueProduct *= array[i];
//            }
//        }

//        Console.WriteLine($"Сумма четных по индексу элементов: {evenIndexSum}");
//        Console.WriteLine($"Произведение нечетных по значению элементов: {oddValueProduct}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 24: Количество и сумма чисел, значения которых меньше значения последнего элемента");

//        double[] array = new double[12];

//        Console.WriteLine("Введите 12 элементов:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        double lastElement = array[array.Length - 1];
//        int count = 0;
//        double sum = 0;

//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            if (array[i] < lastElement)
//            {
//                count++;
//                sum += array[i];
//            }
//        }

//        Console.WriteLine($"Количество чисел, значения которых меньше значения последнего элемента: {count}");
//        Console.WriteLine($"Сумма таких чисел: {sum}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 25: Новый массив, элементы которого определяются как разность между элементами исходного массива и суммой положительных элементов");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int positiveSum = 0;
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > 0)
//            {
//                positiveSum += array[i];
//            }
//        }

//        int[] newArray = new int[array.Length];
//        for (int i = 0; i < array.Length; i++)
//        {
//            newArray[i] = array[i] - positiveSum;
//        }

//        Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 26: Разность между произведением всех положительных элементов и произведением модулей всех отрицательных элементов");

//        double[] array = new double[15];

//        Console.WriteLine("Введите 15 элементов:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        double positiveProduct = 1;
//        double negativeProduct = 1;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > 0)
//            {
//                positiveProduct *= array[i];
//            }
//            else if (array[i] < 0)
//            {
//                negativeProduct *= Math.Abs(array[i]);
//            }
//        }

//        double difference = positiveProduct - negativeProduct;

//        Console.WriteLine($"Разность между произведением положительных и модулей отрицательных элементов: {difference}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 27: Определение максимального числа и замена им всех четных по значению элементов");

//        int[] array = new int[19];

//        Console.WriteLine("Введите 19 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int max = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > max)
//            {
//                max = array[i];
//            }
//        }

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] % 2 == 0)
//            {
//                array[i] = max;
//            }
//        }

//        Console.WriteLine("Массив после замены: [" + string.Join(", ", array) + "]");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 28: Сумма и количество элементов, абсолютное значение которых больше среднеарифметического положительных элементов");

//        int[] array = new int[17];

//        Console.WriteLine("Введите 17 целых чисел:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        double positiveAverage = array.Where(x => x > 0).Average();

//        int sum = 0;
//        int count = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (Math.Abs(array[i]) > positiveAverage)
//            {
//                sum += array[i];
//                count++;
//            }
//        }

//        Console.WriteLine($"Сумма элементов: {sum}");
//        Console.WriteLine($"Количество элементов: {count}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 29: Частное от деления произведения всех положительных элементов и суммы модулей всех отрицательных");

//        double[] array = new double[18];

//        Console.WriteLine("Введите 18 элементов:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        double positiveProduct = 1;
//        double negativeSum = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] > 0)
//            {
//                positiveProduct *= array[i];
//            }
//            else if (array[i] < 0)
//            {
//                negativeSum += Math.Abs(array[i]);
//            }
//        }

//        double quotient = positiveProduct / negativeSum;

//        Console.WriteLine($"Частное от деления: {quotient}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 1: Формирование нового массива из двух массивов");

//        int[] array1 = new int[10];
//        int[] array2 = new int[10];
//        int[] newArray = new int[10];

//        Console.WriteLine("Введите элементы первого массива:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите элементы второго массива:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = int.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < 10; i++)
//        {
//            if (i % 2 == 0)
//            {
//                newArray[i] = array2[i + 1];
//            }
//            else
//            {
//                newArray[i] = array1[i - 1];
//            }
//        }

//        Console.WriteLine("Новый массив:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 2: Массив из цифр младших разрядов");

//        int[] array = new int[8];

//        Console.WriteLine("Введите 8 двузначных чисел:");
//        for (int i = 0; i < 8; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[8];

//        for (int i = 0; i < 8; i++)
//        {
//            newArray[i] = array[i] % 10;
//        }

//        Console.WriteLine("Новый массив из цифр младших разрядов:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3: Сумма цифр массива из 17 двузначных чисел");

//        int[] array = new int[17];

//        Console.WriteLine("Введите 17 двузначных чисел:");
//        for (int i = 0; i < 17; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int sum = 0;

//        for (int i = 0; i < 17; i++)
//        {
//            int number = array[i];
//            sum += number / 10;
//            sum += number % 10;
//        }

//        Console.WriteLine($"Сумма цифр массива: {sum}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 4: Формирование третьего массива из двух упорядоченных");

//        int[] array1 = new int[9];
//        int[] array2 = new int[7];

//        Console.WriteLine("Введите элементы первого массива (9 элементов):");
//        for (int i = 0; i < 9; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите элементы второго массива (7 элементов):");
//        for (int i = 0; i < 7; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = int.Parse(Console.ReadLine());
//        }

//        Array.Sort(array1);
//        Array.Sort(array2);

//        int[] newArray = new int[16];
//        Array.Copy(array1, newArray, 9);
//        Array.Copy(array2, 0, newArray, 9, 7);

//        Array.Sort(newArray);

//        Console.WriteLine("Третий массив, упорядоченный по возрастанию:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5: Формирование массива из одинаковых элементов двух массивов");

//        int[] X = new int[10];
//        int[] Y = new int[10];

//        Console.WriteLine("Введите элементы массива X:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            X[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите элементы массива Y:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            Y[i] = int.Parse(Console.ReadLine());
//        }

//        List<int> commonElements = new List<int>();

//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                if (X[i] == Y[j] && !commonElements.Contains(X[i]))
//                {
//                    commonElements.Add(X[i]);
//                }
//            }
//        }

//        Console.WriteLine("Массив S из одинаковых элементов:");
//        Console.WriteLine("[" + string.Join(", ", commonElements) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6: Рассчитать значения массива Y по формуле и вывести элементы меньше среднего арифметического");

//        double[] Y = new double[12];

//        for (int i = 0; i < 12; i++)
//        {
//            Y[i] = Math.Pow(i, 2) - 2 * i + 19.3 * Math.Cos(i);
//        }

//        double sum = 0;
//        for (int i = 0; i < 12; i++)
//        {
//            sum += Y[i];
//        }
//        double average = sum / 12;

//        Console.WriteLine("Элементы массива Y, значения которых меньше среднего арифметического:");
//        for (int i = 0; i < 12; i++)
//        {
//            if (Y[i] < average)
//            {
//                Console.WriteLine($"Y[{i}] = {Y[i]:F2}");
//            }
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7: Разность между суммой элементов с четными индексами и суммой элементов, индексы которых кратны трем");

//        double[] Z = new double[16];

//        Console.WriteLine("Введите 16 вещественных чисел:");
//        for (int i = 0; i < 16; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            Z[i] = double.Parse(Console.ReadLine());
//        }

//        double evenIndexSum = 0;
//        double multipleOfThreeIndexSum = 0;

//        for (int i = 0; i < 16; i++)
//        {
//            if (i % 2 == 0)
//            {
//                evenIndexSum += Z[i];
//            }
//            if (i % 3 == 0)
//            {
//                multipleOfThreeIndexSum += Z[i];
//            }
//        }

//        double difference = evenIndexSum - multipleOfThreeIndexSum;

//        Console.WriteLine($"Разность: {difference}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8: Индекс наибольшего из нечетных по значению положительных элементов");

//        int[] R = new int[9];

//        Console.WriteLine("Введите 9 целых чисел:");
//        for (int i = 0; i < 9; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            R[i] = int.Parse(Console.ReadLine());
//        }

//        int maxOddPositiveIndex = -1;
//        int maxOddPositiveValue = int.MinValue;

//        for (int i = 0; i < 9; i++)
//        {
//            if (R[i] > 0 && R[i] % 2 != 0 && R[i] > maxOddPositiveValue)
//            {
//                maxOddPositiveValue = R[i];
//                maxOddPositiveIndex = i;
//            }
//        }

//        if (maxOddPositiveIndex != -1)
//        {
//            Console.WriteLine($"Индекс наибольшего из нечетных по значению положительных элементов: {maxOddPositiveIndex}");
//        }
//        else
//        {
//            Console.WriteLine("Нет нечетных положительных элементов.");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9: Рассчитать элементы массива Y по формуле и сформировать третий массив");

//        double[] X = new double[15];
//        double[] Y = new double[15];

//        Console.WriteLine("Введите 15 элементов массива X:");
//        for (int i = 0; i < 15; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            X[i] = double.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < 15; i++)
//        {
//            Y[i] = Math.Cos(X[i] * X[i]) + 2.971 * Math.Log10(i * i);
//        }

//        double[] combinedArray = new double[30];
//        Array.Copy(X, combinedArray, 15);
//        Array.Copy(Y, 0, combinedArray, 15, 15);

//        Array.Sort(combinedArray);
//        Array.Reverse(combinedArray);

//        Console.WriteLine("Третий массив, упорядоченный по убыванию:");
//        Console.WriteLine("[" + string.Join(", ", Array.ConvertAll(combinedArray, x => x.ToString("F2"))) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10: Рассчитать элементы массива Y по формуле и сформировать новый массив R");

//        double[] X = new double[17];
//        double[] Y = new double[17];

//        Console.WriteLine("Введите 17 элементов массива X:");
//        for (int i = 0; i < 17; i++)
//        {
//            Console.Write(\$"Элемент {i + 1}: ");
//            X[i] = double.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < 17; i++)
//        {
//            if (Math.Cos(X[i]) > 0)
//            {
//                Y[i] = Math.Pow(X[i], 3) - 7.5;
//            }
//            else
//            {
//                Y[i] = Math.Pow(X[i], 3) - 5 * Math.Exp(Math.Sin(X[i]));
//            }
//        }

//        Array.Sort(Y);
//        Array.Reverse(Y);

//        int[] R = new int[Y.Length];
//        for (int i = 0; i < Y.Length; i++)
//        {
//            if (i % 2 == 0)
//            {
//                R[i] = (int)Y[i];
//            }
//        }

//        Console.WriteLine("Новый массив R:");
//        Console.WriteLine("[" + string.Join(", ", R) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11: Сумма цифр элементов массива");

//        int[] array = new int[9];

//        Console.WriteLine("Введите 9 двузначных чисел:");
//        for (int i = 0; i < 9; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[9];

//        for (int i = 0; i < 9; i++)
//        {
//            int number = array[i];
//            newArray[i] = (number / 10) + (number % 10);
//        }

//        Console.WriteLine("Новый массив из сумм цифр:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12: Расположение элементов в порядке убывания и подсчет произведений");

//        double[] array = new double[12];

//        Console.WriteLine("Введите 12 вещественных чисел:");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int productCount = 0;

//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (array[j] < array[j + 1])
//                {
//                    double temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                    productCount++;
//                }
//            }
//        }

//        Console.WriteLine("Массив в порядке убывания:");
//        Console.WriteLine("[" + string.Join(", ", Array.ConvertAll(array, x => x.ToString("F2"))) + "]");
//        Console.WriteLine($"Количество произведённых перестановок: {productCount}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13: Сумма нечетных отрицательных элементов и замена кратных трем");

//        int[] array = new int[11];

//        Console.WriteLine("Введите 11 целых чисел:");
//        for (int i = 0; i < 11; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int sumOddNegative = 0;

//        for (int i = 0; i < 11; i++)
//        {
//            if (array[i] < 0 && array[i] % 2 != 0)
//            {
//                sumOddNegative += array[i];
//            }
//        }

//        for (int i = 0; i < 11; i++)
//        {
//            if (array[i] % 3 == 0)
//            {
//                array[i] = sumOddNegative;
//            }
//        }

//        Console.WriteLine("Массив после замены:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");
//        Console.WriteLine($"Сумма нечетных отрицательных элементов: {sumOddNegative}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 14: Перестановка первой и второй половин массива");

//        double[] array = new double[14];

//        Console.WriteLine("Введите 14 вещественных чисел:");
//        for (int i = 0; i < 14; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        int halfLength = array.Length / 2;
//        int productCount = 0;

//        for (int i = 0; i < halfLength; i++)
//        {
//            double temp = array[i];
//            array[i] = array[i + halfLength];
//            array[i + halfLength] = temp;
//            productCount++;
//        }

//        Console.WriteLine("Массив после перестановки:");
//        Console.WriteLine("[" + string.Join(", ", Array.ConvertAll(array, x => x.ToString("F2"))) + "]");
//        Console.WriteLine($"Количество произведённых перестановок: {productCount}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 15: Найти элемент массива, наиболее удаленный от числа S");

//        double[] array = new double[19];

//        Console.WriteLine("Введите 19 вещественных чисел:");
//        for (int i = 0; i < 19; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = double.Parse(Console.ReadLine());
//        }

//        Console.Write("Введите вещественное число S: ");
//        double S = double.Parse(Console.ReadLine());

//        double maxDistance = 0;
//        int maxDistanceIndex = 0;

//        for (int i = 0; i < 19; i++)
//        {
//            double distance = Math.Abs(array[i] - S);
//            if (distance > maxDistance)
//            {
//                maxDistance = distance;
//                maxDistanceIndex = i;
//            }
//        }

//        Console.WriteLine($"Наиболее удаленный элемент: {array[maxDistanceIndex]} (индекс {maxDistanceIndex})");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 16: Сумма и количество элементов до первого отрицательного числа");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 целых чисел:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int sum = 0;
//        int count = 0;

//        for (int i = 0; i < 10; i++)
//        {
//            if (array[i] < 0)
//            {
//                break;
//            }
//            sum += array[i];
//            count++;
//        }

//        Console.WriteLine($"Сумма элементов до первого отрицательного числа: {sum}");
//        Console.WriteLine($"Количество элементов до первого отрицательного числа: {count}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 17: Количество локальных минимумов в массиве");

//        int[] array = new int[20];

//        Console.WriteLine("Введите 20 целых чисел:");
//        for (int i = 0; i < 20; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int localMinCount = 0;

//        for (int i = 1; i < 19; i++)
//        {
//            if (array[i] < array[i - 1] && array[i] < array[i + 1])
//            {
//                localMinCount++;
//            }
//        }

//        Console.WriteLine($"Количество локальных минимумов: {localMinCount}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 18: Количество локальных максимумов в массиве");

//        int[] array = new int[20];

//        Console.WriteLine("Введите 20 целых чисел:");
//        for (int i = 0; i < 20; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int localMaxCount = 0;

//        for (int i = 1; i < 19; i++)
//        {
//            if (array[i] > array[i - 1] && array[i] > array[i + 1])
//            {
//                localMaxCount++;
//            }
//        }

//        Console.WriteLine($"Количество локальных максимумов: {localMaxCount}");
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 19: Сумма и последовательность значений между первым отрицательным и нулевым элементами");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел (положительных, отрицательных и нулей):");
//        for (int i = 0; i < 15; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int firstNegativeIndex = -1;
//        int firstZeroIndex = -1;

//        for (int i = 0; i < 15; i++)
//        {
//            if (array[i] < 0 && firstNegativeIndex == -1)
//            {
//                firstNegativeIndex = i;
//            }
//            if (array[i] == 0 && firstZeroIndex == -1)
//            {
//                firstZeroIndex = i;
//            }
//        }

//        if (firstNegativeIndex != -1 && firstZeroIndex != -1)
//        {
//            int start = Math.Min(firstNegativeIndex, firstZeroIndex);
//            int end = Math.Max(firstNegativeIndex, firstZeroIndex);

//            int sum = 0;
//            List<int> sequence = new List<int>();

//            for (int i = start + 1; i < end; i++)
//            {
//                sum += array[i];
//                sequence.Add(array[i]);
//            }

//            Console.WriteLine($"Сумма значений между первым отрицательным и нулевым элементами: {sum}");
//            Console.WriteLine("Последовательность значений:");
//            Console.WriteLine("[" + string.Join(", ", sequence) + "]");
//        }
//        else
//        {
//            Console.WriteLine("В массиве нет первого отрицательного или нулевого элемента.");
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 20: Индексы последовательности монотонно убывающих чисел");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < 15; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        List<int> decreasingIndices = new List<int>();

//        for (int i = 0; i < 14; i++)
//        {
//            if (array[i] > array[i + 1])
//            {
//                if (!decreasingIndices.Contains(i))
//                {
//                    decreasingIndices.Add(i);
//                }
//                if (!decreasingIndices.Contains(i + 1))
//                {
//                    decreasingIndices.Add(i + 1);
//                }
//            }
//        }

//        Console.WriteLine("Индексы последовательности монотонно убывающих чисел:");
//        Console.WriteLine("[" + string.Join(", ", decreasingIndices) + "]");
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 21: Удаление элементов, встречающихся более двух раз");

//        int[] array = { 1, 2, 3, 2, 4, 5, 3, 6, 3, 7 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        Dictionary<int, int> frequency = new Dictionary<int, int>();

//        foreach (int num in array)
//        {
//            if (frequency.ContainsKey(num))
//            {
//                frequency[num]++;
//            }
//            else
//            {
//                frequency[num] = 1;
//            }
//        }

//        List<int> newArray = new List<int>();

//        foreach (int num in array)
//        {
//            if (frequency[num] <= 2)
//            {
//                newArray.Add(num);
//            }
//        }

//        Console.WriteLine("Массив после удаления элементов, встречающихся более двух раз:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 22: Формирование нового массива с отрицательными элементами и нулями сначала");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 целых чисел:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        List<int> negativeAndZero = new List<int>();
//        List<int> positive = new List<int>();

//        foreach (int num in array)
//        {
//            if (num <= 0)
//            {
//                negativeAndZero.Add(num);
//            }
//            else
//            {
//                positive.Add(num);
//            }
//        }

//        int[] newArray = new int[10];
//        negativeAndZero.CopyTo(newArray, 0);
//        positive.CopyTo(newArray, negativeAndZero.Count);

//        Console.WriteLine("Новый массив:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 23: Вычисление элементов массива Y и нахождение P");

//        double[] X = new double[10];

//        Console.WriteLine("Введите 10 элементов массива X:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            X[i] = double.Parse(Console.ReadLine());
//        }

//        double[] Y = new double[10];

//        for (int i = 0; i < 10; i++)
//        {
//            Y[i] = Math.Pow(X[i], 2) + 0.3;
//        }

//        double numerator = 1;
//        double denominator = 1;

//        for (int i = 0; i < 9; i++)
//        {
//            numerator *= X[i] * Y[i + 1];
//            denominator *= X[i + 1] * Y[i];
//        }

//        double P = numerator / denominator;

//        Console.WriteLine("Массив Y:");
//        Console.WriteLine("[" + string.Join(", ", Array.ConvertAll(Y, x => x.ToString("F2"))) + "]");
//        Console.WriteLine($"Остаток от деления P на 1: {P % 1}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 24: Разности цифр элементов массива");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 двузначных чисел:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[10];

//        for (int i = 0; i < 10; i++)
//        {
//            int firstDigit = array[i] / 10;
//            int secondDigit = array[i] % 10;
//            newArray[i] = Math.Abs(firstDigit - secondDigit);
//        }

//        Console.WriteLine("Новый массив из разностей цифр:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 25: Упорядочивание массива");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 целых чисел:");
//        for (int i = 0; i < 15; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        List<int> negative = new List<int>();
//        List<int> positive = new List<int>();

//        foreach (int num in array)
//        {
//            if (num < 0)
//            {
//                negative.Add(num);
//            }
//            else
//            {
//                positive.Add(num);
//            }
//        }

//        negative.Sort();
//        positive.Sort((a, b) => b.CompareTo(a));

//        int[] newArray = new int[15];
//        negative.CopyTo(newArray, 0);
//        positive.CopyTo(newArray, negative.Count);

//        Console.WriteLine("Упорядоченный массив:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 26: Замена элементов первого массива, которые есть во втором");

//        int[] array1 = new int[12];
//        int[] array2 = new int[12];

//        Console.WriteLine("Введите элементы первого массива:");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = int.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите элементы второго массива:");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = int.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < 12; i++)
//        {
//            for (int j = 0; j < 12; j++)
//            {
//                if (array1[i] == array2[j])
//                {
//                    array1[i] = 0;
//                    break;
//                }
//            }
//        }

//        Console.WriteLine("Первый массив после замены:");
//        Console.WriteLine("[" + string.Join(", ", array1) + "]");
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 27: Количество участков массива с монотонно возрастающими элементами");

//        int[] array = { 1, 2, 3, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 7 };

//        int increasingSegments = 0;
//        bool isIncreasing = false;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > array[i - 1])
//            {
//                if (!isIncreasing)
//                {
//                    increasingSegments++;
//                    isIncreasing = true;
//                }
//            }
//            else
//            {
//                isIncreasing = false;
//            }
//        }

//        Console.WriteLine($"Количество участков массива, на котором элементы монотонно возрастают: {increasingSegments}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 28: Остаток от деления суммы элементов с четными индексами на сумму элементов с нечетными индексами");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 целых чисел:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int evenIndexSum = 0;
//        int oddIndexSum = 0;

//        for (int i = 0; i < 10; i++)
//        {
//            if (i % 2 == 0)
//            {
//                evenIndexSum += array[i];
//            }
//            else
//            {
//                oddIndexSum += array[i];
//            }
//        }

//        int remainder = evenIndexSum % oddIndexSum;

//        Console.WriteLine($"Остаток от деления: {remainder}");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 29: Процентное содержание элементов, превышающих среднеарифметическое");

//        int[] array = new int[10];

//        Console.WriteLine("Введите 10 целых чисел:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        double average = array.Average();

//        int countAboveAverage = 0;
//        foreach (int num in array)
//        {
//            if (num > average)
//            {
//                countAboveAverage++;
//            }
//        }

//        double percentage = (double)countAboveAverage / array.Length * 100;

//        Console.WriteLine($"Процентное содержание элементов, превышающих среднеарифметическое: {percentage:F2}%");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 30: Максимальные элементы в каждом массиве и их замена");

//        double[] array1 = new double[10];
//        double[] array2 = new double[10];

//        Console.WriteLine("Введите элементы первого массива:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = double.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите элементы второго массива:");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = double.Parse(Console.ReadLine());
//        }

//        double max1 = array1[0];
//        int maxIndex1 = 0;
//        double max2 = array2[0];
//        int maxIndex2 = 0;

//        for (int i = 1; i < 10; i++)
//        {
//            if (array1[i] > max1)
//            {
//                max1 = array1[i];
//                maxIndex1 = i;
//            }
//            if (array2[i] > max2)
//            {
//                max2 = array2[i];
//                maxIndex2 = i;
//            }
//        }

//        double temp = array1[maxIndex1];
//        array1[maxIndex1] = array2[maxIndex2];
//        array2[maxIndex2] = temp;

//        Console.WriteLine("Первый массив после замены:");
//        Console.WriteLine("[" + string.Join(", ", Array.ConvertAll(array1, x => x.ToString("F2"))) + "]");
//        Console.WriteLine("Второй массив после замены:");
//        Console.WriteLine("[" + string.Join(", ", Array.ConvertAll(array2, x => x.ToString("F2"))) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3: Перевод числа из двоичной системы счисления в шестнадцатеричную");

//        Console.Write("Введите двоичное число (цифры 0 и 1): ");
//        string binaryNumber = Console.ReadLine();

//        foreach (char c in binaryNumber)
//        {
//            if (c != '0' && c != '1')
//            {
//                Console.WriteLine("Ошибка: Введено некорректное двоичное число.");
//                return;
//            }
//        }

//        int decimalNumber = Convert.ToInt32(binaryNumber, 2);

//        string hexNumber = Convert.ToString(decimalNumber, 16).ToUpper();

//        Console.WriteLine($"Шестнадцатеричное число: {hexNumber}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 4: Перевод дроби из двоичной системы счисления в десятичную");

//        Console.Write("Введите дробное двоичное число (цифры 0 и 1, разделенные точкой): ");
//        string binaryFraction = Console.ReadLine();

//        string[] parts = binaryFraction.Split('.');
//        if (parts.Length != 2)
//        {
//            Console.WriteLine("Ошибка: Введите число в формате 'целая_часть.дробная_часть'.");
//            return;
//        }

//        string integerPart = parts[0];
//        string fractionalPart = parts[1];

//        int integerDecimal = Convert.ToInt32(integerPart, 2);

//        double fractionalDecimal = 0;
//        for (int i = 0; i < fractionalPart.Length; i++)
//        {
//            if (fractionalPart[i] == '1')
//            {
//                fractionalDecimal += Math.Pow(2, -(i + 1));
//            }
//        }

//        double decimalNumber = integerDecimal + fractionalDecimal;

//        Console.WriteLine($"Десятичное число: {decimalNumber}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5: Перевод дроби из двоичной системы счисления в восьмеричную");

//        Console.Write("Введите дробное двоичное число (цифры 0 и 1, разделенные точкой): ");
//        string binaryFraction = Console.ReadLine();

//        string[] parts = binaryFraction.Split('.');
//        if (parts.Length != 2)
//        {
//            Console.WriteLine("Ошибка: Введите число в формате 'целая_часть.дробная_часть'.");
//            return;
//        }

//        string integerPart = parts[0];
//        string fractionalPart = parts[1];

//        int integerDecimal = Convert.ToInt32(integerPart, 2);

//        string octalInteger = Convert.ToString(integerDecimal, 8);

//        fractionalPart = fractionalPart.PadRight(12, '0');
//        string octalFraction = "";

//        for (int i = 0; i < fractionalPart.Length; i += 3)
//        {
//            string triplet = fractionalPart.Substring(i, Math.Min(3, fractionalPart.Length - i));
//            int decimalTriplet = Convert.ToInt32(triplet, 2);
//            octalFraction += Convert.ToString(decimalTriplet, 8);
//        }

//        Console.WriteLine($"Восьмеричное число: {octalInteger}.{octalFraction}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6: Перевод дроби из двоичной системы счисления в шестнадцатеричную");

//        Console.Write("Введите дробное двоичное число (цифры 0 и 1, разделенные точкой): ");
//        string binaryFraction = Console.ReadLine();

//        string[] parts = binaryFraction.Split('.');
//        if (parts.Length != 2)
//        {
//            Console.WriteLine("Ошибка: Введите число в формате 'целая_часть.дробная_часть'.");
//            return;
//        }

//        string integerPart = parts[0];
//        string fractionalPart = parts[1];

//        int integerDecimal = Convert.ToInt32(integerPart, 2);

//        string hexInteger = Convert.ToString(integerDecimal, 16).ToUpper();

//        fractionalPart = fractionalPart.PadRight(16, '0');
//        string hexFraction = "";

//        for (int i = 0; i < fractionalPart.Length; i += 4)
//        {
//            string quadruplet = fractionalPart.Substring(i, Math.Min(4, fractionalPart.Length - i));
//            int decimalQuadruplet = Convert.ToInt32(quadruplet, 2);
//            hexFraction += Convert.ToString(decimalQuadruplet, 16).ToUpper();
//        }

//        Console.WriteLine($"Шестнадцатеричное число: {hexInteger}.{hexFraction}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7: Изменение разрядности цифр, образующих элементы массива");

//        int[] array = new int[15];

//        Console.WriteLine("Введите 15 двузначных целых чисел:");
//        for (int i = 0; i < 15; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[15];

//        for (int i = 0; i < 15; i++)
//        {
//            int number = array[i];
//            int firstDigit = number / 10;
//            int secondDigit = number % 10;
//            newArray[i] = firstDigit * 100 + secondDigit * 10 + (firstDigit + secondDigit);
//        }

//        Console.WriteLine("Новый массив:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8: Перевод значений элементов массива из восьмеричной системы в десятичную");

//        string[] array = new string[9];

//        Console.WriteLine("Введите 9 восьмеричных чисел:");
//        for (int i = 0; i < 9; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = Console.ReadLine();
//        }

//        int[] newArray = new int[9];

//        for (int i = 0; i < 9; i++)
//        {
//            newArray[i] = Convert.ToInt32(array[i], 8);
//        }

//        Console.WriteLine("Новый массив в десятичной системе:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9: Новый массив из цифр старших разрядов");

//        int[] array = new int[7];

//        Console.WriteLine("Введите 7 двузначных целых чисел:");
//        for (int i = 0; i < 7; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] newArray = new int[7];

//        for (int i = 0; i < 7; i++)
//        {
//            newArray[i] = array[i] / 10; // Старший разряд
//        }

//        Console.WriteLine("Новый массив из цифр старших разрядов:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10: Формирование третьего массива из упорядоченных по убыванию значений обоих массивов");

//        double[] array1 = new double[7];
//        double[] array2 = new double[9];

//        Console.WriteLine("Введите 7 элементов первого массива:");
//        for (int i = 0; i < 7; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array1[i] = double.Parse(Console.ReadLine());
//        }

//        Console.WriteLine("Введите 9 элементов второго массива:");
//        for (int i = 0; i < 9; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array2[i] = double.Parse(Console.ReadLine());
//        }

//        double[] combinedArray = new double[16];
//        Array.Copy(array1, combinedArray, 7);
//        Array.Copy(array2, 0, combinedArray, 7, 9);

//        Array.Sort(combinedArray);
//        Array.Reverse(combinedArray);

//        Console.WriteLine("Третий массив, упорядоченный по убыванию:");
//        Console.WriteLine("[" + string.Join(", ", Array.ConvertAll(combinedArray, x => x.ToString("F2"))) + "]");
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11: Удаление элементов, встречающихся более двух раз");

//        int[] array = new int[12];

//        Console.WriteLine("Введите 12 двоичных чисел (0 или 1):");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        Dictionary<int, int> frequency = new Dictionary<int, int>();

//        foreach (int num in array)
//        {
//            if (frequency.ContainsKey(num))
//            {
//                frequency[num]++;
//            }
//            else
//            {
//                frequency[num] = 1;
//            }
//        }

//        List<int> newArray = new List<int>();

//        foreach (int num in array)
//        {
//            if (frequency[num] <= 2)
//            {
//                newArray.Add(num);
//            }
//        }

//        Console.WriteLine("Массив после удаления элементов, встречающихся более двух раз:");
//        Console.WriteLine("[" + string.Join(", ", newArray) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12: Определение местоположения двух одинаковых элементов");

//        int[] array = new int[12];

//        Console.WriteLine("Введите 12 элементов массива:");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        for (int i = 0; i < 12; i++)
//        {
//            for (int j = i + 1; j < 12; j++)
//            {
//                if (array[i] == array[j])
//                {
//                    Console.WriteLine($"Одинаковые элементы {array[i]} находятся на позициях {i} и {j}");
//                    return;
//                }
//            }
//        }

//        Console.WriteLine("Одинаковых элементов не найдено.");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13: Циклический сдвиг элементов массива влево на две позиции");

//        int[] array = new int[12];

//        Console.WriteLine("Введите 12 двоичных чисел (0 или 1):");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int[] shiftedArray = new int[12];
//        Array.Copy(array, 2, shiftedArray, 0, 10);
//        shiftedArray[10] = array[0];
//        shiftedArray[11] = array[1];

//        Console.WriteLine("Массив после циклического сдвига влево на две позиции:");
//        Console.WriteLine("[" + string.Join(", ", shiftedArray) + "]");

//        int originalNumber = Convert.ToInt32(string.Join("", array), 2);
//        int shiftedNumber = Convert.ToInt32(string.Join("", shiftedArray), 2);

//        int difference = originalNumber - shiftedNumber;

//        Console.WriteLine($"Разность исходного и полученного после сдвига числа: {difference}");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 14: Упорядочивание элементов массива по убыванию и нахождение суммы чисел");

//        int[] array = new int[12];

//        Console.WriteLine("Введите 12 двоичных чисел (0 или 1):");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        Array.Sort(array);
//        Array.Reverse(array);

//        Console.WriteLine("Массив, упорядоченный по убыванию:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int sum = array.Sum();
//        Console.WriteLine($"Сумма чисел: {sum}");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 15: Упорядочивание элементов массива по возрастанию и нахождение среднего значения чисел");

//        int[] array = new int[12];

//        Console.WriteLine("Введите 12 двоичных чисел (0 или 1):");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        Array.Sort(array);

//        Console.WriteLine("Массив, упорядоченный по возрастанию:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        double average = array.Average();
//        Console.WriteLine($"Среднее значение чисел: {average}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 16: Замена максимального и минимального элементов");

//        int[] array = new int[12];

//        Console.WriteLine("Введите 12 двоичных чисел (0 или 1):");
//        for (int i = 0; i < 12; i++)
//        {
//            Console.Write($"Элемент {i + 1}: ");
//            array[i] = int.Parse(Console.ReadLine());
//        }

//        int maxIndex = 0;
//        int minIndex = 0;

//        for (int i = 1; i < 12; i++)
//        {
//            if (array[i] > array[maxIndex])
//            {
//                maxIndex = i;
//            }
//            if (array[i] < array[minIndex])
//            {
//                minIndex = i;
//            }
//        }

//        int temp = array[maxIndex];
//        array[maxIndex] = array[minIndex];
//        array[minIndex] = temp;

//        Console.WriteLine("Массив после замены максимального и минимального элементов:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 17: Циклический сдвиг элементов массива вправо на одну позицию");

//        int[] array = { 1, 0, 1, 1, 0, 1, 0, 1 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int lastElement = array[array.Length - 1];
//        for (int i = array.Length - 1; i > 0; i--)
//        {
//            array[i] = array[i - 1];
//        }
//        array[0] = lastElement;

//        Console.WriteLine("Массив после циклического сдвига вправо на одну позицию:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int originalNumber = Convert.ToInt32(string.Join("", array.Select(x => x.ToString())), 2);

//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            array[i] = array[i + 1];
//        }
//        array[array.Length - 1] = lastElement;

//        int shiftedNumber = Convert.ToInt32(string.Join("", array.Select(x => x.ToString())), 2);

//        int sum = originalNumber + shiftedNumber;

//        Console.WriteLine($"Сумма исходного и полученного после сдвига числа: {sum}");
//    }
//}

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 18: Разность между суммой значений элементов массива на участках с монотонно возрастающими и убывающими элементами");

//        int[] array = { 1, 2, 3, 2, 1, 4, 5, 6, 5, 4, 3, 2 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int increasingSum = 0;
//        int decreasingSum = 0;
//        bool isIncreasing = false;
//        bool isDecreasing = false;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (i < array.Length - 1 && array[i] < array[i + 1])
//            {
//                if (!isIncreasing)
//                {
//                    isIncreasing = true;
//                    isDecreasing = false;
//                }
//                increasingSum += array[i];
//            }
//            else if (i < array.Length - 1 && array[i] > array[i + 1])
//            {
//                if (!isDecreasing)
//                {
//                    isDecreasing = true;
//                    isIncreasing = false;
//                }
//                decreasingSum += array[i];
//            }
//            else
//            {
//                if (isIncreasing)
//                {
//                    increasingSum += array[i];
//                }
//                else if (isDecreasing)
//                {
//                    decreasingSum += array[i];
//                }
//                isIncreasing = false;
//                isDecreasing = false;
//            }
//        }

//        int difference = increasingSum - decreasingSum;

//        Console.WriteLine($"Разность между суммой значений элементов массива на участках с монотонно возрастающими и убывающими элементами: {difference}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 19: Проверка, образуют ли значения элементов массива арифметическую прогрессию");

//        int[] array = { 2, 4, 6, 8, 10, 12 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        bool isArithmeticProgression = true;
//        if (array.Length < 2)
//        {
//            isArithmeticProgression = false;
//        }
//        else
//        {
//            int difference = array[1] - array[0];
//            for (int i = 2; i < array.Length; i++)
//            {
//                if (array[i] - array[i - 1] != difference)
//                {
//                    isArithmeticProgression = false;
//                    break;
//                }
//            }
//        }

//        if (isArithmeticProgression)
//        {
//            int difference = array[1] - array[0];
//            Console.WriteLine($"Да, значения элементов массива образуют арифметическую прогрессию с разностью {difference}");
//        }
//        else
//        {
//            Console.WriteLine("Нет, значения элементов массива не образуют арифметическую прогрессию");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 20: Проверка, образуют ли значения элементов массива геометрическую прогрессию");

//        int[] array = { 3, 6, 12, 24, 48 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        bool isGeometricProgression = true;
//        if (array.Length < 2)
//        {
//            isGeometricProgression = false;
//        }
//        else
//        {
//            double ratio = (double)array[1] / array[0];
//            for (int i = 2; i < array.Length; i++)
//            {
//                if ((double)array[i] / array[i - 1] != ratio)
//                {
//                    isGeometricProgression = false;
//                    break;
//                }
//            }
//        }

//        if (isGeometricProgression)
//        {
//            double ratio = (double)array[1] / array[0];
//            Console.WriteLine($"Да, значения элементов массива образуют геометрическую прогрессию с знаменателем {ratio}");
//        }
//        else
//        {
//            Console.WriteLine("Нет, значения элементов массива не образуют геометрическую прогрессию");
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 21: Индексы элементов, значения которых больше, чем у стоящих справа от него");

//        int[] array = { 5, 3, 8, 6, 2, 7, 1, 4 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        List<int> indices = new List<int>();

//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            bool isGreaterThanAllRight = true;
//            for (int j = i + 1; j < array.Length; j++)
//            {
//                if (array[i] <= array[j])
//                {
//                    isGreaterThanAllRight = false;
//                    break;
//                }
//            }
//            if (isGreaterThanAllRight)
//            {
//                indices.Add(i);
//            }
//        }

//        Console.WriteLine("Индексы элементов, значения которых больше, чем у стоящих справа от него:");
//        Console.WriteLine("[" + string.Join(", ", indices) + "]");
//        Console.WriteLine($"Количество таких элементов: {indices.Count}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 22: Номер последнего элемента, который удовлетворяет неравенству");

//        int[] array = { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int lastIndex = -1;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (i > 0 && array[i] < array[i - 1] * 2)
//            {
//                lastIndex = i;
//            }
//        }

//        if (lastIndex != -1)
//        {
//            Console.WriteLine($"Номер последнего элемента, который удовлетворяет неравенству: {lastIndex}");
//        }
//        else
//        {
//            Console.WriteLine("Нет элементов, которые удовлетворяют неравенству");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 23: Количество чисел, стоящих между максимальным и минимальным элементами");

//        int[] array = { 5, 3, 8, 6, 2, 7, 1, 4 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int maxIndex = 0;
//        int minIndex = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > array[maxIndex])
//            {
//                maxIndex = i;
//            }
//            if (array[i] < array[minIndex])
//            {
//                minIndex = i;
//            }
//        }

//        int start = Math.Min(maxIndex, minIndex);
//        int end = Math.Max(maxIndex, minIndex);

//        int count = end - start - 1;

//        Console.WriteLine($"Количество чисел между максимальным и минимальным элементами: {count}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 24: Циклический сдвиг всех элементов массива вправо на одну позицию");

//        int[] array = { 1, 0, 1, 1, 0, 1, 0, 1 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int lastElement = array[array.Length - 1];
//        for (int i = array.Length - 1; i > 0; i--)
//        {
//            array[i] = array[i - 1];
//        }
//        array[0] = lastElement;

//        Console.WriteLine("Массив после циклического сдвига вправо на одну позицию:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 25: Циклический сдвиг всех элементов массива влево на одну позицию");

//        int[] array = { 1, 0, 1, 1, 0, 1, 0, 1 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int firstElement = array[0];
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            array[i] = array[i + 1];
//        }
//        array[array.Length - 1] = firstElement;

//        Console.WriteLine("Массив после циклического сдвига влево на одну позицию:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int decimalNumber = Convert.ToInt32(string.Join("", array.Select(x => x.ToString())), 2);

//        Console.WriteLine($"Сумма чисел до и после операции сдвига: {decimalNumber + decimalNumber}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 26: Увеличение каждого элемента массива на двоичное число 1010");

//        int[] array = { 1010, 1100, 1001, 1111, 1000 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        int binaryNumber = 1010;

//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] += binaryNumber;
//        }

//        Console.WriteLine("Массив после увеличения каждого элемента на двоичное число 1010:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 27: Элемент массива, наиболее близкий к заданному вещественному числу");

//        double[] array = { 1.2, 3.4, 5.6, 7.8, 9.0, 2.3, 4.5, 6.7, 8.9, 0.1 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", Array.ConvertAll(array, x => x.ToString("F2"))) + "]");

//        Console.Write("Введите вещественное число R: ");
//        double R = double.Parse(Console.ReadLine());

//        double minDifference = double.MaxValue;
//        int closestIndex = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            double difference = Math.Abs(array[i] - R);
//            if (difference < minDifference)
//            {
//                minDifference = difference;
//                closestIndex = i;
//            }
//        }

//        Console.WriteLine($"Элемент массива, наиболее близкий к заданному вещественному числу: {array[closestIndex]} (индекс {closestIndex})");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 28: Элемент массива, наиболее удаленный от заданного двоичного числа");

//        int[] array = { 1010, 1100, 1001, 1111, 1000 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        Console.Write("Введите двоичное число D: ");
//        int D = int.Parse(Console.ReadLine());

//        int maxDifference = int.MinValue;
//        int farthestIndex = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            int difference = Math.Abs(array[i] - D);
//            if (difference > maxDifference)
//            {
//                maxDifference = difference;
//                farthestIndex = i;
//            }
//        }

//        Console.WriteLine($"Элемент массива, наиболее удаленный от заданного двоичного числа: {array[farthestIndex]} (индекс {farthestIndex})");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 29: Сумма двух последовательностей нулей и единиц");

//        Console.Write("Введите первое двоичное число: ");
//        string binaryNumber1 = Console.ReadLine();

//        Console.Write("Введите второе двоичное число: ");
//        string binaryNumber2 = Console.ReadLine();

//        int decimalNumber1 = Convert.ToInt32(binaryNumber1, 2);
//        int decimalNumber2 = Convert.ToInt32(binaryNumber2, 2);

//        int sum = decimalNumber1 + decimalNumber2;

//        string binarySum = Convert.ToString(sum, 2);

//        Console.WriteLine($"Сумма двоичных чисел: {binarySum}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 30: Массив из чисел, представленных в двоичной системе счисления");

//        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine("[" + string.Join(", ", array) + "]");

//        string[] binaryArray = new string[array.Length];

//        for (int i = 0; i < array.Length; i++)
//        {
//            binaryArray[i] = Convert.ToString(array[i], 2);
//        }

//        Console.WriteLine("Массив в двоичной системе счисления:");
//        Console.WriteLine("[" + string.Join(", ", binaryArray) + "]");
//    }
//}

//Двумерные
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 1: Сортировка массива 3×4 по последней строке");

//        int[,] matrix = new int[3, 4];

//        // Ввод матрицы
//        Console.WriteLine("Введите элементы матрицы 3×4:");
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write($"Элемент [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        Console.WriteLine("\nИсходная матрица:");
//        PrintMatrix(matrix);

//        // Сортировка по элементам последней строки (индекс 2)
//        SortMatrixByLastRow(matrix);

//        Console.WriteLine("\nМатрица после сортировки по последней строке:");
//        PrintMatrix(matrix);

//        // Демонстрация с тестовыми данными
//        int[,] testMatrix = {
//            {1, 5, 9, 2},
//            {3, 7, 1, 8},
//            {6, 2, 4, 3}
//        };

//        Console.WriteLine("\nТестовый пример:");
//        Console.WriteLine("До сортировки:");
//        PrintMatrix(testMatrix);

//        SortMatrixByLastRow(testMatrix);

//        Console.WriteLine("После сортировки:");
//        PrintMatrix(testMatrix);
//    }

//    static void SortMatrixByLastRow(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        // Сортировка столбцов по элементам последней строки
//        for (int i = 0; i < cols - 1; i++)
//        {
//            for (int j = 0; j < cols - 1 - i; j++)
//            {
//                if (matrix[rows - 1, j] > matrix[rows - 1, j + 1])
//                {
//                    // Обмен столбцов
//                    for (int row = 0; row < rows; row++)
//                    {
//                        int temp = matrix[row, j];
//                        matrix[row, j] = matrix[row, j + 1];
//                        matrix[row, j + 1] = temp;
//                    }
//                }
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 2: Сумма модулей отрицательных нечетных элементов в массиве 7×7");

//        int[,] matrix = new int[7, 7];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами от -20 до 20
//        Console.WriteLine("Генерация матрицы 7×7 со случайными числами:");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                matrix[i, j] = random.Next(-20, 21);
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        // Поиск и суммирование модулей отрицательных нечетных элементов
//        int sum = 0;
//        Console.WriteLine("\nОтрицательные нечетные элементы:");

//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                if (matrix[i, j] < 0 && matrix[i, j] % 2 != 0)
//                {
//                    Console.WriteLine($"matrix[{i},{j}] = {matrix[i, j]}, |{matrix[i, j]}| = {Math.Abs(matrix[i, j])}");
//                    sum += Math.Abs(matrix[i, j]);
//                }
//            }
//        }

//        Console.WriteLine($"\nСумма модулей отрицательных нечетных элементов: {sum}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3: Среднее арифметическое положительных элементов каждого столбца (5×6)");

//        int[,] matrix = new int[5, 6];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами от -10 до 15
//        Console.WriteLine("Генерация матрицы 5×6 со случайными числами:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                matrix[i, j] = random.Next(-10, 16);
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        // Вычисление среднего арифметического положительных элементов каждого столбца
//        Console.WriteLine("\nСреднее арифметическое положительных элементов по столбцам:");

//        for (int j = 0; j < 6; j++)
//        {
//            int sum = 0;
//            int count = 0;

//            Console.Write($"Столбец {j}: положительные элементы: ");
//            for (int i = 0; i < 5; i++)
//            {
//                if (matrix[i, j] > 0)
//                {
//                    sum += matrix[i, j];
//                    count++;
//                    Console.Write($"{matrix[i, j]} ");
//                }
//            }

//            if (count > 0)
//            {
//                double average = (double)sum / count;
//                Console.WriteLine($"→ Среднее: {average:F2}");
//            }
//            else
//            {
//                Console.WriteLine("→ Положительных элементов нет");
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 4: Наименьший элемент на побочной диагонали матрицы 5×5");

//        double[,] matrix = new double[5, 5];
//        Random random = new Random();

//        // Заполнение матрицы случайными вещественными числами
//        Console.WriteLine("Генерация матрицы 5×5 со случайными вещественными числами:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                matrix[i, j] = Math.Round(random.NextDouble() * 20 - 10, 2); // от -10 до 10
//            }
//        }

//        Console.WriteLine("\nМатрица:");
//        PrintMatrix(matrix);

//        // Поиск наименьшего элемента на побочной диагонали
//        // Побочная диагональ: элементы с индексами (i, n-1-i), где n - размер матрицы
//        double minElement = matrix[0, 4]; // Первый элемент побочной диагонали
//        int minRow = 0, minCol = 4;

//        Console.WriteLine("\nЭлементы побочной диагонали:");
//        for (int i = 0; i < 5; i++)
//        {
//            int j = 4 - i; // Столбец побочной диагонали
//            Console.WriteLine($"matrix[{i},{j}] = {matrix[i, j]}");

//            if (matrix[i, j] < minElement)
//            {
//                minElement = matrix[i, j];
//                minRow = i;
//                minCol = j;
//            }
//        }

//        Console.WriteLine($"\nНаименьший элемент на побочной диагонали:");
//        Console.WriteLine($"Значение: {minElement}");
//        Console.WriteLine($"Позиция: [{minRow},{minCol}]");
//    }

//    static void PrintMatrix(double[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],7:F2}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5: Сортировка массива 5×4 по убыванию элементов последнего столбца");

//        int[,] matrix = new int[5, 4];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        Console.WriteLine("Генерация матрицы 5×4 со случайными числами:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("\nИсходная матрица:");
//        PrintMatrix(matrix);

//        // Сортировка строк по убыванию элементов последнего столбца (индекс 3)
//        SortMatrixByLastColumn(matrix);

//        Console.WriteLine("\nМатрица после сортировки по убыванию последнего столбца:");
//        PrintMatrix(matrix);
//    }

//    static void SortMatrixByLastColumn(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);
//        int lastCol = cols - 1;

//        // Сортировка строк по элементам последнего столбца (по убыванию)
//        for (int i = 0; i < rows - 1; i++)
//        {
//            for (int j = 0; j < rows - 1 - i; j++)
//            {
//                if (matrix[j, lastCol] < matrix[j + 1, lastCol])
//                {
//                    // Обмен строк
//                    for (int col = 0; col < cols; col++)
//                    {
//                        int temp = matrix[j, col];
//                        matrix[j, col] = matrix[j + 1, col];
//                        matrix[j + 1, col] = temp;
//                    }
//                }
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6: Операции с матрицей 4×3");
//        Console.WriteLine("Примечание: Условие задачи не завершено.");
//        Console.WriteLine("Ниже представлены возможные варианты операций:");

//        int[,] matrix = new int[4, 3];
//        Random random = new Random();

//        // Заполнение матрицы
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("\nИсходная матрица 4×3:");
//        PrintMatrix(matrix);

//        // Вариант 1: Поменять местами первую и последнюю строки
//        Console.WriteLine("\nВариант 1: Обмен первой и последней строк");
//        SwapRows(matrix, 0, 3);
//        PrintMatrix(matrix);

//        // Восстановление исходной матрицы
//        SwapRows(matrix, 0, 3);

//        // Вариант 2: Поменять местами первый и последний столбцы
//        Console.WriteLine("\nВариант 2: Обмен первого и последнего столбцов");
//        SwapColumns(matrix, 0, 2);
//        PrintMatrix(matrix);

//        // Восстановление исходной матрицы
//        SwapColumns(matrix, 0, 2);

//        // Вариант 3: Поменять местами максимальный и минимальный элементы
//        Console.WriteLine("\nВариант 3: Обмен максимального и минимального элементов");
//        SwapMinMax(matrix);
//        PrintMatrix(matrix);
//    }

//    static void SwapRows(int[,] matrix, int row1, int row2)
//    {
//        int cols = matrix.GetLength(1);
//        for (int j = 0; j < cols; j++)
//        {
//            int temp = matrix[row1, j];
//            matrix[row1, j] = matrix[row2, j];
//            matrix[row2, j] = temp;
//        }
//    }

//    static void SwapColumns(int[,] matrix, int col1, int col2)
//    {
//        int rows = matrix.GetLength(0);
//        for (int i = 0; i < rows; i++)
//        {
//            int temp = matrix[i, col1];
//            matrix[i, col1] = matrix[i, col2];
//            matrix[i, col2] = temp;
//        }
//    }

//    static void SwapMinMax(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        int min = matrix[0, 0], max = matrix[0, 0];
//        int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

//        // Поиск минимального и максимального элементов
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                if (matrix[i, j] < min)
//                {
//                    min = matrix[i, j];
//                    minRow = i;
//                    minCol = j;
//                }
//                if (matrix[i, j] > max)
//                {
//                    max = matrix[i, j];
//                    maxRow = i;
//                    maxCol = j;
//                }
//            }
//        }

//        Console.WriteLine($"Минимальный элемент: {min} в позиции [{minRow},{minCol}]");
//        Console.WriteLine($"Максимальный элемент: {max} в позиции [{maxRow},{maxCol}]");

//        // Обмен элементов
//        matrix[minRow, minCol] = max;
//        matrix[maxRow, maxCol] = min;
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7: Обмен наименьших элементов в первой и третьей строке");

//        int[,] matrix = new int[3, 4]
//        {
//            { 5, 3, 8, 1 },
//            { 6, 2, 9, 4 },
//            { 7, 0, 1, 5 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int minFirstRow = matrix[0, 0];
//        int minFirstRowIndex = 0;
//        int minThirdRow = matrix[2, 0];
//        int minThirdRowIndex = 0;

//        for (int j = 1; j < 4; j++)
//        {
//            if (matrix[0, j] < minFirstRow)
//            {
//                minFirstRow = matrix[0, j];
//                minFirstRowIndex = j;
//            }
//            if (matrix[2, j] < minThirdRow)
//            {
//                minThirdRow = matrix[2, j];
//                minThirdRowIndex = j;
//            }
//        }

//        int temp = matrix[0, minFirstRowIndex];
//        matrix[0, minFirstRowIndex] = matrix[2, minThirdRowIndex];
//        matrix[2, minThirdRowIndex] = temp;

//        Console.WriteLine("\nМатрица после обмена наименьших элементов в первой и третьей строке:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8: Произведение наименьших элементов каждого столбца матрицы");

//        int[,] matrix = new int[5, 5]
//        {
//            { 5, 3, 8, 1, 2 },
//            { 6, 2, 9, 4, 7 },
//            { 7, 0, 1, 5, 3 },
//            { 11, 12, 13, 14, 15 },
//            { 15, 16, 17, 18, 19 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int product = 1;
//        for (int j = 0; j < 5; j++)
//        {
//            int minElement = matrix[0, j];
//            for (int i = 1; i < 5; i++)
//            {
//                if (matrix[i, j] < minElement)
//                {
//                    minElement = matrix[i, j];
//                }
//            }
//            product *= minElement;
//        }

//        Console.WriteLine($"\nПроизведение наименьших элементов каждого столбца: {product}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9: Среднее арифметическое каждого столбца, максимум и минимум каждой строки");

//        int[,] matrix = new int[5, 6]
//        {
//            { 5, 3, 8, 1, 2, 7 },
//            { 6, 2, 9, 4, 7, 1 },
//            { 7, 0, 1, 5, 3, 9 },
//            { 11, 12, 13, 14, 15, 16 },
//            { 15, 16, 17, 18, 19, 20 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        // Среднее арифметическое каждого столбца
//        for (int j = 0; j < 6; j++)
//        {
//            int sum = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                sum += matrix[i, j];
//            }
//            double average = (double)sum / 5;
//            Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {average:F2}");
//        }

//        // Максимум и минимум каждой строки
//        for (int i = 0; i < 5; i++)
//        {
//            int max = matrix[i, 0];
//            int min = matrix[i, 0];
//            for (int j = 1; j < 6; j++)
//            {
//                if (matrix[i, j] > max)
//                {
//                    max = matrix[i, j];
//                }
//                if (matrix[i, j] < min)
//                {
//                    min = matrix[i, j];
//                }
//            }
//            Console.WriteLine($"Строка {i + 1}: Максимум = {max}, Минимум = {min}");
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10: Количество нечетных элементов каждого столбца");

//        int[,] matrix = new int[7, 8]
//        {
//            { 5, 3, 8, 1, 2, 7, 4, 6 },
//            { 6, 2, 9, 4, 7, 1, 5, 3 },
//            { 7, 0, 1, 5, 3, 9, 2, 4 },
//            { 11, 12, 13, 14, 15, 16, 17, 18 },
//            { 15, 16, 17, 18, 19, 20, 21, 22 },
//            { 23, 24, 25, 26, 27, 28, 29, 30 },
//            { 31, 32, 33, 34, 35, 36, 37, 38 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        for (int j = 0; j < 8; j++)
//        {
//            int oddCount = 0;
//            for (int i = 0; i < 7; i++)
//            {
//                if (matrix[i, j] % 2 != 0)
//                {
//                    oddCount++;
//                }
//            }
//            Console.WriteLine($"Количество нечетных элементов в столбце {j + 1}: {oddCount}");
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11: Количество четных и нечетных чисел в массиве");

//        int[,] matrix = new int[5, 6]
//        {
//            { 5, 3, 8, 1, 2, 7 },
//            { 6, 2, 9, 4, 7, 1 },
//            { 7, 0, 1, 5, 3, 9 },
//            { 11, 12, 13, 14, 15, 16 },
//            { 15, 16, 17, 18, 19, 20 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int evenCount = 0;
//        int oddCount = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                if (matrix[i, j] % 2 == 0)
//                {
//                    evenCount++;
//                }
//                else
//                {
//                    oddCount++;
//                }
//            }
//        }

//        Console.WriteLine($"Количество четных чисел: {evenCount}");
//        Console.WriteLine($"Количество нечетных чисел: {oddCount}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12: Количество вхождений числа 7 в массиве");

//        int[,] matrix = new int[5, 6]
//        {
//            { 5, 3, 8, 1, 2, 7 },
//            { 6, 2, 9, 4, 7, 1 },
//            { 7, 0, 1, 5, 3, 9 },
//            { 11, 12, 13, 14, 15, 16 },
//            { 15, 16, 17, 18, 19, 20 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int count = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                if (matrix[i, j] == 7)
//                {
//                    count++;
//                }
//            }
//        }

//        Console.WriteLine($"Число 7 встречается {count} раз(а)");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13: Наибольший элемент массива в каждом столбце");

//        int[,] matrix = new int[5, 6]
//        {
//            { 5, 3, 8, 1, 2, 7 },
//            { 6, 2, 9, 4, 7, 1 },
//            { 7, 0, 1, 5, 3, 9 },
//            { 11, 12, 13, 14, 15, 16 },
//            { 15, 16, 17, 18, 19, 20 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        for (int j = 0; j < 6; j++)
//        {
//            int maxElement = matrix[0, j];
//            for (int i = 1; i < 5; i++)
//            {
//                if (matrix[i, j] > maxElement)
//                {
//                    maxElement = matrix[i, j];
//                }
//            }
//            Console.WriteLine($"Наибольший элемент в столбце {j + 1}: {maxElement}");
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 14: Индексы первого наименьшего элемента массива");

//        int[,] matrix = new int[5, 6]
//        {
//            { 5, 3, 8, 1, 2, 7 },
//            { 6, 2, 9, 4, 7, 1 },
//            { 7, 0, 1, 5, 3, 9 },
//            { 11, 12, 13, 14, 15, 16 },
//            { 15, 16, 17, 18, 19, 20 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int minElement = matrix[0, 0];
//        int minRow = 0;
//        int minCol = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                if (matrix[i, j] < minElement)
//                {
//                    minElement = matrix[i, j];
//                    minRow = i;
//                    minCol = j;
//                }
//            }
//        }

//        Console.WriteLine($"Первый наименьший элемент: {minElement}");
//        Console.WriteLine($"Индексы: [{minRow}, {minCol}]");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 15: Сумма элементов последнего столбца");

//        int[,] matrix = new int[5, 6]
//        {
//            { 5, 3, 8, 1, 2, 7 },
//            { 6, 2, 9, 4, 7, 1 },
//            { 7, 0, 1, 5, 3, 9 },
//            { 11, 12, 13, 14, 15, 16 },
//            { 15, 16, 17, 18, 19, 20 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int sum = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            sum += matrix[i, 5];
//        }

//        Console.WriteLine($"Сумма элементов последнего столбца: {sum}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 16: Произведение элементов первой строки");

//        int[,] matrix = new int[5, 6]
//        {
//            { 5, 3, 8, 1, 2, 7 },
//            { 6, 2, 9, 4, 7, 1 },
//            { 7, 0, 1, 5, 3, 9 },
//            { 11, 12, 13, 14, 15, 16 },
//            { 15, 16, 17, 18, 19, 20 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int product = 1;
//        for (int j = 0; j < 6; j++)
//        {
//            product *= matrix[0, j];
//        }

//        Console.WriteLine($"Произведение элементов первой строки: {product}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 17: Сумма элементов каждой строки");

//        int[,] matrix = new int[10, 10]
//        {
//            { 5, 3, 8, 1, 2, 7, 4, 6, 9, 10 },
//            { 6, 2, 9, 4, 7, 1, 5, 3, 8, 11 },
//            { 7, 0, 1, 5, 3, 9, 2, 4, 6, 12 },
//            { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
//            { 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 },
//            { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 },
//            { 35, 36, 37, 38, 39, 40, 41, 42, 43, 44 },
//            { 45, 46, 47, 48, 49, 50, 51, 52, 53, 54 },
//            { 55, 56, 57, 58, 59, 60, 61, 62, 63, 64 },
//            { 65, 66, 67, 68, 69, 70, 71, 72, 73, 74 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        for (int i = 0; i < 10; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < 10; j++)
//            {
//                sum += matrix[i, j];
//            }
//            Console.WriteLine($"Сумма элементов строки {i + 1}: {sum}");
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 18: Строка с наименьшей суммой элементов");

//        int[,] matrix = new int[4, 4]
//        {
//            { 5, 3, 8, 1 },
//            { 6, 2, 9, 4 },
//            { 7, 0, 1, 5 },
//            { 11, 12, 13, 14 }
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int minSum = int.MaxValue;
//        int minSumRow = 0;

//        for (int i = 0; i < 4; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < 4; j++)
//            {
//                sum += matrix[i, j];
//            }
//            if (sum < minSum)
//            {
//                minSum = sum;
//                minSumRow = i;
//            }
//        }

//        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 19: Строка с наименьшей суммой элементов");

//        int[,] matrix = new int[7, 7];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int minSum = int.MaxValue;
//        int minSumRow = 0;

//        for (int i = 0; i < 7; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < 7; j++)
//            {
//                sum += matrix[i, j];
//            }
//            if (sum < minSum)
//            {
//                minSum = sum;
//                minSumRow = i;
//            }
//        }

//        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRow + 1}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 20: Произведение положительных элементов первого столбца");

//        int[,] matrix = new int[6, 8];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                matrix[i, j] = random.Next(-10, 11);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        long product = 1;
//        bool hasPositive = false;

//        for (int i = 0; i < 6; i++)
//        {
//            if (matrix[i, 0] > 0)
//            {
//                product *= matrix[i, 0];
//                hasPositive = true;
//            }
//        }

//        if (hasPositive)
//        {
//            Console.WriteLine($"\nПроизведение положительных элементов первого столбца: {product}");
//        }
//        else
//        {
//            Console.WriteLine("\nВ первом столбце нет положительных элементов.");
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 21: Сумма каждого столбца матрицы");

//        int[,] matrix = new int[4, 6];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        Console.WriteLine("\nСумма каждого столбца:");
//        for (int j = 0; j < 6; j++)
//        {
//            int sum = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                sum += matrix[i, j];
//            }
//            Console.WriteLine($"Столбец {j + 1}: {sum}");
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 22: Минимальное значение среди сумм элементов всех строк");

//        int[,] matrix = new int[5, 10];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int minSum = int.MaxValue;

//        for (int i = 0; i < 5; i++)
//        {
//            int sum = 0;
//            for (int j = 0; j < 10; j++)
//            {
//                sum += matrix[i, j];
//            }
//            if (sum < minSum)
//            {
//                minSum = sum;
//            }
//        }

//        Console.WriteLine($"\nМинимальное значение среди сумм элементов всех строк: {minSum}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 10; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 23: Количество элементов, превосходящих среднее арифметическое значение");

//        int n = 4, m = 5;
//        int[,] matrix = new int[n, m];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                sum += matrix[i, j];
//            }
//        }
//        double average = (double)sum / (n * m);

//        int count = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (matrix[i, j] > average)
//                {
//                    count++;
//                }
//            }
//        }

//        Console.WriteLine($"\nСреднее арифметическое значение элементов матрицы: {average:F2}");
//        Console.WriteLine($"Количество элементов, превосходящих среднее арифметическое значение: {count}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int n = matrix.GetLength(0);
//        int m = matrix.GetLength(1);
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 24: Сумма элементов второй строки");

//        int N = 5, M = 4;
//        int[,] matrix = new int[N, M];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < M; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int sum = 0;
//        for (int j = 0; j < M; j++)
//        {
//            sum += matrix[1, j];
//        }

//        Console.WriteLine($"\nСумма элементов второй строки: {sum}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int N = matrix.GetLength(0);
//        int M = matrix.GetLength(1);
//        for (int i = 0; i < N; i++)
//        {
//            for (int j = 0; j < M; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 25: Количество отрицательных элементов во втором столбце");

//        int[,] matrix = new int[4, 4];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                matrix[i, j] = random.Next(-10, 11);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int negativeCount = 0;
//        for (int i = 0; i < 4; i++)
//        {
//            if (matrix[i, 1] < 0)
//            {
//                negativeCount++;
//            }
//        }

//        Console.WriteLine($"\nКоличество отрицательных элементов во втором столбце: {negativeCount}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 26: Количество элементов каждого столбца матрицы");

//        int[,] matrix = new int[3, 7];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        Console.WriteLine("\nКоличество элементов каждого столбца:");
//        for (int j = 0; j < 7; j++)
//        {
//            Console.WriteLine($"Столбец {j + 1}: 3 элемента");
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 27: Сумма нечетных элементов матрицы");

//        int[,] matrix = new int[4, 5];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int sum = 0;
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (matrix[i, j] % 2 != 0)
//                {
//                    sum += matrix[i, j];
//                }
//            }
//        }

//        Console.WriteLine($"\nСумма нечетных элементов матрицы: {sum}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 28: Перестановка 4 и 5 строк матрицы");

//        int[,] matrix = new int[5, 5];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        // Перестановка 4 и 5 строк
//        for (int j = 0; j < 5; j++)
//        {
//            int temp = matrix[3, j];
//            matrix[3, j] = matrix[4, j];
//            matrix[4, j] = temp;
//        }

//        Console.WriteLine("\nМатрица после перестановки 4 и 5 строк:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 29: Столбец с наименьшей суммой элементов");

//        int[,] matrix = new int[4, 5];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                matrix[i, j] = random.Next(1, 21);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int minSum = int.MaxValue;
//        int minSumCol = 0;

//        for (int j = 0; j < 5; j++)
//        {
//            int sum = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                sum += matrix[i, j];
//            }
//            if (sum < minSum)
//            {
//                minSum = sum;
//                minSumCol = j;
//            }
//        }

//        Console.WriteLine($"\nСтолбец с наименьшей суммой элементов: {minSumCol + 1}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 30: Количество неотрицательных элементов во втором столбце");

//        int[,] matrix = new int[5, 5];
//        Random random = new Random();

//        // Заполнение матрицы случайными числами
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                matrix[i, j] = random.Next(-10, 11);
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        int nonNegativeCount = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            if (matrix[i, 1] >= 0)
//            {
//                nonNegativeCount++;
//            }
//        }

//        Console.WriteLine($"\nКоличество неотрицательных элементов во втором столбце: {nonNegativeCount}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write($"{matrix[i, j],4}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 3: Заполнение массива по спирали");

//        int n = 4;
//        int[,] matrix = new int[n, n];

//        int value = 1;
//        int minRow = 0, maxRow = n - 1;
//        int minCol = 0, maxCol = n - 1;

//        while (value <= n * n)
//        {
//            // Заполнение верхней строки слева направо
//            for (int i = minCol; i <= maxCol; i++)
//            {
//                matrix[minRow, i] = value++;
//            }
//            minRow++;

//            // Заполнение правого столбца сверху вниз
//            for (int i = minRow; i <= maxRow; i++)
//            {
//                matrix[i, maxCol] = value++;
//            }
//            maxCol--;

//            // Заполнение нижней строки справа налево
//            for (int i = maxCol; i >= minCol; i--)
//            {
//                matrix[maxRow, i] = value++;
//            }
//            maxRow--;

//            // Заполнение левого столбца снизу вверх
//            for (int i = maxRow; i >= minRow; i--)
//            {
//                matrix[i, minCol] = value++;
//            }
//            minCol++;
//        }

//        Console.WriteLine("Заполненный массив:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]:D2} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 4: Удаление строк массива без повторяющихся элементов");

//        int[,] matrix = {
//            {1, 2, 3, 4},
//            {2, 2, 3, 4},
//            {5, 6, 7, 8},
//            {1, 1, 2, 2},
//            {3, 4, 5, 6}
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        List<int[]> newMatrix = new List<int[]>();

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            bool hasDuplicate = false;
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                for (int k = j + 1; k < matrix.GetLength(1); k++)
//                {
//                    if (matrix[i, j] == matrix[i, k])
//                    {
//                        hasDuplicate = true;
//                        break;
//                    }
//                }
//                if (hasDuplicate) break;
//            }
//            if (hasDuplicate)
//            {
//                int[] row = new int[matrix.GetLength(1)];
//                for (int j = 0; j < matrix.GetLength(1); j++)
//                {
//                    row[j] = matrix[i, j];
//                }
//                newMatrix.Add(row);
//            }
//        }

//        Console.WriteLine("\nМатрица после удаления строк без повторяющихся элементов:");
//        PrintNewMatrix(newMatrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]} ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void PrintNewMatrix(List<int[]> newMatrix)
//    {
//        foreach (var row in newMatrix)
//        {
//            foreach (var element in row)
//            {
//                Console.Write($"{element} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 5: Заполнение массива 3x3 по спирали начиная с центра");

//        int n = 3;
//        int[,] matrix = new int[n, n];

//        int center = n / 2;
//        int value = 1;
//        matrix[center, center] = value++;

//        // Заполнение по спирали
//        int step = 1;
//        while (value <= n * n)
//        {
//            // Вправо
//            for (int j = center - step + 1; j <= center + step; j++)
//            {
//                if (matrix[center - step, j] == 0)
//                    matrix[center - step, j] = value++;
//            }
//            // Вниз
//            for (int i = center - step + 1; i <= center + step; i++)
//            {
//                if (matrix[i, center + step] == 0)
//                    matrix[i, center + step] = value++;
//            }
//            // Влево
//            for (int j = center + step - 1; j >= center - step; j--)
//            {
//                if (matrix[center + step, j] == 0)
//                    matrix[center + step, j] = value++;
//            }
//            // Вверх
//            for (int i = center + step - 1; i >= center - step; i--)
//            {
//                if (matrix[i, center - step] == 0)
//                    matrix[i, center - step] = value++;
//            }
//            step++;
//        }

//        Console.WriteLine("Заполненный массив:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]:D2} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 6: Удаление ряда с минимальным элементом главной диагонали");

//        int[,] matrixA = {
//            {5, 7, 3},
//            {6, 1, 2},
//            {9, 4, 8}
//        };

//        Console.WriteLine("Исходная матрица A:");
//        PrintMatrix(matrixA);

//        int minDiagonalElement = matrixA[0, 0];
//        int minRow = 0;

//        for (int i = 1; i < matrixA.GetLength(0); i++)
//        {
//            if (matrixA[i, i] < minDiagonalElement)
//            {
//                minDiagonalElement = matrixA[i, i];
//                minRow = i;
//            }
//        }

//        List<int[]> matrixB = new List<int[]>();

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            if (i != minRow)
//            {
//                int[] row = new int[matrixA.GetLength(1)];
//                for (int j = 0; j < matrixA.GetLength(1); j++)
//                {
//                    row[j] = matrixA[i, j];
//                }
//                matrixB.Add(row);
//            }
//        }

//        Console.WriteLine("\nМатрица B после удаления ряда:");
//        PrintNewMatrix(matrixB);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]} ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void PrintNewMatrix(List<int[]> matrix)
//    {
//        foreach (var row in matrix)
//        {
//            foreach (var element in row)
//            {
//                Console.Write($"{element} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 7: Заполнение квадратной матрицы по спирали против часовой стрелки");

//        int n = 4;
//        int[,] matrix = new int[n, n];

//        int value = 1;
//        int minRow = 0, maxRow = n - 1;
//        int minCol = 0, maxCol = n - 1;

//        while (value <= n * n)
//        {
//            // Заполнение левого столбца снизу вверх
//            for (int i = maxRow; i >= minRow; i--)
//            {
//                matrix[i, minCol] = value++;
//            }
//            minCol++;

//            // Заполнение нижней строки слева направо
//            for (int j = minCol; j <= maxCol; j++)
//            {
//                matrix[minRow, j] = value++;
//            }
//            minRow++;

//            // Заполнение правого столбца сверху вниз
//            for (int i = minRow; i <= maxRow; i++)
//            {
//                matrix[i, maxCol] = value++;
//            }
//            maxCol--;

//            // Заполнение верхней строки справа налево
//            for (int j = maxCol; j >= minCol; j--)
//            {
//                matrix[maxRow, j] = value++;
//            }
//            maxRow--;
//        }

//        Console.WriteLine("Заполненный массив:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]:D2} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 8: Заполнение квадратной матрицы по спирали по часовой стрелке");

//        int n = 4;
//        int[,] matrix = new int[n, n];

//        int value = 1;
//        int minRow = 0, maxRow = n - 1;
//        int minCol = 0, maxCol = n - 1;

//        while (value <= n * n)
//        {
//            // Заполнение верхней строки слева направо
//            for (int i = minCol; i <= maxCol; i++)
//            {
//                matrix[minRow, i] = value++;
//            }
//            minRow++;

//            // Заполнение правого столбца сверху вниз
//            for (int i = minRow; i <= maxRow; i++)
//            {
//                matrix[i, maxCol] = value++;
//            }
//            maxCol--;

//            // Заполнение нижней строки справа налево
//            for (int i = maxCol; i >= minCol; i--)
//            {
//                matrix[maxRow, i] = value++;
//            }
//            maxRow--;

//            // Заполнение левого столбца снизу вверх
//            for (int i = maxRow; i >= minRow; i--)
//            {
//                matrix[i, minCol] = value++;
//            }
//            minCol++;
//        }

//        Console.WriteLine("Заполненный массив:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]:D2} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 9: Одномерный массив B из номеров строк массива A(M,N)");

//        int M = 3, N = 4;
//        int[,] matrixA = {
//            {1, 2, 3, 4},
//            {5, 6, 7, 8},
//            {9, 10, 11, 12}
//        };

//        Console.WriteLine("Исходная матрица A:");
//        PrintMatrix(matrixA);

//        int[] arrayB = new int[M];
//        for (int i = 0; i < M; i++)
//        {
//            arrayB[i] = i + 1;
//        }

//        Console.WriteLine("\nМассив B:");
//        Console.WriteLine("[" + string.Join(", ", arrayB) + "]");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j]} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 10: Элементы матрицы, превышающие по абсолютной величине заданное число B");

//        int[,] matrixA = {
//            {1, -22, 3, 4},
//            {5, 6, -7, 8},
//            {9, 10, 11, 12}
//        };

//        Console.WriteLine("Исходная матрица A:");
//        PrintMatrix(matrixA);

//        Console.Write("Введите число B: ");
//        int B = int.Parse(Console.ReadLine());

//        List<int> elementsC = new List<int>();

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrixA.GetLength(1); j++)
//            {
//                if (Math.Abs(matrixA[i, j]) > B)
//                {
//                    elementsC.Add(matrixA[i, j]);
//                }
//            }
//        }

//        Console.WriteLine("\nЭлементы, превышающие по абсолютной величине число B:");
//        Console.WriteLine("[" + string.Join(", ", elementsC) + "]");
//        Console.WriteLine($"Количество таких элементов: {elementsC.Count}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 11: Элементы матрицы, равные введенному числу");

//        int[,] matrixA = {
//            {1, 2, 3, 4},
//            {5, 6, 7, 8},
//            {9, 10, 11, 12}
//        };

//        Console.WriteLine("Исходная матрица A:");
//        PrintMatrix(matrixA);

//        Console.Write("Введите число: ");
//        int number = int.Parse(Console.ReadLine());

//        List<int[]> positions = new List<int[]>();

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrixA.GetLength(1); j++)
//            {
//                if (matrixA[i, j] == number)
//                {
//                    positions.Add(new int[] { i, j });
//                }
//            }
//        }

//        Console.WriteLine("\nПозиции элементов, равных введенному числу:");
//        foreach (var pos in positions)
//        {
//            Console.WriteLine($"Строка: {pos[0]}, Столбец: {pos[1]}");
//        }
//        Console.WriteLine($"Количество таких элементов: {positions.Count}");
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 12: Деление всех элементов матрицы на ее наибольший по модулю элемент");

//        double[,] matrixA = {
//            {1.0, -22.0, 3.0, 4.0},
//            {5.0, 6.0, -7.0, 8.0},
//            {9.0, 10.0, 11.0, 12.0}
//        };

//        Console.WriteLine("Исходная матрица A:");
//        PrintMatrix(matrixA);

//        double maxAbsElement = Math.Abs(matrixA[0, 0]);

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrixA.GetLength(1); j++)
//            {
//                if (Math.Abs(matrixA[i, j]) > maxAbsElement)
//                {
//                    maxAbsElement = Math.Abs(matrixA[i, j]);
//                }
//            }
//        }

//        double[,] matrixB = new double[matrixA.GetLength(0), matrixA.GetLength(1)];

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrixA.GetLength(1); j++)
//            {
//                matrixB[i, j] = matrixA[i, j] / maxAbsElement;
//            }
//        }

//        Console.WriteLine("\nМатрица B после деления на наибольший по модулю элемент:");
//        PrintMatrix(matrixB);
//    }

//    static void PrintMatrix(double[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],8:F4} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 13: Вставка первой строки после строки с первым минимальным элементом");

//        int[,] matrixA = {
//            {1, 2, 3, 4},
//            {5, 6, 7, 8},
//            {9, 10, 1, 12},
//            {13, 14, 15, 16}
//        };

//        Console.WriteLine("Исходная матрица A:");
//        PrintMatrix(matrixA);

//        int minElement = matrixA[0, 0];
//        int minRow = 0;

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrixA.GetLength(1); j++)
//            {
//                if (matrixA[i, j] < minElement)
//                {
//                    minElement = matrixA[i, j];
//                    minRow = i;
//                    break;
//                }
//            }
//        }

//        List<int[]> matrixB = new List<int[]>();

//        for (int i = 0; i < matrixA.GetLength(0); i++)
//        {
//            int[] row = new int[matrixA.GetLength(1)];
//            for (int j = 0; j < matrixA.GetLength(1); j++)
//            {
//                row[j] = matrixA[i, j];
//            }
//            matrixB.Add(row);
//            if (i == minRow)
//            {
//                matrixB.Add((int[])matrixA.GetRow(0).Clone());
//            }
//        }

//        Console.WriteLine("\nМатрица B после вставки первой строки:");
//        PrintNewMatrix(matrixB);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4} ");
//            }
//            Console.WriteLine();
//        }
//    }

//    static void PrintNewMatrix(List<int[]> matrix)
//    {
//        foreach (var row in matrix)
//        {
//            foreach (var element in row)
//            {
//                Console.Write($"{element,4} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//static class MatrixExtensions
//{
//    public static T[] GetRow<T>(this T[,] matrix, int row)
//    {
//        var rowLength = matrix.GetLength(1);
//        var rowVector = new T[rowLength];

//        for (var i = 0; i < rowLength; i++)
//            rowVector[i] = matrix[row, i];

//        return rowVector;
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 14: Произведение элементов матрицы, расположенных ниже левой диагонали");

//        double[,] matrixB = {
//            {1.0, 2.0, 3.0, 4.0, 5.0},
//            {6.0, 7.0, 8.0, 9.0, 10.0},
//            {11.0, 12.0, 13.0, 14.0, 15.0},
//            {16.0, 17.0, 18.0, 19.0, 20.0},
//            {21.0, 22.0, 23.0, 24.0, 25.0}
//        };

//        Console.WriteLine("Исходная матрица B:");
//        PrintMatrix(matrixB);

//        double product = 1;

//        for (int i = 1; i < matrixB.GetLength(0); i++)
//        {
//            for (int j = 0; j < i; j++)
//            {
//                product *= matrixB[i, j];
//            }
//        }

//        Console.WriteLine($"\nПроизведение элементов ниже левой диагонали: {product}");
//    }

//    static void PrintMatrix(double[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],8:F1} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 15: Сумма элементов массива, расположенных выше левой диагонали");

//        double[,] matrixB = {
//            {1.0, 2.0, 3.0, 4.0, 5.0},
//            {6.0, 7.0, 8.0, 9.0, 10.0},
//            {11.0, 12.0, 13.0, 14.0, 15.0},
//            {16.0, 17.0, 18.0, 19.0, 20.0},
//            {21.0, 22.0, 23.0, 24.0, 25.0}
//        };

//        Console.WriteLine("Исходная матрица B:");
//        PrintMatrix(matrixB);

//        double sum = 0;

//        for (int i = 0; i < matrixB.GetLength(0); i++)
//        {
//            for (int j = i + 1; j < matrixB.GetLength(1); j++)
//            {
//                sum += matrixB[i, j];
//            }
//        }

//        Console.WriteLine($"\nСумма элементов выше левой диагонали: {sum}");
//    }

//    static void PrintMatrix(double[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],8:F1} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Задача 16: Замена отрицательных элементов первой строки числом 0");

//        int[,] matrix = {
//            {1, -2, 3, -4, 5},
//            {6, 7, 8, 9, 10},
//            {11, 12, 13, 14, 15},
//            {16, 17, 18, 19, 20},
//            {21, 22, 23, 24, 25}
//        };

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            if (matrix[0, j] < 0)
//            {
//                matrix[0, j] = 0;
//            }
//        }

//        Console.WriteLine("\nМатрица после замены отрицательных элементов первой строки:");
//        PrintMatrix(matrix);
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4} ");
//            }
//            Console.WriteLine();
//        }
//    }
//}
