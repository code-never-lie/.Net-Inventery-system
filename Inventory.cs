using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2_SCD_W1_S2019065007
{
    class Inventory
    {
        private int _countofcrockeryitem;
        private int _countofimporteditem;
        private int _countoffooditem;
        private int _countoffabrics;
        private int _countofcosmetics;

        public Inventory()
        {
            Countofcrockeryitem = 10;
            Countofimporteditem = 10;
            Countoffooditem = 10;
            Countoffabrics = 10;
            Countofcosmetics = 10;
        }

        public int Countofcrockeryitem { get => _countofcrockeryitem; set => _countofcrockeryitem = value; }
        public int Countofimporteditem { get => _countofimporteditem; set => _countofimporteditem = value; }
        public int Countoffooditem { get => _countoffooditem; set => _countoffooditem = value; }
        public int Countoffabrics { get => _countoffabrics; set => _countoffabrics = value; }
        public int Countofcosmetics { get => _countofcosmetics; set => _countofcosmetics = value; }



    }
}
