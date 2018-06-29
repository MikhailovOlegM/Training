using System;

namespace TrainingCodeLauncher
{
	class Program
	{
		// Menus
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			
			while (true)
			{
				int loadMenu = new Menu("Select import type", new string[] { "Exit", "[WIP] Search in dir", "Load from file", "Load test package" }, 3).Show();

				if (loadMenu == 0)
					break;
				else if (loadMenu == 1 || loadMenu == 2) ;
				else if (loadMenu == 2)
				{
					Console.Write("Enter path to file: ");
					string dllPath = Console.ReadLine();
				}
				else if (loadMenu == 3)
					new PackageProcessor(new TestPackage());
			}
		}

		public static void WriteColored(ConsoleColor foreground, object content)
		{
			WriteColored(foreground, Console.BackgroundColor, content);
		}

		public static void WriteColored(ConsoleColor foreground, ConsoleColor background, object content)
		{
			ConsoleColor fg = Console.ForegroundColor, bg = Console.BackgroundColor;
			lock (new object())
			{
				Console.BackgroundColor = background;
				Console.ForegroundColor = foreground;
				Console.Write(content);
				Console.BackgroundColor = bg;
				Console.ForegroundColor = fg;
			}
		}
	}
}
