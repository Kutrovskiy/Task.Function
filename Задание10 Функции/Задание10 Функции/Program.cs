using System;

class Program
{
    static void Main()
    {
        // Пример двумерного массива чисел
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int sum = CalculateArraySum(matrix);

        Console.WriteLine($"Сумма всех элементов массива: {sum}");
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
