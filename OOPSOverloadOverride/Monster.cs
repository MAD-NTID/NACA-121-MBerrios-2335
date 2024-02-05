public class Monster 
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Power { get; set; }

    public Monster()
    {
        Name = "Unnamed";
        HP = GetRandomHP();
        Power = GetRandomPower();
    }

    public Monster(string name)
    {
        Name = name;
        HP = GetRandomHP();
        Power = GetRandomPower();
    }

    private int GetRandomHP()
    {
        return new Random().Next(1000, 2000);
    }

    private int GetRandomPower()
    {
        return Power = new Random().Next(200);
    }

    public override string ToString()
    {
        return $"Name: {Name}\nHealth: {HP}\nPower: {Power}";
    }
}