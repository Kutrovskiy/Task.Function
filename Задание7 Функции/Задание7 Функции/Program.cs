using System;

class Program
{
    static void Main()
    {
        // Пример массивов целых чисел
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };

        int[] mergedArray = MergeArrays(array1, array2);

        Console.WriteLine("Объединенный массив:");
        foreach (int element in mergedArray)
        {
            Console.Write($"{element} ");
        }
    }

    static int[] MergeArrays(int[] array1, int[] array2)
    {
        int length1 = array1.Length;
        int length2 = array2.Length;

        // Создаем новый массив с суммарной длиной двух массивов
        int[] mergedArray = new int[length1 + length2];

        // Копируем элементы первого массива в новый массив
        Array.Copy(array1, mergedArray, length1);

        // Копируем элементы второго массива в новый массив, начиная с конечной позиции первого массива
        Array.Copy(array2, 0, mergedArray, length1, length2);

        return mergedArray;
    }
}
