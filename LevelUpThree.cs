using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelUpThree : MonoBehaviour
{
    public Button levelThreeButton;
    public void levelUpThreeButton()
    {
        CoinCountScript.coinAmount = DBManager.levelTwoScore; 
        DBManager.level = 3;
        DBManager.timePlayed++;
        CharacterController2D.m_JumpForce = 700f;
        PlayerMovement.runSpeed = 40f;
        Application.LoadLevel("LevelThree");

    }


    void Start()
    {

        levelThreeButton.interactable = false;

        if (DBManager.levelTwoScore >= 100)
        {
            levelThreeButton.interactable = true;
        }
    }
}
