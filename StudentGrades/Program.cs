double[,] studentGrades = 
{
    //  Erik
    {90, 85, 80},
    //  Osman
    {90, 80, 95},
    //  Gus
    {100, 60, 90}
};

// Iterate the Matrix
double average, sum = 0, max = double.MinValue, min = double.MaxValue;
int totalGrades = 0;

for(int row = 0; row < studentGrades.GetLength(0); row++)
{
    for(int col = 0; col < studentGrades.GetLength(0); col++)
    {
        Console.Write($"({row}, {col}) = {studentGrades[row, col]} ");

        double currentNumber = studentGrades[row, col];

        sum += currentNumber;
        max = Math.Max(max, currentNumber);
        min = Math.Min(min, currentNumber);
        totalGrades++;
    }        

    Console.WriteLine();
}

average = sum / totalGrades;

// Display Values Obtained from Matrix
Console.WriteLine($"The matrix has {studentGrades.GetLength(0)} rows and {studentGrades.GetLength(1)} columns.");
Console.WriteLine($"The average grade of all students is {average/100:P}");
Console.WriteLine($"The lowest grade is {min/100:P}");
Console.WriteLine($"The highest grade is {max/100:P}");
