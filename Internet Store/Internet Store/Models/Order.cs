using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Store.Models
{
    internal class Order
    {
        public Order(ShoppingBusket shoppingBusket)
        {
            Guid id = Guid.NewGuid();
            Id = Convert.ToInt32(id);
            Busket = shoppingBusket;
        }

        public ShoppingBusket Busket { get; }

        public int Id { get; }

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
