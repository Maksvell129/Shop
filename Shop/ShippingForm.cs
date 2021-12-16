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
    public partial class ShippingForm : Form
    {
        public ShippingForm()
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
            string query = "select * from ShippingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewShipping.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ClearTextboxes()
        {
            textBoxID.Text = textBoxName.Text = textBoxPrice.Text = "";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Shipping newShipping = new Shipping(textBoxName.Text, Convert.ToInt32(textBoxPrice.Text));
                DataBase.AddShipping(newShipping);
                populate();
                ClearTextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text == ""  || textBoxName.Text == "" || textBoxPrice.Text == "" )
                {
                    MessageBox.Show("Missing information.");
                }
                else
                {
                    Shipping shipping = new Shipping(Convert.ToInt32(textBoxID.Text) ,textBoxName.Text, Convert.ToInt32(textBoxPrice.Text));
                    DataBase.EditShipping(shipping);
                    populate();
                    ClearTextboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text == "")
                {
                    MessageBox.Show("Select the shipping.");
                }
                else
                {
                    DataBase.DeleteShipping(Convert.ToInt32(textBoxID.Text));
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

        private void labelProducts_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
            this.Hide();
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {
            new CategoryForm().Show();
            this.Hide();

        }

        private void dataGridViewShipping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewShipping.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewShipping.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridViewShipping.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
