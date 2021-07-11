using System;

public class Program
{
	public static void Main()
	{
		int result;
		int x = 40, y = 20;
		result = (x + y);
		Console.WriteLine("Addition Operator example: " + result);
		result = (x - y);
		Console.WriteLine("Subtraction Operator example: " + result);
		result = (x * y);
		Console.WriteLine("Multiplication Operator example: " + result);
		result = (x / y);
		Console.WriteLine("Division Operator example: " + result);
		result = (x % y);
		Console.WriteLine("Modulo Operator example: " + result);
		Console.WriteLine("Press Enter Key to Exit..");
		Console.ReadLine();
	}
}