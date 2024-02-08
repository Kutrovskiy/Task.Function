using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        string reversedString = ReverseString(inputString);

        Console.WriteLine($"Строка в обратном порядке: {reversedString}");
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
