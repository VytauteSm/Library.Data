using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal static class Menu
    {
        internal static string GetUserMenuSelection()
        {
            while (true)
            {
                Console.WriteLine("1 - Add book [A]");
                Console.WriteLine("2 - Remove book [R]");
                Console.WriteLine("3 - Search book [S]");
                Console.WriteLine("4 - Exit [E]");

                Console.Write("Pick menu item: ");

                var input = Console.ReadLine();

                if (IsMenuSelectionValid(input))
                {
                    return input.ToUpper();
                }
                //    if(input.Equals("A", StringComparison.InvariantCultureIgnoreCase)
                //    || input.Equals("R", StringComparison.InvariantCultureIgnoreCase)
                //    || input.Equals("S", StringComparison.InvariantCultureIgnoreCase)
                //    || input.Equals("E", StringComparison.InvariantCultureIgnoreCase))
            }
        }
        private static bool IsMenuSelectionValid(string userInput)
        {
            var validMenuSelection = new string[] { "A", "R", "S", "E" };

            return validMenuSelection.Contains(userInput.ToUpper()); //if contains user input value, will get bool true
        }
    }
}
