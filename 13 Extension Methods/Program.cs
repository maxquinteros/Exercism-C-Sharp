using Exercise.LogAnalysis;

// Task 1: Allow retrieving the string after a specific substring
var log = "[INFO]: File Deleted.";
Console.WriteLine(log.SubstringAfter(": ")); // => returns "File Deleted."

// Task 2: Allow retrieving the string in between two substrings
Console.WriteLine(log.SubstringBetween("[", "]")); // => returns "INFO"

// Task 3: Parse message in a log
log = "[ERROR]: Missing ; on line 20.";
Console.WriteLine(log.Message()); // => returns "Missing ; on line 20."

// Task 4: Parse log level in a log
Console.WriteLine(log.LogLevel()); // => returns "ERROR"