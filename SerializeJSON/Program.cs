using Newtonsoft.Json;

Console.Clear();

//  Part 1
// List<Person> people = new();

// people.Add(new("Erik", 22));
// people.Add(new("Gus", 18));
// people.Add(new("Ghost", 0));

// foreach(Person person in people)
//     Console.WriteLine(person);

// Console.WriteLine();

// //  Let's Convert to JSON
// //  Install the package first using Command
// //  dotnet add package Newtonsoft.json
// string serializedPeople = JsonConvert.SerializeObject(people);

// Console.WriteLine(serializedPeople);

// //  When you use the key word "using" it will automatically invoke the "Close()" method of the StreamWriter
// using StreamWriter sw = new StreamWriter("people.json");
// sw.WriteLine(serializedPeople);

//  Part 2
const string CLASSROOM_FILE_NAME = "classroom.json";

Classroom? classroom = new("NACA121");
classroom.AddPerson("Erik", 22);
classroom.AddPerson("Gus", 18);
classroom.AddPerson("Ghost", 0);

foreach(Person person in classroom.People)
    Console.WriteLine(person);

Console.WriteLine();

while(true)
{
    Console.Write("What would you like to do?\n1) Save\n2) Load\n\nSelect: ");
    string? choice = Console.ReadLine();

    if(choice == "1")
    {
        string serializedClassroom = JsonConvert.SerializeObject(classroom);
        Console.WriteLine(serializedClassroom);

        using StreamWriter sw = new(CLASSROOM_FILE_NAME);
        sw.WriteLine(serializedClassroom);

        Console.WriteLine($"Classroom Saved to {CLASSROOM_FILE_NAME}");

        break;
    }
    else if(choice == "2")
    {
        Console.WriteLine($"Reading From File {CLASSROOM_FILE_NAME}");

        using StreamReader sr = new(CLASSROOM_FILE_NAME);
        //  Read the entire file
        string classroomSerializedString = sr.ReadToEnd();

        if(!string.IsNullOrEmpty(classroomSerializedString))
        {
            classroom = JsonConvert.DeserializeObject<Classroom>(classroomSerializedString);   

            //  Prove that it works - Invoke the ToString of Classroom
            Console.WriteLine(classroom);

            break;
        }
        else
            Console.WriteLine("Error reading from file. File is null or empty");
    }
    else
        Console.WriteLine("Invalid Choice");

    Console.WriteLine();
}
