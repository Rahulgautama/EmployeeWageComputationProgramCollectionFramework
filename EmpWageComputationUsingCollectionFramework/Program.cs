using System;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage");
            CalculateEmpDailyWage employeeDailyWage = new CalculateEmpDailyWage();
            employeeDailyWage.CalculateEmpWage();
        }
    }
}
