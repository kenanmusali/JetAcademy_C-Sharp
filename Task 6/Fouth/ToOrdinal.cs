using System;

namespace Task4
{
    public static class IntExtensions
    {
        public static string ToOrdinal(this int number)
        {
            if (number <= 0)
                throw new InvalidObject("Number must be greater than zero.");

            int lastTwoDigits = number % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
            {
                return $"{number}th";
            }

            switch (number % 10)
            {
                case 1:
                    return $"{number}st";
                case 2:
                    return $"{number}nd";
                case 3:
                    return $"{number}rd";
                default:
                    return $"{number}th";
            }
        }
    }
}
