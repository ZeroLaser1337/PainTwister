using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHolder : MonoBehaviour
{
    //private PointManager points;
    private Renderer rend;
    protected bool used;

    public bool small, medium, big;

    void Start()
    {
        rend = this.GetComponent<Renderer>();
        //points = GameObject.Find("PointSystem").GetComponent<PointManager>();
    }
    void OnTriggerEnter(Collider coll)
    {
        if(used == false)
        {
            CheckBox(coll);
        }
    }
    void CheckBox(Collider collision)
    {
        if(small == true && collision.gameObject.CompareTag("Small Box"))
        {
            EnableBox(collision);
        }
        if(medium == true && collision.gameObject.CompareTag("Medium Box"))
        {
            EnableBox(collision);
        }
        if(big == true && collision.gameObject.CompareTag("Big Box"))
        {
            EnableBox(collision);
        }
    }
    void EnableBox(Collider coll)
    {
        Destroy(coll.gameObject);
        rend.enabled = true;
        used = true;
    }
}
