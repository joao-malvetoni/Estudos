namespace AppMAUIGallery.Views.Components.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

	private void Picker_SelectedIndexChanged(object sender, EventArgs e)
	{
		var component = ((Picker)sender);
		var brandName = (String)component.SelectedItem;
		//component.SelectedIndex = 1;
		//component.SelectedItem = component.ItemsSource[0];
		lblValue.Text = brandName;
    }
}