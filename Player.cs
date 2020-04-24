using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Proj
{
    class Player
    {
        //member variables (Has A)
        public Inventory inventory;
        public Wallet wallet;
        public string name;
        public Recipe recipe;
        public Pitcher pitcher;
        public Weather weather;
       
        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            weather = new Weather();
        }

        //member methods (Can Do)
        public void CustomerChanceOfBuying()
        {
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
            double lemonadeSold;
            lemonadeSold = inventory.cups.Count * recipe.pricePerCup;
            wallet.SoldACup(lemonadeSold);
            Console.WriteLine("You made $" + lemonadeSold);
        }
    }
}
