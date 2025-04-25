using AppMAUIGallery.Views.Lists.Models;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Views.Lists;

public partial class CollectionViewPage : ContentPage
{
	ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
	int countMovies = 0;
	public CollectionViewPage()
	{
		InitializeComponent();
		AddTenMovies();
		CollectionViewControl.ItemsSource = MovieList.GetGroupList();
	}

	private async void RefreshView_Refreshing(object sender, EventArgs e)
	{
		((RefreshView)sender).IsRefreshing = true;

		await Task.Delay(3000);
		CollectionViewControl.ItemsSource = MovieList.GetList();

		((RefreshView)sender).IsRefreshing = false;
	}

	private void CollectionViewControl_RemainingItemsThresholdReached(object sender, EventArgs e)
	{
		AddTenMovies();
	}
	private void AddTenMovies()
	{
		for (int i = 0; i < 20; i++)
		{
			Movie movie = new Movie()
			{
				Id = ++countMovies,
				Name = $"Movie {countMovies}",
				Description = $"Movie {countMovies}",
				LaunchYear = 2022,
				Duration = new TimeSpan(2, 0, 0)
			};
			movies.Add(movie);
		}
	}

	private void CollectionViewControl_Scrolled(object sender, ItemsViewScrolledEventArgs e)
	{
		lblScrollStatus.Text = $"Posicionamento: {e.VerticalOffset} - Espa�amento: {e.VerticalDelta}";
		//if (DeviceInfo.Platform != DevicePlatform.WinUI) return;
		//if(sender is CollectionView cv)
		//{
		//	var lastVisibleItem = e.LastVisibleItemIndex;
		//	var remainingItemsThreshold = cv.RemainingItemsThreshold;
		//	var totalItem = ((IEnumerable<object>)cv.ItemsSource).Count();

		//	if(lastVisibleItem > totalItem - remainingItemsThreshold)
		//	{
		//		AddTenMovies();
		//	}
		//}
	}

	private void CollectionViewControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		StringBuilder sb = new StringBuilder();
		foreach (Movie movie in e.CurrentSelection)
		{
			sb.Append(movie.Name + " - ");
		}
		lblSelectedMovies.Text = sb.ToString();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		var group = (List<GroupMovie>)CollectionViewControl.ItemsSource;
		var item = group[2][0];

		CollectionViewControl.ScrollTo(item, position: ScrollToPosition.Start);
		//CollectionViewControl.ScrollTo(4, position: ScrollToPosition.Start);
	}
}