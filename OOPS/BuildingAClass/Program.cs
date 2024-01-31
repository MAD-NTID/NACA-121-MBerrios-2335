//  Instantiate a Food
Food muffin = new Food();

//  Assign values to that instance's properties
muffin.name = "Corn Muffin";
muffin.type = "Pastry";
muffin.calories = 200;

// this property is private, and can't be directly modifed
// muffin.weight = 2; // oz

//  Output the property values of that instance
Console.WriteLine($"This is a {muffin.type} called {muffin.name} which has a caloric intake of {muffin.calories}");

// Food now has a parameterized constructor, so let's use it
Food steak = new Food("Steak", "Meat", 500, 8);

Console.WriteLine($"This is a {steak.type} called {steak.name} which has a caloric intake of {steak.calories}");

// Because we added a parameterized constructor to the Food class, the C# default constructor is no longer functioning. However, if you do want to still have the ability to create default constructor, you can add it manually. Check the default constructor in Food.

// We can use the default constructor to our advantage such as setting up default values
Food proteinShake = new Food();

Console.WriteLine($"This is a {proteinShake.type} called {proteinShake.name} which has a caloric intake of {proteinShake.calories}");

//  Now that we have the basics covered, let's create an array of Food
Food[] foods = new Food[3];
foods[0] = muffin;
foods[1]= steak;
foods[2] = proteinShake;

Console.WriteLine();
Console.WriteLine("Printing the foods arrays using a for loop: ");
for(int i = 0; i < foods.Length; i++)
    Console.WriteLine($"This is a {foods[i].type} called {foods[i].name} which has a caloric intake of {foods[i].calories}");