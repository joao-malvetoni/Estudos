using AppMAUIGallery.Libraries.Fix;
using AppMAUIGallery.Models;
using AppMAUIGallery.Repositories;
using System.Collections.ObjectModel;

namespace AppMAUIGallery.Views;

public partial class MainPage : ContentPage
{
	private IGroupComponentRepository _repository;
	private List<Component> _fullList;
	private ObservableCollection<Component> _filteredList;

	public MainPage()
	{
		InitializeComponent();
		_repository = new GroupComponentRepository();
		_fullList = _repository.GetComponents();
		_filteredList = new ObservableCollection<Component>(_fullList);
		ComponentCollection.ItemsSource = _filteredList;
	}

	private void OnTapComponent(object sender, TappedEventArgs e)
	{
		KeyboardFix.HideKeyboard();
		var page = (Type)e.Parameter;
		((FlyoutPage)App.Current.Windows[0].Page).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
		((FlyoutPage)App.Current.Windows[0].Page).IsPresented = false;
	}

	private void Entry_TextChanged(object sender, TextChangedEventArgs e)
	{
		var word = e.NewTextValue.ToLower();

		Clear();
		Search(word);
	}

	private void Search(string word)
	{
		var filteredList = _fullList.Where(a => a.Title.ToLower().Contains(word)).ToList();
		foreach (var component in filteredList)
		{
			_filteredList.Add(component);
		}
	}

	private void Clear()
	{
		var limit = _filteredList.Count;
		for (int i = 0; i < limit; i++)
			_filteredList.RemoveAt(0);
	}
}