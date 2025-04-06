using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class Looper
    {
        public static void LoopTenTimes()
        // This method asks the user for a string and then prints it 10 times in a row.
        {
            string input = Util.AskForString("Skriv in en text och se den multipliceras med 10!" + Environment.NewLine + "Go: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}. {input} ");
                
            }
            Console.WriteLine();
        }
    }
}
