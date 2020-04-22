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
        Random random;
        //constructor
        public Weather()
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Hazy", "Rainy", "Hot" };
            random = new Random();
            ConditionOfWeather();
            WeatherTemperature();
        
        }
        //member methods
        public void ConditionOfWeather()
        {
            int weatherCondition = random.Next(weatherConditions.Count);
            condition = weatherConditions[weatherCondition];
            Console.WriteLine("Condition: " + condition);
        }
        public void WeatherTemperature()
        {
            if (condition == "Hot")
            {
                temperature = random.Next(90, 100);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            else if (condition == "Hazy")
            {
                temperature = random.Next(80, 89);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            else if (condition == "Sunny")
            {
                temperature = random.Next(70, 79);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            else if (condition == "Cloudy")
            {
                temperature = random.Next(60, 69);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            else if (condition == "Rainy")
            {
                temperature = random.Next(50, 59);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            
        }

    }
}
