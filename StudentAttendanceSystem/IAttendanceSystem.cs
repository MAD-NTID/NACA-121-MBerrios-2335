public interface IAttendanceSystem
{
    void LoadAttendanceFromFile(string filePath);
    void SaveAttendanceToFile(string filePath);    
    void AddStudent(string firstName, string lastName, DateTime date);
    void AddStudent(string firstName, string lastName, List<DateTime> dates);
    List<Student> SortStudentsByLastName();
    List<Student> SelectStudentsByDateRange(DateTime fromDate, DateTime toDate);
}