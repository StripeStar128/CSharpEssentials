using System;
					
public class Program
{
	public void Main(string[] args)
	{
		Random random = new Random();
		
			int returnValue = random.Next(1, 10);
			int Guess = 0;
			int numGuesses = 0;
		
			Console.WriteLine("I am thinking of a number between 1-10. Can you guess what it is?");
		
			while (Guess != returnValue) //This is a while loop, It starts when the specified condition is true.
			{
				Guess = Convert.ToInt32(Console.ReadLine());
				{
					numGuesses++; //This is what incresses the number of guesses it took to guess the number.
					if (Guess < returnValue) //Block of code that is executed when it is true
					{
						Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Can you guess what it is?");
					}
					else if (Guess > returnValue) //Block of code that is executed when the first condition is false
					{
						Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Can you guess what it is?");
					}
				}
			}
			Console.WriteLine("Well done! The answer was " + returnValue + ".\nYou took " + numGuesses + " guesses.");
	}
}