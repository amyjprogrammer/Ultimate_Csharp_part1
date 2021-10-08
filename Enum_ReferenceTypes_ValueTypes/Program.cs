using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_ReferenceTypes_ValueTypes
{
    public enum ShippingMethod { RegularAirMail = 1, RegisteredAirMail = 2, Express = 3}
    public class Person { public int Age; }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // shows three

            var methodId = 3; //we received this from an outside source
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());//shows Express
            Console.WriteLine(method);//also shows Express

            var methodName = "Express";
            //parsing a string to an enum
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"{a} {b}");//10 and 11

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(array1[0]);//got changed to zero just like array 2
            // primitive types are stored in the stack not the heap
            //arrays and classes are in the heap
            //when using arrays and classes they store a location to the heap in stack

            int number = 1;
            Increment(number);
            Console.WriteLine(number);//shows 1, because int is a reference type

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);//is 30 in both makeold person and the newed up person

        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
