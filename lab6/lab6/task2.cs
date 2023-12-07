public class Employee : IComparable<Employee>
{
    public string LastName { get; set; }
    public string Initials { get; set; }
    public int BirthYear { get; set; }
    public double Salary { get; set; }

    public static int ObjectCount { get; private set; }

    public Employee(string lastName, string initials, int birthYear, double salary)
    {
        LastName = lastName;
        Initials = initials;
        BirthYear = birthYear;
        Salary = salary;
        ObjectCount++;
    }

    // Реалізація методу CompareTo для IComparable<T>
    public int CompareTo(Employee other)
    {
        // Порівнюємо спочатку за прізвищем, потім за роком народження
        int result = LastName.CompareTo(other.LastName);
        if (result == 0)
        {
            result = BirthYear.CompareTo(other.BirthYear);
        }
        return result;
    }
}