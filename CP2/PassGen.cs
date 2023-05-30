using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PasswordGenerator
{
    public class PassGen
    {
        static Random rand;

        static int Seed;
        static int WordLength;
        static int DigitCount;
        static int LetterCount;
        static string FilePath;
        static bool UseUppercase;
        static bool UseLowercase;
        static bool UseSpecial;
        static bool Debug;

        static bool SeedIsSet;
        static bool LengthIsSet;
        static bool DigitsIsSet;
        static bool LettersIsSet;
        static bool FileIsSet;

        static List<SymbolType> AllowedTypes = new();  // список типов, которые нужно генерить

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
            Option digitsArg = new Option("digits", 'd', typeof(int), SetDigitsCount);
            Option lettersArg = new Option("letters", 'l', typeof(int), SetLettersCount);
            Option upperArg = new Option("uppercase", 'u', SetUppercase);
            Option lowerArg = new Option("lowercase", 'o', SetLowercase);
            Option specialArg = new Option("special", 's', SetSpecial);
            Option fileArg = new Option("file", 'f', typeof(string), SetFile);
            Option seedArg = new Option("seed", typeof(int), SetSeed); // Добавил после создания парсера
            Option debugArg = new Option("debug", SetDebug); // Добавил после окончания всего скрипта
            Option helpArg = new Option("help", 'h', ShowHelp); // Добавил после окончания всего скрипта

            AllowedOptions = new[] {lenArg, digitsArg, lettersArg, upperArg, lowerArg, specialArg, seedArg, debugArg, helpArg, fileArg }; // Список всех опций

            // Парсит аргументы
            OptionParser.ParseOptions(args, AllowedOptions, lenArg);
            
            // Формирует лист 
            if (UseSpecial) AllowedTypes.Add(SymbolType.Special);
            if (UseUppercase) AllowedTypes.Add(SymbolType.Upper);
            if (UseLowercase) AllowedTypes.Add(SymbolType.Lower);
            // if (LettersIsSet) {AllowedTypes.Remove(SymbolType.Lower); AllowedTypes.Remove(SymbolType.Upper);}

            if (AllowedTypes.Count == 0 && !LettersIsSet && !DigitsIsSet)
            {
                AllowedTypes.Add(SymbolType.Digit);
                AllowedTypes.Add(SymbolType.Lower);
            }
            
            if (!DigitsIsSet && !AllowedTypes.Contains(SymbolType.Digit)) AllowedTypes.Add(SymbolType.Digit);
            
            // Дебаг
            if (Debug) Console.WriteLine($"Allowed Types: {AllowedTypes.ToBeautyString()}");

            // Проверяет адекватность введённых параметров
            if (LengthIsSet && DigitCount + LetterCount > WordLength)
            {
                MyUtils.PrintAndExit("Length cannot be less than (Digits + Letters)!");
            }
            
            if (!LengthIsSet)
            {
                WordLength = 16;
            }
            
            if (DigitsIsSet || LettersIsSet)
            {
                if (DigitCount + LetterCount == WordLength && UseSpecial)
                {
                    MyUtils.PrintWarning("There is no place for special symbols. Digits + Letters = Length!");
                }

                if (!LengthIsSet)
                {
                    WordLength = DigitCount + LetterCount;
                    MyUtils.PrintWarning($"Length will be {WordLength} ({DigitCount} + {LetterCount})");
                }
            }
            
            if (UseUppercase && LettersIsSet)
                AllowedTypes.Remove(SymbolType.Upper);

            if (UseLowercase && LettersIsSet)
                AllowedTypes.Remove(SymbolType.Lower);
            
            if (LengthIsSet && LettersIsSet ^ DigitsIsSet && !UseSpecial && !UseUppercase && !UseLowercase && LetterCount + DigitCount < WordLength)
                MyUtils.PrintAndExit($"Cannot fill {WordLength - LetterCount - DigitCount} symbols. Use special symbols or set Digits + Letters = Length or remove Length option!");
            
            // выбирает сид
            rand = SeedIsSet ? new Random(Seed) : new Random();

            // Инициализирует пустое слово
            SymbolType[] word = new SymbolType[WordLength];

            if (Debug) Console.WriteLine($"Initial (empty) array: {word.ToBeautyString()}");
            
            // Заполняет список
            for (int _ = 0; _ < DigitCount; _++)
            {
                word[GetRandomIntFromArray(GetNullIndexes(word))] = SymbolType.Digit;
            }
            
            if (Debug) Console.WriteLine($"           Add digits: {word.ToBeautyString()}");
            
            for (int _ = 0; _ < LetterCount; _++)
            {
                word[GetRandomIntFromArray(GetNullIndexes(word))] = (SymbolType)rand.Next(2,3+Convert.ToInt32(UseUppercase));
            }
            
            if (Debug) Console.WriteLine($"          Add letters: {word.ToBeautyString()}");
            
            for (int _ = 0; _ < WordLength - DigitCount - LetterCount; _++)
            {
                word[GetRandomIntFromArray(GetNullIndexes(word))] = GetRandomFromList(AllowedTypes);
            }
            
            if (Debug) Console.WriteLine($"          Final array: {word.ToBeautyString()}");

            
            // Выбирает точные значения каждого символа и заисывает их в результирующую строку
            foreach (var symbol in word)
            {
                Password += GenSymbol(symbol);
            }
            
            if (Debug) Console.WriteLine($"Length: {WordLength}");
            
            if (FileIsSet)
            {
                File.WriteAllTextAsync(FilePath, Password, Encoding.Unicode);
                Console.WriteLine($"Your Password is written to {FilePath}.");
            }
            else
            {
                Console.WriteLine($"Your Password: {Password}"); 
            }
            //Console.ReadLine();
            
        }
        
        // можно было бы сделать флаги, которые показывают была ли опция уже запущена, но мне лень upd: не лень
        static void SetDebug()
        {
            Debug = true;
        }
        static void SetSeed(int seed)
        {
            Seed = seed;
            SeedIsSet = true;
            if (Debug) Console.WriteLine($"seed - {seed}");
        }
        static void SetUppercase()
        {
            UseUppercase = true;
            if (Debug) Console.WriteLine("Use uppercase");
        }
        static void SetLowercase()
        {
            UseLowercase = true;
            if (Debug) Console.WriteLine("Use lowercase");
        }
        static void SetSpecial()
        {
            UseSpecial = true;
            if (Debug) Console.WriteLine("Use special");
        }
        static void SetLength(int len)
        {
            WordLength = len;
            LengthIsSet = true;
            if (Debug) Console.WriteLine($"Length - {len}");
        }
        static void SetDigitsCount(int count)
        {
            DigitCount = count;
            DigitsIsSet = true;
            if (Debug) Console.WriteLine($"Digit Count - {count}");
        }
        static void SetLettersCount(int count)
        {
            LetterCount = count;
            LettersIsSet = true;
            if (Debug) Console.WriteLine($"Letters Count - {count}");
        }
        static void SetFile(string path)
        {
            FilePath = path;
            FileIsSet = true;
            if (Debug) Console.WriteLine($"File path is {path}");
        }

        static void ShowHelp()
        {
            MyUtils.PrintAndExit(@"
Password Generator by Gaudium

Options:
    --length|-L <arg>    Sets password length (default: 16)
    --digits|-d <arg>    Sets the exact number of digits (0 for random) (default: 0)
    --letters|-l <arg>   Sets the exact number of letters (both lowercase and uppercase if -u option is set) (0 for random) (default: 0)
    --uppercase|-u       Uses uppercase letters
    --lowercase|-o       Uses lowercase letters
    --special|-s         Uses special symbols (@, #, $ etc.)
    --file|-f <arg>      Sets path to write to the file
    --seed <arg>         Sets seed (default: random)
    --debug              Enable debug mode
    --help|-h            Shows this message

Options that have a short name and no arguments can be written as   -<opt1><opt2>...<optn> (Example: -us)
All options are optional

Usage:
    PassGen.exe
    >>> Your Password: m9q76j221t6j15o5

    PassGen.exe -L 20 -us -d 7
    >>> Your Password: l87k@1dm3DFq9s*4Me3J

    PassGen.exe --digits 7 --letters 3 --seed 1024 
    >>> Warning! Length will be 10 (7 + 3)
    >>> Your Password: 2t5i83880b

    PassGen.exe -d 5 --length 7 --letters 5
    >>> Length cannot be less than (Digits + Letters)!

    PassGen.exe -L 100 -us -f NoSecretsHere.txt
    >>> Your Password is written to NoSecretsHere.txt.
");
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
        
        
        
        static int GetRandomFromList(List<int> list)
        {
            return list[rand.Next(0, list.Count)];
        }
        static SymbolType GetRandomFromList(List<SymbolType> list)
        {
            return list[rand.Next(0, list.Count)];
        }
        static int GetRandomFromList(List<int> list, int minIndex, int maxIndex)
        {
            // MAX IS NOT INCLUDED!!!
            return list[rand.Next(minIndex, maxIndex)];
        }

        static int GetRandomIntFromArray(int[] arr)
        {
            return arr[rand.Next(0, arr.Length)];
        }
    }
}