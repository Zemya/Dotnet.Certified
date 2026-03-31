
//Array Creation and Traversal

int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

Console.WriteLine("\n");

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.\n");