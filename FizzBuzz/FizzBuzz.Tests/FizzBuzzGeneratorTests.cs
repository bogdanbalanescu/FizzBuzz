namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Test]
        public void Generate_APositiveNumberIsProvided_ReturnsTheFirstNFizzBuzzSequence()
        {
            FizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator(new List<Func<int, string>>
            {
                x => x % 3 == 0 ? "Fizz" : string.Empty,
                x => x % 5 == 0 ? "Buzz" : string.Empty
            });

            IEnumerable<string> fizzBuzzSequence = fizzBuzzGenerator.Generate(15);

            IEnumerable<string> expectedFizzBuzzSequence =
                new string[] { 
                    "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.That(fizzBuzzSequence, Is.EqualTo(expectedFizzBuzzSequence));
        }

        [Test]
        public void Generate_APositiveNumberIsProvided_ReturnsTheFirstNEvenFizzBuzzSequence()
        {
            FizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator(new List<Func<int, string>>
            {
                x => x % 2 == 0 ? "Even" : string.Empty,
                x => x % 3 == 0 ? "Fizz" : string.Empty,
                x => x % 5 == 0 ? "Buzz" : string.Empty,
            });

            IEnumerable<string> fizzBuzzSequence = fizzBuzzGenerator.Generate(30);

            IEnumerable<string> expectedFizzBuzzSequence =
                new string[] { 
                    "1", "Even", "Fizz", "Even", "Buzz", "EvenFizz", "7", "Even", "Fizz", "EvenBuzz", "11", "EvenFizz", "13", "Even", "FizzBuzz",
                    "Even", "17", "EvenFizz", "19", "EvenBuzz", "Fizz", "Even", "23", "EvenFizz", "Buzz", "Even", "Fizz", "Even", "29", "EvenFizzBuzz" };
            Assert.That(fizzBuzzSequence, Is.EqualTo(expectedFizzBuzzSequence));
        }
    }
}