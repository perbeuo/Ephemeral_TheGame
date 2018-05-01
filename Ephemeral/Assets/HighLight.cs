
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLight : MonoBehaviour
{

    // Use this for initialization
    public bool isInObject = false;
    RaycastHit hit;
    void Start()
    {
        
        // player = GameObject.Find("FPSController");
    }
    // Update is called once per frame
    void OnMouseEnter()
    {
        isInObject = true;
    }
    void OnMouseExit()
    {
        isInObject = false;
    }
    void Update()
    {

        if (isInObject && Physics.Raycast(MouseHighlight.ray, out hit, 1.0f))
        {
            AddComponent(this.gameObject);

        }
        else
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


}
