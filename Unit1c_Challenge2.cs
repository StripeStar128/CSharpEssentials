using System;
					
public class Program
{
	public void Main(string[] args)
	{
		System.Console.WriteLine("What are 3 of your favorite foods? Write them one at a time.");
			string [] favFoods = new string[3];
			for (int i = 0; i < 3; 	i++)
			{
				favFoods[i] = System.Console.ReadLine(); //This reads the line and stores it in the array
			}
		
			System.Console.ReadLine();
			foreach(string food in favFoods)
			{
				Console.WriteLine("I love " + food + "."); //This prints the different items from the array
			}
	}
}