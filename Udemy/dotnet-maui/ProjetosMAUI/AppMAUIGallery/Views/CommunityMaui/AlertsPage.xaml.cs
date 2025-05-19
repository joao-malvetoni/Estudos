using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace AppMAUIGallery.Views.CommunityMaui;

public partial class AlertsPage : ContentPage
{
	public AlertsPage()
	{
		InitializeComponent();
	}

	private async void OnButtonClickedShowSnackbar(object sender, EventArgs e)
	{
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		var snackbarOptions = new SnackbarOptions
		{
			BackgroundColor = Colors.Red,
			TextColor = Colors.Green,
			ActionButtonTextColor = Colors.Yellow,
			CornerRadius = new CornerRadius(10),
			Font = Microsoft.Maui.Font.SystemFontOfSize(14),
			ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14),
			CharacterSpacing = 0.5
		};

		string text = "This is a Snackbar";
		string actionButtonText = "Click Here to Dismiss";
		Action action = async () => await DisplayAlert("Snackbar ActionButton Tapped", "The user has tapped the Snackbar ActionButton", "OK");
		TimeSpan duration = TimeSpan.FromSeconds(3);
		var snackbar = Snackbar.Make(text, action, actionButtonText, duration, snackbarOptions);

		await snackbar.Show(cancellationTokenSource.Token);
	}
}