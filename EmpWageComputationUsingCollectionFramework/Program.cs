using System;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage");
            CalculateEmpDailyWage employeeDailyWage = new CalculateEmpDailyWage(20);
            var empWage = employeeDailyWage.CalculateWageFullTimePartTime();

            Console.WriteLine("Employee Wage :" + empWage[5]);
        }
    }
}
