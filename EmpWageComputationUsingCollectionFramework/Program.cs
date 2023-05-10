using System;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage switch case");
            CalulateEmpDailyWage employeeDailyWage = new CalulateEmpDailyWage();
            var data=employeeDailyWage.CalculateEmployeeWageTotalHrsAMonth();

            Console.WriteLine("Total Working Days: " + data[0]);
            Console.WriteLine("Total Working Hours: " + data[1]);
            Console.WriteLine("Total Employee Wage : " + data[2]);
        }
    }
}
