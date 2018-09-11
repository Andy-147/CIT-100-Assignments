using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //For loop
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Value of i: " + i);

            }

            //Arrays
            //A way to hold multiple values of the same time in an ordered fashion
            double[] balance = new double[10]; //The 10 is the size or number of items in the array

            balance = new double[5] { 5, 10, 15, 20, 25 };

            Console.WriteLine("Balance Length: " + balance.Length);

            //Arrays start at index of zero 
            for (int i = 0; i <= balance.Length - 1; i++)
            {
                Console.WriteLine("i value: " + i);
                Console.WriteLine("Balance Value: " + balance[i]);
            }

            //You can initialize the array and pre-fill the values
            int[] marks = new int[5] { 5, 10, 15, 20, 25 };

            //To assign values of the array you can do:
            balance[0] = 10;

            balance[1] = 15;

            //To retrieve values you can do:
            double balanceReturned = balance[0];


            //Another kind of loop instead of a for loop is a foreach loop that allows you to
            //loop through the items in an array

            foreach (double b in balance)
            {
                Console.WriteLine(b);
            }

            Console.ReadLine();
        }
    }
}
