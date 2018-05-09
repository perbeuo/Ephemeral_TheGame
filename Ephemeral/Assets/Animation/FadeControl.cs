using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ToBlack(){
		FadeEffect.showCover ();
	}

	void ToTransparent(){
		Debug.Log ("to do transparent!!");

//		FadeEffect.cancelCover ();
	}
}
