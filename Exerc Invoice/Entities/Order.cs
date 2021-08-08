using System;
using System.Collections.Generic;
using System.Text;
using Exerc_Invoice.Entities.Enums;
using Exerc_Invoice.Entities;
using System.Globalization;

namespace Exerc_Invoice.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }
        public Clients Clients { get; set; }
        public List<OrderItens> OrderItem { get; set; } = new List<OrderItens>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Clients clients1)
        {
            Moment = moment;
            Status = status;
            Clients = Clients;
        }
        public void AddNewItem(OrderItens Orderitem)
        {
            OrderItem.Add(Orderitem);
        }
        public void RemoveItem(OrderItens Orderitem)
        {
            OrderItem.Remove(Orderitem);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItens items in OrderItem)
            {
                sum += items.TotalProduct();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Clients);
            sb.AppendLine("Order Items: ");
            foreach (OrderItens itens in OrderItem)
            {
                sb.AppendLine(itens.ToString());
            }
            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
