using AppMAUIGallery.Repositories;
using Microsoft.Maui.Graphics.Text;

namespace AppMAUIGallery.Views;

public partial class Menu : ContentPage
{
	private IGroupComponentRepository _repository;
	public Menu()
	{
		InitializeComponent();

		// TODO - DI - Dependency Injection
		_repository = new GroupComponentRepository();

		MenuCollection.ItemsSource = _repository.GetGroupComponents();
	}

	private void OnTapComponent(object sender, TappedEventArgs e)
	{
		var page = (Type)e.Parameter;

		((FlyoutPage)App.Current.Windows[0].Page).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
		((FlyoutPage)App.Current.Windows[0].Page).IsPresented = false;
	}

	private void OnTapInicio(object sender, TappedEventArgs e)
	{
		((FlyoutPage)App.Current.Windows[0].Page).Detail = new NavigationPage(new AppMAUIGallery.Views.MainPage());
		((FlyoutPage)App.Current.Windows[0].Page).IsPresented = false;
	}
}