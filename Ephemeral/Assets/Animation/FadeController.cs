using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class FadeController : BasicPlayableBehaviour
{
	public float speed;
	public bool toShow;
//	public ExposedReference<GameObject> panel;
//	private GameObject _panel;

	public override void OnGraphStart(Playable playable)
	{
//		FadeEffect.speed = speed;
//		_panel = panel.Resolve(playable.GetGraph().GetResolver());
//		FadeEffect.cancelCover ();
	}

	// Called when the owning graph stops playing
	public override void OnGraphStop(Playable playable) {
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
		if (toShow) {
			FadeEffect.changeSpeed (speed);
			FadeEffect.showCover ();
		} else {
			FadeEffect.changeSpeed (speed);
			FadeEffect.cancelCover ();
		}
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}
}