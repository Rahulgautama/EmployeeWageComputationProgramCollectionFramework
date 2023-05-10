using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputationUsingCollectionFramework
{
    public class Model
    {
        public int EMP_RATE_PER_HOUR { get; } = 20;
        public int IS_FULL_TIME { get;}=1;
        public int IS_PART_TIME { get;} = 2;
        public int NUM_OF_WORKING_DAY { get;} = 20;
        public int empHour { get; set; } = 0;
        public int empWage { get; set; } = 0;
        public int totalEmpWage { get; set; } = 0;
    }
}
