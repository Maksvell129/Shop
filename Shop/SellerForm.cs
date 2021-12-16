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
using DataLib;
using BusinessLib;

namespace Shop
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            populate();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Проекты VS\2kurs\ЯП\Shop\ShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewSellers.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridViewSellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewSellers.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewSellers.SelectedRows[0].Cells[1].Value.ToString();
            textBoxAge.Text = dataGridViewSellers.SelectedRows[0].Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewSellers.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPassword.Text = dataGridViewSellers.SelectedRows[0].Cells[4].Value.ToString();
            checkBoxIsAdmin.Checked= Convert.ToBoolean(dataGridViewSellers.SelectedRows[0].Cells[5].Value.ToString());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text == "")
                {
                    MessageBox.Show("Select the seller.");
                }
                else
                {
                    DataBase.DeleteUser(Convert.ToInt32(textBoxID.Text));
                    //con.Open();
                    //string query = "delete from SellerTbl where SellerId=" + textBoxID.Text + "";
                    //SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Seller deleted.");
                    //con.Close();
                    populate();
                    ClearTextboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Seller newSeller = new Seller(textBoxName.Text, Convert.ToInt32(textBoxAge.Text), textBoxPhone.Text, textBoxPassword.Text, checkBoxIsAdmin.Checked);
                DataBase.AddUser(newSeller);
                MessageBox.Show("Seller added.");
                populate();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    con.Open();
            //    string query = "insert into SellerTbl values(" + textBoxID.Text + ",'" + textBoxName.Text + "','" + textBoxAge.Text + "','" + textBoxPhone.Text + "','" + textBoxPassword.Text + "','" + checkBoxIsAdmin.Checked.ToString() + "')";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Seller added.");
            //    con.Close();
            //    populate();
            //    ClearTextboxes();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ClearTextboxes()
        {
            textBoxID.Text = textBoxAge.Text = textBoxName.Text = textBoxPassword.Text = textBoxPhone.Text = "";

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text == "" || textBoxAge.Text == "" || textBoxName.Text == "" || textBoxPhone.Text == "" || textBoxPassword.Text == "")
                {
                    MessageBox.Show("Missing information.");
                }
                else
                {
                    Seller seller = new Seller(Convert.ToInt32(textBoxID.Text),textBoxName.Text, Convert.ToInt32(textBoxAge.Text), textBoxPhone.Text, textBoxPassword.Text, checkBoxIsAdmin.Checked);
                    DataBase.EditUser(seller);
                    //con.Open();
                    //string query = "update SellerTbl set SellerName='" + textBoxName.Text + "',SellerAge='" + textBoxAge.Text + "',SellerPhone='" + textBoxPhone.Text + "',SellerPassword='" + textBoxPassword.Text + "',IsAdmin='" + checkBoxIsAdmin.Checked.ToString() + "' where SellerId=" + textBoxID.Text + ";";
                    //SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller edited.");
                    //con.Close();
                    populate();
                    ClearTextboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelSellers_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
            this.Hide();
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {
            new CategoryForm().Show();
            this.Hide();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void labelShipping_Click(object sender, EventArgs e)
        {
            new ShippingForm().Show();
            this.Hide();
        }
    }
}
