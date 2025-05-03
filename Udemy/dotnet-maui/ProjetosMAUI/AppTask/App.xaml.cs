﻿using AppTask.Views;
using Microsoft.Maui.Platform;

namespace AppTask
{
	public partial class App : Application
	{
		public App()
		{
			CustomHandler();
			InitializeComponent();
		}

		private void CustomHandler()
		{
			Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) => {
#if ANDROID
				// ANDROID
				handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());

#elif IOS || MACCATALYST
				// iOS || MACCATALYST
				handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
				// Windows
				handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
			});
		}

		protected override Window CreateWindow(IActivationState? activationState)
		{
			return new Window(new NavigationPage(new StartPage()));
		}
	}
}