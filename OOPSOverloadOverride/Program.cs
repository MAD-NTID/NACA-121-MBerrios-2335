// Let's build two monsters
Monster monster1 = new Monster();
monster1.Name = "Gustavio";

Monster monster2 = new Monster("Osminion");

// Console.WriteLine(monster1.ToString());
// Console.WriteLine();
// Console.WriteLine(monster2);

// Create a new Battle
Battle battle = new Battle(monster1, monster2);
Console.WriteLine("Let's Get Ready to Ruuuuuuuumbleeeeee!");
Console.WriteLine("Contestand Number 1: ");
Console.WriteLine(battle.monster1);
Console.WriteLine();
Console.WriteLine("Contestand Number 2: ");
Console.WriteLine(battle.monster2);
Console.WriteLine();
Console.WriteLine("Battle Start");

int round = 1;

while(battle.GetWinner() == null)
{
    Console.WriteLine($"Round: {round++}\n");

    Monster currentAttacker = battle.GetCurrentAttacker();
    Console.WriteLine($"Currently Attacking\n{currentAttacker}\n");
    
    //  We know that after the attack, the current attacking will change
    battle.Attack();

    Console.WriteLine($"{currentAttacker.Name} attacked with {currentAttacker.Power} power");

    //  So now we can use GetCurrentAttacker to get the monster that was attacked, and display its health
    Console.WriteLine($"Attacked Monster's Health: {battle.GetCurrentAttacker().HP}");

    // Check if a monster is defeated
    Monster? winner = battle.GetWinner();
    if(winner != null)
    {
        Console.WriteLine($"{winner.Name} has won!");
    }

    //  A Spacer
    Console.WriteLine();
    Thread.Sleep(1000);
}

Console.WriteLine("Battle Ended");
