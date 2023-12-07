class Program
{
    static void Main()
    {
        // Завдання 1

        // Створення об'єктів для кожного компонента літака
        Wing wing = new Wing(50);
        Chassis chassis = new Chassis("Пасажирський");
        Engine engine = new Engine("Турбоджет");

        // Створення об'єкта літака та ініціалізація його компонентами
        Airplane airplane = new Airplane(50, chassis, engine);

        // Виклик методів для демонстрації роботи літака
        airplane.Fly();
        airplane.SetRoute("Київ - Париж");
        airplane.DisplayRoute();

        // Виведення інформації про кожен компонент
        Console.WriteLine(wing.ToString());
        Console.WriteLine(chassis.ToString());
        Console.WriteLine(engine.ToString());
        Console.WriteLine(airplane.ToString());

        // Порівняння об'єктів за допомогою Equals
        Console.WriteLine($"Чи рівні крила? {wing.Equals(new Wing(50))}");
        Console.WriteLine($"Чи рівні літаки? {airplane.Equals(new Airplane(50, chassis, engine))}");
        Console.WriteLine();

        // Завдання 2

        // Масив об'єктів типу TBody
        TBody[] bodies = new TBody[5];

        // Ініціалізація об'єктів масиву з випадковими значеннями
        Random random = new Random();

        for (int i = 0; i < bodies.Length; i++)
        {
            if (random.Next(2) == 0)
            {
                // Якщо випадкове число дорівнює 0, створюється об'єкт паралелепіпеда
                double length = random.Next(1, 10);
                double width = random.Next(1, 10);
                double height = random.Next(1, 10);

                bodies[i] = new TParallelepiped(length, width, height);
            }
            else
            {
                // Якщо випадкове число дорівнює 1, створюється об'єкт кулі
                double radius = random.Next(1, 10);

                bodies[i] = new TBall(radius);
            }
        }

        // Підрахунок загальної площі поверхні
        double totalSurfaceArea = 0;

        // Виведення інформації про кожен об'єкт масиву
        foreach (var body in bodies)
        {
            Console.WriteLine($"Тип фігури: {body.GetType()}");
            body.DisplayInfo();
            totalSurfaceArea += body.CalculateSurfaceArea();
            Console.WriteLine("--------------------");
        }

        // Виведення загальної площі поверхні всіх об'єктів
        Console.WriteLine($"Загальна площа поверхні всіх тіл: {totalSurfaceArea}");
    }
}
