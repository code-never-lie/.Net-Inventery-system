﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2_SCD_W1_S2019065007
{
    class FoodItem : Item
    {
        private string _expDate;

        public string ExpDate
        {
            get { return _expDate; }
            set { _expDate = value; }
        }
        public FoodItem(string expDate)
        {
            this.ExpDate = expDate;
        }

        public FoodItem(int id, string desc, double price, string expDate) : base(desc, id, price)
        {
            this.ExpDate = expDate;
        }
        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of item: " + this.Id);
            Console.WriteLine("Descrption of item: " + this.Desc);
            Console.WriteLine("Price of item: " + this.Price);
            Console.WriteLine("Expire date of item: " + this.ExpDate);
            Console.WriteLine("--------------------------------------------");
        }


    }
}
