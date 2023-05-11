using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public class EmpWage
    {
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 2;

        public static int CalculateEmployeeWork()
        {
            Random random = new Random();
            int empCheck = random.Next(3);
            return empCheck;
        }
        public List<Model> CalculateWageFullTimePartTime(List<Model> model)
        {
           
                foreach (var data in model)
                {
                for (int day = 0; day <data.numOfWorkingDay; day++)
                {
                    int empCheck = CalculateEmployeeWork();
                    if (empCheck == IS_FULL_TIME)
                        data.empHrs = 8;
                    else if (empCheck == IS_PART_TIME)
                        data.empHrs = 4;
                    else
                        data.empHrs = 0;

                    data.empWage = data.empHrs * data.empRatePerHrs;
                    Console.WriteLine("Employee Daily Wage :" + data.empWage);
                    data.totalEmpWage += data.empWage;                 

                }
                //Console.WriteLine("Total EmpWage :" + data.totalEmpWage);
            }
            return model;
        }


    }
}
