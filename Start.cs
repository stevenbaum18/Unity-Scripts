using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;
public class Start : MonoBehaviour {


    public Button button;
public void StartButton()
    {
        CoinCountScript.coinAmount = 0;
        DBManager.level = 1;
        DBManager.timePlayed+=1;
        Application.LoadLevel("Game");
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
       
    }
}
