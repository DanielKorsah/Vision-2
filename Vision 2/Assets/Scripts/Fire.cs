using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public GameObject projectilePrefab;
    public Vector3 bulletOffset = new Vector3(0, 0, 0.6f);

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    // Update is called once per frame
    void Update()
    {

        cooldownTimer -= Time.deltaTime; //decrement the timeleft on cooldown


        if (Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay; //set cooldown time to max
            Vector3 offset = transform.rotation * bulletOffset;
            Instantiate(projectilePrefab, transform.position + offset, transform.rotation); //make a bullet
        }

    }
}
