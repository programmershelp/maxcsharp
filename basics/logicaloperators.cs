using System;

public class Program
{
	public static void Main()
	{
		bool result;
		bool a = true;
		int firstNumber = 15, secondNumber = 30;

		// OR operator
		result = (firstNumber == secondNumber) || (firstNumber > 5);
		Console.WriteLine(result);

		// AND operator
		result = (firstNumber == secondNumber) && (firstNumber > 5);
		Console.WriteLine(result);
		
		// NOT operator
		result = !a;
		Console.WriteLine(result);		
	}
}