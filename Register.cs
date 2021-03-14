using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class Register : MonoBehaviour {
    public GameObject username;
    public GameObject email;
    public GameObject password;
    public GameObject confPassword;
    private string Username;
    private string Email;
    private string Password;
    private string ConfPassword;
    private string form;
    private bool EmailValid = false;
    private string[] Characters = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                                   "A","B","C","D","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                   "1","2","3","4","5","6","7","8","9","0","_","-"};
    // Start is called before the first frame update
    void Start() { 
    
        
    }
    public void RegisterButton()
    {
        bool UserName = false;
        bool EM = false;
        bool PW = false;
        bool CPW = false;
        if (Username != "")
        {
            if (!System.IO.File.Exists(@"C:\Users\tzvil\Desktop\TestFolder\" + Username + ".txt"))
            {
                UserName = true;
            }
            else
            {
                Debug.LogWarning("Username Taken");
            }
        }
        else
        {
            Debug.LogWarning("Username field empty");
        }
        if(Email != "")
        {
            EmailValidation();
            if (EmailValid)
            {
                if (Email.Contains("@"))
                {
                    if (Email.Contains("."))
                    {
                        EM = true;
                    }
                    else
                    {
                        Debug.LogWarning("Email is Invalid");
                    }
                }
                else
                {
                    Debug.LogWarning("Email is Invalid");
                }
            }
            else
            {
                Debug.LogWarning("Email is Invalid");
            }
        }else
        {
            Debug.LogWarning("Email Field Empty");
        }
        if(Password != "")
        {
            if(Password.Length > 5)
            {
                PW = true;
            }
            else
            {
                Debug.LogWarning("Password must be at least 6 characters");
            }
            
        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }
        if(ConfPassword != "")
        {
            if(ConfPassword == Password)
            {
                CPW = true;
            }
            else
            {
                Debug.LogWarning("Passwords do not match");
            }
        }
        else
        {
            Debug.LogWarning("Confirm Password Field Empty");
        }
        if(UserName == true && EM == true && PW == true && CPW == true)
        {
            bool Clear = true;
            int i = 1;
            foreach(char c in Password)
            {
                if (Clear)
                {
                    Password = "";
                    Clear = false;
                }
                i++;
                char Encrypted = (char)(c * i);
                Password += Encrypted.ToString();
            }
            form = (Username + "\n" + Email + "\n" + Password);
            System.IO.File.WriteAllText(@"C:\Users\tzvil\Desktop\TestFolder\" + Username + ".txt", form);
            username.GetComponent<InputField>().text = "";
            email.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confPassword.GetComponent<InputField>().text = "";
            print("Registration Complete");
        }
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                email.GetComponent<InputField>().Select();
            }
            if (email.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            if (password.GetComponent<InputField>().isFocused)
            {
                confPassword.GetComponent<InputField>().Select();
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != "" && Email != "" && ConfPassword != "" && Username != "")
            {
                RegisterButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Email = email.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfPassword = confPassword.GetComponent<InputField>().text;

    }
    void EmailValidation()
    {
        bool SW = false;
        bool EW = false;
        for(int i = 0; i< Characters.Length; i++)
        {
            if (Email.StartsWith(Characters[i]))
            {
                SW = true;
            }
        }
        for (int i = 0; i < Characters.Length; i++)
        {
            if (Email.EndsWith(Characters[i]))
            {
                EW = true;
            }
        }
        if(SW == true && EW == true)
        {
            EmailValid = true;
        }
        else
        {
            EmailValid = false;
        }
    }
}
