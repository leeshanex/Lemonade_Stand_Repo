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
            CustomerChanceOfBuying();
        }

        //member methods (Can Do)
        public void CustomerChanceOfBuying()
        {
            Customer customer = new Customer();
            foreach (string name in customer.names)
            {
                if (name == customer.names[0])
                {

                    if (weather.condition == "Hot" && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == "Hazy" && (recipe.pricePerCup > 0 && recipe.pricePerCup < .75))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == "Sunny" && (recipe.pricePerCup > 0 && recipe.pricePerCup < .65))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == "Cloudy" && (recipe.pricePerCup > 0 && recipe.pricePerCup < .55))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == "Rainy" && (recipe.pricePerCup > 0 && recipe.pricePerCup < .35))
                    {
                        MadeSale();
                    }
                }
                else if (name == customer.names[1])
                {

                    if (weather.condition == "Hot" && recipe.pricePerCup > 0)
                    {
                        MadeSale();
                    }
                    else if (weather.condition == "Hazy" && (recipe.pricePerCup > 0 && recipe.pricePerCup < .75))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == "Sunny" && (recipe.pricePerCup > 0 && recipe.pricePerCup < .65))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == "Cloudy" && (recipe.pricePerCup > 0 && recipe.pricePerCup < .55))
                    {
                        MadeSale();
                    }
                    else if (weather.condition == "Rainy" && (recipe.pricePerCup > 0 && recipe.pricePerCup < .35))
                    {
                        MadeSale();
                    }
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
