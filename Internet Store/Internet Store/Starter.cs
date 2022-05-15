using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internet_Store.Models;
using Internet_Store.Services;

namespace Internet_Store
{
    public class Starter
    {
        public static void Run()
        {
            var assortiment = AssortimentService.Instance;
            assortiment.FillTheAssortment();
            var consoleService = ConsoleService.Instance;
            consoleService.WriteAssortiment(AssortimentService.Assortment);
            var interaction = UserInteractionService.Instance;
            int[] prodId = interaction.ProductsChoice();
            var shoppingBusketService = ShoppingBusketService.Instance;
            var shoppingbusket = shoppingBusketService.CreateABusket();
            shoppingBusketService.AddInBusket(prodId, shoppingbusket);
            if (interaction.AskUser())
            {
                Order order = new Order(ShoppingBusket.Instance);
                var orderService = OrderService.Instance;
                orderService.FormOrder(order);
                consoleService.WriteOrder(order);
                Console.WriteLine();
            }
        }
    }
}
