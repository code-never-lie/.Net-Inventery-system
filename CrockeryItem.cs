using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2_SCD_W1_S2019065007
{
    class CrockeryItem: Item
    {
        private double _discountRate;

        public double DiscountRate
        {
            get { return _discountRate; }
            set { _discountRate = value; }
        }

        public CrockeryItem(double discount)
        {
            this.DiscountRate = discount;
        }
        public CrockeryItem(int id, string desc, double price, double discount) : base(desc, id, price)
        {
            this.DiscountRate = discount;
        }
        public override double CalculatePrice()
        {
            return this.Price = this.Price - (this.Price * this.DiscountRate) / 100;

        }
        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of item: " + this.Id);
            Console.WriteLine("Descrption of item: " + this.Desc);
            Console.WriteLine("Price of item: " + this.Price);
            Console.WriteLine("Dicount Rate: " + this.DiscountRate);
            Console.WriteLine("--------------------------------------------");
        }



    }
}
