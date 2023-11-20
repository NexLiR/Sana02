using System;
using System.Transactions;

class Program
{
    static void Main()
    {
        double grade, sum = 0, count = 0, avg;
        Console.WriteLine("Enter 5 student grades on a 100-point scale:");
        do
        {
            grade = double.Parse(Console.ReadLine());
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Entered value is out of range");
                continue;
            }
            sum += grade;
            count++;
        } while (count != 5);
        avg = sum / count;
        Console.WriteLine("Student average grade: {0}", avg);
        if (avg >= 50) Console.WriteLine("Student is admitted to take exam");
        else Console.WriteLine("Student is not allowed to take exam");
    }
}