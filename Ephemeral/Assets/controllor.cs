using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllor : MonoBehaviour {
    public Animator animator;
    private  bool isInObject = false;
    public TextMesh tip;
    public string tipInfo = "G";
    private bool isPrss = false;
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
        DeleteInfo();
    }
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (isInObject && Physics.Raycast(MouseHighlight.ray, out hit, 1.0f))
        {
            ShowInfo(tipInfo);
            if (!isPrss && Input.GetKeyDown(KeyCode.G))
            {
                animator.SetBool("status", true);
                isPrss = true;
            }
            else if (isPrss && Input.GetKeyDown(KeyCode.G))
            {
                animator.SetBool("status", false );
                isPrss = false;
            }
        }
        else {
           
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
