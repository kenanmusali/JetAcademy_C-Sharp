using System;

namespace task_4
{

    public class Data : First
    {
        public Data(string userid, int dSalary, int mSalary, int aSalary) : base(userid, dSalary, mSalary, aSalary)
        {
        }

        public override void CalculateMonthlySalary()
        {
            Console.WriteLine("Employee Id: Tom J., Daily Income: 5$, Monthly Income: $345, Annual Salary: $60,000");
        }
    }
}
