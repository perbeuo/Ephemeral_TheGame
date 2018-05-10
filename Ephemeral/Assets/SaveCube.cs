using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;



public class SaveCube : MonoBehaviour
{
    public ItemBox itembox;
    Vector3 v2 = new Vector3(0, -90, 0);
    public void Save()
    {//保存Cube的部分数据，这里保存Cube的位置信息

        GameObject cube = GameObject.Find("FPSController");//获得人物对象
        GameObject cube1 = GameObject.Find("Cube");//获得物体对象
        GameObject cube2 = GameObject.Find("Cube (1)");//获得物体对象

        GameObject key1 = GameObject.Find("key");//获得物体对象
        GameObject key2 = GameObject.Find("key (1)");//获得物体对象
        GameObject key3 = GameObject.Find("key (2)");//获得物体对象

        GameObject sel = GameObject.Find("select");//获得人物对象
        GameObject se2 = GameObject.Find("select（1）");//获得人物对象
        GameObject se3 = GameObject.Find("select（2）");//获得人物对象

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

        if (cube2 != null){g.gameData.s.i1 = 1;}
        else{g.gameData.s.i1 = 0;}

        if (key1 != null) { g.gameData.s.key1 = 1; }
        else { g.gameData.s.key1 = 0; }

        if (key2 != null) { g.gameData.s.key2 = 1; }
        else { g.gameData.s.key2 = 0; }

        if (key3 != null) { g.gameData.s.key3 = 1; }
        else { g.gameData.s.key3 = 0; }

        if (sel != null) { g.gameData.s.sel1 = 1; }
        else { g.gameData.s.sel1 = 0; }

        
    }

    
    public void Load()
    {//场景开始时加载游戏对象

        GameObject cube = GameObject.Find("FPSController");//获得人物对象
        GameObject cube1 = GameObject.Find("Cube");//获得物体对象
        GameObject cube2 = GameObject.Find("Cube (1)");//获得物体对象

        GameObject key1 = GameObject.Find("key");//获得物体对象
        GameObject key2 = GameObject.Find("key (1)");//获得物体对象
        GameObject key3 = GameObject.Find("key (2)");//获得物体对象

        GameObject sel = GameObject.Find("select");//获得人物对象
        GameObject se2 = GameObject.Find("select（1）");//获得人物对象
        GameObject se3 = GameObject.Find("select（2）");//获得人物对象

        GameObject door = GameObject.Find("doors_B");//获得人物对象


        GameObject gameDataManager = GameObject.Find("GameDataManager");//获得GameDataManager(游戏控制器）对象
        GameDataManager g = gameDataManager.GetComponent<GameDataManager>();//获得GameDataManager(游戏控制器）脚本

        if (g.gameData.isDu == true)
        {//如果是读档状态
            cube.transform.position = g.gameData.s.cubePosion;//读取人物的位置，并赋值给人物

            if (g.gameData.s.sel1 != 1)//如果存档时物体不存在.读档是设置消失
            {
                Vector3 v2 = new Vector3(0, -90, 0);
                door.transform.Rotate(v2);
                sel.SetActive(false);
            }


            if (g.gameData.s.i!=1)//如果存档时物体不存在.读档是设置消失
            {
                cube1.SetActive(false);
                itembox.setobjnumber(1);
            }

            if (g.gameData.s.key1 != 1)//如果存档时物体不存在.读档是设置消失
            {
                key1.SetActive(false);
                itembox.setobjnumber(1);
            }

            if (g.gameData.s.key2 != 1)//如果存档时物体不存在.读档是设置消失
            {
                key2.SetActive(false);
                itembox.setobjnumber(2);
            }

            if (g.gameData.s.key3 != 1)//如果存档时物体不存在.读档是设置消失
            {
                key3.SetActive(false);
                itembox.setobjnumber(3);
            }



        }
    }

}