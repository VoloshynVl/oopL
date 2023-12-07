using System;

// Власний клас винятку KilkistException
public class KilkistException : Exception
{
    public KilkistException(string message) : base(message) { }
}

// Власний клас винятку SmugaRozgonuException
public class SmugaRozgonuException : Exception
{
    public SmugaRozgonuException(string message) : base(message) { }
}

// Клас Аеропорт
public class Airport
{
    public string Name { get; set; }
}

// Клас Літальний апарат
public class Aircraft
{
    public string Name { get; set; }
    public int MaxPassengers { get; set; }

    public void Zlit()
    {
        try
        {
           
            Console.WriteLine($"{Name} злітає...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при зльоті: {ex.Message}");
        }
    }
}

// Клас Літак
public class Airplane : Aircraft
{
    private int _smugaRozgonu;

    public int SmugaRozgonu
    {
        get { return _smugaRozgonu; }
        set
        {
            try
            {
                if (value <= 0)
                    throw new SmugaRozgonuException($"Неможливо створити літак - вказана неправильна довжина смуги розгону: {value}");

                _smugaRozgonu = value;
            }
            catch (SmugaRozgonuException ex)
            {
                Console.WriteLine(ex.Message);
                throw; 
            }
        }
    }

    public void Zlit()
    {
        try
        {
           
            Console.WriteLine($"{Name} літає...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при зльоті: {ex.Message}");
        }
    }
}

// Клас Гелікоптер
public class Helicopter : Aircraft
{
    public void Zlit()
    {
        try
        {
           
            Console.WriteLine($"{Name} піднімається в повітря...");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при зльоті: {ex.Message}");
        }
    }
}

// Клас Пасажир
public class Passenger
{
    public string PIB { get; set; }
    public int SeatNumber { get; set; }
}

// Клас Літальний апарат
public class FlyingMachine
{
    private int _currentPassengers = 0;

    public int MaxPassengers { get; set; }

    public void AddPassenger()
    {
        try
        {
            if (_currentPassengers >= MaxPassengers)
                throw new KilkistException($"Перевищено максимальну кількість пасажирів: {_currentPassengers}");

            
            Console.WriteLine("Пасажир доданий до літального апарату.");
            _currentPassengers++;
        }
        catch (KilkistException ex)
        {
            Console.WriteLine($"Помилка при додаванні пасажира: {ex.Message}");
        }
    }
}