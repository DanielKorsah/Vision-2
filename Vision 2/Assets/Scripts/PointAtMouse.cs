﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtMouse : MonoBehaviour {
    
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
}
