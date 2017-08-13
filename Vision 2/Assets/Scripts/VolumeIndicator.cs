using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeIndicator : MonoBehaviour {

    float loudness;
    public float movementMultiplier;
    public float power = 3;
    PlayerController movementComponent;
    Light spot;

    // Use this for initialization
    void Start () {

        try
        {
            movementComponent = gameObject.GetComponent<PlayerController>();
        }
        catch
        {
            Debug.Log("noise component on non-player");
        }

        try
        {
            spot = gameObject.GetComponentInChildren<Light>();
        }
        catch
        {
            Debug.Log("missing spotlight");
        }
    }

	
	// Update is called once per frame
	private void Update () {

        //Noise from movement
        float movNoise;
        if (movementComponent != null)
        {
            movNoise = movementComponent.Pos.magnitude * Mathf.Pow(movementMultiplier, power);
        }
        else
        {
            movNoise = 0;
        }

        //Combine all noise
        loudness = 0;
        loudness += movNoise;

        //turn loudness into visibility
        spot.intensity = loudness;
	}
    
}
