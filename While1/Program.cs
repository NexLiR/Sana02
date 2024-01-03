using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        double a, b, c;
        int n = 0;
        Console.WriteLine("Enter a value for n");
        do
        {
            n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("n must be a positive number");
                continue;
            }
        } while (n <= 0);
        a = expression1(n);
        b = expression2(n);
        c = expression3(n);
        Console.WriteLine("a = -1/3 + 1/5 + ... + (-1)^n/(2*n+1) = {0}", a);
        Console.WriteLine("b = (1+1/1^2) + (1+1/2^2) + ... + (1+1/n^2) = {0}", b);
        Console.WriteLine("c = 1! + 2! + ... + n! = {0}", c);
    }

    static double expression1(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(-1, i) / (2 * i + 1);
        }
        return sum;
    }
    static double expression2(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1 + 1.0 / Math.Pow(i, 2);
        }
        return sum;
    }
    static double expression3(int n)
    {
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += calcFactorial(i);
        }
        return sum;
    }

    static int calcFactorial(int i) 
    {
        if (i < 0)
        { 
            throw new Exception("Factorial of negative number is undefined");
        }
        if (i == 0 || i == 1)
        {
            return 1;
        }
        else
        {
            return i * calcFactorial(i - 1);
        }
    }
}