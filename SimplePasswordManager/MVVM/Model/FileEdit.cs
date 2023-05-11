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
            using (StreamReader sr = new StreamReader(path))
            {
                if (File.Exists(path))
                {
                    while (!sr.EndOfStream)
                    {
                        txtStringValues += sr.ReadLine() + Environment.NewLine;
                    }
                    sr.Close();
                }
                else
                {
                    File.Create(@"..\..\PasswordManageTxtFile.txt");
                }
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
            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                if (File.Exists(path))
                {
                    sw.WriteLineAsync(value);
                }
                sw.Close();
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }
}