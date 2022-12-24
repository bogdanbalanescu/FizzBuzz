namespace FizzBuzz
{
    public static class FizzBuzzGeneratorFactory
    {
        public static FizzBuzzGenerator CreateFizzBuzzGenerator() =>
            new FizzBuzzGenerator(new List<Func<int, string>>
            {
                x => x % 3 == 0 ? "Fizz" : string.Empty,
                x => x % 5 == 0 ? "Buzz" : string.Empty
            });

        public static FizzBuzzGenerator CreateEvenFizzBuzzGenerator() =>
            new FizzBuzzGenerator(new List<Func<int, string>>
            {
                x => x % 2 == 0 ? "Even" : string.Empty,
                x => x % 3 == 0 ? "Fizz" : string.Empty,
                x => x % 5 == 0 ? "Buzz" : string.Empty,
            });
    }
}
