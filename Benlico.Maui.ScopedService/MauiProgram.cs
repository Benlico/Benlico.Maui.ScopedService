using Benlico.Maui.ScopedService.Services;
using Benlico.Maui.ScopedService.ViewModels;
using Benlico.Maui.ScopedService.Views;
using Microsoft.Extensions.Logging;

namespace Benlico.Maui.ScopedService
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

            builder.Services.AddSingleton<ServiceScopeManager>();
            
            builder.Services.AddScoped<SharedService>();

            builder.Services.AddTransient<FirstViewModel>();
            builder.Services.AddTransient<SecondViewModel>();
            builder.Services.AddTransient<ThirdViewModel>();

            builder.Services.AddTransient<FirstView>();
            builder.Services.AddTransient<SecondView>();
            builder.Services.AddTransient<ThirdView>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
