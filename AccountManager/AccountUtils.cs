using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AccountManager;

public static class AccountUtils
{
    public static readonly Dictionary<char, string> TranslitDictionary = new Dictionary<char, string>()
    {
        {'а', "a"},
        {'б', "b"},
        {'в', "v"},
        {'г', "g"},
        {'д', "d"},
        {'е', "e"},
        {'ё', "yo"},
        {'ж', "zh"},
        {'з', "z"},
        {'и', "i"},
        {'й', "y"},
        {'к', "k"},
        {'л', "l"},
        {'м', "m"},
        {'н', "n"},
        {'о', "o"},
        {'п', "p"},
        {'р', "r"},
        {'с', "s"},
        {'т', "t"},
        {'у', "u"},
        {'ф', "f"},
        {'х', "kh"},
        {'ц', "ts"},
        {'ч', "ch"},
        {'ш', "sh"},
        {'щ', "sch"},
        {'ъ', "'"},
        {'ы', "y"},
        {'ь', "'"},
        {'э', "e"},
        {'ю', "yu"},
        {'я', "ya"},
        
        {'_', "_"},
        {'-', "-"},
        {'@', "@"},
    };
    
    public static string TransliterateRussian(string text)
    {
        return string.Join("", text.Select(x => TranslitDictionary[Char.ToLower(x)]));
    }
    
    public static string ToSHA256(this string value)
    {
        StringBuilder sb = new StringBuilder();

        using (var hash = SHA256.Create())            
        {
            Encoding enc = Encoding.UTF8;
            byte[] result = hash.ComputeHash(enc.GetBytes(value));

            foreach (byte b in result)
                sb.Append(b.ToString("x2"));
        }

        return sb.ToString();
    }
    
    public static bool IsRussianLetter(this char c)
    {
        return c is >= 'А' and <= 'я' or 'Ё' or 'ё';
    }
    public static bool IsAllowedLoginSymbol(this char c)
    {
        return c is >= 'A' and <= 'z' or '-' or '_' or '@';
    }
}