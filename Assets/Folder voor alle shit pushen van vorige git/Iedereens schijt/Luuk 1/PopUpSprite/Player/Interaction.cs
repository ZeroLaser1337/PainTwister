using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float rayDis;

    public bool ableToPickUp;
    public bool lockedMouse;

    public RaycastHit hit;

    public CameraScript cam;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * rayDis, Color.red);
    }
}
