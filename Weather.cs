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
        private List<string> weatherConditions;
        public string condition;
        //constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Hazy", "Rainy", "Hot" };
        }
        //member methods
        public void ConditionOfWeather()
        {
            Random r = new Random();
            int weatherCondition = r.Next(weatherConditions.Count);
            condition = weatherConditions[weatherCondition];
            Console.WriteLine(condition);
        }
        public void WeatherTemperature()
        {
            Random r = new Random();

            if (condition == "Hot")
            {
                temperature = r.Next(90, 100);
                Console.WriteLine(temperature + "°F");
            }
            else if (condition == "Hazy")
            {
                temperature = r.Next(80, 89);
                Console.WriteLine(temperature + "°F");
            }
            else if (condition == "Sunny")
            {
                temperature = r.Next(70, 79);
                Console.WriteLine(temperature + "°F");
            }
            else if (condition == "Cloudy")
            {
                temperature = r.Next(60, 69);
                Console.WriteLine(temperature + "°F");
            }
            else if (condition == "Rainy")
            {
                temperature = r.Next(50, 59);
                Console.WriteLine(temperature + "°F");
            }
            Console.ReadLine();
        }

    }
}
