using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public class Order
    {
        private string _adress;
        private int _price;
        private string _date;

        public List<Product> Products = new List<Product>();
        public Seller seller = new Seller();
        public string Adress { get => _adress; set => _adress = value; }
        public int Price { get => _price; set => _price = value; }
        public string Date { get => _date; set => _date = value; }

        public Order()
        {

        }

        public Order(List<Product> products/*,Seller seller_*/,string adress,string date)
        {
            Products = products;
            //seller = seller_;
            Adress = adress;
            Price = 0;
            Date = date;
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            foreach (var item in Products)
            {
                Price += (item.Price * item.Amount);
            }
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}
