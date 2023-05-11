namespace SimplePasswordManager.Core;

public interface INavigationService
{
    ViewModel CurrentView { get; set; }
    void NavigateTo<T>() where T : ViewModel;
}