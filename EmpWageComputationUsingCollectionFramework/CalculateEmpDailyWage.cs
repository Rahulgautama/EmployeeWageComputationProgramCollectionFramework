using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    class CalculateEmpDailyWage
    {
        public static List<int> EmpDailyWage(int emp_Rate_Per_Hrs)
        {
            int EMP_RAT_PER_HOUR = emp_Rate_Per_Hrs;
            int IS_FULL_TIME = 1;

            List<int> details = new List<int>();
            details.Add(EMP_RAT_PER_HOUR);
            details.Add(IS_FULL_TIME);
            return details;
        }
        public void CalculateEmpWage()
        {
            var list = EmpDailyWage(20);
            int empHour = 0,empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == list[1])
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * list[0];
            Console.WriteLine("Employee Wage :" + empWage);
        }
    }
}
