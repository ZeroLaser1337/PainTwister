using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportDoor : MonoBehaviour
{
    public bool storage, consultant, house;
    public Loading loading;

    public string room;

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.CompareTag("PlayerTag"))
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
                loading.LevelLoader(room);
            }
        }
    }
}
