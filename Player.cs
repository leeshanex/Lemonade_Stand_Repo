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
        

        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        //member methods (Can Do)
        public void PurchasingItems()
        {
            //inventory.AddCupsToInventory
        }
    }
}
