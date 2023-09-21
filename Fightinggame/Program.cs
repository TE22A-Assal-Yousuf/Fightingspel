//RNG
Random genertaotor = new Random();

int Armour = 20;
int RNG = genertaotor.Next(10, 100);
int finaldamage = RNG - Armour;

if (finaldamage <= 0){
    Console.WriteLine("you died");
}
else{
    Console.WriteLine(finaldamage);
}

//Loop

int tal = 100;

while (tal > 0){
    Console.WriteLine(tal);
    tal--;
}

Console.ReadLine();