namespace AppMAUIGallery.Views.Components.Main;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}

	private void Button_Pressed(object sender, EventArgs e)
	{
		lblLog.Text += $"\nPressionado: {DateTime.Now}";
    }

	private void Button_Released(object sender, EventArgs e)
	{
		lblLog.Text += $"\nLiberado: {DateTime.Now}";
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		lblLog.Text += $"\nClicado: {DateTime.Now}";
	}
}