using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{
    public List<GameObject> tutPopUpGameObject;
    public List<bool> noLongerPoppinUp;

    public float timer = 90f;
    public float resetTimer = 90f;
    public int offset = 4;
    public int childCount;
    public bool startTimer;

    public GameObject managerTut;


    public void Awake()
    {
        managerTut = gameObject;
    }

    public void Update()
    {
        childCount = managerTut.transform.childCount;
        if (startTimer == true && timer >= 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Destroy(transform.GetChild(childCount - 1).gameObject);
                startTimer = false;
            }
        }
    }

    public void TutPopUp(int i)
    {
        if (noLongerPoppinUp[i] == false)
        {
            timer = resetTimer;
            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + offset);
            Instantiate(tutPopUpGameObject[i], spawnPos, Quaternion.identity, managerTut.transform);
            noLongerPoppinUp[i] = true;
            startTimer = true;
        }
    }

    public void SkipTutorial()
    {
        timer = 0;
    }

    public void ResetTimer()
    {
        timer = 90;
    }
}
