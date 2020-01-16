using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotitieBlock : MonoBehaviour
{
    public GameObject notePad;
    public SpriteRenderer spriteRenderer;
    public List<Sprite> notePadPages;

    public int pageInt;

    public void Start()
    {
        DontDestroyOnLoad(gameObject);
        notePad = gameObject;
    }
    public void Update()
    {
        OpenNotePad();
        PageChange();
    }

    public void OpenNotePad()
    {
        if (Input.GetButton("Oculus_GearVR_DpadY"))
        {
            notePad.SetActive(true);
        }
        else if (Input.GetButton("Oculus_GearVR_DpadY"))
        {
            notePad.SetActive(false);
        }
    }

    public void PageChange()
    {
        if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryHandTrigger") && pageInt < 0)
        {
            pageInt++;
            ForLoop(pageInt);
        }
        if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryHandTrigger") && pageInt >= (notePadPages.Count + 1))
        {
            pageInt--;
            ForLoop(pageInt);
        }
    }

    public void ForLoop(int i)
    {
        spriteRenderer.sprite = notePadPages[i];
    }
}
//__________________________________________________________________________________________________________________________________________________________________________________________________________________________//