public class Chicken : Food
{
    private string texture;
    public string Texture
    {
        get { return texture; }
        set { texture = value; }
    }
    

    public Chicken(int calroies, int fat) : base(calroies, fat) {}

    public override string GetTexture()
    {
        return $"{GetType()}'s Texture: {Texture}";
    }
}