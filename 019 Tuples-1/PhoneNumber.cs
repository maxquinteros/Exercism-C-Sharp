using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.PhoneNumber
{
    public static class PhoneNumber
    {
        // Task 1: Analyze a phone number
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string firstMember = phoneNumber[..3];
            string secondMember = phoneNumber.Substring(4,3);
            string thridMember = phoneNumber[8..];
            return (firstMember == "212", secondMember == "555", thridMember);

        }
        // Task 2: Detect if a phone number has a fake prefix code (555)
        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            return phoneNumberInfo.IsFake;
        }
    }
}
