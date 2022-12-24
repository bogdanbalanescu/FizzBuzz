namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private List<Func<int, string>> numberToWordMappers;

        public FizzBuzzGenerator(List<Func<int, string>> numberToWordMappers)
        {
            this.numberToWordMappers = numberToWordMappers;
        }

        public IEnumerable<string> Generate(int n)
        {
            return Enumerable.Range(1, n)
                .Select(x =>
                {
                    string fizzBuzzElement = string.Join("",
                        numberToWordMappers.Select(numberToWordMapper => numberToWordMapper(x)));

                    return fizzBuzzElement != string.Empty ? fizzBuzzElement : x.ToString();
                });
        }
    }
}