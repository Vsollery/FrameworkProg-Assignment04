using Movies.Services;
namespace Movies.ViewModel;

public partial class MoviesViewModel : BaseViewModel
{
    MoviesService moviesService;
    public ObservableCollection<Movie> Movies { get; } = new();

    IConnectivity connectivity;

    [ObservableProperty]
    bool isRefreshing;

    public MoviesViewModel(MoviesService moviesService, IConnectivity connectivity)
    {
        Title = "Movies";
        this.moviesService = moviesService;
        this.connectivity = connectivity;
    }

    [RelayCommand]
    async Task GotoDetailsASync(Movie movie)
    {
        if(movie is null) return;

        await Shell.Current.GoToAsync($"{nameof(DetailsPage)}",true,
            new Dictionary<string, object>
            {
                {"Movie", movie }
            });
    }

    [RelayCommand]
    async Task GetMoviesAsync()
    {
        if(IsBusy) return;

        try
        {
            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Internet Issue", $"Check Your Internet and Try Again", "OK");
                return;
            }
            IsBusy = true;
            var movies = await moviesService.GetMovies();

            if(Movies.Count != 0)
                Movies.Clear();

            foreach(var movie in movies)
            {
                Movies.Add(movie);
            }
            

        }catch(Exception ex)
        {   
           Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!", $"Unable to get Movies: {ex.Message}", "OK");
        }
        finally 
        { 
            IsBusy = false;
            isRefreshing = false;
        }
    }

}
