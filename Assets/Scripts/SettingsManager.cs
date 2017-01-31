using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SettingsManager : MonoBehaviour {

    private SharedData sharedData;
    GameObject[] settingGOList;

    public Text debug;

	// Use this for initialization
	void Start () {
        settingGOList = GameObject.FindGameObjectsWithTag("Settings");
        foreach (GameObject it in settingGOList)
        {
            it.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetActiveSetting(string settingName)
    {
        string checkStr = "";

        switch (settingName)
        {
            case "Video":
                    checkStr = "VideoCanvas";
                break;

            case "Sound":
                    checkStr = "SoundCanvas";
                break;

            case "Game":
                    checkStr = "GameCanvas";
                break;
        }

        foreach (GameObject it in settingGOList)
        {
            if (it.name == checkStr || it.name == "SettingMenu" || it.name == "SettingsHeadCanvas")
            {
                it.SetActive(true);
            }
            else
            {
                it.SetActive(false);
            }
        }
    }
}
