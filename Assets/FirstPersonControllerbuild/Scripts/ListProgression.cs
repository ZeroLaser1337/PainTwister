using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListProgression : MonoBehaviour
{
    public int listPos;
    public Quest quest;

    public void Awake()
    {
        quest = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>();
        quest.listPos = listPos;
        DontDestroyOnLoad(this);
    }

    public void Update()
    {
        quest.listPos = listPos;
        Debug.Log(listPos);
        quest = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>();
    }
}
