namespace TrainingCodeLauncher
{
	class BooleanMenu : Menu
	{
		public BooleanMenu(string title, string yesAnswer = "Yes", string noAnswer = "No", int defaultPos = 0) : base(title, new string[] { yesAnswer, noAnswer }, defaultPos)
		{
		}

		public new bool Show()
		{
			return base.Show() != 1;
		}
	}
}
