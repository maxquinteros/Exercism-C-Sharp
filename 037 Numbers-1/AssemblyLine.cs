using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.AssemblyLine
{
    static class AssemblyLine
    {
        // Task 1: Calculate the success rate
        public static double SuccessRate(int speed)
        {
            if (speed == 0)
                return 0.00;
            else if (speed <= 4)
                return 1.00;
            else if (speed <= 8)
                return 0.90;
            else if (speed == 9)
                return 0.80;
            else if (speed == 10)
                return 0.77;
            else
                throw new Exception("Value not expected");
        }
        // Task 2: Calculate the production rate per hour
        public static double ProductionRatePerHour(int speed)
        {
            if (speed == 0)
                return 0.00;
            else if (speed <= 4)
                return speed * 1.00 * 221;
            else if (speed <= 8)
                return speed * 0.90 * 221;
            else if (speed == 9)
                return speed * 0.80 * 221;
            else if (speed == 10)
                return speed * 0.77 * 221;
            else
                throw new Exception("Value not expected");
        }
        // Task 3: Calculate the number of working items produced per minute
        public static int WorkingItemsPerMinute(int speed)
        {
            if (speed == 0)
                return 0;
            else if (speed <= 4)
                return (int)(speed * 1.00 * 221 / 60);
            else if (speed <= 8)
                return (int)(speed * 0.90 * 221 / 60);
            else if (speed == 9)
                return (int)(speed * 0.80 * 221 / 60);
            else if (speed == 10)
                return (int)(speed * 0.77 * 221 / 60);
            else
                throw new Exception("Value not expected");
        }
    }
}
