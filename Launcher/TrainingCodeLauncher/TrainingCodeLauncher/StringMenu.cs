using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCodeLauncher
{
	class StringMenu:Menu
	{
		public StringMenu(string title, Dictionary<string,string> options, int defaultPos = 0, bool compressed = false) : base(title, options.Keys.ToArray(), defaultPos, compressed) {
			this.options = options;
		}

		public Dictionary<string, string> options;

		public new string Show()
		{
			return options[options.Keys.ToArray()[base.Show()]];
		}
	}
}
