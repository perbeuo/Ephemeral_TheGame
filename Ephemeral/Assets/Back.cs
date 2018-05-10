using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {
    GameObject gb1;
    // Use this for initialization
    void Start () {
        gb1 = GameObject.Find("Canvas(1)");
    }
	
	// Update is called once per frame
	public void OnClick () {
        gb1.SetActive(false);
	}
}
