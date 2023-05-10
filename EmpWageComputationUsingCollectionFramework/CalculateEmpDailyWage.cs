using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public class CalulateEmpDailyWage
    {
        Model model = new Model();
        public  List<int> CalculateEmployeeWageTotalHrsAMonth()
        {
            int EMP_RATE_PER_HOUR =  20;            
            int NUM_OF_WORKING_DAYS = 20;
            int MAX_HRS_IN_MONTH = 100;
            Random rdm = new Random();

            while (model.totalWorkingDays < NUM_OF_WORKING_DAYS && model.totalWorkingHours < MAX_HRS_IN_MONTH)
            {
                model.totalWorkingDays++;
                int empCheck = rdm.Next(3);
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
                model.totalEmpHour += model.empHour;
                model.empWage = model.empHour * EMP_RATE_PER_HOUR;
                model.totalEmpWage += model.empWage;
            }
            var list = new List<int>();
            list.Add(model.totalWorkingDays);
            list.Add(model.totalEmpHour);
            list.Add(model.totalEmpWage);               
            return list;
        }
    }
}
