using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "Storage", menuName = "Conversation/Boxes", order = 2)]
public class Boxes : ScriptableObject
{
   public string questObjective;
   public string boxesQuestion;
   public List<GameObject> cantPickUp;

   public void DisableBoxes(int amountOfBadBoxes)
   {
       for(int i = 0; i < cantPickUp.Count && i < amountOfBadBoxes; i++)
       {
           cantPickUp[i].GetComponent<OVRGrabbable>().enabled = false;
       }
   }
}
