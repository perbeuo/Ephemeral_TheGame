using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class inventory : MonoBehaviour {

    GameObject gb;

    [DllImport("user32.dll", EntryPoint = "keybd_event")]
    public static extern void Keybd_event(byte bvk, byte bScan, int dwFlags, int dwExtraInfo);

    void Start()
    {

        gb = GameObject.Find("Canvas");
        gb.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (gb.active == true)
            {
                gb.SetActive(false);

            }
            else if (gb.active == false)
            {

                gb.SetActive(true);
     
            }

        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
        }



    }
}
