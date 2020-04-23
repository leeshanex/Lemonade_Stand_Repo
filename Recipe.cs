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
        //public void AdjustLemons(Player player)
        //{
        //    int lemonsPurchased;
        //    lemonsPurchased = player.inventory.lemons.Count;
        //    int amountOfLemons = UserInterface.AdjustRecipe("lemons");
        //    double itemsLeft = CalculateItemsUsed(lemonsPurchased, amountOfLemons);
        //    Console.WriteLine("Lemons left: " + itemsLeft);

        //}
        //public void AdjustIceCubes(Player player)
        //{
        //    int iceCubesPurchased;
        //    iceCubesPurchased = player.inventory.iceCubes.Count;
        //    int amountOfIce = UserInterface.AdjustRecipe("ice cube");
        //    double itemsLeft = CalculateItemsUsed(iceCubesPurchased, amountOfIce);
        //    Console.WriteLine("Ice cubes left: " + itemsLeft);
        //}
        //public void AdjustSugarCubes(Player player)
        //{
        //    int sugarCubesPurchased;
        //    sugarCubesPurchased = player.inventory.sugarCubes.Count;
        //    int amountOfSugarCubes = UserInterface.AdjustRecipe("sugar cube");
        //    double itemsLeft = CalculateItemsUsed(sugarCubesPurchased, amountOfSugarCubes);
        //    Console.WriteLine("Sugar cubes left: " + itemsLeft);
        //}
        //public void AdjustPricePerCup()
        //{
        //    double userInput = UserInterface.AdjustPriceForCup("cups");
        //    double pricePerCup = SetPricePerCup(userInput);
        //    Console.WriteLine("Price per cup set to " + pricePerCup + " each");

        //}
        //private double CalculateItemsUsed(int itemCount, int itemUsed)
        //{
        //    int itemsLeft = itemCount - itemUsed;
        //    return itemsLeft;
        //}
        //private double SetPricePerCup(double setPrice)
        //{
        //    double pricePerCup = setPrice;
        //    return pricePerCup;
        //}
    }
}
