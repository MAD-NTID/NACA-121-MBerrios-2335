public interface IStudent
{
    string FirstName { get; }
    string LastName { get; }
    List<DateTime> AttendanceDates { get; }
    void AddAttendance(DateTime date);
}