using amazing_navigation.Helpers;

namespace amazing_navigation.Contracts
{
    public interface INavigationService
    {
        ViewModel CurrentView { get; }
        void NavigateTo<T>() where T : ViewModel;
    }
}
