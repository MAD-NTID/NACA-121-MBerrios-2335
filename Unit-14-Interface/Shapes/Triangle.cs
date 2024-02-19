public class Triangle : IShape
{
    public string Name { get; set; }

    public string FillColor { get; set; }

    public Triangle(string fillColor)
    {
        Name = "Triangle";
        FillColor = fillColor;
    }

    public double CalculateArea(double length = 0, double width = 0)
    {
        return length * width / 2;
    }
}