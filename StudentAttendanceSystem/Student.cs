
public class Student : IStudent
{
    private string firstName;
    public string FirstName => firstName;

    private string lastName;
    public string LastName => lastName;

    private List<DateTime> attendanceDates;
    public List<DateTime> AttendanceDates => attendanceDates;

    public Student(string firstName, string lastName, List<DateTime> attendanceDates)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.attendanceDates = attendanceDates;
    }

    public void AddAttendance(DateTime date)
    {
        attendanceDates.Add(date);
    }

    public override string ToString()
    {
        return $"{firstName} {lastName}";
    }
}