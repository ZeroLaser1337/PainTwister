using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{
    public string myName;

    public void OnCollisionEnter(Collision c)
    {        
        if(c.gameObject.tag == "Player")
        {
            print(c.gameObject);
            c.gameObject.GetComponent<DoorTeleport>().NewDestination(myName);
        }        
    }
}
