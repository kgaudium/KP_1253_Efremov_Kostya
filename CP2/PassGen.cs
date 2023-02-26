using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PasswordGenerator
{
    public class PassGen
    {
        static Random rand = new();
        
        static int WordLength;
        static int DigitCount;
        static int LetterCount;
        static bool UseUppercase;
        static bool UseSpecial;

        static List<int> AllowedTypes = new List<int>() {1,2};  // список типов, которые нужно генерить

        static Option[] AllowedOptions;

        static string pwd;
        // file, flags

        enum SymbolType : int
        {
          //   0      1      2      3        4
            Null, Digit, Lower, Upper, Special
        }

        static void Main(string[] args)
        {
            Option lenArg = new Option("length", typeof(int), SetLength);
            Option digitsArg = new Option("digits", typeof(int), SetDigitsCount);
            Option lettersArg = new Option("letters", typeof(int), SetLettersCount);
            Option upperArg = new Option("uppercase", 'u', SetUppercase);
            Option specialArg = new Option("special", 's', SetSpecial);

            AllowedOptions = new[] {lenArg, digitsArg, lettersArg, upperArg, specialArg }; // Список всех опций


            // Парсит опции (сделать проверку на то, задавались ли опции ранее?)
            for (int i = 0; i < args.Length; i++)
            {
                string[] splitOption = args[i].Split('-');

                if (splitOption.Length == 1) // Если без минусов
                {
                    if (args.Length == 1) // и в списке всего одна опция
                    {
                        int len;
                        
                        if (int.TryParse(splitOption[0], out len)) // пытаемся этот пргумент преобразовать в число
                        {
                            SetLength(len);
                        }
                        else
                        {
                            // throw new Exception($"Incorrect \"Length\" option: {args[i]} must be an integer");
                            PrintErrorAndExit($"Incorrect \"Length\" option: {args[i]} must be an integer");
                        }
                    }
                    else
                    {
                        // throw new Exception($"Unrecognized option: {args[i]}");
                        PrintErrorAndExit($"Unrecognized option: {args[i]}");
                    }
                }
                
                
                else if (splitOption.Length == 2) // Если один минус -
                {
                    char shortName;
                    if (char.TryParse(splitOption[1], out shortName)) // получилось преобразовать имя в символ
                    {
                        Option option = FindOptionByShortName(shortName); // ищем опцию в списке опций

                        if (option == null) // не нашли
                            // throw new Exception($"Option {args[i]} not found!");
                            PrintErrorAndExit($"Option {args[i]} not found!");

                        if (option.ArgumentType != null && i + 1 <= args.Length) // Если у опции есть аргументы
                        {
                            // if (i + 1 >= args.Length) throw new Exception($"Option \"{option.Name}\" must have a {option.ArgumentType} argument!");
                            if (i + 1 >= args.Length) PrintErrorAndExit($"Option \"{option.Name}\" must have a {option.ArgumentType} argument!");
                            string optionArg = args[++i];
                        
                            if (TypeDescriptor.GetConverter(option.ArgumentType).IsValid(optionArg)) // Если аргумент можно привести к нужному типу
                                option.TargetMethod.DynamicInvoke(Convert.ChangeType(optionArg, option.ArgumentType));
                            else
                            {
                                // throw new Exception($"Invalid {option.Name} option argument: {optionArg}! Must be a {option.ArgumentType}");
                                PrintErrorAndExit($"Invalid {option.Name} option argument: {optionArg}! Must be a {option.ArgumentType}");
                            }
                        }
                        else
                        {
                            option.TargetMethod.DynamicInvoke();
                        }
                    } // TODO: случай где -us
                    else
                    {
                        // throw new Exception($"Unrecognized option: {args[i]}");
                        PrintErrorAndExit($"Unrecognized option: {args[i]}");
                    }
                    
                }
                
                else if (splitOption.Length == 3) // Если два минуса --
                {
                    Option option = FindOptionByName(splitOption[2]);

                    if (option == null)
                        // throw new Exception($"Option {args[i]} not found!");
                        PrintErrorAndExit($"Option {args[i]} not found!");

                    if (option.ArgumentType != null) // Если у опции есть аргументы
                    {
                        // if (i + 1 >= args.Length) throw new Exception($"Option \"{option.Name}\" must have a {option.ArgumentType} argument!");
                        if (i + 1 >= args.Length) PrintErrorAndExit($"Option \"{option.Name}\" must have a {option.ArgumentType} argument!");
                        string optionArg = args[++i];

                        if (TypeDescriptor.GetConverter(option.ArgumentType)
                            .IsValid(optionArg)) // Если аргумент можно привести к нужному типу
                            option.TargetMethod.DynamicInvoke(Convert.ChangeType(optionArg, option.ArgumentType));
                        else
                        {
                            // throw new Exception( $"Invalid {option.Name} option argument: {optionArg}! Must be a {option.ArgumentType}");
                            PrintErrorAndExit( $"Invalid {option.Name} option argument: {optionArg}! Must be a {option.ArgumentType}");
                        }
                    }
                    else
                    {
                        option.TargetMethod.DynamicInvoke();
                    }
                }

                else
                {
                    // throw new Exception($"Invalid option: {args[i]}");
                    PrintErrorAndExit($"Invalid option: {args[i]}");
                }
            }

            // Проверяет адекватность введённых параметров
            if (DigitCount + LetterCount > WordLength)
            {
                PrintErrorAndExit("Length must be greater or equals Digits + Letters!");
            }
            else if (DigitCount + LetterCount == WordLength && UseSpecial)
            {
                PrintWarning("There is no place for special symbols. Digits + Letters = Length!");
            }
			
			if (WordLength == default && (DigitCount != default || LetterCount != default))
			{
				WordLength = DigitCount + LetterCount;
                PrintWarning($"Length will be {WordLength} ({DigitCount} + {LetterCount})");
			}
            else
            {
                WordLength = 16;
            }
            
            SymbolType[] word = new SymbolType[WordLength];

            // Заполняет список случайными типами символов
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = (SymbolType)rand.Next(1, 5);
            }
            


            // Test Zone

            for (int i = 0; i < WordLength; i++)
            {
                pwd += GenSymbol(rand.Next(1, 5));
            }
            
            Console.WriteLine(pwd);
            //Console.ReadLine();
            
        }

        static void SetUppercase()
        {
            UseUppercase = true;
            AllowedTypes.Add(3);
            Console.WriteLine("аперкейс");
        }
        static void SetSpecial()
        {
            UseSpecial = true;
            AllowedTypes.Add(4);
            Console.WriteLine("спещиал");
        }
        static void SetLength(int len)
        {
            WordLength = len;
            Console.WriteLine($"длина - {len}");
        }
        static void SetDigitsCount(int count)
        {
            DigitCount = count;
            Console.WriteLine($"колво цифр - {count}");
        }
        static void SetLettersCount(int count)
        {
            LetterCount = count;
            Console.WriteLine($"колво букв - {count}");
        }
        
        
        
        static char GenSymbol(int type)
        {
            string[] symbols =
            {
                "",
                "0123456789",
                "abcdefghijklmnopqrstuvwxyz",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "!\"#$%&'()*+,-./:;<=>?@[]\\^_`{|}~"
            };
            
            return symbols[type][rand.Next(symbols[type].Length)];
        }
        static char GenSymbol(string type)
        {
            int typeId;
            switch (type)
            {
                case "digit": case "d": typeId = 1; break;
                case "lower": case "l": typeId = 2; break;
                case "upper": case "u": typeId = 3; break; 
                case "special": case "s": typeId = 4; break; 
                default: PrintErrorAndExit($"Invalid Symbol Type: {type}"); typeId = 0; break;
            }

            return GenSymbol(typeId);
        }
        static char GenSymbol(SymbolType type)
        {
            return GenSymbol((int)type);
        }

        
        
        static Option FindOptionByName(string name)
        {
            foreach (var argument in AllowedOptions)
            {
                if (argument.Name == name) return argument;
            }

            return null;
        }
        static Option FindOptionByShortName(char shortName)
        {
            foreach (var argument in AllowedOptions)
            {
                if (argument.Shortname == shortName) return argument;
            }

            return null;
        }
        
        
        
        static int[] GetNullIndexes(SymbolType[] arr)
        {
            List<int> nulles = new List<int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    nulles.Add(i);
                }
            }

            return nulles.ToArray();
        }
        
        
        
        static int GetRandomIntFromList(List<int> list)
        {
            return list[rand.Next(0, list.Count)];
        }
        static int GetRandomIntFromList(List<int> list, int minIndex, int maxIndex)
        {
            // MAX IS NOT INCLUDED!!!
            return list[rand.Next(minIndex, maxIndex)];
        }

        
        
        static void PrintErrorAndExit(string message)
        {
            Console.WriteLine(message);
            Environment.Exit(1);
        }
        static void PrintWarning(string message)
        {
            Console.WriteLine("Warning! " + message);
        }
    }
}