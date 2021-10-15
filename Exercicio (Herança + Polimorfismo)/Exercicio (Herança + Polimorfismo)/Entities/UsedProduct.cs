using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio__Herança___Polimorfismo_.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} (used) $ {Price} (Manufacture Date: {ManufactureDate})");

            return sb.ToString();
        }
    }
}
