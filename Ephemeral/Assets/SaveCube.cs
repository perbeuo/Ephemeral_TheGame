using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;



public class SaveCube : MonoBehaviour
{
    public ItemBox itembox;
    public void Save()
    {//保存Cube的部分数据，这里保存Cube的位置信息

        GameObject cube = GameObject.Find("FPSController");//获得人物对象
        GameObject cube1 = GameObject.Find("Cube");//获得物体对象
        GameObject cube2 = GameObject.Find("Cube (1)");//获得物体对象

        GameObject gameDataManager = GameObject.Find("GameDataManager");//获得GameDataManager(游戏控制器）对象
        GameDataManager g = gameDataManager.GetComponent<GameDataManager>();//获得GameDataManager(游戏控制器）脚本

        g.gameData.s.cubePosion = cube.transform.position;//保存Cube的位置


        Debug.Log(cube1);

        if (cube1!=null)
        {
            g.gameData.s.i = 1;
            Debug.Log(g.gameData.s.i);
        }
        else
        {
            g.gameData.s.i = 0;
            Debug.Log(g.gameData.s.i);
        }

        if (cube2 != null)
        {
            g.gameData.s.i1 = 1;
           
        }
        else
        {
            g.gameData.s.i1 = 0;
            
        }


    }

    
    public void Load()
    {//场景开始时加载游戏对象

        GameObject cube = GameObject.Find("FPSController");//获得人物对象
        GameObject cube1 = GameObject.Find("Cube");//获得物体对象
        GameObject cube2 = GameObject.Find("Cube (1)");//获得物体对象

        GameObject gameDataManager = GameObject.Find("GameDataManager");//获得GameDataManager(游戏控制器）对象
        GameDataManager g = gameDataManager.GetComponent<GameDataManager>();//获得GameDataManager(游戏控制器）脚本

        if (g.gameData.isDu == true)
        {//如果是读档状态
            cube.transform.position = g.gameData.s.cubePosion;//读取人物的位置，并赋值给人物
          
           
            if(g.gameData.s.i!=1)//如果存档时物体不存在.读档是设置消失
            {
                cube1.SetActive(false);
                itembox.setobjnumber(1);
            }

            if (g.gameData.s.i1 != 1)//如果存档时物体不存在.读档是设置消失
            {
                cube2.SetActive(false);
                itembox.setobjnumber(2);              
            }

        }
    }

}