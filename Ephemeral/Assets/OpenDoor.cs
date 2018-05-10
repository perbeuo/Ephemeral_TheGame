using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {
    public ItemBox itembox;
    public int objnum;
    Vector3 v2 = new Vector3(0, -90, 0);
    public bool isInObject = false;
    RaycastHit hit;
	// Use this for initialization
	void Start () {
       
    }

    void OnMouseEnter()
    {
        isInObject = true;
    }
    void OnMouseExit()
    {
        isInObject = false;
    }

	// Update is called once per frame
	void Update () {

        //opendoor();
        if (isInObject && Physics.Raycast(MouseHighlight.ray, out hit, 1.0f))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (itembox.isExist(objnum))
                {
                    this.transform.Rotate(v2);
                    Debug.Log("开门");
                    if (objnum == 1)
                    {
                        GameObject sel = GameObject.Find("select");//获得判定对象
                        sel.SetActive(false);
                    }
                }
                else
                {
                    Debug.Log("提示对白");
                }
            }
        }
      
	}
    /*
    void opendoor()
    {
        RaycastHit hit;
        if (Physics.Raycast(MouseHighlight.ray, out hit, 1.0f))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (itembox.isExist(objnum))
                {
                    this.transform.Rotate(v2);
                    Debug.Log("开门");
                }
                else
                {
                    Debug.Log("提示对白");
                }
            }
        }
      
       
    }
    */
}
