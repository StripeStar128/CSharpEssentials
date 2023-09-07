using System;
					
public class Program
{
	public static void Main()
	{
		//Challenge 1
		
		string myName = "Julia Fullmer"; //A string variable stores text, must have quotation marks around value
		Console.WriteLine(myName); //This will write text that is visable when running the program
		
		int myFavNum = 128; //int stands for Interger and is a variable that stores whole numbers
		Console.WriteLine(myFavNum);
		
		int ranNum; //This stands for random number
		ranNum = 62; //You can assigne values seperatly from the original variable
		Console.WriteLine(ranNum);
		
		ranNum = 45; // Making a different line with the same text as a preivous variable will change it, my random number is now 45
		Console.WriteLine(ranNum);
		
		double decNum = 6.9; //This is a floating point number, it is always a number with a decimal
		Console.WriteLine(decNum);
		
		char ranLetter = 'T'; //char stands for Character, it is used to store a single character and must be surrounded by apostophes
		Console.WriteLine(ranLetter);
		
		Console.WriteLine("My favorite number is 128"); //You can also use this to write text that is not connected to a variable
		bool favNum = true; //This is a Boolean, it does true or false statments
		Console.WriteLine(favNum);
		
		//Challenge 2
		
		int x = 6;
		int y = 8;
		Console.WriteLine("x = " + x);
		Console.WriteLine("y = " + y);
		
		Console.WriteLine("6 + 8 =");
		Console.WriteLine(x + y); //You can add numbers or variables.
		
		Console.WriteLine("6 - 8 =");
		Console.WriteLine(x - y); //You can subtrack numbers or variables.
		
		Console.WriteLine("6 * 8 =");
		Console.WriteLine(x * y); //You can multiply numbers or variables.
		
		Console.WriteLine("6 / 8 =");
		Console.WriteLine(x / y); //You can divide numbers or variables.
		
		x = 25; //Typing and reassigning a pre defined variable will overright the original input in future outputs
		y = 15;
		Console.WriteLine("x = " + x);
		Console.WriteLine("y = " + y);
		
		Console.WriteLine("25 + 15 =");
		Console.WriteLine(x + y); 
		
		Console.WriteLine("25 - 15 =");
		Console.WriteLine(x - y);
		
		Console.WriteLine("25 * 15 =");
		Console.WriteLine(25 * 15);
		
		Console.WriteLine("25 / 15 =");
		Console.WriteLine(x / y);
		
		//Challenge 3
		
		Console.WriteLine("Enter username:");
		string userName = Console.ReadLine(); //You can get user input with the Console.ReadLine() variable
		Console.WriteLine("Username is: " + userName);
		
		Console.WriteLine("Enter your age:");
		int age = Convert.ToInt32(Console.ReadLine()); //Console.ReadLine cannot get infomation from other data like int so you have to convert it with the Convert.To variable
		Console.WriteLine("Your age is: " + age);
		
		Console.WriteLine("Enter a x value:");
		x = Convert.ToInt32(Console.ReadLine()); //This will convert the previous x value to the user inputed one
		Console.WriteLine("Your x value is: " + x);
		
		Console.WriteLine("Enter a y value:");
		y = Convert.ToInt32(Console.ReadLine()); //This will convert the previous y value to the user inputed one
		Console.WriteLine("Your y value is: " + y);
		
		Console.WriteLine("Let's add your x and y together:");
		Console.WriteLine(x + y); // This will add the user inputed numbers together
		
		Console.WriteLine("Let's subtract your x and y together:");
		Console.WriteLine(x - y); // This will subtract the user inputed numbers together
		
		Console.WriteLine("Let's multiply your x and y together:");
		Console.WriteLine(x * y); // This will multiply the user inputed numbers together
		
		Console.WriteLine("Let's divide your x and y together:");
		Console.WriteLine(x / y); // This will divide the user inputed numbers together
	}
}