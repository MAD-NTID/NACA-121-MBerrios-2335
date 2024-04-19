VideoGame vg1 = new("GTA 5", 69.99, 2013);
VideoGame vg2 = new("Resident Evil 2", 29.99, 2019);

Console.WriteLine($"{vg1} - Expensive? {vg1.IsGameTooExpensive}");
Console.WriteLine($"{vg2} - Expensive? {vg2.IsGameTooExpensive}");

Console.WriteLine();
Console.WriteLine($"{vg1.Title} is older than {vg2.Title}? {vg1.IsOlderThan(vg2)}");
Console.WriteLine($"{vg2.Title} is older than {vg2.Title}? {vg1.IsOlderThan(vg1)}");

//  Statement Lambda on the Program.cs and not in a class
Func<VideoGame, VideoGame, VideoGame> MostExpensiveGame = (x, y) => {
    return x.Price > y.Price ? x : y;
};

Action<VideoGame, VideoGame> ShowMostExpensiveGame = (x, y) => Console.WriteLine($"The most expensive game is: {MostExpensiveGame(vg1, vg2)}");

ShowMostExpensiveGame(vg1, vg2);