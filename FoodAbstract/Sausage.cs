public class Sausage : Food
{   
    public Sausage(int calroies, int fat) : base(calroies, fat) {}

    public override string GetTexture()
    {
        return $"{GetType()}'s chewy";
    }
}