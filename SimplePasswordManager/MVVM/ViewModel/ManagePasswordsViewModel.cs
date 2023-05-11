using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using SimplePasswordManager.Encryption;

namespace SimplePasswordManager.MVVM.ViewModel;

public class ManagePasswordsViewModel : Core.ViewModel
{
    private EncryptionHandler _encryptionHandler;
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

    public List<string> TestCollection { get; set; }
    
    public ManagePasswordsViewModel()
    {
        _encryptionHandler = new EncryptionHandler();
        
        TestCollection = new List<string>()
        {
            "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8" 
        };
    }
}