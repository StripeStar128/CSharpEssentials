using System;
					
public class Program
{
	public void Main()
	{
		int rows, i, j;
		Console.WriteLine("Input number of rows: ");
		rows= Convert.ToInt32(Console.ReadLine());
		for (i = 1; i <= rows; i++) //These are statments that will be executed when the code is run. Statment 1(i=1;) is executed 1 time before the execution of the code. Statment 2(i<=rows;) defines the condition for executing the code block. Statment 3(i++) is executed every time after the code block is executed.
		{
			for (j = 1; j <= i; j++) //This is a nested loop, it is what makes the numbers repeat in their rows
			Console.Write("{0}", i);
			Console.Write("\n");
		}
	}
}