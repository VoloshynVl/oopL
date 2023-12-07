class Program
{
    static void Main()
    {
        // task 1
        FileSystemManager.SetupFileSystem();
        Console.WriteLine();

        // task 2

         string filePath = "numbers.txt";  // Ім'я файлу для збереження чисел

        // Створення файлу та запис в нього випадкових цілих чисел
        GenerateRandomNumbersFile(filePath, 10);  // 10 - кількість випадкових чисел

        // Створення екземпляра класу NumberAnalyzer та аналіз чисел
        NumberAnalyzer numberAnalyzer = new NumberAnalyzer(filePath);
        numberAnalyzer.AnalyzeNumbers();
    }

    // Метод для генерації файлу з випадковими цілими числами
    static void GenerateRandomNumbersFile(string filePath, int count)
    {
        Random random = new Random();
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < count; i++)
            {
                writer.WriteLine(random.Next(1, 100));  // Генерація випадкового числа в діапазоні [1, 100)
            }
        }
    }
}