using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internet_Store.Models;

namespace Internet_Store.Services
{
    /// <summary>
    /// The singleton pattern logic in a class of order service.
    /// </summary>
    internal class OrderService
    {
        private static OrderService instance = null;

        private OrderService()
        {
        }

        public static OrderService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderService();
                }

                return instance;
            }
        }

        /// <summary>
        /// Method that forms an order and writes it to the console.
        /// </summary>
        /// <param name="order">Order we need to form.</param>
        public void FormOrder(Order order)
        {
            var consoleService = ConsoleService.Instance;
            consoleService.OrderFormedMessage();
        }
    }
}
