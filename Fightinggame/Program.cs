//RNG

Random generaotor = new Random();

//logic bs

int playerhp = 100;
int enemyhp = 100;

//start of the game


Console.WriteLine($"Select a name!");
string playername = Console.ReadLine().ToLower();


//game loop
while (playerhp >= 1 || enemyhp >= 1)
{
    int damageplayer = generaotor.Next(42, 61);
    int damageenemy = generaotor.Next(42, 61);

    //play
    Console.WriteLine($"{playername} do you wish to attack?");
    string choice = Console.ReadLine(). ToLower();
    if (choice == "yes")
    {
        //grphics

        Console.WriteLine($"Enemy hp {enemyhp}");
        Console.WriteLine($"{playername}'s hp {playerhp}");
        Console.WriteLine($"you attack and did {damageplayer} damage! ");

        
        //gameplay

        enemyhp -= damageplayer;

        if(enemyhp <=0){
            Console.WriteLine("Nice job you won");
            break;
        }

        Console.WriteLine($"It's your enemys turn...");
        Console.ReadLine();

        

        playerhp -= damageenemy;
        
        Console.WriteLine($"The enemy did {damageenemy} damage!");

        if(playerhp <=0){
            Console.WriteLine("You lose hahahahaha...");
            break;
        }

        Console.WriteLine($"Enemy hp {enemyhp}");
        Console.WriteLine($"{playername}'s hp {playerhp}");
        
    }
    else if (choice == "no")
    {
        Console.WriteLine("you are gonna die");
    }
    else
    {
        
    }

}

if(playerhp <= enemyhp){

    Console.WriteLine("damn you lost");

}
else if (playerhp >= enemyhp){

    Console.WriteLine("damn you WON");
    
}

Console.ReadLine();