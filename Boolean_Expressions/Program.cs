
string permission = "Admin||Manager";
int level = 60;

if (permission == "Admin" && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission == "Admin" && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission == "Manager" && level > 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else if (permission == "Manager" && level < 20)
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else if (permission != "Admin || Manager")
{
    Console.WriteLine("You do not have sufficient privileges.");
}