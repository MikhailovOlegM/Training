using System;
using System.Collections.Generic;
using System.Net;

namespace TrainingCodeLauncher
{
	public class SolutionProcessor
	{
		public SolutionProcessor(Solution solution)
		{
			ConnectedSolution = solution;
			ConnectedSolution.SetProcessor(this);
			ShowMenu();
		}

		public Solution ConnectedSolution { get; private set; }
		public bool useDefaultInput = true;
		public int nextInputIndex = 0;

		public void ShowMenu()
		{
			Dictionary<string,string> mid = new Dictionary<string, string>();
			mid.Add("Back", "back");
			mid.Add("Execute", "exec");
			if (ConnectedSolution.Task != null) mid.Add("Show task","task");
			if (ConnectedSolution.GHURL != null) mid.Add("Show source code (require Internet connection)","src");
			if (ConnectedSolution.GHURL != null) mid.Add("Open GitHub page","web");

			while (true)
			{
				string solutionMenu = new StringMenu("What to do with this solution?", mid).Show();

				if (solutionMenu == "back")
					break;
				else if (solutionMenu == "exec")
				{
					ExecuteSolution();
					Console.WriteLine("\n================\nPress any key to return to previous menu");
					Console.ReadLine();
				}
				else if (solutionMenu == "task")
				{
					Console.WriteLine("Task: " + ConnectedSolution.Task);
					Console.WriteLine("\n================\nPress any key to return to previous menu");
					Console.ReadLine();
				}
				else if (solutionMenu == "src")
				{
					Console.WriteLine(new WebClient().DownloadString(ConnectedSolution.GHURL.Replace("github.com", "raw.githubusercontent.com").Replace("/blob", "")));
					Console.WriteLine("\n================\nPress any key to return to previous menu");
					Console.ReadLine();
				}
				else if (solutionMenu == "web")
					System.Diagnostics.Process.Start(ConnectedSolution.GHURL);
			}
		}

		public void ExecuteSolution()
		{
			nextInputIndex = 0;
			if (ConnectedSolution.DefaultInput != null)
				useDefaultInput = new BooleanMenu("Use default input for [ " + ConnectedSolution.Name + " ] ?").Show();
			ConnectedSolution.Execute();
		}

		public void WriteLine(object obj)
		{
			Console.WriteLine(obj);
		}

		public string ReadLine()
		{
			if (useDefaultInput)
			{
				Console.Write("USER > ");
				return Console.ReadLine();
			}
			else
			{
				Console.WriteLine("TCL > " + ConnectedSolution.DefaultInput[nextInputIndex]);
				return ConnectedSolution.DefaultInput[nextInputIndex++];
			}
		}
	}

	public abstract class Solution
	{
		public SolutionProcessor Processor { get; private set; }

		public void SetProcessor(SolutionProcessor processor)
		{
			Processor = processor;
		}

		public abstract string Name { get; }
		public abstract string Task { get; }
		public abstract string GHURL { get; }
		public abstract string[] DefaultInput { get; }
		public abstract void Execute();
	}
}
