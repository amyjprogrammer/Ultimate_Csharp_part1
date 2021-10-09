using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            var numbers = new[] { 3, 7, 9, 2, 14, 6 }; //same as above
            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine($"Index of 9: {index}");

            //Clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort ()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse()- opposite of Sort
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Lists
            Console.WriteLine();
            Console.WriteLine("Lists");
            var number1 = new List<int>() { 1, 2, 3, 4 };
            number1.Add(1);
            number1.AddRange(new int[3] { 5, 6, 7 });

            foreach (var num in number1)
                Console.WriteLine(num);//shows all of them 1, 2, 3, 4, 1, 5, 6, 7

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + number1.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + number1.LastIndexOf(1));

            Console.WriteLine("Count: " + number1.Count);

            /* number1.Remove(1);
             foreach (var num in number1)
                 Console.WriteLine(num);//only removed the first one*/

            for(var i = 0; i < number1.Count; i++)
            {
                if (number1[i] == 1)
                {
                    number1.Remove(number1[i]);
                }
            }
            //can't modify list with foreach- will cause error
           /* foreach (var num in number1)
            {
                if (num == 1)
                {
                    number1.Remove(num);
                }
            }*/
            foreach (var num in number1)
                Console.WriteLine(num);

            number1.Clear();
            Console.WriteLine("Count: " + number1.Count);


        }
    }
}
