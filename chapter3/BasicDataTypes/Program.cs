using System.Numerics;

Console.WriteLine("***** Fun with Basic Data Types *****");
LocalVarDeclarations();

static void LocalVarDeclarations(){
    Console.WriteLine("=> Data Declarations:");
    // Local variables are declared and initialized as follows:
    // dataType varName = initialValue;
    int myInt = 0;
    string myString;
    myString = "This is my character data";
    // Declare 3 bools on a single line.
    bool b1 = true, b2 = false, b3 = b1;
    // Use System.Boolean data type to declare a bool.
    System.Boolean b4 = false;
    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
    myInt, myString, b1, b2, b3, b4);
    Console.WriteLine();
}

static void DefaultDeclarations(){
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
    Console.WriteLine(myInt);
}

static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    /*
    bool b = new(); // Set to false.
    int i = new(); // Set to 0.
    double d = new(); // Set to 0.
    DateTime dt = new(); // Set to 1/1/0001 12:00:00 AM
    */
    bool b = new bool(); // Set to false.
    int i = new int(); // Set to 0.
    double d = new double(); // Set to 0.
    DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}