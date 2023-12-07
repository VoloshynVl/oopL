// Інтерфейс Printable
interface Printable
{
    void Print();
}

// Клас Book реалізує інтерфейс Printable
class Book : Printable
{
    private string title;

    public Book(string title)
    {
        this.title = title;
    }

    public void Print()
    {
        Console.WriteLine("Book: " + title);
    }
}

// Клас Magazine реалізує інтерфейс Printable
class Magazine : Printable
{
    private string title;

    public Magazine(string title)
    {
        this.title = title;
    }

    public void Print()
    {
        Console.WriteLine("Magazine: " + title);
    }

    // Статичний метод, що виводить на консоль назви лише журналів
    public static void PrintMagazines(Printable[] printables)
    {
        Console.WriteLine("\nMagazines Only:");
        foreach (var printable in printables)
        {
            if (printable is Magazine)
            {
                printable.Print();
            }
        }
    }
}