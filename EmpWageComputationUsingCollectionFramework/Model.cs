using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public class Model
    {
        
        public string companyName{ get; set; }
        public int empWage { get; set; }
        public int totalEmpWage { get; set; }
        public int empRatePerHrs { get; set; }
        public int empHrs { get; set; }
        public int totalEmpHrs { get; set; }
        public int numOfWorkingDay { get; set; }
        public int maxHrsPerMonth { get; set; }
    }
}
