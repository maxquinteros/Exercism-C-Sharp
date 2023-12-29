using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.LogAnalysis
{
    public static class LogAnalysis
    {
        // Task 1: Allow retrieving the string after a specific substring
        public static string SubstringAfter(this string str, string v)
        {
            int index = str.IndexOf(v) + v.Length;
            return(str[index..]);
        }

        // Task 2: Allow retrieving the string in between two substrings
        public static string SubstringBetween(this string str, string v1, string v2)
        {
            int openingPosition = str.IndexOf(v1) + v1.Length;
            int closingPosition = str.IndexOf(v2);
            int lenght = closingPosition - openingPosition;

            return (str.Substring(openingPosition, lenght));
        }

        // Task 3: Parse message in a log
        public static string Message(this string str)
        {
            int index = str.IndexOf(": ") + 2;
            return (str[index..]);
        }

        // Task 4: Parse log level in a log
        public static string LogLevel(this string str)
        {
            int openingPosition = str.IndexOf('[') + 1;
            int closingPosition = str.IndexOf(']');
            int lenght = closingPosition - openingPosition;

            return (str.Substring(openingPosition, lenght));
        }
    }

}
