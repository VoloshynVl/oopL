abstract class TBody
{
    // Абстрактний клас, який представляє тіло
    public abstract double CalculateSurfaceArea();  // Абстрактний метод для розрахунку площі поверхні
    public abstract double CalculateVolume();       // Абстрактний метод для розрахунку об'єму

    // Віртуальний метод для відображення інформації про тіло
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Область поверхні: {CalculateSurfaceArea()}");
        Console.WriteLine($"Об'єм: {CalculateVolume()}");
    }
}

class TParallelepiped : TBody
{
    // Клас, який представляє паралелепіпед
    public double Length { get; }
    public double Width { get; }
    public double Height { get; }

    // Конструктор для ініціалізації довжини, ширини та висоти паралелепіпеда
    public TParallelepiped(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    // Реалізація абстрактного методу для розрахунку площі поверхні паралелепіпеда
    public override double CalculateSurfaceArea()
    {
        return 2 * (Length * Width + Width * Height + Height * Length);
    }

    // Реалізація абстрактного методу для розрахунку об'єму паралелепіпеда
    public override double CalculateVolume()
    {
        return Length * Width * Height;
    }
}

class TBall : TBody
{
    // Клас, який представляє кулю
    public double Radius { get; }

    // Конструктор для ініціалізації радіусу кулі
    public TBall(double radius)
    {
        Radius = radius;
    }

    // Реалізація абстрактного методу для розрахунку площі поверхні кулі
    public override double CalculateSurfaceArea()
    {
        return 4 * Math.PI * Radius * Radius;
    }

    // Реалізація абстрактного методу для розрахунку об'єму кулі
    public override double CalculateVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }
}
