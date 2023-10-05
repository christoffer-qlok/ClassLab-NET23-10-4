using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab
{
    internal static class MyHelpers
    {
        private static string _prettyAddon;

        static MyHelpers()
        {
            Console.WriteLine("Ran MyHelpers constructor!");
            _prettyAddon = "~*~*~";
        }

        public static void PrettyPrint(string text)
        {
            Console.WriteLine($"{_prettyAddon} {text} {_prettyAddon}");
        }
    }
}
