using SimplePasswordManager.Core;
using SimplePasswordManager.Services;

namespace SimplePasswordManager.MVVM.ViewModel;

public class MainViewModel : Core.ViewModel
{
    private INavigationService _navigation;

    public INavigationService Navigation
    {
        get => _navigation;
        set
        {
            _navigation = value;
            OnPropertyChanged();
        }
    }
    
    public RelayCommand NavigateToHomeCommand { get; set; }
    public RelayCommand NavigateToGeneratePasswordCommand { get; set; }
    public RelayCommand NavigateToManagePasswordsCommand { get; set; }

    public MainViewModel(INavigationService navSerivce)
    {
        Navigation = navSerivce;

        NavigateToHomeCommand = new RelayCommand(o => { Navigation.NavigateTo<HomeViewModel>(); }, o => true);
        NavigateToGeneratePasswordCommand = new RelayCommand(o => { Navigation.NavigateTo<GernatePasswordViewModel>(); }, o => true);
        NavigateToManagePasswordsCommand = new RelayCommand(o => { Navigation.NavigateTo<ManagePasswordsViewModel>(); }, o => true);
    }
}