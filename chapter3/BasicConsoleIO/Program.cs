Console.WriteLine("***** Basic Console I/O *****");
GetUserData();
Console.ReadLine();

static void GetUserData()
{
    // get name and age
    Console.Write("Please enter your name: ");
    string? userName = Console.ReadLine();
    Console.Write("Please enter your age: ");
    string? userAge = Console.ReadLine();
    Console.Write("Please enter your budget: ");
    string? userBudget = Console.ReadLine();

    // change echo color
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    // echo to the console
    Console.WriteLine("Hello {0}! You are {1} years old and have R${2:f2}", userName, userAge, userBudget != null ? float.Parse(userBudget) : 0);

    // restore previous color
    Console.ForegroundColor = prevColor;
}