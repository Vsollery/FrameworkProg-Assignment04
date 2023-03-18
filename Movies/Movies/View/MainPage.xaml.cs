namespace Movies.View;

public partial class MainPage : ContentPage
{
	public MainPage(MoviesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

