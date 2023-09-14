// -------------------------------------- The Melee Fighter Class: --------------------------------------

// Health starts at a default of 120
// Attacks:
//          Punch, 20 damage
//          Kick, 15 damage
//          Tackle, 25 damage
// Rage method - The fighter performs a random attack from its AttackList, but the attack deals 10 extra damage
//          Hint: How will you handle updating the DamageAmount of your attack when you perform the attack?


public class Melee : Enemy
{
    public Melee(string n) : base(n, 120)
    {
        AttackList = new List<Attack>()
        {
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25),
        };
    }

    public void Rage(Enemy Target)
    {
        Attack randomAttack = RandomAttack();
        int dmgAmount = randomAttack.DamageAmount + 10;
        Target.ChangeHealth(dmgAmount);
    }
}