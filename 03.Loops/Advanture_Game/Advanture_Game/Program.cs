Console.WriteLine("Wellcome to this Game! by Behnam Safari");

System.Console.WriteLine("Enter your characters's name: ");
string characterName = Console.ReadLine()!;

System.Console.WriteLine("Choose your character (Warrior, Wizzard, Archer)");
string characterType = Console.ReadLine()!;

System.Console.WriteLine($"You, {characterName} the {characterType} find yourself at the edge of the dark!");

System.Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp): ");
string choice1 = Console.ReadLine()!;

if (choice1.ToLower() == "enter")
{
    System.Console.WriteLine("You bravely enter the forest");
}
else
{
    System.Console.WriteLine("You decide to camp out and wait for daylight");
}

bool gameContiues = true;

while (gameContiues)
{
    System.Console.WriteLine("You come to a fork in the road. Go left or right?");
    string direction = Console.ReadLine()!;
    if (direction.ToLower() == "left")
    {
        System.Console.WriteLine("You find a treasure chest!");
        gameContiues = false;
    }
    else
    {
        System.Console.WriteLine("You encounter a wild beast!");
        System.Console.WriteLine("Fight or flee (fight/flee)");
        string fightChoice = Console.ReadLine()!;
        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);

            System.Console.WriteLine(luck);

            if (luck > 5)
            {
                System.Console.WriteLine("You beat the wild beast!");
                if (luck > 8)
                {
                    System.Console.WriteLine("The wild beast dropped a treasure :))))");
                }
            }
            else
            {
                System.Console.WriteLine("The beat kiked your ass off ");
                gameContiues = false;
            }

        }
    }
}

System.Console.WriteLine("Thank you for playing");