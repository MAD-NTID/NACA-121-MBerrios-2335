public class Item
{
    private int id;
    private string name;
    private string category;

    public int Id 
    { 
        get{return id;}
        set
        {
            if(value < 0)
                value = 0;
            
            id = value;
        }
    }

    public string Name 
    {
        get{return name;}
        set
        {
            if(string.IsNullOrEmpty(value))
                value = "Item - No Name";
            
            name = value;
        }
    }

    public string Category 
    {
        get{return category;}
        set
        {
            if(string.IsNullOrEmpty(value))
                value = "Item - No Category";
            
            category = value;
        }
    }

    public Item()
    {
        Name = "Item - No Name";
        Category = "Item - No Category";
        Id = 0;
    }

    public Item(int id, string name, string category)
    {
        Name = name;
        Id = id;
        Category = category;
    }

    public override string ToString()
    {
        return $"ID:{id} Name:{name} Category:{Category}";
    }


}