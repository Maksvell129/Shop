using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib
{
    public class Seller
    {
        private int _id;
        private string _name;
        private int _age;
        private string _phone;
        private string _password;
        private bool _IsAdmin;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Password { get => _password; set => _password = value; }
        public bool IsAdmin { get => _IsAdmin; set => _IsAdmin = value; }

        public Seller()
        {

        }

        public Seller(int id,string name,int age, string phone, string password,bool isAdmin)
        {
            Id = id;
            Name = name;
            Age = age;
            Phone = phone;
            Password = password;
            IsAdmin = isAdmin;
        }

        public Seller(string name, int age, string phone, string password, bool isAdmin)
        {
            Name = name;
            Age = age;
            Phone = phone;
            Password = password;
            IsAdmin = isAdmin;
        }

        public override string ToString()
        {
            return Convert.ToString(Id) + " " + Name + " " + Convert.ToString(Age) + " " + Phone + " " + Password+((IsAdmin==true)?"Admin":"Seller");
        }
    }
}
