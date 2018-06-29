using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCodeLauncher
{
	class TestPackage : IPackage
	{
		public string Name => "Test package";
		public string URL => "Test package";
		public Solution[] Solutions => new Solution[] { new Solution1(), new Solution2() };
	}
}
