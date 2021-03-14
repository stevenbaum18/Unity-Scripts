using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
public class PlayAgain : MonoBehaviour
{
    public Button playAgainButton;
  
    public void PlayAgainButton()
    {
        CoinCountScript.coinAmount = 0;
        CharacterController2D.m_JumpForce = 700f;
        PlayerMovement.runSpeed = 40f;
    Application.LoadLevel("StartMenu");
    
    }
    // Start is called before the first frame update
  void Start()
    {
        playAgainButton.onClick.AddListener(PlayAgainButton);
        
    }
    // Update is called once per frame
    void Update()
    {
       
        
    }
   
}
