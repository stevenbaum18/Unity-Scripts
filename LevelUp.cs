using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour { 
    
   

   
    public Button levelbutton;
    public void levelUpButton()
    {
            CoinCountScript.coinAmount = 40; //change back to 40
            DBManager.level = 2;
            DBManager.timePlayed++;
        CharacterController2D.m_JumpForce = 700f;
        PlayerMovement.runSpeed = 40f;
        Application.LoadLevel("LevelTwo");
        
    }

    
    void Start()
    {
   
    levelbutton.interactable = false;
        
        if(DBManager.score >= 40)
        {
            levelbutton.interactable = true;
        }
    }
}

