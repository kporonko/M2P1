﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internet_Store.Models;

namespace Internet_Store.Services
{
    /// <summary>
    /// The singleton pattern logic in a class of shopping busket service.
    /// </summary>
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

        /// <summary>
        /// Method that creates a busket and adds all the chosen products in it.
        /// </summary>
        /// <param name="prodId">Array of indexes of products.</param>
        public void CreateABusket(int[] prodId)
        {
            var busket = ShoppingBusket.Instance;
            AddInBusket(prodId, busket);
        }

        /// <summary>
        /// Method that adds the products to the busket.
        /// </summary>
        /// <param name="prodId">Array of indexes of products.</param>
        /// <param name="shoppingBusket">Currently chosen products in the busket.</param>
        private void AddInBusket(int[] prodId, ShoppingBusket shoppingBusket)
        {
            for (int i = 0; i < prodId.Length; i++)
            {
                shoppingBusket.Products[i] = AssortimentService.Assortment[prodId[i]];
            }

            Console.WriteLine("\nProducts added to busket\n");
        }
    }
}
