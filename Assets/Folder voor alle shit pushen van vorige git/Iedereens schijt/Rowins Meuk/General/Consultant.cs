using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[CreateAssetMenu(fileName = "Consultant", menuName = "Conversation/Consultant", order = 1)]
public class Consultant : ScriptableObject
{
    public string questObjective;
    public List<GameObject> gatherInfo;
    public void RemoveInteractable(int amountOfItems)
   {
       for(int i = 0; i < gatherInfo.Count && i < amountOfItems; i++)
       {
           gatherInfo[i].GetComponent<OVRGrabbable>().enabled = false;
       }
   }

}
