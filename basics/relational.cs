using System;

public class Program
{
	public static void Main()
	{
		bool result;
		int firstNumber = 30, secondNumber = 20;

		result = (firstNumber==secondNumber);
		Console.WriteLine("{0} == {1} returns {2}",firstNumber, secondNumber, result);

		result = (firstNumber > secondNumber);
		Console.WriteLine("{0} > {1} returns {2}",firstNumber, secondNumber, result);

		result = (firstNumber < secondNumber);
		Console.WriteLine("{0} < {1} returns {2}",firstNumber, secondNumber, result);

		result = (firstNumber >= secondNumber);
		Console.WriteLine("{0} >= {1} returns {2}",firstNumber, secondNumber, result);

		result = (firstNumber <= secondNumber);
		Console.WriteLine("{0} <= {1} returns {2}",firstNumber, secondNumber, result);

		result = (firstNumber != secondNumber);
		Console.WriteLine("{0} != {1} returns {2}",firstNumber, secondNumber, result);
	}
}