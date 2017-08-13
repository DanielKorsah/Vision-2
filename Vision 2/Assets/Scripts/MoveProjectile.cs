using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{

    public float flightSpeed = 5f;

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0 , 0, flightSpeed * Time.deltaTime);

        pos += transform.rotation * velocity;
        transform.position = pos;
    }
}