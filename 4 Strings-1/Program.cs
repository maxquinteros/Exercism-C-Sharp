using Exercise.LogLine;

// Task 1: Get message from a logg line
Console.WriteLine(LogLine.Message("[ERROR]: Invalid operation"));
Console.WriteLine(LogLine.Message("[WARNING]:  Disk almost full\r\n"));

// Task 2: Get log level from a log line
Console.WriteLine(LogLine.LogLevel("[ERROR]: Invalid operation"));

// Task 3: Reformat a log line
Console.WriteLine(LogLine.Reformat("[INFO]: Operation completed"));