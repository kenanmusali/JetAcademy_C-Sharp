namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region RomanNumerals
            //Ede Bilmedim
            #endregion

            #region DivideIntegers
            Console.WriteLine("Type your dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int divide = dividend / divisor;
            float divide1 = (float)dividend / divisor;
            Console.WriteLine("Your Answer is: " + divide);
            Console.WriteLine("Your Reminder is: " + divide1);
            #endregion

            #region ZigzagConversion
            // Hecne basa dusmedim.
            #endregion
        }
    }
}
