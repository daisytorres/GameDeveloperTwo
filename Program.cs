// See https://aka.ms/new-console-template for more information

// -------------------------------------- Testing Game Dev 1 --------------------------------------

// Create an instance of an Enemy in Program.cs (you can create any enemy you would like)
// Create 3 instances of Attacks in Program.cs (again, you can create any attacks you would like. Have fun with it!)
// Add the three Attacks to your Enemy instance's AttackList (hint: how do you add items to a List?)
// Call your Enemy instance's RandomAttack method to test that a random Attack can be called on 
//(a good developer will run this multiple times to ensure there are no bugs)


// -------------------------------------- Testing Game Dev 2 --------------------------------------
// Once all your classes are created, complete the following series of actions to test all your new code:

// Create instances of the Melee, Ranged, and Magic Caster classes
// Perform the Kick Attack from your Melee class character on your Ranged character
// Perform the Rage method from your Melee class character on your Magic Caster character
// Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)
// Have your Ranged character perform the Dash method
// Perform another Shoot an Arrow Attack from your Ranged character (this one should have worked now if everything is set up properly)
// Perform a Fireball Attack from your Magic Caster on your Melee character
// Have the Magic Caster perform the Heal method on the Ranged character
// Have the Magic Caster perform the Heal method on themselves

// ----- Bonuses:
// Write special Console messages for each fighter's PerformAttack method
//          You can add even more detail by considering what types of messages would appear for specific attacks
// You may have noticed that when you Heal a character they can end up with more health than they started with. Can you think of a clever way to ensure that your character does not go above their maximum health?
// Conversely, do you think a character should be able to attack another character who has 0 health? Or that a character with 0 health should be capable of attacking? How can you ensure that a character can only be attacked/perform attacks so long as their health is a positive value?
// Have your code reviewed by someone else to see how you might make your code more efficient (comparing your code to someone else's code is a great way to learn!) Some potential areas to check for efficiency might include:
//          Assessing where and how you chose to assign each Attack to your enemies
//          Considering best practices when affecting another character's stats (like in the PerformAttack or Heal method)
//          How you tackled the bonus challenges



// -------------------------------------- Testing Game Dev 3 --------------------------------------
// Create instances of the Melee, Ranged, and Magic Caster classes
// Perform the Kick Attack from your Melee class character on your Ranged character
// Perform the Rage method from your Melee class character on your Magic Caster character
// Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)
// Have your Ranged character perform the Dash method
// Perform another Shoot an Arrow Attack from your Ranged character (this one should have worked now if everything is set up properly)
// Perform a Fireball Attack from your Magic Caster on your Melee character
// Have the Magic Caster perform the Heal method on the Ranged character
// Have the Magic Caster perform the Heal method on themselves



// Create an instance of an Enemy
Enemy enemy = new Enemy("Chun Li", 100);

// Create 3 instances of Attacks
Attack attack1 = new Attack("Yoso Kick", 20);
Attack attack2 = new Attack("Water Lotus Fist", 10);
Attack attack3 = new Attack("Spinning Bird Kick", 15);

// Add the three Attacks to your Enemy instance's AttackList
enemy.AttackList.Add(attack1);
enemy.AttackList.Add(attack2);
enemy.AttackList.Add(attack3);

// Call your Enemy instance's RandomAttack method to test random attack:
Console.WriteLine($"{enemy.Name} has {enemy.AttackList.Count} attacks:");
foreach (Attack a in enemy.AttackList)
{
    enemy.RandomAttack();
}
