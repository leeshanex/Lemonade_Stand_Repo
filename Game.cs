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
        public UserInterface userInterface;
        //constructor
        public Game()
        {
            store = new Store();
            player = new Player();
            days = new List<Day>();
            userInterface = new UserInterface();
            numberOfDays = 7;
            currentDay = days.Count + 1;
        }

        //member methods
        public void RunGame()
        {
            //while() loop for each new day until day 7 and calculate profit/loss for each day
            while (days.Count < 7)
            {
                //CountTheDaysOf();
                AddDaysToList();
                
                SendPlayerToStore();
            }
           
            Console.ReadLine();
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
            Console.WriteLine("Day: " + currentDay + " of " + numberOfDays);
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
