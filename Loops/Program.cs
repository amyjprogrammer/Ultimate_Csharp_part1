using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);//checking for even
                }
            }
            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);//checking for even- goes backward
                }
            }

            var name = "John Smith";
            foreach (var item in name)
            {
                Console.WriteLine(item);//each character in John Smith
            }

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }*/

            /* var i = 1;
             while (i <= 10)
             {
                 if (i % 2 == 0)
                     Console.WriteLine(i); //same as above for loop
                 i++;
             }*/

            /*while (true)
            {
                Console.Write("Type your name: ");
                string userInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userInput)) //checks for null or whitespace
                    break;

                Console.WriteLine($"@Echo: {userInput}");
            }*/

            /*var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10)); //10 numbers that are random
            }*/

            /*var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                //Console.Write((char)random.Next(97, 122));//in asc lowercase a-z is 97 to 122
                Console.Write((char)('a' + random.Next(0, 26)));//a starts at 97..same as above
                
            }
            Console.WriteLine();*/

            /*var rando = new Random();

            const int passwordLength = 10; //if you decide to change the length of password it can be done in one spot
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + rando.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
*/
            var count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)//looking for how many times numbers are divisible by 3 in 100 
                    count++;
            }
            Console.WriteLine(count);

            var num1 = 0;
            while (true)
            {
                Console.Write("Please enter a number or ok to exit: ");
                var userInput = Console.ReadLine();
                if (userInput == "ok")
                {
                    break;
                }
                else
                {
                    var num = Convert.ToInt32(userInput);
                    num1 = num1 + num;
                    Console.WriteLine(num1); //keeps counting while entering a number
                }
            }

            var factorial = 1;
            Console.Write("Please enter a number: ");
            var userNum = Convert.ToInt32(Console.ReadLine());
            for (int i = userNum; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"{userNum}! = {factorial}");

            var chancesLeft = 4;
            var random = new Random();
            var correctNum = random.Next(1, 10);
            Console.WriteLine($"Correct number = {correctNum}");

            while (true)
            {
                Console.Write("Please choose a number between 1-10: ");
                var userGuess = Convert.ToInt32(Console.ReadLine());
                chancesLeft--;

                if (userGuess == correctNum)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                else if (chancesLeft == 0)
                {
                    Console.WriteLine("You lost");
                    break;
                }
                else
                    continue;
            }

            Console.Write("Please enter numbers like 1,2,3: ");
            var stringUser = Console.ReadLine();
            var subs = stringUser.Split(',');
            var max = Convert.ToInt32(subs[0]);//assume first is largest

            foreach (var big in subs)
            {
                var num = Convert.ToInt32(big);
                if (num > max)
                    max = num;
            }
            Console.WriteLine($"The largest number is {max}.");
        }
    }
}
