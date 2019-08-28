using BikeSharing.Clients.Core;
using BikeSharing.Clients.Core.Services.Interfaces;
using BikeSharing.Clients.Core.ViewModels.Base;
using BikeSharing.Clients.UWP.Services;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xaml = Windows.UI.Xaml;

namespace BikeSharing.Clients.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            NavigationCacheMode = Xaml.Navigation.NavigationCacheMode.Required;

            ViewModelLocator.Instance.Register<IOperatingSystemVersionProvider, OperatingSystemVersionProvider>();

			Dispatcher.RunAsync(
                global::Windows.UI.Core.CoreDispatcherPriority.Normal,
				() =>
			{
				// Xamarin.FormsMaps.Init(GlobalSettings.BingMapsAPIKey);
				LoadApplication(new Core.App());
				NativeCustomize();

				Background = new SolidColorBrush(Colors.Black);
			});
		}

		private void NativeCustomize()
        {
            // PC Customization
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                   // titleBar.BackgroundColor = (Color)App.Current.Resources["NativeAccentColor"];
                    // titleBar.ButtonBackgroundColor = (Color)App.Current.Resources["NativeAccentColor"];
                }
            }

            // Mobile Customization
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();
                if (statusBar != null)
                {
                    statusBar.BackgroundOpacity = 1;
                    statusBar.BackgroundColor = (Color)App.Current.Resources["NativeAccentColor"];
                }
            }

            // Launch in Window Mode
            var currentView = ApplicationView.GetForCurrentView();
            if (currentView.IsFullScreenMode)
            {
                currentView.ExitFullScreenMode();
            }
        }
    }
}