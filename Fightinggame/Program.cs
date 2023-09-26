//RNG
Random generaotor = new Random();

//logic bs

int damageplayer = generaotor.Next(10, 21);
int damageenemy = generaotor.Next(10, 21);
int playerhp = 100;
int enemyhp = 100;

//start of the game


Console.WriteLine($"Select a name!");
string playername = Console.ReadLine().ToLower();


//game loop
while (playerhp >= 1 || enemyhp >= 1)
{
    //play
    Console.WriteLine($"{playername} do you wish to attack?");
    string choice = Console.ReadLine(). ToLower();
    if (choice == "yes")
    {
        
    }
    else if (choice == "no")
    {

    }
    else
    {

    }
}


Console.ReadLine();