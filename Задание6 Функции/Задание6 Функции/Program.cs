using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        bool isPalindrome = CheckPalindrome(inputString);

        if (isPalindrome)
        {
            Console.WriteLine("Введенная строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенная строка не является палиндромом.");
        }
    }

    static bool CheckPalindrome(string input)
    {
        // Приводим строку к нижнему регистру и убираем пробелы
        string cleanedInput = input.ToLower().Replace(" ", "");

        // Создаем обратную копию строки
        char[] reversedArray = cleanedInput.ToCharArray();
        Array.Reverse(reversedArray);
        string reversedString = new string(reversedArray);

        // Сравниваем оригинальную и обратную строки
        return cleanedInput.Equals(reversedString);
    }
}
