using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Execicio_Udemy_Aula_133.Entites
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
        public Product()
        {

        }
        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
