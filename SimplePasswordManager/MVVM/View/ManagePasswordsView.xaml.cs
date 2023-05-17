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
        if (PasswordManageListView.SelectedItem == null || ManagePasswordsViewModel.PasswordManageCollection == null) 
            return;
        
        // Compare values
        foreach (PasswordManageModel model in ManagePasswordsViewModel.PasswordManageCollection)
        {
            if (model.appName == PasswordManageListView.ToString())
            {
                MessageBox.Show("Item has been found!");
                    
                ManagePasswordsViewModel._passwordManageModel.appName = model.appName;
                ManagePasswordsViewModel._passwordManageModel.appUsername = model.appUsername;
                ManagePasswordsViewModel._passwordManageModel.appPassword = model.appPassword;
                
                return;
            }
        }
        /*
        var selectedItems = PasswordManageListView.SelectedItems;

        if (selectedItems != null)
        {
            foreach (ListViewItem item in selectedItems)
            {
                ManagePasswordsViewModel.PasswordManageCollection.Contains((PasswordManageModel)selectedItems);
               
                foreach (PasswordManageModel model in ManagePasswordsViewModel.PasswordManageCollection)
                {
                    if (model.appName == item.ToString())
                    {
                        MessageBox.Show("Item has been found!");
                    
                        ManagePasswordsViewModel._passwordManageModel.appName = model.appName;
                        ManagePasswordsViewModel._passwordManageModel.appUsername = model.appUsername;
                        ManagePasswordsViewModel._passwordManageModel.appPassword = model.appPassword;

                        break;
                    }
                }
            }
        }
        */
    }
}