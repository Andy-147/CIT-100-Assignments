using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playbook_Program_B
{
    class Program
    {
        static void Main(string[] args)
        {

            ScoreOption1 scoreOption1 = new ScoreOption1();

            //Startup Menu

            string userinputA;

            StartupMenu:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Start Menu");
            Console.WriteLine("");
            Console.WriteLine(" Which file would you like to access?");
            Console.WriteLine("");
            Console.WriteLine("   1. Plays ");
            Console.WriteLine("   2. Terms and Definitions ");
            Console.WriteLine("   3. Scores ");
            Console.WriteLine("   4. Other ");
            Console.WriteLine("   5. Exit ");
            Console.WriteLine("");

            Error: userinputA = Console.ReadLine();
            
            
            switch (userinputA)
            {
                case ("1"):
                    Console.WriteLine("  -User chose Plays-  ");
                    break;
                case ("plays"):
                    Console.WriteLine("  -User chose Plays-  ");
                    break;
                case ("2"):
                    Console.WriteLine("  -User chose T & D-  ");
                    break;
                case ("terms"):
                    Console.WriteLine("  -User chose T & D-  ");
                    break;
                case ("define"):
                    Console.WriteLine("  -User chose T & D-  ");
                    break;
                case ("3"):
                    Console.WriteLine("  -User chose Scores-  ");
                    scoreOption1.GetScores();
                    break;
                case ("scores"):
                    Console.WriteLine("  -User chose Scores-  ");
                    break;
                case ("4"):
                    Console.WriteLine("  -User chose Other-  ");
                    break;
                case ("other"):
                    Console.WriteLine("  -User chose Other-  ");
                    break;
                case ("5"):
                    Console.WriteLine("  -User chose Exit-  ");
                    goto Leave;
                default:
                    Console.WriteLine("  -User didn't make a selection- ");
                    Console.WriteLine("   Please try again. ");
                    Console.WriteLine("");
                    goto Error;
            }

            goto StartupMenu;

            Leave:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Thank you and have a nice day.");
            

            Console.ReadLine();

           
            
        }
    }


    class Terms
    {
        public void Definitions()
        {
            Console.WriteLine("Here are the definitions.");
            Console.Clear();



        }

    }

    class ScoreOption1
    {
        public void GetScores()
        {
            Console.WriteLine("Scores are numbers.");
            Console.ReadLine();
        }
    }
}

