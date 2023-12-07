// Інтерфейс "Чоловічий Одяг"
interface IMensClothing
{
    void DressMan();
}

// Інтерфейс "Жіночий Одяг"
interface IWomensClothing
{
    void DressWoman();
}

// Абстрактний клас Одяг
abstract class Clothing
{
    protected string size;
    protected double cost;
    protected string color;

    public Clothing(string size, double cost, string color)
    {
        this.size = size;
        this.cost = cost;
        this.color = color;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Size: {size}, Cost: {cost}, Color: {color}");
    }
}

// Клас Футболка, який реалізує інтерфейси "Чоловічий Одяг" та "Жіночий Одяг"
class TShirt : Clothing, IMensClothing, IWomensClothing
{
    public TShirt(string size, double cost, string color) : base(size, cost, color) { }

    public void DressMan()
    {
        Console.WriteLine("Man is dressed in T-shirt. ");
        DisplayInfo();
    }

    public void DressWoman()
    {
        Console.WriteLine("Woman is dressed in T-shirt. ");
        DisplayInfo();
    }
}

// Клас Штани, який реалізує інтерфейси "Чоловічий Одяг" та "Жіночий Одяг"
class Pants : Clothing, IMensClothing, IWomensClothing
{
    public Pants(string size, double cost, string color) : base(size, cost, color) { }

    public void DressMan()
    {
        Console.WriteLine("Man is dressed in Pants. ");
        DisplayInfo();
    }

    public void DressWoman()
    {
        Console.WriteLine("Woman is dressed in Pants. ");
        DisplayInfo();
    }
}

// Клас Спідниця, який реалізує інтерфейс "Жіночий Одяг"
class Skirt : Clothing, IWomensClothing
{
    public Skirt(string size, double cost, string color) : base(size, cost, color) { }

    public void DressWoman()
    {
        Console.WriteLine("Woman is dressed in Skirt. ");
        DisplayInfo();
    }
}

// Клас Краватка, який реалізує інтерфейс "Чоловічий Одяг"
class Tie : Clothing, IMensClothing
{
    public Tie(string size, double cost, string color) : base(size, cost, color) { }

    public void DressMan()
    {
        Console.WriteLine("Man is dressed in Tie. ");
        DisplayInfo();
    }
}

// Клас Ательє
class Atelier
{
    public void DressWoman(IWomensClothing[] womensClothing)
    {
        Console.WriteLine("Dressing Woman:");
        foreach (var clothing in womensClothing)
        {
            clothing.DressWoman();
            Console.WriteLine();
        }
    }

    public void DressMan(IMensClothing[] mensClothing)
    {
        Console.WriteLine("Dressing Man:");
        foreach (var clothing in mensClothing)
        {
            clothing.DressMan();
            Console.WriteLine();
        }
    }
}