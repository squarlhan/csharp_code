using System;


//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.

class DeclareVar
{
    static void Main(string[] args)
    {
        //52130, -115, 4825932, 97, -10000. 
        ushort var1 = 52130;
        sbyte var2 = -115;
        int var3 = 4825932;
        byte var4 = 97;
        short var5 = -10000;
        Console.WriteLine("Desired result: 52130, -115, 4825932, 97, -10000");
        Console.WriteLine("Actual result: {0}, {1}, {2}, {3}, {4}", var1, var2, var3, var4, var5);
    }
}


//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.

class FloatOrDouble
{
    static void Main(string[] args)
    {
        //34.567839023, 12.345, 8923.1234857, 3456.091
        double var1 = 34.567839023d;
        float var2 = 12.345f;
        double var3 = 8923.1234857d;
        float var4 = 3456.091f;
        Console.WriteLine("Desired result: 34.567839023, 12.345, 8923.1234857, 3456.091");
        Console.WriteLine("Actual result: {0}, {1}, {2}, {3}", var1, var2, var3, var4);
    }
}


//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.

class Quotes
{
    static void Main(string[] args)
    {
        string notQuotedStr = "The \"use\" of quotations causes difficulties.";
        string quotedStr = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(notQuotedStr + "\n" + quotedStr);
    }
}



//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.

class IsoTriangle
{
    static void Main(string[] args)
    {
        //char mark = '\u00A9'; // Unicode of the copyright symbol.
        //Console.WriteLine(mark);
        Console.WriteLine(@" 
	   ©
	  © ©
	 ©   ©
	© © © ©
	        ");
    }
}



//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.

class NullVal
{
    static void Main(string[] args)
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("integer: {0}\ndouble: {1}", a, b);
        a += null;
        b += 0.63;
        Console.WriteLine("After accumulation:\ninteger: {0}\ndouble: {1}", a, b);
    }
}



//The code can run, score 5;
//If the result is correct, score more 5.
//The reference code is as follows.

class ComparingFloats
{
    static bool compare(double a, double b) // method witch takes 2 double's and returning boolean
    {
        double eps = 0.000001d;
        double sub;
        sub = Math.Abs(a - b);
        return sub < eps;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Comparing 5.3 and 6.01. Expected - False");
        Console.WriteLine(compare(5.3, 6.01));
        Console.WriteLine("Comparing 5.00000001 and 5.00000003. Expected - True");
        Console.WriteLine(compare(5.00000001, 5.00000003));
        Console.WriteLine("Comparing 5.00000005 and 5.00000001. Expected - True");
        Console.WriteLine(compare(5.00000005, 5.00000001));
        Console.WriteLine("Comparing -0.0000007 and 0.00000007. Expected - True");
        Console.WriteLine(compare(-0.0000007, 0.00000007));
        Console.WriteLine("Comparing -4.999999 and -4.999998. Expected - False");
        Console.WriteLine(compare(-4.999999, -4.999998));
        Console.WriteLine("Comparing 4.999999 and 4.999998. Expected - False");
        Console.WriteLine(compare(4.999999, 4.999998));
    }
}



//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.

class asciiTable
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} is {1}", i, (char)i /*Convert.ToChar(i)*/);
        }
    }
}


//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.
// float and double's are entered with "," in the console
class CircleAreaAndPerimeter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter radius:");
        double r = float.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(r, 2);
        double perimeter = 2 * Math.PI * r;
        Console.WriteLine("Perimeter = {0:F2}\nArea = {1:F2}", perimeter, area);
    }
}


//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.
// float and double's are entered with "," in the console
class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter first number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number:");
        double thirdNum = double.Parse(Console.ReadLine());
        string binaryFirstNum = Convert.ToString(firstNum, 2);
        Console.WriteLine("{0,-10:X} {1,10} {2,10:0.##} {3,-10:0.###}",
        firstNum, binaryFirstNum.PadLeft(10, '0'), secondNum, thirdNum);
    }
}


//The code can run, score 3;
//If the result is correct, score more 2.
//The reference code is as follows.


class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter length of the line: ");
        int n = int.Parse(Console.ReadLine());
        ulong firstNumber = 0;
        ulong secondNumber = 1;
        ulong nextNumber = new int();
        Console.WriteLine("First {0} of Fibonacci numbers", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(firstNumber + " ");
            nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
        Console.WriteLine();
    }
}


//The code can run, score 5;
//If the result is correct, score more 5.
//The reference code is as follows.

class MagicWand
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}",//THE 1ST PART - STATIC - ONE ROW
            new string('.', (n * 3 + 1) / 2));

        for (int i = 0; i < (n / 2 + 1); i++)//THE 2ND PART (DYNAMIC + FOR LOOP)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', ((n * 3 + 1) / 2) - 1 - i),
                new string('.', 1 + 2 * i));
        }

        Console.WriteLine("{0}{1}{0}",//THE 3RD PART - STATIC - ONE ROW
            new string('*', (n)),
            new string('.', (n + 2)));

        for (int i = 0; i < n / 2; i++)//THE 4TH PART (DYNAMIC + FOR LOOP)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', 1 + i),
                new string('.', 3 * n - 2 - 2 * i));
        }

        for (int i = 0; i < n / 2; i++)//THE 5TH PART (DYNAMIC + FOR LOOP)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                new string('.', n / 2 - 1 - i),
                new string('.', n / 2),
                new string('.', 0 + i),
                new string('.', n));
        }
        Console.WriteLine("{0}{1}*{2}*{1}{0}",//THE 6TH PART - STATIC - ONE ROW
                new string('*', n / 2 + 1),
                new string('.', n / 2),
                new string('.', n));

        for (int i = 0; i < n; i++)//THE 7TH PART (DYNAMIC + FOR LOOP)
        {
            Console.WriteLine("{0}*{0}*{0}",
                new string('.', n));
        }
        Console.WriteLine("{0}{1}{0}",//THE 8TH PART - STATIC - ONE ROW
            new string('.', n),
            new string('*', n + 2));
    }
}

