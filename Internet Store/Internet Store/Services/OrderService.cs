using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internet_Store.Models;

namespace Internet_Store.Services
{
    internal class OrderService
    {
        public void FormOrder(ShoppingBusket shoppingBusket)
        {
            Order order = new Order(shoppingBusket);
            Console.WriteLine("Order is formed");
        }

        public void WriteOrder(Order order)
        {
            Console.WriteLine($"Your order №{order.Id} :\n");
            for (int i = 0; i < order.Busket.Products.Length; i++)
            {
                Console.WriteLine($"1) {order.Busket.Products[i].Name} - {order.Busket.Products[i].Sum}$");
            }

            Console.WriteLine($"Overall price: {order.Sum}");
        }
    }
}
