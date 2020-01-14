using Stylet;

namespace CoreUI.ViewModels
{
	public class ChangeWelcomeTextViewModel : Screen
	{
		private string _userInput;

		public string UserInput
		{
			get => _userInput;
			set
			{
				SetAndNotify(ref _userInput, value);
			}
		}

		public void SetText()
		{
			this.RequestClose(true);
		}

		public void Cancel()
		{
			this.RequestClose();
		}
	}
}
