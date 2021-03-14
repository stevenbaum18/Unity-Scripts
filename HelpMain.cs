using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
public class HelpMain : MonoBehaviour
{
    // Start is called before the first frame update
    public Button helpButton;
    public void HelpButton()
    {

        Application.LoadLevel("HelpMain");

    }
    void Start()
    {
        helpButton.onClick.AddListener(HelpButton);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
