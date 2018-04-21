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

        gb = GameObject.Find("Canvas");
        gb.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (gb.active == true)
            {
                gb.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
             

            }
            else if (gb.active == false)
            {

                gb.SetActive(true);
              
                //we force unlock the cursor if the user disable the cursor locking helper
                    Cursor.lockState = CursorLockMode.None;
                   
                

            }

        }

        if (Input.GetKeyUp(KeyCode.Tab))
        {
        }



    }
}
