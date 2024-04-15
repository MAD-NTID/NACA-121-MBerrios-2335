public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string? name, int age)
    {
        Name = name is not null ? name : "No Name";
        Age = age >= 0 ? age : 0;
    }

    public override string ToString()
    {
        return $"Name: {Name}, {Age} years old";
    }
}