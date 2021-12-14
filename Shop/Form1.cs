using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLib;

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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Проекты VS\2kurs\ЯП\Shop\ShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from SellerTbl where SellerName='"+textBoxUsername.Text+"' and SellerPassword = '"+textBoxPassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                Seller newSeller = new Seller(Convert.ToInt32(Convert.ToString(dtbl.Rows[0]["SellerId"])),
                    Convert.ToString(dtbl.Rows[0]["SellerName"]),
                    Convert.ToInt32(Convert.ToString(dtbl.Rows[0]["SellerAge"])),
                    Convert.ToString(dtbl.Rows[0]["SellerPhone"]),
                    Convert.ToString(dtbl.Rows[0]["SellerPassword"]),
                    Convert.ToBoolean(Convert.ToString(dtbl.Rows[0]["IsAdmin"])));
                con.Close();

                if(newSeller.IsAdmin==true)
                {
                    new ProductForm().Show();
                    this.Hide();
                }
                else
                {
                    new SellingForm(newSeller).Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }























            //if(textBoxPassword.Text==""|| textBoxUsername.Text=="")
            //{
            //    MessageBox.Show("Enter data.");
            //}
            //else
            //{
            //    if (comboBoxSelectRole.SelectedIndex > -1)
            //    {
            //        if (comboBoxSelectRole.SelectedItem.ToString() == "ADMIN")
            //        {
            //            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            //            {
            //                new ProductForm().Show();
            //                this.Hide();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Enter correct data for admin.");
            //            }
            //        }
            //        else if (comboBoxSelectRole.SelectedItem.ToString() == "SELLER")
            //        {
            //            //MessageBox.Show("You are seller");
            //            new SellingForm().Show();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Select a role");
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
