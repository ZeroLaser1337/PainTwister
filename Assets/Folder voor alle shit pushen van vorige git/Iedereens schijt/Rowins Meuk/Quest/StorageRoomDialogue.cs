using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageRoomDialogue : ConversationSystem
{
    void Update()
    {
        UpdateButtons();
        UpdateProgress();
    }

    public void StorageRoomButton(int choice, int kn)
    {
        show2Buttons = false;
        quest.listPos++;
        knowledge.UpdateKnowledge(kn);          
    }
}
