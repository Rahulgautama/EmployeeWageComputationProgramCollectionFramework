using System;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage switch case");
            CalulateEmpDailyWage employeeDailyWage = new CalulateEmpDailyWage();
            var empWage = employeeDailyWage.CalculateEmployeeWageSwitchCase();

            Console.WriteLine("Employee Wage :" + empWage);
        }
    }
}
