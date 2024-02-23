public class Professor : RITMember
{
    public double Rating { get; set; }
    public int YearsWork { get; private set;}

    public Professor(string name, string uid) : base(name, "Professor", uid)
    {
        //  ... no need to initialize Rating and YearsWork, it's already 0
    }

    public bool SetYearsWork(int years)
    {
        if(years < 0)
            return false;

        YearsWork = years;

        return true;
    }

    public override void Work()
    {
        base.Work();

        Console.WriteLine($"{Role} does curriculum development, teach, grade, among other academia things");
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nRating: {Rating}\nYears at Work: {YearsWork}";
    }
}