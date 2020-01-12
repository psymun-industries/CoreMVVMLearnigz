using Stylet;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUI.ViewModels
{
	public class RootViewModel : Screen
	{
		public string Welcome { get; set; }

		public RootViewModel()
		{
			Welcome =
				"Eventually this application will do something very exciting indeed. " +
				"For now, enjoy reading this pleasant text.";
		}
	}
}
