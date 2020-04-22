using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Proj
{
    class Game
    {
        //member variables
        Weather weather;
        Store store;
        //Day day;
        Wallet wallet;
        Inventory inventory;
        private Player player;
        private List<Day> days;
        private int currentDay;
        //constructor
        public Game()
        {
            weather = new Weather();
            store = new Store();
            //day = new Day();
            player = new Player();
            days = new List<Day>();
            wallet = new Wallet();
            inventory = new Inventory();
        }

        //member methods
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
        public void RunGame()
        {
            DisplayRules();
            StoreMenu();
            //while() loop for each new day until day 7 and then calculate profit/loss
            AddDaysToList();
            SendPlayerToStore();
            Console.ReadLine();



        }
        public void StoreMenu()
        {
            Console.WriteLine(" ____________________________");
            Console.WriteLine("|_________Store_Menu_________|");
            Console.WriteLine("|Lemons = $0.50 each         |");
            Console.WriteLine("|Sugar = $0.10 per sugar cube|");
            Console.WriteLine("|Ice = $0.01 per ice cube    |");
            Console.WriteLine("|Cup = $0.25 each            |");
            Console.WriteLine("|____________________________|");
        }
        public void SendPlayerToStore()
        {
            store.SellCups(player);
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
        }

        public void AddDaysToList()
        {
            //days.Add(new Day());
            Console.WriteLine();
            int numberOfDays = 7;
            for (int i = 1; i <= numberOfDays; i++)
            {
                Day day = new Day("Day " + i );
                days.Add(day);
                Console.WriteLine("Day: " + (i) + " of " + (numberOfDays));
                Console.ReadLine();
            }
        }
    }
}
