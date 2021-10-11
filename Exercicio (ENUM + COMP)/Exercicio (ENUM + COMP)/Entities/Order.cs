using System;
using System.Collections.Generic;
using System.Text;
using Exercicio__ENUM___COMP_.Entities.Enums;

namespace Exercicio__ENUM___COMP_.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(){}

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item){
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total(){

            double sum = 0;
            foreach (OrderItem item in Items) {
                sum += item.subTotal();
                
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order Moment: {Moment}" );
            sb.AppendLine($"Order Status: {Status}");
            sb.AppendLine($"Client: {Client.Name} {Client.BirthDate} - {Client.Email }");
            sb.AppendLine("Order Itens:");
            foreach (OrderItem i in Items) {
                sb.AppendLine($"{i.Product.Name},Price: {i.Price}$ Quantity: {i.Quantity} Subtotal: {i.subTotal()}$");
            }
            sb.AppendLine($"Total: {Total()}");
            return sb.ToString();
        }

    }
}
