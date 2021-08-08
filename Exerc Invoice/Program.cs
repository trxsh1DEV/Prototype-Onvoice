using System;
using System.Globalization;
using Exerc_Invoice.Entities.Enums;
using Exerc_Invoice.Entities;
using System.Text;
using System.Collections.Generic;

namespace Exerc_Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime Birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Data: ");
            Console.WriteLine();
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Clients clients1 = new Clients(name, email, Birthdate);
            Order order = new Order (DateTime.Now, status,clients1);

            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nameItem = Console.ReadLine();
                Console.Write("Product price: ");
                double priceItem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Products products = new Products(nameItem, priceItem);
                Console.WriteLine("Quantity: ");
                int qtdeItem = int.Parse(Console.ReadLine());

                OrderItens orderItens = new OrderItens(qtdeItem, priceItem,products);

                order.AddNewItem(orderItens);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}
