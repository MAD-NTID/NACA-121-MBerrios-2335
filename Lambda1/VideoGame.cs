public class VideoGame
{
    private const double TOO_EXPENSIVE = 60;

    private string title;
    public string Title
    {
        //  this is expression lambda
        //  you've been using it since, but not realized
        get => title;
        private set { title = value; }
    }
    
    private double price;
    public double Price
    {
        //  expression lambda
        get => price;
        private set { price = value; }
    }

    //  Very Basic Expression Lambda
    public bool IsGameTooExpensive
    {
        get => price > TOO_EXPENSIVE;
    }
    
    private int year;
    public int Year
    {
        get => year;
        private set { year = value; }
    }
    

    public VideoGame(string title, double price, int year = 0)
    {
        Title = title;
        Price = price;
        Year = year;
    }

    //  Let's set up a Statement Lambda
    public Func<VideoGame, bool> IsOlderThan
    {
        get
        {
            return (VideoGame vg) => {
                return year < vg.Year;
            };
        }   
    }

    public override string ToString()
    {
        return $"Title: {Title}, Price: {Price:C}";
    }
}