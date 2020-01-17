using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionShield : MonoBehaviour
{
    public Quest quest;

    public GameObject me;

    public GameObject target;

    public void Start()
    {       
        Physics.IgnoreLayerCollision(8, 9);
    }

    void Update()
    {   
        me.transform.position = target.transform.position;
    }

    private void OnCollisionEnter(Collision c)
    {
        if(c.collider.gameObject.tag == ("Item"))
        {
            Debug.Log("hit");

            if (quest.storyQuests[quest.listPos].questItemNum == c.collider.gameObject.GetComponent<QuestItemNumber>().questNumber)
           {
                quest.storyQuests[quest.listPos].PickUp(quest);

                c.gameObject.transform.position = new Vector3(0,5000,0);
           }
        }
    }
}
