using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Proj
{
    class Day
    {
        //member variables
        public Weather weather;
        public List<Customer> customers;

        //constructor
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer> { };
        }
        //member methods
        //public void DisplaySevenDayForecast()
        //{
        //    Console.WriteLine("7-day Weather Forecast");

        //    for (int i = 1; i < 8; i++)
        //    {
        //        Console.WriteLine("Day " + i + ":");
        //        weather.ConditionOfWeather();
        //        weather.WeatherTemperature();
        //        Console.ReadLine();
        //    }
        //}
        //public void DisplayActualWeather()
        //{

        //}

    }
}
