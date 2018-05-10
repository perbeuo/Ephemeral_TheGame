using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKeyDoors : MonoBehaviour {
	public ItemBox itembox;
	public int itemNumber;
	public int toMap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		RaycastHit hit;
//		if (Physics.Raycast(MouseHighlight.ray, out hit, 1.6f))
//		{
//			TryOpen(this.gameObject);
//		}
	}

	void TryOpen(GameObject obj){
		if (Input.GetKeyDown(KeyCode.F))
		{
			if (itembox.isExist (itemNumber)) {
				if (toMap == 1) {
					Application.LoadLevel("hospital");
				}
				//Debug.Log ("u shall pass!");
			}
		}
	}

	public static void LoadScene(int num){
		if (num == 1) {
			Application.LoadLevel("hospital");
		}
	}
}
