namespace AppMAUIGallery.Views.Components.Forms;

public partial class DatePickerPage : ContentPage
{
	public DatePickerPage()
	{
		InitializeComponent();
	}

	private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
	{
		lblValue.Text = "Nova data: " + e.NewDate.ToString();
    }
}