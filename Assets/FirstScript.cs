using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstScript : MonoBehaviour
{
    void Start()
    {
        /*
        string say = "ガヤ";　// 宣言と代入
        Debug.Log(say);

        const string sayConst = "hahaha";
        Debug.Log(sayConst);

        int x = 100;
        string xString = "100";
        int y = 23;
        string yString = "23";

        Debug.Log(x + y);
        Debug.Log(xString + yString);
        
        // ifの条件式
        int hp = 99;

        if (hp%3 == 1)
        {
            Debug.Log("あまりが１です");
        }
        else if (hp%3 == 2)
        {
            Debug.Log("あまりが２です");
        }
        else
        {
            Debug.Log("あまりが０です");
        }
        */

        //switch文

        string characterType = "Player";

        switch (characterType)
        {
            case "Player":
            case "Friends":
            Debug.Log("味方");
            break;
            case "Enemy":
            Debug.Log("敵");
            break;
            default:
            Debug.Log("その他");
            break;
        }
    }

    void Update()
    {
        //string say;
        //say = "ガヤ";
        //Debug.Log(say);
    }
}
