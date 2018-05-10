using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour {

    public  Image[] items;
    public  int[] itemnum = new int[10];
    public int index = 0;


	// Use this for initialization
 
	void Start () {
       
	}

	// Update is called once per frame
	void Update () {
       
    }

    public void setobjnumber(int objnum)
    {
        Debug.Log(index);
        itemnum[index] = objnum;
        Texture2D aa;
        Sprite kk;
        Debug.Log(itemnum[index]);
        switch (itemnum[index])
        {

            case 1:
                aa = (Texture2D)Resources.Load("key1") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;

                break;
            case 2:
                aa = (Texture2D)Resources.Load("key2") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;
            case 3:
                aa = (Texture2D)Resources.Load("key3") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;
            case 4:
                aa = (Texture2D)Resources.Load("bag") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;
            case 5:
                aa = (Texture2D)Resources.Load("door_2") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;
            case 6:
                aa = (Texture2D)Resources.Load("door_2") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;
            case 7:
                aa = (Texture2D)Resources.Load("door_2") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;
            case 8:
                aa = (Texture2D)Resources.Load("door_2") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;
            case 9:
                aa = (Texture2D)Resources.Load("door_2") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;
            case 10:
                aa = (Texture2D)Resources.Load("door_2") as Texture2D;
                kk = Sprite.Create(aa, new Rect(0, 0, aa.width, aa.height), new Vector2(0.5f, 0.5f));
                items[index].sprite = kk;
                break;

        }
        //Additem(index);
        Debug.Log(itemnum[index]);
        index++;

    }
    
	public bool isExist(int objnum){
		for (int i = 0; i < index; i++) {
			if (itemnum [i] == objnum) {
				return true;
			}
		}
		return false;
	}


}
