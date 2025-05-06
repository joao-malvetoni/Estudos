using AppTask.Repositories;

namespace AppTask.Views;

public partial class StartPage : ContentPage
{
	private ITaskModelRepository _repository;
	public StartPage()
	{
		InitializeComponent();
		_repository = new TaskModelRepository();
		LoadData();
	}
	private void LoadData()
	{
		var tasks = _repository.GetAll();
		CollectionViewTasks.ItemsSource = tasks;
		lblEmptyText.IsVisible = tasks.Count <= 0;
	}
	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new AddEditTaskPage());
    }

	private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		Entry_Search.Focus();
	}
}