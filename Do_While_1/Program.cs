
string? input;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    input = Console.ReadLine();
    if (input != null)
    {
        validNumber = int.TryParse(input, out numValue);
        if (validNumber)
        {
            if (numValue >= 5 && numValue <= 10)
            {
                valueEntered = input;
                Console.WriteLine($"You entered ({input}), a valid number");
            }
            else
            {
                Console.WriteLine($"Sorry, you entered ({input}) an invalid number, please try again");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    }
}

while (input == null);
