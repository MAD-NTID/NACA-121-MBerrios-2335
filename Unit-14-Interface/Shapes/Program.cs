IShape circle = new Circle("red");
IShape triangle = new Triangle("red");

Console.WriteLine($"Area of a Circle: {circle.CalculateArea(5)}");
Console.WriteLine($"Area of Triangle: {triangle.CalculateArea(5, 2)}");