using System;
					
public class Program
{
	public static void Main()
	{
		string input;
		input = Console.ReadLine();
		
		if(isBalanced(input))
			Console.WriteLine("Brackets are balanced");
		else
			Console.WriteLine("Brackets are not balanced");
	}
	
	public static bool isBalanced(string sequence){
		while(sequence.Contains("()") || sequence.Contains("[]"))
			sequence = sequence.Replace("()", "").Replace("[]", "");
		
		return string.IsNullOrWhiteSpace(sequence);
	}
}