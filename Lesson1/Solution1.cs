using System;
					
public class Program
{
	public static void Main()
	{
		string input, output;
		input = Console.ReadLine();
		output = input.Replace("@", "[ at ]").Replace(".", "[ dot ]");
		Console.WriteLine(output);
	}
}