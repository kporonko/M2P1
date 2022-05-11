using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internet_Store.Models;

namespace Internet_Store.Services
{
    internal sealed class AssortimentService
    {
        private static AssortimentService instance = null;
        private AssortimentService()
        {
        }

        public static AssortimentService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AssortimentService();
                }

                return instance;
            }
        }

        public static Product[] Assortment { get; set; } = new Product[10];

        /// <summary>
        /// Method that fills the assortment by 10 products.
        /// </summary>
        public void FillTheAssortment()
        {
            /*
            Product t_shirt = new Product(1, 550, "Gucci t-shirt");
            Product shirt = new Product(2, 1150, "Gucci shirt");
            Product belt = new Product(3, 150, "Gucci belt");
            Product swimwear = new Product(4, 350, "Gucci swimwear");
            Product sneakers = new Product(5, 2150, "Gucci sneakers");
            Product boots = new Product(6, 3150, "Gucci boots");
            Product bag = new Product(7, 650, "Gucci bag");
            Product polo = new Product(8, 1250, "Gucci polo");
            Product suit = new Product(9, 1850, "Gucci suit");
            Product hat = new Product(10, 250, "Gucci hat");
            */

            Assortment[0] = new Product(1, 550, "Gucci t-shirt");
            Assortment[1] = new Product(2, 1150, "Gucci shirt");
            Assortment[2] = new Product(3, 150, "Gucci belt");
            Assortment[3] = new Product(4, 350, "Gucci swimwear");
            Assortment[4] = new Product(5, 2150, "Gucci sneakers");
            Assortment[5] = new Product(6, 3150, "Gucci boots");
            Assortment[6] = new Product(7, 650, "Gucci bag");
            Assortment[7] = new Product(8, 1250, "Gucci polo");
            Assortment[8] = new Product(9, 1850, "Gucci suit");
            Assortment[9] = new Product(10, 250, "Gucci hat");
        }

        public void WriteAssortiment()
        {
            FillTheAssortment();
            Console.WriteLine("Our assortiment:\n");
            for (int i = 0; i < Assortment.Length; i++)
            {
                Console.WriteLine($"{Assortment[i].Id}) {Assortment[i].Name} - {Assortment[i].Sum}$");
            }

            Console.WriteLine();
        }
    }
}
