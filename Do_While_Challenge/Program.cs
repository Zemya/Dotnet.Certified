
Random random = new Random();

int hero = 10;
int monster = 10;

do
{
    int heroAttack = random.Next(1, 11);
    int monsterAttack = random.Next(1, 11);

    monster -= heroAttack;
    hero -= monsterAttack;

    Console.WriteLine($"Hero attacks for {heroAttack}. Monster health: {monster}");
    if (monster <= 0)
    {
        Console.WriteLine("Monster defeated! Hero wins!");
        break;
    }

    Console.WriteLine($"Monster attacks for {monsterAttack}. Hero health: {hero}");
    if (hero <= 0)
    {
        Console.WriteLine("Hero defeated! Monster wins!");
        break;
    }

    Console.WriteLine();

} while (hero > 0 && monster > 0);