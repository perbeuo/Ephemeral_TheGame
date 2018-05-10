using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour {

	private static bool _isHide = false;
	private static bool _isShow = false;
	private static float _start = 1;
	private static float _speed = .04f;
	public GameObject panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_isHide) {
			Color color = panel.GetComponent<Image> ().color;
			_start += _speed;
			Color end = new Color (color.r, color.g, color.b, _start);
			//渐变
			panel.GetComponent<Image> ().color = Color.Lerp (color, end, 1);
			if (_start >= 1) {
				_start = 1;
				_isHide = false;
			}
		} else if (_isShow) {
			Color color = panel.GetComponent<Image> ().color;
			_start -= _speed;
			Color end = new Color (color.r, color.g, color.b, _start);
			//渐变
			panel.GetComponent<Image> ().color = Color.Lerp (color, end, 1);
			if (_start <= 0) {
				_start = 0;
				_isShow = false;
			}
		}
	}

	public static void showCover(){
//		Debug.Log ("to black speed" + _speed);
		_isHide = true;
	}

	public static void cancelCover(){
//		Debug.Log ("to trans speed "+_speed);
		_isShow = true;
	}

	public static void changeState(){
		if (_isHide) {
			_isHide = false;
			_isShow = true;
		} else {
			_isHide = true;
			_isShow = false;
		}
	}

	public static void changeSpeed(float speed){
		_speed = speed;
	}

}
