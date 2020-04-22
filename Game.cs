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
        Day day;
        private Player player;
        private List<Day> days;
        private int currentDay;
        //constructor
        public Game()
        {
            weather = new Weather();
            store = new Store();
            day = new Day();
            player = new Player();
            days = new List<Day>();
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
        }
        public void RunGame()
        {
            DisplayRules();
            //day.DisplaySevenDayForecast();
            AddDaysToList();
            SendPlayerToStore();

           
        }
        public void StoreMenu()
        {
            Console.WriteLine();
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
            for (int i = 1; i < 8; i++)
            {
                days.Add(currentDay);
                Console.WriteLine();
            }
        }
    }
}
