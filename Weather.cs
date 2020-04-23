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
            if (condition == weatherConditions[4])
            {
                temperature = random.Next(90, 100);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            else if (condition == weatherConditions[2])
            {
                temperature = random.Next(80, 89);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            else if (condition == weatherConditions[0])
            {
                temperature = random.Next(70, 79);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            else if (condition == weatherConditions[1])
            {
                temperature = random.Next(60, 69);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            else if (condition == weatherConditions[3])
            {
                temperature = random.Next(50, 59);
                Console.WriteLine("Temp: " + temperature + "°F");
            }
            
        }

    }
}
