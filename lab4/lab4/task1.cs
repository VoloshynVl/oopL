class Wing
{
    // Представляє довжину крила
    public int Length { get; }

    // Конструктор для ініціалізації довжини крила
    public Wing(int length)
    {
        Length = length;
    }

    // Перевизначає метод Equals для власного порівняння за довжиною крила
    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (obj == null || GetType() != obj.GetType())
            return false;

        Wing other = (Wing)obj;
        return Length == other.Length;
    }

    // Перевизначає метод GetHashCode для генерації хеш-коду об'єкта крила
    public override int GetHashCode()
    {
        return HashCode.Combine(Length);
    }

    // Перевизначає метод ToString для отримання рядкового представлення об'єкта крила
    public override string ToString()
    {
        return $"Крила: Довжина - {Length}";
    }
}

class Chassis
{
    // Представляє тип шасі (посадкового обладнання) літака
    public string Type { get; }

    // Конструктор для ініціалізації типу шасі
    public Chassis(string type)
    {
        Type = type;
    }

    // Перевизначає метод Equals для власного порівняння за типом шасі
    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (obj == null || GetType() != obj.GetType())
            return false;

        Chassis other = (Chassis)obj;
        return Type == other.Type;
    }

    // Перевизначає метод GetHashCode для генерації хеш-коду об'єкта шасі
    public override int GetHashCode()
    {
        return HashCode.Combine(Type);
    }

    // Перевизначає метод ToString для отримання рядкового представлення об'єкта шасі
    public override string ToString()
    {
        return $"Двигун: Тип Ходова: Тип - {Type}";
    }
}

class Engine
{
    // Представляє тип двигуна літака
    public string Type { get; }

    // Конструктор для ініціалізації типу двигуна
    public Engine(string type)
    {
        Type = type;
    }

    // Перевизначає метод Equals для власного порівняння за типом двигуна
    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (obj == null || GetType() != obj.GetType())
            return false;

        Engine other = (Engine)obj;
        return Type == other.Type;
    }

    // Перевизначає метод GetHashCode для генерації хеш-коду об'єкта двигуна
    public override int GetHashCode()
    {
        return HashCode.Combine(Type);
    }

    // Перевизначає метод ToString для отримання рядкового представлення об'єкта двигуна
    public override string ToString()
    {
        return $"Двигун: Тип - {Type}";
    }
}

class Airplane : Wing
{
    private readonly Chassis _chassis;
    private readonly Engine _engine;

    // Конструктор для ініціалізації об'єкта літака зазначеною довжиною крила, шасі та двигуном
    public Airplane(int wingLength, Chassis chassis, Engine engine)
        : base(wingLength)
    {
        _chassis = chassis;
        _engine = engine;
    }

    // Метод, що виводить повідомлення про польот
    public void Fly()
    {
        Console.WriteLine("Літак летить!");
    }

    // Метод для встановлення маршруту
    public void SetRoute(string route)
    {
        Console.WriteLine($"Набір маршруту: {route}");
    }

    // Метод для відображення маршруту на консолі
    public void DisplayRoute()
    {
        Console.WriteLine("Маршрут, що відображається на консолі.");
    }

    // Перевизначає метод Equals для власного порівняння об'єктів літака
    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;

        if (obj == null || GetType() != obj.GetType())
            return false;

        if (!base.Equals(obj))
            return false;

        Airplane other = (Airplane)obj;
        return _chassis.Equals(other._chassis) && _engine.Equals(other._engine);
    }

    // Перевизначає метод GetHashCode для генерації хеш-коду об'єкта літака
    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), _chassis, _engine);
    }

    // Перевизначає метод ToString для отримання рядкового представлення об'єкта літака
    public override string ToString()
    {
        return $"Літак: {base.ToString()}, {_chassis}, {_engine}";
    }
}
