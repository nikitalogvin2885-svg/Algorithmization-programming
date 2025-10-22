using System;


//// 1. Метод для суммирования двух чисел
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// 2. Метод для суммирования двух чисел
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// 3. Максимум из трех чисел
//static int MaxOfThree(int a, int b, int c)
//{
//    int max = a;
//    if (b > max) max = b;
//    if (c > max) max = c;
//    return max;
//}

//// 4. Проверка четности
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//// 5. Проверка четности
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//// 6. Проверка четности
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//// 7. Суммирование двух чисел
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// 8. Метод, выводящий все числа в диапазоне от a до b
//static void PrintRange(int a, int b)
//{
//    for (int i = a; i <= b; i++)
//        Console.WriteLine(i);
//}

//// 9. Суммирование двух чисел
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// 10. Метод, выводящий все числа в диапазоне от a до b
//static void PrintRange(int a, int b)
//{
//    for (int i = a; i <= b; i++)
//        Console.WriteLine(i);
//}

//11
//static long Factorial(int n)
//{
//    if (n < 0) throw new ArgumentException("Число не может быть отрицательным");
//    if (n == 0 || n == 1) return 1;

//    long result = 1;
//    for (int i = 2; i <= n; i++)
//        result *= i;
//    return result;
//}

//// 12
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// 13
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// 14
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// 15
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//// 16
//static bool IsEven(int n)
//{
//    return n % 2 == 0;
//}

//// 17
//static void PrintRange(int a, int b)
//{
//    for (int i = a; i <= b; i++)
//        Console.WriteLine(i);
//}

//// 18
//static void PrintRange(int a, int b)
//{
//    for (int i = a; i <= b; i++)
//        Console.WriteLine(i);
//}

//// 19
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//// 20
//static void PrintRange(int a, int b)
//{
//    for (int i = a; i <= b; i++)
//        Console.WriteLine(i);
//}
//// 21
//static int Square(int number)
//{
//    return number * number;
//}

//// 22
//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return true;

//    string cleaned = str.ToLower().Replace(" ", "");
//    int left = 0;
//    int right = cleaned.Length - 1;

//    while (left < right)
//    {
//        if (cleaned[left] != cleaned[right])
//            return false;
//        left++;
//        right--;
//    }
//    return true;
//}

//// 23
//static void MultiplyByTwo(ref int number)
//{
//    number *= 2;
//}

//// 24
//static int Square(int number)
//{
//    return number * number;
//}

//// 25
//static void ResetToZero(ref int value)
//{
//    value = 0;
//}

//// 26
//static bool IsPalindrome(string str)
//{
//    if (string.IsNullOrEmpty(str))
//        return true;

//    char[] charArray = str.ToLower().ToCharArray();
//    Array.Reverse(charArray);
//    string reversed = new string(charArray);

//    return str.ToLower() == reversed;
//}

//// 27
//static int Add(int a, int b)  //функция
//{
//    return a + b;
//}

//static void PrintSum(int a, int b)  //процедура
//{
//    Console.WriteLine($"Сумма: {a + b}");
//}

//// 28
//static void PrintHelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}
//// 29
//static int Square(int number)
//{
//    return number * number;
//}

//// 30
//static void IncrementByTen(ref int number)
//{
//    number += 10;
//}

//// 31
//static double CalculateCircleArea(double radius)  //Функция
//{
//    return Math.PI * radius * radius;
//}

//static void DisplayCircleArea(double radius)  //Процедура
//{
//    double area = Math.PI * radius * radius;
//    Console.WriteLine($"Площадь круга: {area:F2}");
//}

//// 32
//static string ConvertToUpperCase(string text)  //Функция
//{
//    return text.ToUpper();
//}

//static void PrintUpperCase(string text)  //Процедура
//{
//    Console.WriteLine(text.ToUpper());
//}

//// 33
//static double Square(double number)
//{
//    return number * number;
//}

//// 34
//static long Square(long number)
//{
//    return number * number;
//}

//// 35
//static bool IsAdult(int age)  //Функция
//{
//    return age >= 18;
//}

//static void CheckAge(int age)  //Процедура
//{
//    if (age >= 18)
//        Console.WriteLine("Совершеннолетний");
//    else
//        Console.WriteLine("Несовершеннолетний");
//}

//// 36
//static void ShowHelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}

//// 37
//static void DisplayHelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}

//// 38
//static void DoubleValue(ref int value)
//{
//    value *= 2;
//}
//// 39
//static void PrintHelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}

//// 40
//static int Multiply(int a, int b)  //Функция
//{
//    return a * b;
//}

//static void ShowMultiplication(int a, int b)  //Процедура
//{
//    Console.WriteLine($"{a} * {b} = {a * b}");
//}

//// 41
//static string FormatName(string firstName, string lastName)  //Функция
//{
//    return $"{lastName}, {firstName}";
//}

//static void DisplayFormattedName(string firstName, string lastName)  //Процедура
//{
//    Console.WriteLine($"{lastName}, {firstName}");
//}

//// 42
//static bool IsPalindrome(string text)
//{
//    if (string.IsNullOrEmpty(text))
//        return true;

//    string cleaned = new string(text.ToLower()
//                                 .Where(char.IsLetterOrDigit)
//                                 .ToArray());

//    return cleaned.SequenceEqual(cleaned.Reverse());
//}

//// 43
//static DateTime GetNextWeekDate()  //Функция
//{
//    return DateTime.Now.AddDays(7);
//}

//static void ShowNextWeekDate()  //Процедура
//{
//    DateTime nextWeek = DateTime.Now.AddDays(7);
//    Console.WriteLine($"Дата через неделю: {nextWeek:dd.MM.yyyy}");
//}

//// 44
//static void HelloWorld()
//{
//    Console.WriteLine("Hello, World!");
//}

//// 45
//static void AddFive(ref int number)
//{
//    number += 5;
//}

//// 46
//static int FindMin(int[] array)
//{
//    if (array == null || array.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    int min = array[0];
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (array[i] < min)
//            min = array[i];
//    }
//    return min;
//}

//// 47
//static double CalculateAverage(int[] array)
//{
//    if (array == null || array.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    double sum = 0;
//    foreach (int num in array)
//        sum += num;

//    return sum / array.Length;
//}

//// 48
//static int[] CopyArray(int[] source)
//{
//    if (source == null)
//        return null;

//    int[] copy = new int[source.Length];
//    for (int i = 0; i < source.Length; i++)
//        copy[i] = source[i];

//    return copy;
//}

//// 49
//static double GetAverage(double[] array)
//{
//    if (array == null || array.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    return array.Average();
//}

//// 50
//static double FindMinimum(double[] array)
//{
//    if (array == null || array.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    double min = array[0];
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (array[i] < min)
//            min = array[i];
//    }
//    return min;
//}

//// 51
//static int GetStringLength(string text)
//{
//    return text?.Length ?? 0;
//}

//// 52
//static int GetMinValue(int[] numbers)
//{
//    if (numbers == null || numbers.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    return numbers.Min();
//}

//// 53
//static int StringLength(string input)
//{
//    if (input == null)
//        return 0;
//    return input.Length;
//}

// 54

//static T FindMin<T>(T[] array) where T : IComparable<T>
//{
//    if (array == null || array.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    T min = array[0];
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (array[i].CompareTo(min) < 0)
//            min = array[i];
//    }
//    return min;
//}

// 55.
//using System;

//static int Add(int a, int b)
//{
//    return a + b;
//}

//static int Add(int a, int b, int c)
//{
//    return a + b + c;
//}

//// 56
//static double CalculateAverage(int[] array)
//{
//    if (array == null || array.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    int sum = 0;
//    foreach (int num in array)
//        sum += num;

//    return (double)sum / array.Length;
//}

//// 57
//static double GetAverage(double[] numbers)
//{
//    if (numbers == null || numbers.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    return numbers.Average();
//}

//// 58
//static double Add(double a, double b)
//{
//    return a + b;
//}

//static double Add(double a, double b, double c)
//{
//    return a + b + c;
//}

//// 59
//static int GetLength(string text)
//{
//    return text?.Length ?? 0;
//}

//// 60
//static decimal CalculateAverage(decimal[] array)
//{
//    if (array == null || array.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    decimal sum = 0;
//    foreach (decimal num in array)
//        sum += num;

//    return sum / array.Length;
//}

//// 61
//static decimal Add(decimal a, decimal b)
//{
//    return a + b;
//}

//static decimal Add(decimal a, decimal b, decimal c)
//{
//    return a + b + c;
//}

//// 62
//static float Average(float[] values)
//{
//    if (values == null || values.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    float sum = 0;
//    for (int i = 0; i < values.Length; i++)
//        sum += values[i];

//    return sum / values.Length;
//}

//// 63
//static int[] CopyArray(int[] source)
//{
//    if (source == null)
//        return null;

//    int[] copy = new int[source.Length];
//    Array.Copy(source, copy, source.Length);
//    return copy;
//}

//// 64
//static int StringSize(string input)
//{
//    if (string.IsNullOrEmpty(input))
//        return 0;
//    return input.Length;
//}

//// 65
//static T[] DuplicateArray<T>(T[] original)
//{
//    if (original == null)
//        return null;

//    T[] copy = new T[original.Length];
//    for (int i = 0; i < original.Length; i++)
//        copy[i] = original[i];

//    return copy;
//}

//// 66
//static int TextLength(string str)
//{
//    return str == null ? 0 : str.Length;
//}

//// 67
//static long Add(long a, long b)
//{
//    return a + b;
//}

//static long Add(long a, long b, long c)
//{
//    return a + b + c;
//}

//// 68
//static int MeasureString(string text)
//{
//    return text?.Length ?? 0;
//}

//// 69
//static int CountCharacters(string inputString)
//{
//    if (inputString == null)
//        return 0;
//    return inputString.Length;
//}

//// 70
//static float Add(float x, float y)
//{
//    return x + y;
//}

//static float Add(float x, float y, float z)
//{
//    return x + y + z;
//}

//// 71
//static int GetStringSize(string text)
//{
//    return text == null ? 0 : text.Length;
//}
//// 72
//static double ComputeAverage(int[] numbers)
//{
//    if (numbers == null || numbers.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    double sum = 0;
//    foreach (int num in numbers)
//        sum += num;

//    return sum / numbers.Length;
//}

//// 73
//static int FindMinimum(int[] array)
//{
//    if (array == null || array.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    int min = array[0];
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (array[i] < min)
//            min = array[i];
//    }
//    return min;
//}

//// 74
//static int Sum(int a, int b)
//{
//    return a + b;
//}

//static int Sum(int a, int b, int c)
//{
//    return a + b + c;
//}

//// 75
//static double GetMinValue(double[] values)
//{
//    if (values == null || values.Length == 0)
//        throw new ArgumentException("Массив не может быть пустым");

//    double min = values[0];
//    for (int i = 1; i < values.Length; i++)
//    {
//        if (values[i] < min)
//            min = values[i];
//    }
//    return min;
//}

//// 76
//static int ValidateAge(int age)
//{
//    if (age < 0)
//        return -1; 
//    if (age > 150)
//        return -2; 

//    return 0; 
//}

//// 77
//static int CheckPassword(string password)
//{
//    if (string.IsNullOrEmpty(password))
//        return -1; 
//    if (password.Length < 8)
//        return -2; 

//    return 0; 
//}

//// 78
//static bool IsDivisibleByThree(int number)
//{
//    return number % 3 == 0;
//}

//// 79
//static bool CheckDivisionByThree(int value)
//{
//    if (value % 3 == 0)
//        return true;
//    else
//        return false;
//}

//// 80
//static string GetGrade(int score)
//{
//    if (score < 0 || score > 100)
//        return "Invalid score"; 

//    if (score >= 90)
//        return "A";
//    if (score >= 80)
//        return "B";
//    if (score >= 70)
//        return "C";
//    if (score >= 60)
//        return "D";

//    return "F";
//}

//// 81
//static string ProcessString(string input)
//{
//    if (string.IsNullOrWhiteSpace(input))
//        return null; 

//    return input.ToUpper();
//}

//// 82
//static int ValidateEmail(string email)
//{
//    if (string.IsNullOrEmpty(email))
//        return -1; 
//    if (!email.Contains("@"))
//        return -2; 

//    return 0; 
//}

//// 83
//static bool IsValidTriangle(double a, double b, double c)
//{
//    if (a <= 0 || b <= 0 || c <= 0)
//        return false; 

//    if (a + b <= c || a + c <= b || b + c <= a)
//        return false; 

//    return true;
//}

//// 84
//static string EvaluateNumber(int number)
//{
//    if (number == 0)
//        return "Zero";

//    if (number > 0)
//        return "Positive";

//    return "Negative";
//}

//// 85
//static int ValidateUserData(string username, int age)
//{
//    if (string.IsNullOrEmpty(username))
//        return -1; 
//    if (username.Length < 3)
//        return -2; 
//    if (age < 0)
//        return -3;
//    if (age < 18)
//        return -4; 

//    return 0; 
//}

//// 86
//static string GetTimeOfDay(int hour)
//{
//    if (hour < 0 || hour > 23)
//        return "Invalid hour";

//    if (hour >= 5 && hour < 12)
//        return "Morning";

//    if (hour >= 12 && hour < 17)
//        return "Afternoon";

//    if (hour >= 17 && hour < 21)
//        return "Evening";

//    return "Night";
//}

//// 87
//static double CalculateSquareRoot(double number)
//{
//    if (number < 0)
//        return double.NaN; 

//    return Math.Sqrt(number);
//}

//// 88
//static bool IsMultipleOfThree(int num)
//{
//    return num % 3 == 0;
//}

//// 89
//static string CheckAccessLevel(int userLevel)
//{
//    if (userLevel < 0)
//        return "Invalid level"; 

//    if (userLevel >= 10)
//        return "Admin access";

//    if (userLevel >= 5)
//        return "Moderator access";

//    if (userLevel >= 1)
//        return "User access";

//    return "No access";
//}
//// 90
//static string GetSeason(int month)
//{
//    if (month < 1 || month > 12)
//        return "Invalid month";

//    if (month >= 3 && month <= 5)
//        return "Spring";

//    if (month >= 6 && month <= 8)
//        return "Summer";

//    if (month >= 9 && month <= 11)
//        return "Autumn";

//    return "Winter";
//}

//// 91
//static int ValidateTemperature(double temperature)
//{
//    if (temperature < -273.15)
//        return -1; 
//    if (temperature > 10000)
//        return -2; 

//    return 0; 
//}

//// 92
//static string? FormatName(string firstName, string lastName)
//{
//    if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
//        return null;

//    return $"{lastName.Trim()}, {firstName.Trim()}";
//}

//// 93
//static double CalculateBMI(double weight, double height)
//{
//    if (weight <= 0 || height <= 0)
//        return -1; 

//    if (height > 3) 
//        height /= 100;

//    return weight / (height * height);
//}

//// 94
//static int ValidateCoordinates(double x, double y)
//{
//    if (double.IsNaN(x) || double.IsNaN(y))
//        return -1; 
//    if (double.IsInfinity(x) || double.IsInfinity(y))
//        return -2; 

//    return 0; 
//}

//// 95
//static bool IsThreeDivisible(int number)
//{
//    return number % 3 == 0;
//}

//// 96
//static bool DivisibleByThree(int value)
//{
//    if (value % 3 == 0)
//        return true;
//    return false;
//}

//// 97
//static bool CheckThreeDivision(int num)
//{
//    return num % 3 == 0 ? true : false;
//}

//// 98
//static int ValidateFileSize(long fileSize)
//{
//    if (fileSize < 0)
//        return -1; 
//    if (fileSize == 0)
//        return -2; 
//    if (fileSize > 10L * 1024 * 1024 * 1024) 
//        return -3; 

//    return 0; 
//}

//// 99
//static string CheckNumberType(int number)
//{
//    if (number == 0)
//        return "Zero";

//    if (number % 2 == 0)
//        return "Even";

//    return "Odd";
//}

//// 100
//static int ValidatePhoneNumber(string phone)
//{
//    if (string.IsNullOrEmpty(phone))
//        return -1; 
//    if (phone.Length < 10)
//        return -2; 
//    if (!phone.All(char.IsDigit))
//        return -3; 

//    return 0; 
//}

//// 101
//static int ValidatePercentage(double percent)
//{
//    if (percent < 0)
//        return -1; 
//    if (percent > 100)
//        return -2;

//    return 0; 
//}

//// 102
//static string? ReverseString(string input)
//{
//    if (string.IsNullOrEmpty(input))
//        return null;

//    char[] charArray = input.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}

//// 103
//static string? GetInitials(string fullName)
//{
//    if (string.IsNullOrWhiteSpace(fullName))
//        return null;

//    string[] names = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//    if (names.Length < 2)
//        return null;

//    return $"{names[0][0]}.{names[1][0]}.";
//}

//// 104
//static int Factorial(int n)
//{
//    if (n < 0)
//        return -1; 
//    if (n == 0 || n == 1)
//        return 1; 

//    return n * Factorial(n - 1);
//}

//// 105
//static string? CapitalizeWords(string text)
//{
//    if (string.IsNullOrWhiteSpace(text))
//        return null;

//    return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
//}

//// 106
//static double SafeDivide(double numerator, double denominator)
//{
//    if (denominator == 0)
//        throw new DivideByZeroException("Denominator cannot be zero");

//    if (double.IsInfinity(numerator) || double.IsInfinity(denominator))
//        throw new ArgumentException("Values cannot be infinity");

//    return numerator / denominator;
//}
//// 107
//public class User
//{
//    public string Name { get; }
//    public int Age { get; }

//    public User(string name, int age)
//    {
//        if (string.IsNullOrWhiteSpace(name))
//            throw new ArgumentException("Name cannot be null or empty", nameof(name));

//        if (age < 0 || age > 150)
//            throw new ArgumentOutOfRangeException(nameof(age), "Age must be between 0 and 150");

//        Name = name;
//        Age = age;
//    }
//}

//// 108
//static double DivideNumbers(double a, double b)
//{
//    if (b == 0)
//        throw new DivideByZeroException("Division by zero is not allowed");

//    return a / b;
//}

//// 109
//static double CalculateDiscount(double purchaseAmount, int discountPercent)
//{
//    if (purchaseAmount < 0)
//        throw new ArgumentOutOfRangeException(nameof(purchaseAmount), "Purchase amount cannot be negative");

//    if (discountPercent < 0 || discountPercent > 100)
//        throw new ArgumentOutOfRangeException(nameof(discountPercent), "Discount must be between 0 and 100 percent");

//    return purchaseAmount * (discountPercent / 100.0);
//}

//// 110
//static void PrintArray(int[] numbers)
//{
//    if (numbers == null || numbers.Length == 0)
//        return;

//    foreach (int number in numbers)
//        Console.WriteLine(number);
//}

//// 111
//static void ProcessData(string[] items)
//{
//    if (items == null || items.Length == 0)
//        return;

//    foreach (string item in items)
//        Console.WriteLine($"Processing: {item}");
//}

//// 112
//public class Product
//{
//    public string Name { get; }
//    public decimal Price { get; }

//    public Product(string name, decimal price)
//    {
//        if (string.IsNullOrWhiteSpace(name))
//            throw new ArgumentException("Product name cannot be null or empty", nameof(name));

//        if (price < 0)
//            throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative");

//        Name = name;
//        Price = price;
//    }
//}

//// 113
//static decimal SafeDivision(decimal dividend, decimal divisor)
//{
//    if (divisor == 0)
//        throw new InvalidOperationException("Divisor cannot be zero");

//    return dividend / divisor;
//}

//// 114
//static void ValidatePerson(Person person)
//{
//    if (person == null)
//        throw new ArgumentNullException(nameof(person));

//    Console.WriteLine($"Validating: {person.Name}");
//}

//// 115
//static void SaveToDatabase(string connectionString, object data)
//{
//    if (connectionString == null)
//        throw new ArgumentNullException(nameof(connectionString));

//    if (data == null)
//        throw new ArgumentNullException(nameof(data));

//    Console.WriteLine("Saving data to database...");
//}

//// 116
//static List<string> FilterItems(List<string> items, Func<string, bool> predicate)
//{
//    if (items == null)
//        throw new ArgumentNullException(nameof(items));

//    if (predicate == null)
//        throw new ArgumentNullException(nameof(predicate));

//    return items.Where(predicate).ToList();
//}

//// 117
//static void DisplayNumbers(int[] numbers)
//{
//    if (numbers == null || numbers.Length == 0)
//        return;

//    for (int i = 0; i < numbers.Length; i++)
//        Console.WriteLine($"Index {i}: {numbers[i]}");
//}

//// 118
//static void CalculateStatistics(double[] data)
//{
//    if (data == null || data.Length == 0)
//        return;

//    double sum = data.Sum();
//    double average = sum / data.Length;
//    Console.WriteLine($"Sum: {sum}, Average: {average}");
//}

//// 119
//static double CalculateRatio(double numerator, double denominator)
//{
//    if (denominator == 0)
//        throw new ArithmeticException("Denominator must not be zero");

//    if (double.IsNaN(numerator) || double.IsNaN(denominator))
//        throw new ArgumentException("Values cannot be NaN");

//    return numerator / denominator;
//}

//// 120
//public class BankAccount
//{
//    public string AccountNumber { get; }
//    public string OwnerName { get; }
//    public decimal Balance { get; private set; }

//    public BankAccount(string accountNumber, string ownerName, decimal initialBalance = 0)
//    {
//        if (string.IsNullOrWhiteSpace(accountNumber))
//            throw new ArgumentException("Account number cannot be null or empty", nameof(accountNumber));

//        if (string.IsNullOrWhiteSpace(ownerName))
//            throw new ArgumentException("Owner name cannot be null or empty", nameof(ownerName));

//        if (initialBalance < 0)
//            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance cannot be negative");

//        AccountNumber = accountNumber;
//        OwnerName = ownerName;
//        Balance = initialBalance;
//    }
//}

//121
//static void ProcessData(string input)
//{
//    if (input == null)
//    {
//        throw new ArgumentNullException(nameof(input), "Аргумент не может быть null.");
//    }

//    // Логика обработки данных
//}

//122
//static double Divide(double a, double b)
//{
//    if (b == 0)
//    {
//        throw new DivideByZeroException("Деление на ноль невозможно.");
//    }

//    return a / b;
//}

//123
//static double Divide(double a, double b)
//{
//    if (b == 0)
//    {
//        throw new DivideByZeroException("Деление на ноль невозможно.");
//    }

//    return a / b;
//}

//124
//public class User
//{
//    public string Name { get; }

//    public User(string name)
//    {
//        Name = name ?? throw new ArgumentNullException(nameof(name), "Имя пользователя обязательно.");
//    }
//}

//125
//static double Divide(double a, double b)
//{
//    if (b == 0)
//    {
//        throw new DivideByZeroException("Деление на ноль невозможно.");
//    }

//    return a / b;
//}

//126
//public class User
//{
//    public string Name { get; }

//    public User(string name)
//    {
//        Name = name ?? throw new ArgumentNullException(nameof(name), "Имя пользователя обязательно.");
//    }
//}

//127
//static int CalculateSum(int a, int b)
//{
//    int result = a + b;
//    if (result < 0)
//    {
//        throw new InvalidOperationException("Результат не может быть отрицательным.");
//    }

//    return result;
//}

//128
//public class User
//{
//    public string Name { get; }

//    public User(string name)
//    {
//        Name = name ?? throw new ArgumentNullException(nameof(name), "Имя пользователя обязательно.");
//    }
//}

//129
//static void ProcessData(string input)
//{
//    if (input == null)
//    {
//        throw new ArgumentNullException(nameof(input), "Аргумент не может быть null.");
//    }

//    // Логика обработки данных
//}

//130
//static void ProcessData(string input)
//{
//    if (input == null)
//    {
//        throw new ArgumentNullException(nameof(input), "Аргумент не может быть null.");
//    }

//    // Логика обработки данных
//}

//131
//public class User
//{
//    public string Name { get; }

//    public User(string name)
//    {
//        Name = name ?? throw new ArgumentNullException(nameof(name), "Имя пользователя обязательно.");
//    }
//}

//132
//static int CalculateSum(int a, int b)
//{
//    int result = a + b;
//    if (result < 0)
//    {
//        throw new InvalidOperationException("Результат не может быть отрицательным.");
//    }

//    return result;
//}

//133
//static int CalculateSum(int a, int b)
//{
//    int result = a + b;
//    if (result < 0)
//    {
//        throw new InvalidOperationException("Результат не может быть отрицательным.");
//    }

//    return result;
//}

//134
//static void ProcessData(string input)
//{
//    if (input == null)
//    {
//        throw new ArgumentNullException(nameof(input), "Аргумент не может быть null.");
//    }

//    // Логика обработки данных
//}

//135
//static int CalculateSum(int a, int b)
//{
//    int result = a + b;
//    if (result < 0)
//    {
//        throw new InvalidOperationException("Результат не может быть отрицательным.");
//    }

//    return result;
//}

//136
//static double Divide(double a, double b)
//{
//    if (b == 0)
//    {
//        throw new DivideByZeroException("Деление на ноль невозможно.");
//    }

//    return a / b;
//}

//137
//static void ProcessArray(int[] array)
//{
//    if (array == null || array.Length == 0)
//    {
//        return;
//    }

//    // Логика обработки массива
//}

//138
//static double Divide(double a, double b)
//{
//    if (b == 0)
//    {
//        throw new DivideByZeroException("Деление на ноль невозможно.");
//    }

//    return a / b;
//}

//139
//static void ProcessData(string input)
//{
//    if (input == null)
//    {
//        throw new ArgumentNullException(nameof(input), "Аргумент не может быть null.");
//    }

//    // Логика обработки данных
//}

//140
//static int CalculateSum(int a, int b)
//{
//    int result = a + b;
//    if (result < 0)
//    {
//        throw new InvalidOperationException("Результат не может быть отрицательным.");
//    }

//    return result;
//}

//141
//static double PerformCalculation(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        return 0;
//    }

//    return a * b;
//}

//142
//static bool CheckTime(int time, int minTime)
//{
//    if (time < minTime)
//    {
//        return false;
//    }

//    return true;
//}

//143
//static double PerformCalculation(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        return 0;
//    }

//    return a * b;
//}

//144
//static bool Authorize(string password, int minLength)
//{
//    if (password.Length < minLength)
//    {
//        throw new ArgumentException("Пароль слишком короткий.");
//    }

//    return true;
//}

//145
//static bool RegisterUser(string email, List<string> registeredEmails)
//{
//    if (registeredEmails.Contains(email))
//    {
//        throw new InvalidOperationException("Email уже зарегистрирован.");
//    }

//    registeredEmails.Add(email);
//    return true;
//}

//146
//static double PerformCalculation(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        return 0;
//    }

//    return a * b;
//}

//147
//static double PerformCalculation(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        return 0;
//    }

//    return a * b;
//}

//148
//static bool CheckTime(int time, int minTime)
//{
//    if (time < minTime)
//    {
//        return false;
//    }

//    return true;
//}

//149
//static bool CheckTime(int time, int minTime)
//{
//    if (time < minTime)
//    {
//        return false;
//    }

//    return true;
//}

//150
//static bool RegisterUser(string email, List<string> registeredEmails)
//{
//    if (registeredEmails.Contains(email))
//    {
//        Console.WriteLine("Ошибка: Email уже зарегистрирован.");
//        return false;
//    }

//    registeredEmails.Add(email);
//    Console.WriteLine("Регистрация успешна.");
//    return true;
//}

//151
//static bool CheckTime(int time, int minTime)
//{
//    if (time < minTime)
//    {
//        Console.WriteLine("Ошибка: Время меньше минимального.");
//        return false;
//    }

//    Console.WriteLine("Время корректно.");
//    return true;
//}

//152
//static double Calculate(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        Console.WriteLine("Ошибка: Разница слишком мала.");
//        return 0;
//    }

//    return a + b;
//}

//153
//static double Calculate(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        Console.WriteLine("Ошибка: Разница слишком мала.");
//        return 0;
//    }

//    return a + b;
//}

//154
//static bool Authorize(string password, int minLength)
//{
//    if (password.Length < minLength)
//    {
//        Console.WriteLine("Ошибка: Пароль слишком короткий.");
//        return false;
//    }

//    Console.WriteLine("Авторизация успешна.");
//    return true;
//}

//155
//static double Calculate(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        Console.WriteLine("Ошибка: Разница слишком мала.");
//        return 0;
//    }

//    return a + b;
//}

//156
//static bool RegisterUser(string email, List<string> registeredEmails)
//{
//    if (registeredEmails.Contains(email))
//    {
//        Console.WriteLine("Ошибка: Email уже зарегистрирован.");
//        return false;
//    }

//    registeredEmails.Add(email);
//    Console.WriteLine("Регистрация успешна.");
//    return true;
//}

//157
//static bool CheckDateFormat(string date, string format)
//{
//    if (!DateTime.TryParseExact(date, format, null, System.Globalization.DateTimeStyles.None, out _))
//    {
//        Console.WriteLine("Ошибка: Некорректный формат даты.");
//        return false;
//    }

//    Console.WriteLine("Формат даты корректен.");
//    return true;
//}

//158
//static bool Authorize(string password, int minLength)
//{
//    if (password.Length < minLength)
//    {
//        Console.WriteLine("Ошибка: Пароль слишком короткий.");
//        return false;
//    }

//    Console.WriteLine("Авторизация успешна.");
//    return true;
//}

//159
//static bool Authorize(string password, int minLength)
//{
//    if (password.Length < minLength)
//    {
//        Console.WriteLine("Ошибка: Пароль слишком короткий.");
//        return false;
//    }

//    Console.WriteLine("Авторизация успешна.");
//    return true;
//}

//160
//static bool RegisterUser(string email, List<string> registeredEmails)
//{
//    if (registeredEmails.Contains(email))
//    {
//        Console.WriteLine("Ошибка: Email уже зарегистрирован.");
//        return false;
//    }

//    registeredEmails.Add(email);
//    Console.WriteLine("Регистрация успешна.");
//    return true;
//}

//161
//static bool RegisterUser(string email, List<string> registeredEmails)
//{
//    if (registeredEmails.Contains(email))
//    {
//        Console.WriteLine("Ошибка: Email уже зарегистрирован.");
//        return false;
//    }

//    registeredEmails.Add(email);
//    Console.WriteLine("Регистрация успешна.");
//    return true;
//}

//162
//static bool CheckTime(int time, int minTime)
//{
//    if (time < minTime)
//    {
//        Console.WriteLine("Ошибка: Время меньше минимального.");
//        return false;
//    }

//    Console.WriteLine("Время корректно.");
//    return true;
//}

//163
//static bool Authorize(string password, int minLength)
//{
//    if (password.Length < minLength)
//    {
//        Console.WriteLine("Ошибка: Пароль слишком короткий.");
//        return false;
//    }

//    Console.WriteLine("Авторизация успешна.");
//    return true;
//}

//164
//static bool CheckTime(int time, int minTime)
//{
//    if (time < minTime)
//    {
//        Console.WriteLine("Ошибка: Время меньше минимального.");
//        return false;
//    }

//    Console.WriteLine("Время корректно.");
//    return true;
//}

//165
//static double Calculate(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        Console.WriteLine("Ошибка: Разница слишком мала.");
//        return 0;
//    }

//    return a + b;
//}

//166
//static bool Authorize(string password, int minLength)
//{
//    if (password.Length < minLength)
//    {
//        Console.WriteLine("Ошибка: Пароль слишком короткий.");
//        return false;
//    }

//    Console.WriteLine("Авторизация успешна.");
//    return true;
//}

//167
//static bool Authorize(string password, int minLength)
//{
//    if (password.Length < minLength)
//    {
//        Console.WriteLine("Ошибка: Пароль слишком короткий.");
//        return false;
//    }

//    Console.WriteLine("Авторизация успешна.");
//    return true;
//}

//168
//static bool CheckDateFormat(string date, string format)
//{
//    if (!DateTime.TryParseExact(date, format, null, System.Globalization.DateTimeStyles.None, out _))
//    {
//        Console.WriteLine("Ошибка: Некорректный формат даты.");
//        return false;
//    }

//    Console.WriteLine("Формат даты корректен.");
//    return true;
//}

//169
//static bool Authorize(string password, int minLength)
//{
//    if (password.Length < minLength)
//    {
//        Console.WriteLine("Ошибка: Пароль слишком короткий.");
//        return false;
//    }

//    Console.WriteLine("Авторизация успешна.");
//    return true;
//}

//170
//static double Calculate(double a, double b, out bool error)
//{
//    error = false;
//    if (Math.Abs(a - b) < 0.0001)
//    {
//        error = true;
//        Console.WriteLine("Ошибка: Разница слишком мала.");
//        return 0;
//    }

//    return a + b;
//}

//171
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//172
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//173
//static bool TryParseInt(string input, out int result)
//{
//    return int.TryParse(input, out result);
//}

//174
//static bool TryDivide(int a, int b, out double result)
//{
//    if (b == 0)
//    {
//        result = 0;
//        return false;
//    }

//    result = (double)a / b;
//    return true;
//}

//175
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//176
//static void Increment(ref int value)
//{
//    value++;
//}

//177
//static bool TryDivide(int a, int b, out double result)
//{
//    if (b == 0)
//    {
//        result = 0;
//        return false;
//    }

//    result = (double)a / b;
//    return true;
//}

//178
//static bool TryDivide(int a, int b, out double result)
//{
//    if (b == 0)
//    {
//        result = 0;
//        return false;
//    }

//    result = (double)a / b;
//    return true;
//}

//179
//static bool TryParseInt(string input, out int result)
//{
//    return int.TryParse(input, out result);
//}

//180
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//181
//static bool TryDivide(int a, int b, out double result)
//{
//    if (b == 0)
//    {
//        result = 0;
//        return false;
//    }

//    result = (double)a / b;
//    return true;
//}

//182
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//183
//static void Increment(ref int value)
//{
//    value++;
//}

//184
//static bool TryParseInt(string input, out int result)
//{
//    return int.TryParse(input, out result);
//}

//185
//static void Increment(ref int value)
//{
//    value++;
//}
//186
//static bool TryParseInt(string input, out int result)
//{
//    return int.TryParse(input, out result);
//}

//187
//static bool TryDivide(int a, int b, out double result)
//{
//    if (b == 0)
//    {
//        result = 0;
//        return false;
//    }

//    result = (double)a / b;
//    return true;
//}

//188
//static bool TryParseInt(string input, out int result)
//{
//    return int.TryParse(input, out result);
//}

//189
//static void Swap(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}


//190
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//191
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//192
//static void Swap(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}


//193
//static void Increment(ref int value)
//{
//    value++;
//}

//194
//static void Swap(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}


//195
//static bool TryDivide(int a, int b, out double result)
//{
//    if (b == 0)
//    {
//        result = 0;
//        return false;
//    }

//    result = (double)a / b;
//    return true;
//}

//196
//static bool TryDivide(int a, int b, out double result)
//{
//    if (b == 0)
//    {
//        result = 0;
//        return false;
//    }

//    result = (double)a / b;
//    return true;
//}

//197
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//198
//static bool TryDivide(int a, int b, out double result)
//{
//    if (b == 0)
//    {
//        result = 0;
//        return false;
//    }

//    result = (double)a / b;
//    return true;
//}

//199
//static int Divide(int a, int b, out int remainder)
//{
//    remainder = a % b;
//    return a / b;
//}

//200
//static void Swap(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
