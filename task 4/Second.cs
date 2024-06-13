using System;

namespace task_4
{
    internal class Second
    {
        public Second()
        {
            Console.WriteLine("Universal Traffic light:");
            //foreach (TrafficLights light in Enum.GetValues(typeof(TrafficLights)))
            ConsoleColor[] colors = { ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Red };
            TrafficLights[] lights = (TrafficLights[])Enum.GetValues(typeof(TrafficLights));
            for (int i = 0; i < lights.Length; i++)
            {
                Console.ForegroundColor = colors[i];
                Console.WriteLine(lights[i]);
            }
            Console.ResetColor();
            //Console.WriteLine(light);
        }

        #region Question 2

        public enum TrafficLights
        {
            Green,
            Yellow,
            Red,
        }

        #endregion
    }
}