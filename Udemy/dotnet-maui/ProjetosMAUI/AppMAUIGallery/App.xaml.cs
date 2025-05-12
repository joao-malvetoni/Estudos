﻿namespace AppMAUIGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
			Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;
        }

		private void Current_RequestedThemeChanged(object? sender, AppThemeChangedEventArgs e)
		{
			if(e.RequestedTheme == AppTheme.Light)
            {
                App.Current.Windows[0].Page.DisplayAlert("Troca de tema","Trocou para o tema claro","Ok");
            }
            else
            {
				App.Current.Windows[0].Page.DisplayAlert("Troca de tema", "Trocou para o tema escuro", "Ok");
			}
		}

		protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppFlyout());
        }
    }
}