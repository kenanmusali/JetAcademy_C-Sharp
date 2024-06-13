using System;

namespace task_4
{
    internal class First
    {
        public string UserId { get; set; }
        public int dailySalary { get; set; }
        public int MonthlySalary { get; set; }
        public int AnnualSalary { get; set; }

        public First(string userid, int dSalary, int mSalary, int aSalary)
        {
            UserId = userid;
            dailySalary = dSalary;
            MonthlySalary = mSalary;
            AnnualSalary = aSalary;
        }

        public virtual void CalculateMonthlySalary()
        {
            Console.WriteLine($"Employee Id: {UserId}, Daily Income: {dailySalary}$, Monthly Income: {MonthlySalary}$, Annual Salary: {AnnualSalary}$");
        }
    }

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
