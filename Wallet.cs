﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Proj
{
    class Wallet
    {
        private double money;

        public double Money
        {
            get
            {
                return money;
            }
        }

        public Wallet()
        {
            money = 20.00;

        }

        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }
        public void SoldACup(double lemonadeSold)
        {
            money += lemonadeSold;
        }
        public void DisplayAmount()
        {
            Console.WriteLine("Money: $" + money);
        }
        public void DisplayAmountLeft()
        {
            Console.WriteLine("Money left: $" + money);
        }
    }
}
