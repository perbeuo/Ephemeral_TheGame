using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isAnimationFinsh : MonoBehaviour {

    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
        // 判断动画是否播放完成
        if (info.normalizedTime >= 1.0f)
        {
            Debug.Log("结束");
            //播放完毕，要执行的内容
            Application.LoadLevel("Main Interface");
           
        }
	}
}
