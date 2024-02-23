public class Weapon
{
    public string Name { get; set; }
    public string Type { get; set; }

    public Weapon(string name)
    {
        Name = name;
    }

    public void Fire()
    {
        //  Some fire code here
    }

    public void Turn(string direction)
    {
        //  Some turn code here
    }
}