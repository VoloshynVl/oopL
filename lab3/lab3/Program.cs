class Program
{
    static void Main()
    {
        //task 1
        // Створення нової людини і привітання
        Person person = new Person();
        person.Greet();

        // Створення нового студента, встановлення віку, привітання та показ віку
        Student student = new Student();
        student.SetAge(20);
        student.Greet();
        student.ShowAge();
        student.Study(); // Виклик методу Study

        // Створення нового професора, встановлення віку, привітання та початок пояснення
        Professor professor = new Professor();
        professor.SetAge(45);
        professor.Greet();
        professor.Explain();
        Console.WriteLine();
        
        //task 2

        // Створення об'єктів класу Worker
        Worker ivan = new Worker();
        ivan.SetName("Іван");
        ivan.SetAge(25);
        ivan.SetSalary(1000);

        Worker vasya = new Worker();
        vasya.SetName("Вася");
        vasya.SetAge(26);
        vasya.SetSalary(2000);

        // Знайдення суми зарплат Івана і Васі
        double totalSalary = ivan.GetSalary() + vasya.GetSalary();
        Console.WriteLine($"Сума зарплат Івана і Васі: {totalSalary}");

        // Створення об'єкту класу Student
        Students student1 = new Students();
        student1.SetName("Студент");
        student1.SetAge(20);
        student1.SetScholarship(500);
        student1.SetCourse(2);

        // Створення об'єкту класу Driver
        Driver driver = new Driver();
        driver.SetName("Водій");
        driver.SetAge(30);
        driver.SetSalary(1500);
        driver.SetDrivingExperience(5);
        driver.SetDrivingCategory("B");

        // Виведення інформації про студента та водія
        Console.WriteLine($"Ім'я студента: {student1.GetName()}");
        Console.WriteLine($"Вік студента: {student1.GetAge()} років");
        Console.WriteLine($"Студент отримує стипендію: {student1.GetScholarship()} грн");
        Console.WriteLine($"Студент на {student1.GetCourse()}-му курсі");

        Console.WriteLine($"Ім'я водія: {driver.GetName()}");
        Console.WriteLine($"Вік водія: {driver.GetAge()} років");
        Console.WriteLine($"Зарплата водія: {driver.GetSalary()} грн");
        Console.WriteLine($"Водій має водійський стаж: {driver.GetDrivingExperience()} років");
        Console.WriteLine($"Водійська категорія водіння: {driver.GetDrivingCategory()}");
        Console.WriteLine();

        // task 3
        
        // Створення об'єкта класу Date
        Date currentDate = new Date(25, 12, 2023);

        // Функція-метод 1: перевірка, чи збігаються номер місяця і число дня
        Console.WriteLine($"Є відповідність місяця та дня: {currentDate.IsMonthDayMatch()}");

        // Функція-метод 2: збільшення дати на один місяць
        currentDate.IncreaseByOneMonth();
        Console.WriteLine($"Збільшена дата: {currentDate.day}/{currentDate.month}/{currentDate.year}");

        // Створення об'єкта класу Medicine
        Medicine medicine = new Medicine("Aspirin", 10, 11, 2023, "PharmaCompany");

        // Функція-метод 3: визначення, скільки пройшло днів від виготовлення ліків
        int daysSinceManufacture = medicine.DaysSinceManufacture();
        Console.WriteLine($"Днів з моменту виготовлення: {daysSinceManufacture}");
    }
}