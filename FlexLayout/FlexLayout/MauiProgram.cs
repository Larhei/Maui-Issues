using Microsoft.Extensions.Logging;

namespace FlexLayout;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("NotoSans-Regular.ttf", "NotoSansRegular");
                    fonts.AddFont("NotoSans-SemiBold.ttf", "NotoSansSemiBold");
                    fonts.AddFont("NotoSans-Bold.ttf", "NotoSansBold");
                    fonts.AddFont("NotoSerif-Regular.ttf", "NotoSerifRegular");
                    fonts.AddFont("NotoSerif-Bold.ttf", "NotoSerifBold");
                });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
	}
}

