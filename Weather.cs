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
        public void ConditionOfWeather()
        {
            Random r = new Random();
            int weatherCondition = r.Next(weatherConditions.Count);

            if (weatherCondition == 0)
            {
                Console.WriteLine(weatherCondition);
            }
            else if (weatherCondition == 1)
            {
                Console.WriteLine(weatherCondition);
            }
            else if (weatherCondition == 2)
            {
                Console.WriteLine(weatherCondition);
            }   
            else if (weatherCondition == 3)
            {
                Console.WriteLine(weatherCondition);
            }
            else if (weatherCondition == 4)
            {
                Console.WriteLine(weatherCondition);
            }
            Console.ReadLine();
        }
    }
}
