using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2_SCD_W1_S2019065007
{
    class ImportedItem : Item
    {
        private double _taxRate;

        public double TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }

        private void UpdatePrice()
        {
            this.Price = this.Price + (this.Price * this.TaxRate) / 100;

        }
        public ImportedItem(double taxRate)
        {
            this.TaxRate = taxRate;
        }
        public ImportedItem(int id, string desc, double price, double taxRate) : base(desc, id, price)
        {
            this.TaxRate = taxRate;
        }

        public override double CalculatePrice()
        {
            return this.Price = this.Price + (this.Price * this.TaxRate) / 100;

        }
        public override void Display()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("id of item: " + this.Id);
            Console.WriteLine("Descrption of item: " + this.Desc);
            Console.WriteLine("Price of item: " + this.Price);
            Console.WriteLine("Tax Rate: " + this.TaxRate);
            Console.WriteLine("--------------------------------------------");
        }


    }
}
