class Program
{
    static void Main()
    {
        // task 1

        // Створення екземплярів класів
        IShape circle1 = new Circle { FirstDimension = 5.0 };
        IShape circle2 = new Circle { FirstDimension = 7.5 };
        IShape circle3 = new Circle { FirstDimension = 10.0 };

        IColoredShape coloredCircle1 = new ColoredCircle { FirstDimension = 3.0, Color = "Red" };
        IColoredShape coloredCircle2 = new ColoredCircle { FirstDimension = 6.0, Color = "Blue" };
        IColoredShape coloredCircle3 = new ColoredCircle { FirstDimension = 8.0, Color = "Green" };

        // Створення масиву та заповнення його екземплярами
        IShape[] shapesArray = { circle1, circle2, circle3, coloredCircle1, coloredCircle2, coloredCircle3 };

        // Метод, що викликає методи для кожного елемента масиву в залежності від інтерфейсу
        DisplayShapes(shapesArray);
        Console.WriteLine();
        
        //task 2

        // Створення масиву типу Printable
        Printable[] printables = {
            new Book("C# Programming"),
            new Magazine("C# Weekly"),
            new Book("Object-Oriented Design"),
            new Magazine("Tech Insights")
        };

        // Виклик методу Print() для кожного об'єкта в масиві
        foreach (var printable in printables)
        {
            printable.Print();
        }

        // Виклик статичного методу PrintMagazines
        Magazine.PrintMagazines(printables);
        Console.WriteLine();

        // task3

        // Створення масиву з усіх типів одягу
        Clothing[] clothingArray = {
            new TShirt("M", 20.0, "Red"),
            new Pants("L", 40.0, "Blue"),
            new Skirt("S", 30.0, "Black"),
            new Tie("L", 15.0, "Striped")
        };

        // Створення об'єкта Ательє та виклик методів одягу
        Atelier atelier = new Atelier();
        atelier.DressWoman(Array.FindAll(clothingArray, item => item is IWomensClothing).Cast<IWomensClothing>().ToArray());
        atelier.DressMan(Array.FindAll(clothingArray, item => item is IMensClothing).Cast<IMensClothing>().ToArray());
    }



    static void DisplayShapes(IShape[] shapes)
    {
        foreach (var shape in shapes)
        {
            shape.DisplayType();
            shape.DisplayArea();

            if (shape is IColoredShape coloredShape)
            {
                coloredShape.DisplayColor();
            }

            Console.WriteLine();
        }
    }
}