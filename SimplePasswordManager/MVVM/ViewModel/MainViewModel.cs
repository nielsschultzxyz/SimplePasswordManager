using System.Collections.ObjectModel;
using SimplePasswordManager.Core;
using SimplePasswordManager.MVVM.Model;
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

    private ObservableCollection<PasswordManageModel> _allPasswordModels;

    public ObservableCollection<PasswordManageModel> AllPasswordModels
    {
        get => _allPasswordModels;
        set
        {
            _allPasswordModels = value;
            OnPropertyChanged();
        }
    }

    public RelayCommand NavigateToHomeCommand { get; set; }
    public RelayCommand NavigateToGeneratePasswordCommand { get; set; }
    public RelayCommand NavigateToManagePasswordsCommand { get; set; }

    public MainViewModel(INavigationService navSerivce)
    {
        Navigation = navSerivce;
        Navigation.CurrentView = new HomeViewModel();

        NavigateToHomeCommand = new RelayCommand(o => { Navigation.NavigateTo<HomeViewModel>(); }, o => true);
        NavigateToGeneratePasswordCommand = new RelayCommand(o => { Navigation.NavigateTo<GernatePasswordViewModel>(); }, o => true);
        NavigateToManagePasswordsCommand = new RelayCommand(o => { Navigation.NavigateTo<ManagePasswordsViewModel>(); }, o => true);

        AllPasswordModels = new ObservableCollection<PasswordManageModel>()
        {
            new PasswordManageModel("Spotify", "SpotifyUsername", "password"),
            new PasswordManageModel("Email", "EmailUsername", "password"),
            new PasswordManageModel("Discord", "Discord", "password"),
            new PasswordManageModel("JetBrains", "JetBrainsUsername", "password"),
            new PasswordManageModel("CodeWars", "CodeWarsUsername", "password"),
            new PasswordManageModel("LinkedIn", "LinkedInUsername", "password"),
            new PasswordManageModel("Youtube", "YoutubeUsername", "password"),
            new PasswordManageModel("Twitch", "TwitchUsername", "password"),
            new PasswordManageModel("Microsoft", "MicrosoftUsername", "password"),
            new PasswordManageModel("Google", "GoogleUsername", "password"),
            new PasswordManageModel("Battle.net", "BattleNetUsername", "password"),
            new PasswordManageModel("EpicGames", "EpicGamesUsername", "password"),
        };
    }
}