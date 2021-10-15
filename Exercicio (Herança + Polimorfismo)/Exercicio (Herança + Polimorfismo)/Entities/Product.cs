using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio__Herança___Polimorfismo_.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        { 
        
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag() {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} $ {Price}");

            return sb.ToString();
        }
    
    }

}
