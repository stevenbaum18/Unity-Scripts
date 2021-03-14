using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool destroyed = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (destroyed == false && gameObject.tag == "Cherries")
        {
            destroyed = true;
            CharacterController2D.m_JumpForce = 1000f;
            PlayerMovement.runSpeed = 70f;
            Destroy(gameObject);
        }

    }
}
