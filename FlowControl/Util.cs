using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public static class Util
    {
        public static int AskForInt(string prompt)
        // This method asks the user for an integer input and validates it.
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result) && result >= 0)
                
                    return result;
                 else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
        public static string AskForString(string prompt)
        // This method asks the user for a string input and validates it.
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                } else
                {
                    Console.WriteLine("Please enter a valid text.");
                }
            }
            
        } 
    }
}
