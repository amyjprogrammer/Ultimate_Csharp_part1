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
    }
}
