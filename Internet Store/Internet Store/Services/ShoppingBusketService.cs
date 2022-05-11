using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internet_Store.Models;

namespace Internet_Store.Services
{
    internal class ShoppingBusketService
    {
        public static void CreateABusket(int[] prodId)
        {
            var busket = ShoppingBusket.Instance;
            AddInBusket(prodId, busket);
        }

        public static void AddInBusket(int[] prodId, ShoppingBusket shoppingBusket)
        {
            for (int i = 0; i < prodId.Length; i++)
            {
                shoppingBusket.Products[i] = Starter.Assortment[prodId[i]];
            }

            Console.WriteLine("Products added");
        }
    }
}
