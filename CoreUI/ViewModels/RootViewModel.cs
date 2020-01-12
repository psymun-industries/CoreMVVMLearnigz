using Stylet;

namespace CoreUI.ViewModels
{
	public class RootViewModel : Screen
	{
		private string _welcome;
		private string _defaultWelcome =
				"Eventually this application will do something very exciting indeed.\n" +
				"For now, enjoy reading this pleasant text.";

		public string Welcome
		{
			get => _welcome;
			set
			{
				_welcome = value;
				NotifyOfPropertyChange(() => Welcome);
			}
		}

		public RootViewModel()
		{
			Welcome = _defaultWelcome;
		}

		public void ChangeWT()
		{
			Welcome = "turd";
		}

	}
}
