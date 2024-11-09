using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private decimal price;
        private int count;

       
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentException("Price cannot be negative");
            }
        }

     
        public int Count
        {
            get { return count; }
            set
            {
                if (value >= 0)
                    count = value;
                else
                    throw new ArgumentException("Count cannot be negative");
            }
        }

       
        public Product(int id, string name, decimal price, int count)
        {
            Id = id;
            Name = name;
            Price = price;
            Count = count;
        }
    }




}
