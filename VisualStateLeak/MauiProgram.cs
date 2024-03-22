using Microsoft.Extensions.Logging;

namespace VisualStateLeak
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            Routing.RegisterRoute("//LeakingPage", typeof(LeakingPage));
            Routing.RegisterRoute("//NotLeakingPage", typeof(NotLeakingPage));
            return builder.Build();
        }
    }
}
