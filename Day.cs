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
        public string dayName;
        //constructor
        public Day(string dayName)
        {
            this.dayName = dayName;
            Console.WriteLine(dayName);
            weather = new Weather();
            customers = new List<Customer> { };
        }
        //member methods
    }
}
