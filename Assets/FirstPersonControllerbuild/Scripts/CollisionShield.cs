using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionShield : MonoBehaviour
{
    public GameObject me;

    public GameObject target;

    public void Start()
    {
        Physics.IgnoreLayerCollision(8, 9);
    }

    void Update()
    {
        me.transform.position = target.transform.position;
    }
}
