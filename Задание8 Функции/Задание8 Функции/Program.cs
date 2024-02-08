using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 2)
        {
            bool isPrime = IsPrime(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} - простое число.");
            }
            else
            {
                Console.WriteLine($"{number} - не является простым числом.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число больше или равное 2.");
        }
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
}
