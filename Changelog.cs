using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Changelog : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;

    public void ChangelogButton()
    {
        Application.LoadLevel("Changelog");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
