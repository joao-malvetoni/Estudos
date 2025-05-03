namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

	private void OnButtonNextClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page3());
	}

	private void OnButtonPreviousClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();

		// Navigation.NavigationStack
		// Tem todas as telas na pilha de chamadas até a tela atual aberta
		// Além de outras propriedades e métodos para trabalhar com as telas
	}
}