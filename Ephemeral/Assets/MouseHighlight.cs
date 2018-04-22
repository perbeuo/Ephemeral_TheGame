using UnityEngine;
using System.Collections;

/// <summary>
/// 鼠标选中时高亮
/// </summary>
public class MouseHighlight : MonoBehaviour
{
    public static Ray ray;
    public
    void Start()
    {

    }
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);//鼠标的屏幕坐标转化为一条射线

    }



}
