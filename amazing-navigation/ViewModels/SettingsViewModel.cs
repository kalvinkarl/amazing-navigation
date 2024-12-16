using amazing_navigation.Contracts;
using amazing_navigation.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace amazing_navigation.ViewModels;

public partial class SettingsViewModel : ViewModel
{
    [ObservableProperty] private INavigationService _navigationService;

    public SettingsViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    [RelayCommand]
    private void NavToHome()
    {
        NavigationService.NavigateTo<HomeViewModel>();
    }
}
