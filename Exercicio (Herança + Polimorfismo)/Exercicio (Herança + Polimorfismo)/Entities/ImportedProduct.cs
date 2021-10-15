using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio__Herança___Polimorfismo_.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name,price)
        {
            Name = name;
            Price = price;
            CustomFee = customFee;
        }

        public double totalPrice() {
            return Price + CustomFee;
        
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} $ {totalPrice()} (Customs fee: ${CustomFee})");

            return sb.ToString();
        }

    }
}
