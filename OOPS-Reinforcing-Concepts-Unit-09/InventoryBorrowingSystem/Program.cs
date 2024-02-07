const int MAX_PERSONS = 30000;
Inventory inventory = new Inventory();
Person[] persons = new Person[MAX_PERSONS];

// Menu Items
string[] menu = new string[] 
{
    "Add New Item to Inventory",
    // "Delete Item from Inventory",
    "Show Inventory",
    "Lend Item (Check-out)",
    "Return Item to Inventory (Check-in)",
    "Exit"
};

void ShowMenu()
{
    for(int i = 0; i < menu.Length; i++)
        Console.WriteLine($"{i + 1}. {menu[i]}");
}

int PromptMenu()
{
    int choice = 0;

    do {
        Console.Write($"Enter your choice from (1 - {menu.Length}): ");

        if(!int.TryParse(Console.ReadLine(), out choice))
            Console.WriteLine("Invalid Choice");

        Console.WriteLine();
    } while(choice <= 0 && choice > menu.Length);

    return choice;
}

// Creates a New Item Object and Return it
Item NewItem()
{
    Item item = null;
    string name;
    string category;
    int id;

    while(true)
    {
        Console.Write("Item Id:");
        if(int.TryParse(Console.ReadLine(), out id) && id > 0)
            break;
        
        Console.WriteLine("Item Id must be a digit greater than 0!");
    }

    while(true)
    {
        Console.Write("Item Category:");
        category = Console.ReadLine();
        if(!string.IsNullOrEmpty(category))
            break;
        
        Console.WriteLine("Category cannot be empty or null");
    }

    while (true)
    {
        Console.Write("Item Name:");
        name = Console.ReadLine();

        if(!string.IsNullOrEmpty(name))
            break;
        
        Console.WriteLine("Item name cannot be empty or null");
    }

    return new Item(id, name, category);
}

string GetPersons()
{
    string persons = string.Empty;

    for(int i = 0; i < persons.Length; i++)
    {
        if(!persons[i].Equals(null))
            persons += $"{i + 1}. {persons[i]}\n";
    }

    if(string.IsNullOrEmpty(persons))
        return "No Persons Available";

    return persons;
}

// Program
int choice = 0;
do {
    ShowMenu();

    choice = PromptMenu();

    if(choice == 1)
    {
        inventory.AddItem(NewItem());
    }
    else if(choice == 2)
    {
        Console.WriteLine("Inventory Listing: ");
        inventory.ShowAvailableItems();
    }
    else if(choice == 3)
    {
        Console.WriteLine("Loaning an Equipment: ");
        Console.WriteLine(GetPersons());
    }
    else if(choice == 5)
    {
        Console.WriteLine("Exiting");
    }
    else
    {
        Console.WriteLine("Invalid Choice");
    }

    Console.WriteLine();

} while(choice != 5);