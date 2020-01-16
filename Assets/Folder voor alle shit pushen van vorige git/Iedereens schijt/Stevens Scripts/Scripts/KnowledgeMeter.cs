﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowledgeMeter : MonoBehaviour
{
    public int knowledgeAmount;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void UpdateKnowledge(int amount)
    {
        knowledgeAmount += amount;
    }
}