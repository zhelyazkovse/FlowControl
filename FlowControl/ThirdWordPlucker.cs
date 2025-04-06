using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class ThirdWordPlucker
    {
        public static void PluckThirdWord()
        // This method asks the user for a sentence and then prints the third word in that sentence.
        {
            var input = Util.AskForString("Skriv in en mening som är minst 3 ord lång." + Environment.NewLine);
            var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            if (words.Length >= 3)
            {
                Console.WriteLine($"Det tredje ordet är: {words[2]}" + Environment.NewLine);
            } else
            {
                Console.WriteLine("Meningen måste bestå av minst 3 ord." + Environment.NewLine);
            }
        }

    }
}