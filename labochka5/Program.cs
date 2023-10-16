using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Найдем среднее значение двух чисел
        double average = (number1 + number2) / 2.0;

        Console.WriteLine("Среднее значение: " + average);
        Console.WriteLine("Добра и позитива");
    }
}