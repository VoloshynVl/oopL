// Клас User
class User
{
    protected string name;
    protected int age;

    // Геттер та сеттер для імені
    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    // Геттер та сеттер для віку
    public int GetAge()
    {
        return age;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
}

// Клас Worker, що успадковується від User
class Worker : User
{
    private double salary;

    // Геттер та сеттер для зарплати
    public double GetSalary()
    {
        return salary;
    }

    public void SetSalary(double salary)
    {
        this.salary = salary;
    }
}

// Клас Student, що успадковується від User
class Students : User
{
    private double scholarship;
    private int course;

    // Геттери та сеттери для стипендії та курсу
    public double GetScholarship()
    {
        return scholarship;
    }

    public void SetScholarship(double scholarship)
    {
        this.scholarship = scholarship;
    }

    public int GetCourse()
    {
        return course;
    }

    public void SetCourse(int course)
    {
        this.course = course;
    }
}

// Клас Driver, що успадковується від Worker
class Driver : Worker
{
    private int drivingExperience;
    private string drivingCategory;

    // Геттери та сеттери для водійського стажу та категорії водіння
    public int GetDrivingExperience()
    {
        return drivingExperience;
    }

    public void SetDrivingExperience(int drivingExperience)
    {
        this.drivingExperience = drivingExperience;
    }

    public string GetDrivingCategory()
    {
        return drivingCategory;
    }

    public void SetDrivingCategory(string drivingCategory)
    {
        this.drivingCategory = drivingCategory;
    }
}