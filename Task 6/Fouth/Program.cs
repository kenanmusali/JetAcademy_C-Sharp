using System;
using System.Collections.Generic;
using System;

namespace Task4
{
    public class Program
    {
        public static void Main()
        {
            int number = 123;
            Console.WriteLine(number.ToOrdinal()); 
        }
    }
}


//Integer ToOrdinal
//Create an extension method ToOrdinal for the int class that converts the integer
//to its ordinal string representation (e.g., 1 -> "1st", 2 -> "2nd", 3 -> "3rd").