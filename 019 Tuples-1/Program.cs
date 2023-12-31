using Exercise.PhoneNumber;

// Task 1: Analyze a phone number
Console.WriteLine(PhoneNumber.Analyze("631-555-1234")); // => (false, true, "1234")

// Task 2: Detect if a phone number has a fake prefix code (555)
Console.WriteLine(PhoneNumber.IsFake(PhoneNumber.Analyze("631-555-1234"))); // => true