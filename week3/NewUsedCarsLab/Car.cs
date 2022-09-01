using System;
using System.Collections.Generic;

namespace NewUsedCarsLab
{
    public class Car
    {
        public static List<Car> CarsList = new List<Car>();

        public static void ListCars()
        {
            Console.WriteLine("\nAvailable Cars\n==============");
            int count = 1;
            foreach (var car in CarsList)
            {
                Console.WriteLine($"    {count++}: {car}");
            }
        }

        public static void Remove(int idx)
        {
            CarsList.Remove(CarsList[idx]);
        }

        public string Model;
        public string Make;
        public int Year;
        public decimal Price;

        public Car()
        {
            Model = "Not provided";
            Make = "Not provided";
            Year = 9999;
            Price = 0.00m;
        }

        public Car(string make, string model, int year, decimal price)
        {
            Model = model;
            Make = make;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Make} {Model} ({Year}), ${Price}";
        }

        //protected string Model
        //{
        //    get { return _Model; }
        //    set { _Model = value; }
        //}

        //protected string Make
        //{
        //    get { return _Make; }
        //    set { _Make = value; }
        //}
        //protected int Year
        //{
        //    get { return _Year; }
        //    set { _Year = value; }
        //}
        //protected decimal Price
        //{
        //    get { return _Price; }
        //    set { _Price = value; }
        //}


    }
}
