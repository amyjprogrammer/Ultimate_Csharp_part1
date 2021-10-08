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

            var nums = new int[3] { 1, 2, 3 };
            string list = string.Join(", ", nums);
            Console.WriteLine(list);

            //escape characters
            // \n - new line
            // \t - tab
            // \\ backslash
            // \' single quotation mark
            // \" Double quotation mark

            //verbatim strings
            string path = "c:\\projects\\project1\\folder1"; //would show projects\project1\folder1
            string path1 = @"c:\projects\project1\folder1"; //same as above when printed

            string firstName = "Amy"; //or var firstName = "Amy";
            var lastName = "Jones";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var nameString = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", nameString);
            Console.WriteLine(formattedNames); // shows John, Jack, Mary

            var text = "Hi John\nLook into the following paths\nc:\\folder\\folder1\\projects\n\\folder3";
            Console.WriteLine(text);

            //use Verbatim
            var text1 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text1);
        }


    }
}
