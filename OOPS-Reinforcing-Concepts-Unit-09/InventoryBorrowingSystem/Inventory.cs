public class Inventory
{
    private const int MAX_ITEMS = 100000;
    private Item[] availableItems;
    private Item[] loanedOutItems;

    public Item[] AvailableItems
    {
        get{return availableItems;}
    }

    public Item[] LoanedOutItems
    {
        get{return loanedOutItems;}
    }

    public Inventory()
    {
        availableItems = new Item[MAX_ITEMS];
        loanedOutItems = new Item[MAX_ITEMS];
    }

    public void AddItem(Item item)
    {
        for(int i = 0; i < MAX_ITEMS; i++)
        {
            if(availableItems[i] == null)
            {
                availableItems[i] = item;
                break;
            }
        }
    }

    public void ReturnItem(Item item)
    {
        //  first we need to remove the item from the loaned out
        for(int i = 0; i < MAX_ITEMS; i++){
            Item loanedItem = loanedOutItems[i];
            if(loanedItem!= null && loanedItem.Name == item.Name)
            {
                loanedOutItems[i] = null;
                break;
            }
        }

        //then we need to add the item to the available items
        AddItem(item);
    }

    public void ShowAvailableItems()
    {
        Console.WriteLine("Available Items:");
        for(int i = 0; i < MAX_ITEMS; i++)
        {
            Item available = availableItems[i];
            if(available!=null) {
                Console.WriteLine(available.ToString());
            }
        }
    }

        public void ShowLoanedItems()
    {
        Console.WriteLine("Loaned Items:");
        for(int i = 0; i < MAX_ITEMS; i++)
        {
            Item loan = loanedOutItems[i];
            if(loan!=null) {
                Console.WriteLine(loan.ToString());
            }
        }
    }
}