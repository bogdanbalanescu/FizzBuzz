namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Test]
        public void Generate_APositiveNumberIsProvided_ReturnsTheFirstNFizzBuzzSequence()
        {
            FizzBuzzGenerator fizzBuzzGenerator = FizzBuzzGeneratorFactory.CreateFizzBuzzGenerator();

            IEnumerable<string> fizzBuzzSequence = fizzBuzzGenerator.Generate(15);

            IEnumerable<string> expectedFizzBuzzSequence =
                new string[] { 
                    "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.That(fizzBuzzSequence, Is.EqualTo(expectedFizzBuzzSequence));
        }

        [Test]
        public void Generate_APositiveNumberIsProvided_ReturnsTheFirstNEvenFizzBuzzSequence()
        {
            FizzBuzzGenerator fizzBuzzGenerator = FizzBuzzGeneratorFactory.CreateEvenFizzBuzzGenerator();

            IEnumerable<string> fizzBuzzSequence = fizzBuzzGenerator.Generate(30);

            IEnumerable<string> expectedFizzBuzzSequence =
                new string[] { 
                    "1", "Even", "Fizz", "Even", "Buzz", "EvenFizz", "7", "Even", "Fizz", "EvenBuzz", "11", "EvenFizz", "13", "Even", "FizzBuzz",
                    "Even", "17", "EvenFizz", "19", "EvenBuzz", "Fizz", "Even", "23", "EvenFizz", "Buzz", "Even", "Fizz", "Even", "29", "EvenFizzBuzz" };
            Assert.That(fizzBuzzSequence, Is.EqualTo(expectedFizzBuzzSequence));
        }

        [Test]
        public void Generate_APositiveNumberIsProvided_ReturnsTheFirstNOddEvenFizzBuzzSequence()
        {
            FizzBuzzGenerator fizzBuzzGenerator = FizzBuzzGeneratorFactory.CreateOddEvenFizzBuzzGenerator();

            IEnumerable<string> fizzBuzzSequence = fizzBuzzGenerator.Generate(30);

            IEnumerable<string> expectedFizzBuzzSequence =
                new string[] {
                    "Odd", "Even", "OddFizz", "Even", "OddBuzz", "EvenFizz", "Odd", "Even", "OddFizz", "EvenBuzz", "Odd", "EvenFizz", "Odd", "Even", "OddFizzBuzz",
                    "Even", "Odd", "EvenFizz", "Odd", "EvenBuzz", "OddFizz", "Even", "Odd", "EvenFizz", "OddBuzz", "Even", "OddFizz", "Even", "Odd", "EvenFizzBuzz" };
            Assert.That(fizzBuzzSequence, Is.EqualTo(expectedFizzBuzzSequence));
        }
    }
}