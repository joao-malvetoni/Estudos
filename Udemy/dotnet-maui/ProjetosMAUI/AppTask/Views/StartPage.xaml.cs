using AppTask.Models;
using AppTask.Repositories;

namespace AppTask.Views;

public partial class StartPage : ContentPage
{
	private ITaskModelRepository _repository;
	private IList<TaskModel> _tasks;

	public StartPage()
	{
		InitializeComponent();
		_repository = new TaskModelRepository();
		LoadData();
	}
	public void LoadData()
	{
		_tasks = _repository.GetAll();
		CollectionViewTasks.ItemsSource = _tasks;
		lblEmptyText.IsVisible = _tasks.Count <= 0;
	}
	private void OnButtonClickedToAdd(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new AddEditTaskPage());
    }

	private void OnBorderClickedToFocusEntry(object sender, TappedEventArgs e)
	{
		Entry_Search.Focus();
	}

	private async void OnImageClickedToDelete(object sender, TappedEventArgs e)
	{
		var task = (TaskModel)e.Parameter;
		var confirm = await DisplayAlert("Confirme a exclus�o!", $"Tem certeza que deseja excluir essa tarefa: {task.Name}?", "Sim", "N�o");
		if (confirm)
		{
			_repository.Delete(task);
			LoadData();
		}
	}

	private void OnCkeckBoxClickedToComplete(object sender, TappedEventArgs e)
	{
		var checkbox = ((CheckBox)sender);
		var task = (TaskModel)e.Parameter;

		if (DeviceInfo.Platform != DevicePlatform.WinUI)
			checkbox.IsChecked = !checkbox.IsChecked;

		task.IsCompleted = checkbox.IsChecked;
		_repository.Update(task);
	}

	private void OnTapToEdit(object sender, TappedEventArgs e)
	{
		var task = (TaskModel) e.Parameter;
		Navigation.PushModalAsync(new AddEditTaskPage(_repository.GetById(task.Id)));
    }

	private void OnTextChanged_FilterList(object sender, TextChangedEventArgs e)
	{
		var word = e.NewTextValue;
		CollectionViewTasks.ItemsSource = _tasks.Where(a => a.Name.ToLower().Contains(word.ToLower()));
	}
}