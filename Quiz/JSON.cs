using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Quiz;

public class JSON
{
    public static string Dump(object? obj)
    {
        if (obj == null) return "null";

        Type type = obj.GetType();
        
        // Если число
        if (type == typeof(Int32) || type == typeof(Int16) || type == typeof(Int64) || type == typeof(Double) || type == typeof(Decimal) || type == typeof(float))
        {
            return obj.ToString();
        }

        // Если строка
        if (type == typeof(string))
        {
            char[] symbs = new[] {'\\', '\"', '\b', '\f', '\n', '\r', '\t'};
            string[] jsonSymbs = new[] {"\\\\", "\\\"", "\\b", "\\f", "\\n", "\\r","\\t"};

            string jsonStr = "\"";
            
            for (int i=0; i < ((string) obj).Length; i++)
            {
                char symbol = ((string) obj)[i];
                
                if (symbs.Contains(symbol))
                {
                    jsonStr += jsonSymbs[Array.IndexOf(symbs, symbol)];
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
        if (type.IsArray)
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
            Dictionary<object, object> dict = new Dictionary<object, object>
                ((obj as IDictionary)
                    .Cast<object>()
                    .ToDictionary(x => x.GetType().GetProperty("Key").GetValue(x), 
                        x => x.GetType().GetProperty("Value").GetValue(x)));
            
            foreach (var item in dict)
            {
                if (item.Key is string)
                {
                    jsonStr += $"{Dump(item.Key)}: {Dump(item.Value)},\n";
                }
                else
                {
                    jsonStr += $"\"{Dump(item.Key)}\": {Dump(item.Value)},\n";
                }
            } 
            
            return jsonStr.Substring(0, jsonStr.Length - 2) + "\n}";
        }

        throw new Exception("Privet");
    }
}