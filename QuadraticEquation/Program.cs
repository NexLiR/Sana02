using System;

class Program
{
    static void Main()
    {
        double a, b, c, D, x1, x2;
        Console.Write("Enter a value for variables: \na = ");
        a = double.Parse(Console.ReadLine());   
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        if (a <= 0) Console.Write("It is not quadratic equation");
        else
        {
            D = Math.Pow(b, 2) + 4 * a * c;
            Console.WriteLine("Discriminator = {0}", D);
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("x = {0}", x1);
            }
            else Console.WriteLine("The equation has no roots");
        }
    }
}