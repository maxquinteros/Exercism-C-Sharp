namespace Exercism.PythagoreanTriplet
{
    public static class PythagoreanTriplet
    {
        public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        {
            (int, int, int) result;

            result.Item1 = 1;
            result.Item2 = sum / 3;
            result.Item3 = sum / 2;

            while (result.Item1 < result.Item3)
            {
                while (result.Item2 != result.Item3)
                {
                    result.Item2 = sum - result.Item1 - result.Item3;
                    if (result.Item1 * result.Item1 + result.Item2 * result.Item2 == result.Item3 * result.Item3 && result.Item1 < result.Item2 && result.Item1 < result.Item3 && result.Item2 < result.Item3 && result.Item1 + result.Item2 + result.Item3 == sum)
                    {
                        yield return result;
                        break;
                    }
                    result.Item3--;
                    result.Item2 = result.Item1;
                }
                result.Item1++;
                result.Item2 = result.Item1 + 1;
                result.Item3 = sum / 2;
            }
        }
    }
}