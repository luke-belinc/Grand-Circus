using System;

namespace NewUsedCarsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Car.CarsList.Add(new Car("Ford", "Mustang", 2021, 100000m));
            Car.CarsList.Add(new Car("Land Rover", "Range Rover", 2021, 104000m));
            Car.CarsList.Add(new Car("Dodge", "Dart", 2017, 23000m));
            Car.CarsList.Add(new UsedCar("Ford", "Taurus", 2015, 15000m, 50000d));
            Car.CarsList.Add(new UsedCar("Jeep", "Wrangler", 2018, 35000m, 23000d));
            Car.CarsList.Add(new UsedCar("Honda", "Civic", 2012, 6000m, 84000d));

            Car.ListCars();

            Console.Write("\nWhich car would you like to buy? (1-6): ");
            int opt = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nYou chose: {Car.CarsList[opt - 1]}");
            Car.Remove(opt - 1);

            Car.ListCars();

        }
    }
}
