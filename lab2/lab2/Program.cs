using lab2;

class Program
{
    static void Main()
    {

        // task 1

        int[] numbers = { 4, 2, 7, 1, 9, 5 };

        int min, max;
        numbers.FindMinMax(out min, out max);

        Console.WriteLine($"Min: {min}, Max: {max}");

        // task 2


        Employee[] employees = new Employee[10];
        Random random = new Random();

        // Створюємо 10 об'єктів Employee та додаємо їх в масив
        for (int i = 0; i < 10; i++)
        {
            employees[i] = new Employee($"Employee{i + 1}", $"{(char)('А' + i)}.{(char)('А' + i)}", 1980 + i, random.Next(2000, 5000));
        }

        // Виводимо інформацію про всіх співробітників
        Console.WriteLine("Список співробітників:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.LastName}, {employee.Initials}, {employee.BirthYear}, {employee.Salary:C}");
        }

        // Знаходимо співробітників, оклад яких менший за певне значення
        double salaryThreshold = 3000;
        Console.WriteLine($"\nСпівробітники з окладом менше {salaryThreshold:C}:");
        foreach (var employee in employees)
        {
            if (employee.Salary < salaryThreshold)
            {
                Console.WriteLine($"{employee.LastName}, {employee.Initials}, {employee.BirthYear}, {employee.Salary:C}");
            }
        }

        // Перевіряємо кількість існуючих об'єктів
        int objectLimit1 = 15;
        int objectLimit2 = 5;

        if (Employee.ObjectCount > objectLimit1)
        {
            Console.WriteLine($"\nКількість об'єктів перевищує {objectLimit1}. Деякі об'єкти можуть бути не ініціалізовані.");
        }
        else if (Employee.ObjectCount < objectLimit2)
        {
            Console.WriteLine($"\nКількість об'єктів менше {objectLimit2}. Збільште кількість створених об'єктів.");
        }
    }
}