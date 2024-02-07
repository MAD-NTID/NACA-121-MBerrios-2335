public class Person
{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private Item[] itemsBorrowed;
    public Item[] ItemsBorrowed
    {
        get { return itemsBorrowed; }
        set { itemsBorrowed = value; }
    }

    private const int MAX_ITEMS_BORROWED = 10000;

    public Person()
    {
        Name = "Person - No Value supplied";
        Id = -1;
        ItemsBorrowed = new Item[MAX_ITEMS_BORROWED];
    }

    public Person(int id, string name)
    {
        Name = name;
        Id = id;
        ItemsBorrowed = new Item[MAX_ITEMS_BORROWED];
    }

    public bool BorrowItem(Item item)
    {
        bool added = false;

        for(int i = 0; i < MAX_ITEMS_BORROWED; i++){
            //  find a empty spot in the array to store the item borrowed
            if(itemsBorrowed[i] == null)
            {
                itemsBorrowed[i] = item;
                added = true;
                break;
            }
        }

        return added;
    }

    public bool HasItem(Item item)
    {
        for(int i = 0; i < MAX_ITEMS_BORROWED; i++)
        {
            if(itemsBorrowed[i]!=null && itemsBorrowed[i].Name == item.Name) {
                return true;
            }
        }

        return false;
    }

    public bool ReturnItem(Item item)
    {
        bool returned = false;

        //  search for the item and remove it. we can do this by set the index position of the item to null
        for(int i = 0; i < MAX_ITEMS_BORROWED; i++){
            if(itemsBorrowed[i]!= null && itemsBorrowed[i].Name == item.Name) 
            {
                itemsBorrowed[i] = null;
                returned = true;
                break;
            }
        }

        return returned;
    }
}