using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_basico
{
    internal class Lasagna
    {
        // Define the expected oven time in minutes
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        // Calculate the remaining oven time in minutes
        public int RemainingMinutesInOven(int actualTime)
        {
            return ExpectedMinutesInOven() - actualTime;
        }

        // Calculate the preparation time in minutes
        public int PreparationTimeInMinutes(int numberLayers)
        {
            return 2 * numberLayers;
        }
        // Calculate the elapsed time in minutes
        public int ElapsedTimeInMinutes(int numberLayers, int actualTime)
        {
            return 2 * numberLayers + actualTime;
        }
    }
}
