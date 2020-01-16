using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public Vector3 dir;

    public float movementSpeed;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Physics.IgnoreLayerCollision(8, 9);    
    }

    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        float horiInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        dir = new Vector3(horiInput, 0, vertInput);

        transform.Translate(dir * movementSpeed * Time.deltaTime);
    }

}
