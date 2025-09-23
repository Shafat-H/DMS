using CommunityToolkit.Maui;
using DMS.Plugins.DataStore.InMemory;
using DMS.UseCases;
using DMS.UseCases.Interface;
using DMS.UseCases.PluginsInterface;
using DMS.View_MVVM;
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
            // Shell
            builder.Services.AddSingleton<AppShell>();

            builder.Services.AddSingleton<ItemPage>();
            builder.Services.AddSingleton<ItemEditPage>();
            builder.Services.AddSingleton<ItemAddPage>();
            builder.Services.AddSingleton<DashboardPage>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<Item_MVVM_Page>();

            builder.Services.AddSingleton<ItemsViewModel>();

            builder.Services.AddTransient<IItemRepository, ItemInMemoryRepository>();
            builder.Services.AddTransient<IViewItemUseCase, ViewItemUseCase>();





            

           

            return builder.Build();
        }
    }
}
