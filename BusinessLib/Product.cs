using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public class Product
    {
        private int _id;
        private string _name;
        private int _amount;
        private int _price;
        private string _category;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public int Price { get => _price; set => _price = value; }
        public string Category { get => _category; set => _category = value; }
       
        public Product()
        {

        }

        public Product(string name,int amount, int price, string category)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Category = category;
        }

        public Product(int id, string name, int amount, int price)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Price = price;
        }

        public Product(int id, string name, int amount, int price, string category)
        {
            Id = id;
            Name = name;
            Amount = amount;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return "№ " + Convert.ToString(Id) + " " + Name + " * " + Convert.ToString(Amount) + " with cost " + Convert.ToString(Price)/* + " " + Category*/;
        }
    }
}
