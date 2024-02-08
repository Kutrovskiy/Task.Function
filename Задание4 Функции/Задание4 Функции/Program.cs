using System;

class Program
{
    static void Main()
    {
        // Пример массива целых чисел
        int[] numbers = { 7, 15, 3, 22, 10, 5 };

        int maxNumber = FindMaxNumber(numbers);

        Console.WriteLine($"Наибольшее значение в массиве: {maxNumber}");
    }

    static int FindMaxNumber(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Массив не может быть пустым или равным null.");
        }

        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }
}
