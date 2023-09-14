// -------------------------------------- The Enemy Class: --------------------------------------

// Enemy fields:
//          Name (i.e. Bandit, Boss, Guard)
//          Health
//          AttackList -- This will be a List of type Attack that will hold the various Attacks an enemy can perform
// Constructor: 
//          When an Enemy is created, we must provide their Name upon creation
//          Health will start at a default value of 100
//          AttackList will initialize as an empty List
// Methods:
//          RandomAttack: the enemy object performs a randomized attack from their AttackList (hint: remember Random()?)

public class Enemy
{
    public string Name;
    public int health;
    public int _Health {get {return health;}}
    public List<Attack> AttackList;
    private int maxHealth;
    public int _maxHealth {get {return maxHealth;}}

    public Enemy (string name)
    {
        Name = name;
        health = 100;
        maxHealth = 100;
        AttackList = new List<Attack>();
    }

    public Enemy(string n, int h)
    {
        Name = n;
        health = h;
        maxHealth = h;
        AttackList = new List<Attack>();
    }

    public Attack RandomAttack ()
    {
        Random ran = new Random();
        int randomNum = ran.Next (0, AttackList.Count);
        Console.WriteLine($"{Name} performed attack {AttackList[randomNum].Name}");
        return AttackList[randomNum];
    }


    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.health-=ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} using {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target._Health}");
    }

    public void ChangeHealth(int Amount)
    {
        health -=Amount;
        Console.WriteLine($"{Name}'s health is now {health}");
    }


}