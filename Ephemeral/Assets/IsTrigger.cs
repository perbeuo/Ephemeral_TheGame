using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IsTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        this.gameObject.SetActive(false);
        SceneManager.LoadScene("Office2");
        Debug.Log("碰撞啦！");
    }
}
