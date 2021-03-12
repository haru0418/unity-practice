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
        

        //switch文 //特定できるものに使う（Playerなど）

        string characterType = "Player";

        switch (characterType) //代入された値を探す
        {
            case "Player":
            case "Friends":
            Debug.Log("味方");
            break;
            case "Enemy":
            Debug.Log("敵");
            break;
            default:           //なければdefaultが出力される
            Debug.Log("その他");
            break;
        }
        

        // 繰り返し処理
        // while
        int x = 0;
        while (x < 10)
        {
            Debug.Log(x);
            x++;
        }
        
        //for
        //continue：次の処理を行う
        //break:処理を抜ける
        for (int i=0; i<10; i++)
        {
            if (i == 7)
            {
                break;
            }

            if(i == 3)
            {
                continue;
            }
            Debug.Log(i);
        }
        */
        for (int r=0; r<=20; r++)
        {
            if (r%2 != 0)
            {
                continue;
            }
            Debug.Log(r);
        }
    }

    void Update()
    {
        //string say;
        //say = "ガヤ";
        //Debug.Log(say);
    }
}
