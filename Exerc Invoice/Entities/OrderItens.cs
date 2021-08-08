using System;
using System.Globalization;

namespace Exerc_Invoice.Entities
{
    class OrderItens
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Products Product { get; set; }
        public OrderItens()
        {

        }

        public OrderItens(int quantity, double price, Products product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double TotalProduct()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + Quantity +
                ", Subtotal: $" + TotalProduct().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
