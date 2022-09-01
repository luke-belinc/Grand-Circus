using System;
namespace NewUsedCarsLab
{
    public class UsedCar : Car
    {
        public double Mileage;

        public UsedCar() : base()
        {
            Mileage = 0;
        }

        public UsedCar(string make, string model, int year, decimal price, double mileage) : base (make, model, year, price)
        {
            Mileage = mileage;
        }

        public override string ToString()
        {
            return $"{Make} {Model} ({Year}), {Mileage} miles, ${Price}";
        }
    }
}
