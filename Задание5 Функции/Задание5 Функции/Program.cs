using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"Факториал числа {number} равен {factorial}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите неотрицательное целое число.");
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Число должно быть неотрицательным.");
        }

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
}
