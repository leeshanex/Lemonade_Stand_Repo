using System;

namespace Lemonade_Stand_Proj
{
    class UserInterface
    {

        public UserInterface()
        {
            DisplayRules();
            StoreMenu();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to the Lemonade Stand Game!! ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Rules: Your goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("~> Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.");
            Console.WriteLine("~> Start with the basic recipe, but try to vary the recipe and see if you can do better.");
            Console.WriteLine("~> Lastly, set your price and sell you lemonade at the stand.");
            Console.WriteLine("~> Try changing the price based on the weather conditions as well.");
            Console.WriteLine("~> At the end of the game, you'll see how much money you made.");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }
            public void StoreMenu()
        {
            Console.WriteLine(" ____________________________");
            Console.WriteLine("|_________Store_Menu_________|");
            Console.WriteLine("|Cup = $0.25 each            |");
            Console.WriteLine("|Lemons = $0.50 each         |");
            Console.WriteLine("|Sugar = $0.10 per sugar cube|");
            Console.WriteLine("|Ice = $0.01 per ice cube    |");
            Console.WriteLine("|____________________________|");
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
    }
}
