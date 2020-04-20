using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Proj
{
    class Weather
    {
        //member variables
        public double outsideTemps;
        public List<string> weatherConditions;
        //constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Hazy", "Rainy", "Windy" };
        }
        //member methods
        public void ConditionOfWeather(int weatherCondition)
        {
            Random r = new Random();
            weatherCondition = r.Next(weatherConditions.Count);

        }
    }
}
