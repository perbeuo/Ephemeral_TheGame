using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class inventory : MonoBehaviour {

    GameObject gb;
    GameObject gb1;

    [DllImport("user32.dll", EntryPoint = "keybd_event")]
    public static extern void Keybd_event(byte bvk, byte bScan, int dwFlags, int dwExtraInfo);

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        gb = GameObject.Find("Canvas");
        gb1 = GameObject.Find("Canvas(1)");
        gb.SetActive(false);
        gb1.SetActive(false);

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

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (gb1.active == true)
            {
                gb1.SetActive(false);
              


            }
            else if (gb1.active == false)
            {

                gb1.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                //we force unlock the cursor if the user disable the cursor locking helper

            }

        }



    }
}
