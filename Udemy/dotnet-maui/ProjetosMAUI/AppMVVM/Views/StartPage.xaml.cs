namespace AppMVVM.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
		// 1� forma de conectar a nossa viewmodel com nossa view
		//BindingContext = new ViewModels.StartPageViewModel();
	}
}