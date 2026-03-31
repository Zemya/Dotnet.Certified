
Console.WriteLine("");
//String Composite Formatting with Format Specifiers
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

Console.WriteLine("");

Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
Console.WriteLine("");

//String Interpolation with Format Specifiers

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
Console.WriteLine("");


//Using Format Specifiers
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

Console.WriteLine("");

decimal newprice = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (newprice - salePrice), newprice);

//Combining formatting approaches
yourDiscount += $"A discount of {((newprice - salePrice)/newprice):P2}!"; //inserted
Console.WriteLine(yourDiscount);

Console.WriteLine("");