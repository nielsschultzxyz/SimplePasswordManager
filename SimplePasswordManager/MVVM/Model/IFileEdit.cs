namespace SimplePasswordManager.MVVM.Model;

public interface IFileEdit
{
    string getTxtFileValues(string path);
    void setTxtFileValues(string path, string value);
}