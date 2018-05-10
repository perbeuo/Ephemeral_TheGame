using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showinfo : MonoBehaviour {
    public TextMesh tip;
    public string tipInfo;
	// Use this for initialization
	void Start () {
		
	}

    void OnMouseEnter()
    {
        ShowInfo(tipInfo);
    }
    void OnMouseExit()
    {
        DeleteInfo();
    }
	// Update is called once per frame
	void Update () {
		
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
