namespace AppMAUIGallery.Views.Components.Forms;

public partial class CheckBoxPage : ContentPage
{
	public CheckBoxPage()
	{
		InitializeComponent();
	}

	private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if (e.Value)
		{
			var checkebox = ((CheckBox)sender);
			HorizontalStackLayout horizontal = (HorizontalStackLayout)checkebox.Parent;
			Label label = (Label)horizontal.Children[1];
			lblStatus.Text = label.Text;
		}
		else
		{
			lblStatus.Text = string.Empty;
		}
    }
}