using Microsoft.Extensions.Logging;
using Movies.Services;
using Movies.ViewModel;
using Movies.View;

namespace Movies;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
		builder.Services.AddSingleton<MoviesService>();
        builder.Services.AddSingleton<MoviesViewModel>();
		builder.Services.AddTransient<MoviesDetailsViewModel>();
        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<DetailsPage>();


		return builder.Build();
	}
}
