using System;

namespace EmpWageComputationUsingCollectionFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new CheckAttendance();
            var empData=data.EmpAttendance();
            const int IS_FULL_TIME = 1;
            Console.WriteLine("Welcome to Employee Wage Computation Program using Collection FrameWork");
            if (empData[0]== IS_FULL_TIME)
            {
                Console.WriteLine("Empoyee is Present");
            }
            else
            {
                Console.WriteLine("Empoyee is Absent");
            }
        }
    }
}
