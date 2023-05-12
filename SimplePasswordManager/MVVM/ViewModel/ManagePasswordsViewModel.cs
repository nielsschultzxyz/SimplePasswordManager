using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using SimplePasswordManager.Core;
using SimplePasswordManager.Encryption;
using SimplePasswordManager.MVVM.Model;

namespace SimplePasswordManager.MVVM.ViewModel;

public class ManagePasswordsViewModel : Core.ViewModel
{
    private readonly string filePath = @"..\..\PasswordManageTxtFile.txt";
    
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

    private ObservableCollection<PasswordManageModel>? _passwordManageCollection;

    public ObservableCollection<PasswordManageModel>? PasswordManageCollection
    {
        get => _passwordManageCollection;
        set
        {
            _passwordManageCollection = value;
            OnPropertyChanged();
        }
    }

    public ManagePasswordsViewModel()
    {
        _encryptionHandler = new EncryptionHandler();
        _fileEdit = new FileEdit();
        PasswordManageCollection = new ObservableCollection<PasswordManageModel>();
        
        var txtManagePasswordString = _fileEdit.getTxtFileValues(filePath);
        getCollecionValues(txtManagePasswordString);
        
        TestCollection = new List<string>()
        {
            "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8" 
        };
        
        // RelayCommands
        AddNewManagePasswordCommand = new RelayCommand(o =>
        {
            var newManagePassowrdInfoString = $"{AppName} {AppUsername} {_encryptionHandler.Encrypt(AppPassword)};";
            _fileEdit.setTxtFileValues(filePath, newManagePassowrdInfoString);   
        }, o => true);
    }

    private void getCollecionValues(string txtFileValues)
    {
        if (string.IsNullOrEmpty(txtFileValues))
        {
            return;
        }
        
        string[] splitManagePasswordLine = txtFileValues.Split(";");
        string[] splitManagePasswordStrings = new string[3];
        
        foreach (var s in splitManagePasswordLine)
        {
            splitManagePasswordStrings = s.Split(" ");
            PasswordManageCollection.Add(new PasswordManageModel(splitManagePasswordStrings[0], splitManagePasswordStrings[1], splitManagePasswordStrings[2]));
        }
    }
}