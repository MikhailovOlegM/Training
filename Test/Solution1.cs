//
// This is test solution.
//

namespace TrainingCodeLauncher
{
	class Solution1 : Solution
	{
		public override string Name => "Default input test";
		public override string Task => null;
		public override string GHURL => "https://github.com/Yavd3341/Training/blob/master/Test/Solution1.cs";
		public override string[] DefaultInput => new string[] {"Input 1", "Input 2"};

		public override void Execute()
		{
			string i1,i2;
			Processor.WriteLine("Enter input 1: ");
			i1 = Processor.ReadLine();
			Processor.WriteLine("Enter input 2: ");
			i2 = Processor.ReadLine();
			Processor.WriteLine("Your inputs is " + i1 + " and " + i2);
		}

	}
}