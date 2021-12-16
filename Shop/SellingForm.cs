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
    public partial class SellingForm : Form
    {
        Order order = new Order();
        Seller seller = new Seller();
        Shipping shipping = new Shipping();

        public SellingForm(Seller _seller)
        {
            seller = _seller;
            InitializeComponent();
            FillCombo();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            labelDate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            order.Date = labelDate.Text;
            labelUsername.Text = seller.Name;
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Проекты VS\2kurs\ЯП\Shop\ShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            con.Open();
            string query = "select ProductName,ProductPrice from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridViewProducts.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPrice.Text = dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
        }

        int n = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            int totalProductPrice = Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxAmount.Text);
            order.Price += totalProductPrice;
            if (textBoxName.Text == "" || textBoxAmount.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                n += 1;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewOrder);
                newRow.Cells[0].Value = n;
                newRow.Cells[1].Value = textBoxName.Text;
                newRow.Cells[2].Value = textBoxPrice.Text;
                newRow.Cells[3].Value = textBoxAmount.Text;
                newRow.Cells[4].Value = totalProductPrice;
                dataGridViewOrder.Rows.Add(newRow);
                labelProductsPrice.Text= "Products price: " + order.Price;
                labelTotalPrice.Text = "Total price: " + Convert.ToString(order.Price+shipping.Price);
                Product buf = new Product(n, textBoxName.Text, Convert.ToInt32(textBoxAmount.Text), Convert.ToInt32(textBoxPrice.Text));
                order.Add(buf);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int startPosX = 20;
            int startPosY = 100;
            int interval = 30;
            int i = 0;
            e.Graphics.DrawString("YOUR ORDER", new Font("Century Gothic",25,FontStyle.Bold),Brushes.Red,new Point(230, 10));
            foreach (var item in order.Products)
            {
                e.Graphics.DrawString(item.ToString(), new Font("Century Gothic", 14, FontStyle.Bold), Brushes.Red, new Point(startPosX, startPosY + interval * i));
                i++;
            }
            e.Graphics.DrawString("Shipping Adress: " + shipping.Name, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Green, new Point(startPosX, startPosY + interval * i));
            e.Graphics.DrawString("Shiping price: " + shipping.Price, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Green, new Point(startPosX, startPosY + interval * (i+1)));
            e.Graphics.DrawString("Products price: " + order.Price, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Green, new Point(startPosX, startPosY + interval * (i + 2)));
            e.Graphics.DrawString("Total price: "+ Convert.ToString(order.Price + shipping.Price), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Green, new Point(startPosX, startPosY + interval * (i+3)));
            e.Graphics.DrawString(order.Date, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Green, new Point(startPosX, startPosY + interval * (i+4)));

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FillCombo()
        {
            con.Open();
            string query = "select ShippingName from ShippingTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ShippingName", typeof(string));
            dt.Load(rdr);
            comboBoxSelectShipping.ValueMember = "shippingName";
            comboBoxSelectShipping.DataSource = dt;
            con.Close();
        }

        private void comboBoxSelectShipping_SelectedIndexChanged(object sender, EventArgs e)
        {
            shipping.Name = comboBoxSelectShipping.SelectedValue.ToString();
            SetShippingPrice();
        }

        private void SetShippingPrice()
        {
            try
            {
                //con.Open();
                string shippingName = shipping.Name;
                string query = "select ShippingPrice from ShippingTbl where ShippingName=@shippingName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@shippingName", shippingName);
                string shippingPrice = cmd.ExecuteScalar()?.ToString();
                labelShippingPrice.Text = ("Shipping Price: "+ shippingPrice);
                shipping.Price = Convert.ToInt32(shippingPrice);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
