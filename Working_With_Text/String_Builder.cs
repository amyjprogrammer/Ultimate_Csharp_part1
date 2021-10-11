using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Text
{
    class String_Builder
    {
        static void Main(string[] args)
        {
            var fullName = "Amy Jones   ";
            Console.WriteLine($"Trim: '{fullName.Trim()}'");//gets rid of whitespace before and after
            Console.WriteLine($"ToUpper: '{fullName.Trim().ToUpper()}'");//gets rid of whitespace before and after..also converts everything to upper

            var index = fullName.Trim().IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");

            var names = fullName.Split(' ');
            Console.WriteLine($"First Name: {names[0]}");
            Console.WriteLine($"Last Name: {names[1]}");

            Console.WriteLine(fullName.Replace("Amy", "June"));
            fullName.Replace("m", "M");

            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");//shows invalid
            if (String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");//shows invalid
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");//also shows invalid--looks for null, empty and whitespace

            var str = "25";
            Convert.ToByte(str);//user giving an age- goes to 255

            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); //formats it to $29.95

            //Summarizing Text
            var sentence = "This is going to be a really really really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence);
            var summary1 = StringUtility.SummerizeText(sentence, 30);
            Console.WriteLine(summary);
            Console.WriteLine(summary1);

            //StringBuilder- more efficient

            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();//adds a new line
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');//replaces all the above - with +

            builder.Remove(0, 10);//removes the top line

            builder.Insert(0, new string('-', 10));//adds the dashes back to the top line
            Console.WriteLine(builder);

            Console.WriteLine($"First Char: {builder[0]}");

            var builderOne = new StringBuilder();
            builderOne.Append('*', 10)
                .AppendLine()
                .Append("Hello World")
                .AppendLine()
                .Append('#', 10);//chaining them together

            Console.WriteLine(builderOne);

            Console.WriteLine("Enter numbers with a hyphen in between: ");//checking for consecutive
            var userNums = Console.ReadLine();
            var list = userNums.Split('-');

            var first = Convert.ToInt32(list[0]);
            var second = Convert.ToInt32(list[1]);

            if ((first - second) == 1 || (second - first) == 1)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");


        }
    }
}
