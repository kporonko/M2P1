using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Store.Services
{
    internal sealed class UserInteractionService
    {
        private static UserInteractionService instance = null;

        private UserInteractionService()
        {
        }

        public static UserInteractionService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserInteractionService();
                }

                return instance;
            }
        }

        public int[] ProductsChoice()
        {
            int[] prodId = new int[5];
            Console.WriteLine("Choose 5 products (id)");
            int temp = -1;
            for (int i = 0; i < prodId.Length; i++)
            {
                while (temp < 1 || temp > 10)
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                    if (temp < 1 || temp > 10)
                    {
                        Console.WriteLine("Try again");
                    }
                }

                prodId[i] = temp - 1;
                temp = -1;
            }

            return prodId;
        }

        public bool AskUser()
        {
            Console.WriteLine("Do you want to form an order ? Yes/no");
            if (Console.ReadLine().ToLower() == "yes")
            {
                return true;
            }

            Console.WriteLine("\nGoodbye");
            return false;
        }
    }
}
