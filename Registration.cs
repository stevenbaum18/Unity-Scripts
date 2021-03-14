using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }
    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("Name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("https://venus.cs.qc.cuny.edu/~bast8620/register2.php", form);
        yield return www;
        if(www.text == "0")
        {
            gameObject.GetComponent<Text>().text = "User created Succesfully";

        }
        else
        {
            gameObject.GetComponent<Text>().text = "User creation failed. Error #" + www.text;
        }
        
    }
    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 8);
    }
}
