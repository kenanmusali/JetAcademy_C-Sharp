using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{

    public class Program
    {
        public static void Main()
        {
            try
            {
                int celsius = 2;
                int fahrenheit = celsius * 9 / 5 + 32;
                Check(celsius);
                Console.WriteLine($"{celsius} Celsius");

                Check1(fahrenheit);
                Console.WriteLine($"{fahrenheit} Fahrenheit");
            }
            catch (ITE ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Check(int celsius)
        {
            if (celsius < 0)
            {
                
                throw new ITE();
            }
        }

        public static void Check1(int fahrenheit)
        {
            if (fahrenheit < 0)
            {
               
                throw new ITE();
            }
        }
    }
}


//Task 2: Create a custom exception InvalidTemperatureException
//that is thrown when an invalid temperature (below absolute zero)
//is provided. Implement this in a TemperatureConverter class that
//converts temperatures between Celsius and Fahrenheit.