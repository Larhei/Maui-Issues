using Microsoft.Extensions.Logging;

namespace GarbageCollection;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        builder.Services.AddTransient<NoLeak>();
        builder.Services.AddTransient<BackgroundLeak>();
        builder.Services.AddTransient<ButtonStyleLeak>();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        Routing.RegisterRoute("/NoLeak", typeof(NoLeak));
        Routing.RegisterRoute("/BackgroundLeak", typeof(BackgroundLeak));
        Routing.RegisterRoute("/ButtonStyleLeak", typeof(ButtonStyleLeak));
        return builder.Build();
	}
}
