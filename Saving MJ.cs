using System;


namespace SavingMJ
{
    class Program
    {
        static void Main(string[] args)
        {
            string playanswer;
            double webfluid = 100;
            double endurance = 100;
            double endurate;
            double webrate;
            double floorlevel = 0;
            double numoffloor = 0;
            string playchoice;

            Console.WriteLine(" Enter a number:");
            numoffloor = Convert.ToInt32(Console.ReadLine());

            if (numoffloor < 10)
            {
                numoffloor = 10;
            }

            Console.Clear();

            Setrate:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" What rate should Spiderman's web fluid deplete?");
            webrate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(" What rate should Spiderman's endurance decrease?");
            endurate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");

            Reenter:
            Console.WriteLine(" Spiderman's Web fluid will decrease at a rate of " + webrate + " for each floor.");
            Console.WriteLine(" Spiderman's endurance will decrease at a rate of " + endurate + " for each floor.");
            Console.WriteLine(" Are these the settings you want?");
            Console.WriteLine(" Enter Yes or No");
            playanswer = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Player Answer: " + playanswer);
            Console.WriteLine("");

            if (playanswer == "y" || playanswer == "Y" || playanswer == "yes")
            {
                playanswer = "Yes";
            }else if (playanswer == "n" || playanswer == "N" || playanswer == "no")
            {
                playanswer = "No";
            }





            switch (playanswer)
            {
                case ("Yes"):
                    Console.Clear();
                    Console.WriteLine("Applying Setting...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case ("No"):
                    Console.Clear();
                    goto Setrate;
                default:
                    Console.WriteLine(" Press Enter then type in Yes or No as an answer. Press Enter afterward.");
                    Console.ReadLine();
                    Console.Clear();
                    goto Reenter;
            }
                


            while ( floorlevel < numoffloor)
            {
                floorlevel++;

                Console.WriteLine("");
                Console.WriteLine("Spiderman: I need to get to the top floor!");
                Console.WriteLine("");
                Console.WriteLine("Should I use my web, or should I go up the stairs?");
                Console.WriteLine("Enter Web or Stairs");
                playchoice = Console.ReadLine();

                if (playchoice == "web"|| playchoice == "w" || playchoice == "W")
                {
                    playchoice = "Web";
                }else if (playchoice == "stairs"||playchoice == "s"|| playchoice == "S"|| playchoice == "stair" || playchoice == "Stair")
                {
                    playchoice = "Stairs";

                }
                else
                {
                    playchoice = "nothing";
                }


                switch (playchoice)
                {
                    case ("Web"):
                        webfluid = webfluid - webrate;
                        break;
                    case ("Stairs"):
                        endurance = endurance - endurate;
                        break;
                    default:
                        floorlevel--;
                        Console.WriteLine("I didn't go anywhere.");
                        Console.WriteLine("");
                        break;
                }


                Console.WriteLine("");
                Console.WriteLine("Floor Level: " + floorlevel);
                Console.WriteLine("Number of floors: " + numoffloor);
                Console.WriteLine("Webfluid left: " + webfluid);
                Console.WriteLine("Endurance left: " + endurance);
                Console.WriteLine("");


                
            }


            Console.WriteLine("End of Program");

            Console.ReadLine();
        }
    }
}
