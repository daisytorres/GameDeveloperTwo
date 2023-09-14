// -------------------------------------- The Ranged Fighter Class: --------------------------------------

// Ranged enemies have a Distance field that tracks how far from the player the ranged enemy is (the "player" in this scenario is theoretical 
//and does not need to be factored into the code at this time)
// The Distance field defaults to 5 upon initialization
// Attacks:
//          Shoot an Arrow, 20 damage
//          Throw a Knife, 15 damage
// A ranged enemy cannot perform an attack if Distance is less than 10
// Dash method - The fighter performs a dash, setting Distance to 20
//          Note: Do not worry about Distance when considering if a close-range attack like a punch can hit a Ranged fighter, just assume it will for now

public class Ranged : Enemy
{
    public int Distance;

    public Ranged(string n) : base(n)
    {
        Distance = 5;
        AttackList = new List<Attack>()
        {
            new Attack("Shoot Arrow", 20),
            new Attack("Throw Knife", 15)
        };
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance < 10)
        {
            Console.WriteLine("Too close to attack!");
        } else {
            Target.ChangeHealth(ChosenAttack.DamageAmount);
            Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target._Health}!!");
        }
    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"{Name} dashed away!");
    }
}