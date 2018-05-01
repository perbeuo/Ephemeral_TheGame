using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
public class ShowAnimation : MonoBehaviour
{


	public bool isInObject;


	public PlayableDirector playableDirector;

	void OnMouseEnter()
	{
		isInObject = true;
	}
	void OnMouseExit()
	{
		isInObject = false;
	}

	public void Update()
	{
	if (isInObject)
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				playableDirector.Play();
			}
		}
	}

}