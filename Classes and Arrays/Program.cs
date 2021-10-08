using Classes_and_Arrays.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();//creating an object
            person.FirstName = "Amy";//instance of the object
            person.LastName = "Jones";
            person.Introduce();

            //fast way to switch between cs programs- ctrl + tab

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            
        }
        
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            var anotherCookie = new Cookie();
            anotherCookie.Name = "Chocalate Chip";
            cookie.HasNuts = false;

            var secondCookie = new Cookie();
            secondCookie.GramsOfFlour = 1.3;

            Cookie peanutButter = new Cookie("Peanut Butter", true, 3.4);
        }

        public void VehicleTests()
        {
            var car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle //initializing with curly braces
            {
                TypeOfVehicle = VehicleType.Motorcyle,
                Make = "Honda",
                Model = "Civic"
            };
        }

        
    }
}
