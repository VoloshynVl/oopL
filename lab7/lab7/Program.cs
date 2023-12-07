class Program
{
    static void Main()
    {
 
        try
        {
            // Приклад виклику методу зліту для літака
            Airplane airplane = new Airplane();
            airplane.Name = "Boeing 737";
            airplane.SmugaRozgonu = 500; // Генерує виняток SmugaRozgonuException
            airplane.Zlit();

            // Приклад виклику методу додавання пасажира до літального апарату
            FlyingMachine flyingMachine = new FlyingMachine();
            flyingMachine.MaxPassengers = 2;
            flyingMachine.AddPassenger();
            flyingMachine.AddPassenger(); // Додаємо другого пасажира
            flyingMachine.AddPassenger(); // Генерує виняток KilkistException

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка в основній програмі: {ex.Message}");
        }
    }
}