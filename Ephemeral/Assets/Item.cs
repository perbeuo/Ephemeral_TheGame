using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int objnum;
    public TextMesh tip;
    public string tipInfo;
    public GameObject player;
    public bool isInObject = false;
    public ItemBox itembox;
    // Use this for initialization
    void Start()
    {
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
    void Update()
    {

        if (isInObject)
        {
            float distance = (this.gameObject.transform.position - player.gameObject.transform.position).magnitude;
            if (distance < 2)
            {
                ShowInfo();
                if (Input.GetKeyDown(KeyCode.F))
                {
                    this.gameObject.SetActive(false);
                    Debug.Log(objnum);
                    itembox.setobjnumber(objnum);
                    //Setnumber.setobjnumber(objnum);
                }
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
