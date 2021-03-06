﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConsultantDialogue : ConversationSystem
{
    public Audiodialog audiodialog;
   void Start()
   {
       Begin();
       dialogueProgress.StartDialogue(audiodialog);
   }

    void Update()
    {
        UpdateButtons();
        UpdateProgress();
    }

   public void ConsultantButton4(Audiodialog audio_4)
   {
       show2Buttons = false;
       dialogueProgress.StartDialogue(audio_4);
       quest.listPos++;
   }
   public void ConsultantButton2(Audiodialog audio_2)
   {
       show4Buttons = false;
       dialogueProgress.StartDialogue(audio_2);
       quest.listPos++;
   }
}
