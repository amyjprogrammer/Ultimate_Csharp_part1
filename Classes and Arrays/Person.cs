﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Arrays
{
    //can be public or private (public lets you access in other systems)
    public class Person
    {
        public string FirstName; //declaring a variable in the class
        public string LastName;

        //also methods
        public void Introduce ()//doesn't take any parameters
        {
            Console.WriteLine("Hi, my name is " + FirstName + " " + LastName);
        }
    }
}
