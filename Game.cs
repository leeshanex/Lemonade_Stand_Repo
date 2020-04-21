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
        UserInterface userInterface;
        private Player player;
        private List<Day> days;
        private int currentDay;
        //constructor
        public Game()
        {
            weather = new Weather();
            userInterface = new UserInterface();
        }

        //member methods
        public void RunGame()
        {
            //UserInterface.GetNumberOfItems(); cannot int string itemsToGet??<
            weather.ConditionOfWeather();
            weather.WeatherTemperature();

        }
    }
}
