using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class BackLogin : MonoBehaviour
{
    // Start is called before the first frame update
    public Button backButton;
    // Start is called before the first frame update
    public void BackButton()
    {

        Application.LoadLevel("Login");

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
