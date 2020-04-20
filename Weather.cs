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
        public int temperature;
        public List<string> weatherConditions;
        public string condition;
        //constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Hazy", "Rainy", "Windy" };
        }
        //member methods
        public void ConditionOfWeather()
        {
            Random r = new Random();
            int weatherCondition = r.Next(weatherConditions.Count);

                condition = weatherConditions[weatherCondition];
                Console.WriteLine(condition);
            
            Console.ReadLine();
        }
        public void WeatherTemperature()
        {

        }
    }
}
