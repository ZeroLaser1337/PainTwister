using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCollider : MonoBehaviour
{
    public int tutorialPopUpNumber;
    public Sprite notes;

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<TutorialPopUp>().TutPopUp(tutorialPopUpNumber);
        other.GetComponent<NotitieBlock>().notePadPages.Add(notes);
    }

    public void OnTriggerExit(Collider other)
    {
        other.GetComponent<TutorialPopUp>().timer = 0;
    }
}
