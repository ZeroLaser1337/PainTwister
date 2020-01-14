using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class ConversationSystem : MonoBehaviour
{
    public Quest quest;
    public Audiodialog audiodialog;
    protected DialogueProgress dialogueProgress;
    public TextMeshProUGUI mainQuestion;
    protected AudioSource voiceOver;
    public Button[] buttons;
    public GameObject _4Buttons;
    public GameObject _2Buttons;
    public bool show4Buttons;
    public bool show2Buttons;
    public void Begin()
    {
        quest = GetComponent<Quest>();
        voiceOver = GetComponent<AudioSource>();
        dialogueProgress = GetComponent<DialogueProgress>();
        dialogueProgress.StartDialogue(audiodialog);
    }
    public void UpdateProgress()
    {
        if (dialogueProgress.conversating)
        {
            dialogueProgress.ProgressDialogue(dialogueProgress.audiodialog, dialogueProgress.listPosCurrentDialogue);
            mainQuestion.text = dialogueProgress.audiodialog.myStrings[dialogueProgress.listPosCurrentDialogue];
        }
        else
        {
            dialogueProgress.listPosCurrentDialogue = 0;
            mainQuestion.text = null;
        }
    }
    public void UpdateButtons()
    {
        if(show4Buttons)
        {
            _4Buttons.SetActive(true);
            if(show2Buttons)
            {
                _2Buttons.SetActive(true);
            }
            else
            {
                _2Buttons.SetActive(false);
            }
        }
        else
        {
            _4Buttons.SetActive(false);
        }
    }
}
