using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    class CalculateEmpDailyWage
    {
        int EMP_RATE_PER_HOUR;// = 20;
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 2;
        int empHour = 0;
        int empWage = 0;
        List<int> list;



        public CalculateEmpDailyWage(int emp_Rate_Per_Hours)
        {
            EMP_RATE_PER_HOUR = emp_Rate_Per_Hours;
            list = new List<int>();
            list.Add(EMP_RATE_PER_HOUR);
            list.Add(IS_FULL_TIME);
            list.Add(IS_PART_TIME);
            list.Add(empHour);
            list.Add(empWage);
        }

        public static int CalculateEmployeeWork()
        {
            Random random = new Random();
            int empCheck = random.Next(3);
            return empCheck;
        }
        public List<int> CalculateWageFullTimePartTime()
        {
            int empCheck = CalculateEmployeeWork();
            if (empCheck == list[1])            
                empHour = 8;
            else if (empCheck == list[2])
                empHour = 4;
            else
                empHour = 0;
            empWage = empHour * list[0];
            list.Add(empWage);
            return list;
        }
    }
}
