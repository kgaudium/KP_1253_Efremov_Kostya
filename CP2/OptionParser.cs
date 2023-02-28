using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;

namespace PasswordGenerator;

public class OptionParser
{
    public static void ParseOptions(string[] args, Option[] optionsArray, Option defaultOption)
    {
        // Парсит опции (сделать проверку на то, задавались ли опции ранее?)
            for (int i = 0; i < args.Length; i++)
            {
                string[] splitOption = args[i].Split('-');

                if (splitOption.Length == 1) // Если без минусов
                {
                    if (args.Length != 1) // и в списке всего одна опция
                    {
                        // throw new Exception($"Unrecognized option: {args[i]}");
                        MyUtils.PrintAndExit($"Unrecognized option: {args[i]}");
                    }
                    
                    if (defaultOption.ArgumentType == null) // Если у дефольной опции нет аргумента
                    {
                        throw new Exception("Default Option must have argument!");
                    }
                    

                    // if (i + 1 >= args.Length) throw new Exception($"Option \"{option.Name}\" must have a {option.ArgumentType} argument!");
                    string optionArg = args[i];
                
                    if (TypeDescriptor.GetConverter(defaultOption.ArgumentType).IsValid(optionArg)) // Если аргумент можно привести к нужному типу
                        defaultOption.TargetMethod.DynamicInvoke(Convert.ChangeType(optionArg, defaultOption.ArgumentType)); // То вызывем таргет функцию с этим аргументом
                    else
                    {
                        // throw new Exception($"Invalid {option.Name} option argument: {optionArg}! Must be a {option.ArgumentType}");
                        MyUtils.PrintAndExit($"Invalid {defaultOption.Name} option argument: {optionArg}! Must be a {defaultOption.ArgumentType}");
                    }
                }
                
                
                else if (splitOption.Length == 2) // Если один минус -
                {
                    char shortName;
                    if (char.TryParse(splitOption[1], out shortName)) // получилось преобразовать имя в символ
                    {
                        Option option = FindOptionByShortName(shortName, optionsArray); // ищем опцию в списке опций

                        if (option == null) // не нашли
                            // throw new Exception($"Option {args[i]} not found!");
                            MyUtils.PrintAndExit($"Option {args[i]} not found!");

                        
                        if (option.ArgumentType == null) // Если опция без аргументов, то вызываем её
                        {
                            option.TargetMethod.DynamicInvoke();
                            continue;
                        }

                        if (i + 1 >= args.Length) // Если аргумент не указан 
                        {
                            MyUtils.PrintAndExit($"Option \"{option.Name}\" must have a {option.ArgumentType} argument!");
                        }
                        
                        string optionArg = args[++i];
                        if (!TypeDescriptor.GetConverter(option.ArgumentType).IsValid(optionArg)) // не смогли преобразовать аргумент в нужный тип
                        {
                            MyUtils.PrintAndExit($"Invalid {option.Name} option argument: {optionArg}! Must be a {option.ArgumentType}");
                        }
                        
                        option.TargetMethod.DynamicInvoke(Convert.ChangeType(optionArg, option.ArgumentType)); // всё смогли
                    }
                    else
                    {
                        foreach (char opt in splitOption[1])
                        {
                            Option option = FindOptionByShortName(opt, optionsArray);

                            if (option == null)
                            {
                                // throw new Exception($"Unrecognized option: {args[i]}");
                                MyUtils.PrintAndExit($"Unrecognized option: {args[i]}");
                            }
                            else if (option.ArgumentType != null)
                            {
                                MyUtils.PrintAndExit($"{option.Name} option have an argument of type {option.ArgumentType} and and cannot be written in format {args[i]}!");
                            }
                            
                            option.TargetMethod.DynamicInvoke();
                        }
                        
                    }
                    
                }
                
                else if (splitOption.Length == 3) // Если два минуса --
                {
                    Option option = FindOptionByName(splitOption[2], optionsArray);

                    if (option == null)
                        // throw new Exception($"Option {args[i]} not found!");
                        MyUtils.PrintAndExit($"Option {args[i]} not found!");

                    if (option.ArgumentType == null) // Если опция без аргументов, то вызываем её
                    {
                        option.TargetMethod.DynamicInvoke();
                        continue;
                    }
                    
                    if (i + 1 >= args.Length) // Если аргумент не указан 
                    {
                        MyUtils.PrintAndExit($"Option \"{option.Name}\" requires a {option.ArgumentType} argument!");
                    }
                    
                    string optionArg = args[++i];
                    if (!TypeDescriptor.GetConverter(option.ArgumentType).IsValid(optionArg)) // не смогли преобразовать аргумент в нужный тип
                    {
                        MyUtils.PrintAndExit($"Invalid {option.Name} option argument: {optionArg}! Must be a {option.ArgumentType}");
                    }

                    option.TargetMethod.DynamicInvoke(Convert.ChangeType(optionArg, option.ArgumentType));
                }

                else
                {
                    // throw new Exception($"Invalid option: {args[i]}");
                    MyUtils.PrintAndExit($"Invalid option: {args[i]}");
                }
            }
            
        
    }
    public static Option FindOptionByName(string name, Option[] allowedOptions)
    {
        foreach (var argument in allowedOptions)
        {
            if (argument.Name == name) return argument;
        }

        return null;
    }
    public static Option FindOptionByShortName(char shortName, Option[] allowedOptions)
    {
        foreach (var argument in allowedOptions)
        {
            if (argument.Shortname == shortName) return argument;
        }

        return null;
    }
}