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

        //constructor
        public Game()
        {
            weather = new Weather();
        }

        //member methods
        public void RunGame()
        {

            weather.ConditionOfWeather();
            weather.WeatherTemperature();

        }
    }
}
