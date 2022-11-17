using Android.Media;
using CommunityToolkit.Maui;

namespace ShellNavigation;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    {

        Routing.RegisterRoute("/TestPage", typeof(TestPage));
        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}

