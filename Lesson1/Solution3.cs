// В следующем фрагменте кода остались строки для дебага. Удалите их (и этот коммент) при ненадобности.

using System;
					
public class Program
{
	public static void Main()
	{
		string input;
		int count = 0;
		input = Console.ReadLine();
		string[] words = input.Split(',');
		foreach(string word in words){
			if(isPalendrome(RemoveSpacesFromString(word)))
				count++;
		}
		switch(count){
			case 0:
				Console.WriteLine("Palindromes not found");
				break;
			case 1:
				Console.WriteLine("There is one palindrome");
				break;
			default:
				Console.WriteLine("There are " + count + " palindromes");
				break;
		}
	}
	
	public static bool isPalendrome(string s){
		char[] chars = s.ToLower().ToCharArray();
		// DEBUG: Console.WriteLine("IP > [" + s +"]");
		for(int i = 0; i < chars.Length / 2;i++){
			// DEBUG: Console.WriteLine(chars[i] + " - " + chars[chars.Length - 1 - i]);
			if(chars[i] != chars[chars.Length - 1 - i])
				return false;
		}
		
		return true;
	}
	
	// Несколько пробелов не смогли победить ни Replace, ни Trim и даже не их связка
	public static string RemoveSpacesFromString(string input)
    {
        for(int i = 0;i < input.Length; i++)
		{
			// DEBUG: Console.WriteLine("<" + input[i] + ">");
        	if (string.IsNullOrWhiteSpace(input[i].ToString()))
        	{
        	    input = input.Remove(i, 1);
				i--;
			}
		}
        return input;
    }
}