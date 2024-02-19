namespace Test;

public class Tests
{
    [Test]
    public void AddTwoNumbersTest()
    {
        // Set Up
        double num1 = 2;
        double num2 = 2.5;
        double result = 4.5;

        // Invoke
        Calculation calculation = new Calculation();
        double actual = calculation.Add(num1, num2);

        //  Analyze
        Assert.AreEqual(result, actual);
    }
}