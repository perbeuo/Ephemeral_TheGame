using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class read : MonoBehaviour {

    private GameDataManager g;//定义GameDataManager(游戏控制器）脚本
    private SenceData s;//定义SenceData（场景加载器）脚本

    public int senceNum;

    // Use this for initialization
    void Start () {
        GameObject gameDataManager = GameObject.Find("GameDataManager");//获得GameDataManager(游戏控制器）对象
        g = gameDataManager.GetComponent<GameDataManager>();//获得GameDataManager(游戏控制器）脚本
        GameObject senceData = GameObject.Find("SenceData");//获得SenceData（场景加载器）对象
        s = senceData.GetComponent<SenceData>();//获得SenceData（场景加载器）脚本

    }
	
	// Update is called once per frame
	public void OnClick () {
        g.gameData.isDu = true;//设置为可读档状态
        g.Save();//日志保存为可读档状态

        UnityEngine.SceneManagement.SceneManager.LoadScene(senceNum);//加载场景

    }
}
