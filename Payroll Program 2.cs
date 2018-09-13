using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrsalary;
            int hrtime;
            int grosspay;
            double taxes;
            double netpay;
            string userinput;
            int howudo = 0;
            
        

            while (howudo == 0)
            {

                // Input
                Console.WriteLine("What is your hourly salary?");
                hrsalary = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many hours did you work?");
                hrtime = Convert.ToInt32(Console.ReadLine());


                //Process

                grosspay = hrsalary * hrtime;

                taxes = grosspay * 0.1;

                netpay = grosspay - taxes;

                //Output
                Console.WriteLine("");
                Console.WriteLine("This is your taxes: " + taxes);
                Console.WriteLine("");
                Console.WriteLine("This is your grosspay: " + grosspay);
                Console.ReadLine();



                Console.WriteLine("Would you like to continue?");
                Console.WriteLine("(Yes = Y) (No = N)");
                userinput = Console.ReadLine();

                if (userinput == "y" || userinput == "Y")
                {
                    howudo = 0;
                }
                else if (userinput == "n" || userinput == "N")
                {
                    howudo = 1;
                }
                else
                {
                    Console.WriteLine("Bye");
                    howudo = 2;
                }
                
                while (howudo == 2)
                {
                    Console.WriteLine("Enter a 'y' for yes or a 'n' for no.");
                    userinput = Console.ReadLine();

                    if (userinput == "y" || userinput == "Y")
                    {
                        howudo = 0;
                    }
                    else if (userinput == "n" || userinput == "N")
                    {
                        howudo = 1;
                    }
                    else
                    {
                        howudo = 2;
                    }


                }

            }
            Console.ReadLine();
        }
    }
}
