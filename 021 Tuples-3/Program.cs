using Exercism.PythagoreanTriplet;

// Test 1: Triplets whose sum is 12 => (3, 4, 5)
Console.WriteLine("Test 1:");
foreach (var triplet in PythagoreanTriplet.TripletsWithSum(12))
{
    Console.WriteLine($"a: {triplet.a}, b: {triplet.b}, c: {triplet.c}");
}
Console.WriteLine("");

// Test 2: Triplets whose sum is 108 => (27, 36, 45)
Console.WriteLine("Test 2:");
foreach (var triplet in PythagoreanTriplet.TripletsWithSum(108))
{
    Console.WriteLine($"a: {triplet.a}, b: {triplet.b}, c: {triplet.c}");
}
Console.WriteLine("");

// Test 3: Triplets whose sum is 1000 => (200, 375, 425)
Console.WriteLine("Test 3:");
foreach (var triplet in PythagoreanTriplet.TripletsWithSum(1000))
{
    Console.WriteLine($"a: {triplet.a}, b: {triplet.b}, c: {triplet.c}");
}
Console.WriteLine("");

// Test 4: No matching triplets for 1001
Console.WriteLine("Test 4:");
foreach (var triplet in PythagoreanTriplet.TripletsWithSum(1001))
{
    Console.WriteLine($"a: {triplet.a}, b: {triplet.b}, c: {triplet.c}");
}
Console.WriteLine("");

// Test 5: Returns all matching triplets => (9, 40, 41), (15, 36, 39)
Console.WriteLine("Test 5:");
foreach (var triplet in PythagoreanTriplet.TripletsWithSum(90))
{
    Console.WriteLine($"a: {triplet.a}, b: {triplet.b}, c: {triplet.c}");
}
Console.WriteLine("");

// Test 6: Several matching triplets => (40, 399, 401), (56, 390, 394), (105, 360, 375), (120, 350, 370), (140, 336, 364), (168, 315, 357), (210, 280, 350), (240, 252, 348)
Console.WriteLine("Test 6:");
foreach (var triplet in PythagoreanTriplet.TripletsWithSum(840))
{
    Console.WriteLine($"a: {triplet.a}, b: {triplet.b}, c: {triplet.c}");
}
Console.WriteLine("");

// Test 7: Triplets for large number => (1200, 14375, 14425), (1875, 14000, 14125), (5000, 12000, 13000), (6000, 11250, 12750), (7500, 10000, 12500)
Console.WriteLine("Test 7:");
foreach (var triplet in PythagoreanTriplet.TripletsWithSum(30000))
{
    Console.WriteLine($"a: {triplet.a}, b: {triplet.b}, c: {triplet.c}");
}