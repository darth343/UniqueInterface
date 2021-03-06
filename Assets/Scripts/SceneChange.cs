﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneChange : MonoBehaviour
{
    // Button to know which scene to change to
    //public Text ButtonText;

    // Debug
    public Text DebugInfo;

    private SharedData sharedData;

    // Use this for initialization
    void Start()
    {
        var sharedGO = GameObject.Find("SharedData");
        sharedData = sharedGO.GetComponent<SharedData>();
    }

    // Update is called once per frame
    void Update()
    {
        //// If 3 finger touch
        //if (Input.touchCount == 3)
        //{
        //    //SceneManager.LoadScene("Scene2");
        //}

        //DebugInfo.text = "Prev: " + sharedData.PrevScene + '\n' + "Curr: " + sharedData.CurrScene;
        //DebugInfo.text = "Prev: " + sharedData.PrevScene + '\n' + "Curr: " + sharedData.CurrScene;
    }

    public void Change(string name)
    {
        sharedData.PrevScene = sharedData.CurrScene;
        sharedData.CurrScene = name;

        //Singleton.PrevScene = Singleton.CurrScene;
        //Singleton.CurrScene = name;

        SceneManager.LoadScene(name);
    }

    public void Back(string name)
    {
        string temp = sharedData.PrevScene;
        sharedData.PrevScene = sharedData.CurrScene;
        sharedData.CurrScene = temp;

        //string temp = Singleton.PrevScene;
        //Singleton.PrevScene = Singleton.CurrScene;
        //Singleton.CurrScene = temp;

        SceneManager.LoadScene(temp);
    }
}
