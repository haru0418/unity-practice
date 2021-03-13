using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Presenter : MonoBehaviour
{
    //[SerializeField] GameObject image;
    //[SerializeField] TestScript testscript;
    //[SerializeField] Text textscropt;
    public void OnClockButton()
    {

        //Debug.Log("ボタンが押された");
        //SceneManager.LoadScene("Main");

        //objectの非表示
        //image.SetActive(false);

        //obkectの破壊
        //Destroy(image);
        //testscript.TestScriptText();
        //textscropt.text = "haruyuki";
    }

    //[SerializeField] GameObject imagePrefab;
    //[SerializeField] Transform parent;
    void Start()
    {
        //オブジェクトの生成
        //GameObject image = Instantiate(imagePrefab);

        //親要素の変更
        //image.transform.SetParent(parent);

        //saveの仕方（文字列の場合）
        /*
        string xx = "saveデータ";
        PlayerPrefs.SetString("DATA", xx);
        PlayerPrefs.Save();
        */

        //string saveText = PlayerPrefs.GetString("DATA");
        //Debug.Log(saveText);

        PlayerModels player = new PlayerModels();
        string JsonPlayer = JsonUtility.ToJson(player);
        Debug.Log(JsonPlayer);
    }
}

[Serializable]
public class PlayerModels
{
    [SerializeField]    
    int hp;
    [SerializeField]
    int at;
    [SerializeField]
    int currentStage;
}

    

