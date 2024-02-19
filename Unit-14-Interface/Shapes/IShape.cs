public interface IShape
{
    public string Name { get; set; }
    public string FillColor { get; set; }

    public double CalculateArea(double x = 0, double y = 0);
}