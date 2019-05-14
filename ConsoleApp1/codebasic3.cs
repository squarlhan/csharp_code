using System;
using System.Collections.Generic;
using System.Text;

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool thirdDigitIs7 = (n / 100) % 10 == 7;
        Console.WriteLine(thirdDigitIs7);
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class PointInsideACircleOutsideOfARectangle
{
    static void Main()
    {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());

        if (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5) && (x < -1 || x > 5 || y < -1 || y > 1))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class ExtractBitFromInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        n >>= p;
        int bitAtPositionP = n & 1;
        Console.WriteLine(bitAtPositionP);
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask1 = 7 & (n >> 3);
        uint mask2 = 7 & (n >> 24);
        n &= 4177526783;
        n |= mask1 << 24;
        n &= 4294967239;
        n |= mask2 << 3;
        Console.WriteLine(n);
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        if (score >= 1 && score <= 3)
        {
            score *= 10;
            Console.WriteLine(score);
        }
        else if (score >= 4 && score <= 6)
        {
            score *= 100;
            Console.WriteLine(score);
        }
        else if (score >= 7 && score <= 9)
        {
            score *= 1000;
            Console.WriteLine(score);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter a number (0-999): ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0 && number <= 999)
        {
            switch (number / 100)
            {
                case 0: break;
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }

            if (number / 100 != 0 && number % 100 != 0 && number % 100 > 9)
            {
                Console.Write("and ");
            }

            switch ((number / 10) % 10)
            {
                case 0: break;
                case 1:
                    switch (number % 10)
                    {
                        case 0: Console.Write("ten"); break;
                        case 1: Console.Write("eleven"); break;
                        case 2: Console.Write("twelve"); break;
                        case 3: Console.Write("thirteen"); break;
                        case 4: Console.Write("fourteen"); break;
                        case 5: Console.Write("fifteen"); break;
                        case 6: Console.Write("sixteen"); break;
                        case 7: Console.Write("seventeen"); break;
                        case 8: Console.Write("eighteen"); break;
                        case 9: Console.Write("nineteen"); break;
                    }
                    break;
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;

            }
            if (number / 10 % 10 == 0 && number % 100 != 0)
            {
                Console.Write("and ");
            }

            if ((number / 10) % 10 != 1)
            {
                switch (number % 10)
                {
                    case 0:
                        if (number == 0)
                            Console.Write("Zero");
                        break;
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;
                }
            }
        }
        else
        {
            Console.Write("Number too big or too small! ");
        }
        Console.WriteLine();
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class PrintADeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2: Console.Write("2"); break;
                    case 3: Console.Write("3"); break;
                    case 4: Console.Write("4"); break;
                    case 5: Console.Write("5"); break;
                    case 6: Console.Write("6"); break;
                    case 7: Console.Write("7"); break;
                    case 8: Console.Write("8"); break;
                    case 9: Console.Write("9"); break;
                    case 10: Console.Write("10"); break;
                    case 11: Console.Write("J"); break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;
                    default: Console.WriteLine("Invalid data!"); break;
                }

                switch (j)
                {
                    case 1: Console.Write('\u2663'); break;
                    case 2: Console.Write('\u2666'); break;
                    case 3: Console.Write('\u2665'); break;
                    case 4: Console.Write('\u2660'); break;
                    default: Console.WriteLine("Invalid data!"); break;
                }

                if (i == 10)
                {
                    continue;
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class PRandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rand = new Random();
        for (int i = 1; i <= n; i++)
        {
            int number = rand.Next(min, max + 1);
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class DecimalToBinaryNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine(0);
            return;
        }
        BigInteger multiplier = 1;
        BigInteger nBinary = 0;
        int binaryDigit = 0;
        while (n > 0)
        {
            binaryDigit = n % 2;
            nBinary += binaryDigit * multiplier;
            multiplier *= 10;
            n /= 2;
        }
        if (binaryDigit == 0)
        {
            nBinary += multiplier;
        }
        string binary = nBinary.ToString();
        Console.WriteLine(binary);
    }
}

//The code can run, score 3;
//If the result is correct, score more 4.
//The reference code is as follows.

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a < 0)
            a *= -1;
        if (b < 0)
            b *= -1;
        if (a == 0)
        {
            Console.WriteLine(b);
            return;
        }
        if (b == 0)
        {
            Console.WriteLine(a);
            return;
        }
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        Console.WriteLine(a);
    }
}
