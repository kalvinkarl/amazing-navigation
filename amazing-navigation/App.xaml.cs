using amazing_navigation.Contracts;
using amazing_navigation.Helpers;
using amazing_navigation.Services;
using amazing_navigation.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace amazing_navigation;

public partial class App : Application
{
    private ServiceProvider _serviceProvider;

    public App()
    {
        IServiceCollection services = new ServiceCollection();
        services.AddSingleton<MainWindow>(provider => new MainWindow
        {
            DataContext = provider.GetRequiredService<MainViewModel>()
        });
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<HomeViewModel>();
        services.AddSingleton<SettingsViewModel>();
        services.AddSingleton<INavigationService, NavigationService>();
        services.AddSingleton<Func<Type, ViewModel>>(serviceProvider => viewModelType => (ViewModel)serviceProvider.GetRequiredService(viewModelType));

        _serviceProvider  = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
        base.OnStartup(e);
    }
}
