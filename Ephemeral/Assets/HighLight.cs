
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLight : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
    public bool isInObject = false;
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
       
        if (isInObject )
        {
            float distance = (this.gameObject.transform.position - player.gameObject.transform.position).magnitude;
            if (distance < 2)
            {
                AddComponent(this.gameObject);
            }
            else
            {
                RemoveComponent(this.gameObject);
            }
          
        }else
        {
            RemoveComponent(this.gameObject);
        }

	}
    public void RemoveComponent(GameObject obj)
    {
        if (obj.GetComponent<SpectrumController>() != null)
        {
            Destroy(obj.GetComponent<SpectrumController>());
        }

        if (obj.GetComponent<HighlightableObject>() != null)
        {
            Destroy(obj.GetComponent<HighlightableObject>());
        }
    }

    /// <summary>
    /// 添加高亮组件
    /// </summary>
    /// <param name="obj"></param>
    public void AddComponent(GameObject obj)
    {
        if (obj.GetComponent<SpectrumController>() == null)
        {
            obj.AddComponent<SpectrumController>();
        }
    }
    public float calculate_distance(float x, float y, float z)
    {
        return Mathf.Sqrt(Mathf.Pow(x, 2)+Mathf.Pow(y, 2)+ Mathf.Pow(z, 2));
    }
}
