using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr7
{
    public class Product
    {

        private string _name;
        private double _price;


        public Product(string name, double price)
        {
            _name = name;
            Price = price;
        }


        public string Name
        {
            get { return _name; }
        }


        public double Price
        {
            get { return _price; }
            private set { _price = value; }
        }
    }
}
