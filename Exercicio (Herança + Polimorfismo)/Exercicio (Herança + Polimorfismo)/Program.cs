using Exercicio__Herança___Polimorfismo_.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio__Herança___Polimorfismo_
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> Produtos = new List<Product>();

            Console.WriteLine("Number of Products");
            int i = int.Parse(Console.ReadLine());

            for (int j = 1; j <= i; j++) {

                Console.WriteLine("Common used or imported? (c/u/i)");
                char c = char.Parse(Console.ReadLine());

                if (c == 'c') {
                    
                    Console.WriteLine("Product Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Product Price");
                    double price = double.Parse(Console.ReadLine());
                    Product product = new Product(name,price);
                    Produtos.Add(product);
                }
                else if (c == 'u')
                {

                    Console.WriteLine("Product Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Product Price");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Manufacture Date");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct usedProduct = new UsedProduct(name, price,date);
                    Produtos.Add(usedProduct);
                }
                else if (c == 'i')
                {
                    Console.WriteLine("Product Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Product Price");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Customs Fee");
                    double fee = double.Parse(Console.ReadLine());
                    ImportedProduct importedProduct = new ImportedProduct(name, price, fee);
                    Produtos.Add(importedProduct);
                }

            }

            foreach (Product produto in Produtos) {
                Console.WriteLine(produto.priceTag());
            }



        }
    }
}
