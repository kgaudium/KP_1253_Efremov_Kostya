using System;
using System.Collections.Generic;


namespace CP2
{
    public class PassGen
    {
        static Random rand = new Random();
        
        static int WordLength = 16;
        static int DigitCount;
        static int LetterCount;
        static bool UseUpper;
        static bool UseSpecial;

        static List<int> AllowedTypes;  // список типов, которые нужно генерить

        static Argument[] AllowedCommands;

        static string pwd;
        // file, flags

        enum SymbolType : int
        {
            Null, Digit, Lower, Upper, Special
        }

        static void Main(string[] args)
        {

            // Парсит аргументы (можно было бы делать сплит сразу по коммандам "--length", а потом по "="
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Substring(0, 2) == "--")
                {
                    string command = args[i].Substring(2, args[i].Length);

                    if (command.Split('=').Length == 1)
                    {
                        switch (command)
                        {
                            case "uppercase":
                                SwitchUppercase();
                                break;
                            
                            case "special":
                                SwitchSpecial();
                                break;
                            
                            case "length":
                                int len;
                                
                                if (!int.TryParse(args[++i], out len))
                                {
                                    throw new Exception($"Incorrect \"length\" command argument! Expected integer, got {args[++i]}!");
                                }
                                    
                                SetLength(len);
                                break;
                            
                            case "digits":
                                
                                break;
                            
                            default: break;
                            
                        }
                    }
                }
            }

            
            SymbolType[] word = new SymbolType[WordLength];

            // Заполняет список случайными типами символов
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = (SymbolType)rand.Next(1, 5);
            }
            


            // Test Zone
			
            Argument lenArg = new Argument("length", 'l', true, typeof(int), SetLength);
            for (int i = 0; i < WordLength; i++)
            {
                pwd += GenSymbol(rand.Next(4));
            }
            
            Console.WriteLine(pwd);
            Console.ReadLine();
            
        }

        static bool SwitchUppercase()
        {
            UseUpper = !UseUpper;
            return UseUpper;
        }
        static bool SwitchSpecial()
        {
            UseSpecial = !UseSpecial;
            return UseSpecial;
        }

        static void SetLength(int len)
        {
            WordLength = len;
        }
        
        static char GenSymbol(int type)
        {
            string[] symbols =
            {
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
                case "digit": case "d": typeId = 0; break;
                case "lower": case "l": typeId = 1; break;
                case "upper": case "u": typeId = 2; break; 
                case "special": case "s": typeId = 3; break; 
                default: throw new Exception($"Invalid Symbol Type: {type}");
            }

            return GenSymbol(typeId);
        }

        static char GenSymbol(SymbolType type)
        {
            return GenSymbol((int)type);
        }

        static int[] GetNullIndexes(SymbolType[] arr)
        {
            List<int> nulles = new List<int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    nulles.Add(i);
                }
            }

            return nulles.ToArray();
        }
        
        static int GetRandomIntFromList(List<int> list)
        {
            return list[rand.Next(0, list.Count-1)];
        }

        static int GetRandomIntFromList(List<int> list, int minIndex, int maxIndex)
        {
            return list[rand.Next(minIndex, maxIndex)];
        }
    }
}