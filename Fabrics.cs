using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2_SCD_W1_S2019065007
{
    class Fabrics: Item
    {
        private int _Size;



        public int Size { get => _Size; set => _Size = value; }

        public Fabrics(int Size)
        {
            this.Size = Size;
        }
        public Fabrics(int id, string desc, double price, int Size) : base(desc, id, price)
        {
            this.Size = Size;
        }

        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of item: " + this.Id);
            Console.WriteLine("Descrption of item: " + this.Desc);
            Console.WriteLine("Price of item: " + this.Price);
            Console.WriteLine("Size of fabrics: " + this.Size);
            Console.WriteLine("--------------------------------------------");
        }


    }
}
