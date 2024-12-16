using amazing_navigation.Contracts;
using amazing_navigation.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace amazing_navigation.ViewModels;

public partial class HomeViewModel : ViewModel
{
    [ObservableProperty] private INavigationService _navigationService;

    public HomeViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    [RelayCommand]
    private void NavToSettings()
    {
        NavigationService.NavigateTo<SettingsViewModel>();
    }
}
