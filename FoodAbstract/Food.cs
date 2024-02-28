public abstract class Food
{   
    private int calories;
    public int Calories
    {
        get { return calories; }
        set { calories = value; }
    }
    
    private int fat;
    public int Fat
    {
        get { return fat; }
        set { fat = value; }
    }

    public Food(int calories, int fat)
    {
        Calories = calories;
        Fat = fat;
    }

    public abstract string GetTexture();

    public void Cook(string style = "pan")
    {
        Console.WriteLine($"Cooking the {GetType()} with {style}");
    }

    public override string ToString()
    {
        return $"{GetType()} - Calories: {calories} - Fat: {fat}";
    }
}