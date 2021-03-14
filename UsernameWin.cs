using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UsernameWin : MonoBehaviour
{
    Text text;
    string user;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        user = DBManager.username;
        text.text = user;
    }
}
