using System;
using System.Collections.Generic;


namespace CP
{
    public class PassGen
    {
        static Random rand = new Random();
        static int len = 16;
        static int digits;
        static bool useUpper = true;
        static bool useLower = true;
        static bool useSpecial = true;

        static string pwd;
        // file, flags

        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                switch (arg){
                    //case 
                }
            }


            for (int i = 0; i < len; i++)
            {
                pwd += GenSymbol(rand.Next(4));
            }
            
            Console.WriteLine(pwd);
            Console.ReadLine();
            
        }

        static char GenSymbol(int type)
        {
            string[] symbols =
            {
                "0123456789",
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "abcdefghijklmnopqrstuvwxyz",
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
    }
}