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
    public partial class Login : Form
    {

         
        
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals("Ahmad") && txt_password.Text.Equals("123"))
            {
                
                Form_Inventory hf = new Form_Inventory();

                hf.Show(this);
                txt_name.Text = "";
                txt_password.Clear();
                txt_name.Focus();

            }
            else if(txt_name.Text.Equals("Shop") && txt_password.Text.Equals("123"))
            {

                item hv = new item();

                hv.Show(this);
                txt_name.Text = "";
                txt_password.Clear();
                txt_name.Focus();

            }
            else
            {

                MessageBox.Show("Invalid Login");
                txt_name.Text = "";
                txt_password.Clear();
                txt_name.Focus();

            }
        }

        private void login_closing(object sender, FormClosingEventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
