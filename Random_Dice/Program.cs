
Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"\nDice roll: {roll1} + {roll2} + {roll3} = {total}");

// Check for Triples First, then Doubles
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

// There is a logical bug in the original code where both bonuses could be applied
if (total >= 16)
{
    Console.WriteLine("You win a car!\n");
}
else if (total >= 10)
{
    Console.WriteLine("You win a laptop!\n");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip!\n");
}
else
{
    Console.WriteLine("You win a kitten!\n");
}
