using System;

namespace WebLayer
{ 

public class FibonacciSeries
{
    public static void GenerateFibonacciSeries(int n)
    {
        int firstNum = 0, secondNum = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(firstNum + " ");

            int nextNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = nextNum;

            if (firstNum > n)
                break;
        }

        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number up to which you want to generate the Fibonacci series: ");
        int number = Convert.ToInt32(Console.ReadLine());

        GenerateFibonacciSeries(number);
    }
}
}

