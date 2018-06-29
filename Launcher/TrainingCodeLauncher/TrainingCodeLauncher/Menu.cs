using System;

namespace TrainingCodeLauncher
{
	class Menu
	{
		public Menu(string title, string[] options, int defaultPos = 0, bool compressed = false)
		{
			this.title = title;
			this.options = options;
			this.compressed = compressed;
			this.Position = defaultPos;
		}

		public string title;
		public bool compressed;
		public string[] options;
		public int Position { get; protected set; }

		protected void Draw()
		{
			Console.Clear();

			Program.WriteColored(ConsoleColor.White, "\n   " + title + "\n\n");

			for(int i = 0; i < options.Length; i++)
			{
				Console.Write("  ");
				Program.WriteColored(ConsoleColor.Cyan, i == Position ? " > " : "   ");
				Program.WriteColored(i == Position ? ConsoleColor.Cyan : ConsoleColor.White, options[i]);
				Console.WriteLine(compressed ? "" : "\n");
			}
		}

		public int Show()
		{
			Draw();
			while (true)
			{
				ConsoleKey key = Console.ReadKey().Key;
				Draw();
				if (key == ConsoleKey.DownArrow)
				{
					Position++;
					if (Position > options.Length - 1)
						Position = 0;
					Draw();
				}
				else if (key == ConsoleKey.UpArrow)
				{
					Position--;
					if (Position < 0)
						Position = options.Length - 1;
					Draw();
				}
				else if (key == ConsoleKey.Enter)
				{
					Console.Clear();
					return Position;
				}
			}
		}
	}
}
