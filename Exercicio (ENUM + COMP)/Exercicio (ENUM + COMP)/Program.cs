using System;
using Exercicio__ENUM___COMP_.Entities;
using Exercicio__ENUM___COMP_.Entities.Enums;

namespace Exercicio__ENUM___COMP_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Client Data");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("BirthDate:");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name,email,date);

            Console.WriteLine("Enter Order Data");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many itens:");
            int i = int.Parse(Console.ReadLine());

            Order order = new Order(status, client);

            for (int j = 0; j < i; j++) {
                
                Console.WriteLine($"Enter #{j} Data");
                Console.Write("Product Name:");
                string pName = Console.ReadLine();
                Console.Write("Product Price:");
                double pPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                
                Product product = new Product(pPrice, pName);
                OrderItem oItem = new OrderItem(quantity, pPrice, product);
                order.AddItem(oItem);
                
            }

            Console.WriteLine(order.ToString());


        }
    }
}
