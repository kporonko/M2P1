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
        private static ShoppingBusketService instance = null;

        public ShoppingBusketService()
        {
        }

        public static ShoppingBusketService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShoppingBusketService();
                }

                return instance;
            }
        }

        public void CreateABusket(int[] prodId)
        {
            var busket = ShoppingBusket.Instance;
            AddInBusket(prodId, busket);
        }

        public void AddInBusket(int[] prodId, ShoppingBusket shoppingBusket)
        {
            for (int i = 0; i < prodId.Length; i++)
            {
                shoppingBusket.Products[i] = AssortimentService.Assortment[prodId[i]];
            }

            Console.WriteLine("\nProducts added to busket\n");
        }
    }
}
