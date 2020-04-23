using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Proj
{
    class Recipe
    {
        //member variables
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;
        //constructor
        public Recipe()
        {
            pricePerCup = .25;
            amountOfLemons = 4;
            amountOfSugarCubes = 4;
            amountOfIceCubes = 2;
        }
        //member methods
        public void AdjustLemons(Player player)
        {
            int lemonsPurchased = UserInterface.AdjustRecipe("lemons");
            double itemsLeft = CalculateItemsUsed(lemonsPurchased, amountOfLemons);
            Console.WriteLine(itemsLeft);
        
        }
        public void AdjustIceCubes(Player player)
        {
            int iceCubesPurchased = UserInterface.AdjustRecipe("ice cube");
        }
        public void AdjustSugarCubes(Player player)
        {
            int sugarCubesPurchased = UserInterface.AdjustRecipe("sugar cube");
        }
        public void AdjustPricePerCup(Player player)
        {

        }
        private double CalculateItemsUsed(int itemCount, int itemUsed)
        {
            int itemsLeft = itemCount - itemUsed;
            return itemsLeft;
        }
    }
}
