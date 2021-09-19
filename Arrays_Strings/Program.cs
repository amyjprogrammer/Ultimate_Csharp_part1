using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];//this initializing an array..it can never be more than three
            var numbr = new int[3]; //can also use var to initialize

            numbers[0] = 1; //use ctrl + d (duplicates the line
            numbers[1] = 2;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);//don't forget ctrl + d- I really like being able to duplicate fast
            //this will be zero- it is initialized to zero by default

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);//show false, because it is initialized that way
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
