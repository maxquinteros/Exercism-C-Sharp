namespace Exercise.LogLine
{
    public static class LogLine
    {
        // Task 1: Get message from a logg line
        public static string Message(string logLine)
        {
            int closingPosition = logLine.IndexOf(' ');
            return (logLine[closingPosition..].Trim());
        }

        // Task 2: Get log level from a log line
        public static string LogLevel(string logLine)
        {
            int startPosition = logLine.IndexOf('[') + 1;
            int closingPosition = logLine.IndexOf(']');
            int length = closingPosition - startPosition;
            return (logLine.Substring(startPosition, length).ToLower());
        }

        // Task 3: Reformat a log line
        public static string Reformat(string logLine)
        {
            int spacePosition = logLine.IndexOf(' ');
            int startPosition = logLine.IndexOf('[') + 1;
            int closingPosition = logLine.IndexOf(']');
            int length = closingPosition - startPosition;

            return ($"{logLine[spacePosition..].Trim()} ({logLine.Substring(startPosition, length).ToLower()})");
        }
    }
}
