class Program {
    static int Main(string[] args) {
        Console.WriteLine("***** My First C# App *****");
        Console.WriteLine("Hello {0}!", Environment.UserName);
        Console.WriteLine("\nThese are your PC settings");
        ShowEnvironmentDetails();
        // Process any incoming args.
        /*
        for(int i = 0; i < args.Length; i++){
            Console.WriteLine("Arg: {0}", args[i]);
        }
        string[] theArgs = Environment.GetCommandLineArgs();
        foreach(string arg in theArgs){
            Console.WriteLine("Arg: {0}, arg");
        }
        foreach(string arg in args){
            Console.WriteLine("Arg: {0}", arg);
        }
        */
        // Wait for Enter key to be pressed before shutting down
        Console.ReadLine();

        return 0;
    }

    static void ShowEnvironmentDetails(){
        foreach(string drive in Environment.GetLogicalDrives()){
            Console.WriteLine("Drive: {0}", drive);
        }
        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
        Console.WriteLine(".NET Version: {0}", Environment.Version);
    }
}