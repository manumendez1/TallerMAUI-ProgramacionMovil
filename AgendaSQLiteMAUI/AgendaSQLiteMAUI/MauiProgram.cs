using Microsoft.Extensions.Logging;
using AgendaSQLiteMAUI.Services;
using AgendaSQLiteMAUI.ViewModels;

namespace AgendaSQLiteMAUI;

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

        // ✅ CORREGIDO: sin parámetro, DatabaseService maneja el path internamente
        builder.Services.AddSingleton<DatabaseService>();

        builder.Services.AddTransient<ContactsViewModel>();
        builder.Services.AddTransient<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}