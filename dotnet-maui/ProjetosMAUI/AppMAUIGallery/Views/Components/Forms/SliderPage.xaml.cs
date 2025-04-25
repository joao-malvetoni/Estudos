namespace AppMAUIGallery.Views.Components.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

	private void Slider_DragCompleted(object sender, EventArgs e)
	{
		lblStatus.Text = "Completou o arrasto";
    }

	private void Slider_DragStarted(object sender, EventArgs e)
	{
		lblStatus.Text = "Iniciou o arrasto";
	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		if(lblStatus != null)
			lblStatus.Text = "Valor: " + e.NewValue.ToString();
	}
}