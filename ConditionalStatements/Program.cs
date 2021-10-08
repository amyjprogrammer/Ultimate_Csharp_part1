using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    partial class Program
    {
        //declared Season Enum up here, but used visual studio to easily move it to season.cs
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning.");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon.");
            else
                Console.WriteLine("It's evening.");

            //control w allows you to select multiple lines 

            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            float price1 = (isGoldCustomer) ? 19.95f : 29.95f;//same as above and shows 19.95

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Summer:
                case Season.Autumn:
                    Console.WriteLine("We've got a promotion.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }

            Console.Write("Enter a number between 1-10: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput >= 1 && userInput <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            Console.Write("Enter a number: ");
            var userInputNumOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            var userInputNumTwo = Convert.ToInt32(Console.ReadLine());
            if (userInputNumOne > userInputNumTwo)
                Console.WriteLine(userInputNumOne);
            else
                Console.WriteLine(userInputNumTwo);

            Console.Write("Enter a width: ");
            var userInputWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a height: ");
            var userInputNumHeight = Convert.ToInt32(Console.ReadLine());
            if (userInputWidth > userInputNumHeight)
                Console.WriteLine("Landscape");
            else
                Console.WriteLine("Portrait");

            //program to get users speed and set the speed limit
            Console.Write("Enter your speed limit: ");
            var speedLimit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your speed: ");
            var userSpeed = Convert.ToDouble(Console.ReadLine());

            int demeritMiles = 5;
            if (userSpeed < speedLimit)
                Console.WriteLine("ok");
            else
            {
                var demerit = (userSpeed - speedLimit) / demeritMiles;
                if(demerit > 12)
                    Console.WriteLine("Your license was suspended");
                else
                    Console.WriteLine($"You received {demerit} demerits for driving {userSpeed}");
            }

        }
    }
}
