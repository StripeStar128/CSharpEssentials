using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Input todays temperture in Celsius: ");
		string todayTemp = Console.ReadLine();
		Console.WriteLine("Todays temperture is: " + todayTemp);
		Temperature(Convert.ToInt32(Console.ReadLine()));
		Console.WriteLine("What is your grade(percent): ");
		string yourGrade = Console.ReadLine();
		Console.WriteLine("Your grade is: " + yourGrade);
		Grades(Convert.ToInt32(Console.ReadLine()));
	}
	//Challenge 1
	public void Temperature (int value)
	{
		int baseTemp = 30;
		if(baseTemp < value) //Block of code that is executed when it is true
		{
			Console.WriteLine("It is pretty hot today, maybe try staying hydrated and avoid staying in the sun to long.");
		} 
		else //Block of code that is executed when it is false
		{
			Console.WriteLine("It is a pretty good day, go enjoy it.");
		}
	}
	//Challenge 2
	public void Grades (int value)
	{
		int baseGrade = 100;
		if (baseGrade >= 90) //Block of code that is executed when it is true
		{
			Console.WriteLine("A");
		}
		else if (baseGrade >= 80) //Block of code that is executed when the first condition is false
		{
			Console.WriteLine("B");
		}
		else //Block of code that is executed when the first and second condition is false
		{
			Console.WriteLine("C");
		}
	}
}