using CommunityToolkit.Maui;
using DMS.Plugins.DataStore.InMemory;
using DMS.UseCases;
using DMS.UseCases.Interface;
using DMS.UseCases.PluginsInterface;
using DMS.Views;
using Microsoft.Extensions.Logging;

namespace DMS
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
            builder
             .UseMauiApp<App>()
             .UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<IItemRepository, ItemInMemoryRepository>();

            builder.Services.AddSingleton<IViewItemUseCase, ViewItemUseCase>();

            builder.Services.AddSingleton<ItemPage>();

            return builder.Build();
        }
    }
}
