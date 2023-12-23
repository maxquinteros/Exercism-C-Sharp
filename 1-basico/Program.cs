using _1_basico;

var lasagna = new Lasagna();

// Define the expected oven time in minutes
Console.WriteLine(lasagna.ExpectedMinutesInOven());
// Calculate the remaining oven time in minutes
Console.WriteLine(lasagna.RemainingMinutesInOven(30));
// Calculate the preparation time in minutes
Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
// Calculate the elapsed time in minutes
Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));
