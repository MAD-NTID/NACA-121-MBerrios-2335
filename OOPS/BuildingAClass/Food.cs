public class Food
{
    public string name, type;
    public int calories;
    private double weight;

    public Food() 
    {
        // do nothing, or set default values, up to the programmer
        name = "Unspecified";
        type = "NA";
    }

    public Food(string _name, string _type, int _calories, double _weight = 0)
    {
        name = _name;
        type = _type;
        calories = _calories;
        weight = _weight;
    }

    void ModifyWeight() 
    {
        // this method has direct access to weight because they belong to the same encapsulated class
        weight = 2; // oz
    }
}