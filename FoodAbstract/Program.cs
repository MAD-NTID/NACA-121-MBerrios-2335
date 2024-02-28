// Food food = new Chicken(400, 20);
// ((Chicken)food).Texture = "Tender";

// Console.WriteLine(food.GetTexture());

int totalCalories = 0, totalFat = 0;

Food[] dinnerPlate = new Food[100];
dinnerPlate[0] = new Chicken(400, 20);
dinnerPlate[1] = new Spaghetti(200, 3);
dinnerPlate[2] = new Sausage(800, 30);
dinnerPlate[3] = new Sauce("Marinara", 100, 0);

Console.WriteLine("Our plate consist of...");
foreach(Food food in dinnerPlate)
{
    if(food != null)
    {
        Console.WriteLine($"{food}");
        
        if(food is Sauce)
            ((Sauce)food).Make();
        else if(food is Spaghetti)
            ((Spaghetti)food).Boil();
        else
            food.Cook();

        //  Extra Spacing
        Console.WriteLine();

        totalCalories += food.Calories;
        totalFat += food.Fat;
    }
}

Console.WriteLine();
Console.WriteLine($"You will eat a total of {totalCalories} calories, and {totalFat} fat.");