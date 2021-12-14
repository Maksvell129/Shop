using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelShop_Click(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text==""|| textBoxUsername.Text=="")
            {
                MessageBox.Show("Enter data.");
            }
            else
            {
                if (comboBoxSelectRole.SelectedIndex > -1)
                {
                    if (comboBoxSelectRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
                        {
                            new ProductForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Enter correct data for admin.");
                        }
                    }
                    else if (comboBoxSelectRole.SelectedItem.ToString() == "SELLER")
                    {
                        //MessageBox.Show("You are seller");
                        new SellingForm().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Select a role");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
