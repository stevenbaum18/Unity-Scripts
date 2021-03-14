using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelThreeTop : MonoBehaviour
{
    public Text text;
    public static int score;
    public int dbscore;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (CoinCountScript.coinAmount > 40&& CoinCountScript.coinAmount > 100)
        {
            if (LevelThreeWin.triggered == true && CoinCountScript.coinAmount >= 155)
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
                    DBManager.levelThreeScore = score;
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
                    DBManager.levelThreeScore = score;
                }

            }
        }
    }
}
