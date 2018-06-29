// В Вашем условии ошибка. С девятого элемента числа вдруг выросли на десять (44 и 65 вместо 34 и 55)

// Рекурсия

using System;
					
public class Program
{
	public static void Main()
	{
		int input = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Fib(0,1,input));
	}
	
	public static int Fib(int a, int b, int n){
		if(n == 1)
			return b;
		else
			return Fib(b, a + b, n - 1);
	}
}

// Цикл

using System;
					
public class Program
{
	public static void Main()
	{
		int input = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Fib(input));
	}
	
	public static int Fib(int n){
		int a = 0, b = 1;
		for(int i = 0; i < n - 1; i++){
			b = a + b;
			a = b - a;
		}
		return b;
	}
}