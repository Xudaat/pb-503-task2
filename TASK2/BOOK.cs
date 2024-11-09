using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    public class Book : Product
    {
        public string Genre { get; set; }

        
        public Book(int id, string name, decimal price, int count, string genre)
            : base(id, name, price, count)  
        {
            if (string.IsNullOrEmpty(genre))
                throw new ArgumentException("Genre cannot be null or empty");

            Genre = genre;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}, Count: {Count}, Genre: {Genre}";
        }
    }

}
