using UnityEngine;
using System.Collections;

/// <summary>
/// 鼠标选中时高亮
/// </summary>
public class MouseHighlight : MonoBehaviour {

	public int objnum;
	public TextMesh tip;
	public string tipInfo;
    public GameObject gameCheck;
	public GameObject targetDoor;

	public GameObject pickupObj;	
	public ItemBox itembox;

    public 
    void Start()
    {
       
    }
    void Update () {

		//if (Input.GetMouseButtonDown (0)) {
			var ray = Camera.main.ScreenPointToRay (Input.mousePosition);//鼠标的屏幕坐标转化为一条射线
			RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 3.0f)) {
			var hitObj = hit.collider.gameObject;
			SetObjectHighlight (hitObj);
			//Debug.Log (hitObj);
		} else {
			RemoveComponent (gameCheck);
			DeleteInfo();
		}
		//}
    }

    /// <summary>
    /// 设置物体高亮
    /// </summary>
    /// <param name="obj"></param>
    public void SetObjectHighlight(GameObject obj)
    {
		if (targetDoor.Equals (obj) || pickupObj.Equals (obj)) {
			if (gameCheck == null) {
				AddComponent (obj);
			} else if (gameCheck == obj) {
				//RemoveComponent(obj);
			} else {
				RemoveComponent (gameCheck);
				AddComponent (obj);
			}
		}
		if (pickupObj.Equals (obj)) {
			PickUpItem (obj);
		}
    }

    /// <summary>
    /// 移出组件
    /// </summary>
    /// <param name="obj"></param>
    public void RemoveComponent(GameObject obj)
    {
        if(obj.GetComponent<SpectrumController>() != null) {
            Destroy(obj.GetComponent<SpectrumController>());
        }

        if(obj.GetComponent<HighlightableObject>() != null) {
            Destroy(obj.GetComponent<HighlightableObject>());
        }

        gameCheck = null;
    }

    /// <summary>
    /// 添加高亮组件
    /// </summary>
    /// <param name="obj"></param>
    public void AddComponent(GameObject obj)
    {
        if(obj.GetComponent<SpectrumController>() == null) {
            obj.AddComponent<SpectrumController>();
        }
        gameCheck = obj;
    }

	/// <summary>
	/// Picks up item.
	/// </summary>
	/// <param name="obj">Object.</param>
	public void PickUpItem(GameObject obj){
		ShowInfo(tipInfo);
		if (Input.GetKeyDown(KeyCode.F))
		{
			Debug.Log(objnum);
			obj.SetActive(false);
			itembox.setobjnumber(objnum);
			//Setnumber.setobjnumber(objnum);
			DeleteInfo ();
		}
	}

	public void ShowInfo(string info)
	{
		tip.text = info;
	}

	public void DeleteInfo()
	{
		tip.text = " ";
	}

	public void Catch(GameObject obj)
	{
		obj.transform.position = new Vector2(0, 1000);
	}

}
