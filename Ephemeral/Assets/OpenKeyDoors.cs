using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeyDoors : MonoBehaviour {
	public ItemBox itembox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast(MouseHighlight.ray, out hit, 1.0f))
		{
			TryOpen(this.gameObject);
		}
	}

	void TryOpen(GameObject obj){
		if (Input.GetKeyDown(KeyCode.F))
		{
			if (itembox.isExist (1)) {
				Debug.Log ("u shall pass!");
			} else {
				Debug.Log ("u shall not pass!");
			}
		}
	}
}
