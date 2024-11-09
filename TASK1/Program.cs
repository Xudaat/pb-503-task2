namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        { 

        
           
            Gallery gallery = new Gallery(1, "Car Gallery");

            
            Car car1 = new Car(1245, "Lexus", 160);
            Car car2 = new Car(2135, "Mercedes", 210);
            Car car3 = new Car(3276, "BMW", 180);

            
            gallery.AddCar(car1);
            gallery.AddCar(car2);
            gallery.AddCar(car3);

            Console.WriteLine("All Cars in the Gallery:");
            gallery.ShowAllCars();
            Console.WriteLine();
            //
            var allCars = gallery.GetAllCars();
            Console.WriteLine("All Cars returned from GetAllCars:");
            foreach (var car in allCars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            Console.WriteLine("FindCarById(2135):");
            var foundCarById = gallery.FindCarById(2135);
            Console.WriteLine(foundCarById);
            Console.WriteLine();
            //
            Console.WriteLine("FindCarByCarCode('MERCEDES2135'):");
            var foundCarByCarCode = gallery.FindCarByCarCode("MERCEDES2135");
            Console.WriteLine(foundCarByCarCode);
            Console.WriteLine();
            //
            Console.WriteLine("FindCarsBySpeedInterval(190, 210):");
            var carsInSpeedInterval = gallery.FindCarsBySpeedInterval(190, 210);
            foreach (var car in carsInSpeedInterval)
            {
                Console.WriteLine(car);
            }
        }
    

    }
}

