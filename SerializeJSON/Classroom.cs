public class Classroom
{
    public string Section { get; set; }
    public List<Person> People { get; set; }

    public Classroom(string? section)
    {
        Section = section is not null ? section : "Default Section";
        People = new();
    }

    public void AddPerson(string? name, int age)
    {
        People.Add(new(name, age));
    }

    public override string ToString()
    {
        string people = $"Section: {Section}\n\nStudents: \n";

        foreach(Person person in People)
            people += $"{person}\n";

        return people;
    }
}