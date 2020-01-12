using Stylet;
using CoreUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace CoreUI
{
	public class Bootstrapper : Bootstrapper<RootViewModel>
	{
        protected override void OnStart()
        {
            // This is called just after the application is started, but before the IoC container is set up.
            // Set up things like logging, etc
        }

        protected override void Configure()
        {
            // This is called after Stylet has created the IoC container, so this.Container exists, but before the
            // Root ViewModel is launched.
            // Configure your services, etc, in here
        }

        protected override void OnLaunch()
        {
            // This is called just after the root ViewModel has been launched
            // Something like a version check that displays a dialog might be launched from here
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // Called on Application.Exit
        }
    }
}
