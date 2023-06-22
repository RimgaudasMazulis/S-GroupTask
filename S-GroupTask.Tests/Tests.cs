namespace S_GroupTask.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly string Numbers = "1,2,3,B,5,6,7,8,A,10";
        private readonly int[] ParsedNumbers = new int[] { 1, 2, 3, 5, 6, 7, 8, 10 };

        [Test]
        public void ParseNumbers_ReturnsNumbers()
        {
            var expected = new[] { 1, 2, 3, 5, 6, 7, 8, 10 };

            var result = ParseHelper.ParseNumbers(Numbers);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CalculateSum_ValidInput_ReturnsSum()
        {
            var result = Algorithm.CalculateSum(ParsedNumbers);

            Assert.AreEqual(42, result);
        }


        [Test]
        public void CalculateSumEven_ValidInput_ReturnsSum()
        {
            var result = Algorithm.CalculateSumEven(ParsedNumbers);

            Assert.AreEqual(26, result);
        }

        [Test]
        public void CalculateSum_ValidInput_IgnoresNonNumericValues()
        {
            var parsedNumbers = ParseHelper.ParseNumbers(Numbers);
            var result = Algorithm.CalculateSum(parsedNumbers);

            Assert.AreEqual(42, result);
        }

        [Test]
        public void CalculateSumEven_ValidInput_IgnoresNonNumericValues()
        {
            var parsedNumbers = ParseHelper.ParseNumbers(Numbers);
            var result = Algorithm.CalculateSumEven(parsedNumbers);

            Assert.AreEqual(26, result);
        }
    }
}