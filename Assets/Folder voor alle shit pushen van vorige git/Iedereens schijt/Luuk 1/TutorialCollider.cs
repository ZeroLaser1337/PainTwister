using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCollider : MonoBehaviour
{
    public int tutorialPopUpNumber;
    public bool notesAdded;

    public Sprite notes;

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<TutorialPopUp>().TutPopUp(tutorialPopUpNumber);
        if (notesAdded == false)
        {
            other.gameObject.GetComponentInChildren<NotitieBlock>(true).notePadPages.Add(notes);
        }
        notesAdded = true;
    }

    public void OnTriggerExit(Collider other)
    {
        other.GetComponent<TutorialPopUp>().timer = 5;
    }
}
