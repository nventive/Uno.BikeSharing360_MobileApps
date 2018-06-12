using BikeSharing.Clients.UWP.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(DatePicker), typeof(CustomDatePickerRenderer))]
namespace BikeSharing.Clients.UWP.Renderers
{
    public partial class CustomDatePickerRenderer : DatePickerRenderer
    {
        private const double MaxDatePickerWidth = 200;

		public CustomDatePickerRenderer()
		{

		}

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);

            var datePicker = Control;

            if (datePicker != null)
            {
                datePicker.MinWidth = MaxDatePickerWidth;
                datePicker.Width = MaxDatePickerWidth;
                datePicker.MaxWidth = MaxDatePickerWidth;
            }
        }
    }
}
