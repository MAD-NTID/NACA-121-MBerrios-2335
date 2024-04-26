
using Newtonsoft.Json;

public class AttendanceSystem : IAttendanceSystem
{
    private Dictionary<string, Student> students;
    public Dictionary<string, Student> Students => students;

    public AttendanceSystem()
    {
        students = new Dictionary<string, Student>();
    }

    public void AddStudent(string firstName, string lastName, DateTime date)
    {
        students.Add($"{firstName} {lastName}", new Student(firstName, lastName, new List<DateTime> { date }));
    }

    public void AddStudent(string firstName, string lastName, List<DateTime> dates)
    {
        students.Add($"{firstName} {lastName}", new Student(firstName, lastName, dates));
    }

    public void LoadAttendanceFromFile(string filePath)
    {
        StreamReader reader = new StreamReader(filePath);
        reader.ReadLine(); // Skip the header

        while(!reader.EndOfStream)
        {
            string line = reader.ReadLine();

            string[] parts = line.Split(',');

            //  Grab the first and last names of the CSV line
            string firstName = parts[0], lastName = parts[1];
            
            //  The key to use for the Dictionary
            string key = $"{firstName} {lastName}";
            
            //  List of DateTime to use when creating the Student Object
            List<DateTime> dates = new List<DateTime>();
            
            //  Parse Each of the DateTime from the CSV
            for(int i = 2; i < parts.Length; i++)
                dates.Add(DateTime.Parse(parts[i]));

            //  Create the Student Object
            Student student = new Student(firstName, lastName, dates);
            
            //  Add to the Dictionary
            students.Add(key, student);
        }

        reader.Close();
    }

    public void SaveAttendanceToFile(string filePath)
    {
        using StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine(JsonConvert.SerializeObject(students, Formatting.Indented));
    }

    public List<Student> SelectStudentsByDateRange(DateTime fromDate, DateTime toDate)
    {
        throw new NotImplementedException();
    }

    public List<Student> SortStudentsByLastName()
    {
        //  You are expected to apply a Sorting Algorithm of 0(n^2) time complexity
        //  InsertSort Algorithm Here
        //  Convert the Dictionary to Array
        var sortedStudents = students.Values.ToList();
        for (int i = 1; i < sortedStudents.Count; i++)
        {
            var current = sortedStudents[i];
            int j = i - 1;
            while (j >= 0 && string.Compare(sortedStudents[j].LastName, current.LastName) > 0)
            {
                sortedStudents[j + 1] = sortedStudents[j];
                j--;
            }
            sortedStudents[j + 1] = current;
        }
        return sortedStudents;
    }
}