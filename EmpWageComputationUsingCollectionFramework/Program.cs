using System;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage empWage = new EmpWage();
            empWage.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWage.AddCompanyEmpWage("Jio", 10, 4, 20);

            empWage.ComputeEmpWage();
        }
    }
}
