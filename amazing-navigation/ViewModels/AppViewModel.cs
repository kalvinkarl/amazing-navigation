using amazing_navigation.Contracts;
using amazing_navigation.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace amazing_navigation.ViewModels;

public partial class AppViewModel : ViewModel
{
    [ObservableProperty]
    private INavigationService _navigationService;

    public AppViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
        NavigationService.NavigateTo<HomeViewModel>();
    }

    [RelayCommand]
    private void NavigateToHome()
    {
        NavigationService.NavigateTo<HomeViewModel>();
    }

    [RelayCommand]
    private void NavigateToSettings()
    {
        NavigationService.NavigateTo<SettingsViewModel>();
    }
}
