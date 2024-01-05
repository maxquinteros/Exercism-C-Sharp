using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Bob
{
    public static class Bob
    {
        public static string Response (string statement)
        {
            statement = statement.Trim ();
            if (statement == "" || statement == null)
            {
                return "Fine. Be that way!";
            }
            else if (statement[^1] == '?')
            {
                return statement == statement.ToUpper() && statement.ToLower() != statement.ToUpper() ? "Calm down, I know what I'm doing!" : "Sure.";
            }
            else if (statement == statement.ToUpper() && statement.ToLower() != statement.ToUpper())
            {
                return "Whoa, chill out!";
            }   
            else
            {
                return "Whatever.";
            }
        }
    }
}
