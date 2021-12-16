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
using DataLib;

namespace Shop
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked == true)
            {
                textBoxConfirmPassword.PasswordChar = textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxConfirmPassword.PasswordChar = textBoxPassword.PasswordChar = '*';
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Проекты VS\2kurs\ЯП\Shop\ShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAdmin = false;
                Seller newSeller = new Seller(textBoxName.Text, Convert.ToInt32(textBoxAge.Text), textBoxPhone.Text, textBoxPassword.Text, isAdmin);
                DataBase.AddUser(newSeller);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Registration completed successfully");
            this.Close();
            //try
            //{
            //    con.Open();
            //    string query = "insert into SellerTbl (SellerName,SellerAge,SellerPhone,SellerPassword,IsAdmin) values(" /*+ textBoxID.Text + ",'"*/ + textBoxName.Text + ",'" + textBoxAge.Text + "','" + textBoxPhone.Text + "','" + textBoxPassword.Text + "','" + isAdmin.ToString() + "')";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Seller added.");
            //    con.Close();                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        }
}
