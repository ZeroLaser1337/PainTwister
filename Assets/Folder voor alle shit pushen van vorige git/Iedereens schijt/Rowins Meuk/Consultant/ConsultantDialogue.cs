    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConsultantDialogue : ConversationSystem
{

   void Start()
   {
       Begin();
   }

    void Update()
    {
        UpdateButtons();
        UpdateProgress();
    }

   public void ConsultantButton4(Audiodialog audio_4, int kn)
   {
       show2Buttons = false;
       dialogueProgress.StartDialogue(audio_4);
       quest.listPos++;
       knowledge.UpdateKnowledge(kn);   
   }
   public void ConsultantButton2(Audiodialog audio_2, int kn)
   {
       show4Buttons = false;
       dialogueProgress.StartDialogue(audio_2);
       quest.listPos++;
       knowledge.UpdateKnowledge(kn);   
   }
}
