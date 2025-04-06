using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class MenuHelper
    // This class is used to show the menu and handle user input.
    {
        public string CheckTicket = "1";
        public string CalculateGroup = "2";
        public string Quit = "q";

        public static void ShowMenu()
        {
            Console.WriteLine("1. Kontrollera biljettpris.");
            Console.WriteLine("2. Beräkna biljettpris för en grupp.");
            Console.WriteLine("3. Upprepa en text 10 gånger.");
            Console.WriteLine("4. Plocka ut det 3:e ordet från en mening och skriv ut det.");
            Console.WriteLine("q. Avsluta.");
            Console.WriteLine();
            Console.Write("Välj ett alternativ: ");
        }

        public static bool HandleInput(string userInput)
        {
            switch (userInput)

            // The switch statement is used to handle the user's input and call the appropriate method.
            {
                case "1":
                    TicketPrice.CheckTicketPrice();
                    break;
                case "2":
                    TicketPrice.CalculateGroupPrice();
                    break;
                case "3":
                    Looper.LoopTenTimes();
                    break;
                case "4":
                    ThirdWordPlucker.PluckThirdWord();
                    break;
                case "q":
                    return false;
                default:
                    Console.WriteLine("Ogiltigt alternativ. Försök igen.");
                    break;

            }
            Console.WriteLine($"{Environment.NewLine}Tryck på en tangent för att fortsätta...");
            Console.WriteLine();
            Console.ReadKey(); // Wait for user input before clearing the console.
            Console.WriteLine();
            return true; // This return value indicates whether the program should continue running or not.

        }

    }
}
