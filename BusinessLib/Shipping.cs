using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public class Shipping
    {
        private int _id;
        private string _name;
        private int _price;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public Shipping() { }

        public Shipping(int id, string name, int price) 
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Shipping(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
