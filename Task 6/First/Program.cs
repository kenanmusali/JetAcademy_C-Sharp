namespace Task1
{

    public class Program
    {
        public static void Main()
        {
            try
            {
                int number = -15; 
                Check(number);
            }
            catch (NNE ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Check(int number)
        {
            if (number < 0)
            {
                throw new NNE();
            }
        }
    }

}

//Task 1: Custom Exception Class
//Create a custom exception called NegativeNumberException
//that is thrown when the user enters a negative number
//Modify the program to handle this exception.