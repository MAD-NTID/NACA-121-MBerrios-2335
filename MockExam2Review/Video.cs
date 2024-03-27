public class Video
{
    private string title;
    public string Title
    {
        get { return title; }
        private set { title = value; }
    }
    
    private string duration;
    public string Duration
    {
        get { return duration; }
        private set { duration = value; }
    }
    
    private string category;
    public string Category
    {
        get { return category; }
        private set { category = value; }
    }
    
    public Video(string title, string duration, string category)
    {
        Title = title;
        Duration = duration;
        Category = category;
    }

    public override string ToString()
    {
        return $"{title},{duration},{category}";
    }
}