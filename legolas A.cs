using System;

public class Program
{
    public static void Main()
    {
        int arrow = 3;
        int enemies = 3;

        for (int numberofarrows = 0; numberofarrows <= arrow; numberofarrows++)
        {


            arrow--;

            enemies--;



            Console.WriteLine("How many arrows are left? " + arrow);
            Console.WriteLine("");
            Console.WriteLine("How many enemies are left? " + enemies);
            Console.WriteLine("---------------------------------");

        }

        if (enemies == 0)
        {
            Console.WriteLine("Legolas lives!");

        }
        if (enemies != 0)
        {
            Console.WriteLine("Legolas dies!");
        }
    }

}