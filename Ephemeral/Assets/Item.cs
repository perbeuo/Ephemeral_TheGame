using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int objnum;
    public ItemBox itembox;
    public TextMesh tip;
    public string tipInfo;
    public bool isInObject = false;
    private bool isUse = false;
	public bool withDlg = false;

    // Use this for initialization
    void Start()
    {
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
    void Update()
    {
        RaycastHit hit;
        if (isInObject && Physics.Raycast(MouseHighlight.ray, out hit, 3.0f))
        {
				PickUpItem(this.gameObject);
        }
        else
        {

            if (isUse) DeleteInfo();

        }


    }


    public void PickUpItem(GameObject obj)
    {

        if (!isUse) ShowInfo(tipInfo);

		if (Input.GetKeyDown(KeyCode.E) && !withDlg)
        {
            Debug.Log(objnum);
            obj.SetActive(false);
            itembox.setobjnumber(objnum);
            //Setnumber.setobjnumber(objnum);
            if (isUse) DeleteInfo();

        }
    }

    public void ShowInfo(string info)
    {
        tip.text = info;
        isUse = true;

    }

    public void DeleteInfo()
    {
        tip.text = " ";
        isUse = false;

    }



}