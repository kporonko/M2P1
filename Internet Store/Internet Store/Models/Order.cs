using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Store.Models
{
    internal class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// Constructor randomly receive id.
        /// </summary>
        /// <param name="shoppingBusket">Current shopping busket.</param>
        public Order(ShoppingBusket shoppingBusket)
        {
            Id = new Random().Next(0, 1000000);
            Busket = shoppingBusket;
        }

        /// <summary>
        /// Gets the current shopping busket. Property of class ShoppingBusket based on which order is being formed.
        /// </summary>
        /// <value>
        /// The current shopping busket.
        /// </value>
        public ShoppingBusket Busket { get; }

        public int Id { get; }

        /// <summary>
        /// Gets a sum of all the products in the order. Propetry sum without the 'set' accessor.
        /// </summary>
        /// <value>
        /// A sum of all the products in the order.
        /// </value>
        public double Sum
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < Busket.Products.Length; i++)
                {
                    sum += Busket.Products[i].Sum;
                }

                return sum;
            }
        }
    }
}
