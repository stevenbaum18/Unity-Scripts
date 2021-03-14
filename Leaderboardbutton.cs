using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
public class Leaderboardbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public Button lbButton;
    // Start is called before the first frame update
    public void leaderButton()
    {

        Application.LoadLevel("Leaderboard");

    }

    void Start()
    {
        lbButton.onClick.AddListener(leaderButton);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
