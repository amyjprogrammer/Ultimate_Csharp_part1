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
            person.firstName = "Amy";//instance of the object
            person.lastName = "Jones";
            person.Introduce();
        }
    }
}
