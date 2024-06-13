using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1-4
            Data employee = new Data("Tom J.", 5, 345, 60000);
            employee.CalculateMonthlySalary();

            Second b = new Second();
            Third c = new Third();
            Fourth d = new Fourth();
            #endregion
        }
    }
}
