using AppMAUIGallery.Views.Lists.Models;

namespace AppMAUIGallery.Views.Lists;

public partial class PickerListPage : ContentPage
{
	public PickerListPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		PickerControl.ItemsSource = MovieList.GetList();
		var index = PickerControl.SelectedIndex;
	}

	private void PickerControl_SelectedIndexChanged(object sender, EventArgs e)
	{

	}
}