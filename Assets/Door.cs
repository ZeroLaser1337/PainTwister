using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PlayerTag")
        {
            Debug.Log(collision.gameObject.name);
        }
    }
}
