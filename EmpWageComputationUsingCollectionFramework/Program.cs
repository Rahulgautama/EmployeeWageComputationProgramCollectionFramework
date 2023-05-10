using System;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage switch case");
            CalulateEmpDailyWage employeeDailyWage = new CalulateEmpDailyWage();
            employeeDailyWage.CalculateEmployeeWageMonth();            
        }
    }
}
