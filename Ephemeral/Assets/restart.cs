using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour {

    public int senceNum;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public void OnClick () {
        UnityEngine.SceneManagement.SceneManager.LoadScene(senceNum);//加载场景
    }
}
