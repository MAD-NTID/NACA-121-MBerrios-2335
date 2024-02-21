public class Weapon
{
    public string Name { get; set; }
    public string Type { get; set; }

    public Weapon(string name, string type = "Not Specified")
    {
        Name = name;
        Type = type;
    }
}