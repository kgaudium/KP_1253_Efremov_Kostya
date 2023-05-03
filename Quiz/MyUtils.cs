using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;

namespace Quiz;

public static class MyUtils
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

    public static string DictToString(Dictionary<object, object> dict)
    {
        string result = "{\n";
        
        foreach (var pair in dict)
        {
            result += $"\t{pair.Key}: {pair.Value},\n";
        }

        return result.Substring(0, result.Length-2) + "\n}";
    }

    public static string ListToString(List<object> list)
    {
        string result = "[";
        
        foreach (var obj in list)
        {
            result += $"{obj}, ";
        }

        return result.Substring(0, result.Length-2) + ']';
    }
    
    public static string ToDescription<T>(this T value) where T : Enum
    {
        var attribute = typeof(T)
            .GetField(value.ToString())
            .GetCustomAttribute<DescriptionAttribute>();

        return attribute != null ? attribute.Description : value.ToString();
    }
}