class Program
{
    static void Main()
    {
        //task 1

        // Приклад використання узагальненого класу CollectionType<T>
        CollectionType<int> intCollection = new CollectionType<int>();

        intCollection.AddItem(1);
        intCollection.AddItem(2);
        intCollection.AddItem(3);

        Console.WriteLine("Collection of integers:");
        intCollection.DisplayItems();

        // Приклад використання індексатора
        Console.WriteLine("Element at index 1: " + intCollection[1]);

        // Приклад використання методу видалення
        intCollection.RemoveItem(2);
        Console.WriteLine("Collection after removing element 2:");
        intCollection.DisplayItems();
        Console.WriteLine();

        //task 2

        // Створення колекції з об'єктами Employee
        List<Employee> employees = new List<Employee>
        {
            new Employee("Doe", "J.", 1980, 50000),
            new Employee("Smith", "A.", 1990, 60000),
            new Employee("Johnson", "M.", 1985, 55000),
            new Employee("Williams", "S.", 1982, 52000)
        };

        // Вивід несортованого списку
        Console.WriteLine("Unsorted employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.LastName}, {employee.Initials}, {employee.BirthYear}, {employee.Salary}");
        }

        // Сортування за прізвищем та роком народження
        employees.Sort();

        // Вивід відсортованого списку
        Console.WriteLine("\nSorted employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.LastName}, {employee.Initials}, {employee.BirthYear}, {employee.Salary}");
        }

        // LINQ-запит для виводу працівників, які мають зарплату більше 55000
        var highSalaryEmployees = from emp in employees
                                   where emp.Salary > 55000
                                   select emp;

        Console.WriteLine("\nEmployees with salary > 55000:");
        foreach (var employee in highSalaryEmployees)
        {
            Console.WriteLine($"{employee.LastName}, {employee.Initials}, {employee.BirthYear}, {employee.Salary}");
        }
        Console.WriteLine();

        //task 3

        // 1. Вивести інформацію про працівників, які мають зарплату більше 50000 та впорядкувати за прізвищем.
        var highSalaryOrderedByLastName = employees
            .Where(e => e.Salary > 50000)
            .OrderBy(e => e.LastName)
            .Select(e => $"{e.LastName}, {e.Initials}, {e.BirthYear}, {e.Salary}");

        Console.WriteLine("1. Employees with salary > 50000, ordered by last name:");
        foreach (var info in highSalaryOrderedByLastName)
        {
            Console.WriteLine(info);
        }
        Console.WriteLine();

        // 2. Знайти працівника з найвищою зарплатою та вивести його інформацію.
        var highestSalaryEmployee = employees.OrderByDescending(e => e.Salary).First();

        Console.WriteLine("2. Employee with the highest salary:");
        Console.WriteLine($"{highestSalaryEmployee.LastName}, {highestSalaryEmployee.Initials}, {highestSalaryEmployee.BirthYear}, {highestSalaryEmployee.Salary}");
        Console.WriteLine();

        // 3. Знайти середню зарплату всіх працівників.
        var averageSalary = employees.Average(e => e.Salary);

        Console.WriteLine($"3. Average salary of all employees: {averageSalary}");
        Console.WriteLine();

        // 4. Вивести перші три працівники, які народилися після 1980 року, впорядковані за роком народження.
        var youngestEmployees = employees
            .Where(e => e.BirthYear > 1980)
            .OrderBy(e => e.BirthYear)
            .Take(3)
            .Select(e => $"{e.LastName}, {e.Initials}, {e.BirthYear}, {e.Salary}");

        Console.WriteLine("4. First three employees born after 1980, ordered by birth year:");
        foreach (var info in youngestEmployees)
        {
            Console.WriteLine(info);
        }
        Console.WriteLine();

        // 5. Перевірити, чи існує хоча б один працівник із зарплатою більше 60000.
        var hasHighSalaryEmployee = employees.Any(e => e.Salary > 60000);

        Console.WriteLine($"5. Does any employee have a salary greater than 60000? {hasHighSalaryEmployee}");
        Console.WriteLine();
        // task 4

        List<string> stringCollection = new List<string>
        {
            "apple", "orange", "banana", "grape", "kiwi", "pear", "mango", "strawberry"
        };

        CollectionHandler<string> stringCollectionHandler = new CollectionHandler<string>(stringCollection);

        Console.WriteLine("All lines:");
        stringCollectionHandler.PrintCollection();

        string searchValue = "kiwi";
        Console.WriteLine($"\nLines containing '{searchValue}':");
        stringCollectionHandler.SearchByValue(searchValue);
        stringCollectionHandler.PrintCollection();

        int lengthToCount = 6;
        Console.WriteLine($"\nNumber of rows of length {lengthToCount}: {stringCollectionHandler.CountStringsByLength(lengthToCount)}");

        Console.WriteLine("\nSort in ascending order:");
        stringCollectionHandler.SortCollectionAscending();
        stringCollectionHandler.PrintCollection();

        Console.WriteLine("\nSort in descending order:");
        stringCollectionHandler.SortCollectionDescending();
        stringCollectionHandler.PrintCollection();

    }
}