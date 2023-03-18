using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
namespace Movies.Services;

public class MoviesService
{
    HttpClient httpClient;
    public MoviesService()
    {
        httpClient = new HttpClient();
    }
    List<Movie> moviesList = new();
    public async Task<List<Movie>> GetMovies()
    {
        if (moviesList?.Count > 0) return moviesList;

        var url = "https://raw.githubusercontent.com/Vsollery/FrameworkProg-Assignment04/main/Movies/Movies/Resources/Raw/Movies.json";

        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            moviesList = await response.Content.ReadFromJsonAsync<List<Movie>>();
        }

        /*using var stream = await FileSystem.OpenAppPackageFileAsync("Movies.json");
        using var reader = new StreamReader(stream);
        var content = await reader.ReadToEndAsync();
        moviesList = JsonSerializer.Deserialize<List<Movie>>(content); */

        return moviesList;
    }


}
