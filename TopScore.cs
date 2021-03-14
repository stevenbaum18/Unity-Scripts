using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TopScore : MonoBehaviour
{
    Text text;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinCountScript.coinAmount < 41)
        {
            if (WinGame.triggered == true && CoinCountScript.coinAmount >= 35)
            {
                score = CoinCountScript.coinAmount;
                score += 5;
                DBManager.score = 40;
                if (score < DBManager.score)
                {
                    text.text = score.ToString();
                }
                else
                {
                    text.text = score.ToString();
                    DBManager.score = score;
                    DBManager.levelOneScore = score;
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
                    DBManager.levelOneScore = score;
                }

            }
        }
    }
}
