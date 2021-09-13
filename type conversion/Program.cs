using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //implicit type conversion
            byte b = 1; //computer sees it as 000001
            int i = b; //converts to int and is stored as 00000000 00000000 00000000 00000001

            int i1 = 1;
            float f = i1; //no data loss

            int i2 = 1;
            byte b1 = i2; //will not compile, because of potential data loss

            float f1 = 1.0f;
            int i3 = f1; //will not compile, because of potential data loss
            int i4 = (int)f1; //will compile, because we told the computer to ignore the potential loss

            string s = "1";
            int it = (int)s; //won't compile, because non-compatible types

            //for non-compatible types use either the Convert.ToInt32 or Parse class
            string st = "1";
            int numb = Convert.ToInt32(st);
            int numb2 = int.Parse(st);

            //Some add'l methods for the Convert class ToByte(), ToInt16(), ToInt32() and ToInt64()
            //every byte has 8 bits

            //exception handling

            */

            try
            {
                var number = "1234";
                byte by = Convert.ToByte(number);
                Console.WriteLine(number);  //will have data loss and would crash w/the try & catch
            }
            catch (Exception)
            {

                Console.WriteLine("The number couldn't be converted.");
            }

            try
            {
                string str = "true";
                bool boo = Convert.ToBoolean(str);
                Console.WriteLine(boo);
            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't be converted to a Boolean");
            }

            var a = 10;
            var b = 3;
            var c = 2;

            Console.WriteLine(a + b);//will be 13
            Console.WriteLine(a / b );//will be 3 (will not show as a float
            Console.WriteLine((float)a / (float)b);//(will show 3.333333333)
            Console.WriteLine(a + b * c);//will be 16
            Console.WriteLine((a + b) * c);//will be 26

            Console.WriteLine(a > b);//boolean value- true
            Console.WriteLine(a == b);//will be false, because they are not equal
            Console.WriteLine(a > b && a > c);//will be true, because both are true
            Console.WriteLine(b > a || b > c);//will be true, because one is true
        }
    }
}
