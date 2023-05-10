using System.Windows.Controls;

namespace SimplePasswordManager.MVVM.ViewModel;

public class ManagePasswordsViewModel : Core.ViewModel
{
    private string _appPassword = "AppPassword";

    public string AppPassword
    {
        get => _appPassword;
        set
        {
            _appPassword = value;
            OnPropertyChanged();
        }
    }
    
    private string _appName = "AppName";

    public string AppName
    {
        get => _appName;
        set
        {
            _appName = value;
            OnPropertyChanged();
        }
    }
    private string _appUsername = "Username";

    public string AppUsername
    {
        get => _appUsername;
        set
        {
            _appUsername = value;
            OnPropertyChanged();
        }
    }

    public ManagePasswordsViewModel()
    {
        
    }
}