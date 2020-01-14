using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Switch", menuName = "Interactable/Switch", order = 0)]

public class SwitchInfo : ScriptableObject
{
    public AudioClip switchAudio;
    public bool switchState;
    public GameObject switchToggle;
    protected AudioManagement audioManager;
}
