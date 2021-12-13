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

namespace Shop
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Проекты VS\2kurs\ЯП\Shop\ShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void FillCombo()
        {
            con.Open();
            string query = "select CategoryName from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Load(rdr);
            comboBoxSelectCategory.ValueMember = "categoryName";
            comboBoxSelectCategory.DataSource = dt;
            con.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillCombo();
            populate();
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {
            new CategoryForm().Show();
            this.Hide();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewProducts.DataSource = ds.Tables[0];
            con.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into ProductTbl values(" + textBoxID.Text + ",'" + textBoxName.Text + "','" + textBoxAmount.Text + "','" + textBoxPrice.Text + "','" + comboBoxSelectCategory.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added.");
                con.Close();
                populate();
                ClearTextboxes();
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
                    MessageBox.Show("Select the product.");
                }
                else
                {
                    con.Open();
                    string query = "delete from ProductTbl where ProductId=" + textBoxID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted.");
                    con.Close();
                    populate();
                    ClearTextboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
            textBoxAmount.Text = dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxSelectCategory.SelectedValue = dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text == "" || textBoxAmount.Text == "" || textBoxName.Text == "" || textBoxPrice.Text=="")
                {
                    MessageBox.Show("Missing information.");
                }
                else
                {
                    con.Open();
                    string query = "update ProductTbl set ProductName='" + textBoxName.Text + "',ProductAmount='" + textBoxAmount.Text + "',ProductPrice='" + textBoxPrice.Text + "',ProductCategory='" + comboBoxSelectCategory.SelectedValue.ToString() + "' where ProductId=" + textBoxID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product edited.");
                    con.Close();
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
            new SellerForm().Show();
            this.Hide();
        }

        private void labelSelling_Click(object sender, EventArgs e)
        {

        }

        private void ClearTextboxes()
        {
            textBoxID.Text = textBoxAmount.Text = textBoxName.Text = textBoxPrice.Text = "";

        }
    }
}
