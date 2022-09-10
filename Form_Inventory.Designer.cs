
using System;

namespace Assign_2_SCD_W1_S2019065007
{
    partial class Form_Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inventory));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(107, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Item";
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(254, 133);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(319, 21);
            this.cb_item.TabIndex = 10;
          
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(254, 218);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(78, 20);
            this.txt_add.TabIndex = 24;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(390, 208);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(183, 30);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save_Item_Count";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Add_Item_Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(126, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Inventory Management System ";
            // 
            // Form_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.cb_item);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form_Inventory";
            this.Text = "Form_Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inv_closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.inv_closed);
            this.Load += new System.EventHandler(this.Form_Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}