using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destination : MonoBehaviour
{
    public Quest quest;
    public QuestItemNumber number;

    public bool backHome;
    public string myName,myNameBad,myNameGood;

    public void Update()
    {
        quest = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>();
    }

    public void OnCollisionEnter(Collision c)
    {        
        if(c.gameObject.tag == "Player")
        {
            if(quest.storyQuests[quest.listPos].questItemNum == number.questNumber)
            {
                quest.progression.listPos++;
            }

            if (backHome)
            {
                if(quest.knowledgeMeter.knowledgeAmount < 30)
                {
                    c.gameObject.GetComponent<DoorTeleport>().NewDestination(myNameBad);
                }

                else if(quest.knowledgeMeter.knowledgeAmount > 30 && quest.knowledgeMeter.knowledgeAmount < 90)
                {
                    c.gameObject.GetComponent<DoorTeleport>().NewDestination(myName);
                }

                else if(quest.knowledgeMeter.knowledgeAmount >= 90)
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
