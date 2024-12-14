using amazing_navigation.Contracts;
using amazing_navigation.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace amazing_navigation.ViewModels;

public partial class MainViewModel : ViewModel
{
    [ObservableProperty]
    private INavigationService _navigationService;

    public MainViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
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
