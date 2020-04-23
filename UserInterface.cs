using System;

namespace Lemonade_Stand_Proj
{
    class UserInterface
    {

        public UserInterface()
        {

        }

        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
        public static int AdjustRecipe(string itemsPurchased)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;
            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("----------Recipe Adjustments----------");
                Console.WriteLine("How many " + itemsPurchased + " would you like to use?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");
                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }
            return quantityOfItem;
        }

        public static double AdjustPriceForCup(string cupsPurchased)
        {
            bool userInputIsADouble = false;
            double setPrice = -1;
            while (!userInputIsADouble || setPrice < 0)
            {
                Console.WriteLine("-----------Price Adjustments----------");
                Console.WriteLine("How much do you want to charge per " + cupsPurchased + " ?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");
                userInputIsADouble = double.TryParse(Console.ReadLine(), out setPrice);
            }
            return setPrice;
        }

        
    }
}

