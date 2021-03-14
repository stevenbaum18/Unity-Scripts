using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StatsButton : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    public void StatButton()
    {
        Application.LoadLevel("Stats");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
