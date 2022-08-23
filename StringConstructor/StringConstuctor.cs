using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConstructor
{
    internal class StringConstuctor
    {
        static void Main(string[] args)
        {
            char[] characterArray = { 'b', 'i', 'r', 't', 'h', ' ', 'd', 'a', 'y'};
            var originalString = "Welcome to the Thunderdome, Bitch!";
            var string1 = originalString;
            var string2 = new string(characterArray);
            var string3 = new string(characterArray, 6, 3);
            var string4 = new string('C', 3);

            Console.WriteLine($"string1: \"{string1}\"\n" +
                $"string2: \"{string2}\"\n" +
                $"string3: \"{string3}\"\n" +
                $"string4: \"{string4}\"\n");
        }
    }
}
