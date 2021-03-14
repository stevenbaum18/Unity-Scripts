using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetScores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetScore());
    }

    // Update is called once per frame
    IEnumerator GetScore()
    {
        gameObject.GetComponent<Text>().text = "Loading Scores";
        WWW hs_get = new WWW("http://192.168.1.83/sqlconnect/display2.php");
        yield return hs_get;
        
        if (hs_get.error != null)
        {
            print("There was an error getting the high score: " + hs_get.error);
        }
        else
        {
            gameObject.GetComponent<Text>().text = hs_get.text; // this is a Text that will display the scores in game.
        }
    }
}
