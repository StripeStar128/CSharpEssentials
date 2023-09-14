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
		Console.WriteLine("What class is this grade for: 1-Art, 2-Math, 3-English, 4-Health, 5-P.E., 6-Science, 7-History, 8-Music");
		string whatClass = Console.ReadLine();
		Console.WriteLine("Your class is: " + whatClass);
		Subjects(Convert.ToInt32(Console.ReadLine()));
	}
//Challenge 1
	public void Temperature (int value)
	{
		int baseTemp = value;
		if(baseTemp >= 30) 
		{
			Console.WriteLine("It is pretty hot today, maybe try staying hydrated and avoid staying in the sun to long.");
		} 
		else if(baseTemp <= 29 && baseTemp >= 20)
		{
			Console.WriteLine("It is a pretty good day, go enjoy it.");
		}
		else if(baseTemp <= 19 && baseTemp >= 10)
		{
			Console.WriteLine("It is a bit chilly today, maybe bring a light jacket.");
		}
		else
		{
			Console.WriteLine("It is pretty cold today, maybe wear some warm clothes.");
		}
	}
//Challenge 2
	public void Grades (int value)
	{
		int baseGrade = value;
		if (baseGrade >= 90) 
		{
			Console.WriteLine("A");
		}
		else if (baseGrade <= 89 && baseGrade >= 80) 
		{
			Console.WriteLine("B");
		}
		else if (baseGrade <= 79 && baseGrade >= 70)
		{
			Console.WriteLine("C");
		}
		else if (baseGrade <= 69 && baseGrade >= 60)
		{
			Console.WriteLine("D");
		}
		else
		{
			Console.WriteLine("F");
		}
	}
	public void Subjects (int value)
	{
		int subject = value;
		switch (subject)
		{
			case 1:
				Console.WriteLine("Art");
				Console.WriteLine("Do you like this subject? 1-yes, 2-no");
				string artClass = Console.ReadLine();
				FavClass(Convert.ToInt32(Console.ReadLine()));
				break;
			case 2:
				Console.WriteLine("Math");
				Console.WriteLine("Do you like this subject? 1-yes, 2-no");
				string mathClass = Console.ReadLine();
				FavClass(Convert.ToInt32(Console.ReadLine()));
				break;
			case 3:
				Console.WriteLine("English");
				Console.WriteLine("Do you like this subject? 1-yes, 2-no");
				string favoritClass = Console.ReadLine();
				FavClass(Convert.ToInt32(Console.ReadLine()));
				break;
			case 4:
				Console.WriteLine("Health");
				Console.WriteLine("Do you like this subject? 1-yes, 2-no");
				string favoriteClass = Console.ReadLine();
				FavClass(Convert.ToInt32(Console.ReadLine()));
				break;
			case 5:
				Console.WriteLine("P.E.");
				Console.WriteLine("Do you like this subject? 1-yes, 2-no");
				string favorIteClass = Console.ReadLine();
				FavClass(Convert.ToInt32(Console.ReadLine()));
				break;
			case 6:
				Console.WriteLine("Science");
				Console.WriteLine("Do you like this subject? 1-yes, 2-no");
				string faVorClass = Console.ReadLine();
				FavClass(Convert.ToInt32(Console.ReadLine()));
				break;
			case 7:
				Console.WriteLine("History");
				Console.WriteLine("Do you like this subject? 1-yes, 2-no");
				string favOriteClass = Console.ReadLine();
				FavClass(Convert.ToInt32(Console.ReadLine()));
				break;
			case 8:
				Console.WriteLine("Music");
				Console.WriteLine("Do you like this subject? 1-yes, 2-no");
				string favoriTeClass = Console.ReadLine();
				FavClass(Convert.ToInt32(Console.ReadLine()));
				break;
		}
	}
	public void FavClass (int value)
	{
		int likeClass = 1;
		if(likeClass >= value)
		{
			Console.WriteLine("That is a fun class!");
		}
		else
		{
			Console.WriteLine("Yeah, that class can be hard at times, just keep at it because knowledge is power.");
		}
	}
}