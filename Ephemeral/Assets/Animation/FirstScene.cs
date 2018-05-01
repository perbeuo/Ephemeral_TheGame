using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class FirstScene : BasicPlayableBehaviour
{
	[Header("对话框")]
	public ExposedReference<TextMesh> dialog;
	private TextMesh _dialog;
	[Multiline(3)]
	public string dialogStr;

	public override void OnGraphStart(Playable playable)
	{
		_dialog = dialog.Resolve(playable.GetGraph().GetResolver());
		//Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	// Called when the owning graph stops playing
	public override void OnGraphStop(Playable playable) {
		//Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{

		_dialog.gameObject.SetActive(true);
		_dialog.text = dialogStr;
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
		if (_dialog)
		{
			_dialog.gameObject.SetActive(false);
		}
	}
}