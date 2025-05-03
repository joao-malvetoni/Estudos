namespace AppMAUIGallery.Views.Components.Main;

public partial class ImagePage : ContentPage
{
	public ImagePage()
	{
		InitializeComponent();
		/* Image source pode ter 4 valor
		 * - ImageSource.FromFile
		 * - ImageSource.FromResource
		 * - ImageSource.FromStream
		 * - ImageSource.FromUri
		 */
		//Imagem01.Source = ImageSource.FromUri(new Uri("https://gru.ifsp.edu.br/images/phocagallery/galeria2/image03_grd.png"));
	}
}