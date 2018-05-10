using System.Collections;
using System.Collections.Generic;
using UnityEngine.Timeline;
using UnityEngine.Playables;
using UnityEngine;

public class ShowAnime : MonoBehaviour {
	public PlayableDirector playableDirector;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider)
	{
		this.gameObject.SetActive(false);
		playableDirector.Play();
	}
}
