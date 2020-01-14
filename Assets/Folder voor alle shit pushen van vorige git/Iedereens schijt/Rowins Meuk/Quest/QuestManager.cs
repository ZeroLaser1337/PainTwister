using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestManager : MonoBehaviour
{
   public TextMeshProUGUI questText;
   public TextMeshProUGUI questAmount;
   
   public void UpdateQuest(ScriptableObject questObj, int amount)
    {
        questAmount.text = amount.ToString();
        
            if(questObj is Boxes)
            {
                var boxes = questObj as Boxes;
                questText.text = boxes.questObjective;
                boxes.DisableBoxes(amount);
            }
            if(questObj is Consultant)
            {
                var consultant = questObj as Consultant;
                questText.text = consultant.questObjective;
                consultant.RemoveInteractable(amount);
            }
    }
}
