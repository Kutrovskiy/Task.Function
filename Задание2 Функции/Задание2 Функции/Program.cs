using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите радиус окружности:");
        if (double.TryParse(Console.ReadLine(), out double radius) && radius >= 0)
        {
            double area = CalculateCircleArea(radius);
            Console.WriteLine($"Площадь окружности с радиусом {radius} равна {area:F2}");
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное число для радиуса окружности.");
        }
    }

    static double CalculateCircleArea(double radius)
    {
        // Формула для вычисления площади окружности: π * r^2
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }
}
