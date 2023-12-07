class Person
{
    protected int age;

    public void Greet()
    {
        Console.WriteLine("Hello, I'm a person.");
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
}

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying.");
    }

    public void ShowAge()
    {
        Console.WriteLine($"My age is: {age} years old");
    }
}

class Professor : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining.");
    }
}