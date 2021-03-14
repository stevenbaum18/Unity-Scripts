using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimePlayed : MonoBehaviour
{
    Text text;
    string playtime;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playtime = DBManager.timePlayed.ToString();
        text.text = playtime;
    }
}
