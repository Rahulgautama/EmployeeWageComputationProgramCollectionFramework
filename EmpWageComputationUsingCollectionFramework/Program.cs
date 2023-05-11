using System;
using System.Collections.Generic;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.AddCompanyEmpWage("Flipkart", 20, 2, 10);
            empWageBuilderArray.AddCompanyEmpWage("Amazon", 10, 4, 20);
            empWageBuilderArray.AddCompanyEmpWage("Google", 32, 19, 8);

            empWageBuilderArray.ComputeEmpWage();
        }
    }
}
