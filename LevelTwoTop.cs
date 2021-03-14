using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelTwoTop : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public static int score;
    public int dbscore;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinCountScript.coinAmount > 40  && DBManager.level == 2)
        {
            if (LevelTwoWin.triggered == true && CoinCountScript.coinAmount >= 100)
            {
                
                score = CoinCountScript.coinAmount;
                score += 5;

                if (score < DBManager.score)
                {
                    
                    text.text = score.ToString();
                }
                else
                {
                    

                    text.text = score.ToString();
                    DBManager.score = score;
                    DBManager.levelTwoScore = score;
                }
            }
            else
            {
                score = CoinCountScript.coinAmount;
                if (score < DBManager.score)
                {
                    text.text = CoinCountScript.coinAmount.ToString();
                }
                else
                {
                    text.text = CoinCountScript.coinAmount.ToString();
                    DBManager.score = score;
                    DBManager.levelTwoScore = score;
                }

            }
        }
    }
}
