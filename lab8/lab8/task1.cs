class FileSystemManager
{
    // Метод для налаштування файлової системи
    public static void SetupFileSystem()
    {
        try
        {
            // Задання кореневого каталогу
            string rootDirectory = @"D:\OOP_lab08";
            Directory.CreateDirectory(rootDirectory);

            // Задання номеру групи та вашого прізвища
            string groupNumber = "KNms1b23";
            string yourLastName = "Voloshin";

            // Формування шляхів до підкаталогів
            string groupDirectory = Path.Combine(rootDirectory, groupNumber);
            string yourLastNameDirectory = Path.Combine(rootDirectory, yourLastName);
            string sourcesDirectory = Path.Combine(rootDirectory, "Sources");
            string reportsDirectory = Path.Combine(rootDirectory, "Reports");
            string textsDirectory = Path.Combine(rootDirectory, "Texts");

            Console.WriteLine("Крок 1: Створення кореневого каталогу");
            CreateDirectory(rootDirectory);

            Console.WriteLine("Крок 2: Створення підкаталогів");
            CreateDirectory(groupDirectory);
            CreateDirectory(yourLastNameDirectory);
            CreateDirectory(sourcesDirectory);
            CreateDirectory(reportsDirectory);
            CreateDirectory(textsDirectory);

            Console.WriteLine("Крок 3: Копіювання каталогів");
            CopyDirectory(textsDirectory, Path.Combine(yourLastNameDirectory, "Texts"));
            CopyDirectory(sourcesDirectory, Path.Combine(yourLastNameDirectory, "Sources"));
            CopyDirectory(reportsDirectory, Path.Combine(yourLastNameDirectory, "Reports"));

            Console.WriteLine("Крок 4: Переміщення каталогу");
            MoveDirectory(yourLastNameDirectory, Path.Combine(groupDirectory, yourLastName));

            Console.WriteLine("Крок 5: Створення файлу dirinfo.txt");
            string dirinfoPath = Path.Combine(textsDirectory, "dirinfo.txt");
            CreateDirInfoFile(dirinfoPath, textsDirectory);

            Console.WriteLine("Операції виконано успішно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    // Метод для створення каталогу
    private static void CreateDirectory(string directoryPath)
    {
        Console.WriteLine($"Створення каталогу: {directoryPath}");
        Directory.CreateDirectory(directoryPath);
    }

    /// Метод для копіювання каталогу
    private static void CopyDirectory(string sourceDirName, string destDirName)
    {
        Console.WriteLine($"Копіювання каталогу з {sourceDirName} у {destDirName}");

        DirectoryInfo sourceDir = new DirectoryInfo(sourceDirName);
        DirectoryInfo destDir = new DirectoryInfo(destDirName);

        // Create the destination directory if it doesn't exist
        if (!destDir.Exists)
        {
            CreateDirectory(destDir.FullName);
        }

        foreach (FileInfo file in sourceDir.GetFiles())
        {
            file.CopyTo(Path.Combine(destDir.FullName, file.Name), false);
        }

        foreach (DirectoryInfo subDir in sourceDir.GetDirectories())
        {
            string subDirPath = Path.Combine(destDir.FullName, subDir.Name);
            CopyDirectory(subDir.FullName, subDirPath);
        }
    }

    // Метод для переміщення каталогу
    private static void MoveDirectory(string sourceDirName, string destDirName)
    {
        Console.WriteLine($"Переміщення каталогу з {sourceDirName} у {destDirName}");
        Directory.Move(sourceDirName, destDirName);
    }

    // Метод для створення файлу dirinfo.txt
    private static void CreateDirInfoFile(string filePath, string directoryPath)
    {
        Console.WriteLine($"Створення файлу dirinfo.txt в {directoryPath}");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"Інформація про каталог: {directoryPath}");
            writer.WriteLine($"Створено: {DateTime.Now}");
            writer.WriteLine("Зміст:");

            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                writer.WriteLine($"- {Path.GetFileName(file)}");
            }

            string[] subdirectories = Directory.GetDirectories(directoryPath);
            foreach (string subdirectory in subdirectories)
            {
                writer.WriteLine($"- {Path.GetFileName(subdirectory)}/");
            }
        }
    }
}
