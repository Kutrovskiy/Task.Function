using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Введите второе число:");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                int result = SumNumbers(num1, num2);
                Console.WriteLine($"Сумма чисел {num1} и {num2} равна {result}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода второго числа. Пожалуйста, введите целое число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода первого числа. Пожалуйста, введите целое число.");
        }
    }

    static int SumNumbers(int a, int b)
    {
        return a + b;
    }
}
