using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Delegates_05.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name + ", U$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
