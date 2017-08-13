using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float runSpeed = 20;
    public float walkSpeed = 1;
    private float speed;
    private Vector3 pos;

    Rigidbody2D playerRigidbody;

    public Vector3 Pos
    {
        get { return pos; }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey("left shift"))
        {
            speed = runSpeed;
        }
        else
        {
            speed = walkSpeed;
        }

        Vector3 oldPos = transform.position;
        pos = transform.position;

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        pos = movement.normalized * speed * Time.deltaTime;
        transform.position += pos;

    }
}
