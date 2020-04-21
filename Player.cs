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
        

        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        //member methods (Can Do)

    }
}
