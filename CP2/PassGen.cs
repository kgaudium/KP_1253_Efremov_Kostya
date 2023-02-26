using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PasswordGenerator
{
    public class PassGen
    {
        static Random rand;

        static int Seed = -1;
        static int WordLength;
        static int DigitCount;
        static int LetterCount;
        static bool UseUppercase;
        static bool UseSpecial;
        static bool Debug;

        static List<int> AllowedTypes = new List<int>() {1,2};  // список типов, которые нужно генерить

        static Option[] AllowedOptions;

        static string Password;
        // file, flags

        enum SymbolType : int
        {
          //   0      1      2      3        4
            Null, Digit, Lower, Upper, Special
        }

        static void Main(string[] args)
        {
            Option lenArg = new Option("length", 'L', typeof(int), SetLength);
            Option digitsArg = new Option("digits", typeof(int), SetDigitsCount);
            Option lettersArg = new Option("letters", typeof(int), SetLettersCount);
            Option upperArg = new Option("uppercase", 'u', SetUppercase);
            Option specialArg = new Option("special", 's', SetSpecial);
            Option seedArg = new Option("seed", typeof(int), SetSeed); // Добавил после создания парсера
            Option debugArg = new Option("debug", SetDebug); // Добавил после окончания всего скрипта

            AllowedOptions = new[] {lenArg, digitsArg, lettersArg, upperArg, specialArg, seedArg, debugArg }; // Список всех опций

            // Парсит аргументы
            OptionParser.ParseOptions(args, AllowedOptions, lenArg);
            

            // Проверяет адекватность введённых параметров
            if (DigitCount + LetterCount > WordLength && WordLength != default)
            {
                PrintErrorAndExit("Length must be greater or equals Digits + Letters!");
            }
            else if (DigitCount + LetterCount == WordLength && UseSpecial && (DigitCount != default || LetterCount != default))
            {
                PrintWarning("There is no place for special symbols. Digits + Letters = Length!");
            }
            
			if (WordLength == default && (DigitCount != default || LetterCount != default))
			{
				WordLength = DigitCount + LetterCount;
                PrintWarning($"Length will be {WordLength} ({DigitCount} + {LetterCount})");
			}
            else if (WordLength == default)
            {
                WordLength = 16;
            }
            
            // выбирает сид
            rand = Seed < 0 ? new Random() : new Random(Seed);

            // Инициализирует пустое слово
            SymbolType[] word = new SymbolType[WordLength];
            
            if (Debug) Console.Write("Initial (empty) array: ");
            if (Debug) PrintArray(word);
            
            // Заполняет список
            for (int _ = 0; _ < DigitCount; _++)
            {
                word[GetRandomIntFromArray(GetNullIndexes(word))] = SymbolType.Digit;
            }
            if (Debug) Console.Write("           Add digits: ");
            if (Debug) PrintArray(word);
            for (int _ = 0; _ < LetterCount; _++)
            {
                word[GetRandomIntFromArray(GetNullIndexes(word))] = (SymbolType)rand.Next(2,3+Convert.ToInt32(UseUppercase));
            }
            if (Debug) Console.Write("          Add letters: ");
            if (Debug) PrintArray(word);
            for (int _ = 0; _ < WordLength - DigitCount - LetterCount; _++)
            {
                word[GetRandomIntFromArray(GetNullIndexes(word))] = (SymbolType)GetRandomIntFromList(AllowedTypes);
            }
            if (Debug) Console.Write("          Final array: ");
            if (Debug) PrintArray(word);

            
            // Выбирает точные значения каждого символа и заисывает их в результирующую строку
            foreach (var symbol in word)
            {
                Password += GenSymbol(symbol);
            }
            
            if (Debug) Console.WriteLine($"Length: {WordLength}");
            Console.WriteLine($"Your Password: {Password}"); 
            //Console.ReadLine();
            
        }
        
        // можно было бы сделать флаги, которые показывают была ли опция уже запущена, но мне лень
        static void SetDebug()
        {
            Debug = true;
        }
        static void SetSeed(int seed)
        {
            Seed = seed;
            if (Debug) Console.WriteLine($"seed - {seed}");
        }
        static void SetUppercase()
        {
            UseUppercase = true;
            AllowedTypes.Add(3);
            if (Debug) Console.WriteLine("Use uppercase");
        }
        static void SetSpecial()
        {
            UseSpecial = true;
            AllowedTypes.Add(4);
            if (Debug) Console.WriteLine("Use special");
        }
        static void SetLength(int len)
        {
            WordLength = len;
            if (Debug) Console.WriteLine($"Length - {len}");
        }
        static void SetDigitsCount(int count)
        {
            DigitCount = count;
            AllowedTypes.Remove((int)SymbolType.Digit);
            if (Debug) Console.WriteLine($"Digit Count - {count}");
        }
        static void SetLettersCount(int count)
        {
            LetterCount = count;
            AllowedTypes.Remove((int)SymbolType.Lower);
            AllowedTypes.Remove((int)SymbolType.Upper);
            if (Debug) Console.WriteLine($"Letters Count - {count}");
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

        static int GetRandomIntFromArray(int[] arr)
        {
            return arr[rand.Next(0, arr.Length)];
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


        static void PrintArray(Array arr)
        {
            string res = "[";
            foreach (var el in arr)
            {
                res += $"{el}, ";
            }
            
            Console.WriteLine(res.Substring(0, res.Length-2) + "]");
        }
    }
}