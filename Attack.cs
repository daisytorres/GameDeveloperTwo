// -------------------------------------- The Attack Class: --------------------------------------
// Attack fields:
//          Name (i.e. fireball, punch, throw)
//          DamageAmount (i.e. a fireball will do 20 damage, keep the damage range between 5 and 25)
// Constructor: When an Attack is created, we must specify the Name and DamageAmount upon creation

public class Attack
{
    public string Name;
    public int DamageAmount;

    public Attack (string name, int damage)
    {
        Name = name;
        DamageAmount = damage;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name} did {DamageAmount}");
    }
}