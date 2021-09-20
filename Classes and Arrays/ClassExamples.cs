using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Arrays
{
    //the default for the public access modifier is internal
    public class Cookie
    {
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }

        public Cookie() //Constructor has to have the same name as the class
        {

        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour)
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }

    public enum VehicleType { Car, Truck, Van, Motorcyle}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public double Mileage { get; set; }
        public bool IsHybrid { get; set; }

        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle() { } //overloading- two constructors

        public Vehicle (string make, string model, double mileage, bool isHybrid)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            IsHybrid = isHybrid;
        }
    }

    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }
    }
}
