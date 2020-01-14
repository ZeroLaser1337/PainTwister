using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotitieBlock : MonoBehaviour
{
    public SpriteRenderer notePad;
    public List<Sprite> notePadPages;

    public int pageInt;
    public int unlocked;

    public void Update()
    {
        PageChange();
    }

    public void PageChange()
    {
        if (Input.GetButtonDown("NextPage") && pageInt < 0)
        {
            pageInt++;
            ForLoop(pageInt);
        }
        if (Input.GetButtonDown("PrevPage") && pageInt >= (notePadPages.Count + 1))
        {
            pageInt--;
            ForLoop(pageInt);
        }
    }

    public void ForLoop(int i)
    {
        for (int b = 0; b < notePadPages.Count; b++)
        {
        }
    }
}
//__________________________________________________________________________________________________________________________________________________________________________________________________________________________//