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
		builder.Services.AddSingleton<MoviesService>();
        builder.Services.AddSingleton<MoviesViewModel>();
        builder.Services.AddSingleton<MainPage>();


		return builder.Build();
	}
}
