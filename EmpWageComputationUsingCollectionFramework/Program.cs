using System;
using System.Collections;
using System.Collections.Generic;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Daily Employee Wage");

            List<Model> data = new List<Model>{
                new Model { companyName="Jio", maxHrsPerMonth=20, empRatePerHrs=20,empWage=0,totalEmpWage=0,numOfWorkingDay=20},
                new Model { companyName="Google", maxHrsPerMonth=20,empRatePerHrs=40,empWage=0,totalEmpWage=0,numOfWorkingDay=20}
                };

            EmpWage employeeDailyWage = new EmpWage();
            var empDetails = employeeDailyWage.CalculateWageFullTimePartTime(data);
            foreach (var details in empDetails)
            {
                Console.WriteLine("Company Name is " + details.companyName + " Total Emp Wage =" + details.totalEmpWage);

            }
            // Console.WriteLine("Employee Wage :" + empWage[]);
        }
    }
}
