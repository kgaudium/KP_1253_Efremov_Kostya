namespace PasswordGenerator;

public static class MyUtils
{
    public static void PrintAndExit(string message)
    {
        Console.WriteLine("Error! " + message);
        Environment.Exit(1);
    }
    public static void PrintWarning(string message)
    {
        Console.WriteLine("Warning! " + message);
    }

    public static string ToBeautyString<T>(this IEnumerable<T> list)
    {
        string result = "[";

        foreach (var obj in list)
        {
            result += $"{obj}, ";
        }
        
        if (result.Length > 2)
        {
            result = result.Substring(0, result.Length - 2);
        }

        return result + "]";
    }
}