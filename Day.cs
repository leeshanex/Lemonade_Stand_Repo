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

    }
}
