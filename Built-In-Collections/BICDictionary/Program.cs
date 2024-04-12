Dictionary<string, double> studentsGPA = new();

double GetRandomGPA()
{
    return new Random().NextDouble() * 4;
}

studentsGPA.Add("Erik", GetRandomGPA());
studentsGPA.Add("Gus", GetRandomGPA());
studentsGPA.Add("Ghost", GetRandomGPA());

//  Display each student and their GPA
foreach(KeyValuePair<string, double> student in studentsGPA)
    Console.WriteLine($"Student Name: {student.Key} - GPA: {student.Value:f2}");