using System;
using System.Reflection;
using BikeSharing.Clients.UWP;
using Microsoft.Extensions.Logging;
using UIKit;
using Uno.Extensions;

namespace BikeSharing.Clients
{
	public class Program
	{
		// This is the main entry point of the application.
		static void Main(string[] args)
		{
			Assembly.Load("Xamarin.Forms.Platform.UAP");
			Assembly.Load("Xamarin.Forms.Platform");
			Assembly.Load("Xamarin.Forms.Core");
			Assembly.Load("Xamarin.Forms.Xaml");

			Xamarin.Forms.Internals.Log.Listeners.Add(new Xamarin.Forms.Internals.DelegateLogListener((c, m) => Console.WriteLine(c + ":" + m)));
#if DEBUG
			ConfigureFilters(LogExtensionPoint.AmbientLoggerFactory);
#endif

			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, typeof(App));
		}

		static void ConfigureFilters(ILoggerFactory factory)
		{
			factory
				.WithFilter(new FilterLoggerSettings
					{
						{ "Uno", LogLevel.Warning },
						{ "Windows", LogLevel.Warning },
						
						// Generic Xaml events
						// { "Windows.UI.Xaml", LogLevel.Debug },
						// { "Windows.UI.Xaml.Shapes", LogLevel.Debug },
						// { "Windows.UI.Xaml.VisualStateGroup", LogLevel.Debug },
						// { "Windows.UI.Xaml.Media", LogLevel.Debug },
						// { "Windows.UI.Xaml.StateTriggerBase", LogLevel.Debug },
						// { "Windows.UI.Xaml.UIElement", LogLevel.Debug },
						// { "Windows.UI.Xaml.Setter", LogLevel.Debug },
						   
						// Layouter specific messages
						// { "Windows.UI.Xaml.Controls", LogLevel.Debug },
						 { "Windows.UI.Xaml.Controls.Layouter", LogLevel.Debug },
						// { "Windows.UI.Xaml.FrameworkElement", LogLevel.Debug },
						   
						// Binding related messages
						// { "Windows.UI.Xaml.Data", LogLevel.Debug },
						// { "Windows.UI.Xaml.Data", LogLevel.Debug },
						   
						//  Binder memory references tracking
						// { "ReferenceHolder", LogLevel.Debug },
					}
				)
				.AddConsole(LogLevel.Debug);
		}

	}
}