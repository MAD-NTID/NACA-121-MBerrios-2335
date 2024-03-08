Cars cars = new();

string menuChoice = string.Empty;

while(string.IsNullOrEmpty(menuChoice))
{
    Console.WriteLine("1) Write\n2) Read\n3) GetCar\nAnything Else to Exit");
    Console.Write("Choose: ");

    menuChoice = Console.ReadLine();

    if(menuChoice == "1")
    {
        cars.WriteStream();
        Console.WriteLine($"Information has been saved to the {cars.CarsFile} file");
    }
    else if(menuChoice == "2")
    {
        if(cars.ReadStream())
            Console.WriteLine($"Information has been loaded from {cars.CarsFile} file");
        else
            Console.WriteLine($"Could not located {cars.CarsFile} file");
    }
    else if(menuChoice == "3")
    {
        Console.WriteLine(cars);
        Console.Write("Enter a car to get: ");

        int row = int.Parse(Console.ReadLine());

        Console.WriteLine(cars.GetCar(row));
    }
    else
        Console.WriteLine("Buh Bye");

    Console.WriteLine();
}

Console.WriteLine($"Data:\n{cars}");
