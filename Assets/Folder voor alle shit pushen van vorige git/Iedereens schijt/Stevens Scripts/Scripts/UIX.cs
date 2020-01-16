using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIX : MonoBehaviour
{
    public KnowledgeMeter knowledgeItem;

    public Quest quest;

    public Text questText;
    public Text knowledgeMeterText;

    public void Update()
    {
        questText.text = quest.storyQuests[quest.listPos].questText;
        knowledgeMeterText.text = knowledgeItem.knowledgeAmount.ToString();
    }
}
