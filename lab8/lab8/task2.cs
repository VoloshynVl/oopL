using System;
using System.IO;

class NumberAnalyzer
{
    private int[] numbers;

    // Конструктор класу NumberAnalyzer, який зчитує числа з файлу за вказаним шляхом
    public NumberAnalyzer(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            numbers = Array.ConvertAll(lines, int.Parse);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    // Метод для аналізу чисел та виведення різних характеристик
    public void AnalyzeNumbers()
    {
        // Перевірка, чи числа були успішно зчитані
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Немає чисел для аналізу.");
            return;
        }

        // Виведення початкового масиву чисел
        Console.WriteLine("Початкові числа:");
        PrintNumbers();

        // Підрахунок кількості парних чисел та їх виведення
        int countEvenNumbers = CountEvenNumbers();
        Console.WriteLine($"1) Кількість парних чисел: {countEvenNumbers}");

        // Підрахунок кількості подвоєних парних чисел та їх виведення
        int countDoubledEvenNumbers = CountDoubledEvenNumbers();
        Console.WriteLine($"2) Кількість подвоєних парних чисел: {countDoubledEvenNumbers}");

        // Підрахунок кількості квадратів непарних чисел та їх виведення
        int countSquaresOfOddNumbers = CountSquaresOfOddNumbers();
        Console.WriteLine($"3) Кількість квадратів непарних чисел: {countSquaresOfOddNumbers}");
    }

    // Виведення чисел
    private void PrintNumbers()
    {
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    // Підрахунок кількості парних чисел та їх виведення
    private int CountEvenNumbers()
    {
        int count = 0;
        Console.WriteLine("Парні числа:");
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
                count++;
            }
        }
        Console.WriteLine();
        return count;
    }

    // Підрахунок кількості подвоєних парних чисел та їх виведення
    private int CountDoubledEvenNumbers()
    {
        int count = 0;
        Console.WriteLine("Подвоєні парні числа:");
        foreach (var number in numbers)
        {
            if (number % 2 == 0 && Array.IndexOf(numbers, number * 2) != -1)
            {
                Console.Write(number + " ");
                count++;
            }
        }
        Console.WriteLine();
        return count;
    }

    // Підрахунок кількості квадратів непарних чисел та їх виведення
    private int CountSquaresOfOddNumbers()
    {
        int count = 0;
        Console.WriteLine("Квадрати непарних чисел:");
        foreach (var number in numbers)
        {
            if (number % 2 != 0 && Array.IndexOf(numbers, number * number) != -1)
            {
                Console.Write(number + " ");
                count++;
            }
        }
        Console.WriteLine();
        return count;
    }
}
