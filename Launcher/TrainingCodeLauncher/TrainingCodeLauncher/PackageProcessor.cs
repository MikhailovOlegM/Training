using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCodeLauncher
{
	class PackageProcessor
	{
		public PackageProcessor(IPackage package)
		{
			ConnectedPackage = package;
			ShowMenu();
		}

		public IPackage ConnectedPackage { get; private set; }
		public bool useDefaultInput = true;
		public int lastInputIndex = 0;

		public void ShowMenu()
		{
			string[] menuItems = new string[ConnectedPackage.Solutions.Length + 1];
			menuItems[0] = "Back\n";
			for(int i = 1; i < menuItems.Length; i++)
			{
				menuItems[i] = ConnectedPackage.Solutions[i - 1].Name;
			}

			while (true)
			{
				int packageMenu = new Menu("Avaible solutions in package " + ConnectedPackage.Name, menuItems, compressed: true).Show() - 1;

				if (packageMenu == -1)
				{
					break;
				}
				else
					new SolutionProcessor(ConnectedPackage.Solutions[packageMenu]);
			}
		}
	}

	public interface IPackage
	{
		string Name { get; }
		string URL { get; }
		Solution[] Solutions { get; }
	}
}
