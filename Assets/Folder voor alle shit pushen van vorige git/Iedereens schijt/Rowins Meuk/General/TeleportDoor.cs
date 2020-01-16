using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportDoor : MonoBehaviour
{
    public bool storage, consultant, house;
    public Loading loading;
    public KnowledgeMeter kn;

    public string room;
    [Header("Extra House")]
    public string spooky, middle;

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.CompareTag("Player"))
        {   
            print("Door");
            if(storage == true)
            {
                loading.LevelLoader(room);
                print("Storage");
            }
            else if(consultant == true)
            {
                loading.LevelLoader(room);
                print("Consultant");
            }
            else if(house == true)
            {
                if(kn.knowledgeAmount >= 0 && kn.knowledgeAmount < 30)
                {
                  loading.LevelLoader(room);  
                }
                else if(kn.knowledgeAmount >= 30 && kn.knowledgeAmount < 60)
                {
                    loading.LevelLoader(room);
                }
                else if(kn.knowledgeAmount >= 60)
                {
                    loading.LevelLoader(room);
                }
            }
        }
    }
}
