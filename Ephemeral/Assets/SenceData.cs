using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;

public class SenceData : MonoBehaviour
{


    void Start()
    {//初始化场景
        //Cube信息的初始化
        SaveCube sc = gameObject.GetComponent<SaveCube>();
        sc.Load();


        //末尾设置默认不读挡
        GameObject gameDataManager = GameObject.Find("GameDataManager");
        GameDataManager g = gameDataManager.GetComponent<GameDataManager>();
        g.gameData.isDu = false;
        g.Save();
    }
    public void Save()
    {//存档数据
        //Cube信息的保存
        SaveCube sc = gameObject.GetComponent<SaveCube>();
        sc.Save();


    }
}