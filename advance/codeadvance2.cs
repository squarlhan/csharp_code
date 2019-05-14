using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace ExtractEmail
{
    class ExtractEmail
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"(?<=\s|^)[a-z0-9]+(?:[-._][a-z0-9]+)*@[a-z0-9]+(?:[-][a-z0-9]*)*\.[a-z]+(?:\.[a-z]+)*";

            Regex rgx = new Regex(pattern);

            var match = rgx.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match);

                match = match.NextMatch();
            }
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        private static void Main(string[] args)
        {
            var pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""""]*)""|([^\s>]+))[^>]*>";

            var regx = new Regex(pattern);

            var input = Console.ReadLine();

            var sb = new StringBuilder();

            while (input != "END")
            {
                sb.AppendLine(input);

                input = Console.ReadLine();
            }

            var matches = regx.Matches(sb.ToString());

            foreach (Match match in matches)
            {
                for (int group = 1; group <= 3; group++)
                {
                    if (match.Groups[group].Length > 0)
                    {
                        Console.WriteLine(match.Groups[group]);
                    }
                }
            }
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        private static void Main(string[] args)
        {
            Action<string> printSir = (x) => Console.WriteLine(string.Concat("Sir ", x));

            Console.ReadLine().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(w => printSir(w));
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace CustomMinFunction
{
    class CustomMinFunction
    {
        private static void Main(string[] args)
        {
            Func<List<int>, int> min = (n) => n.Min();

            var numbers = Console.ReadLine().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Console.WriteLine(min(numbers));
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        private static void Main(string[] args)
        {
            Predicate<int> isEven = (n) => n % 2 == 0;

            var rangeArgs = Console.ReadLine().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var start = rangeArgs[0];
            var end = rangeArgs[1];
            var count = (end - start) + 1;

            var numbers = new List<int>(Enumerable.Range(start, count));

            var oddEven = Console.ReadLine();

            if (oddEven == "odd")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(n => isEven(n) == false)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(n => isEven(n) == true)));
            }
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

namespace CustomComparator
{
    class CustomComparator
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var evenNumbers = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            var oddNumber = numbers.Where(x => x % 2 != 0).OrderBy(x => x).ToList();

            evenNumbers.AddRange(oddNumber);
            Console.WriteLine(string.Join(" ", evenNumbers));
        }
    }
}