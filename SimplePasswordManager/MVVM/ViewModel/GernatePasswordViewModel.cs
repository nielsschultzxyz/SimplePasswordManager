using System;
using System.Windows;
using System.Windows.Controls;
using SimplePasswordManager.Core;

namespace SimplePasswordManager.MVVM.ViewModel;

public class GernatePasswordViewModel : Core.ViewModel
{
    private int _passwordLength { get; set; }

    public int PasswordLength
    {
        get => _passwordLength;
        set
        {
            _passwordLength = value;
            OnPropertyChanged(nameof(PasswordLength));
        }
    }
    private int _passwordUppercaseLetters { get; set; }

    public int PasswordUppercaseLetters
    {
        get => _passwordUppercaseLetters;
        set
        {
            _passwordUppercaseLetters = value;
            OnPropertyChanged();
        }
    }
    private int _passwordSpecialChars { get; set; }

    public int PasswordSpecailChars
    {
        get => _passwordSpecialChars;
        set
        {
            _passwordSpecialChars = value;
            OnPropertyChanged();
        }
    }
  
    private string _generatedPassword { get; set; }

    public string GenerateedPassword
    {
        get => _generatedPassword;
        set
        {
            _generatedPassword = value;
            OnPropertyChanged();
        }
    }
    public RelayCommand GeneratePasswordCommand { get; set; }
    public GernatePasswordViewModel()
    {
        GeneratePasswordCommand = new RelayCommand(o =>
        {
            int length = 0, upper = 0, specail = 0;
            if (string.IsNullOrEmpty(PasswordLength.ToString()))
            {
                MessageBox.Show("Please enter a Length!");
            } else if (string.IsNullOrEmpty(PasswordUppercaseLetters.ToString()))
            {
                MessageBox.Show("Please enter amount of Uppercase letters!");
            }
            else if (string.IsNullOrEmpty(PasswordSpecailChars.ToString()))
            {
                MessageBox.Show("Please enter the amount of specialcharacter!");
            }
            else
            {
                length = Convert.ToInt32(PasswordLength);
                upper = Convert.ToInt32(PasswordUppercaseLetters);
                specail = Convert.ToInt32(PasswordSpecailChars);
            }
            GenerateedPassword = generateRandomPassword(length, upper, specail);
        }, o => true);
    }

    private static string generateRandomPassword(int length, int upper, int specialCharacter)
    {
        Random random = new Random();
        int letter = 0, position = 0, counter = 0;
        string[] tempPw = new string[length];
        bool specialCharFound = false;

        string[] letters =
        {
            "a", "b", "c", "d", "e", "f", "g", "h",
            "k", "i", "j", "k", "l", "m", "n", "o",
            "p", "q", "r", "s", "t", "u", "v", "w",
            "x", "y", "z"
        };

        string[] specialChars =
        {
            "[", "]", "!", "§", "%", "&", "(", ")", "=", "?", "^", "<", ">", "-", "_", "+", "*", "#", ",", ";", ".", ":"
        };
        
        for(int i = 0; i < length; i++)
        {
            letter = random.Next(letters.Length);
            tempPw[i] = letters[letter];
        }

        for (int i = 0; i < specialCharacter; i++)
        {
            letter = random.Next(specialChars.Length);
            position = random.Next(tempPw.Length);

            tempPw[position] = specialChars[letter];
        }

        while(counter <= upper)
        {
            position = random.Next(tempPw.Length);

            for(int i = 0; i < specialChars.Length; i++)
            {
                if (tempPw[position] == specialChars[i])
                {
                    specialCharFound = true;
                    break;
                }
            }

            if(specialCharFound == false)
            {
                tempPw[position] = tempPw[position].ToUpper();
                counter++;
            }
            specialCharFound = false;
        }

        return string.Join("", tempPw);
    }
}