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
    }

    public enum VehicleType { Car, Truck, Van, Motorcyle}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public double Mileage { get; set; }
        public bool IsHybrid { get; set; }

        public VehicleType TypeOfVehicle { get; set; }
    }

    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }
    }
}
