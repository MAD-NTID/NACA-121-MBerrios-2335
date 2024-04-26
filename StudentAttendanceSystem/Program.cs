AttendanceSystem attendanceSystem = new AttendanceSystem();
bool exit = false;

while (!exit)
{
    Console.WriteLine("\nAttendance System Menu:");
    Console.WriteLine("1. Load attendance data from file");
    Console.WriteLine("2. Save attendance data to file");
    Console.WriteLine("3. Add Student Record");
    Console.WriteLine("4. Sort students by last name");
    Console.WriteLine("5. Select students by date range");
    Console.WriteLine("6. Exit");
    Console.Write("Enter your choice (1-5): ");

    string choice = Console.ReadLine();

    switch (choice)
    { 
        case "1":
            Console.Write("Enter the file path: ");
            string filePath = Console.ReadLine();
            attendanceSystem.LoadAttendanceFromFile(filePath);
            break;
        case "2":
            Console.Write("Enter the file path: ");
            filePath = Console.ReadLine();
            attendanceSystem.SaveAttendanceToFile(filePath);
            break;
        case "3":
            Console.Write("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            
            Console.Write("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            
            Console.Write("Enter the date of attendance: ");
            string attendance = Console.ReadLine();
            
            //  Administrators can add multiple dates, or a single date
            if(attendance.Contains(","))
            {
                string[] dates = attendance.Split(',');
                List<DateTime> attendanceDates = new();
                
                foreach(string date in dates)
                    attendanceDates.Add(DateTime.Parse(date));
                
                //  Add Multiple Dates
                attendanceSystem.AddStudent(firstName, lastName, attendanceDates);
            }
            //  Add Single Date
            else
                attendanceSystem.AddStudent(firstName, lastName, DateTime.Parse(attendance));

            break;
        case "4":
            Console.WriteLine("Students sorted by last name:");
            foreach(Student student in attendanceSystem.SortStudentsByLastName())
                Console.WriteLine($"{student.LastName}, {student.FirstName}");
            break;
        default:
            Console.WriteLine("Invalid Option");
        break;
    }

    Console.WriteLine();
}