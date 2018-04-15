using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public TextMesh tip;
    public string tipInfo = "拾取";
    public GameObject player;
    public bool isInObject = false;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("PLAYER");
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
        
        if (isInObject)
        {
            float distance = (this.gameObject.transform.position - player.gameObject.transform.position).magnitude;
            if (distance < 2)
            {
                ShowInfo();
            }
            else
            {
                DeleteInfo();
            }
            
        }
        else
        {
            DeleteInfo();
        }
	}
    public void ShowInfo()
    {
        tip.text = tipInfo;
    }
    public void DeleteInfo()
    {
        tip.text = "";
    }
    public void Catch()
    {
        transform.position = new Vector2(0, 1000);
    }
    public float calculate_distance(float x, float y, float z)
    {
        return Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2));
    }
}
