using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public static class TicketPrice
    {
        
        public static void CheckTicketPrice()
        // This method checks the ticket price based on the user's age.
        {
            int age = Util.AskForInt("Ange din ålder: ");
            PriceEnum category = GetPriceCategory(age);
            if (category == PriceEnum.FreeOfCharge)
            {
                Console.WriteLine(GetTicketLabel(category));
            }else
            {
                Console.WriteLine($"{GetTicketLabel(category)}: {GetTicketPrice(category)} SEK");
            }
        }

        public static void CalculateGroupPrice()
        // This method calculates the total ticket price for a group of people based on their age.
        {
            int groupSize = Util.AskForInt("Ange antalet personer i gruppen: ");
            int totalPrice = 0;
            for (int i = 0; i < groupSize; i++)
            {
                int age = Util.AskForInt($"Ange åldern för person {i + 1}: ");
                PriceEnum category = GetPriceCategory(age);
                totalPrice += GetTicketPrice(category);
            }
            Console.WriteLine($"Totalt biljettpris för gruppen: {totalPrice} SEK");
        }

        public static int GetTicketPrice(PriceEnum category)
        // This method returns the ticket price based on the category.
        {
            return category switch {

                PriceEnum.Youth => 80,

                PriceEnum.Adult => 120,

                PriceEnum.Senior => 90,

                PriceEnum.FreeOfCharge => 0


            };
        }

        public static string GetTicketLabel(PriceEnum category)
        {
            return category switch {
                // This method returns the label for the ticket price based on the category.
                PriceEnum.Youth => "Ungdomspris",
                PriceEnum.Adult => "Standardpris",
                PriceEnum.Senior => "Pensionärspris",
                PriceEnum.FreeOfCharge => "Biljetten är gratis!",
            };
        }
        
        public static PriceEnum GetPriceCategory(int age)
        // This method determines the price category based on the age provided.
        {
            if (age < 20 && age > 4)
            {
                return PriceEnum.Youth;
            } else if (age >= 20 && age < 65)
            {
                return PriceEnum.Adult;
            } else if (age >= 65 && age < 100)
            {
                return PriceEnum.Senior;
            } else if (age < 5 || age > 100)
            {
                return PriceEnum.FreeOfCharge;
            }

            throw new ArgumentOutOfRangeException(nameof(age), "Ange en giltig ålder.");



        }
    }
}



