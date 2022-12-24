namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public IEnumerable<string> Generate(int n)
        {
            return Enumerable.Range(1, n)
                .Select(x =>
                {
                    string fizzBuzzElement = $"{FizzOrEmpty(x)}{BuzzOrEmpty(x)}";

                    return fizzBuzzElement != string.Empty ? fizzBuzzElement : x.ToString();
                });
        }

        private string FizzOrEmpty(int x) => x % 3 == 0 ? "Fizz" : string.Empty;
        private string BuzzOrEmpty(int x) => x % 5 == 0 ? "Buzz" : string.Empty;
    }
}