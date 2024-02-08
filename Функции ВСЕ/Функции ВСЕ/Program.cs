using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задание:");
        Console.WriteLine("1. Сумма двух чисел");
        Console.WriteLine("2. Площадь окружности");
        Console.WriteLine("3. Длина строки");
        Console.WriteLine("4. Наибольшее значение в массиве");
        Console.WriteLine("5. Факториал числа");
        Console.WriteLine("6. Проверка на палиндром");
        Console.WriteLine("7. Объединение двух массивов");
        Console.WriteLine("8. Проверка на простое число");
        Console.WriteLine("9. Строка в обратном порядке");
        Console.WriteLine("10. Сумма всех элементов двумерного массива");

        int choice;

        while (true)
        {
            Console.Write("Введите номер задания (или 0 для выхода): ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Программа завершена.");
                        return;

                    case 1:
                        Console.WriteLine("Введите два целых числа:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Сумма чисел: {Sum(num1, num2)}");
                        break;

                    case 2:
                        Console.WriteLine("Введите радиус окружности:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Площадь окружности: {CalculateCircleArea(radius)}");
                        break;

                    case 3:
                        Console.WriteLine("Введите строку:");
                        string inputString = Console.ReadLine();
                        Console.WriteLine($"Длина строки: {CalculateStringLength(inputString)}");
                        break;

                    case 4:
                        int[] array = { 7, 15, 3, 22, 10, 5 };
                        Console.WriteLine($"Наибольшее значение в массиве: {FindMaxNumber(array)}");
                        break;

                    case 5:
                        Console.WriteLine("Введите число:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Факториал числа: {CalculateFactorial(number)}");
                        break;

                    case 6:
                        Console.WriteLine("Введите строку:");
                        string palindromeString = Console.ReadLine();
                        Console.WriteLine($"Это палиндром: {IsPalindrome(palindromeString)}");
                        break;

                    case 7:
                        int[] array1 = { 1, 2, 3 };
                        int[] array2 = { 4, 5, 6 };
                        int[] mergedArray = MergeArrays(array1, array2);
                        Console.WriteLine("Объединенный массив:");
                        foreach (int element in mergedArray)
                        {
                            Console.Write($"{element} ");
                        }
                        break;

                    case 8:
                        Console.WriteLine("Введите число:");
                        int primeNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Это простое число: {IsPrime(primeNumber)}");
                        break;

                    case 9:
                        Console.WriteLine("Введите строку:");
                        string reverseString = Console.ReadLine();
                        Console.WriteLine($"Строка в обратном порядке: {ReverseString(reverseString)}");
                        break;

                    case 10:
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                        };
                        Console.WriteLine($"Сумма всех элементов массива: {CalculateArraySum(matrix)}");
                        break;

                    default:
                        Console.WriteLine("Некорректный номер задания. Пожалуйста, введите существующий номер.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }
        }
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }

    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static int CalculateStringLength(string input)
    {
        return input.Length;
    }

    static int FindMaxNumber(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static bool IsPalindrome(string input)
    {
        string cleanedInput = input.ToLower().Replace(" ", "");
        char[] reversedArray = cleanedInput.ToCharArray();
        Array.Reverse(reversedArray);
        string reversedString = new string(reversedArray);
        return cleanedInput.Equals(reversedString);
    }

    static int[] MergeArrays(int[] array1, int[] array2)
    {
        int length1 = array1.Length;
        int length2 = array2.Length;
        int[] mergedArray = new int[length1 + length2];
        Array.Copy(array1, mergedArray, length1);
        Array.Copy(array2, 0, mergedArray, length1, length2);
        return mergedArray;
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int CalculateArraySum(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }
        }
        return sum;
    }
}
