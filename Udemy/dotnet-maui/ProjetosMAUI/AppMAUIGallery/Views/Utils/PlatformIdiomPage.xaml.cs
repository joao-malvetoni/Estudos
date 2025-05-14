namespace AppMAUIGallery.Views.Utils;

public partial class PlatformIdiomPage : ContentPage
{
	public PlatformIdiomPage()
	{
		InitializeComponent();

#if WINDOWS
	DisplayAlert("Condições de compilação", "Esta é uma mensagem executada só no Windows usando condições de compilação", "OK");
#endif

		if (DeviceInfo.Platform == DevicePlatform.WinUI)
		{
			DisplayAlert("Windows", "Esta mensagem é exclusiva do Windows", "OK");
		}

		if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
		{
			DisplayAlert("Desktop", "Esta mensagem é exclusiva do Desktop PC", "OK");
		}
	}
}