public class RITMember : IRITMember
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string UID { get; set; }

    public RITMember(string name, string role, string uid)
    {
        Name = name;
        Role = role;
        UID = uid;
    }

    // This is Parent clase (base class)
    // Declare this method as virtual to allow overriding by derived classes like Student, Professor
    public virtual void Work()
    {
        Console.WriteLine($"{Name} is working as a {Role} of RIT");
    }

    public override string ToString()
    {
        return $"Name: {Name}\nRole: {Role}\nUID: {UID}";
    }
}