using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoginFinal : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField nameField;
    public InputField passwordField;
    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(Login());
    }
    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("Name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://baum.epizy.com/goodStuff/login2.php", form);
        yield return www;
        
        if(www.text[0] == '0')
        {
            DBManager.username = nameField.text;
            DBManager.score = int.Parse(www.text.Split('\t')[1]);
            DBManager.timePlayed = int.Parse(www.text.Split('\t')[2]);
            DBManager.levelOneScore = int.Parse(www.text.Split('\t')[3]);
            DBManager.levelTwoScore = int.Parse(www.text.Split('\t')[4]);
            DBManager.levelThreeScore = int.Parse(www.text.Split('\t')[5]);
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            gameObject.GetComponent<Text>().text = "User login failed Error " + www.text;
        }

    }
    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 8);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (nameField.GetComponent<InputField>().isFocused)
            {
                passwordField.GetComponent<InputField>().Select();
            }
        }
    }
}
