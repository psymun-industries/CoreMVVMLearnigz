using Stylet;

namespace CoreUI.ViewModels
{
	public class ChangeWelcomeTextViewModel : Screen
	{
		public string UserInput { get; set; }

		public void SetText()
		{
			this.RequestClose(true);
		}
	}
}
