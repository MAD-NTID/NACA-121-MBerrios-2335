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

    int menuChoice;

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
        if(ship.IsShipFull())
            Console.WriteLine($"The ship is full and alien crew can't be added");
        else
        {
            Alien alien = null;
            bool added = false;

            do
            {
                if(alien != null && (alien.IsCaptain() || alien.IsChief()))
                    Console.WriteLine($"Only 1 {Alien.CAPTAIN_ROLE} or {Alien.CHIEF_ROLE} allowed!\n");

                string name, role;

                Console.Write("Enter the alien's name: ");
                name = Console.ReadLine();

                Console.Write("Enter the alien's role: ");
                role = Console.ReadLine();

                alien = new Alien(name, role);
            } while(!ship.Add(alien));

            Console.WriteLine($"Alien was added to the ship: {alien}");
        }
    }
    else if(menuChoice == 2)
    {
        ship.Fly();

        Console.WriteLine($"{ship.Name} flew {ship.Distance} interstellar distance at {ship.Speed} warp speed");
    }
    else if(menuChoice == 3)
    {
        Console.Write("Enter a warp speed in multiple of 3: ");

        if(int.TryParse(Console.ReadLine(), out int warpSpeed) && warpSpeed > 0 && warpSpeed % 3 == 0)
        {
            ship.Fly(warpSpeed);

            Console.WriteLine($"{ship.Name} flew {ship.Distance} interstellar distance at {ship.Speed} warp speed");
        }
        else
            Console.WriteLine("Invalid Speed! Speed must be an integer in multiple of 3! Ship did not fly!");
    }
    else if(menuChoice == 4)
    {
        Console.Write("Enter name of alien to remove: ");
        string name = Console.ReadLine();

        if(ship.Remove(name))
            Console.WriteLine($"Alien {name} was removed");
        else
            Console.WriteLine($"Alien {name} does not exist");
    }
    else if(menuChoice == 5)
    {
        Console.WriteLine(ship);
    }
    else if(menuChoice == 6)
    {
        Console.WriteLine("Thank you for exploring space with use!");
        break;
    }
    else
        Console.WriteLine("Invalid Choice");
    
    Console.WriteLine();
}