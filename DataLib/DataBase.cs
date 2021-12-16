using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessLib;
using System.Windows.Forms;

namespace DataLib
{
    public class DataBase
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Проекты VS\2kurs\ЯП\Shop\ShopDb.mdf;Integrated Security=True;Connect Timeout=30");

        static public void AddUser(Seller seller)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SellerAdd",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SellerName", seller.Name);
                cmd.Parameters.AddWithValue("@SellerAge", seller.Age);
                cmd.Parameters.AddWithValue("@SellerPhone", seller.Phone);
                cmd.Parameters.AddWithValue("@SellerPassword", seller.Password);
                cmd.Parameters.AddWithValue("@IsAdmin", seller.IsAdmin);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void EditUser(Seller seller)
        {
            try
            {
                con.Open();
                string query = "update SellerTbl set SellerName='" + seller.Name + "',SellerAge='" + seller.Age.ToString() + "',SellerPhone='" + seller.Phone.ToString() + "',SellerPassword='" + seller.Password.ToString() + "',IsAdmin='" + seller.IsAdmin.ToString() + "' where SellerId=" + seller.Id.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller edited.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void DeleteUser(int Id)
        {
            try
            {
                con.Open();
                string query = "delete from SellerTbl where SellerId=" + Id.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller deleted.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        static public void AddProduct(Product product)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ProductAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", product.Name);
                cmd.Parameters.AddWithValue("@ProductAmount", product.Amount);
                cmd.Parameters.AddWithValue("@ProductPrice", product.Price);
                cmd.Parameters.AddWithValue("@Productcategory", product.Category);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void EditProduct(Product product)
        {
            try
            {
                con.Open();
                string query = "update ProductTbl set ProductName='" + product.Name + "',ProductAmount='" + product.Amount.ToString() + "',ProductPrice='" + product.Price.ToString() + "',ProductCategory='" + product.Category + "' where ProductId=" + product.Id.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product edited.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void DeleteProduct(int Id)
        {
            try
            {
                con.Open();
                string query = "delete from ProductTbl where ProductId=" + Id.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product deleted.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void AddCategory(string name, string desc)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("CategoryAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryName", name);
                cmd.Parameters.AddWithValue("@CategoryDesc", desc);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Category added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void EditCategory(int id, string name, string desc)
        {
            try
            {
                con.Open();
                string query = "update CategoryTbl set CategoryName='" + name + "',CategoryDesc='" + desc + "' where CategoryId=" + id.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product edited.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void DeleteCategory(int Id)
        {
            try
            {
                con.Open();
                string query = "delete from CategoryTbl where CategoryId=" + Id.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category deleted.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void AddShipping(Shipping shipping)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ShippingAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ShippingName", shipping.Name);
                cmd.Parameters.AddWithValue("@ShippingPrice", shipping.Price);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Shipping added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void EditShipping(Shipping shipping)
        {
            try
            {
                con.Open();
                string query = "update ShippingTbl set ShippingName='" + shipping.Name + "',ShippingPrice='" + shipping.Price.ToString() + "' where ShippingId=" + shipping.Id.ToString() + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Shipping edited.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void DeleteShipping(int Id)
        {
            try
            {
                con.Open();
                string query = "delete from ShippingTbl where ShippingId=" + Id.ToString() + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Shipping deleted.");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
