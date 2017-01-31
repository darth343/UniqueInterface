using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SettingsManager : MonoBehaviour {

    private SharedData sharedData;
    GameObject[] settingGOList;

    // Info for saving settings to SharedData
    private string GraphicalLevel = "wronmg";
    private bool IsPowerSaver = false;

    private int SoundLevel;
    private int MusicLevel;

    private bool IsNotification = false;
    private bool IsInvert = false;
    private bool IsVibrate = false;

    public Text debug;

	// Use this for initialization
	void Start () {
        
        // Get a handle to the setting objects then set them to inactive
        settingGOList = GameObject.FindGameObjectsWithTag("Settings");
        foreach (GameObject it in settingGOList)
        {
            it.SetActive(false);
        }

        // Find SharedData Object
        var sharedGO = GameObject.Find("SharedData");
        sharedData = sharedGO.GetComponent<SharedData>();

        // Sync settings with SharedData
        GraphicalLevel = sharedData.GetInstance().GraphicalLevel;
        debug.text = GraphicalLevel;

        if (GraphicalLevel == "Low")
        {
            GameObject.Find("LowToggle").GetComponent<Toggle>().isOn = true;
            GameObject.Find("MedToggle").GetComponent<Toggle>().isOn = false;
            GameObject.Find("HighToggle").GetComponent<Toggle>().isOn = false;
        }
        else if (GraphicalLevel == "Med")
        {
            GameObject.Find("LowToggle").GetComponent<Toggle>().isOn = false;
            GameObject.Find("MedToggle").GetComponent<Toggle>().isOn = true;
            GameObject.Find("HighToggle").GetComponent<Toggle>().isOn = false;
        }
        else if (GraphicalLevel == "High")
        {
            GameObject.Find("LowToggle").GetComponent<Toggle>().isOn = false;
            GameObject.Find("MedToggle").GetComponent<Toggle>().isOn = false;
            GameObject.Find("HighToggle").GetComponent<Toggle>().isOn = true;
        }


        IsPowerSaver = sharedData.GetInstance().IsPowerSaver;
        GameObject.Find("PowerToggle").GetComponent<Toggle>().isOn = IsPowerSaver;

        SoundLevel = sharedData.GetInstance().SoundLevel;
        GameObject.Find("SoundSlider").GetComponent<Slider>().value = SoundLevel;
        
        MusicLevel = sharedData.GetInstance().MusicLevel;
        GameObject.Find("MusicSlider").GetComponent<Slider>().value = MusicLevel;

        IsNotification = sharedData.GetInstance().IsNotification;
        GameObject.Find("NotificationToggle").GetComponent<Toggle>().isOn = IsNotification;

        IsInvert = sharedData.GetInstance().IsInvert;
        GameObject.Find("InvertToggle").GetComponent<Toggle>().isOn = IsInvert;

        IsVibrate = sharedData.GetInstance().IsVibrate;
        GameObject.Find("VibrateToggle").GetComponent<Toggle>().isOn = IsVibrate;
	}
	
	// Update is called once per frame
	void Update () {

        // Sync settings with SharedData
        GraphicalLevel = sharedData.GetInstance().GraphicalLevel;
        debug.text = GraphicalLevel;

        if (GraphicalLevel == "Low")
        {
            GameObject.Find("LowToggle").GetComponent<Toggle>().isOn = true;
            GameObject.Find("MedToggle").GetComponent<Toggle>().isOn = false;
            GameObject.Find("HighToggle").GetComponent<Toggle>().isOn = false;
        }
        else if (GraphicalLevel == "Med")
        {
            GameObject.Find("LowToggle").GetComponent<Toggle>().isOn = false;
            GameObject.Find("MedToggle").GetComponent<Toggle>().isOn = true;
            GameObject.Find("HighToggle").GetComponent<Toggle>().isOn = false;
        }
        else if (GraphicalLevel == "High")
        {
            GameObject.Find("LowToggle").GetComponent<Toggle>().isOn = false;
            GameObject.Find("MedToggle").GetComponent<Toggle>().isOn = false;
            GameObject.Find("HighToggle").GetComponent<Toggle>().isOn = true;
        }


        IsPowerSaver = sharedData.GetInstance().IsPowerSaver;
        GameObject.Find("PowerToggle").GetComponent<Toggle>().isOn = IsPowerSaver;

        SoundLevel = sharedData.GetInstance().SoundLevel;
        GameObject.Find("SoundSlider").GetComponent<Slider>().value = SoundLevel;

        MusicLevel = sharedData.GetInstance().MusicLevel;
        GameObject.Find("MusicSlider").GetComponent<Slider>().value = MusicLevel;

        IsNotification = sharedData.GetInstance().IsNotification;
        GameObject.Find("NotificationToggle").GetComponent<Toggle>().isOn = IsNotification;

        IsInvert = sharedData.GetInstance().IsInvert;
        GameObject.Find("InvertToggle").GetComponent<Toggle>().isOn = IsInvert;

        IsVibrate = sharedData.GetInstance().IsVibrate;
        GameObject.Find("VibrateToggle").GetComponent<Toggle>().isOn = IsVibrate;

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

    public void SetGraphicalLevel(string level)
    {
        GraphicalLevel = level;
        sharedData.GetInstance().GraphicalLevel = GraphicalLevel;
    }

    public void SetPowerSaver(bool mode)
    {
        IsPowerSaver = !IsPowerSaver;
        sharedData.GetInstance().IsPowerSaver = IsPowerSaver;
    }

    public void SetSoundLevel(int level)
    {
        SoundLevel = (int) GameObject.Find("SoundSlider").GetComponent<Slider>().value;
        sharedData.GetInstance().SoundLevel = SoundLevel;
    }

    public void SetMusicLevel(int level)
    {
        MusicLevel = (int)GameObject.Find("MusicSlider").GetComponent<Slider>().value;
        sharedData.GetInstance().MusicLevel = MusicLevel;
    }

    public void SetNotifications(bool mode)
    {
        IsNotification = !IsNotification;
        sharedData.GetInstance().IsNotification = IsNotification;
    }

    public void SetInvert(bool mode)
    {
        IsInvert = !IsInvert;
        sharedData.GetInstance().IsInvert = IsInvert;
    }

    public void SetVibrate(bool mode)
    {
        IsVibrate = !IsVibrate;
        sharedData.GetInstance().IsVibrate = IsVibrate;
    }

    public void SaveSettings(bool save)
    {
    }
}
