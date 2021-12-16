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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            populate();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new ShippingForm().Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Проекты VS\2kurs\ЯП\Shop\ShopDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                DataBase.AddCategory(textBoxName.Text, textBoxDescription.Text);
                //con.Open();
                //string query = "insert into CategoryTbl values("+textBoxID.Text+",'"+textBoxName.Text+"','"+textBoxDescription.Text+"')";
                //SqlCommand cmd = new SqlCommand(query,con);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Category added.");
                //con.Close();
                populate();
                ClearTextboxes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewGategories.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridViewGategories_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yep");
            populate();
        }

        private void dataGridViewGategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewGategories.SelectedRows[0].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewGategories.SelectedRows[0].Cells[1].Value.ToString();
            textBoxDescription.Text = dataGridViewGategories.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxID.Text=="")
                {
                    MessageBox.Show("Select the category.");
                }
                else
                {
                    DataBase.DeleteCategory(Convert.ToInt32(textBoxID.Text));
                    //con.Open();
                    //string query = "delete from CategoryTbl where CategoryId="+textBoxID.Text+"";
                    //SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Category deleted.");
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBoxID.Text == "" || textBoxDescription.Text == "" || textBoxName.Text == "")
                {
                    MessageBox.Show("Missing information.");
                }
                else
                {
                    DataBase.EditCategory(Convert.ToInt32(textBoxID.Text), textBoxName.Text, textBoxDescription.Text);
                    //con.Open();
                    //string query = "update CategoryTbl set CategoryName='" + textBoxName.Text + "',CategoryDesc='" + textBoxDescription.Text + "' where CategoryId=" + textBoxID.Text + ";";
                    //SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Category edited.");
                    //con.Close();
                    populate();
                    ClearTextboxes();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelProducts_Click(object sender, EventArgs e)
        {
            new ProductForm().Show();
            this.Hide();
        }

        private void labelSellers_Click(object sender, EventArgs e)
        {
            new SellerForm().Show();
            this.Hide();
        }

        private void ClearTextboxes()
        {
            textBoxID.Text = textBoxDescription.Text = "";
        }
    }
}
