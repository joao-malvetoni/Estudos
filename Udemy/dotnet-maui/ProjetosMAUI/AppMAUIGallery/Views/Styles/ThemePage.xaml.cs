using AppMAUIGallery.Resources.Styles;

namespace AppMAUIGallery.Views.Styles;

public partial class ThemePage : ContentPage
{
	private bool Light = true;
	public ThemePage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		ICollection<ResourceDictionary> dictionaries = Application.Current.Resources.MergedDictionaries;

		if(dictionaries != null)
		{
			dictionaries.Remove(dictionaries.ElementAt(2));
			if (Light)
			{
				Light = !Light;
				dictionaries.Add(new DarkTheme());
			}
			else
			{
				Light = !Light;
				dictionaries.Add(new LightTheme());
			}
		}
    }
}