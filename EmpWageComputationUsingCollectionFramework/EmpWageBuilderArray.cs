using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public interface EmpBuilder
    {
        public void AddCompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth);
        public int ComputeEmpWage(CompanyEmployeeDailyWage companyEmployeeDailyWage);
        public void ComputeEmpWage();        
    }
    public class EmpWageBuilderArray:EmpBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmployeeDailyWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmployeeDailyWage[5];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmployeeDailyWage(company, empRatePerHours, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                int val = this.ComputeEmpWage(this.companyEmpWageArray[i]);
                companyEmpWageArray[i].setTotalEmpWage(val);
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        public int ComputeEmpWage(CompanyEmployeeDailyWage companyEmployeeDailyWage)
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

            }


            return companyEmployeeDailyWage.totalEmpWage;
        }


    }
}
