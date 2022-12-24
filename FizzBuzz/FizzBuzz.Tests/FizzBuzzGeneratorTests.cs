namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Test]
        public void Generate_APositiveNumberIsProvided_ReturnsTheFirstNFizzBuzzSequence()
        {
            FizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator();

            IEnumerable<string> fizzBuzzSequence = fizzBuzzGenerator.Generate(15);

            IEnumerable<string> expectedFizzBuzzSequence =
                new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.That(fizzBuzzSequence, Is.EqualTo(expectedFizzBuzzSequence));
        }
    }
}