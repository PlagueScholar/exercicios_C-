using System;


namespace Exercicio__ENUM___COMP_.Entities
{
    class Product
    {
        public Double Price { get; set; }
        public String Name { get; set; }

        public Product(double price, string name)
        {
            Price = price;
            Name = name;
        }
    }

}
