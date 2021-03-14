using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class Back : MonoBehaviour
{
    public Button backButton;
    // Start is called before the first frame update
    public void BackButton()
    {

        Application.LoadLevel("StartMenu");

    }

    void Start()
    {
        backButton.onClick.AddListener(BackButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
