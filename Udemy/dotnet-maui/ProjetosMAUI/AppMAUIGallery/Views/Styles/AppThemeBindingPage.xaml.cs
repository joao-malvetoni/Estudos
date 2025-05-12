namespace AppMAUIGallery.Views.Styles;

public partial class AppThemeBindingPage : ContentPage
{
	public AppThemeBindingPage()
	{
		InitializeComponent();

		// Ler o tema
		var theme = Application.Current.RequestedTheme;

		// Trocar o tema
		//Application.Current.UserAppTheme = AppTheme.Dark;
	}
}