public class Spaghetti : Food
{
    public Spaghetti(int calories, int fat) : base(calories, fat) {}

    public override string GetTexture()
    {
        return $"{GetType()} is al-dente";
    }

    public void Boil()
    {
        base.Cook("pot");
    }
}