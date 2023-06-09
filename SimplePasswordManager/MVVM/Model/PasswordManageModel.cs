﻿namespace SimplePasswordManager.MVVM.Model;

public class PasswordManageModel
{
    public string appName { get; set; }
    public string appUsername { get; set; }
    public string appPassword { get; set; }

    public PasswordManageModel(string appName, string appUsername, string appPassword)
    {
        this.appName = appName;
        this.appUsername = appUsername;
        this.appPassword = appPassword;
    }
}