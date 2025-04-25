namespace AppMAUIGallery.Views.Components.Forms;

public partial class RadioButtonPage : ContentPage
{
	public RadioButtonPage()
	{
		InitializeComponent();
	}

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if (e.Value)
		{
			var value = ((RadioButton)sender).Content;
			lblResultAsk01.Text = $"Você escolheu {value}";
		}
    }
}