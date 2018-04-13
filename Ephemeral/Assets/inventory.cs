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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;

        gb = GameObject.Find("Panel");
        gb.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("手动触发A键Down");
            if (gb.active == true)
            {
                gb.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = true;
                Debug.Log("锁上");

            }
            else if (gb.active == false)
            {

                gb.SetActive(true);
      
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Debug.Log("解锁");
            }

        }

        if (Input.GetKeyUp(KeyCode.Y))
        {
            Debug.Log("手动触发A键up");
        }



    }
}
