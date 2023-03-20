namespace Movies.ViewModel;

[QueryProperty("Movie", "Movie")]
public partial class MoviesDetailsViewModel : BaseViewModel
{
    public MoviesDetailsViewModel() 
    { 
         
    }

    [ObservableProperty]
    Movie movie;

    [RelayCommand]
    async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}
