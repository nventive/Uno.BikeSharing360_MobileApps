using BikeSharing.Clients.Core.Controls;
using BikeSharing.Clients.UWP.Renderers;
using System;
using Windows.UI;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Media;

[assembly: ExportRenderer(typeof(CustomProgressBar), typeof(CustomProgressBarRenderer))]
namespace BikeSharing.Clients.UWP.Renderers
{
    public partial class CustomProgressBarRenderer : ProgressBarRenderer
    {
		public CustomProgressBarRenderer()
		{

		}

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
        {
            base.OnElementChanged(e);

            try
            {
                var foregroundColor = Colors.White;
                var backgroundColor = Color.FromArgb(25, 255, 255, 255);
                Control.Foreground = new SolidColorBrush(foregroundColor);
                Control.Background = new SolidColorBrush(backgroundColor);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}