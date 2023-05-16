using System;
using System.IO;
using System.Windows;

namespace SimplePasswordManager.MVVM.Model;

public class FileEdit : IFileEdit
{
    public string getTxtFileValues(string path)
    {
        var txtStringValues = "";
        
        try
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        txtStringValues += sr.ReadLine() + Environment.NewLine;
                    }
                    sr.Close();
                }
            }
            else
            {
                File.Create(@"..\..\PasswordManageTxtFile.txt");
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Error msg:\n{exception.Message}");
        }
        return txtStringValues;
    }

    public void setTxtFileValues(string path, string value)
    {
        try
        {
            if (File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path, append: true))
                {
                    sw.WriteLine(value);
                    sw.Close();
                } 
            }
            else
            {
                MessageBox.Show($"Filepath cant be found {path}");
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }
}