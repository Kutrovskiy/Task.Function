using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        int length = CalculateStringLength(inputString);

        Console.WriteLine($"Длина строки: {length}");
    }

    static int CalculateStringLength(string input)
    {
        return input.Length;
    }
}
