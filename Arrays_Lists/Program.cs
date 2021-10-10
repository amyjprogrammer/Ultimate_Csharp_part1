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

            for (var i = 0; i < number1.Count; i++)
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

            var nameList = new List<string>();
            bool enterName = true;
            while (enterName)
            {
                Console.Write("Please enter a name: ");
                var userInput = Console.ReadLine();

                if (userInput.Length < 1)
                {
                    if (nameList.Count == 0)
                    {
                        Console.WriteLine("Nothing");
                    }
                    else if (nameList.Count == 1)
                    {
                        Console.WriteLine($"{nameList[0]} likes your post.");
                    }
                    else if (nameList.Count == 2)
                    {
                        Console.WriteLine($"{nameList[0]}, {nameList[1]} like your post.");
                    }
                    else
                    {
                        Console.WriteLine($"{nameList[0]}, {nameList[1]} and {nameList.Count - 2} others like your post.");
                    }
                    enterName = false;
                }
                else
                {
                    nameList.Add(userInput);
                }

            }

            Console.Write("Please enter your name: ");
            var userIn = Console.ReadLine();
            var array = new[] { userIn };
            Array.Reverse(array);
            var newString = array;
            Console.WriteLine(newString);

            var numFive = new List<int>();//asking user for five numbers..make sure they don't duplicate and sort the five numbers
            while (numFive.Count < 5)
            {

                Console.Write("Enter numbers: ");
                var userNum = Convert.ToInt32(Console.ReadLine());

                if (numFive.Contains(userNum))
                {
                    Console.Write("Enter a new number: ");
                    continue;
                }
                numFive.Add(userNum);
                numFive.Sort();
                foreach (var n in numFive)
                {
                    Console.WriteLine(n);
                }

            }


            var numberList = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numberList.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numberList)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }


    }
}

