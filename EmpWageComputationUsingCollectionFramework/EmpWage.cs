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
                int empCheck = CalculateEmployeeWork();
                if (empCheck == IS_FULL_TIME)
                    data.empHrs= 8;
                else if (empCheck == IS_PART_TIME)
                    data.empHrs = 4;
                else
                    data.empHrs = 0;
                data.totalEmpHrs = data.maxHrsPerMonth * data.empHrs;
                data.totalEmpWage = data.totalEmpHrs * data.empRatePerHrs;
                
            }
            return model;
        }


    }
}
