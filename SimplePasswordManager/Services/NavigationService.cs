using System;
using System.Collections.ObjectModel;
using SimplePasswordManager.Core;

namespace SimplePasswordManager.Services;

public class NavigationService : ObservableObject, INavigationService
{
    private Func<Type, ViewModel> _viewModelFactory;
    
    private ViewModel _currentView;
    public ViewModel CurrentView
    {
        get => _currentView;
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public NavigationService(Func<Type, ViewModel> viewModelFactory)
    {
        _viewModelFactory = viewModelFactory;
    }
    
    public void NavigateTo<TViewModel>() where TViewModel : ViewModel
    {
        ViewModel viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
        CurrentView = viewModel;
    }
}