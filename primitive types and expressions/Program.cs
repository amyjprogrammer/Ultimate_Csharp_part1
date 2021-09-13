using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primitive_types_and_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 1.2f; //needs a f after the number
            double number2 = 1.2;//C# defaults to double
            decimal number3 = 1.2m; //needs a m after the number

            /*
            //Overflowing
            byte example = 255; //that is the largest number for byte
            example++;

            Console.WriteLine(example);//shows zero

            //stopping Overflowing with checked
            checked
            {
                byte example1 = 255;
                example1++;
            }
            
            */

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);//shows the low and high of byte variable
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); //shows the low and high of float

            const float Pi = 3.14f; //can't be changed, constance are fixed and can't be updated

        }
    }
}
