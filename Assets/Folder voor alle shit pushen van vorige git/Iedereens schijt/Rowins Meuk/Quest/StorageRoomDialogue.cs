using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageRoomDialogue : ConversationSystem
{
    public Boxes storageRoom;

    void OnEnable()
    {
        mainQuestion.text = storageRoom.boxesQuestion;
    }
    void Update()
    {
        UpdateButtons();
        UpdateProgress();
    }

    public void StorageRoomButton(int choice)
    {
                  
    }
}
