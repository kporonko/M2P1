using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Store.Models
{
    public class Product
    {
        public Product(int id, double sum, string name)
        {
            Id = id;
            Sum = sum;
            Name = name;
        }

        public int Id { get; set; }
        public double Sum { get; set; }
        public string Name { get; set; }
    }
}
