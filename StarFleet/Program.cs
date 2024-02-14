Ship ship = new Ship("Voyager", 3000);

string[] menuChoices = new string[] 
{
    "Add Alien to ship",
    "Fly",
    "Fly at a specific speed",
    "Remove an alien from the ship",
    "Show ship information",
    "Exit"
};

void PrintMenu()
{
    for(int i = 0; i < menuChoices.Length; i++)
        Console.WriteLine($"{i + 1}. {menuChoices[i]}");

    Console.Write("Select: ");
}

int Selection()
{
    int menuChoice = 0;

    menuChoice = int.Parse(Console.ReadLine());

    return menuChoice;
}

while(true)
{
    PrintMenu();

    int menuChoice = 0;

    try
    {
        menuChoice = Selection();
    }
    catch(FormatException fe)
    {
        Console.WriteLine("Invalid selection. Input must be a digit!");
        Console.WriteLine();
        continue;   
    }

    if(menuChoice == 1)
    {

    }
    else if(menuChoice == 2)
    {

    }
    else if(menuChoice == 3)
    {

    }
    else if(menuChoice == 4)
    {

    }
    else if(menuChoice == 5)
    {

    }
    else if(menuChoice == 6)
    {

    }
    else
        Console.WriteLine("Invalid Choice");
    
    Console.WriteLine();
}