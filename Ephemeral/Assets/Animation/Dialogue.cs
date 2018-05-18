using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using UnityStandardAssets.Characters.FirstPerson;
public class Dialogue : MonoBehaviour {
	public string name;
	public Text lines;
	int count = 0;
	public GameObject gb; // dialogue
	public GameObject player;
	public bool isInObject = false;
	private bool isUse = false;
	public int dialogue_num;
	public ItemBox itembox;
	private static float _current_dlg;

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
//				count = 0;
				if (dialogue_num == 1 && !itembox.isExist(4) && !itembox.isExist(3)){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "可恶，门锁住了!";
					_current_dlg = 1;
				}else if (dialogue_num == 1 && itembox.isExist(3) && !itembox.isExist(4)){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "应该是这把钥匙吧。";
					_current_dlg = 1.1f;
				}else if (dialogue_num == 1 && itembox.isExist(4)){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "用这些工具试试...";
					_current_dlg = 1.11f;
				}else if (dialogue_num == 3 && !itembox.isExist(3)){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "这是个保险箱？我记得里面装的是一些工具...";
					Debug.Log ("这是个保险箱？我记得里面装的是一些工具...");
					_current_dlg = 3;
				}else if (dialogue_num == 3 && itembox.isExist(3)){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "就是它！赶紧用这些工具去试试开锁！";
					_current_dlg = 3.1f;
				}else if (dialogue_num == 4){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "这张纸...";
					_current_dlg = 4;
				}else if (dialogue_num == 5){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "这是医院的地图...";
					_current_dlg = 5;
				}else if (dialogue_num == 6){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "这是另外半张地图！";
					_current_dlg = 6;
				}else if (dialogue_num == 7){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "这次...门没锁？";
					_current_dlg = 7;
				}
				else if (dialogue_num == 667){
					gb.SetActive (true);
					cc.enabled = false;
					cc.GetComponent<FirstPersonController>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.lockState = CursorLockMode.Confined;
					lines.text = "Hello!";
					_current_dlg = 667;
				}
			}
		}
	}

	public void ShowLines()
	{
		Debug.Log ("num" + _current_dlg + "\r\nname" + this.name);
		if (_current_dlg == 1 && this.name.Equals("office_door")) {
			if (count == 0) {
				lines.text = "（摸索）我的钥匙不见了？钱包也不见了？";
				count++;
			} else if (count == 1) {
				lines.text = "小何那里好像有备用钥匙，先出去看看再说！";
				count++;
			} else if (count == 2) {
				lines.text = "他的座位应该是在靠窗离我办公室最远的地方，有把绿色的椅子。";
				count++;
			} else if (count == 3) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			}
		} else if (_current_dlg == 1.1f && this.name.Equals("office_door")) {
			if (count == 0) {
				lines.text = "（尝试开门）";
				count++;
			} else if (count == 1) {
				lines.text = "***！钥匙拧不动，卡住了！";
				count++;
			} else if (count == 2) {
				lines.text = "那些**把资金都用到哪了？？";
				count++;
			} else if (count == 3) {
				lines.text = "没办法了，档案室里好像有个保险箱，里面装的是开锁工具，拿来试试吧。";
				count++;
			} else if (count == 4) {
				lines.text = "（为什么开锁工具会在档案室的保险箱里？我是怎么知道的？）";
				count++;
			} else if (count == 5) {
				count = 0;
				_current_dlg = 0;
				GameObject.Find ("BriefCasePrefab").GetComponent<Item>().withDlg = false;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			}
		} else if (_current_dlg == 1.11f && this.name.Equals("office_door")) {
			if (count == 0) {
				lines.text = "（尝试撬锁）";
				count++;
			} else if (count == 1) {
				lines.text = "好了！";
				count++;
			} else if (count == 2) {
				lines.text = "（我是怎么在天天写代码的时候学会撬锁的？）";
				count++;
			} else if (count == 3) {
				lines.text = "（不管了，赶紧出去看看外面是什么情况！）";
				count++;
			} else if (count == 4) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
				OpenKeyDoors.LoadScene (1);
			}
		} else if (_current_dlg == 3f && this.name.Equals("brief_case")) {
//			Debug.Log ("现在拿它也没用，还是先把钥匙找到去外面看看！");
			if (count == 0) {
				lines.text = "现在拿它也没用，还是先把钥匙找到去外面看看！";
				count++;
			} else if (count == 1) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			}
		} else if (_current_dlg == 3.1f && this.name.Equals("brief_case")) {
			if (count == 0) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			} 
		} else if (_current_dlg == 4f && this.name.Equals("hint_paper")) {
			if (count == 0) {
				lines.text = "这...好像是我的病例？";
				count++;
			} else if (count == 1) {
				lines.text = "我...好像以前来过这里...";
				count++;
			} else if (count == 2) {
				lines.text = "那次我加班太久，昏倒之后来到的好像就是这家医院？";
				count++;
			} else if (count == 3) {
				lines.text = "现在它怎么变得这么破败？";
				count++;
			} else if (count == 4) {
				lines.text = "旁边好像有地图，我先看一看。";
				count++;
			} else if (count == 5) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			}
		}else if (_current_dlg == 5f && this.name.Equals("map_1")) {
			if (count == 0) {
				lines.text = "但是这里只有半张...";
				count++;
			} else if (count == 1) {
				lines.text = "嗯...这半张没有关键地点啊，要去找到另外一半。";
				count++;
			} else if (count == 2) {
				lines.text = "先在一楼看看吧。";
				count++;
			} else if (count == 3) {
				lines.text = "（为什么这么奇怪的事情会发生在我身上？）";
				count++;
			} else if (count == 4) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			}
		}else if (_current_dlg == 6f && this.name.Equals("map_2")) {
			if (count == 0) {
				lines.text = "我看看...";
				count++;
			} else if (count == 1) {
				lines.text = "嗯...跟上一张结合起来看的话...";
				count++;
			} else if (count == 2) {
				lines.text = "（仔细查看）";
				count++;
			} else if (count == 3) {
				lines.text = "看来想离开这里要通过电梯...还是先去查看一下吧。";
				count++;
			} else if (count == 4) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			}
		}else if (_current_dlg == 7f && this.name.Equals("office_door2")) {
			if (count == 0) {
				lines.text = "门后的会是什么？";
				count++;
			} else if (count == 1) {
				lines.text = "可恶...头又开始晕了...";
				count++;
			} else if (count == 2) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			}
		}else if (_current_dlg == 667 && this.name.Equals("test")) {
			if (count == 0) {
				lines.text = "This is Ephemeral!";
				count++;
			} else if (count == 1) {
				lines.text = "策划：何方溥，张硕";
				count++;
			} else if (count == 2) {
				lines.text = "实现：何方溥，常昊，甘泽港";
				count++;
			} else if (count == 3) {
				lines.text = "测试：郝江鹏";
				count++;
			} else if (count == 4) {
				count = 0;
				_current_dlg = 0;
				gb.SetActive (false);
				cc.enabled = true;
				cc.GetComponent<FirstPersonController> ().enabled = true;
			}
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
