using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public class EmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmployeeWage[] companyEmpWageList;

        public EmpWage()
        {
            this.companyEmpWageList = new CompanyEmployeeWage[5];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageList[this.numOfCompany] = new CompanyEmployeeWage(company, empRatePerHours, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                int val = this.ComputeEmpWage(this.companyEmpWageList[i]);
                companyEmpWageList[i].setTotalEmpWage(val);
                Console.WriteLine(this.companyEmpWageList[i].toString());
            }
        }
        public int ComputeEmpWage(CompanyEmployeeWage companyEmployeeDailyWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmployeeDailyWage.maxHoursPerMonth && totalWorkingDays < companyEmployeeDailyWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                companyEmployeeDailyWage.totalEmpWage = totalEmpHrs * companyEmployeeDailyWage.empRatePerHour;
                // companyEmployeeDailyWage.totalEmpWage += companyEmployeeDailyWage.totalEmpWage;
                //companyEmployeeDailyWage.totalEmpWage = companyEmployeeDailyWage.totalEmpWage* companyEmployeeDailyWage.numOfWorkingDays;
            }

            

            return companyEmployeeDailyWage.totalEmpWage;
        }


    }
}
