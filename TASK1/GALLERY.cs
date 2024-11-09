using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{ 
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; } = new List<Car>();

        
        public Gallery(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void ShowAllCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine(car);
            }
        }

        public List<Car> GetAllCars()
        {
            return Cars;
        }

        public Car FindCarById(int id)
        {
            return Cars.FirstOrDefault(car => car.Id == id);
        }

        public Car FindCarByCarCode(string carCode)
        {
            return Cars.FirstOrDefault(car => car.CarCode == carCode);
        }

        public List<Car> FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            return Cars.Where(car => car.Speed >= minSpeed && car.Speed <= maxSpeed).ToList();
        }
    }
}



     