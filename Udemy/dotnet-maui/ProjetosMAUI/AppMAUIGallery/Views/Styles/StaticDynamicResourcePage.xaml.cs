namespace AppMAUIGallery.Views.Styles;

public partial class StaticDynamicResourcePage : ContentPage
{
	public StaticDynamicResourcePage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		//Color.FromHex...
		Resources["TitleColor"] = Colors.Green;
		/*
		 * ((Style)Resource["EstiloX"]).<propriedade> = ...;
		 * Resource["Campo"] = Resource["CampoDesativado"];
		 * Resource["Campo"] = Resource["CampoAtivado"];
		 */
	}
}