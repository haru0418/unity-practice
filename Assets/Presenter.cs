using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Presenter : MonoBehaviour
{
    //[SerializeField] GameObject image;
    //[SerializeField] TestScript testscript;
    [SerializeField] Text textscropt;
    public void OnClockButton()
    {

        Debug.Log("ボタンが押された");
        //SceneManager.LoadScene("Main");

        //objectの非表示
        //image.SetActive(false);

        //obkectの破壊
        //Destroy(image);
        //testscript.TestScriptText();
        textscropt.text = "haruyuki";
    }

    void Start()
    {
        
    }

    
}
