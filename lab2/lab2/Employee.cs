namespace lab2
{
    public class Employee
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
    }
}