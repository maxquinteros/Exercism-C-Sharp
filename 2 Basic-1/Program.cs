var lasagna = new Lasagna();
// 1.Define the expected oven time in minutes
Console.WriteLine(lasagna.ExpectedMinutesInOven());
// 2. Calculate the remaining oven time in minutes
Console.WriteLine(lasagna.RemainingMinutesInOven(30));
// 3. Calculate the preparation time in minutes
Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
// 4. Calculate the elapsed time in minutes
Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));