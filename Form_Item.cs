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
    public partial class item : Form
    {
        List<Item> items = new List<Item>();
        Inventory inv = new Inventory();
        int countid = 0;
        public item()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Item_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void item_closing(object sender, FormClosingEventArgs e)
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

        private void item_closed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btn_additem_Click(object sender, EventArgs e)
        {


            if (rb_crockery.Checked)
            {
                Item i1 = new CrockeryItem(countid++, txt_name.Text, Double.Parse(txt_price.Text), Double.Parse(txt_discount.Text));
                items.Add(i1);

                string[] row = { (countid).ToString(), txt_name.Text, (txt_price.Text), "", txt_discount.Text, "", "", "" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                inv.Countofcrockeryitem = inv.Countofcrockeryitem - 1;

            }
            else if (rb_cosmetics.Checked)
            {

                Item i1 = new Cosmetics(countid++, txt_name.Text, Double.Parse(txt_price.Text), Convert.ToBoolean((txt_water.Text)));
                items.Add(i1);

                string[] row = { (countid).ToString(), txt_name.Text, (txt_price.Text), "", "", "", "", txt_water.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                inv.Countofcosmetics = inv.Countofcosmetics - 1;
            }
            else if (rb_fabrics.Checked)
            {

                Item i1 = new Fabrics(countid++, txt_name.Text, Double.Parse(txt_price.Text), Convert.ToInt32((txt_size.Text)));
                items.Add(i1);

                string[] row = { (countid).ToString(), txt_name.Text, (txt_price.Text), "", "", "", txt_size.Text, "" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                inv.Countoffabrics = inv.Countoffabrics - 1;
            }
            
            else if (rb_food.Checked)
            {

                Item i1 = new FoodItem(countid++, txt_name.Text, Double.Parse(txt_price.Text), txt_expirey.Text);
                items.Add(i1);

                string[] row = { (countid).ToString(), txt_name.Text, (txt_price.Text), "", "", txt_expirey.Text, "", "" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                inv.Countoffooditem = inv.Countoffooditem - 1;
            }
            else if (rb_imported.Checked)
            {

                Item i1 = new ImportedItem(countid++, txt_name.Text, Double.Parse(txt_price.Text), Double.Parse(txt_tax.Text));
                items.Add(i1);

                string[] row = { (countid).ToString(), txt_name.Text, (txt_price.Text), txt_tax.Text, "", "", "", "" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                inv.Countofimporteditem = inv.Countofimporteditem - 1;
            }

            txt_discount.Clear();
            txt_expirey.Clear();
            txt_name.Clear();
            txt_price.Clear();
            txt_size.Clear();
            txt_tax.Clear();
            txt_water.Clear();
            txt_count.Clear();
            txt_name.Focus();

        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            Double t_price = 0;
            foreach (Item aPart in items)
            {

                
                t_price = t_price + aPart.CalculatePrice();
            }


            txt_total.Text = (t_price).ToString();

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
            Item r1 = null;
            foreach (Item aPart in items)
            {
                if (aPart.Id == Convert.ToInt32(txt_removeid.Text))
                {
                    r1 = aPart;
                }


            }

            items.Remove(r1);
            txt_removeid.Clear();

        }

        private void btn_show_Click(object sender, EventArgs e)
        {

            if (rb_crockery.Checked)
            {
                txt_count.Text = (inv.Countofcrockeryitem).ToString();

            }
            else if (rb_cosmetics.Checked)
            {

                txt_count.Text = (inv.Countofcosmetics).ToString();
            }
            else if (rb_fabrics.Checked)
            {
                txt_count.Text = (inv.Countoffabrics).ToString();

            }
            else if (rb_food.Checked)
            {
                txt_count.Text = (inv.Countoffooditem).ToString();

            }
            
            else if (rb_imported.Checked)
            {
                txt_count.Text = (inv.Countofimporteditem).ToString();

            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
