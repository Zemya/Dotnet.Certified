
using System.Formats.Asn1;

Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if (daysUntilExpiration == 0)
{
    Console.WriteLine("\nYour subscription has expired!\n"); 
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("\nYour subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"\nYour subscription expires in {daysUntilExpiration} days!");
    discountPercentage = 10;
}
else if (daysUntilExpiration > 5)
{
    Console.WriteLine("\nYour subscription, will expire soon. Renew Now!\n");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Use code RENEW{discountPercentage} to renew your subscription and save {discountPercentage}%!\n");
}