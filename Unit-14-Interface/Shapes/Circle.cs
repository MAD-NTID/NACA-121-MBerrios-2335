public class Circle : IShape
{
    public string Name { get; set; }

    public string FillColor { get; set; }

    public Circle(string fillColor)
    {
        Name = "Circle";
        FillColor = fillColor;
    }

    public double CalculateArea(double diameter, double width)
    {
        return Math.PI * Math.Pow(diameter / 2, 2);
    }
}