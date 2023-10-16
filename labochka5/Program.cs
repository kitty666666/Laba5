using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");
        double number1 = Convert.ToDouble(); // Ошибка: Не указан аргумент

        Console.WriteLine("Введите второе число: ");
        double number2 = Convert.ToDouble(); // Ошибка: Не указан аргумент

        // Найдем среднее значение двух чисел
        double average = (number1 + number2) / 2.0;

        Console.WriteLine("Среднее значение: " + average);
    }
}