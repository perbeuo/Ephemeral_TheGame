using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startgenerator : MonoBehaviour {
     RaycastHit hit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(MouseHighlight.ray, out hit, 1.0f) && Input.GetKeyDown(KeyCode.E))
        {
            controllor.isStart = true;
        }
		
	}
}
