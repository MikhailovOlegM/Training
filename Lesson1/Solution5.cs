using System;
					
public class Program
{
	public static void Main()
	{
		int[] arr = { /* INSERT ARRAY HERE */ };
		int input = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(BinSearch(arr, input));
	}
	
	public static bool BinSearch(int[] array, int searchItem){
		int min = 0, max = array.Length - 1;
		
		if(array[0] > searchItem || array[array.Length - 1] < searchItem)
			return false;
		
		while(min != max - 1){
			int temp = (max - min) / 2 + min;
			if(array[temp] < searchItem)
				min = temp;
			else if(array[temp] > searchItem)
				max = temp;
			else return true;
		}
		return false;
	}
}