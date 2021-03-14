using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class LevelThreeCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (CoinCountScript.coinAmount >= 155)
        {
            Destroy(this.gameObject);
        }
        else if (CoinCountScript.coinAmount < 155)
        {

            Destroy(other.gameObject);
            StartCoroutine(SavePlayerData());
            Application.LoadLevel("Leaderboard");
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
        public IEnumerator SavePlayerData()
        {
            WWWForm form = new WWWForm();
            form.AddField("Name", DBManager.username);
            form.AddField("score", DBManager.score);
            form.AddField("level", DBManager.level);
            form.AddField("timePlayed", DBManager.timePlayed);
            form.AddField("levelOneScore", DBManager.levelOneScore);
            form.AddField("levelTwoScore", DBManager.levelTwoScore);
            WWW www = new WWW("http://192.168.1.83/sqlconnect/savedata2.php", form);
            yield return www;
            if (www.text == "0")
            {
                gameObject.GetComponent<Text>().text = "Game Saved.";
            }
            else
            {
                gameObject.GetComponent<Text>().text = "Ignore unless score doesn't save :Possible Error " + www.text;

            }

        }

    }

