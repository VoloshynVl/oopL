using System.Globalization;

class Program
{
    static void Main()
    {
        // Завдання 1: Заміна символів в рядку
        Console.WriteLine("Введіть рядок:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Введіть позицію, з якої починати заміну:");
        int startPosition = int.Parse(Console.ReadLine());

        string resultString = StringReplacer.ReplaceOnesAndZeros(inputString, startPosition);
        Console.WriteLine("Результат заміни: " + resultString);

        System.Console.WriteLine();
        // Завдання 2: Підрахунок кількості днів до вказаної дати
        Console.WriteLine("Введіть дату у форматі (рік-місяць-день):");
        DateTime targetDate = DateTime.Parse(Console.ReadLine());

        TimeSpan remainingDays = DateCalculator.CalculateRemainingDays(targetDate);

        if (remainingDays.TotalDays < 0)
            Console.WriteLine("Вказана дата вже минула.");
        else
            Console.WriteLine($"Залишилося {Convert.ToInt32(remainingDays.TotalDays)} днів до вказаної дати.");

        System.Console.WriteLine();
        // Завдання 3: Обробка рядка з трьома різними датами
        Console.WriteLine("Введіть рядок з трьома датами у форматі (день-місяць-рік), розділені комою:");
        string inputDates = Console.ReadLine();

        DateProcessor.ProcessDateStrings(inputDates);
    }
}