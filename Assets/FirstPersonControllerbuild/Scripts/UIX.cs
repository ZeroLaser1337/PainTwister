using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiScript : MonoBehaviour
{
    public KnowledgeMeter knowledgeMeter;
    public Quest ques;

    public TextMeshPro knowledge;
    public TextMeshPro q;

    public void Update()
    {
        knowledge.text = knowledgeMeter.knowledgeAmount.ToString();
        q.text = ques.storyQuests[ques.listPos].questText;
    }
}
