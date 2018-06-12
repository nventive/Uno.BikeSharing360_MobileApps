using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BikeSharing.Clients.UWP;

namespace BikeSharing.Clients
{
	[global::Android.App.ApplicationAttribute(
		Label = "@string/ApplicationName",
		LargeHeap = true,
		HardwareAccelerated = true,
		Theme = "@style/AppTheme"
	)]
	public class MyApplication : Windows.UI.Xaml.NativeApplication
	{
		public MyApplication(IntPtr javaReference, JniHandleOwnership transfer)
			: base(new App(), javaReference, transfer)
		{
		}
	}
}