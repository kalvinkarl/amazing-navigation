using amazing_navigation.Contracts;
using amazing_navigation.Helpers;
using CommunityToolkit.Mvvm.ComponentModel;

namespace amazing_navigation.Services;

public partial class NavigationService : ObservableObject, INavigationService
{
    [ObservableProperty]
    private ViewModel? _currentView;

    private Func<Type, ViewModel> _viewModelFactory;

    public NavigationService(Func<Type, ViewModel> viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
    }

    public void NavigateTo<TViewModel>() where TViewModel : ViewModel
    {
        var viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
        CurrentView = viewModel;
    }
}
