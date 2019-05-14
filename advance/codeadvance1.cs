using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

class Calculate_Sequence_with_Queue
{
    static void Main(string[] args)
    {
        long first = long.Parse(Console.ReadLine());
        var queue = new Queue<long>();
        var result = new List<long>();

        queue.Enqueue(first);
        result.Add(first);

        while (result.Count < 50)
        {
            long current = queue.Dequeue();
            queue.Enqueue(current + 1);
            queue.Enqueue(2 * current + 1);
            queue.Enqueue(current + 2);

            result.Add(current + 1);
            result.Add(2 * current + 1);
            result.Add(current + 2);
        }

        Console.WriteLine(String.Join(" ", result.Take(50)));
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

class Balanced_Parentheses
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var stack = new Stack<char>();
        bool isBalanced = true;

        foreach (var ch in input)
        {
            switch (ch)
            {
                case '(':
                case '{':
                case '[':
                    stack.Push(ch);
                    break;
                case ')':
                    if (!stack.Any() || stack.Pop() != '(')
                    {
                        isBalanced = false;
                    }
                    break;
                case '}':
                    if (!stack.Any() || stack.Pop() != '{')
                    {
                        isBalanced = false;
                    }
                    break;
                case ']':
                    if (!stack.Any() || stack.Pop() != '[')
                    {
                        isBalanced = false;
                    }
                    break;
            }
        }

        var result = isBalanced ? "YES" : "NO";
        Console.WriteLine(result);
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

class PeriodicTable
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var elements = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            var compounds = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ele in compounds)
            {
                if (!elements.Contains(ele))
                {
                    elements.Add(ele);
                }
            }
        }
        Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
    }
}


//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

class CountSymbols
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var symbolData = new SortedDictionary<char, int>();

        foreach (var c in input)
        {
            if (symbolData.ContainsKey(c))
            {
                symbolData[c] += 1;
            }
            else
            {
                symbolData.Add(c, 1);
            }
        }

        foreach (var res in symbolData)
        {
            Console.WriteLine($"{res.Key}: {res.Value} time/s");
        }
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

class WordCount
{
    private static void Main(string[] args)
    {
        StreamReader reader1 = new StreamReader(@"..\..\words.txt");
        StreamReader reader2 = new StreamReader(@"..\..\text.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        Console.WriteLine("Procesing sample text...");

        using (reader1)
        {
            using (reader2)
            {
                using (writer)
                {
                    StringBuilder sb1 = new StringBuilder();
                    StringBuilder sb2 = new StringBuilder();

                    var line = reader1.ReadLine();
                    while (line != null)
                    {
                        sb1.Append(line.ToLower() + " ");
                        line = reader1.ReadLine();
                    }

                    line = reader2.ReadLine();
                    while (line != null)
                    {
                        sb2.Append(line.ToLower() + " ");
                        line = reader2.ReadLine();
                    }

                    var wordsFileElements = sb1.ToString().Split(new[] { ' ', '!', '?', '.', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var textFileElements = sb2.ToString().Split(new[] { ' ', '!', '?', '.', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    var results = wordsFileElements.Intersect(textFileElements);

                    var dict = new Dictionary<string, int>();

                    foreach (var word in results)
                    {
                        var count = textFileElements.Where(x => x == word).Count();
                        dict[word] = count;
                    }

                    foreach (var entry in dict.OrderByDescending(d => d.Value))
                    {
                        writer.WriteLine($"{entry.Key} - {entry.Value}");
                    }
                }
            }
        }

        Console.WriteLine("Done.\nFile is located in the problem folder.");
    }
}

//The code can run, score 6;
//If the result is correct, score more 4.
//The reference code is as follows.

class CountSubstringOccurrences
{
    private static void Main(string[] args)
    {
        string inputText = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();

        int counter = 0;
        int index = inputText.IndexOf(pattern);
        while (index != -1)
        {
            counter++;
            index = inputText.IndexOf(pattern, index + 1);
        }

        Console.WriteLine(counter);
    }
}