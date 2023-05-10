using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public class CalulateEmpDailyWage
    {
        public const int EMP_RATE_PER_HOUR=20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int empHour = 0;
        int empWage = 0;
        static Random random = new Random();
        int empCheck = random.Next(3);
        List<int> list;
        public CalulateEmpDailyWage()
        {
            list= new List<int>();
            list.Add(EMP_RATE_PER_HOUR);
            list.Add(IS_FULL_TIME);
            list.Add(IS_PART_TIME);
            list.Add(empHour);
            list.Add(empWage);
            list.Add(empCheck);
        }

        public int CalculateEmployeeWageSwitchCase()
        {
            
            switch (list[5])
            {
                case IS_FULL_TIME:
                    empHour = 8;
                    break;
                case IS_PART_TIME:
                    empHour = 4;
                    break;
                default:
                    empHour = 0;
                    break;
            }
            empWage = empHour * list[0];
            return empWage;
        }
    }
}
