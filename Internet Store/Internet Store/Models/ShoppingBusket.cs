using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Store.Models
{
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

        public Product[] Products { get; } = new Product[5];
    }
}
