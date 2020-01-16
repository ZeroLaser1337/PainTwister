using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public Interaction interaction;

    public Button itemHolding;

    public int health = 100;
    public int def;
    public int atk;
    public int listPos;

    public Text healthText;
    public Text defText;
    public Text atkText;
    public Text heldItem;

    public GameObject pickUp;
    public Text itemToPickUp;

    public bool gameOver;

    public void Start()
    {
        health = 100;
    }

    public void Update()
    {

    }
}

