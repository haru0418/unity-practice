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
        
        for (int r=0; r<=20; r++)
        {
            if (r%2 != 0)
            {
                continue;
            }
            Debug.Log(r);
        }
        

        //配列
        //宣言、代入、長さ取得
        //for文との兼ね合い

        
        int x1 = 0;
        int x2 = 2;
        int x3 = 3;
        

        int[] xList = new int[3]; //宣言パターン１
        xList[0] = 0; //代入
        xList[1] = 1;
        xList[2] = 2;
        

        int[] xList = new int[3] {0, 2, 3};

        //取得
        Debug.Log(xList[0]);
        Debug.Log(xList[1]);
        Debug.Log(xList[2]);
        

        //長さの取得（要素の数）
        Debug.Log(xList.Length);

        //for文との連携
        for (int i = 0; i < xList.Length; i++)
        {
            Debug.Log(xList[i]);
        }
        */

        int[] yList = new int[31];

        for (int i=0; i<31; i++)
        {
            yList[i] = i;
        }

        for (int i=0; i<yList.Length; i++)
        {
            Debug.Log(yList[i]);
        }
        
    }

    void Update()
    {
        //string say;
        //say = "ガヤ";
        //Debug.Log(say);
    }
}
