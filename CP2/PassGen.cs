using System;
using System.Collections.Generic;


namespace CP2
{
    public class PassGen
    {
        static Random rand = new Random();
        
        static int WordLength;
        static int DigitCount;
        static int LetterCount;
        static bool UseUppercase;
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
            Argument lenArg = new Argument("length", typeof(int), SetLength);
            Argument digitsArg = new Argument("digits", typeof(int), SetLength); // 
            Argument lettersArg = new Argument("letters", typeof(int), SetLength); //
            Argument upperArg = new Argument("uppercase", 'u', typeof(int), SetUppercase);
            Argument specialArg = new Argument("special", 's', typeof(int), SetSpecial);

            AllowedCommands = new[] {lenArg, digitsArg, lettersArg, upperArg, specialArg };
            
            // Парсит аргументы (можно было бы делать сплит сразу по коммандам "--length", а потом по "="
            // for (int i = 0; i < args.Length; i++)
            // {
            //     if (args[i].Substring(0, 2) == "--")
            //     {
            //         string command = args[i].Substring(2, args[i].Length);
            //
            //         if (command.Split('=').Length == 1)
            //         {
            //             switch (command)
            //             {
            //                 case "uppercase":
            //                     SetUppercase();
            //                     break;
            //                 
            //                 case "special":
            //                     SetSpecial();
            //                     break;
            //                 
            //                 case "length":
            //                     int len;
            //                     
            //                     if (!int.TryParse(args[++i], out len))
            //                     {
            //                         throw new Exception($"Incorrect \"length\" command argument! Expected integer, got {args[++i]}!");
            //                     }
            //                         
            //                     SetLength(len);
            //                     break;
            //                 
            //                 case "digits":
            //                     
            //                     break;
            //                 
            //                 default: break;
            //                 
            //             }
            //         }
            //     }
            // }

            
            SymbolType[] word = new SymbolType[WordLength];

            // Заполняет список случайными типами символов
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = (SymbolType)rand.Next(1, 5);
            }
            


            // Test Zone
			
            
            for (int i = 0; i < WordLength; i++)
            {
                pwd += GenSymbol(rand.Next(4));
            }
            
            Console.WriteLine(pwd);
            Console.ReadLine();
            
        }

        static void SetUppercase()
        {
            UseUppercase = true;
        }
        static void SetSpecial()
        {
            UseSpecial = true;
        }

        static void SetLength(int len)
        {
            WordLength = len;
        }
        
        static void SetDigitsCount(int count)
        {
            DigitCount = count;
        }

        static void SetLettersCount(int count)
        {
            LetterCount = count;
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