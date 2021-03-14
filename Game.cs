using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour
{
   

  

    
    public  void CallSaveData()
    {
        StartCoroutine(SavePlayerData());
    }
   public  IEnumerator SavePlayerData()
    {
        WWWForm form = new WWWForm();
        form.AddField("Name", DBManager.username);
        form.AddField("score", DBManager.score);
        form.AddField("level", DBManager.level);
        form.AddField("timePlayed", DBManager.timePlayed);
        form.AddField("levelOneScore", DBManager.levelOneScore);
        form.AddField("levelTwoScore", DBManager.levelTwoScore);
        form.AddField("levelThreeScore", DBManager.levelThreeScore);
        WWW www = new WWW("http://192.168.1.83/sqlconnect/savedata2.php", form);
        yield return www;
        if (www.text == "0")
        {
            gameObject.GetComponent<Text>().text = "Game Saved.";
        }
        else
        {
            gameObject.GetComponent<Text>().text = "Game Saved. Stats Updated";

        }
       
    }
   
    
}
