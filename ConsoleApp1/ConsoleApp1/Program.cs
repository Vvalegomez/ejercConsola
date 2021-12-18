using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static string MinWindowSubstring(string[] strArr)
        {

            var n = strArr[0];
            var k = strArr[1];
            var palabras = new Dictionary<char, int>();

            foreach (var letra in k)
            {
                if (palabras.ContainsKey(letra))
                    palabras[letra] = palabras[letra] + 1;
                else
                    palabras[letra] = 1;
            }

            for (int i = k.Length; i <= n.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (j + i <= n.Length)
                    {
                        var subStr = n.Substring(j, i).ToCharArray();
                        if (palabras.Keys.All(key => subStr.Count(s => s == key) >= palabras[key]))
                        {
                            return new string(subStr);
                        }
                    }
                }
            }

            // code goes here  
            return "";

        
    }
        static void Main()
        {
            // keep this function call here
            Console.WriteLine(MinWindowSubstring(new string[] { "aaabaaddae", "aed"  }));
        }
    }

}
