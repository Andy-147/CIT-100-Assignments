using System;

public class Program
{
    public static void Main()
	{
		int arrow = 3;
		int enemies = 3;
		bool legolaslives;
		
		
			Console.WriteLine("---------------------------------");
			Console.WriteLine("How many arrows are left? " + arrow);
			Console.WriteLine("");
			Console.WriteLine("How many enemies are left? " + enemies);
			Console.WriteLine("---------------------------------");
			Console.WriteLine("");
		
		
		for(int numberofarrows = 0; numberofarrows <= 3; numberofarrows++)
		{
			
			
			arrow--;
			
			enemies--;
			
			
			Console.WriteLine("---------------------------------");
			Console.WriteLine("How many arrows are left? " + arrow);
			Console.WriteLine("");
			Console.WriteLine("How many enemies are left? " + enemies);
			Console.WriteLine("---------------------------------");
			Console.WriteLine("");
			
			
		}
		
		if (enemies <= 0)
		{
			legolaslives = true;
			
		}  else{

			legolaslives = false


		}
		if (legolaslives)
		{
			Console.WriteLine("Legolas lives!");
		} else {

			Console.WriteLine("Legolas dies!")

		}
	
	}

}