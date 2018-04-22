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
        if (isInObject && Physics.Raycast(MouseHighlight.ray, out hit, 1.0f))
        {
            PickUpItem(this.gameObject);
        }
        else
        {
            DeleteInfo();
        }


    }


    public void PickUpItem(GameObject obj)
    {
        ShowInfo(tipInfo);
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(objnum);
            obj.SetActive(false);
            itembox.setobjnumber(objnum);
            //Setnumber.setobjnumber(objnum);
            DeleteInfo();
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



}
