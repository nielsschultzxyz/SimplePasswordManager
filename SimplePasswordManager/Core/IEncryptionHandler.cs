namespace SimplePasswordManager.Core;

public interface IEncryptionHandler
{
    string Encrypt(string clearText);
    string Decrypt(string cipherText);
}