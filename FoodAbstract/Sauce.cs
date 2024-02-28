public class Sauce : Food
{
    private string sauceType;
    public string SauceType
    {
        get { return sauceType; }
        set { sauceType = value; }
    }

    public Sauce(string sauceType, int calories, int fat) : base(calories, fat)
    {
        SauceType = sauceType;
    }

    public override string GetTexture()
    {
        return $"{SauceType} {GetType()} is watery and cheap at DC";
    }

    public void Make(string style = "sauce pan")
    {
        base.Cook(style);
    }
}