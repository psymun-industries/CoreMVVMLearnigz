using Stylet;
using System;

namespace CoreUI.ViewModels
{
	public class RootViewModel : Screen
	{
		private string _welcome;
		private string _defaultWelcome =
				"Eventually this application will do something very exciting indeed.\n" +
				"For now, enjoy reading this pleasant text.";

		private IWindowManager _wm;

		public string Welcome
		{
			get => _welcome;
			set
			{
				SetAndNotify(ref _welcome, value);
			}
		}

		public RootViewModel(IWindowManager windowManager)
		{
			_wm = windowManager;
			Welcome = _defaultWelcome;

			this.DisplayName = WindowGreeting();
		}
		
		public void ResetText()
		{
			Welcome = _defaultWelcome;
		}

		public void ShowChangeTextView()
		{
			var viewModel = new ChangeWelcomeTextViewModel();

			var userName = HandleUserName(Environment.UserName);
			viewModel.DisplayName = $"Hello {userName}";

			bool? result = _wm.ShowDialog(viewModel);
			if (result.GetValueOrDefault(true))
			{
				this.Welcome = viewModel.UserInput;
			}

		}

		private string WindowGreeting()
		{
			int hour = DateTime.Now.Hour;
			int min = DateTime.Now.Minute;
			int sec = DateTime.Now.Second;

			if (hour < 12)
			{
				return "Good morning";
			}
			else if (hour < 17)
			{
				return "Good afternoon";
			}
			else if (hour <= 23 && min <= 59 && sec <= 59)
			{
				return "Good evening";
			}
			else // this should never really happen....
			{
				return "Good day";
			}
		}

		private string HandleUserName(string name)
		{
			var un = name;
			if (String.IsNullOrEmpty(un))
			{
				return "my dear user";
			}
			else if (un.Length >= 32)
			{
				return "Captain Long Username";
			}
			else
			{
				return un;
			}
		}
	}
}
