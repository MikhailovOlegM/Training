using System;
					
public class Program
{
	public static void Main()
	{
		int[] a1 = { /* INSERT ARRAY HERE */ };
		int[] a2 = { /* INSERT ARRAY HERE */ };
		int[] aOut = new int[a1.Length + a2.Length];
		int temp = 0, j = 0;
		
		
		for(int i = 0; i < a1.Length; i++){
			if(a1[i] > a2[j])
				for(; j < a2.Length && a1[i] > a2[j]; j++)
					aOut[temp++] = a2[j];
			aOut[temp++] = a1[i];
		}
		
		if(temp < aOut.Length)
			for(; j < a2.Length; j++)
				aOut[temp++] = a2[j];
		
		foreach(int num in aOut)
			Console.WriteLine(num);
	}
}