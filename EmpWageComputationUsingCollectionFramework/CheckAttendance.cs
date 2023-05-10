using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public class CheckAttendance
    {
        public List<int> EmpAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(2);
            List<int> empData = new List<int>();
            empData.Add(empCheck);
            return empData;
        }
    }
}
