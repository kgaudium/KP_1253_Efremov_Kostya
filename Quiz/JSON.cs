using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Quiz;

public static class JSON
{
    private static char[] specSymbs = {'\\', '\"', '\b', '\f', '\n', '\r', '\t'};
    private static string[] jsonSpecSymbs = {"\\\\", "\\\"", "\\b", "\\f", "\\n", "\\r","\\t"};
    
    public static string Dump(object? obj)
    {
        if (obj == null) return "null";

        Type type = obj.GetType();
        

        // Если число
        if (obj.IsNumericType())
        {
            return Convert.ToDecimal(obj).ToString(CultureInfo.InvariantCulture);
            //return ((decimal)obj).ToString(CultureInfo.InvariantCulture);
        }

        // Если строка
        if (type == typeof(string))
        {
            string jsonStr = "\"";
            
            for (int i=0; i < ((string) obj).Length; i++)
            {
                char symbol = ((string) obj)[i];
                
                if (specSymbs.Contains(symbol))
                {
                    jsonStr += jsonSpecSymbs[Array.IndexOf(specSymbs, symbol)];
                }
                else
                {
                    jsonStr += ((string) obj)[i];
                }
            }

            return jsonStr + "\"";
        }

        // Если символ
        if (type == typeof(char)) 
        {
            return $"\"{obj}\"";
        }

        // Если булевое
        if (type == typeof(bool))
        {
            return (bool) obj ? "true" : "false";
        }

        // Если массив
        if (type.IsArray || type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
        {
            string jsonStr = "[";

            foreach (var _obj in (IEnumerable) obj)
            {
                jsonStr += $"{Dump(_obj)}, ";
            }

            return jsonStr.Substring(0, jsonStr.Length - 2) + "]";
        }

        // Если словарь
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<,>))
        {
            string jsonStr = "{\n";
            
            // ¯\_(ツ)_/¯
            // Dictionary<object, object> dict = new Dictionary<object, object> ((obj as IDictionary).Cast<object>().ToDictionary( x => x.GetType().GetProperty("Key").GetValue(x), x => x.GetType().GetProperty("Value").GetValue(x) ));

            // foreach (var item in dict)
            
            foreach (var item in (IDictionary)obj)
            {
                var key = ((DictionaryEntry) item).Key;
                var value = ((DictionaryEntry) item).Value;
                
                if (key is string)
                {
                    jsonStr += $"\t{Dump(key)}: {Dump(value)},\n";
                }
                else
                {
                    jsonStr += $"\t\"{Dump(key)}\": {Dump(value)},\n";
                }
            } 
            
            return jsonStr.Substring(0, jsonStr.Length - 2) + "\n}";
        }

        throw new Exception("Cannot convert this type to JSON");
    }

    /// ///////////////////////////////////////////////////

    public static object? Parse(string json)
    {
        int index = 0;

        return ParseValue(json, ref index);
    }

    private static object? ParseValue(string json, ref int index)
    {
        SkipWhiteSpace(json, ref index);

        char currentChar = json[index];

        switch (currentChar)
        {
            case '{':
                return ParseObject(json, ref index);
            case '[':
                return ParseArray(json, ref index);
            case '"':
                return ParseString(json, ref index);
            case 't' or 'f':
                return ParseBoolean(json, ref index);
            case 'n':
                return ParseNull(json, ref index);
            default:
                return ParseNumber(json, ref index);
        }
    }

    private static Dictionary<string, object> ParseObject(string json, ref int index)
    {
        Dictionary<string, object> dict = new Dictionary<string, object>();

        index++;

        while (true)
        {
            if (json[index] == '}')
            {
                index++;
                return dict;
            }
            
            SkipWhiteSpace(json, ref index);
            string key = ParseString(json, ref index);
            SkipWhiteSpace(json, ref index);

            if (json[index] != ':')
            {
                throw new Exception($"Invalid JSON: expected colon separator. {index}");
            }

            index++;
            SkipWhiteSpace(json, ref index);

            object value = ParseValue(json, ref index);
            
            dict.Add(key, value);
            
            SkipWhiteSpace(json, ref index);

            if (json[index] == ',')
            {
                index++;
            }
            else if (json[index] == '}')
            {
                index++;
                return dict;
            }
            else
            {
                throw new Exception($"Invalid JSON: expected comma separator or closing brace. {index}");
            }
        }
    }

    private static List<object> ParseArray(string json, ref int index)
    {
        List<object> list = new List<object>();

        index++;

        while (true)
        {
            SkipWhiteSpace(json, ref index);

            if (json[index] == ']')
            {
                index++;
                return list;
            }

            object value = ParseValue(json, ref index);
            list.Add(value);
            
            SkipWhiteSpace(json, ref index);

            if (json[index] == ',')
                index++;
            else if (json[index] == ']')
            {
                index++;
                return list;
            }
            else
            {
                throw new Exception($"Invalid JSON: incorrect array. {index}");
            }
            
        }
    }

    private static string ParseString(string json, ref int index)
    {
        index++;

        StringBuilder result = new StringBuilder();

        while (index < json.Length)
        {
            if (index >= json.Length) throw new Exception($"Invalid JSON: '\"' was never closed. {index}");

            char currentChar = json[index];

            if (currentChar == '\\')
            {
                index++;
                
                if (index >= json.Length) throw new Exception($"Invalid JSON: unterminated escape sequence. {index}");

                currentChar = json[index];

                switch (currentChar)
                {
                    case '\"':
                        result.Append('\"');
                        break;
                    case '\\':
                        result.Append('\\');
                        break;
                    case 'b':
                        result.Append('\b');
                        break;
                    case 'f':
                        result.Append('\f');
                        break;
                    case 'n':
                        result.Append('\n');
                        break;
                    case 'r':
                        result.Append('\r');
                        break;
                    case 't':
                        result.Append('\t');
                        break;
                    default:
                        throw new Exception($"Invalid JSON: invalid escape sequence. {index}");
                }

                //index++;
            }
            else if (currentChar == '\"')
            {
                index++;
                return result.ToString();
            }
            else
            {
                result.Append(currentChar);
            }

            index++;
        }
        
        throw new Exception("Invalid JSON: unterminated string.");
    }

    private static double ParseNumber(string json, ref int index)
    {
        int startIndex = index;

        if (json[index] == '-') index++;

        while (index < json.Length && char.IsDigit(json[index]))
        {
            index++;
        }

        if (index < json.Length && json[index] == '.')
        {
            index++;

            while (index < json.Length && char.IsDigit(json[index]))
            {
                index++;
            }
        }

        if (index < json.Length && (json[index] == 'e' || json[index] == 'E'))
        {
            index++;
            
            if (index < json.Length && (json[index] == '+' || json[index] == '-'))
            {
                index++;
            }

            while (index < json.Length && char.IsDigit(json[index]))
            {
                index++;
            }
        }

        return Double.Parse(json.Substring(startIndex, index - startIndex), System.Globalization.CultureInfo.InvariantCulture);
    }
    
    private static object? ParseNull(string json, ref int index)
    {
        if (index + 4 <= json.Length && json.Substring(index, 4) == "null")
        {
            index += 4;
            return null;
        }
        
        throw new Exception($"Invalid JSON. Expected 'null'. {index}");
    }

    private static bool ParseBoolean(string json, ref int index)
    {
        if (json[index] == 't')
        {
            if (index + 4 <= json.Length && json.Substring(index, 4) == "true")
            {
                index += 4;
                return true;
            }

            throw new Exception($"Invalid JSON. Expected 'true'. {index}");
        }

        if (json[index] == 'f')
        {
            if (index + 5 <= json.Length && json.Substring(index, 5) == "false")
            {
                index += 5;
                return false;
            }
            
            throw new Exception($"Invalid JSON. Expected 'false'. {index}");
        }

        throw new Exception($"Bruuuh bool {index}");
    }

    private static void SkipWhiteSpace(string json, ref int index)
    {
        while (index < json.Length && char.IsWhiteSpace(json[index]))
        {
            index++;
        }
    }
    
    public static bool IsNumericType(this object value)
    {   
        return value is decimal
               || value is double
               || value is float
               || value is int
               || value is uint
               || value is long
               || value is ulong
               || value is short
               || value is ushort
               || value is byte
               || value is sbyte;
    }
}