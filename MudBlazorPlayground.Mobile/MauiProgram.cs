﻿using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using MudBlazorPlayground.Mobile.Data;
using Microsoft.Extensions.DependencyInjection;

namespace MudBlazorPlayground.Mobile;
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

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMudServices();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<CountryService>();

        return builder.Build();
    }
}
