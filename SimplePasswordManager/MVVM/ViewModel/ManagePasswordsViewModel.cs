using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using SimplePasswordManager.Core;
using SimplePasswordManager.Encryption;
using SimplePasswordManager.MVVM.Model;
using SimplePasswordManager.MVVM.View;

namespace SimplePasswordManager.MVVM.ViewModel;

public class ManagePasswordsViewModel : Core.ViewModel
{
    private readonly string filePath = @"..\..\PasswordManageTxtFile.txt";
    
    private EncryptionHandler _encryptionHandler;
    private FileEdit _fileEdit;
    
    public static PasswordManageModel _passwordManageModel { get; set; }
    
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

    private string _appNameInfo = $"AppNameInfo";

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
    public RelayCommand ShowManagePasswordValuesCommand { get; set; }

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
        _passwordManageModel = new PasswordManageModel("AppName", "AppUsername", "AppPassword");
        
        var txtManagePasswordString = _fileEdit.getTxtFileValues(filePath);
        getCollecionValues(txtManagePasswordString);
        
        // RelayCommands
        AddNewManagePasswordCommand = new RelayCommand(o =>
        {
            var newManagePassowrdInfoString = $"{AppName} {AppUsername} {_encryptionHandler.Encrypt(AppPassword)}";
            _fileEdit.setTxtFileValues(filePath, newManagePassowrdInfoString);
            
            // Add Model
            PasswordManageCollection.Add(new PasswordManageModel(AppName, AppUsername, _encryptionHandler.Encrypt(AppPassword)));
            MessageBox.Show($"Added new ManagePassword:\n{AppName}, {AppUsername}, {_encryptionHandler.Encrypt(AppPassword)}");

            // set default values
            AppName = "AppName";
            AppUsername = "Username";
            AppPassword = "AppPassword";
        }, o => true);

        ShowManagePasswordValuesCommand = new RelayCommand(o =>
        {
            if (string.IsNullOrEmpty(_passwordManageModel.appPassword))
                return;

            AppNameInfo = _passwordManageModel.appName;
            AppUsernameInfo = _passwordManageModel.appUsername;
            AppPasswordInfo = _passwordManageModel.appPassword;

        }, o => true);
        
        ShowPasswordClearTextCommand = new RelayCommand(o =>
        {
            AppPasswordInfo = _encryptionHandler.Decrypt(_passwordManageModel.appPassword);
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
            string[] splitManagePasswordLine = txtFileValues.Split("\n");
            string[] splitManagePasswordStrings;

            PasswordManageModel addPasswordModel;

            if (splitManagePasswordLine.Length > 0)
            {
                for (int i = 0; i < splitManagePasswordLine.Length -1; i++)
                {
                    splitManagePasswordStrings = splitManagePasswordLine[i].Split(" ");
                    
                    addPasswordModel = new PasswordManageModel(splitManagePasswordStrings[0],
                        splitManagePasswordStrings[1],
                        splitManagePasswordStrings[2]);
                    
                    PasswordManageCollection?.Add(addPasswordModel);
                }    
            }
        }
        catch (Exception ex)    
        {
            MessageBox.Show(ex.Message);
        }
    }
}