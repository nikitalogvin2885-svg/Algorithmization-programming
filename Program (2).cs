using System;

//11
//static int MinArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    int min = array[0];
//    foreach (int num in array)
//    {
//        if (num < min)
//            min = num;
//    }
//    return min;
//}

//12
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//13
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//14
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//15
//static bool IsPrime(int n)
//{
//    if (n <= 1) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0)
//            return false;
//    }
//    return true;
//}

//16
//static int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}

//17
//static bool Contains(int[] array, int element)
//{
//    if (array == null)
//        return false;
//    foreach (int num in array)
//    {
//        if (num == element)
//            return true;
//    }
//    return false;
//}

//18
//static int Abs(int n)
//{
//    return n < 0 ? -n : n;
//}

//19
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//20
//static string ReverseString(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    char[] chars = str.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

//21
//static bool IsPrime(int n)
//{
//    if (n <= 1) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0)
//            return false;
//    }
//    return true;
//}

//22
//static string ReverseString(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    char[] chars = str.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

//23
//static int MinArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    int min = array[0];
//    foreach (int num in array)
//    {
//        if (num < min)
//            min = num;
//    }
//    return min;
//}

//24
//static int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}

//25
//static void SortArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return;
//    Array.Sort(array);
//}

//26
//static int CountArrayElements(int[] array)
//{
//    return array == null ? 0 : array.Length;
//}

//27
//static int GetStringLength(string str)
//{
//    return string.IsNullOrEmpty(str) ? 0 : str.Length;
//}

//28
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//29
//static string ConcatenateStrings(string str1, string str2)
//{
//    return str1 + str2;
//}

//30
//static int MinArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    int min = array[0];
//    foreach (int num in array)
//    {
//        if (num < min)
//            min = num;
//    }
//    return min;
//}

//31
//static double RectangleArea(double width, double height)
//{
//    return width * height;
//}

//32
//static int GetStringLength(string str)
//{
//    return string.IsNullOrEmpty(str) ? 0 : str.Length;
//}

//33
//static void PrintMultiplicationTable(int n)
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{n} x {i} = {n * i}");
//    }
//}

//34
//static bool IsPrime(int n)
//{
//    if (n <= 1) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0)
//            return false;
//    }
//    return true;
//}

//35
//static bool IsPrime(int n)
//{
//    if (n <= 1) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0)
//            return false;
//    }
//    return true;
//}

//36
//static int Square(int n)
//{
//    return n * n;
//}

//37
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//38
//static int CountVowels(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return 0;
//    int count = 0;
//    string vowels = "aeiouAEIOU";
//    foreach (char c in str)
//    {
//        if (vowels.Contains(c))
//            count++;
//    }
//    return count;
//}

//39
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//40
//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    string reversed = ReverseString(str);
//    return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
//}

//41
//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    string reversed = ReverseString(str);
//    return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
//}

//42
//static int Abs(int n)
//{
//    return n < 0 ? -n : n;
//}

//43
//static int GetStringLength(string str)
//{
//    return string.IsNullOrEmpty(str) ? 0 : str.Length;
//}

//44
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//45
//static void SortArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return;
//    Array.Sort(array);
//}

//46
//static string ReverseString(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    char[] chars = str.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

//47
//static int Square(int n)
//{
//    return n * n;
//}

//48
//static int CountVowels(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return 0;
//    int count = 0;
//    string vowels = "aeiouAEIOU";
//    foreach (char c in str)
//    {
//        if (vowels.Contains(c))
//            count++;
//    }
//    return count;
//}

//49
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//50
//static string ReverseString(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    char[] chars = str.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

//51
//static double CelsiusToFahrenheit(double celsius)
//{
//    return (celsius * 9 / 5) + 32;
//}

//52
//static int Abs(int n)
//{
//    return n < 0 ? -n : n;
//}

//53
//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    string reversed = ReverseString(str);
//    return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
//}

//54
//static int CountArrayElements(int[] array)
//{
//    return array == null ? 0 : array.Length;
//}

//55
//static bool IsPrime(int n)
//{
//    if (n <= 1) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0)
//            return false;
//    }
//    return true;
//}

//56
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//57
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//58
//static int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}

//59
//static double CelsiusToFahrenheit(double celsius)
//{
//    return (celsius * 9 / 5) + 32;
//}

//60
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//61
//static int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}

//62
//static int Square(int n)
//{
//    return n * n;
//}

//63
//static int CountVowels(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return 0;
//    int count = 0;
//    string vowels = "aeiouAEIOU";
//    foreach (char c in str)
//    {
//        if (vowels.Contains(c))
//            count++;
//    }
//    return count;
//}

//64
//static int GetStringLength(string str)
//{
//    return string.IsNullOrEmpty(str) ? 0 : str.Length;
//}

//65
//static void SortArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return;
//    Array.Sort(array);
//}

//66
//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    string reversed = ReverseString(str);
//    return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
//}

//67
//static string ConcatenateStrings(string str1, string str2)
//{
//    return str1 + str2;
//}

//68
//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    string reversed = ReverseString(str);
//    return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
//}

//69
//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    string reversed = ReverseString(str);
//    return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
//}

//70
//static bool IsPrime(int n)
//{
//    if (n <= 1) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0)
//            return false;
//    }
//    return true;
//}

//71
//static int GetStringLength(string str)
//{
//    return string.IsNullOrEmpty(str) ? 0 : str.Length;
//}

//72
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//73
//static int Abs(int n)
//{
//    return n < 0 ? -n : n;
//}

//74
//static string ConcatenateStrings(string str1, string str2)
//{
//    return str1 + str2;
//}

//75
//static string ReverseString(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    char[] chars = str.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

//76
//static int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}

//77
//static string ConcatenateStrings(string str1, string str2)
//{
//    return str1 + str2;
//}

//78
//static void SortArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return;
//    Array.Sort(array);
//}

//79
//static int CountVowels(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return 0;
//    int count = 0;
//    string vowels = "aeiouAEIOU";
//    foreach (char c in str)
//    {
//        if (vowels.Contains(c))
//            count++;
//    }
//    return count;
//}

//80
//static int GetStringLength(string str)
//{
//    return string.IsNullOrEmpty(str) ? 0 : str.Length;
//}

//81
//static string ReverseString(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    char[] chars = str.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

//82
//static int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}

//83
//static double RectangleArea(double width, double height)
//{
//    return width * height;
//}

//84
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//85
//static int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int temp = b;
//        b = a % b;
//        a = temp;
//    }
//    return a;
//}

//86
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//87
//static double RectangleArea(double width, double height)
//{
//    return width * height;
//}

//88
//static int CountVowels(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return 0;
//    int count = 0;
//    string vowels = "aeiouAEIOU";
//    foreach (char c in str)
//    {
//        if (vowels.Contains(c))
//            count++;
//    }
//    return count;
//}

//89
//static int GetStringLength(string str)
//{
//    return string.IsNullOrEmpty(str) ? 0 : str.Length;
//}

//90
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//91
//static bool IsPrime(int n)
//{
//    if (n <= 1) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0)
//            return false;
//    }
//    return true;
//}

//92
//static int CountArrayElements(int[] array)
//{
//    return array == null ? 0 : array.Length;
//}

//93
//static double RectangleArea(double width, double height)
//{
//    return width * height;
//}

//94
//static bool IsPrime(int n)
//{
//    if (n <= 1) return false;
//    for (int i = 2; i * i <= n; i++)
//    {
//        if (n % i == 0)
//            return false;
//    }
//    return true;
//}

//95
//static double AverageArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    int sum = 0;
//    foreach (int num in array)
//    {
//        sum += num;
//    }
//    return (double)sum / array.Length;
//}

//96
//static int CountVowels(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return 0;
//    int count = 0;
//    string vowels = "aeiouAEIOU";
//    foreach (char c in str)
//    {
//        if (vowels.Contains(c))
//            count++;
//    }
//    return count;
//}

//97
//static void SortArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return;
//    Array.Sort(array);
//}

//98
//static void PrintMultiplicationTable(int n)
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{n} x {i} = {n * i}");
//    }
//}

//99
//static int GetStringLength(string str)
//{
//    return string.IsNullOrEmpty(str) ? 0 : str.Length;
//}

//100
//static void PrintMultiplicationTable(int n)
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{n} x {i} = {n * i}");
//    }
//}

//101
//static bool IsPalindromeRecursive(string str, int left, int right)
//{
//    if (left >= right)
//        return true;
//    if (str[left] != str[right])
//        return false;
//    return IsPalindromeRecursive(str, left + 1, right - 1);
//}

//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    return IsPalindromeRecursive(str, 0, str.Length - 1);
//}

//102
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }

//    GenerateSubsets(array, index + 1, current, result);

//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//103
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }

//    GenerateSubsets(array, index + 1, current, result);

//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//104
//static int SumRecursive(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumRecursive(n - 1);
//}

//105
//static int BinomialCoefficient(int n, int k)
//{
//    if (k == 0 || k == n)
//        return 1;
//    return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
//}

//106
//static int SumArrayRecursive(int[] array, int index)
//{
//    if (index == array.Length)
//        return 0;
//    return array[index] + SumArrayRecursive(array, index + 1);
//}

//107
//static int BinomialCoefficient(int n, int k)
//{
//    if (k == 0 || k == n)
//        return 1;
//    return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
//}

//108
//static bool IsSortedRecursive(int[] array, int index)
//{
//    if (index == array.Length - 1)
//        return true;
//    if (array[index] > array[index + 1])
//        return false;
//    return IsSortedRecursive(array, index + 1);
//}

//static bool IsSorted(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return true;
//    return IsSortedRecursive(array, 0);
//}

//109
//static int MaxRecursive(int[] array, int index, int max)
//{
//    if (index == array.Length)
//        return max;
//    if (array[index] > max)
//        max = array[index];
//    return MaxRecursive(array, index + 1, max);
//}

//static int MaxArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    return MaxRecursive(array, 0, array[0]);
//}

//110
//static bool IsPalindromeRecursive(string str, int left, int right)
//{
//    if (left >= right)
//        return true;
//    if (str[left] != str[right])
//        return false;
//    return IsPalindromeRecursive(str, left + 1, right - 1);
//}

//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    return IsPalindromeRecursive(str, 0, str.Length - 1);
//}

//111
//static int GCDRecursive(int a, int b)
//{
//    if (b == 0)
//        return a;
//    return GCDRecursive(b, a % b);
//}

//112
//static void Hanoi(int n, char from, char to, char aux)
//{
//    if (n == 1)
//    {
//        Console.WriteLine($"Move disk 1 from {from} to {to}");
//        return;
//    }
//    Hanoi(n - 1, from, aux, to);
//    Console.WriteLine($"Move disk {n} from {from} to {to}");
//    Hanoi(n - 1, aux, to, from);
//}

//113
//static int PascalTriangle(int row, int col)
//{
//    if (col == 0 || col == row)
//        return 1;
//    return PascalTriangle(row - 1, col - 1) + PascalTriangle(row - 1, col);
//}

//114
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//115
//static int Fibonacci(int n)
//{
//    if (n <= 1)
//        return n;
//    return Fibonacci(n - 1) + Fibonacci(n - 2);
//}

//116
//static int SumOfDigits(int number)
//{
//    if (number < 10)
//        return number;

//    return number % 10 + SumOfDigits(number / 10);
//}

//117
//static int GCDRecursive(int a, int b)
//{
//    if (b == 0)
//        return a;
//    return GCDRecursive(b, a % b);
//}

//118
//static string ReverseStringRecursive(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    return ReverseStringRecursive(str.Substring(1)) + str[0];
//}

//119
//static int SumArrayRecursive(int[] array, int index)
//{
//    if (index == array.Length)
//        return 0;
//    return array[index] + SumArrayRecursive(array, index + 1);
//}

//120
//static bool IsSubstringRecursive(string text, string sub, int textIndex, int subIndex)
//{
//    if (subIndex == sub.Length)
//        return true;
//    if (textIndex == text.Length)
//        return false;
//    if (text[textIndex] == sub[subIndex])
//        return IsSubstringRecursive(text, sub, textIndex + 1, subIndex + 1);
//    return IsSubstringRecursive(text, sub, textIndex + 1, 0);
//}

//static bool IsSubstring(string text, string sub)
//{
//    if (string.IsNullOrEmpty(sub))
//        return true;
//    return IsSubstringRecursive(text, sub, 0, 0);
//}

//121
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//122
//static bool IsSortedRecursive(int[] array, int index)
//{
//    if (index == array.Length - 1)
//        return true;
//    if (array[index] > array[index + 1])
//        return false;
//    return IsSortedRecursive(array, index + 1);
//}

//static bool IsSorted(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return true;
//    return IsSortedRecursive(array, 0);
//}

//123
//static bool IsSortedRecursive(int[] array, int index)
//{
//    if (index == array.Length - 1)
//        return true;
//    if (array[index] > array[index + 1])
//        return false;
//    return IsSortedRecursive(array, index + 1);
//}

//static bool IsSorted(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return true;
//    return IsSortedRecursive(array, 0);
//}

//124
//static bool IsSubstringRecursive(string text, string sub, int textIndex, int subIndex)
//{
//    if (subIndex == sub.Length)
//        return true;
//    if (textIndex == text.Length)
//        return false;
//    if (text[textIndex] == sub[subIndex])
//        return IsSubstringRecursive(text, sub, textIndex + 1, subIndex + 1);
//    return IsSubstringRecursive(text, sub, textIndex + 1, 0);
//}

//static bool IsSubstring(string text, string sub)
//{
//    if (string.IsNullOrEmpty(sub))
//        return true;
//    return IsSubstringRecursive(text, sub, 0, 0);
//}

//125
//static string ToBinary(int n)
//{
//    if (n == 0)
//        return "0";
//    if (n == 1)
//        return "1";
//    return ToBinary(n / 2) + (n % 2).ToString();
//}

//126
//static void Hanoi(int n, char from, char to, char aux)
//{
//    if (n == 1)
//    {
//        Console.WriteLine($"Move disk 1 from {from} to {to}");
//        return;
//    }
//    Hanoi(n - 1, from, aux, to);
//    Console.WriteLine($"Move disk {n} from {from} to {to}");
//    Hanoi(n - 1, aux, to, from);
//}

//127
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//128
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }
//    GenerateSubsets(array, index + 1, current, result);
//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//129
//static int Factorial(int n)
//{
//    if (n == 0 || n == 1)
//        return 1;
//    return n * Factorial(n - 1);
//}

//131
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }
//    GenerateSubsets(array, index + 1, current, result);
//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//132
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//133
//static void PrintArrayRecursive(int[] array, int index)
//{
//    if (index >= array.Length)
//        return;
//    Console.WriteLine(array[index]);
//    PrintArrayRecursive(array, index + 1);
//}

//134
//static int ProductOfDigits(int number)
//{
//    if (number < 10)
//        return number;

//    return (number % 10) * ProductOfDigits(number / 10);
//}

//135
//static int Ackermann(int m, int n)
//{
//    if (m == 0)
//        return n + 1;
//    if (n == 0)
//        return Ackermann(m - 1, 1);
//    return Ackermann(m - 1, Ackermann(m, n - 1));
//}

//136
//static int Sum2DArrayRecursive(int[,] array, int row, int col)
//{
//    if (row >= array.GetLength(0))
//        return 0;
//    if (col >= array.GetLength(1))
//        return Sum2DArrayRecursive(array, row + 1, 0);
//    return array[row, col] + Sum2DArrayRecursive(array, row, col + 1);
//}

//static int Sum2DArray(int[,] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    return Sum2DArrayRecursive(array, 0, 0);
//}

//137
//static string ReverseStringRecursive(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    return ReverseStringRecursive(str.Substring(1)) + str[0];
//}

//138
//static string ToBinary(int n)
//{
//    if (n == 0)
//        return "0";
//    if (n == 1)
//        return "1";
//    return ToBinary(n / 2) + (n % 2).ToString();
//}

//139
//static int Factorial(int n)
//{
//    if (n == 0 || n == 1)
//        return 1;
//    return n * Factorial(n - 1);
//}

//140
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//141
//static void Hanoi(int n, char from, char to, char aux)
//{
//    if (n == 1)
//    {
//        Console.WriteLine($"Move disk 1 from {from} to {to}");
//        return;
//    }
//    Hanoi(n - 1, from, aux, to);
//    Console.WriteLine($"Move disk {n} from {from} to {to}");
//    Hanoi(n - 1, aux, to, from);
//}

//142
//static string ReverseStringRecursive(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    return ReverseStringRecursive(str.Substring(1)) + str[0];
//}

//143
//static void Hanoi(int n, char from, char to, char aux)
//{
//    if (n == 1)
//    {
//        Console.WriteLine($"Move disk 1 from {from} to {to}");
//        return;
//    }
//    Hanoi(n - 1, from, aux, to);
//    Console.WriteLine($"Move disk {n} from {from} to {to}");
//    Hanoi(n - 1, aux, to, from);
//}

//144
//static int ProductOfDigits(int number)
//{
//    if (number < 10)
//        return number;

//    return (number % 10) * ProductOfDigits(number / 10);
//}
//145
//static int Ackermann(int m, int n)
//{
//    if (m == 0)
//        return n + 1;
//    if (n == 0)
//        return Ackermann(m - 1, 1);
//    return Ackermann(m - 1, Ackermann(m, n - 1));
//}

//146
//static void Hanoi(int n, char from, char to, char aux)
//{
//    if (n == 1)
//    {
//        Console.WriteLine($"Move disk 1 from {from} to {to}");
//        return;
//    }
//    Hanoi(n - 1, from, aux, to);
//    Console.WriteLine($"Move disk {n} from {from} to {to}");
//    Hanoi(n - 1, aux, to, from);
//}

//147
//static bool IsSubstringRecursive(string text, string sub, int textIndex, int subIndex)
//{
//    if (subIndex == sub.Length)
//        return true;
//    if (textIndex == text.Length)
//        return false;
//    if (text[textIndex] == sub[subIndex])
//        return IsSubstringRecursive(text, sub, textIndex + 1, subIndex + 1);
//    return IsSubstringRecursive(text, sub, textIndex + 1, 0);
//}

//static bool IsSubstring(string text, string sub)
//{
//    if (string.IsNullOrEmpty(sub))
//        return true;
//    return IsSubstringRecursive(text, sub, 0, 0);
//}

//148
//static int CountDigits(int n)
//{
//    if (n < 10)
//        return 1;
//    return 1 + CountDigits(n / 10);
//}

//149
//static int GCDRecursive(int a, int b)
//{
//    if (b == 0)
//        return a;
//    return GCDRecursive(b, a % b);
//}

//150
//static int MaxRecursive(int[] array, int index, int max)
//{
//    if (index == array.Length)
//        return max;
//    if (array[index] > max)
//        max = array[index];
//    return MaxRecursive(array, index + 1, max);
//}

//static int MaxArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    return MaxRecursive(array, 0, array[0]);
//}

//151
//static string ReverseStringRecursive(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    return ReverseStringRecursive(str.Substring(1)) + str[0];
//}

//152
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }
//    GenerateSubsets(array, index + 1, current, result);
//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//153
//static void Hanoi(int n, char from, char to, char aux)
//{
//    if (n == 1)
//    {
//        Console.WriteLine($"Move disk 1 from {from} to {to}");
//        return;
//    }
//    Hanoi(n - 1, from, aux, to);
//    Console.WriteLine($"Move disk {n} from {from} to {to}");
//    Hanoi(n - 1, aux, to, from);
//}

//154
//static int Factorial(int n)
//{
//    if (n == 0 || n == 1)
//        return 1;
//    return n * Factorial(n - 1);
//}

//155
//static bool IsSubstringRecursive(string text, string sub, int textIndex, int subIndex)
//{
//    if (subIndex == sub.Length)
//        return true;
//    if (textIndex == text.Length)
//        return false;
//    if (text[textIndex] == sub[subIndex])
//        return IsSubstringRecursive(text, sub, textIndex + 1, subIndex + 1);
//    return IsSubstringRecursive(text, sub, textIndex + 1, 0);
//}

//static bool IsSubstring(string text, string sub)
//{
//    if (string.IsNullOrEmpty(sub))
//        return true;
//    return IsSubstringRecursive(text, sub, 0, 0);
//}

//156
//static void PrintArrayRecursive(int[] array, int index)
//{
//    if (index >= array.Length)
//        return;
//    Console.WriteLine(array[index]);
//    PrintArrayRecursive(array, index + 1);
//}

//157
//static int PascalTriangle(int row, int col)
//{
//    if (col == 0 || col == row)
//        return 1;
//    return PascalTriangle(row - 1, col - 1) + PascalTriangle(row - 1, col);
//}

//158
//static int Factorial(int n)
//{
//    if (n == 0 || n == 1)
//        return 1;
//    return n * Factorial(n - 1);
//}

//159
//static int ProductOfDigits(int number)
//{
//    if (number < 10)
//        return number;

//    return (number % 10) * ProductOfDigits(number / 10);
//}

//160
//static int MaxRecursive(int[] array, int index, int max)
//{
//    if (index == array.Length)
//        return max;
//    if (array[index] > max)
//        max = array[index];
//    return MaxRecursive(array, index + 1, max);
//}

//static int MaxArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    return MaxRecursive(array, 0, array[0]);
//}

//161
//static int Ackermann(int m, int n)
//{
//    if (m == 0)
//        return n + 1;
//    if (n == 0)
//        return Ackermann(m - 1, 1);
//    return Ackermann(m - 1, Ackermann(m, n - 1));
//}

//162
//static bool IsPalindromeRecursive(string str, int left, int right)
//{
//    if (left >= right)
//        return true;
//    if (str[left] != str[right])
//        return false;
//    return IsPalindromeRecursive(str, left + 1, right - 1);
//}

//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    return IsPalindromeRecursive(str, 0, str.Length - 1);
//}

//163
//static int Fibonacci(int n)
//{
//    if (n <= 1)
//        return n;
//    return Fibonacci(n - 1) + Fibonacci(n - 2);
//}

//164
//static bool IsPalindromeRecursive(string str, int left, int right)
//{
//    if (left >= right)
//        return true;
//    if (str[left] != str[right])
//        return false;
//    return IsPalindromeRecursive(str, left + 1, right - 1);
//}

//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    return IsPalindromeRecursive(str, 0, str.Length - 1);
//}

//165
//static int BinomialCoefficient(int n, int k)
//{
//    if (k == 0 || k == n)
//        return 1;
//    return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
//}

//166
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//167
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//168
//static int BinomialCoefficient(int n, int k)
//{
//    if (k == 0 || k == n)
//        return 1;
//    return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
//}

//169
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//170
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }
//    GenerateSubsets(array, index + 1, current, result);
//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//171
//static int GCDRecursive(int a, int b)
//{
//    if (b == 0)
//        return a;
//    return GCDRecursive(b, a % b);
//}

//172
//static int GCDRecursive(int a, int b)
//{
//    if (b == 0)
//        return a;
//    return GCDRecursive(b, a % b);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//173
//static int PascalTriangle(int row, int col)
//{
//    if (col == 0 || col == row)
//        return 1;
//    return PascalTriangle(row - 1, col - 1) + PascalTriangle(row - 1, col);
//}

//174
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }
//    GenerateSubsets(array, index + 1, current, result);
//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//175
//static string ReverseStringRecursive(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return str;
//    return ReverseStringRecursive(str.Substring(1)) + str[0];
//}

//176
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//177
//static void Hanoi(int n, char from, char to, char aux)
//{
//    if (n == 1)
//    {
//        Console.WriteLine($"Move disk 1 from {from} to {to}");
//        return;
//    }
//    Hanoi(n - 1, from, aux, to);
//    Console.WriteLine($"Move disk {n} from {from} to {to}");
//    Hanoi(n - 1, aux, to, from);
//}

//178
//static bool IsSubstringRecursive(string text, string sub, int textIndex, int subIndex)
//{
//    if (subIndex == sub.Length)
//        return true;
//    if (textIndex == text.Length)
//        return false;
//    if (text[textIndex] == sub[subIndex])
//        return IsSubstringRecursive(text, sub, textIndex + 1, subIndex + 1);
//    return IsSubstringRecursive(text, sub, textIndex + 1, 0);
//}

//static bool IsSubstring(string text, string sub)
//{
//    if (string.IsNullOrEmpty(sub))
//        return true;
//    return IsSubstringRecursive(text, sub, 0, 0);
//}

//179
//static int Sum2DArrayRecursive(int[,] array, int row, int col)
//{
//    if (row >= array.GetLength(0))
//        return 0;
//    if (col >= array.GetLength(1))
//        return Sum2DArrayRecursive(array, row + 1, 0);
//    return array[row, col] + Sum2DArrayRecursive(array, row, col + 1);
//}

//static int Sum2DArray(int[,] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    return Sum2DArrayRecursive(array, 0, 0);
//}

//180
//static int CountDigits(int n)
//{
//    if (n < 10)
//        return 1;
//    return 1 + CountDigits(n / 10);
//}

//181
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }
//    GenerateSubsets(array, index + 1, current, result);
//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//182
//static int CountDigits(int n)
//{
//    if (n < 10)
//        return 1;
//    return 1 + CountDigits(n / 10);
//}

//183
//static int Ackermann(int m, int n)
//{
//    if (m == 0)
//        return n + 1;
//    if (n == 0)
//        return Ackermann(m - 1, 1);
//    return Ackermann(m - 1, Ackermann(m, n - 1));
//}

//184
//static bool IsSortedRecursive(int[] array, int index)
//{
//    if (index == array.Length - 1)
//        return true;
//    if (array[index] > array[index + 1])
//        return false;
//    return IsSortedRecursive(array, index + 1);
//}

//static bool IsSorted(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return true;
//    return IsSortedRecursive(array, 0);
//}

//185
//static int MaxRecursive(int[] array, int index, int max)
//{
//    if (index == array.Length)
//        return max;
//    if (array[index] > max)
//        max = array[index];
//    return MaxRecursive(array, index + 1, max);
//}

//static int MaxArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//        return 0;
//    return MaxRecursive(array, 0, array[0]);
//}

//186
//static string ToBinary(int n)
//{
//    if (n == 0)
//        return "0";
//    if (n == 1)
//        return "1";
//    return ToBinary(n / 2) + (n % 2).ToString();
//}

//187
//static void Hanoi(int n, char from, char to, char aux)
//{
//    if (n == 1)
//    {
//        Console.WriteLine($"Move disk 1 from {from} to {to}");
//        return;
//    }
//    Hanoi(n - 1, from, aux, to);
//    Console.WriteLine($"Move disk {n} from {from} to {to}");
//    Hanoi(n - 1, aux, to, from);
//}

//188
//static string ToBinary(int n)
//{
//    if (n == 0)
//        return "0";
//    if (n == 1)
//        return "1";
//    return ToBinary(n / 2) + (n % 2).ToString();
//}

//189
//static int ProductOfDigits(int number)
//{
//    if (number < 10)
//        return number;

//    return (number % 10) * ProductOfDigits(number / 10);
//}

//190
//static bool IsPalindromeRecursive(string str, int left, int right)
//{
//    if (left >= right)
//        return true;
//    if (str[left] != str[right])
//        return false;
//    return IsPalindromeRecursive(str, left + 1, right - 1);
//}

//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    return IsPalindromeRecursive(str, 0, str.Length - 1);
//}

//191
//static bool IsPalindromeRecursive(string str, int left, int right)
//{
//    if (left >= right)
//        return true;
//    if (str[left] != str[right])
//        return false;
//    return IsPalindromeRecursive(str, left + 1, right - 1);
//}

//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    return IsPalindromeRecursive(str, 0, str.Length - 1);
//}

//192
//static int SumFrom1ToN(int n)
//{
//    if (n == 1)
//        return 1;
//    return n + SumFrom1ToN(n - 1);
//}

//193
//static void PrintArrayRecursive(int[] array, int index)
//{
//    if (index >= array.Length)
//        return;
//    Console.WriteLine(array[index]);
//    PrintArrayRecursive(array, index + 1);
//}

//194
//static int Factorial(int n)
//{
//    if (n == 0 || n == 1)
//        return 1;
//    return n * Factorial(n - 1);
//}

//195
//static int BinomialCoefficient(int n, int k)
//{
//    if (k == 0 || k == n)
//        return 1;
//    return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
//}

//196
//static void GenerateSubsets(int[] array, int index, List<int> current, List<List<int>> result)
//{
//    if (index == array.Length)
//    {
//        result.Add(new List<int>(current));
//        return;
//    }
//    GenerateSubsets(array, index + 1, current, result);
//    current.Add(array[index]);
//    GenerateSubsets(array, index + 1, current, result);
//    current.RemoveAt(current.Count - 1);
//}

//static List<List<int>> GetAllSubsets(int[] array)
//{
//    List<List<int>> result = new List<List<int>>();
//    GenerateSubsets(array, 0, new List<int>(), result);
//    return result;
//}

//197
//static bool IsPalindromeRecursive(string str, int left, int right)
//{
//    if (left >= right)
//        return true;
//    if (str[left] != str[right])
//        return false;
//    return IsPalindromeRecursive(str, left + 1, right - 1);
//}

//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    return IsPalindromeRecursive(str, 0, str.Length - 1);
//}

//198
//static int BinomialCoefficient(int n, int k)
//{
//    if (k == 0 || k == n)
//        return 1;
//    return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
//}

//199
//static bool IsPalindromeRecursive(string str, int left, int right)
//{
//    if (left >= right)
//        return true;
//    if (str[left] != str[right])
//        return false;
//    return IsPalindromeRecursive(str, left + 1, right - 1);
//}

//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return false;
//    return IsPalindromeRecursive(str, 0, str.Length - 1);
//}

//200
//static long Factorial(int n) { return n <= 1 ? 1 : n * Factorial(n - 1); }

//201
//static void Print(int value) { Console.WriteLine($"Int: {value}"); }
//static void Print(string value) { Console.WriteLine($"String: {value}"); }
//static void Print(double value) { Console.WriteLine($"Double: {value}"); }

//202
//static double Area(double radius) { return Math.PI * radius * radius; }
//static double Area(double width, double height) { return width * height; }

//203
//static int Multiply(int a, int b) { return a * b; }
//static double Multiply(double a, double b) { return a * b; }
//static decimal Multiply(decimal a, decimal b) { return a * b; }

//204
//static void Display(int num) { Console.WriteLine($"Number: {num}"); }
//static void Display(string text) { Console.WriteLine($"Text: {text}"); }
//static void Display(bool flag) { Console.WriteLine($"Boolean: {flag}"); }

//205
//static double CalculateArea(double radius) { return Math.PI * radius * radius; }
//static double CalculateArea(double length, double width) { return length * width; }

//206
//static double Distance(double x1, double y1, double x2, double y2) { return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); }
//static double Distance(double x1, double y1, double z1, double x2, double y2, double z2) { return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); }

//207
//static void Output(int value) { Console.WriteLine(value); }
//static void Output(string value) { Console.WriteLine(value); }
//static void Output(double value) { Console.WriteLine(value); }

//208
//static void Add(List<int> list, int item) { list.Add(item); }
//static void Add(List<int> list, params int[] items) { list.AddRange(items); }

//209
//static int Product(int x, int y) { return x * y; }
//static double Product(double x, double y) { return x * y; }
//static decimal Product(decimal x, decimal y) { return x * y; }

//210
//static string Format(DateTime date) { return date.ToString("yyyy-MM-dd"); }
//static string Format(DateTime date, string pattern) { return date.ToString(pattern); }

//211
//static decimal Discount(decimal price, decimal percent) { return price * percent / 100; }
//static decimal Discount(decimal price, int fixedAmount) { return fixedAmount; }

//212
//static void Process(int[] arr) { Array.Sort(arr); }
//static void Process(string[] arr) { Array.Sort(arr); }

//213
//static bool Validate(string email) { return email.Contains("@"); }
//static bool Validate(string phone, bool isPhone) { return phone.All(char.IsDigit); }
//static bool Validate(string url, string type) { return url.StartsWith("http"); }

//214
//static string Concat(string a, string b) { return a + b; }
//static string Concat(string a, string b, string c) { return a + b + c; }
//static string Concat(string a, string b, string c, string d) { return a + b + c + d; }

//215
//static string Encrypt(string text) { return Convert.ToBase64String(Encoding.UTF8.GetBytes(text)); }
//static string Encrypt(string text, int key) { return new string(text.Select(c => (char)(c + key)).ToArray()); }

//216
//static string EncryptText(string input) { return new string(input.Reverse().ToArray()); }
//static string EncryptText(string input, string method) { return Convert.ToBase64String(Encoding.UTF8.GetBytes(input)); }

//217
//static decimal CalculateDiscount(decimal price, decimal percentage) { return price * percentage / 100; }
//static decimal CalculateDiscount(decimal price, decimal fixedDiscount, bool useFixed) { return fixedDiscount; }

//218
//static int MultiplyNumbers(int a, int b) { return a * b; }
//static double MultiplyNumbers(double a, double b) { return a * b; }
//static decimal MultiplyNumbers(decimal a, decimal b) { return a * b; }

//219
//static decimal ApplyDiscount(decimal price, decimal percent) { return price * percent; }
//static decimal ApplyDiscount(decimal price, int fixedDiscount) { return price - fixedDiscount; }

//220
//static double Perimeter(double side) { return 4 * side; }
//static double Perimeter(double length, double width) { return 2 * (length + width); }
//static double Perimeter(double a, double b, double c) { return a + b + c; }

//221
//static void PrintArray(int[] arr) { Console.WriteLine(string.Join(", ", arr)); }
//static void PrintArray(double[] arr) { Console.WriteLine(string.Join(", ", arr)); }

//222
//static int Max(int a, int b) { return Math.Max(a, b); }
//static int Max(int a, int b, int c) { return Math.Max(a, Math.Max(b, c)); }

//223
//static int FindMax(int a, int b) { return a > b ? a : b; }
//static int FindMax(int a, int b, int c) { return Math.Max(a, Math.Max(b, c)); }
//static int FindMax(int a, int b, int c, int d) { return Math.Max(Math.Max(a, b), Math.Max(c, d)); }

//224
//static double CalculatePerimeter(double side) { return 4 * side; }
//static double CalculatePerimeter(double length, double width) { return 2 * (length + width); }

//225
//static double ConvertTemperature(double celsius) { return celsius * 9 / 5 + 32; }
//static double ConvertTemperature(double value, string from, string to)
//{
//    if (from == "C" && to == "F") return value * 9 / 5 + 32;
//    if (from == "F" && to == "C") return (value - 32) * 5 / 9;
//    return value;
//}

//226
//static double GetPerimeter(double radius) { return 2 * Math.PI * radius; }
//static double GetPerimeter(double length, double width) { return 2 * (length + width); }

//227
//static double ComputePerimeter(double side) { return 4 * side; }
//static double ComputePerimeter(double a, double b) { return 2 * (a + b); }
//static double ComputePerimeter(double a, double b, double c) { return a + b + c; }

//228
//static int ParseToInt(string str) { return int.Parse(str); }
//static double ParseToDouble(string str) { return double.Parse(str); }
//static decimal ParseToDecimal(string str) { return decimal.Parse(str); }

//229
//static double GetArea(double radius) { return Math.PI * radius * radius; }
//static double GetArea(double width, double height) { return width * height; }

//230
//static int Maximum(int a, int b) { return Math.Max(a, b); }
//static int Maximum(int a, int b, int c) { return Math.Max(a, Math.Max(b, c)); }

//231
//static double AreaOfCircle(double radius) { return Math.PI * radius * radius; }
//static double AreaOfRectangle(double length, double width) { return length * width; }
//232
//static void Sort(int[] arr) { Array.Sort(arr); }
//static void Sort(int[] arr, bool descending) { Array.Sort(arr); if (descending) Array.Reverse(arr); }

//233
//static double Distance(double x1, double y1, double x2, double y2) { return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); }
//static double Distance(double x1, double y1, double z1, double x2, double y2, double z2) { return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); }

//234
//static int Max(int a, int b) { return Math.Max(a, b); }
//static int Max(int a, int b, int c) { return Math.Max(a, Math.Max(b, c)); }
//static int Max(int a, int b, int c, int d) { return Math.Max(Math.Max(a, b), Math.Max(c, d)); }

//235
//static int Multiply(int a, int b) { return a * b; }
//static double Multiply(double a, double b) { return a * b; }
//static decimal Multiply(decimal a, decimal b) { return a * b; }

//236
//static void Process(int[] arr) { Console.WriteLine($"Int array: {arr.Length}"); }
//static void Process(string[] arr) { Console.WriteLine($"String array: {arr.Length}"); }

//237
//static T[] CreateArray<T>(T element, int count) { return Enumerable.Repeat(element, count).ToArray(); }
//static List<T> CreateArray<T>(T element, int count, bool asList) { return Enumerable.Repeat(element, count).ToList(); }

//238
//static bool Validate(string email) { return email.Contains("@") && email.Contains("."); }
//static bool Validate(string phone, int type) { return phone.Length >= 10 && phone.All(char.IsDigit); }
//static bool Validate(string url, string type) { return url.StartsWith("http"); }

//239
//static int Parse(string str) { return int.Parse(str); }
//static double Parse(string str, bool asDouble) { return double.Parse(str); }
//static decimal Parse(string str, string asDecimal) { return decimal.Parse(str); }

//240
//static string Combine(string a, string b) { return a + b; }
//static string Combine(string a, string b, string c) { return a + b + c; }
//static string Combine(string a, string b, string c, string d) { return a + b + c + d; }

//241
//static double Perimeter(double side) { return 4 * side; }
//static double Perimeter(double length, double width) { return 2 * (length + width); }
//static double Perimeter(double a, double b, double c) { return a + b + c; }

//242
//static double Volume(double side) { return side * side * side; }
//static double Volume(double length, double width, double height) { return length * width * height; }
//static double Volume(double radius, double height, string type) { return Math.PI * radius * radius * height; }

//243
//static string FormatDate(DateTime date) { return date.ToString("yyyy-MM-dd"); }
//static string FormatDate(DateTime date, string format) { return date.ToString(format); }
//static string FormatDate(DateTime date, bool withTime) { return date.ToString(withTime ? "yyyy-MM-dd HH:mm" : "yyyy-MM-dd"); }

//244
//static int ToNumber(string str) { return int.Parse(str); }
//static double ToNumber(string str, bool isDouble) { return double.Parse(str); }
//static decimal ToNumber(string str, string isDecimal) { return decimal.Parse(str); }

//245
//static int Multiply(int x, int y) { return x * y; }
//static double Multiply(double x, double y) { return x * y; }
//static decimal Multiply(decimal x, decimal y) { return x * y; }

//246
//static void Print(int value) { Console.WriteLine($"Integer: {value}"); }
//static void Print(string value) { Console.WriteLine($"String: {value}"); }
//static void Print(double value) { Console.WriteLine($"Double: {value}"); }

//247
//static int ConvertToInt(string str) { return int.Parse(str); }
//static long ConvertToLong(string str) { return long.Parse(str); }
//static double ConvertToDouble(string str) { return double.Parse(str); }

//248
//static bool IsValidEmail(string email) { return email.Contains("@") && email.Contains("."); }
//static bool IsValidPhone(string phone) { return phone.Length == 11 && phone.All(char.IsDigit); }
//static bool IsValidUrl(string url) { return url.StartsWith("http"); }

//249
//static int FindMax(int a, int b) { return Math.Max(a, b); }
//static int FindMax(int a, int b, int c) { return Math.Max(a, Math.Max(b, c)); }
//static int FindMax(int a, int b, int c, int d) { return Math.Max(Math.Max(a, b), Math.Max(c, d)); }

//250
//static double CalculateArea(double radius) { return Math.PI * radius * radius; }
//static double CalculateArea(double width, double height) { return width * height; }

//251
//static bool ValidateData(string email) { return email.Contains("@"); }
//static bool ValidateData(string phone, bool isPhone) { return phone.All(char.IsDigit); }
//static bool ValidateData(string url, int type) { return url.StartsWith("http"); }

//252
//static int Add(int a, int b) { return a + b; }
//static int Add(int a, int b, int c) { return a + b + c; }

//253
//static void Display(int num) { Console.WriteLine($"Number: {num}"); }
//static void Display(string text) { Console.WriteLine($"Text: {text}"); }
//static void Display(bool flag) { Console.WriteLine($"Boolean: {flag}"); }

//254
//static int Product(int a, int b) { return a * b; }
//static double Product(double a, double b) { return a * b; }
//static decimal Product(decimal a, decimal b) { return a * b; }

//255
//static double GetVolume(double side) { return Math.Pow(side, 3); }
//static double GetVolume(double length, double width, double height) { return length * width * height; }
//static double GetVolume(double radius, double height) { return Math.PI * radius * radius * height; }

//256
//static double GetPerimeter(double side) { return 4 * side; }
//static double GetPerimeter(double length, double width) { return 2 * (length + width); }
//static double GetPerimeter(params double[] sides) { return sides.Sum(); }

//257
//static decimal ApplyDiscount(decimal price, decimal percentage) { return price * (1 - percentage / 100); }
//static decimal ApplyDiscount(decimal price, int fixedAmount) { return price - fixedAmount; }

//258
//static decimal CalculateDiscount(decimal price, decimal percent) { return price * percent / 100; }
//static decimal CalculateDiscount(decimal price, decimal fixedDiscount, bool useFixed) { return fixedDiscount; }

//259
//static void PrintArray(int[] arr) { Console.WriteLine(string.Join(", ", arr)); }
//static void PrintArray(string[] arr) { Console.WriteLine(string.Join(", ", arr)); }
//static void PrintArray(double[] arr) { Console.WriteLine(string.Join(", ", arr)); }

//260
//static void SortArray(int[] arr) { Array.Sort(arr); }
//static void SortArray(int[] arr, bool descending) { Array.Sort(arr); if (descending) Array.Reverse(arr); }

//261
//static double Area(double radius) { return Math.PI * radius * radius; }
//static double Area(double length, double width) { return length * width; }

//262
//static double ComputeVolume(double edge) { return edge * edge * edge; }
//static double ComputeVolume(double length, double width, double height) { return length * width * height; }
//static double ComputeVolume(double radius, double height, string shape) { return Math.PI * radius * radius * height; }

//263
//static void SortList(List<int> list) { list.Sort(); }
//static void SortList(List<int> list, bool descending) { list.Sort(); if (descending) list.Reverse(); }

//264
//static int Sum(int a, int b) { return a + b; }
//static int Sum(int a, int b, int c) { return a + b + c; }

//265
//static void OrderArray(int[] arr) { Array.Sort(arr); }
//static void OrderArray(int[] arr, string order) { Array.Sort(arr); if (order == "desc") Array.Reverse(arr); }

//266
//static string Format(DateTime date) { return date.ToString("dd.MM.yyyy"); }
//static string Format(DateTime date, bool full) { return date.ToString(full ? "dd.MM.yyyy HH:mm:ss" : "dd.MM.yyyy"); }

//267
//static int ParseInt(string str) { return int.Parse(str); }
//static double ParseDouble(string str) { return double.Parse(str); }
//static decimal ParseDecimal(string str) { return decimal.Parse(str); }

//268
//static int Find(int[] array, int value) { return Array.IndexOf(array, value); }
//static int Find(List<int> list, int value) { return list.IndexOf(value); }

//269
//static double Perimeter(double side) { return 4 * side; }
//static double Perimeter(double length, double width) { return 2 * (length + width); }
//static double Perimeter(double a, double b, double c) { return a + b + c; }
//270
//static bool Validate(string email) { return email.Contains("@") && email.Contains("."); }
//static bool Validate(string phone, bool isPhone) { return phone.Length >= 10 && phone.All(char.IsDigit); }
//static bool Validate(string url, bool isUrl, bool isPhone) { return url.StartsWith("http"); }

//271
//static decimal ApplyDiscount(decimal price, decimal percent) { return price * (1 - percent / 100); }
//static decimal ApplyDiscount(decimal price, decimal fixedAmount, bool useFixed) { return price - fixedAmount; }

//272
//static string Concat(string a, string b) { return a + b; }
//static string Concat(string a, string b, string c) { return a + b + c; }
//static string Concat(string a, string b, string c, string d) { return a + b + c + d; }

//273
//static void Process(int[] array) { Console.WriteLine($"Int array: {array.Length}"); }
//static void Process(string[] array) { Console.WriteLine($"String array: {array.Length}"); }
//static void Process(double[] array) { Console.WriteLine($"Double array: {array.Length}"); }

//274
//static int Find(int[] array, int value) { return Array.IndexOf(array, value); }
//static int Find(List<int> list, int value) { return list.IndexOf(value); }

//275
//static T[] Reverse<T>(T[] array) { Array.Reverse(array); return array; }
//static List<T> Reverse<T>(List<T> list) { list.Reverse(); return list; }

//276
//static double CalculateArea(double radius) { return Math.PI * radius * radius; }
//static double CalculateArea(double width, double height) { return width * height; }

//277
//static string Encrypt(string text) { return Convert.ToBase64String(Encoding.UTF8.GetBytes(text)); }
//static string Encrypt(string text, int key) { return new string(text.Select(c => (char)(c + key)).ToArray()); }

//278
//static bool IsValid(string email) { return email.Contains("@") && email.Contains("."); }
//static bool IsValid(string phone, int type) { return phone.Length == 11 && phone.All(char.IsDigit); }
//static bool IsValid(string url, string type) { return url.StartsWith("http"); }

//279
//static double Area(double r) { return Math.PI * r * r; }
//static double Area(double a, double b) { return a * b; }
//static double Area(double a, double b, double c) { return 2 * (a * b + b * c + a * c); }

//280
//static double Distance(double x1, double y1, double x2, double y2) { return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); }
//static double Distance(double x1, double y1, double z1, double x2, double y2, double z2) { return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); }

//281
//static double GetArea(double radius) { return Math.PI * radius * radius; }
//static double GetArea(double length, double width) { return length * width; }
//static double GetArea(double a, double b, double height) { return (a + b) * height / 2; }

//282
//static double ComputeArea(double side) { return side * side; }
//static double ComputeArea(double width, double height) { return width * height; }
//static double ComputeArea(double baseLength, double height, bool isTriangle) { return baseLength * height / 2; }

//283
//static string EncryptText(string text) { return new string(text.Reverse().ToArray()); }
//static string EncryptText(string text, string key) { return Convert.ToBase64String(Encoding.UTF8.GetBytes(text + key)); }

//284
//static decimal CalculateDiscount(decimal price, decimal percentage) { return price * percentage / 100; }
//static decimal CalculateDiscount(decimal price, int fixedDiscount) { return fixedDiscount; }

//285
//static void AddToList(List<int> list, int item) { list.Add(item); }
//static void AddToList(List<int> list, params int[] items) { list.AddRange(items); }

//286
//static void AddToCollection<T>(ICollection<T> collection, T item) { collection.Add(item); }
//static void AddToCollection<T>(ICollection<T> collection, IEnumerable<T> items) { foreach (var item in items) collection.Add(item); }

//287
//static double Volume(double side) { return Math.Pow(side, 3); }
//static double Volume(double length, double width, double height) { return length * width * height; }
//static double Volume(double radius, double height) { return Math.PI * radius * radius * height; }

//288
//static double CalculateArea(int side) { return side * side; }
//static double CalculateArea(int length, int width) { return length * width; }
//static double CalculateArea(float radius) { return Math.PI * radius * radius; }

//289
//static void AddElement(List<string> list, string element) { list.Add(element); }
//static void AddElement(List<string> list, string[] elements) { list.AddRange(elements); }

//290
//static void Print(int value) { Console.WriteLine($"Int: {value}"); }
//static void Print(string value) { Console.WriteLine($"String: {value}"); }
//static void Print(bool value) { Console.WriteLine($"Bool: {value}"); }

//291
//static double CalculateVolume(double edge) { return edge * edge * edge; }
//static double CalculateVolume(double a, double b, double c) { return a * b * c; }
//static double CalculateVolume(double radius, double height, string type) { return Math.PI * radius * radius * height; }

//292
//static void Display(int number) { Console.WriteLine($"Number: {number}"); }
//static void Display(string text) { Console.WriteLine($"Text: {text}"); }
//static void Display(DateTime date) { Console.WriteLine($"Date: {date:yyyy-MM-dd}"); }

//293
//static int RandomNumber() { return new Random().Next(); }
//static int RandomNumber(int max) { return new Random().Next(max); }
//static int RandomNumber(int min, int max) { return new Random().Next(min, max); }

//294
//static void Show(object obj) { Console.WriteLine($"Object: {obj}"); }
//static void Show(int[] array) { Console.WriteLine($"Array: [{string.Join(", ", array)}]"); }
//static void Show(Dictionary<string, int> dict) { Console.WriteLine($"Dictionary: {string.Join(", ", dict)}"); }

//295
//static int Multiply(int a, int b) { return a * b; }
//static double Multiply(double a, double b) { return a * b; }
//static decimal Multiply(decimal a, decimal b) { return a * b; }

//296
//static void Sort(int[] array) { Array.Sort(array); }
//static void Sort(int[] array, bool descending) { Array.Sort(array); if (descending) Array.Reverse(array); }

//297
//static int Max(int a, int b) { return Math.Max(a, b); }
//static int Max(int a, int b, int c) { return Math.Max(a, Math.Max(b, c)); }
//static int Max(int a, int b, int c, int d) { return Math.Max(Math.Max(a, b), Math.Max(c, d)); }

//298
//static string Encrypt(string input) { return Convert.ToBase64String(Encoding.UTF8.GetBytes(input)); }
//static string Encrypt(string input, string method) { return new string(input.Select(c => (char)(c + 1)).ToArray()); }

//299
//static int Multiply(int x, int y) { return x * y; }
//static double Multiply(double x, double y) { return x * y; }
//static decimal Multiply(decimal x, decimal y) { return x * y; }
//300
//static string Encrypt(string text) { return $"BASE64:{Convert.ToBase64String(Encoding.UTF8.GetBytes(text))}"; }
//static string Encrypt(string text, int shift) { return new string(text.Select(c => (char)(c + shift)).ToArray()); }
//static string Encrypt(string text, string key) { return $"XOR:{new string(text.Select((c, i) => (char)(c ^ key[i % key.Length])).ToArray())}"; }

//301
//static string BuildSQL(string table, string[] columns = null, string where = "", string orderBy = "", int limit = 0)
//{
//    string cols = columns != null ? string.Join(", ", columns) : "*";
//    string sql = $"SELECT {cols} FROM {table}";
//    if (!string.IsNullOrEmpty(where)) sql += $" WHERE {where}";
//    if (!string.IsNullOrEmpty(orderBy)) sql += $" ORDER BY {orderBy}";
//    if (limit > 0) sql += $" LIMIT {limit}";
//    return sql;
//}

//302
//static string CreateUser(string username, string email, string firstName = null, string lastName = null, int age = 0)
//{
//    return $"User: {username}, Email: {email}, Name: {firstName} {lastName}, Age: {age}";
//}

//303
//static string CreateQuery(string table, string condition = "", string sortBy = "", int top = 0)
//{
//    string query = $"SELECT * FROM {table}";
//    if (!string.IsNullOrEmpty(condition)) query += $" WHERE {condition}";
//    if (!string.IsNullOrEmpty(sortBy)) query += $" ORDER BY {sortBy}";
//    if (top > 0) query += $" TOP {top}";
//    return query;
//}

//304
//static string FormatText(string text, bool upper = false, bool trim = true, int maxLen = 0)
//{
//    string result = text ?? "";
//    if (trim) result = result.Trim();
//    if (upper) result = result.ToUpper();
//    if (maxLen > 0 && result.Length > maxLen) result = result.Substring(0, maxLen);
//    return result;
//}

//305
//static string CreateGraph(int width = 800, int height = 600, string color = "blue", string type = "line")
//{
//    return $"Graph: {type}, Size: {width}x{height}, Color: {color}";
//}

//306
//static string GeneratePassword(int length = 8, bool useUpper = true, bool useNumbers = true)
//{
//    string chars = "abcdefghijklmnopqrstuvwxyz";
//    if (useUpper) chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//    if (useNumbers) chars += "0123456789";
//    Random random = new Random();
//    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
//}

//307
//static string CreatePassword(int len = 10, bool symbols = false, bool mixedCase = true)
//{
//    string characters = "abcdefghijklmnopqrstuvwxyz0123456789";
//    if (mixedCase) characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//    if (symbols) characters += "!@#$%^&*";
//    Random rand = new Random();
//    return new string(Enumerable.Repeat(characters, len).Select(s => s[rand.Next(s.Length)]).ToArray());
//}

//308
//static double Round(double number, int decimals = 0)
//{
//    return Math.Round(number, decimals);
//}

//309
//static string CreateFile(string name, string ext = "txt", string folder = "")
//{
//    return string.IsNullOrEmpty(folder) ? $"{name}.{ext}" : $"{folder}/{name}.{ext}";
//}

//310
//static int FindIndex(string[] array, string value, int start = 0)
//{
//    if (array == null) return -1;
//    for (int i = start; i < array.Length; i++)
//        if (array[i] == value) return i;
//    return -1;
//}

//311
//static string DBConnection(string server, string database, int port = 1433, bool trusted = true)
//{
//    return $"Server={server};Database={database};Port={port};Trusted_Connection={trusted}";
//}

//312
//static string MakeFilePath(string fileName, string extension = "log", string path = "logs")
//{
//    return $"{path}/{fileName}.{extension}";
//}

//313
//static void SetupLogging(string level = "INFO", bool file = true, bool console = false)
//{
//    Console.WriteLine($"Log Level: {level}, File: {file}, Console: {console}");
//}

//314
//static int Search(int[] array, int value, int fromIndex = 0)
//{
//    if (array == null) return -1;
//    for (int i = fromIndex; i < array.Length; i++)
//        if (array[i] == value) return i;
//    return -1;
//}

//315
//static (int, int) GetPage(int page = 1, int size = 10)
//{
//    int skip = (page - 1) * size;
//    return (skip, size);
//}

//316
//static void Output(string message, string prefix = ">")
//{
//    Console.WriteLine($"{prefix} {message}");
//}

//317
//static void SendEmail(string to, string subject, string body, string cc = null, bool html = false)
//{
//    Console.WriteLine($"To: {to}, Subject: {subject}, CC: {cc}, HTML: {html}");
//}

//318
//static bool ValidateForm(string username, string
//327
//static string CreateAppConfig(string name, string version = "1.0", bool debug = false, int port = 8080)
//{
//    return $"App: {name}, Version: {version}, Debug: {debug}, Port: {port}";
//}

//328
//static string ConnectDatabase(string server, string database, string user = "sa", int timeout = 30)
//{
//    return $"Server={server};Database={database};User={user};Timeout={timeout}";
//}

//329
//static decimal RoundValue(decimal number, int decimals = 2)
//{
//    return Math.Round(number, decimals);
//}

//330
//static int FindElement(int[] array, int value, int startIndex = 0)
//{
//    if (array == null) return -1;
//    for (int i = startIndex; i < array.Length; i++)
//        if (array[i] == value) return i;
//    return -1;
//}

//331
//static void PrintWithPrefix(string message, string prefix = ">>>")
//{
//    Console.WriteLine($"{prefix} {message}");
//}

//332
//static int[] FilterNumbers(int[] numbers, int min = 0, int max = 100, bool evenOnly = false)
//{
//    if (numbers == null) return new int[0];
//    return numbers.Where(n => n >= min && n <= max && (!evenOnly || n % 2 == 0)).ToArray();
//}

//333
//static string FormatString(string text, bool uppercase = false, int maxLength = 0)
//{
//    string result = text ?? "";
//    if (uppercase) result = result.ToUpper();
//    if (maxLength > 0 && result.Length > maxLength) result = result.Substring(0, maxLength);
//    return result;
//}

//334
//static void SetupLogging(string level = "INFO", string file = "app.log", bool console = true)
//{
//    Console.WriteLine($"Log Level: {level}, File: {file}, Console: {console}");
//}

//335
//static string[] FilterStrings(string[] items, int minLength = 1, string contains = null)
//{
//    if (items == null) return new string[0];
//    return items.Where(i => i.Length >= minLength && (contains == null || i.Contains(contains))).ToArray();
//}

//336
//static void SendEmailMessage(string to, string subject, string body, string cc = null, bool urgent = false)
//{
//    Console.WriteLine($"To: {to}, Subject: {subject}, CC: {cc}, Urgent: {urgent}");
//}

//337
//static string CreateReport(string title, string author, DateTime date = default, string format = "PDF")
//{
//    if (date == default) date = DateTime.Now;
//    return $"Report: {title}, Author: {author}, Date: {date:yyyy-MM-dd}, Format: {format}";
//}

//338
//static bool ValidateForm(string username, string email, bool checkAge = true, int minAge = 18)
//{
//    if (string.IsNullOrEmpty(username)) return false;
//    if (string.IsNullOrEmpty(email) || !email.Contains("@")) return false;
//    return true;
//}

//339
//static Dictionary<string, object> CreateConfiguration(string appName, string environment = "Production", int maxUsers = 100)
//{
//    return new Dictionary<string, object>
//    {
//        ["AppName"] = appName,
//        ["Environment"] = environment,
//        ["MaxUsers"] = maxUsers
//    };
//}

//340
//static void SendMail(string recipient, string subject, string message, string[] attachments = null, bool highPriority = false)
//{
//    Console.WriteLine($"To: {recipient}, Subject: {subject}, Attachments: {attachments?.Length ?? 0}, Priority: {highPriority}");
//}

//341
//static string BuildSQL(string table, string[] fields = null, string condition = "", int limit = 0)
//{
//    string select = fields != null ? string.Join(", ", fields) : "*";
//    string sql = $"SELECT {select} FROM {table}";
//    if (!string.IsNullOrEmpty(condition)) sql += $" WHERE {condition}";
//    if (limit > 0) sql += $" LIMIT {limit}";
//    return sql;
//}

//342
//static double RoundDouble(double value, int decimalPlaces = 2)
//{
//    return Math.Round(value, decimalPlaces);
//}

//343
//static double Power(double baseNumber, int exponent = 2)
//{
//    return Math.Pow(baseNumber, exponent);
//}

//344
//static string ConfigureApp(string name, string version = "1.0.0", bool enableCache = true, string environment = "Production")
//{
//    return $"Name: {name}, Version: {version}, Cache: {enableCache}, Environment: {environment}";
//}

//345
//static void Email(string to, string subject, string body, bool isHtml = false, string replyTo = null)
//{
//    Console.WriteLine($"To: {to}, Subject: {subject}, HTML: {isHtml}, ReplyTo: {replyTo}");
//}

//346
//static decimal CalculateTotal(decimal price, int quantity = 1, decimal tax = 0.1m, decimal discount = 0m)
//{
//    return price * quantity * (1 - discount) * (1 + tax);
//}

//347
//static void DisplayMessage(string text, string prefix = "MSG")
//{
//    Console.WriteLine($"[{prefix}] {text}");
//}

//348
//static int SearchArray(string[] array, string value, int startFrom = 0)
//{
//    if (array == null) return -1;
//    for (int i = startFrom; i < array.Length; i++)
//        if (array[i] == value) return i;
//    return -1;
//}
//349
//static decimal CalculateOrder(decimal price, int quantity = 1, decimal tax = 0.2m, decimal discount = 0m)
//{
//    return price * quantity * (1 - discount) * (1 + tax);
//}

//350
//static decimal ComputeTotal(decimal unitPrice, int count = 1, decimal shipping = 0m, decimal taxRate = 0.1m)
//{
//    return (unitPrice * count + shipping) * (1 + taxRate);
//}

//351
//static string CreateAppConfig(string name, string environment = "Production", bool enableLogging = true, int port = 8080)
//{
//    return $"App: {name}, Env: {environment}, Logging: {enableLogging}, Port: {port}";
//}

//352
//static void LogMessage(string message, string level = "INFO")
//{
//    Console.WriteLine($"[{level}] {message}");
//}

//353
//static int FindIndex(int[] array, int value, int startIndex = 0)
//{
//    if (array == null) return -1;
//    for (int i = startIndex; i < array.Length; i++)
//        if (array[i] == value) return i;
//    return -1;
//}

//354
//static void SendEmail(string to, string subject, string body, string cc = null, bool isHtml = false, string[] attachments = null)
//{
//    Console.WriteLine($"To: {to}, Subject: {subject}, CC: {cc}, HTML: {isHtml}, Attachments: {attachments?.Length ?? 0}");
//}

//355
//static string BuildQuery(string table, string[] columns = null, string where = "", string orderBy = "", int limit = 0)
//{
//    string cols = columns != null ? string.Join(", ", columns) : "*";
//    string query = $"SELECT {cols} FROM {table}";
//    if (!string.IsNullOrEmpty(where)) query += $" WHERE {where}";
//    if (!string.IsNullOrEmpty(orderBy)) query += $" ORDER BY {orderBy}";
//    if (limit > 0) query += $" LIMIT {limit}";
//    return query;
//}

//356
//static string ConnectToDB(string server, string database, string user = "admin", string password = "", int timeout = 30)
//{
//    return $"Server={server};Database={database};User={user};Timeout={timeout}";
//}

//357
//static string CreateFilePath(string filename, string extension = "txt", string directory = "")
//{
//    return string.IsNullOrEmpty(directory) ? $"{filename}.{extension}" : $"{directory}/{filename}.{extension}";
//}

//358
//static string DatabaseConnection(string host, string dbName, int port = 5432, bool ssl = true, string schema = "public")
//{
//    return $"Host={host};Port={port};Database={dbName};SSL={ssl};Schema={schema}";
//}

//359
//static int SearchFromIndex(string[] array, string target, int startFrom = 0, bool caseSensitive = false)
//{
//    if (array == null) return -1;
//    for (int i = startFrom; i < array.Length; i++)
//        if (string.Equals(array[i], target, caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase))
//            return i;
//    return -1;
//}

//360
//static double RoundNumber(double value, int decimals = 2)
//{
//    return Math.Round(value, decimals);
//}

//361
//static string CreateHttpRequest(string url, string method = "GET", Dictionary<string, string> headers = null, string body = "")
//{
//    return $"URL: {url}, Method: {method}, Headers: {headers?.Count ?? 0}, Body Length: {body?.Length ?? 0}";
//}
//362
//static int FindInArray(int[] array, int value, int startIndex = 0)
//{
//    if (array == null) return -1;
//    for (int i = startIndex; i < array.Length; i++)
//        if (array[i] == value) return i;
//    return -1;
//}

//363
//static string CreateUserProfile(string username, string email, string firstName = null, string lastName = null, int age = 0, string role = "User")
//{
//    return $"User: {username}, Email: {email}, Name: {firstName} {lastName}, Age: {age}, Role: {role}";
//}

//364
//static string FormatString(string text, bool uppercase = false, int maxLength = 0, string suffix = "...")
//{
//    string result = text ?? "";
//    if (uppercase) result = result.ToUpper();
//    if (maxLength > 0 && result.Length > maxLength)
//        result = result.Substring(0, maxLength) + suffix;
//    return result;
//}

//365
//static string CreateChart(int width = 800, int height = 600, string color = "blue", string title = "", bool legend = true)
//{
//    return $"Chart: {title}, Size: {width}x{height}, Color: {color}, Legend: {legend}";
//}

//366
//static int SearchArray(string[] array, string value, int startIndex = 0, bool ignoreCase = false)
//{
//    if (array == null) return -1;
//    for (int i = startIndex; i < array.Length; i++)
//        if (string.Equals(array[i], value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
//            return i;
//    return -1;
//}

//367
//static string RegisterUser(string username, string password, string email = "", string phone = "", DateTime? birthDate = null)
//{
//    return $"Username: {username}, Email: {email}, Phone: {phone}, BirthDate: {birthDate?.ToString("yyyy-MM-dd") ?? "N/A"}";
//}

//368
//static double CalculatePower(double number, int exponent = 2)
//{
//    return Math.Pow(number, exponent);
//}

//369
//static string CreateFile(string name, string extension = "txt", string path = "")
//{
//    return string.IsNullOrEmpty(path) ? $"{name}.{extension}" : $"{path}/{name}.{extension}";
//}

//370
//static void ShowMessage(string message, string prefix = ">>")
//{
//    Console.WriteLine($"{prefix} {message}");
//}

//371
//static int IndexOf(double[] array, double value, int startIndex = 0, double tolerance = 0.0001)
//{
//    if (array == null) return -1;
//    for (int i = startIndex; i < array.Length; i++)
//        if (Math.Abs(array[i] - value) < tolerance) return i;
//    return -1;
//}

//372
//static string GenerateReport(string title, string author, DateTime date = default, string format = "PDF", bool confidential = false)
//{
//    if (date == default) date = DateTime.Today;
//    return $"Report: {title}, Author: {author}, Date: {date:yyyy-MM-dd}, Format: {format}, Confidential: {confidential}";
//}

//373
//static bool ValidateForm(string username, string email, int minAge = 18, int maxAge = 100, bool requirePhone = false, string phone = "")
//{
//    if (string.IsNullOrEmpty(username)) return false;
//    if (string.IsNullOrEmpty(email) || !email.Contains("@")) return false;
//    if (requirePhone && string.IsNullOrEmpty(phone)) return false;
//    return true;
//}

//374
//static Dictionary<string, object> CreateConfig(string appName, string environment = "Production", int timeout = 30, bool logging = true)
//{
//    return new Dictionary<string, object>
//    {
//        ["AppName"] = appName,
//        ["Environment"] = environment,
//        ["Timeout"] = timeout,
//        ["Logging"] = logging
//    };
//}

//375
//static string BuildChart(int width, int height, string color = "red", string type = "bar", bool animated = false)
//{
//    return $"Chart Type: {type}, Size: {width}x{height}, Color: {color}, Animated: {animated}";
//}

//376
//static string SetupAppConfig(string name, string version = "1.0", int port = 8080, bool debug = false, string database = "default")
//{
//    return $"App: {name}, Version: {version}, Port: {port}, Debug: {debug}, Database: {database}";
//}
//377
//static double Power(double number, int exponent = 2)
//{
//return Math.Pow(number, exponent);
//}

//378
//static decimal CalculateOrderTotal(decimal basePrice, int quantity = 1, decimal taxRate = 0.2m, decimal discount = 0m)
//{
//decimal subtotal = basePrice * quantity;
//decimal discounted = subtotal * (1 - discount);
//return discounted * (1 + taxRate);
//}

//379
//static string FormatText(string text, bool toUpper = false, bool trim = true, string prefix = "", string suffix = "")
//{
//string result = text ?? "";
//if (trim) result = result.Trim();
//if (toUpper) result = result.ToUpper();
//return prefix + result + suffix;
//}

//380
//static void PrintMessage(string message, string prefix = "INFO")
//{
//Console.WriteLine($"[{prefix}] {message}");
//}

//381
//static string CreateAppConfig(string appName, string version = "1.0", bool enableLogging = true, int maxConnections = 100, string environment = "Production")
//{
//return $"App: {appName}, Version: {version}, Logging: {enableLogging}, MaxConnections: {maxConnections}, Environment: {environment}";
//}

//382
//static string CreateUser(string username, string email, string firstName = null, string lastName = null, int age = 0, bool isActive = true)
//{
//return $"User: {username}, Email: {email}, Name: {firstName} {lastName}, Age: {(age > 0 ? age.ToString() : "N/A")}, Active: {isActive}";
//}

//383
//static int[] FilterData(int[] numbers, int minValue = int.MinValue, int maxValue = int.MaxValue, bool includeEven = true, bool includeOdd = true)
//{
//if (numbers == null) return new int[0];
//return numbers.Where(n => n >= minValue && n <= maxValue && ((n % 2 == 0 && includeEven) || (n % 2 != 0 && includeOdd))).ToArray();
//}

//384
//static string GeneratePassword(int length = 8, bool includeUppercase = true, bool includeLowercase = true, bool includeNumbers = true, bool includeSpecial = false)
//{
//const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//const string lower = "abcdefghijklmnopqrstuvwxyz";
//const string numbers = "0123456789";
//const string special = "!@#$%^&*";
//var chars = "";
//if (includeUppercase) chars += upper;
//if (includeLowercase) chars += lower;
//if (includeNumbers) chars += numbers;
//if (includeSpecial) chars += special;
//if (string.IsNullOrEmpty(chars)) chars = lower + numbers;
//var random = new Random();
//return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
//}

//385
//static Dictionary<string, object> CreateApplicationConfig(string name, string version = "1.0.0", int port = 8080, bool debugMode = false, string database = "default.db")
//{
//return new Dictionary<string, object>
//{
//["Name"] = name,
//["Version"] = version,
//["Port"] = port,
//["DebugMode"] = debugMode,
//["Database"] = database
//};
//}

//386
//static void Log(string message, LogLevel level = LogLevel.Info)
//{
//string prefix = level switch
//{
//LogLevel.Debug => "DEBUG",
//LogLevel.Info => "INFO",
//LogLevel.Warning => "WARN",
//LogLevel.Error => "ERROR",
//_ => "INFO"
//};
//Console.WriteLine($"[{prefix}] {DateTime.Now:HH:mm:ss} {message}");
//}

//public enum LogLevel { Debug, Info, Warning, Error }

//387
//static string CreateChart(int width = 800, int height = 600, string backgroundColor = "white", string borderColor = "black", int borderWidth = 1, string chartType = "line")
//{
//    return $"Chart: {chartType}, Size: {width}x{height}, Background: {backgroundColor}, Border: {borderColor} ({borderWidth}px)";
//}

//388
//static void DisplayAlert(string message, AlertType type = AlertType.Info)
//{
//    string prefix = type switch
//    {
//        AlertType.Success => "✓",
//        AlertType.Info => "ℹ",
//        AlertType.Warning => "⚠",
//        AlertType.Error => "✗",
//        _ => "ℹ"
//    };
//    Console.WriteLine($"{prefix} {message}");
//}

//public enum AlertType { Success, Info, Warning, Error }

//389
//static string RegisterUser(string username, string password, string email = null, string phone = null, DateTime? birthDate = null, string country = "Unknown")
//{
//    return $"Username: {username}, Email: {email ?? "N/A"}, Phone: {phone ?? "N/A"}, BirthDate: {birthDate?.ToString("yyyy-MM-dd") ?? "N/A"}, Country: {country}";
//}

//390
//static void SendEmail(string to, string subject, string body, string cc = null, string bcc = null, bool isHtml = false, string[] attachments = null)
//{
//    Console.WriteLine($"To: {to}, Subject: {subject}, CC: {cc ?? "N/A"}, BCC: {bcc ?? "N/A"}, HTML: {isHtml}, Attachments: {(attachments != null ? attachments.Length : 0)}");
//}

//391
//static List<string> FilterStrings(List<string> items, string contains = null, int minLength = 0, int maxLength = int.MaxValue, bool caseSensitive = false)
//{
//    if (items == null) return new List<string>();
//    return items.Where(item =>
//        (contains == null || (caseSensitive ? item.Contains(contains) : item.ToLower().Contains(contains.ToLower()))) &&
//        item.Length >= minLength &&
//        item.Length <= maxLength
//    ).ToList();
//}

//392
//static string CreateUserProfile(string username, string email, string firstName = "", string lastName = "", int age = 0, string role = "User", bool emailVerified = false)
//{
//    return $"Username: {username}, Email: {email}, Full Name: {firstName} {lastName}, Age: {age}, Role: {role}, Email Verified: {emailVerified}";
//}

//393
//static double[] FilterNumbers(double[] values, double min = double.MinValue, double max = double.MaxValue, bool positiveOnly = false, bool negativeOnly = false)
//{
//    if (values == null) return new double[0];
//    return values.Where(v =>
//        v >= min && v <= max &&
//        (!positiveOnly || v > 0) &&
//        (!negativeOnly || v < 0)
//    ).ToArray();
//}

//394
//static string ConnectToDatabase(string server, string database, string username = "sa", string password = "", int timeout = 30, bool encrypt = false)
//{
//    return $"Server: {server}, Database: {database}, Username: {username}, Timeout: {timeout}s, Encrypt: {encrypt}";
//}

//395
//static void ConfigureLogging(string logLevel = "Info", string logFile = "app.log", bool enableConsole = true, bool enableFile = true, int maxFileSize = 10485760)
//{
//    Console.WriteLine($"LogLevel: {logLevel}, LogFile: {logFile}, Console: {enableConsole}, File: {enableFile}, MaxFileSize: {maxFileSize}");
//}

//396
//static decimal CalculateOrder(decimal unitPrice, int quantity, decimal shippingCost = 0m, decimal taxRate = 0.1m, decimal discount = 0m)
//{
//    decimal subtotal = unitPrice * quantity;
//    decimal discounted = subtotal * (1 - discount);
//    return discounted * (1 + taxRate) + shippingCost;
//}

//397
//static List<DateTime> FilterDates(List<DateTime> dates, DateTime? startDate = null, DateTime? endDate = null, DayOfWeek? dayOfWeek = null)
//{
//    if (dates == null) return new List<DateTime>();
//    return dates.Where(date =>
//        (!startDate.HasValue || date >= startDate.Value) &&
//        (!endDate.HasValue || date <= endDate.Value) &&
//        (!dayOfWeek.HasValue || date.DayOfWeek == dayOfWeek.Value)
//    ).ToList();
//}

//398
//static string SetupConfiguration(string appName, string environment = "Production", string connectionString = "", int cacheTimeout = 300, bool enableSwagger = false)
//{
//    return $"App: {appName}, Environment: {environment}, CacheTimeout: {cacheTimeout}s, Swagger: {enableSwagger}";
//}

//399
//static string BuildGraph(int width, int height, string title = "", string xAxis = "X", string yAxis = "Y", string color = "blue", bool grid = true)
//{
//    return $"Graph: {title}, Size: {width}x{height}, Axes: {xAxis}/{yAxis}, Color: {color}, Grid: {grid}";
//}

//400
//static string BuildSQLQuery(string table, string[] columns = null, string whereClause = "", string orderBy = "", int limit = 0)
//{
//    string cols = columns != null && columns.Length > 0 ? string.Join(", ", columns) : "*";
//    string sql = $"SELECT {cols} FROM {table}";
//    if (!string.IsNullOrEmpty(whereClause)) sql += $" WHERE {whereClause}";
//    if (!string.IsNullOrEmpty(orderBy)) sql += $" ORDER BY {orderBy}";
//    if (limit > 0) sql += $" LIMIT {limit}";
//    return sql;
//}