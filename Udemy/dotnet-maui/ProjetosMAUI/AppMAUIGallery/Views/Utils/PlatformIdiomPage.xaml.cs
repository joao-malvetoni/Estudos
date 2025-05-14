namespace AppMAUIGallery.Views.Utils;

public partial class PlatformIdiomPage : ContentPage
{
	public PlatformIdiomPage()
	{
		InitializeComponent();

#if WINDOWS
	DisplayAlert("Condi��es de compila��o", "Esta � uma mensagem executada s� no Windows usando condi��es de compila��o", "OK");
#endif

		if (DeviceInfo.Platform == DevicePlatform.WinUI)
		{
			DisplayAlert("Windows", "Esta mensagem � exclusiva do Windows", "OK");
		}

		if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
		{
			DisplayAlert("Desktop", "Esta mensagem � exclusiva do Desktop PC", "OK");
		}
	}
}