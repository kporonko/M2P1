using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internet_Store.Services;
using Internet_Store.Models;

namespace Internet_Store.Services
{
    internal sealed class ConsoleService
    {
        private static ConsoleService instance = null;

        private ConsoleService()
        {
        }

        public static ConsoleService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConsoleService();
                }

                return instance;
            }
        }

        /// <summary>
        /// Method that writes assortiment on the console.
        /// </summary>
        /// <param name="assortment">Assortment of the store.</param>
        public void WriteAssortiment(Product[] assortment)
        {
            Console.WriteLine("Our assortiment:\n");
            for (int i = 0; i < assortment.Length; i++)
            {
                Console.WriteLine($"{assortment[i].Id}) {assortment[i].Name} - {assortment[i].Sum}$");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Method that writes an order to the console.
        /// </summary>
        /// <param name="order">Order we need to write to the console.</param>
        public void WriteOrder(Order order)
        {
            Console.WriteLine($"Your order №{order.Id} :\n");
            for (int i = 0; i < order.Busket.Products.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {order.Busket.Products[i].Name} - {order.Busket.Products[i].Sum}$");
            }

            Console.WriteLine($"\nOverall price: {order.Sum}\n");
        }

        public void OrderFormedMessage()
        {
            Console.WriteLine("\nOrder is formed\n");
        }

        public void ProductsAddedToBusketMesssage()
        {
            Console.WriteLine("\nProducts added to busket\n");
        }
    }
}
