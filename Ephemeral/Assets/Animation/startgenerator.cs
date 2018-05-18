using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startgenerator : MonoBehaviour {
     RaycastHit hit;
     private bool isPres = false;
	// Use this for initialization
	void Start () {
		
	}

    void OnMouseEnter()
    {
        isPres = true;
    }

	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(MouseHighlight.ray, out hit, 5.0f)&& isPres == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                controllor.isStart = true;
                
            }
            
        }
       
	}
}
