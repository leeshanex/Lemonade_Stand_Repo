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

        //constructor
        public Game()
        {
            weather = new Weather();
            userInterface = new UserInterface;
        }

        //member methods
        public void RunGame()
        {
            
            weather.ConditionOfWeather();
            weather.WeatherTemperature();

        }
    }
}
