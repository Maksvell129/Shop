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

        public SellingForm()
        {
            InitializeComponent();
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
                labelTotalPrice.Text = "Total price: " + order.Price;
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
            e.Graphics.DrawString("Total price: "+order.Price, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Green, new Point(startPosX, startPosY + interval * i));
            e.Graphics.DrawString(order.Date, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Green, new Point(startPosX, startPosY + interval * (i+1)));

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
