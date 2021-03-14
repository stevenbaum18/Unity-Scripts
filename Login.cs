using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;
public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    public static string Username;
    private string Password;
    private string[] Lines;
    private string DecryptPass;

    public void LoginButton()
    {
        bool UserName = false;
        bool PW = false;
        if(Username != "")
        {
            if(System.IO.File.Exists(@"C:\Users\tzvil\Desktop\TestFolder\" + Username + ".txt"))
            {
                UserName = true;
                Lines = System.IO.File.ReadAllLines(@"C:\Users\tzvil\Desktop\TestFolder\" + Username + ".txt");
            }
            else
            {
                Debug.LogWarning("Username invalid");
            }
        }
        else
        {
            Debug.LogWarning("Username field empty");
        }
        if (Password != "")
        {
            if (System.IO.File.Exists(@"C:\Users\tzvil\Desktop\TestFolder\" + Username + ".txt")) { 
            
            int i = 1;
                foreach (char c in Lines[2])
                {
              
                i++;
                char Decrypted = (char)(c / i);
                DecryptPass += Decrypted.ToString();
                }
                if(Password == DecryptPass)
                {
                    PW = true;
                }
                else
                {
                    Debug.LogWarning("Password Incorrect");
                }
            }
        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }
        if(UserName == true && PW == true)
        {
            username.GetComponent<InputField>().text ="";
            password.GetComponent<InputField>().text = "";
            print("Login Successful");
            Application.LoadLevel("StartMenu");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) { 
            if (username.GetComponent<InputField>().isFocused)
            {
            password.GetComponent<InputField>().Select();
            }
    }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != ""  && Username != "")
            {
                LoginButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}
