using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using SimplePasswordManager.Core;
using SimplePasswordManager.Encryption;
using SimplePasswordManager.MVVM.Model;

namespace SimplePasswordManager.MVVM.ViewModel;

public class ManagePasswordsViewModel : Core.ViewModel
{
    private EncryptionHandler _encryptionHandler;
    private FileEdit _fileEdit;
    
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

    public RelayCommand AddNewManagePasswordCommand { get; set; }
    public List<string> TestCollection { get; set; }
    
    public ManagePasswordsViewModel()
    {
        _encryptionHandler = new EncryptionHandler();
        _fileEdit = new FileEdit();
        
        TestCollection = new List<string>()
        {
            "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8" 
        };
        
        // RelayCommands
        AddNewManagePasswordCommand = new RelayCommand(o =>
        {
            var newManagePassowrdInfoString = $"{AppName},{AppUsername},{_encryptionHandler.Encrypt(AppPassword)};";
            _fileEdit.setTxtFileValues(@"..\..\PasswordManageTxtFile.txt", newManagePassowrdInfoString);   
        }, o => true);
    }
}