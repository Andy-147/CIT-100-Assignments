using System;
using System.IO;

namespace Read_and_Write_to_a_file
{
    class Program
    {
        static void Main(string[] args)
        {

            // Check and see if a file exist
            if (!System.IO.File.Exists(@"C:\Users\austin-52511\Writing\test.txt"))
            {

                System.IO.File.Create(@"C:\Users\austin-52511\Writing\test.txt");
            }

            WriteToFile();
            ReadFromFile();


        }


        public static void ReadFromFile()
        {
            //Reading from a file
            string line = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\austin-52511\Writing\test.txt"))
            {
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }



        }

        public static void WriteToFile()
        {
            try
            {
                //Writing to a file

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(@"C:\Users\austin-52511\Writing\test.txt");

                //Write a line of text
                sw.WriteLine("Hello World!!");

                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");

                string answerToQuestion = Console.ReadLine();
                sw.WriteLine(answerToQuestion);

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}