using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using UnityStandardAssets.Characters.FirstPerson;
public class Dialogue : MonoBehaviour {
	public Text lines;
	int count = 0;
	public GameObject gb;
	public GameObject player;
	public bool isInObject = false;
	private bool isUse = false;

	private bool _isShow = false;

	CharacterController cc;
	private MouseLook[] m_mouseLook;

	// Use this for initialization
	void Start () {
//		m_Rigidbody = player.GetComponent<Rigidbody>();
//		//This locks the RigidBody so that it does not move or rotate in the z axis (can be seen in Inspector).
//		m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
//		//Set up vector for moving the Rigidbody in the z axis
//		m_ZAxis = new Vector3(0, 0, 5);

		m_mouseLook = player.GetComponentsInChildren<MouseLook>();
	
		cc = player.GetComponent<CharacterController>();
		//enableMouseLook ();
		//Cursor.lockState = CursorLockMode.None;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (isInObject && Physics.Raycast(MouseHighlight.ray, out hit, 1.6f))
		{
			if (Input.GetKeyDown (KeyCode.E)) {
				gb.SetActive (true);
				cc.enabled = false;
				cc.GetComponent<FirstPersonController>().enabled = false;
				Cursor.lockState = CursorLockMode.None;
				Cursor.lockState = CursorLockMode.Confined;
				lines.text = "Hello!";
//				if (!_isShow) {
//					FadeEffect.showCover ();
//					_isShow = true;
//				} else {
//					FadeEffect.cancelCover ();
//					_isShow = false;
//				}
			}
		}
	}

	public void ShowLines()
	{
		if (count == 0) {
			lines.text = "aha";
			count++;
		} else if (count == 1) {
			lines.text = "me again";
			count++;
		}else if (count == 2) {
			lines.text = "Bye!";
			count++;
		}else if (count == 3) {
			count = 0;
			gb.SetActive (false);
			cc.enabled = true;
			cc.GetComponent<FirstPersonController>().enabled = true;
		}
	}
//	public void MouseOutHere()
//	{
//	}

//	public void enableMouseLook() {
//		Screen.lockCursor = false;
//	}

	void OnMouseEnter()
	{
		isInObject = true;
	}
	void OnMouseExit()
	{
		isInObject = false;
	}

}
