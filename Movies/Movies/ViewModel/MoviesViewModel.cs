﻿using Movies.Services;
namespace Movies.ViewModel;

public partial class MoviesViewModel : BaseViewModel
{
    MoviesService moviesService;
    public ObservableCollection<Movie> Movies { get; } = new();

    public MoviesViewModel(MoviesService moviesService)
    {
        Title = "Movies";
        this.moviesService = moviesService;
     
     }

    [RelayCommand]
    async Task GetMoviesAsync()
    {
        if(IsBusy) return;

        try
        {
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
        }
    }

}
