using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using SimplePasswordManager.MVVM.Model;
using SimplePasswordManager.MVVM.ViewModel;

namespace SimplePasswordManager.MVVM.View;

public partial class ManagePasswordsView : UserControl
{
    public ManagePasswordsView()
    {
        InitializeComponent();
    }

    private void SelectedItems(object sender, RoutedEventArgs e)
    {
        if (PasswordManageListView.SelectedItem != null && ManagePasswordsViewModel.PasswordManageCollection != null)
        {
            foreach (PasswordManageModel model in ManagePasswordsViewModel.PasswordManageCollection)
            {
                if (model.appName == PasswordManageListView.ToString())
                {
                    MessageBox.Show("Item has been found!");
                    // static model -> set info value in managepassviewmodel?
                }
            }
        }
    }
}