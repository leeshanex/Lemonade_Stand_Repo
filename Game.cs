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
        public Store store;
        private Player player;
        private List<Day> days;
        private int currentDay;
        int numberOfDays;
       
        //constructor
        public Game()
        {
            store = new Store();
            player = new Player();
            days = new List<Day>();
            
            //numberOfDays = 7;
            //currentDay = days.Count;
        }

        //member methods
        public void RunGame()
        {
            DisplayRules();
            StoreMenu();
            //while() loop for each new day until day 7 and calculate profit/loss for each day
            while (days.Count < 7)
            {
                //CountTheDaysOf();
                AddDaysToList();
                SendPlayerToStore();
            }
           
            Console.ReadLine();
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
            Console.WriteLine("|Cups = $0.25 each            |");
            Console.WriteLine("|Lemons = $0.50 each         |");
            Console.WriteLine("|Sugar = $0.10 per sugar cube|");
            Console.WriteLine("|Ice = $0.01 per ice cube    |");
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
            Day day = new Day();
                days.Add(day);
            
        }
        //public void CountTheDaysOf()
        //{
        //    int numberOfDays = 7;
        //    for (int i = currentDay + 1; i <= numberOfDays; i++)
        //    {
        //        if(currentDay < 7)
        //        {
        //            Console.WriteLine("Day: " + i + " of " + numberOfDays);
        //        }
        //    }
        //}
    }
}
