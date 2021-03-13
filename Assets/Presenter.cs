using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Presenter : MonoBehaviour
{
    [SerializeField] GameObject image;
    public void OnClockButton()
    {

        Debug.Log("ボタンが押された");
        //SceneManager.LoadScene("Main");

        //objectの非表示
        //image.SetActive(false);

        //obkectの破壊
        Destroy(image);
    }

    void Start()
    {
        
    }

    
}
