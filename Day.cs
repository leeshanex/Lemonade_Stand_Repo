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
            customers = new List<Customer>();
        }
        //member methods
        public void CustomerChanceOfBuying()
        {
            Recipe recipe = new Recipe();
            Customer customer = new Customer();
            foreach (string name in customer.names)
            {
                if (name == customer.names[0])
                {

                    if (weather.condition == weather.weatherConditions[4] && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[2] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .75))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[0] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .65))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[1] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .55))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[3] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .35))
                    {
                        MadeSale();
                    }
                }
                else if (name == customer.names[1])
                {

                    if (weather.condition == weather.weatherConditions[4] && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[2] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .65))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[0] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .55))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[1] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .45))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[3] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .35))
                    {
                        MadeSale();
                    }
                }
                else if (name == customer.names[2])
                {

                    if (weather.condition == weather.weatherConditions[4] && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[2] && (recipe.pricePerCup > 0 && recipe.pricePerCup < 1))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[0] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .75))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[1] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .65))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[3] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .45))
                    {
                        MadeSale();
                    }
                }
                else if (name == customer.names[3])
                {

                    if (weather.condition == weather.weatherConditions[4] && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[2] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .40))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[0] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .35))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[1] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .30))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[3] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .25))
                    {
                        MadeSale();
                    }
                }
                else if (name == customer.names[4])
                {

                    if (weather.condition == weather.weatherConditions[4] && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[2] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .60))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[0] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .55))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[1] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .50))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[3] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .45))
                    {
                        MadeSale();
                    }
                }
                else if (name == customer.names[5])
                {

                    if (weather.condition == weather.weatherConditions[4] && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[2] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .25))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[0] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .45))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[1] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .60))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[3] && (recipe.pricePerCup > 0 && recipe.pricePerCup < 1))
                    {
                        MadeSale();
                    }
                }
                else if (name == customer.names[6])
                {

                    if (weather.condition == weather.weatherConditions[4] && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[2] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .60))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[0] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .25))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[1] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .50))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[3] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .15))
                    {
                        MadeSale();
                    }
                }
                else if (name == customer.names[7])
                {

                    if (weather.condition == weather.weatherConditions[4] && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[2] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .55))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[0] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .65))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[1] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .20))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == weather.weatherConditions[3] && (recipe.pricePerCup > 0 && recipe.pricePerCup < .10))
                    {
                        MadeSale();
                    }
                }
                else
                {
                    Console.WriteLine("No sales made");
                }
            }



        }
        public void MadeSale()
        {
            Inventory inventory = new Inventory();
            Wallet wallet = new Wallet();
            Recipe recipe = new Recipe();
            double lemonadeSold;
            lemonadeSold = inventory.cups.Count * recipe.pricePerCup;
            wallet.SoldACup(lemonadeSold);
            Console.WriteLine("You made $" + lemonadeSold);
        }

    }
}
