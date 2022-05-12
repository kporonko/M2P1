using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Store.Models
{
    /// <summary>
    /// The singleton pattern logic in a class of shopping busket.
    /// </summary>
    public sealed class ShoppingBusket
    {
        private static ShoppingBusket instance = null;

        private ShoppingBusket()
        {
        }

        public static ShoppingBusket Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShoppingBusket();
                }

                return instance;
            }
        }

        /// <summary>
        /// Gets current products in the shopping busket.
        /// </summary>
        /// <value>
        /// Array of products which user fills later.
        /// </value>
        public Product[] Products { get; } = new Product[5];
    }
}
