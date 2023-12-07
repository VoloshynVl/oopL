using System.Globalization;

class DateProcessor
{
    public static void ProcessDateStrings(string inputDates)
    {
        string[] dateStrings = inputDates.Split(',');

        DateTime[] dates = dateStrings.Select(dateString => DateTime.ParseExact(dateString.Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture)).ToArray();

        // a) Рік з найменшим номером
        int minYear = dates.Min(date => date.Year);
        Console.WriteLine($"a) Рік з найменшим номером: {minYear}");

        // b) Всі весняні дати
        var springDates = dates.Where(date => date.Month >= 3 && date.Month <= 5);
        Console.WriteLine("b) Весняні дати:");
        foreach (var springDate in springDates)
        {
            Console.WriteLine(springDate.ToString("dd-MM-yyyy"));
        }

        // c) Сама пізня дата
        DateTime latestDate = dates.Max();
        Console.WriteLine($"c) Сама пізня дата: {latestDate.ToString("dd-MM-yyyy")}");
    }
}