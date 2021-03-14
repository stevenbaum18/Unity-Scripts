using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    bool destroyed = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(destroyed == false && gameObject.tag == "Coins" && other.tag == "Player")
        {
            destroyed = true;
            CoinCountScript.coinAmount += 1;
            Destroy(gameObject);
        }
            
    }
}
