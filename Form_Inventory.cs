using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign_2_SCD_W1_S2019065007
{
    public partial class Form_Inventory : Form
    {
        Inventory inv = new Inventory();
        public Form_Inventory()
        {
            InitializeComponent();
        }

        private void Form_Inventory_Load(object sender, EventArgs e)
        {

            cb_item.Items.Add("CrockeryItem");
            cb_item.Items.Add("ImportedItem");
            cb_item.Items.Add("FoodItem");
            cb_item.Items.Add("Fabrics");
            cb_item.Items.Add("Cosmetics");
            this.Owner.Hide();
        }

        private void inv_closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to close!!!", "Form is going to close", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
            else
            {

            }



        }


        private void inv_closed(object sender, FormClosedEventArgs e)
        {


            this.Owner.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (cb_item.Text == "CrockeryItem")
            {
                inv.Countofcrockeryitem = inv.Countofcrockeryitem + Convert.ToInt32(txt_add.Text);
                MessageBox.Show("Now Count of crockery item is  " + inv.Countofcrockeryitem,"Count of that Item");


            }
            else if (cb_item.Text == "ImportedItem")
            {
                inv.Countofimporteditem = inv.Countofimporteditem + Convert.ToInt32(txt_add.Text);
                MessageBox.Show("Now Count of imported item is  " + inv.Countofimporteditem, "Count of that Item");
            }
            else if (cb_item.Text == "FoodItem")
            {
                inv.Countoffooditem = inv.Countoffooditem + Convert.ToInt32(txt_add.Text);
                MessageBox.Show("Now Count of food item is  " + inv.Countoffooditem, "Count of that Item");

            }
            else if (cb_item.Text == "Fabrics")
            {
                inv.Countoffabrics = inv.Countoffabrics + Convert.ToInt32(txt_add.Text);
                MessageBox.Show("Now Count of fabrics is  " + inv.Countoffabrics, "Count of that Item");

            }
            else if (cb_item.Text == "Cosmetics")
            {
                inv.Countofcosmetics = inv.Countofcosmetics + Convert.ToInt32(txt_add.Text);
                MessageBox.Show("Now Count of cosmetics is  " + inv.Countofcosmetics, "Count of that Item");

            }


            txt_add.Clear();
            cb_item.Text = "";

        }
    }
}
