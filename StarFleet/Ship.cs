public class Ship
{
    private const int INITIAL_CREW_CAPACITY = 10;
    private const int INCREMENTAL_SPEED = 3, INCREMENTAL_DISTANCE = 5;

    private int distance, speed;
    private string name;
    private Alien[] crew = new Alien[INITIAL_CREW_CAPACITY];
    private int crewCount;


    public int Distance 
    { 
        get
        {
            return distance;
        } 
    }

    public int Speed 
    { 
        get 
        {
            return speed;
        }
    }
    public string Name { get; }

    public Ship()
    {
        // distance = 0;
        // speed = 0;
        // crewCount = 0;
        name = "Unidentified Flying Object";
        crew = new Alien[INITIAL_CREW_CAPACITY];
    }

    public Ship(string name, int alienCapacity)
    {
        // distance = 0;
        // speed = 0;
        // crewCount = 0;
        this.name = name;
        crew = new Alien[alienCapacity];
    }

    public bool IsShipFull()
    {
        return crewCount == crew.Length;
    }

    public bool Add(Alien alien)
    {
        //  Check if there's space for the crew member to be added
        if(IsShipFull())
            return false;

        //  If the new Alien's role is not of "Captain" there's no point to check if there's is a captain in the crew
        //  Just go ahead and add it
        //  Check if there's a captain if the new alien's role is captain
        //  Check if there's a chief if the new alien's role is chief
        //  Co-signed by Gustavo, PHD lead researcher.
        if(alien.IsCaptain() || alien.IsChief())
            for(int i = 0; i < crew.Length; i++)
                if(crew[i] !=null && crew[i].Role ==  alien.Role)
                    return false;      
           

        //  Otherwise, add the alien to the crew
        for(int i = 0; i < crew.Length; i++)
            if(crew[i] == null)
            {
                crew[i] = alien;
                crewCount++;
                break;
            }

        return true;
    }

    public bool Remove(string name)
    {
        if(!string.IsNullOrEmpty(name))
            for(int i = 0; i < crew.Length; i++)
                if(crew[i] != null && name.ToLower() == crew[i].Name.ToLower())
                {
                    crew[i] = null;
                    crewCount--;
                    return true;
                }

        return false;
    }

    public void Fly()
    {
        speed += INCREMENTAL_SPEED;
        distance += INCREMENTAL_DISTANCE;
    }

    public void Fly(int speed)
    {
        this.speed += speed;

        distance += speed / 3 * INCREMENTAL_DISTANCE;
    }

    public override string ToString()
    {
        string crews = string.Empty;

        for(int i = 0; i < crew.Length; i++)
            crews += crew[i] != null ? $"\n\t-{crew[i]}" : string.Empty;

        return $"Ship Name: {name}\nSpeed: {speed}\nDistance: {distance}\nTotal Crew: {crewCount}\nCrews: {crews}";
    }
}