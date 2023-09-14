// -------------------------------------- The Magic Caster Class: --------------------------------------

// Health starts at a default of 80
// Attacks:
//          Fireball, 25 damage
//          Lightning Bolt, 20 damage
//          Staff Strike, 10 damage
// Heal method - The fighter heals a targeted Enemy character for 40 health and displays the new health at the end


public class MagicCaster : Enemy
{
    public MagicCaster(string n) : base(n, 80)
    {
        AttackList = new List<Attack>()
        {
            new Attack("Fireball", 25),
            new Attack("Lightning", 20),
            new Attack("Staff Strike", 10)
        };
    }

    public void Heal(Enemy Target)
    {
        if((Target._Health + 40) > Target._maxHealth)
        {
            int difference = (Target._maxHealth - Target._Health) * -1;
            Target.ChangeHealth(difference);
        } else {
            Target.ChangeHealth(-40);
        }
        Console.WriteLine($"{Name} heals {Target.Name} to {Target._Health} health!");
    }
}