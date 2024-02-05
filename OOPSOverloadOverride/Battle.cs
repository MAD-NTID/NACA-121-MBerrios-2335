public class Battle
{
    public Monster monster1 { get; }
    public Monster monster2 { get; }   
    private Monster attackingMonster;

    // We need a default constructor with default values in case the parameterized constructor is not used, so we create fake monsters
    public Battle()
    {
        monster1 = new Monster("Leviathan");
        monster2 = new Monster("God of War");

        attackingMonster = GetRandomMonster();
    }

    public Battle(Monster monster1, Monster monster2)
    {
        this.monster1 = monster1;
        this.monster2 = monster2;
        
        attackingMonster = GetRandomMonster();
    }

    private Monster GetRandomMonster()
    {
        // Ternary Operator (The short way)
        return new Random().Next(2) == 1 ?
            monster1 : monster2;

        // The Long Way
        // int randomNum = new Random().Next(0, 1);

        // if(randomNum == 1)
        //     attackingMonster = monster1;
        // else
        //     attackingMonster = monster2;
        // 
        // return attackingMonster;
    }

    public Monster GetCurrentAttacker()
    {
        return attackingMonster;
    }

    public void Attack()
    {
        // Implement a Critical Hit (10% chance)
        int criticalHitPower = 1;
        if(new Random().Next(10) == 1)
            criticalHitPower = new Random().Next(2, 4);

        // Determine if the monster attacking is not the same as itself
        if(attackingMonster != monster1)
        {
            monster1.HP -= attackingMonster.Power * criticalHitPower;
            attackingMonster = monster1;
        }
        else
        {
            monster2.HP -= attackingMonster.Power * criticalHitPower;
            attackingMonster = monster2;
        }
    }

    public Monster? GetWinner()
    {
        if(monster1.HP <= 0)
            return monster2;
        
        if(monster2.HP <= 0)
            return monster1;
        
        return null;
    }
}