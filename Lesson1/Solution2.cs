using System;
					
public class Program
{
	public static void Main()
	{
		string input, output = "";
		input = Console.ReadLine();
		string[] words = input.Split(' ');
		for(int i = 0; i < words.Length; i++){
			if(words[i].Length > 4)
				words[i] = words[i][0] + (words[i].Length - 2).ToString() + words[i][words[i].Length - 1];
			
			output += words[i] + (i == words.Length - 1 ? "" : " ");
		}
		Console.WriteLine(output);
	}
}