namespace PasswordGenerator;

public class MyUtils
{
    public static void PrintAndExit(string message)
    {
        Console.WriteLine(message);
        Environment.Exit(1);
    }
    public static void PrintWarning(string message)
    {
        Console.WriteLine("Warning! " + message);
    }

}