using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public string CarCode { get; set; }

        public Car(int id, string name, int speed)
        {
            Id = id;
            Name = name;
            Speed = speed;
            CarCode = GenerateCarCode(name, id);
        }

        private string GenerateCarCode(string name, int id)
        {
            string namePrefix = name;
            return $"{namePrefix}{id}";
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Speed: {Speed}, CarCode: {CarCode}";
        }
    }
}