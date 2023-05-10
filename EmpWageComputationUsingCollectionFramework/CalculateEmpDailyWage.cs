using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public class CalulateEmpDailyWage
    {
        Model model = new Model();        
        public void CalculateEmployeeWageMonth()
        {            
            for (int day = 0; day < model.NUM_OF_WORKING_DAY; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                
                switch (empCheck)
                {
                    case 1:
                        model.empHour = 8;
                        break;
                    case 2:
                        model.empHour = 4;
                        break;
                    default:
                        model.empHour = 0;
                        break;
                }
                model.empWage = model.empHour * model.EMP_RATE_PER_HOUR;
                Console.WriteLine("Employee Wage :" + model.empWage);
                model.totalEmpWage += model.empWage;

            }
            Console.WriteLine("Total EmpWage :" + model.totalEmpWage);
        }
    }
}
