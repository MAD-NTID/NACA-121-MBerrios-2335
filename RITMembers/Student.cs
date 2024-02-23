public class Student : RITMember
{
    public double GPA { get; set; }
    public string Program { get; private set; }

    public Student(string name, string uid) : base(name, "Student", uid)
    {
        Program = "Unknown";
    }

    public bool SetProgram(string program)
    {
        if(program.Equals("aas", StringComparison.CurrentCultureIgnoreCase) || 
        program.Equals("as", StringComparison.CurrentCultureIgnoreCase) ||
        program.Equals("bs", StringComparison.CurrentCultureIgnoreCase) ||
        program.Equals("ms", StringComparison.CurrentCultureIgnoreCase) ||
        program.Equals("p.h.d", StringComparison.CurrentCultureIgnoreCase))
        {
            Program = program;
            return true;
        }

        return false;
    }

    public override void Work()
    {
        base.Work();

        Console.WriteLine($"{Role} take classes, do homework, eat and sleep without showering for a whole year");
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nProgram: {Program}\nGPA: {GPA}";
    }
}