namespace S_GroupTask
{
    public static class Algorithm
    {
        public static int CalculateSum(int[] numbers)
        {
            return numbers.Sum();
        }

        public static int CalculateSumEven(int[] numbers)
        {
            return numbers.Where(num => num % 2 == 0).Sum();
        }
    }
}
