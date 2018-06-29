using System;
					
public class Program
{
	public static void Main()
	{
		int[] arr = { /* INSERT ARRAY HERE */ };
		Console.WriteLine(hasSum(arr, Convert.ToInt32(Console.ReadLine())));
	}
	
	// Спасибо Schullz с русскоязычного SO.
	public static bool hasSum(int[] arr, int sum){
		int lt = 0, rt = arr.Length - 1;
		while(lt != rt){
			int tmp = arr[lt] + arr[rt];
			if(tmp > sum)
				rt--;
			else if(tmp < sum)
				lt++;
			else
				return true;
		}
		return false;
	}
}