using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
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

    private string _appNameInfo = "AppNameInfo";

    public string AppNameInfo
    {
        get => _appNameInfo;
        set
        {
            _appNameInfo = value;
            OnPropertyChanged();
        }
    }

    private string _appUsernameInfo = "AppUsernameInfo";

    public string AppUsernameInfo
    {
        get => _appUsernameInfo;
        set
        {
            _appUsernameInfo = value;
            OnPropertyChanged();
        }
    }

    private string _appPasswordInfo = "AppPasswordInfo";

    public string AppPasswordInfo
    {
        get => _appPasswordInfo;
        set
        {
            _appPasswordInfo = value;
            OnPropertyChanged();
        }
    }
    
    //  RelayCommands
    public RelayCommand AddNewManagePasswordCommand { get; set; }
    public RelayCommand ShowPasswordClearTextCommand { get; set; }

    // Collection
    private static ObservableCollection<PasswordManageModel>? _passwordManageCollection;

    public static ObservableCollection<PasswordManageModel>? PasswordManageCollection
    {
        get => _passwordManageCollection;
        set
        {
            _passwordManageCollection = value;
            //OnPropertyChanged();
        }
    }

    public ManagePasswordsViewModel()
    {
        _encryptionHandler = new EncryptionHandler();
        _fileEdit = new FileEdit();
        PasswordManageCollection = new ObservableCollection<PasswordManageModel>();
        
        var txtManagePasswordString = _fileEdit.getTxtFileValues(filePath);
        getCollecionValues(txtManagePasswordString);
        
        // TODO: ListViewItem isSelected -> fill props PasswordInfos (AppName, AppUsername, AppPassword) if-statemente in ShowPasswordClearText to check and confirm the values?
        
        // RelayCommands
        AddNewManagePasswordCommand = new RelayCommand(o =>
        {
            var newManagePassowrdInfoString = $"{AppName} {AppUsername} {_encryptionHandler.Encrypt(AppPassword)};";
            _fileEdit.setTxtFileValues(filePath, newManagePassowrdInfoString);
            
            // Add Model
            PasswordManageCollection.Add(new PasswordManageModel(AppName, AppUsername, _encryptionHandler.Encrypt(AppPassword)));
            MessageBox.Show($"Added new ManagePassword:\n{AppName}, {AppUsername}, {_encryptionHandler.Encrypt(AppPassword)}");

            // set default values
            AppName = "AppName";
            AppUsername = "Username";
            AppPassword = "AppPassword";
        }, o => true);

        ShowPasswordClearTextCommand = new RelayCommand(o =>
        {
            // get the cipherText out of the Model -> in terms to display clearText
            AppPasswordInfo = _encryptionHandler.Decrypt(AppPasswordInfo);
        }, o => true);
    }

    private void getCollecionValues(string txtFileValues)
    {
        if (string.IsNullOrEmpty(txtFileValues))
        {
            return;
        }

        try
        {
            string[] splitManagePasswordLine = txtFileValues.Split(";");
            string[] splitManagePasswordStrings;

            foreach (var s in splitManagePasswordLine)
            {
                splitManagePasswordStrings = s.Split(" ");
                PasswordManageCollection?.Add(new PasswordManageModel(splitManagePasswordStrings[0], 
                    splitManagePasswordStrings[1], splitManagePasswordStrings[2]));
            }
        }
        catch (Exception ex)    
        {
            MessageBox.Show(ex.Message);
        }
    }
}