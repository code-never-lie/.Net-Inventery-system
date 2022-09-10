using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2_SCD_W1_S2019065007
{
    class Cosmetics: Item
    {
        private bool _isWaterproof;

        public Cosmetics(bool isWaterproof)
        {
            _isWaterproof = isWaterproof;
        }

        public Cosmetics(int id, string desc, double price, bool isWaterproof) : base(desc, id, price)
        {

            _isWaterproof = isWaterproof;
        }

        public bool IsWaterproof { get => _isWaterproof; set => _isWaterproof = value; }

        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of item: " + this.Id);
            Console.WriteLine("Descrption of item: " + this.Desc);
            Console.WriteLine("Price of item: " + this.Price);
            Console.WriteLine("Is makeup is waterproof: " + this.IsWaterproof);
            Console.WriteLine("--------------------------------------------");
        }



    }
}
