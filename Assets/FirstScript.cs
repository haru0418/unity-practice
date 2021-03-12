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
        

        int[] yList = new int[31];

        for (int i=0; i<31; i++)
        {
            yList[i] = i;
        }

        for (int i=0; i<yList.Length; i++)
        {
            Debug.Log(yList[i]);
        }
        


        //List
        //宣言、代入、取得、長さの取得、追加、削除
        //for文との兼ね合い
        //foreach

        List<int> numbers = new List<int>() { -1, 21, 23 };
        Debug.Log(numbers[0]);
        Debug.Log(numbers[1]);
        Debug.Log(numbers[2]);

        numbers[1] = 0;
        Debug.Log(numbers[1]);

        // 追加
        numbers.Add(100);
        Debug.Log(numbers[3]);
        Debug.Log(numbers.Count);

        // 削除
        numbers.RemoveAt(3);
        Debug.Log(numbers.Count);
        numbers.Remove(-1);
        Debug.Log(numbers.Count);

        // for文
        for (int i = 0; i < numbers.Count; i++)
        {
            Debug.Log(numbers[i]);
        }
        // 1-9までのListを作りたい
        List<int> numberList = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numberList.Add(i);
        }
        for (int i = 0; i < numberList.Count; i++)
        {
            Debug.Log(numberList[i]);
        }
        List<string> nameList = new List<string>() { "太郎", "田中", "鈴木" };
        foreach (string Name in nameList)
        {
            Debug.Log(Name);
        }

        //練習
        List<int> numbers = new List<int>();
        for ( int i=0; i<100; i++)
        {
            if (i%3 == 0)
            {
                numbers.Add(i);
            }
        }

        foreach (int numder in numbers)
        {
            Debug.Log(numder);
        }
        */


        //int numder1 = NumderAddFunction(1, 100);
        //Debug.Log(numder1);

        List<int> threenumber = ThreeNumber();

        foreach (int number in threenumber)
        {
            Debug.Log(number);
        }


    }
    /*
    int NumderAddFunction(int n, int m)
    {
        int sum = 0;
        for (int i=n; i<m+1; i++)
        {
            if (i%2 == 0)
            {
                Debug.Log(i);
                sum += i;
            }
        }
        return sum;
    }
    */

    List<int> ThreeNumber()
    {
        List<int> threenumber = new List<int>();
        for (int i=1; i<=100; i++)
        {
            if (IsThreeAhoNumber(i))
            {
                threenumber.Add(i);
            }
        }
        return threenumber;
    }

    bool IsThreeAhoNumber(int number)
    {
        if (number%3 == 0)
        {
            return true;
        }
        if (number%10 == 3)
        {
            return true;
        }

        while (number != 0)
        {
            if ( number % 10 == 3)
            {
                return true;
            }
            number = number / 10;
        }
        return false;
    }
     

    void Update()
    {
        //string say;
        //say = "ガヤ";
        //Debug.Log(say);
    }
}
