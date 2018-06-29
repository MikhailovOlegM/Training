using System;
					
public class Program
{
	public static void Main()
	{
		string input, output;
		input = Console.ReadLine();
		output = FromBinary(input).ToString();
		Console.WriteLine(output);
	}
	
	public static int FromBinary(string bin){
		int _out = 0;
		for(int i = bin.Length - 1; i >= 0; i--){
			if(bin[i] == '1')
				_out += (int)Math.Pow(2, bin.Length - 1 -i);
		}
		return _out;
	}
}