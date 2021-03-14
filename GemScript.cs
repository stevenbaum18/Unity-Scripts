using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool destroyed = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (destroyed == false && gameObject.tag == "Gems")
        {
            destroyed = true;
            CoinCountScript.coinAmount += 3;
            Destroy(gameObject);
        }

    }
}
