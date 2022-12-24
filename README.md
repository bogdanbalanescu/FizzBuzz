# FizzBuzz kata

Given a number N, return a list of numbers one-to-N, where:
- every number divisible by three is replaced with "Fizz",
- every number divisible by five is replaced with "Buzz",
- and every number divisible by both three and five is replaced with "FizzBuzz".

## New requirements

Suppose a new rule was added to FizzBuzz, which stated that:
- every even number shall be replaced with "Even",
- every even number which is also "Fizz" shall be replaced with "EvenFizz",
- every even number which is also "Buzz" shall be replaced with "EvenBuzz",
- and every even number which is also "FizzBuzz", shall be replaced with "EvenFizzBuzz".

How would this new requirement impact/change the original implementation?

### Other new requirements

Suppose that yet another rule was added to FizzBuzz, which stated that:
- every odd number shall be replaced with "Odd",
- every odd number which is also "Fizz" shall be replaced with "OddFizz",
- every odd number which is also "Buzz" shall be replaced with "OddBuzz",
- and every odd number which is also "FizzBuzz", shall be replaced with "OddFizzBuzz".

How would this new requirement impact/change the original implementation?

What if yet another rule was to be added, that would cover prime numbers?

What if there was a need to add/remove rules dynamically? How would that impact/change the design?