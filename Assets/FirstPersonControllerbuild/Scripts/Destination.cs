using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{
    public KnowledgeMeter knowledgeMeter;
    public bool backHome;
    public string myName,myNameBad,myNameGood;

    public void OnCollisionEnter(Collision c)
    {        
        if(c.gameObject.tag == "Player")
        {
            if (backHome)
            {
                if(knowledgeMeter.knowledgeAmount < 30)
                {
                    c.gameObject.GetComponent<DoorTeleport>().NewDestination(myNameBad);
                }

                else if(knowledgeMeter.knowledgeAmount > 30 && knowledgeMeter.knowledgeAmount < 90)
                {
                    c.gameObject.GetComponent<DoorTeleport>().NewDestination(myName);
                }

                else if(knowledgeMeter.knowledgeAmount >= 90)
                {
                    c.gameObject.GetComponent<DoorTeleport>().NewDestination(myNameGood);
                }
            }
            else
            {
                c.gameObject.GetComponent<DoorTeleport>().NewDestination(myName);
            }
        }        
    }
}
